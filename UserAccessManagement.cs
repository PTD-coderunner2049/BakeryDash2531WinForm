using BakeryDash.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BakeryDash2531
{
    public partial class UserAccessManagement : Form
    {
        UserService _userve;
        DataTable _fullDataTable;
        public UserAccessManagement()
        {
            InitializeComponent();
            _userve = new UserService();

            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "Username", "Role", "Status", "Date", "User GUID", "Staff GUID" });
                collumBox.SelectedIndex = 0;
            }
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
            LoadUserData();

            UserGrid.SelectionChanged += UserGrid_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        }

        private void LoadUserData()
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
            //    row.Cells["EmployeeGUIDCol"].Value = rowData["EmployeeGlobalId"];
            //    row.Cells["RoleCol"].Value = (bool)rowData["IsSystemManager"] ? "Manager" : "Staff";
            //}
        }
        private void ApplyFilter()
        {
            if (_fullDataTable == null) return;

            DataView dv = _fullDataTable.DefaultView;
            string filterValue = valueBox.Text.Replace("'", "''");
            string selectedCollum = collumBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(filterValue))
            {
                dv.RowFilter = "";
            }
            else
            {
                try
                {
                    switch (selectedCollum)
                    {
                        case "Username":
                            dv.RowFilter = $"Username LIKE '%{filterValue}%'";
                            break;
                        case "User GUID":
                            dv.RowFilter = $"Convert(UserGlobalId, 'System.String') LIKE '%{filterValue}%'";
                            break;
                        case "Staff GUID":
                            dv.RowFilter = $"Convert(EmployeeGlobalId, 'System.String') LIKE '%{filterValue}%'";
                            break;
                        case "Date":
                            dv.RowFilter = $"Convert(CreatedAt, 'System.String') LIKE '%{filterValue}%'";
                            break;
                        case "Role":
                            if (filterValue.ToLower().Contains("man")) dv.RowFilter = "IsSystemManager = true";
                            else if (filterValue.ToLower().Contains("sta")) dv.RowFilter = "IsSystemManager = false";
                            break;
                        case "Status":
                            if (filterValue.ToLower().Contains("act")) dv.RowFilter = "Active = true";
                            else if (filterValue.ToLower().Contains("ina")) dv.RowFilter = "Active = false";
                            break;
                    }
                }
                catch {}
            }

            PopulateGrid(dv);
        }
        private void PopulateGrid(DataView dv)
        {
            UserGrid.Rows.Clear();
            foreach (DataRowView rowView in dv)
            {
                DataRow rowData = rowView.Row;
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
        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void UserGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (UserGrid.SelectedRows.Count > 0)
            {
                // Bind
                DataGridViewRow row = UserGrid.SelectedRows[0];
                usernameText.Text = row.Cells["UsernameCol"].Value?.ToString();
                //passText.Text = row.Cells["PasswordCol"].Value?.ToString();
                staffGUIDText.Text = row.Cells["EmployeeGUIDCol"].Value?.ToString();

                bool isManager = row.Cells["RoleCol"].Value?.ToString() == "Manager";
                bool isActive = row.Cells["StatusCol"].Value?.ToString() == "Active";
                UserCheckBox.SetItemChecked(0, isManager);
                UserCheckBox.SetItemChecked(1, isActive);
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(staffGUIDText.Text))
            {
                svWarnLab.Text = "Username and Staff GUID are required!";
                svWarnLab.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrWhiteSpace(passText.Text))
            {
                svWarnLab.Text = "Password cannot be empty!";
                svWarnLab.ForeColor = Color.Red;
                return false;
            }

            return true;
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
                    LoadUserData();
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
                if (success) LoadUserData();
            }
        }
    }
}
