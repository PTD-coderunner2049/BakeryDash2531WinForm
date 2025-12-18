using BakeryDash.BLL;
using BakeryDash.Utils;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryDash2531
{
    public partial class Regis : Form
    {
        private readonly RegistryService _reserve;
        public Regis()
        {
            InitializeComponent();
            _reserve = new RegistryService();
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
        }
        private void ValidateRegisInputs(object sender, EventArgs e)
        {
            bool isEmailValid = !string.IsNullOrWhiteSpace(userField.Text);
            bool passwordsMatch = passField.Text == cpassField.Text && !string.IsNullOrWhiteSpace(passField.Text);
            bool userFilled = !string.IsNullOrWhiteSpace(userField.Text);

            regisBtn.Enabled = isEmailValid && passwordsMatch && userFilled;
        }

        private void toLogInBtn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Dispose();
        }

        private async void regisBtn_ClickAsync(object sender, EventArgs e)
        {
            bool? res = _reserve.UserRegister(employeeGUIDField.Text, userField.Text, passField.Text);
            if (res == true)
            {
                await UIUtils.ShowToast("Registration successful! You can now log in.", "RegistryService:", 1000);
                new LogIn().Show();
                this.Dispose();
            }
            else if (res == null)
                await UIUtils.ShowToast("Invalid Employee GUID. Please check and try again.", "RegistryService:", 1000);
            else
                MessageBox.Show("Registration failed! Username or Email may already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}