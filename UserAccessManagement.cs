using BakeryDash.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BakeryDash2531
{
    public partial class UserAccessManagement : Form
    {
        UserService _userve;
        public UserAccessManagement()
        {
            InitializeComponent();
            _userve = new UserService();
            LoadUserData();

            UserGrid.SelectionChanged += UserGrid_SelectionChanged;
        }
        private void LoadUserData()
        {
            UserGrid.Rows.Clear();
            DataTable usersTable = _userve.Fetch();

            foreach (DataRow rowData in usersTable.Rows)
            {
                int rowIndex = UserGrid.Rows.Add();
                DataGridViewRow row = UserGrid.Rows[rowIndex];

                row.Cells["GUIDCol"].Value = rowData["UserGlobalId"].ToString().Substring(0, 8);
                row.Cells["UsernameCol"].Value = rowData["Username"];
                row.Cells["CreatedTimeCol"].Value = Convert.ToDateTime(rowData["CreatedAt"]).ToShortDateString();
                row.Cells["StatusCol"].Value = (bool)rowData["Active"] ? "Active" : "Inactive";
                row.Cells["PasswordCol"].Value = rowData["PasswordHash"];
                row.Cells["EmployeeGUIDCol"].Value = rowData["EmployeeGlobalId"];
                row.Cells["RoleCol"].Value = (bool)rowData["IsSystemManager"] ? "Manager" : "Staff";
            }
        }
        private void UserGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (UserGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = UserGrid.SelectedRows[0];
                // Bind
                usernameText.Text = row.Cells["UsernameCol"].Value?.ToString();
                crDateText.Text = row.Cells["CreatedTimeCol"].Value?.ToString();
                //passText.Text = row.Cells["PasswordCol"].Value?.ToString();
                staffGUIDText.Text = row.Cells["EmployeeGUIDCol"].Value?.ToString();
                bool isManager = row.Cells["RoleCol"].Value?.ToString() == "Manager";
                UserCheckBox.SetItemChecked(0, isManager);
                bool isActive = row.Cells["StatusCol"].Value?.ToString() == "Active";
                UserCheckBox.SetItemChecked(1, isActive);
            }
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(staffGUIDText.Text, out Guid empGuid))
            {
                bool success = _userve.SaveUser(
                    empGuid,
                    usernameText.Text,
                    passText.Text,
                    UserCheckBox.GetItemChecked(1)
                );

                if (success) LoadUserData();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(staffGUIDText.Text, out Guid empGuid))
            {
                bool success = _userve.DelUser(empGuid);
                if (success) LoadUserData();
            }
        }
    }
}
