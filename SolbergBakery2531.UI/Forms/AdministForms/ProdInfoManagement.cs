using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms.AdministForms
{
    public partial class ProdInfoManagement : Form
    {
        private readonly ProductService _proderve;
        private DataTable _fullDataTable;
        private DashBoard _parent;
        public ProdInfoManagement(DashBoard Parent)
        {
            InitializeComponent();
            _proderve = new ProductService();
            _parent = Parent;

            SetupfilterBoxes();
            LoadProdDataAsync();
            ProdGrid.SelectionChanged += ProdGrid_SelectionChanged;
            VisualListView.SelectionChanged += VisualListView_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        }
        private async void LoadProdDataAsync()
        {
            await UIUtils.ShowToast("Loading...", "SolbergBakery", 1000);
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
        private async void LoadProdVisualAsync()
        {
            await UIUtils.ShowToast("Loading...Visual", "SolbergBakery", 500);
            try
            {
                VisualListView.AutoGenerateColumns = false;
                VisualListView.DataSource = _proderve.FetchVisual(); ;

                VisualListView.ClearSelection();
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

            _parent.UpdateProgress(25);
            LoadProdVisualAsync();
            _parent.endProgress();
        }
        private void SetupfilterBoxes()
        {
            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "Description", "Note", "AvailableDate", "DiscontinueDate", "Pricing" });
                collumBox.SelectedIndex = 0;
            }
        }
        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private async void ApplyFilter()
        {
            _parent.resetProgress();
            await UIUtils.ShowToast("Updating...", "SolbergBakery", 1000);
            string filterColumn = collumBox.SelectedItem.ToString();
            string filterValue = valueBox.Text.Trim();
            _parent.UpdateProgress(50);
            _proderve.GetFilteredProd(_fullDataTable, filterColumn, filterValue);
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
            VisualListView.Rows.Clear();
        }
        private void svBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            _parent.UpdateProgress(50);
            _parent.endProgress();
            ValidateInputs(); //HERE
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            _parent.UpdateProgress(50);
            _parent.endProgress();
            //HERE
        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            //Open the file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Product Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                VisualDisplay.Image = Image.FromFile(selectedFilePath);
                MessageBox.Show("Selected: " + selectedFilePath);
            }
        }
    }
}
