using SolbergBakery2531.BLL;
using SolbergBakery2531._utils;

using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolbergBakery2531.UI.Forms.AdministForms;

namespace SolbergBakery2531.UI
{
    public partial class StaffInfoManagement : Form
    {
        private readonly StaffService _staffService;
        private DataTable _fullDataTable;
        private DashBoard _parent;

        public StaffInfoManagement(DashBoard Parent)
        {
            InitializeComponent();
            _staffService = new StaffService();
            _parent = Parent;
            SetupfilterBoxes();

            SetupCheckedListBoxes();

            LoadStaffDataAsync();

            StaffGrid.SelectionChanged += StaffGrid_SelectionChanged;
            valueBox.TextChanged += ValueBox_TextChanged;
            collumBox.SelectedIndexChanged += (s, e) => ApplyFilterAsync();
        }




        private void SetupfilterBoxes()
        {
            if (collumBox.Items.Count == 0)
            {
                collumBox.Items.AddRange(new string[] { "FirstName", "LastName", "Email", "PhoneContact", "SSN", "Id" });
                collumBox.SelectedIndex = 0;
            }
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

        private void LoadStaffDataAsync()
        {
            _ = UIUtils.ShowToast("Loading...", "SolbergBakery", 1000);

            try
            {
                StaffGrid.AutoGenerateColumns = false;
                _fullDataTable = _staffService.Fetch();
                StaffGrid.DataSource = _fullDataTable;

                StaffGrid.ClearSelection();
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
            FnameText.Clear();
            LnameText.Clear();
            emailText.Clear();
            phoneText.Clear();
            ssnText.Clear(); 
            //employdateText.Clear();
            payrateText.Clear();

            foreach (int i in genderBox.CheckedIndices) genderBox.SetItemChecked(i, false);
            foreach (int i in StatusRoleBox.CheckedIndices) StatusRoleBox.SetItemChecked(i, false);
            
            staffGUIDText.ReadOnly = false;
            ssnText.ReadOnly = false;
            svWarnLab.Text = string.Empty;
        }

        private void StaffGrid_SelectionChanged(object sender, EventArgs e)
        {
            _parent.resetProgress();
            DataRow dataRow = StaffGrid.GetSelectedRow();
            if ( dataRow == null ) 
            {
                ClearInputs();
                return;
            }
            _parent.UpdateProgress(20);

            staffGUIDText.Text = dataRow["Id"].ToString();
            staffGUIDText.ReadOnly = true;
            FnameText.Text = dataRow["FirstName"].ToString();
            LnameText.Text = dataRow["LastName"].ToString();
            emailText.Text = dataRow["Email"].ToString();
            phoneText.Text = dataRow["PhoneContact"].ToString();
            ssnText.Text = dataRow["SSN"].ToString();
            ssnText.ReadOnly = true;
            payrateText.Text = dataRow["PayratePerHrs"].ToString();

            _parent.UpdateProgress(20);

            string gender = dataRow["Gender"].ToString();
            genderBox.SetItemChecked(0, gender == "M");
            genderBox.SetItemChecked(1, gender == "F");

            _parent.UpdateProgress(20);

            if (DateTime.TryParse(dataRow["Birth"].ToString(), out DateTime birthDate))
                birthText.Text = birthDate.ToShortDateString();

            _parent.UpdateProgress(20);

            bool isRoleManager = (bool)dataRow["IsSystemManager"];
            bool Active = (bool)dataRow["Active"];
            StatusRoleBox.SetItemChecked(0, Active);
            StatusRoleBox.SetItemChecked(1, isRoleManager);
            
            _parent.endProgress();
        }

        private void ApplyFilterAsync()
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

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAsync();
        }
        private bool ValidateInputs()
                {
                    string res = _staffService.ValidateInputs(FnameText.Text, LnameText.Text, emailText.Text,
                        phoneText.Text, ssnText.Text, payrateText.Text, birthText.Text, genderBox.CheckedItems.Count);

                    svWarnLab.Text = res;
                    return string.IsNullOrEmpty(res);
                }

        private void svBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
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
            //DateTime employedAt = DateTime.Parse(employdateText.Text);

            string gender = genderBox.GetItemChecked(0) ? "M" : "F";
            bool Active = StatusRoleBox.GetItemChecked(0);
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
                    //employedAt,
                    isManager,
                    Active
                );

                if (success)
                {
                    svWarnLab.Text = (empGuid == Guid.Empty ? "New staff record created successfully!" : "Staff record updated successfully!");
                    svWarnLab.ForeColor = Color.Green;
                    LoadStaffDataAsync();
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

            _parent.endProgress();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            if (StaffGrid.SelectedRows.Count == 0 || !staffGUIDText.ReadOnly)
            {
                svWarnLab.Text = "Please select an existing staff member to delete.";
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
                            LoadStaffDataAsync();
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
            _parent.endProgress();
        }

        private void instBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();

            staffGUIDText.Text = Guid.NewGuid().ToString();
            staffGUIDText.ReadOnly = false;
            ssnText.ReadOnly = false;
            ssnText.Clear();
            phoneText.Clear();
            FnameText.Clear();
            LnameText.Clear();
            emailText.Clear();
            payrateText.Clear();
            birthText.Clear();
         
            _parent.endProgress();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();

            DataRow dataRow = StaffGrid.GetSelectedRow();
            if (dataRow == null)
            {
                _ = UIUtils.ShowToast("Object's History not found!", "SolbergBakery", 1000);
                return;
            }
            Guid empGuid = Guid.Empty;
            Guid.TryParse(staffGUIDText.Text, out empGuid);
            new EmploymentHistory(empGuid, FnameText.Text + " " + LnameText.Text).Show();
            _parent.endProgress();
        }

        private void rtnBtn_Click(object sender, EventArgs e)
        {
            _parent.resetProgress();
            _parent.endProgress();
            //_parent.ResetToHome();
        }
    }
}