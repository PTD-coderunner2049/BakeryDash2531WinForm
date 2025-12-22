namespace SolbergBakery2531.UI
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextGreet = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextUserName = new System.Windows.Forms.ToolStripTextBox();
            this.GeneralProgBar = new System.Windows.Forms.ProgressBar();
            this.panelBack = new System.Windows.Forms.Panel();
            this.centralPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statBtn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashMenuStrip.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.centralPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashMenuStrip
            // 
            this.dashMenuStrip.BackColor = System.Drawing.Color.PapayaWhip;
            this.dashMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xXToolStripMenuItem,
            this.xXToolStripMenuItem1,
            this.xXToolStripMenuItem2,
            this.toolStripTextGreet,
            this.toolStripTextUserName});
            this.dashMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.dashMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.dashMenuStrip.Name = "dashMenuStrip";
            this.dashMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.dashMenuStrip.Size = new System.Drawing.Size(1180, 24);
            this.dashMenuStrip.TabIndex = 2;
            this.dashMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logoutToolStripMenuItem.Text = "Personal Info";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // xXToolStripMenuItem
            // 
            this.xXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderingToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.xXToolStripMenuItem.Name = "xXToolStripMenuItem";
            this.xXToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.xXToolStripMenuItem.Text = "Tasks";
            // 
            // orderingToolStripMenuItem
            // 
            this.orderingToolStripMenuItem.Name = "orderingToolStripMenuItem";
            this.orderingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderingToolStripMenuItem.Text = "Ordering";
            this.orderingToolStripMenuItem.Click += new System.EventHandler(this.orderingToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // xXToolStripMenuItem1
            // 
            this.xXToolStripMenuItem1.Name = "xXToolStripMenuItem1";
            this.xXToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.xXToolStripMenuItem1.Text = "Sale\'s Satistic";
            // 
            // xXToolStripMenuItem2
            // 
            this.xXToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.accessToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.xXToolStripMenuItem2.Name = "xXToolStripMenuItem2";
            this.xXToolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.xXToolStripMenuItem2.Text = "Administ";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.accessToolStripMenuItem.Text = "Access";
            this.accessToolStripMenuItem.Click += new System.EventHandler(this.accessToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // toolStripTextGreet
            // 
            this.toolStripTextGreet.BackColor = System.Drawing.Color.PapayaWhip;
            this.toolStripTextGreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextGreet.Enabled = false;
            this.toolStripTextGreet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextGreet.Name = "toolStripTextGreet";
            this.toolStripTextGreet.Size = new System.Drawing.Size(55, 20);
            this.toolStripTextGreet.Text = "Greeting!!";
            // 
            // toolStripTextUserName
            // 
            this.toolStripTextUserName.BackColor = System.Drawing.Color.PapayaWhip;
            this.toolStripTextUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.toolStripTextUserName.Enabled = false;
            this.toolStripTextUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextUserName.MaxLength = 50767;
            this.toolStripTextUserName.Name = "toolStripTextUserName";
            this.toolStripTextUserName.ReadOnly = true;
            this.toolStripTextUserName.Size = new System.Drawing.Size(500, 20);
            this.toolStripTextUserName.Text = "user ....";
            // 
            // GeneralProgBar
            // 
            this.GeneralProgBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralProgBar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GeneralProgBar.Location = new System.Drawing.Point(0, 24);
            this.GeneralProgBar.Margin = new System.Windows.Forms.Padding(1);
            this.GeneralProgBar.Name = "GeneralProgBar";
            this.GeneralProgBar.Size = new System.Drawing.Size(1180, 3);
            this.GeneralProgBar.TabIndex = 6;
            this.GeneralProgBar.Value = 50;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Transparent;
            this.panelBack.Controls.Add(this.centralPanel);
            this.panelBack.Controls.Add(this.panel4);
            this.panelBack.Controls.Add(this.panel1);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 27);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1180, 650);
            this.panelBack.TabIndex = 7;
            // 
            // centralPanel
            // 
            this.centralPanel.BackColor = System.Drawing.Color.Transparent;
            this.centralPanel.Controls.Add(this.panel5);
            this.centralPanel.Controls.Add(this.panel6);
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.centralPanel.Location = new System.Drawing.Point(400, 150);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(780, 500);
            this.centralPanel.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.orderBtn);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 110);
            this.panel5.TabIndex = 0;
            // 
            // orderBtn
            // 
            this.orderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderBtn.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.orderBtn.Location = new System.Drawing.Point(0, 0);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(373, 110);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "New Order";
            this.orderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statBtn);
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(373, 110);
            this.panel6.TabIndex = 1;
            // 
            // statBtn
            // 
            this.statBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statBtn.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.statBtn.Location = new System.Drawing.Point(0, 0);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(373, 110);
            this.statBtn.TabIndex = 1;
            this.statBtn.Text = "Statistic";
            this.statBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 500);
            this.panel4.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 150);
            this.panel1.TabIndex = 13;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.ClientSize = new System.Drawing.Size(1180, 677);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.GeneralProgBar);
            this.Controls.Add(this.dashMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.dashMenuStrip.ResumeLayout(false);
            this.dashMenuStrip.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.centralPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip dashMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextUserName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextGreet;
        private System.Windows.Forms.ProgressBar GeneralProgBar;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.FlowLayoutPanel centralPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label orderBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label statBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}