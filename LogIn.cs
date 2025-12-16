using BakeryDash.BLL;
using System;
using System.Windows.Forms;

namespace BakeryDash2531
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            LogIn_Load();
        }
        private void LogIn_Load()
        {
            userField.Hint = "Username";
            passField.Hint = "Password";
            passField.UseSystemPasswordChar = true; // Secure the password field, its a cool built-in hider
            loginBtn.Enabled = false;
            userField.TextChanged += ValidateInputs;
            passField.TextChanged += ValidateInputs;

            toSignUpBtn.Click += (s, e) => {
                new Regis().Show();
                this.Hide();
            };
            loginBtn.Click += (s, e) => {

                if (SearchUser())
                {
                    MessageBox.Show("Loging in...");
                    new DashBoard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            loginBtn.Enabled = !string.IsNullOrWhiteSpace(userField.Text) &&
                               !string.IsNullOrWhiteSpace(passField.Text);
        }

        private bool SearchUser()
        {
            //AutorizationService looker = new AutorizationService();
            return new AutorizationService().UserLooker(userField.Text, passField.Text);
        }
    }
}