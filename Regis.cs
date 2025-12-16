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
            emailField.Hint = "Email (example@domain.com)";
            passField.Hint = "Password";
            cpassField.Hint = "Confirm Password";

            passField.UseSystemPasswordChar = true;
            cpassField.UseSystemPasswordChar = true;

            regisBtn.Enabled = false;

            userField.TextChanged += ValidateRegisInputs;
            emailField.TextChanged += ValidateRegisInputs;
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
            bool isEmailValid = Regex.IsMatch(emailField.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool passwordsMatch = passField.Text == cpassField.Text && !string.IsNullOrWhiteSpace(passField.Text);
            bool userFilled = !string.IsNullOrWhiteSpace(userField.Text);

            regisBtn.Enabled = isEmailValid && passwordsMatch && userFilled;
        }
        private bool SignUpUser()
        {
            return new RegistryService().UserRegister(emailField.Text, userField.Text, passField.Text);
        }
    }
}