using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using SolbergBakery2531.UI.UserControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms
{
    public partial class OrderComplier : Form
    {
        private ProductService _service = new ProductService();
        private ProdCardControl _selectedCard = null;
        public OrderComplier()
        {
            InitializeComponent();
            OrderComplier_Load();


            ProductTreeView.AfterSelect += ProductTreeView_AfterSelect;
        }
        private void OrderComplier_Load()
        {
            LoadCategories();
            OrderGrid.AllowUserToAddRows = false;
            OrderGrid.CellValidating += OrderGrid_CellValidating;
            OrderGrid.CellClick += (s, e) => {
                if (e.ColumnIndex == OrderGrid.Columns["QuantityCol"].Index && e.RowIndex >= 0)
                {
                    OrderGrid.BeginEdit(true);
                }
            };
        }
        private async void OrderGrid_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            if (OrderGrid.Columns[e.ColumnIndex].Name == "QuantityCol")
            {
                int newQty;
                if (!int.TryParse(e.FormattedValue.ToString(), out newQty))
                {
                    await UIUtils.ShowToast("Please enter a valid whole number.", "Compiler", 1000);
                    e.Cancel = true;
                    return;
                }

                int stockLimit = Convert.ToInt32(OrderGrid.Rows[e.RowIndex].Cells["StockLimitCol"].Value);
                if (newQty > stockLimit)
                {
                    await UIUtils.ShowToast($"Sorry! Only {stockLimit} items available in stock.", "Compiler", 1000);
                    e.Cancel = true;
                }
                else if (newQty < 1)
                {
                    await UIUtils.ShowToast("Quantity must be at least 1.", "Compiler", 1000);
                    e.Cancel = true;
                }
            }
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
                    card.Tag = row["Pricing"];
                    card.Click += Card_Click;
                    ProductFlowLayoutPanel.Controls.Add(card);
                }
            }
        }
        private async void Card_Click(object sender, EventArgs e)
        {
            _selectedCard = sender as ProdCardControl;
            if (_selectedCard != null)
            {
                bool exists = false;
                foreach (DataGridViewRow row in OrderGrid.Rows)
                {
                    if ((Guid)row.Cells["GUIDCol"].Value == _selectedCard.ProductId)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                        int stockLimit = _selectedCard.CurrentStock;
                        if (currentQty + 1 <= stockLimit)
                            row.Cells["QuantityCol"].Value = currentQty + 1;
                        else
                            await UIUtils.ShowToast($"Cannot add more than {stockLimit} items for {_selectedCard.ProductName}.", "Compiler", 1000);
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    OrderGrid.Rows.Add(
                        _selectedCard.ProductId,
                        _selectedCard.ProductName,
                        _selectedCard.Tag,
                        1, //Qantity coll, solo 1 for single click event
                        _selectedCard.CurrentStock
                    );
                }
            }
        }

    }
}
