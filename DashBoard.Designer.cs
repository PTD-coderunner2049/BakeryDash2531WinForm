namespace BakeryDash2531
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dashMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextGreet = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextUserName = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(570, 261);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "DASHBOARD";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(0, 90);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1264, 10);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // dashMenuStrip
            // 
            this.dashMenuStrip.BackColor = System.Drawing.SystemColors.Control;
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
            this.dashMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.dashMenuStrip.TabIndex = 2;
            this.dashMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // xXToolStripMenuItem
            // 
            this.xXToolStripMenuItem.Name = "xXToolStripMenuItem";
            this.xXToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.xXToolStripMenuItem.Text = ">(V.V)<";
            // 
            // xXToolStripMenuItem1
            // 
            this.xXToolStripMenuItem1.Name = "xXToolStripMenuItem1";
            this.xXToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.xXToolStripMenuItem1.Text = ">(V.V)<";
            // 
            // xXToolStripMenuItem2
            // 
            this.xXToolStripMenuItem2.Name = "xXToolStripMenuItem2";
            this.xXToolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.xXToolStripMenuItem2.Text = ">(V.V)<";
            // 
            // toolStripTextGreet
            // 
            this.toolStripTextGreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextGreet.Enabled = false;
            this.toolStripTextGreet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextGreet.Name = "toolStripTextGreet";
            this.toolStripTextGreet.Size = new System.Drawing.Size(55, 20);
            this.toolStripTextGreet.Text = "Greeting!!";
            // 
            // toolStripTextUserName
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 5;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dashMenuStrip);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.dashMenuStrip.ResumeLayout(false);
            this.dashMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.MenuStrip dashMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextUserName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextGreet;
        private System.Windows.Forms.Panel panel1;
    }
}