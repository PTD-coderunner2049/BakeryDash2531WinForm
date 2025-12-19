using SolbergBakery2531.BLL;
using SolbergBakery2531.UI.Forms.AdministForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolbergBakery2531.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StaffInfoManagement());
            //Application.Run(new UserAccessManagement());
            //new LogIn().Show();
            //new EmploymentHistory().Show();
            new ProdInfoManagement().Show();

            Application.Run();
        }
    }
}
