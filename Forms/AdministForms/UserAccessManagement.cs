using BakeryDash.BLL;
using BakeryDash.Utils;
using BakeryDash2531._utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BakeryDash2531
{
    public partial class UserAccessManagement : Form
    {
        private readonly UserService _userve;
        private DataTable _fullDataTable;
        private DashBoard _parent;
        public UserAccessManagement(DashBoard Parent)
        {
            InitializeComponent();
            _userve = new UserService();
            _parent = Parent;

            SetupfilterBoxes();
            SetupCheckedListBoxes();

            LoadUserDataAsync();

            UserGrid.SelectionChanged += UserGrid_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        }




        private void SetupfilterBoxes()
        {
            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "Username", "Role", "Status", "Date", "User GUID", "Staff GUID" });
                collumBox.SelectedIndex = 0;
            }
        }
        private void SetupCheckedListBoxes()
        {
            UserCheckBox.MouseDown += (s, e) => {
                int index = UserCheckBox.IndexFromPoint(e.Location);
                if (index == 0) { }
            };

            UserCheckBox.ItemCheck += (s, e) => {
                if (e.Index == 0 && UserCheckBox.Focused)
                {
                    e.NewValue = e.CurrentValue;
                }
            };
        }
        private async void LoadUserDataAsync()
        {
            await UIUtils.ShowToast("Loading...", "SolbergBakery", 1000);

            try
            {
                UserGrid.AutoGenerateColumns = false;
                _fullDataTable = _userve.Fetch();
                UserGrid.DataSource = _fullDataTable;

                UserGrid.ClearSelection();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            staffGUIDText.Text = Guid.Empty.ToString();
            passText.Clear();
            usernameText.Clear();
            staffGUIDText.Clear();
            UserCheckBox.SetItemChecked(0, false);

            foreach (int i in UserCheckBox.CheckedIndices) UserCheckBox.SetItemChecked(i, false);
        }
        private void UserGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataRow dataRow = UserGrid.GetSelectedRow();
            if (dataRow == null)
            {
                ClearInputs();
                return;
            }
            //DataGridViewRow row = UserGrid.SelectedRows[0];

            //if (UserGrid.SelectedRows.Count == 0 || row == null || row.IsNewRow)
            //{
            //    ClearInputs();
            //    return;
            //}
            //DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

            staffGUIDText.Text = dataRow["Id"].ToString();
            usernameText.Text = dataRow["Username"].ToString();
            //passText.Text = dataRow["PasswordHash"].ToString();

            bool isRoleManager = (bool)dataRow["IsSystemManager"];
            bool Active = (bool)dataRow["Active"];
            UserCheckBox.SetItemChecked(0, Active);
            UserCheckBox.SetItemChecked(1, isRoleManager);
        }
        private void LoadUserxxxxxxxxxxxxxData()
        {
            _fullDataTable = _userve.Fetch();
            ApplyFilter();

            //UserGrid.Rows.Clear();
            //DataTable usersTable = _userve.Fetch();

            //foreach (DataRow rowData in usersTable.Rows)
            //{
            //    int rowIndex = UserGrid.Rows.Add();
            //    DataGridViewRow row = UserGrid.Rows[rowIndex];

            //    row.Cells["GUIDCol"].Value = rowData["UserGlobalId"].ToString().Substring(0, 8);
            //    row.Cells["UsernameCol"].Value = rowData["Username"];
            //    row.Cells["CreatedTimeCol"].Value = Convert.ToDateTime(rowData["CreatedAt"]).ToShortDateString();
            //    row.Cells["StatusCol"].Value = (bool)rowData["Active"] ? "Active" : "Inactive";
            //    row.Cells["PasswordCol"].Value = rowData["PasswordHash"];
            //    row.Cells["EmployeeGUIDCol"].Value = rowData["Id"];
            //    row.Cells["RoleCol"].Value = (bool)rowData["IsSystemManager"] ? "Manager" : "Staff";
            //}
        }
        private async void ApplyFilter()
        {
            await UIUtils.ShowToast("Updating...", "SolbergBakery", 1000);

            string filterColumn = collumBox.SelectedItem.ToString();
            string filterValue = valueBox.Text.Trim();

            _userve.GetFilteredUser(_fullDataTable, filterColumn, filterValue);
        }
        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private bool ValidateInputs()
        {
            string res = _userve.ValidateInputs(usernameText.Text, passText.Text);

            svWarnLab.Text = res;
            return string.IsNullOrEmpty(res);
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (Guid.TryParse(staffGUIDText.Text, out Guid empGuid))
            {
                bool activeStatusFromUI = UserCheckBox.GetItemChecked(1);

                bool success = _userve.SaveUser(
                    empGuid,
                    usernameText.Text,
                    passText.Text,
                    activeStatusFromUI
                );

                if (success)
                {
                    svWarnLab.Text = "User updated successfully!";
                    svWarnLab.ForeColor = Color.Green;
                    LoadUserDataAsync();
                }
                else
                {
                    svWarnLab.Text = "Failed! Staff GUID not found or Username taken.";
                    svWarnLab.ForeColor = Color.Red;
                }
            }
            else
            {
                svWarnLab.Text = "Invalid Staff GUID format.";
                svWarnLab.ForeColor = Color.Red;
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(staffGUIDText.Text, out Guid empGuid))
            {
                bool success = _userve.DelUser(empGuid);
                if (success) LoadUserDataAsync();
            }
        }

        private void rtnBtn_Click(object sender, EventArgs e)
        {
            //_parent.ResetToHome();
        }
    }
}
