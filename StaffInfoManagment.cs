using BakeryDash.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace BakeryDash2531
{
    public partial class StaffInfoManagment : Form
    {
        StaffService _staffService;
        DataTable _fullDataTable;

        public StaffInfoManagment()
        {
            InitializeComponent();
            _staffService = new StaffService();

            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "FirstName", "LastName", "Email", "PhoneContact", "SSN", "EmployeeGlobalId" });
                collumBox.SelectedIndex = 0;
            }

            SetupCheckedListBoxes();

            LoadStaffData();

            StaffGrid.SelectionChanged += StaffGrid_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilter();
        }

        private void SetupCheckedListBoxes()
        {
            if (genderBox.Items.Count == 0)
            {
                genderBox.Items.AddRange(new string[] { "Male", "Female" });
            }
            genderBox.ItemCheck += (s, e) => {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < genderBox.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            genderBox.SetItemChecked(i, false);
                        }
                    }
                }
            };

            if (StatusRoleBox.Items.Count == 0)
            {
                StatusRoleBox.Items.AddRange(new string[] { "Activated", "System Manager" });
            }
        }

        /// <summary>
        /// Loads all staff data into the DataGridView.
        /// </summary>
        private void LoadStaffData()
        {
            try
            {
                _fullDataTable = _staffService.Fetch();
                StaffGrid.DataSource = _fullDataTable;

                StaffGrid.Columns["GUIDCol"].DataPropertyName = "EmployeeGlobalId";
                StaffGrid.Columns["FNameCol"].DataPropertyName = "FirstName";
                StaffGrid.Columns["LNameCol"].DataPropertyName = "LastName";
                StaffGrid.Columns["EmailCol"].DataPropertyName = "Email";
                StaffGrid.Columns["PhoneCol"].DataPropertyName = "PhoneContact";
                StaffGrid.Columns["GenderCol"].DataPropertyName = "Gender";
                StaffGrid.Columns["BirthCol"].DataPropertyName = "Birth";
                StaffGrid.Columns["SSNCol"].DataPropertyName = "SSN";
                StaffGrid.Columns["EmployDateCol"].DataPropertyName = "EmployedAt";
                StaffGrid.Columns["PayrateCol"].DataPropertyName = "PayratePerHrs";
                StaffGrid.Columns["RoleCol"].DataPropertyName = "IsSystemManager";
                StaffGrid.Columns["ActiveCol"].DataPropertyName = "IsActive";


                foreach (DataGridViewColumn col in StaffGrid.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    if (col.Name == "GUIDCol")
                    {
                        col.ReadOnly = true;
                        col.Visible = false;
                    }
                }

                StaffGrid.AutoResizeColumns();
                StaffGrid.ClearSelection();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Filters the DataGridView based on the selected column and value.
        /// </summary>
        private void ApplyFilter()
        {
            string filterColumn = collumBox.SelectedItem.ToString();
            string filterValue = valueBox.Text.Trim();

            if (_fullDataTable == null) return;

            try
            {
                string filterExpression = string.Empty;

                if (!string.IsNullOrEmpty(filterValue))
                {
                    filterExpression = $"CONVERT({filterColumn}, 'System.String') LIKE '%{filterValue.Replace("'", "''")}%'";
                }

                _fullDataTable.DefaultView.RowFilter = filterExpression;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Filter Error: {ex.Message}");
            }
        }

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        /// <summary>
        /// Clears all input controls on the form.
        /// </summary>
        private void ClearInputs()
        {
            staffGUIDText.Text = Guid.Empty.ToString();
            FnameText.Clear();
            LnameText.Clear();
            emailText.Clear();
            phoneText.Clear();
            ssnText.Clear(); 
            employdateText.Clear();
            payrateText.Clear();

            for (int i = 0; i < genderBox.Items.Count; i++) genderBox.SetItemChecked(i, false);
            for (int i = 0; i < StatusRoleBox.Items.Count; i++) StatusRoleBox.SetItemChecked(i, false);

            staffGUIDText.ReadOnly = false;
            ssnText.ReadOnly = false;
            svWarnLab.Text = string.Empty;
        }

        /// <summary>
        /// Binds selected staff data from the grid to the input fields.
        /// </summary>
        private void StaffGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (StaffGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = StaffGrid.SelectedRows[0];
                DataRowView rowView = (DataRowView)row.DataBoundItem;
                DataRow dataRow = rowView.Row;

                staffGUIDText.Text = dataRow["EmployeeGlobalId"].ToString();
                staffGUIDText.ReadOnly = true; // Read-only for existing records

                FnameText.Text = dataRow["FirstName"].ToString();
                LnameText.Text = dataRow["LastName"].ToString();
                emailText.Text = dataRow["Email"].ToString();
                phoneText.Text = dataRow["PhoneContact"].ToString();
                ssnText.Text = dataRow["SSN"].ToString();
                ssnText.ReadOnly = true; // SSN is not mutable after creation
                payrateText.Text = dataRow["PayratePerHrs"].ToString();

                string gender = dataRow["Gender"].ToString();
                genderBox.SetItemChecked(0, gender == "M");
                genderBox.SetItemChecked(1, gender == "F");

                if (DateTime.TryParse(dataRow["Birth"].ToString(), out DateTime birthDate))
                {
                    birthText.Text = birthDate.ToShortDateString();
                }
                if (DateTime.TryParse(dataRow["EmployedAt"].ToString(), out DateTime employDate))
                {
                    employdateText.Text = employDate.ToShortDateString();
                }

                bool isRoleManager = (bool)dataRow["IsSystemManager"];
                bool isActive = (bool)dataRow["IsActive"];

                StatusRoleBox.SetItemChecked(0, isActive);
                StatusRoleBox.SetItemChecked(1, isRoleManager);
            }
            else
            {
                ClearInputs();
            }
        }

        /// <summary>
        /// Validates all required inputs before calling the save operation.
        /// </summary>
        private bool ValidateInputs()
        {
            svWarnLab.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(FnameText.Text) ||
                string.IsNullOrWhiteSpace(LnameText.Text) ||
                string.IsNullOrWhiteSpace(emailText.Text) ||
                string.IsNullOrWhiteSpace(phoneText.Text) ||
                string.IsNullOrWhiteSpace(ssnText.Text) ||
                string.IsNullOrWhiteSpace(payrateText.Text))
            {
                svWarnLab.Text = "All staff information fields are required.";
                return false;
            }

            if (genderBox.CheckedItems.Count != 1)
            {
                svWarnLab.Text = "Please select one gender.";
                return false;
            }
            if (!decimal.TryParse(payrateText.Text, out decimal payrate))
            {
                svWarnLab.Text = "Pay Rate must be a valid decimal number.";
                return false;
            }

            if (!DateTime.TryParse(birthText.Text, out DateTime birthDate))
            {
                svWarnLab.Text = "Invalid Birth Date format. Use MM/DD/YYYY.";
                return false;
            }

            if (!DateTime.TryParse(employdateText.Text, out DateTime employedDate))
            {
                svWarnLab.Text = "Invalid Employed At Date format. Use MM/DD/YYYY.";
                return false;
            }

            return true;
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Guid empGuid = Guid.Empty;
            if (staffGUIDText.ReadOnly)
            {
                Guid.TryParse(staffGUIDText.Text, out empGuid);
            }
            string fName = FnameText.Text.Trim();
            string lName = LnameText.Text.Trim();
            string email = emailText.Text.Trim();
            string phone = phoneText.Text.Trim();
            string ssn = ssnText.Text.Trim();
            decimal pay = decimal.Parse(payrateText.Text);
            DateTime birth = DateTime.Parse(birthText.Text);
            DateTime employedAt = DateTime.Parse(employdateText.Text);

            string gender = genderBox.GetItemChecked(0) ? "M" : "F";
            bool isActive = StatusRoleBox.GetItemChecked(0);
            bool isManager = StatusRoleBox.GetItemChecked(1);

            try
            {
                bool success = _staffService.SaveStaff(
                    empGuid,
                    email,
                    fName,
                    lName,
                    phone,
                    gender,
                    birth,
                    ssn,
                    pay,
                    employedAt,
                    isManager,
                    isActive
                );

                if (success)
                {
                    svWarnLab.Text = (empGuid == Guid.Empty ? "New staff record created successfully!" : "Staff record updated successfully!");
                    svWarnLab.ForeColor = Color.Green;
                    LoadStaffData(); // Reload grid

        }
                else
                {
                    svWarnLab.Text = "Failed to save record. SSN or Email might already exist or a database error occurred.";
                    svWarnLab.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                svWarnLab.Text = $"An error occurred during save: {ex.Message}";
                svWarnLab.ForeColor = Color.Red;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (StaffGrid.SelectedRows.Count == 0 || !staffGUIDText.ReadOnly)
            {
                svWarnLab.Text = "Please select an existing staff member to delete.";
                svWarnLab.ForeColor = Color.Red;
                return;
            }

            if (Guid.TryParse(staffGUIDText.Text, out Guid empGuid))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this staff record? This action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        bool success = _staffService.DelStaff(empGuid);
                        if (success)
                        {
                            svWarnLab.Text = "Staff record deleted successfully.";
                            svWarnLab.ForeColor = Color.Green;
                            LoadStaffData();
                        }
                        else
                        {
                            svWarnLab.Text = "Deletion failed. Staff GUID not found.";
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
        }

        private void instBtn_Click(object sender, EventArgs e)
        {
            staffGUIDText.Text = Guid.NewGuid().ToString();
            ssnText.ReadOnly = false;
            ssnText.Clear();
            phoneText.Clear();
            FnameText.Clear();
            LnameText.Clear();
            emailText.Clear();
            payrateText.Clear();
            employdateText.Clear();
            birthText.Clear();


        }
    }
}