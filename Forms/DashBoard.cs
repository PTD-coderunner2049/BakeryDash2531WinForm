using BakeryDash.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public interface IDashboardController
{
    void ResetToHome();
    void resetProgress();
    void UpdateProgress(int value);
    void endProgress();
}
namespace BakeryDash2531
{
    public partial class DashBoard : Form
    {
        SessionService _session;
        AnimateService _anima;

        public DashBoard()
        {
            InitializeComponent();
            resetProgress();
            UpdateProgress(25);
            _session = new SessionService();
            _anima = new AnimateService();
            UpdateProgress(25);
            Board_Load();
            UpdateProgress(25);
            this.MaximizeBox = false;
            endProgress();
        }
        public void ResetToHome()
        {
            panelBack.Controls.Clear();
            this.Text = "Solberg's Bakery - Dashboard";
            GeneralProgBar.Value = 0;
            Dashing();
        }
        public void resetProgress()
        {
            GeneralProgBar.Value = 0;
        }
        public void endProgress()
        {
            GeneralProgBar.Value = 100;
        }
        public void UpdateProgress(int value)
        {
            if (value >= 0 && value <= 100)
                GeneralProgBar.Value = value;
        }
        public void Board_Load()
        {
            GeneralProgBar.Value = 0;
            GeneralProgBar.Step = 20;

            toolStripTextUserName.Text = _session.GetStaffFullName();

            this.Text = "Solberg's Bakery - Dashboard";
            xXToolStripMenuItem2.Enabled = _session.IsAdmin();
            SetupHoverEffect(orderBtn);
            SetupHoverEffect(statBtn);
            //SetupPanelHoverEffect(LogOutPad);
        }

        private void LoadFormToPanel(Panel panel, Form form)
        {
            GeneralProgBar.Value = 0;

            panel.Controls.Clear();
            GeneralProgBar.PerformStep();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            GeneralProgBar.PerformStep();

            panel.Controls.Add(form);
            GeneralProgBar.PerformStep();

            panel.Visible = true;
            form.Show();
            form.BringToFront();

            GeneralProgBar.Value = 100;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _session.PerformLogout();
            new LogIn().Show();
            this.Dispose();
        }
        private void SetupHoverEffect(Label lbl)
        {
            lbl.Tag = false;
            lbl.MouseEnter += (s, e) => { lbl.Tag = true; lbl.Invalidate(); };
            lbl.MouseLeave += (s, e) => { lbl.Tag = false; lbl.Invalidate(); };

            lbl.Paint += (s, e) => {
                if (lbl.Tag is bool isHovering && isHovering)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    Color softColor = Color.FromArgb(120, Color.PapayaWhip); //Alpha low = transparency

                    float borderThickness = 2.0f;
                    using (Pen p = new Pen(softColor, borderThickness))
                    {
                        // IMPORTANT: Inset must be at least half the pen width + 1
                        // This prevents the thick edges from being clipped by the Label/Panel
                        // bounds and orther shid I put them in...
                        int offset = (int)(borderThickness / 2) + 1;
                        Rectangle rect = new Rectangle(offset, offset, lbl.Width - (offset * 2) - 1, lbl.Height - (offset * 2) - 1);

                        int radius = Math.Min(rect.Height, 100);

                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseAllFigures();

                        e.Graphics.DrawPath(p, path);
                    }
                }
            };
        }
        private void SetupPanelHoverEffect(Panel pnl)
        {
            pnl.Tag = false;
            pnl.MouseEnter += (s, e) => { pnl.Tag = true; pnl.Invalidate(); };
            pnl.MouseLeave += (s, e) => { pnl.Tag = false; pnl.Invalidate(); };

            pnl.Paint += (s, e) => {
                if (pnl.Tag is bool isHovering && isHovering)
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Color softColor = Color.FromArgb(120, Color.PapayaWhip);

                    float borderThickness = 3.0f; // Thicker for panels
                    using (Pen p = new Pen(softColor, borderThickness))
                    {
                        int offset = (int)(borderThickness / 2) + 1;
                        Rectangle rect = new Rectangle(offset, offset, pnl.Width - (offset * 2) - 1, pnl.Height - (offset * 2) - 1);

                        // For a "soft" box look, use a lower radius like 15-20 instead of 100
                        int radius = 70;

                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseAllFigures();

                        e.Graphics.DrawPath(p, path);
                    }
                }
            };
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {

            //LoadFormToPanel(panel4, new SessionInfoUser());
            //LoadFormToPanel(panel4, new SessionInfoHandler());
        }

        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBack.Controls.Clear();
            this.Text = "Solberg's Bakery - User's Assess Managment";
            LoadFormToPanel(Dashing(), new UserAccessManagement(this));
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBack.Controls.Clear();
            this.Text = "Solberg's Bakery - Employee Managment";
            LoadFormToPanel(Dashing(), new StaffInfoManagement(this));
        }
        private Panel Dashing()
        {
            panelBack.Controls.Clear();
            Panel foundation = new Panel();
            foundation.BackColor = Color.Transparent;
            foundation.Dock = DockStyle.Fill;
            foundation.BackgroundImage =
            foundation.BackgroundImage = Properties.Resources.HDHD_1080;
            foundation.BackgroundImageLayout = ImageLayout.Stretch;
            panelBack.Controls.Add(foundation);
            return foundation;
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
