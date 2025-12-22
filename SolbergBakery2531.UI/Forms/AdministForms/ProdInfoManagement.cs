using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms.AdministForms
{
    public partial class ProdInfoManagement : Form
    {
        private readonly ProductService _proderve;
        private DataTable _fullDataTable;
        private readonly DashBoard _parent;
        public ProdInfoManagement(DashBoard Parent)
        {
            InitializeComponent();
            _proderve = new ProductService();
            _parent = Parent;

            SetupfilterBoxes();
            SetupComboBoxes();
            LoadProdDataAsync();
            ProdGrid.SelectionChanged += ProdGrid_SelectionChanged;
            VisualListView.SelectionChanged += VisualListView_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        }
        private void LoadProdDataAsync()
        {
            _ = UIUtils.ShowToast("Loading...", "SolbergBakery", 1000);
            try
            {
                ProdGrid.AutoGenerateColumns = false;
                _fullDataTable = _proderve.Fetch();
                ProdGrid.DataSource = _fullDataTable;

                ProdGrid.ClearSelection();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProdVisualAsync(Guid productId)
        {
            _ = UIUtils.ShowToast("Loading...Visual", "SolbergBakery", 500);
            try
            {
                VisualListView.AutoGenerateColumns = false;
                VisualListView.DataSource = _proderve.FetchVisual(productId); ;

                VisualListView.ClearSelection();
                VisualListView.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading visual data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualListView_SelectionChanged(object sender, EventArgs e)
        {
            DataRow dataRow = VisualListView.GetSelectedRow();
            if (dataRow == null)
            {
                VisualDisplay.Image = null;
                return;
            }
            byte[] imgBytes = (byte[])dataRow["VisualinByte"];
            using (var ms = new System.IO.MemoryStream(imgBytes))
            {
                //VisualDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                VisualDisplay.Image = Image.FromStream(ms);
            }
        }
        private void ProdGrid_SelectionChanged(object sender, EventArgs e)
        {
            _parent.resetProgress();
            DataRow dataRow = ProdGrid.GetSelectedRow();
            if (dataRow == null)
            {
                ClearInputs();
                return;
            }
            _parent.UpdateProgress(25);
            DesText.Text = dataRow["Description"].ToString();
            NoteText.Text = dataRow["Note"].ToString();
            PriceText.Text = dataRow["Pricing"].ToString();
            ADateText.Text = dataRow["AvailableDate"].ToString();
            DDateText.Text = dataRow["DiscontinueDate"].ToString();
            NameText.Text = dataRow["Name"].ToString();
            CateComboBox.SelectedValue = dataRow["ProdCategoryId"];

            _parent.UpdateProgress(25);
            LoadProdVisualAsync((Guid)dataRow["Id"]);
            _parent.endProgress();
        }
        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        
        private void SetupfilterBoxes()
        {
            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "Description", "Note", "AvailableDate", "DiscontinueDate", "Pricing" });
                collumBox.SelectedIndex = 0;
            }
        }
        private void SetupComboBoxes()
        {
            CateComboBox.Items.Clear();
            var categories = _proderve.FetchCate();
            CateComboBox.DataSource = categories;
            CateComboBox.DisplayMember = "EngName"; //show
            CateComboBox.ValueMember = "Id"; //hidden
        }

        private void ApplyFilter()
        {
            _parent.resetProgress();
            _ = UIUtils.ShowToast("Updating...", "SolbergBakery", 1000);
            string filterColumn = collumBox.SelectedItem.ToString();
            string filterValue = valueBox.Text.Trim();
            _parent.UpdateProgress(50);

            _fullDataTable.DefaultView.RowFilter =
                BLLUtils.GetFilteredView(filterColumn, filterValue);
            
            _parent.endProgress();
        }
        private bool ValidateInputs()
        {
            string res = _proderve.ValidateInputs(NameText.Text, DesText.Text, NoteText.Text, PriceText.Text,ADateText.Value, DDateText.Value);

            svWarnLab.Text = res;
            return string.IsNullOrEmpty(res);
        }
        private void ClearInputs()
        {
            DesText.Clear();
            NoteText.Clear();
            PriceText.Clear();
            ADateText.Refresh();
            DDateText.Refresh();
            NameText.Clear();

            if (VisualListView.DataSource is DataTable dt)
            {
                dt.Clear();
            }
            else
            {
                VisualListView.DataSource = null;
            }
            VisualDisplay.Image = null;
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            if (!ValidateInputs()) return;

            DataRow dataRow = ProdGrid.GetSelectedRow();
            bool isNew = (dataRow == null);

            Guid currId = isNew? Guid.NewGuid() : (Guid)dataRow["Id"];

            string name = NameText.Text.Trim();
            string des = DesText.Text.Trim();
            string note = NoteText.Text.Trim();
            decimal price = decimal.Parse(PriceText.Text);
            DateTime ADate = DateTime.Parse(ADateText.Text);
            DateTime DDate = DateTime.Parse(DDateText.Text);
            Guid CateId = (Guid)CateComboBox.SelectedValue;
            try
            {
                bool success = _proderve.SaveProd(
                  currId,
                  name,
                  des,
                  note,
                  price,
                  ADate,
                  DDate,
                  CateId
                );

                if (success)
                {
                    svWarnLab.Text = (isNew ? "New Product record created successfully!" : "Product record updated successfully!");
                    svWarnLab.ForeColor = Color.Green;
                    LoadProdDataAsync();
                }
                else
                {
                    svWarnLab.Text = "Failed to save Product. error occurred.";
                    svWarnLab.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                svWarnLab.Text = $"An error occurred during save: {ex.Message}";
                svWarnLab.ForeColor = Color.Red;
            }

            _parent.endProgress();
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            if (ProdGrid.SelectedRows.Count == 0)
            {
                svWarnLab.Text = "Please select an existing Product to delete.";
                return;
            }
            DataRow dataRow = ProdGrid.GetSelectedRow();
            if (Guid.TryParse(dataRow["Id"].ToString(), out Guid prodGuid))
            {
                DialogResult dialogResult = MessageBox.Show(
                  "Are you sure you want to delete this Product? This action cannot be undone.",
                  "Confirm Deletion",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        bool success = _proderve.DelProd(prodGuid);
                        if (success)
                        {
                            svWarnLab.Text = "Product record deleted successfully.";
                            svWarnLab.ForeColor = Color.Green;
                            LoadProdDataAsync();
                        }
                        else
                        {
                            svWarnLab.Text = "Deletion failed. Product GUID not found.";
                            svWarnLab.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        svWarnLab.Text = $"An error occurred during deletion: {ex.Message}";
                        svWarnLab.ForeColor = Color.Red;
                    }
                }
            }
            _parent.endProgress();
        }
        private void addVbtn_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ProdGrid.GetSelectedRow();
            if (dataRow == null)
            {
                _ = UIUtils.ShowToast("Please pick an existing product before injecting visuals...", "SolbergBakery", 500);
                return;
            }

            _parent.resetProgress();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Product Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            byte[] imgBytes;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Image img = Image.FromFile(selectedFilePath);

                imgBytes = UIUtils.ImageToByteArray(img);
                VisualDisplay.Image = img;

                _parent.UpdateProgress(50);

                try
                {
                    bool sucess = _proderve.SaveProdVisual(imgBytes, (Guid)dataRow["Id"]);
                    if (sucess)
                        LoadProdVisualAsync((Guid)dataRow["Id"]);
                    else
                        MessageBox.Show("Visual without associated product in db.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving visual data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _parent.endProgress();
            }
        }
        private void delVbtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            DataRow dataRow = VisualListView.GetSelectedRow();
            DataRow PdataRow = ProdGrid.GetSelectedRow();
            if (dataRow == null)
            {
                _ = UIUtils.ShowToast("Nothing to remove...", "SolbergBakery", 500);
                _ = UIUtils.ShowToast("Pick a Visual", "SolbergBakery", 500);
                return;
            }
            try
            {
                bool success = _proderve.DelProdVisual((Guid)dataRow["Id"]);
                if (success)
                    LoadProdVisualAsync((Guid)PdataRow["Id"]);
                    VisualDisplay.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting visual data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadProdVisualAsync((Guid)dataRow["Id"]);
            _parent.endProgress();
        }
    }
}
