using SolbergBakery2531.BLL;
using SolbergBakery2531._utils;
 
using System;
using System.Windows.Forms;

namespace SolbergBakery2531.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            LogIn_Load();
            emailField.Text = "m.johansen@bakery.com";
            passField.Text = "123123";
        }
        private void LogIn_Load()
        {
            emailField.Hint = "(v.laStrange@bakery.com)";
            passField.Hint = "Password";
            passField.UseSystemPasswordChar = true; // Secure the password field, its a cool built-in hider
            loginBtn.Enabled = false;
            emailField.TextChanged += ValidateInputs;
            passField.TextChanged += ValidateInputs;
        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            loginBtn.Enabled = !string.IsNullOrWhiteSpace(emailField.Text) &&
                               !string.IsNullOrWhiteSpace(passField.Text);
        }

        private bool SearchUser()
        {
            //AutorizationService looker = new AutorizationService();
            return new AutorizationService().UserLooker(emailField.Text, passField.Text);
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            await UIUtils.ShowToast("Loging in...", "SolbergBakery:", 1000);

            if (SearchUser())
            {
                await UIUtils.ShowToast("Welcome back to Solberg's Bakery!", "Login Success", 1000);

                new DashBoard().Show();
                //_ = ShowAutoClosingMessageBox("Welcome back to Solberg's Bakery!", 1000);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void toSignUpBtn_Click(object sender, EventArgs e)
        {
            new Regis().Show();
            _ = UIUtils.ShowToast("Loading...", "SolbergBakery:", 200);
            this.Dispose();
        }
    }
}