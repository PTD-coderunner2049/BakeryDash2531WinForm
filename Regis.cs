using BakeryDash.BLL;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BakeryDash2531
{
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
            SignUp_Load();
        }
        private void SignUp_Load()
        {
            userField.Hint = "Username";
            employeeGUIDField.Hint = "Submit your Employee GUID";
            passField.Hint = "Password";
            cpassField.Hint = "Confirm Password";

            passField.UseSystemPasswordChar = true;
            cpassField.UseSystemPasswordChar = true;

            regisBtn.Enabled = false;

            userField.TextChanged += ValidateRegisInputs;
            employeeGUIDField.TextChanged += ValidateRegisInputs;
            passField.TextChanged += ValidateRegisInputs;
            cpassField.TextChanged += ValidateRegisInputs;

            toLogInBtn.Click += (s, e) => {
                new LogIn().Show();
                this.Hide();
            };

            regisBtn.Click += (s, e) => {
                if (SignUpUser())
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new LogIn().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed! Username or Email may already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        private void ValidateRegisInputs(object sender, EventArgs e)
        {
            bool isEmailValid = !string.IsNullOrWhiteSpace(userField.Text);
            bool passwordsMatch = passField.Text == cpassField.Text && !string.IsNullOrWhiteSpace(passField.Text);
            bool userFilled = !string.IsNullOrWhiteSpace(userField.Text);

            regisBtn.Enabled = isEmailValid && passwordsMatch && userFilled;
        }
        private bool SignUpUser()
        {
            return new RegistryService().UserRegister(employeeGUIDField.Text, userField.Text, passField.Text);
        }
    }
}