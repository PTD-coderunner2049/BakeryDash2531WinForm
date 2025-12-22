using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using SolbergBakery2531.UI.UserControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms.AdministForms
{
    public partial class InventoryReconcilier : Form
    {
        private ProductService _service = new ProductService();
        private ProdCardControl _selectedCard = null;

        public InventoryReconcilier()
        {
            InitializeComponent();
            InventoryReconcilier_Load();
            ProductTreeView.AfterSelect += ProductTreeView_AfterSelect;
            QuantityToAddBar.ValueChanged += QuantityToAddBar_ValueChanged;
        }



        private void InventoryReconcilier_Load()
        {
            LoadCategories();
            QuantityflowLayoutPanel.Visible = false;
        }
        private void LoadCategories()
        {
            ProductTreeView.Nodes.Clear();
            DataTable cates = _service.FetchCate();
            foreach (DataRow row in cates.Rows)
            {
                TreeNode node = new TreeNode(row["Name"].ToString());
                node.Tag = row["Id"]; // Store Guid in Tag
                ProductTreeView.Nodes.Add(node);
            }
        }

        private void ProductTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            QuantityflowLayoutPanel.Visible = false;
            ProductFlowLayoutPanel.Controls.Clear();
            _selectedCard = null;

            if (e.Node.Tag is Guid cateId)
            {
                DataTable prods = _service.Fetch(cateId);
                foreach (DataRow row in prods.Rows)
                {
                    var card = new ProdCardControl(
                        (Guid)row["Id"],
                        row["Name"].ToString(),
                        (int)row["quantityInStock"]
                    );
                    card.Click += Card_Click;
                    ProductFlowLayoutPanel.Controls.Add(card);
                }
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            _selectedCard = sender as ProdCardControl;
            if (_selectedCard != null)
            {
                QuantityflowLayoutPanel.Visible = true;
                QuantityToAddBar.Minimum = -_selectedCard.CurrentStock;
                QuantityToAddBar.Value = 0;
                //QuantityToAddLab.Text = "0";
                currQuantityLab.Text = _selectedCard.CurrentStock.ToString();
            }
        }

        private void QuantityToAddBar_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedCard == null) return;

            int adjustment = QuantityToAddBar.Value;
            QuantityToAddLab.Text = adjustment.ToString();

            // Calculate new stock and push to DB immediately
            int newTotal = _selectedCard.CurrentStock + adjustment;
            _service.UpdateStock(_selectedCard.ProductId, newTotal);
        }
        private async void svBtn_Click(object sender, EventArgs e)
        {
            if (_selectedCard == null) return;

            int adjustment = QuantityToAddBar.Value;
            if (adjustment == 0)
            {
                await UIUtils.ShowToast("Adjustment is zero. No changes to save.", "Reconsilier", 1000);
                return;
            }

            int newTotal = _selectedCard.CurrentStock + adjustment;
            if (newTotal < 0)
            {
                await UIUtils.ShowToast("Adjustment exceeded availability, stockpile expired.", "Reconsilier", 1000);
                newTotal = 0;
            }
            _service.UpdateStock(_selectedCard.ProductId, newTotal);

            QuantityflowLayoutPanel.Visible = false;
            await UIUtils.ShowToast($"Stock for {_selectedCard.ProductName} updated to {newTotal}.", "Reconsilier", 1000);
            //refresh
            if (ProductTreeView.SelectedNode != null)
                ProductTreeView_AfterSelect(ProductTreeView, new TreeViewEventArgs(ProductTreeView.SelectedNode));
            
            _selectedCard = null;
        }
    }
}