namespace BakeryDash2531
{
    partial class UserAccessManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffGUIDText = new System.Windows.Forms.TextBox();
            this.UserCheckBox = new System.Windows.Forms.CheckedListBox();
            this.crDateText = new System.Windows.Forms.MaskedTextBox();
            this.passLab = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.creLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.svBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.svWarnLab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeWarnLab = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(12, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(270, 22);
            this.title.TabIndex = 0;
            this.title.Text = "User\'s Managment Interface";
            // 
            // UserGrid
            // 
            this.UserGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.UserGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.UsernameCol,
            this.RoleCol,
            this.CreatedTimeCol,
            this.StatusCol,
            this.PasswordCol,
            this.EmployeeGUIDCol});
            this.UserGrid.GridColor = System.Drawing.Color.Brown;
            this.UserGrid.Location = new System.Drawing.Point(12, 119);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserGrid.Size = new System.Drawing.Size(632, 530);
            this.UserGrid.TabIndex = 1;
            // 
            // GUIDCol
            // 
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            this.GUIDCol.ReadOnly = true;
            this.GUIDCol.Width = 40;
            // 
            // UsernameCol
            // 
            this.UsernameCol.HeaderText = "Username";
            this.UsernameCol.Name = "UsernameCol";
            this.UsernameCol.ReadOnly = true;
            // 
            // RoleCol
            // 
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.Name = "RoleCol";
            // 
            // CreatedTimeCol
            // 
            this.CreatedTimeCol.HeaderText = "CreatedAt";
            this.CreatedTimeCol.Name = "CreatedTimeCol";
            this.CreatedTimeCol.ReadOnly = true;
            // 
            // StatusCol
            // 
            this.StatusCol.HeaderText = "Status";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.ReadOnly = true;
            this.StatusCol.Width = 60;
            // 
            // PasswordCol
            // 
            this.PasswordCol.HeaderText = "Password";
            this.PasswordCol.Name = "PasswordCol";
            this.PasswordCol.ReadOnly = true;
            // 
            // EmployeeGUIDCol
            // 
            this.EmployeeGUIDCol.HeaderText = "EmployeeGUID";
            this.EmployeeGUIDCol.Name = "EmployeeGUIDCol";
            this.EmployeeGUIDCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.staffGUIDText);
            this.groupBox1.Controls.Add(this.UserCheckBox);
            this.groupBox1.Controls.Add(this.crDateText);
            this.groupBox1.Controls.Add(this.passLab);
            this.groupBox1.Controls.Add(this.passText);
            this.groupBox1.Controls.Add(this.creLab);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usernameText);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 215);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Associated Staff :";
            // 
            // staffGUIDText
            // 
            this.staffGUIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGUIDText.Location = new System.Drawing.Point(202, 130);
            this.staffGUIDText.Name = "staffGUIDText";
            this.staffGUIDText.Size = new System.Drawing.Size(190, 31);
            this.staffGUIDText.TabIndex = 14;
            // 
            // UserCheckBox
            // 
            this.UserCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCheckBox.FormattingEnabled = true;
            this.UserCheckBox.Items.AddRange(new object[] {
            "Is System Manager",
            "Is Activated"});
            this.UserCheckBox.Location = new System.Drawing.Point(202, 167);
            this.UserCheckBox.Name = "UserCheckBox";
            this.UserCheckBox.Size = new System.Drawing.Size(151, 38);
            this.UserCheckBox.TabIndex = 3;
            // 
            // crDateText
            // 
            this.crDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crDateText.Location = new System.Drawing.Point(202, 56);
            this.crDateText.Name = "crDateText";
            this.crDateText.Size = new System.Drawing.Size(190, 31);
            this.crDateText.TabIndex = 13;
            // 
            // passLab
            // 
            this.passLab.AutoSize = true;
            this.passLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLab.Location = new System.Drawing.Point(83, 100);
            this.passLab.Name = "passLab";
            this.passLab.Size = new System.Drawing.Size(86, 20);
            this.passLab.TabIndex = 12;
            this.passLab.Text = "Password :";
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.Location = new System.Drawing.Point(202, 93);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(190, 31);
            this.passText.TabIndex = 11;
            // 
            // creLab
            // 
            this.creLab.AutoSize = true;
            this.creLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creLab.Location = new System.Drawing.Point(58, 63);
            this.creLab.Name = "creLab";
            this.creLab.Size = new System.Drawing.Size(111, 20);
            this.creLab.TabIndex = 10;
            this.creLab.Text = "Creation time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(202, 19);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(190, 31);
            this.usernameText.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(747, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 530);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.svWarnLab);
            this.panel4.Location = new System.Drawing.Point(217, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 100);
            this.panel4.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.svBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 40);
            this.panel6.TabIndex = 21;
            // 
            // svBtn
            // 
            this.svBtn.AutoSize = true;
            this.svBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.svBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.svBtn.Depth = 0;
            this.svBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.svBtn.Location = new System.Drawing.Point(0, 0);
            this.svBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.svBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.svBtn.Name = "svBtn";
            this.svBtn.Primary = false;
            this.svBtn.Size = new System.Drawing.Size(191, 36);
            this.svBtn.TabIndex = 3;
            this.svBtn.Text = "Save Changes";
            this.svBtn.UseVisualStyleBackColor = false;
            this.svBtn.Click += new System.EventHandler(this.svBtn_Click);
            // 
            // svWarnLab
            // 
            this.svWarnLab.AutoSize = true;
            this.svWarnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svWarnLab.ForeColor = System.Drawing.Color.Maroon;
            this.svWarnLab.Location = new System.Drawing.Point(3, 43);
            this.svWarnLab.Name = "svWarnLab";
            this.svWarnLab.Size = new System.Drawing.Size(162, 26);
            this.svWarnLab.TabIndex = 17;
            this.svWarnLab.Text = "Non-existing entry will be created\r\nautomatically.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.removeWarnLab);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(15, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 100);
            this.panel3.TabIndex = 18;
            // 
            // removeWarnLab
            // 
            this.removeWarnLab.AutoSize = true;
            this.removeWarnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeWarnLab.ForeColor = System.Drawing.Color.Maroon;
            this.removeWarnLab.Location = new System.Drawing.Point(3, 43);
            this.removeWarnLab.Name = "removeWarnLab";
            this.removeWarnLab.Size = new System.Drawing.Size(184, 26);
            this.removeWarnLab.TabIndex = 16;
            this.removeWarnLab.Text = "Perma removal of data is not advised.\r\nConsider deactivate option.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 40);
            this.panel5.TabIndex = 20;
            // 
            // delBtn
            // 
            this.delBtn.AutoSize = true;
            this.delBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.delBtn.Depth = 0;
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.delBtn.Location = new System.Drawing.Point(0, 0);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBtn.Name = "delBtn";
            this.delBtn.Primary = false;
            this.delBtn.Size = new System.Drawing.Size(191, 36);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Remove";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 46);
            this.panel2.TabIndex = 4;
            // 
            // UserAccessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakeryDash2531.Properties.Resources.HDHD_1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 654);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAccessManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccessManagement";
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label passLab;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label creLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox UserCheckBox;
        private System.Windows.Forms.MaskedTextBox crDateText;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGUIDCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffGUIDText;
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private MaterialSkin.Controls.MaterialFlatButton delBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label svWarnLab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label removeWarnLab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}