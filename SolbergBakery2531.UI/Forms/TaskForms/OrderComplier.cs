using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using SolbergBakery2531.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using SolbergBakery2531.BLL.DTOModels;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms
{
    public partial class OrderComplier : Form
    {
        private readonly ProductService _service = new ProductService();
        private readonly OrderService _orvice = new OrderService();
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
            OrderGrid.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == OrderGrid.Columns["QuantityCol"].Index && e.RowIndex >= 0)
                {
                    OrderGrid.BeginEdit(true);
                }
            };
            removeWarnLab.ForeColor = System.Drawing.Color.Black;
        }
        private void OrderGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (OrderGrid.Columns[e.ColumnIndex].Name == "QuantityCol")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int newQty))
                {
                    _ = UIUtils.ShowToast("Please enter a valid number.", "Compiler", 1000);
                    e.Cancel = true;
                    return;
                }

                var limitValue = OrderGrid.Rows[e.RowIndex].Cells["StockLimitCol"].Value;
                int stockLimit = limitValue != null ? Convert.ToInt32(limitValue) : 0;

                // BLL
                if (!_orvice.ValidateQuantity(newQty, stockLimit, out string error))
                {
                    _ = UIUtils.ShowToast(error, "Compiler", 1000);
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
        private void Card_Click(object sender, EventArgs e)
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
                            _ = UIUtils.ShowToast($"Cannot add more than {stockLimit} items for {_selectedCard.ProductName}.", "Compiler", 1000);
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
        private async void complieBtn_Click(object sender, EventArgs e)
        {
            if (OrderGrid.Rows.Count == 0) return;

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var orderData = new List<OrderItemDTO>();
                    foreach (DataGridViewRow row in OrderGrid.Rows)
                    {
                        orderData.Add(new OrderItemDTO
                        {
                            ProductId = (Guid)row.Cells["GUIDCol"].Value,
                            Name = row.Cells["NameCol"].Value.ToString(),
                            Price = Convert.ToDecimal(row.Cells["PricingCol"].Value),
                            Quantity = Convert.ToInt32(row.Cells["QuantityCol"].Value)
                        });
                    }
                    await _orvice.ExportOrderToPdf(sfd.FileName, orderData);
                    bool success = _orvice.RunPurchase(orderData);
                    if (success)
                    {
                        _ = UIUtils.ShowToast("PDF Generated!", "Success", 1000);
                        OrderGrid.Rows.Clear();
                    }
                }
            }
        }

        private void revBtn_Click(object sender, EventArgs e)
        {
            DataRow dataRow = OrderGrid.GetSelectedRow();
            if (dataRow != null)
            {
                removeWarnLab.Text = "This item is already drafted via source bonding (for debuging reason) and cannot be removed.";
                removeWarnLab.ForeColor = System.Drawing.Color.Maroon;
                return;
            }
            DataGridViewRow gridRow = OrderGrid.GetSelectedGridRow();
            if (gridRow == null)
            {
                removeWarnLab.Text = "Pick a drafted item to remove it from the drafting bill";
                removeWarnLab.ForeColor = System.Drawing.Color.Maroon;
                return;
            }
            OrderGrid.Rows.Remove(gridRow);

            removeWarnLab.Text = "Undrafted item.";
            removeWarnLab.ForeColor = System.Drawing.Color.Green;
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            OrderGrid.Rows.Clear();
            removeWarnLab.Text = "Undrafted Bill.";
            removeWarnLab.ForeColor = System.Drawing.Color.Green;
        }
    }
}
