using SolbergBakery2531._utils;
using SolbergBakery2531.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace SolbergBakery2531.UI.Forms.AdministForms
{
    public partial class EmploymentHistory : Form
    {
        private readonly StaffService _staffService;
        private readonly Guid _Id;
        private DataTable _fullDataTable;
        public EmploymentHistory(Guid Id, String fullname)
        {
            _staffService = new StaffService();
            _Id = Id;
            InitializeComponent();

            LoadHistoryAsync();

            viewGroup.Text = $"Employment History - Staff: {fullname}";
            historyView.SelectionChanged += History_SelectionChanged;
        }
        private async void LoadHistoryAsync()
        {
            await UIUtils.ShowToast("Loading...", "SolbergBakery", 1000);

            try
            {
                historyView.AutoGenerateColumns = false;
                _fullDataTable = _staffService.HistoryFetch(_Id);
                historyView.DataSource = _fullDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            HRFeedbackText.Clear();
        }
        private void History_SelectionChanged(object sender, EventArgs e)
        {
            DataRow dataRow = historyView.GetSelectedRow();
            if (dataRow == null)
            {
                ClearInputs();
                return;
            }

            HRFeedbackText.Text = _fullDataTable.Rows[historyView.SelectedRows[0].Index]["FeedBack"].ToString();
        }
        private void rtnBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void svBtn_ClickAsync (object sender, EventArgs e)
        {
            DataRow dataRow = historyView.GetSelectedRow();
            if (dataRow == null)
            {
                await UIUtils.ShowToast("Oldrecords are Immutable! Ongoing record in the otherhand...", "Historian", 2000);
                return;
            }
            await UIUtils.ShowToast("Updating current feedback...", "Historian", 2000);
            _staffService.SaveHistory(_Id, HRFeedbackText.Text);
            LoadHistoryAsync();
        }
    }
}
