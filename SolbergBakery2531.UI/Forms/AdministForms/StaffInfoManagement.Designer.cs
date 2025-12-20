namespace SolbergBakery2531.UI
{
    partial class StaffInfoManagement
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
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payrateText = new System.Windows.Forms.TextBox();
            this.payrateLab = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.CheckedListBox();
            this.StatusRoleBox = new System.Windows.Forms.CheckedListBox();
            this.genderLab = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phoneLab = new System.Windows.Forms.Label();
            this.emailLab = new System.Windows.Forms.Label();
            this.ssnLab = new System.Windows.Forms.Label();
            this.LnameText = new System.Windows.Forms.TextBox();
            this.birthLab = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.birthText = new System.Windows.Forms.MaskedTextBox();
            this.staffGUIDText = new System.Windows.Forms.TextBox();
            this.guidLab = new System.Windows.Forms.Label();
            this.ssnText = new System.Windows.Forms.TextBox();
            this.nameLab = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.instBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.historyBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.svWarnLab = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.svBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.rtnBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.collumBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterLab = new System.Windows.Forms.Label();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSNCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayrateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.title.Size = new System.Drawing.Size(280, 22);
            this.title.TabIndex = 0;
            this.title.Text = "Staff\'s Managment Interface";
            // 
            // StaffGrid
            // 
            this.StaffGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.StaffGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.FnameCol,
            this.LnameCol,
            this.EmailCol,
            this.PhoneCol,
            this.GenderCol,
            this.BirthCol,
            this.SSNCol,
            this.EmployDateCol,
            this.PayrateCol,
            this.RoleCol,
            this.ActiveCol});
            this.StaffGrid.GridColor = System.Drawing.Color.Brown;
            this.StaffGrid.Location = new System.Drawing.Point(16, 119);
            this.StaffGrid.MultiSelect = false;
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StaffGrid.Size = new System.Drawing.Size(1156, 348);
            this.StaffGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.payrateText);
            this.groupBox1.Controls.Add(this.payrateLab);
            this.groupBox1.Controls.Add(this.genderBox);
            this.groupBox1.Controls.Add(this.StatusRoleBox);
            this.groupBox1.Controls.Add(this.genderLab);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.phoneLab);
            this.groupBox1.Controls.Add(this.emailLab);
            this.groupBox1.Controls.Add(this.ssnLab);
            this.groupBox1.Controls.Add(this.LnameText);
            this.groupBox1.Controls.Add(this.birthLab);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.birthText);
            this.groupBox1.Controls.Add(this.staffGUIDText);
            this.groupBox1.Controls.Add(this.guidLab);
            this.groupBox1.Controls.Add(this.ssnText);
            this.groupBox1.Controls.Add(this.nameLab);
            this.groupBox1.Controls.Add(this.FnameText);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // payrateText
            // 
            this.payrateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrateText.Location = new System.Drawing.Point(661, 22);
            this.payrateText.Name = "payrateText";
            this.payrateText.Size = new System.Drawing.Size(211, 26);
            this.payrateText.TabIndex = 34;
            // 
            // payrateLab
            // 
            this.payrateLab.AutoSize = true;
            this.payrateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrateLab.Location = new System.Drawing.Point(584, 25);
            this.payrateLab.Name = "payrateLab";
            this.payrateLab.Size = new System.Drawing.Size(71, 20);
            this.payrateLab.TabIndex = 34;
            this.payrateLab.Text = "Payrate :";
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(661, 60);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(211, 38);
            this.genderBox.TabIndex = 20;
            // 
            // StatusRoleBox
            // 
            this.StatusRoleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRoleBox.FormattingEnabled = true;
            this.StatusRoleBox.Location = new System.Drawing.Point(661, 105);
            this.StatusRoleBox.Name = "StatusRoleBox";
            this.StatusRoleBox.Size = new System.Drawing.Size(211, 38);
            this.StatusRoleBox.TabIndex = 3;
            // 
            // genderLab
            // 
            this.genderLab.AutoSize = true;
            this.genderLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLab.Location = new System.Drawing.Point(584, 60);
            this.genderLab.Name = "genderLab";
            this.genderLab.Size = new System.Drawing.Size(71, 20);
            this.genderLab.TabIndex = 33;
            this.genderLab.Text = "Gender :";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(390, 54);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(190, 26);
            this.phoneText.TabIndex = 19;
            // 
            // phoneLab
            // 
            this.phoneLab.AutoSize = true;
            this.phoneLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLab.Location = new System.Drawing.Point(321, 57);
            this.phoneLab.Name = "phoneLab";
            this.phoneLab.Size = new System.Drawing.Size(63, 20);
            this.phoneLab.TabIndex = 18;
            this.phoneLab.Text = "Phone :";
            // 
            // emailLab
            // 
            this.emailLab.AutoSize = true;
            this.emailLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLab.Location = new System.Drawing.Point(328, 89);
            this.emailLab.Name = "emailLab";
            this.emailLab.Size = new System.Drawing.Size(56, 20);
            this.emailLab.TabIndex = 17;
            this.emailLab.Text = "Email :";
            // 
            // ssnLab
            // 
            this.ssnLab.AutoSize = true;
            this.ssnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLab.Location = new System.Drawing.Point(49, 89);
            this.ssnLab.Name = "ssnLab";
            this.ssnLab.Size = new System.Drawing.Size(50, 20);
            this.ssnLab.TabIndex = 16;
            this.ssnLab.Text = "SSN :";
            // 
            // LnameText
            // 
            this.LnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameText.Location = new System.Drawing.Point(491, 22);
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(89, 26);
            this.LnameText.TabIndex = 32;
            // 
            // birthLab
            // 
            this.birthLab.AutoSize = true;
            this.birthLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLab.Location = new System.Drawing.Point(49, 120);
            this.birthLab.Name = "birthLab";
            this.birthLab.Size = new System.Drawing.Size(50, 20);
            this.birthLab.TabIndex = 20;
            this.birthLab.Text = "Birth :";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(390, 86);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(190, 26);
            this.emailText.TabIndex = 11;
            // 
            // birthText
            // 
            this.birthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthText.Location = new System.Drawing.Point(105, 117);
            this.birthText.Mask = "00/00/0000";
            this.birthText.Name = "birthText";
            this.birthText.Size = new System.Drawing.Size(190, 26);
            this.birthText.TabIndex = 22;
            this.birthText.ValidatingType = typeof(System.DateTime);
            // 
            // staffGUIDText
            // 
            this.staffGUIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGUIDText.Location = new System.Drawing.Point(105, 19);
            this.staffGUIDText.Multiline = true;
            this.staffGUIDText.Name = "staffGUIDText";
            this.staffGUIDText.Size = new System.Drawing.Size(190, 61);
            this.staffGUIDText.TabIndex = 14;
            // 
            // guidLab
            // 
            this.guidLab.AutoSize = true;
            this.guidLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidLab.Location = new System.Drawing.Point(9, 22);
            this.guidLab.Name = "guidLab";
            this.guidLab.Size = new System.Drawing.Size(90, 20);
            this.guidLab.TabIndex = 15;
            this.guidLab.Text = "Staff Guid :";
            // 
            // ssnText
            // 
            this.ssnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnText.Location = new System.Drawing.Point(105, 86);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(190, 26);
            this.ssnText.TabIndex = 7;
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLab.Location = new System.Drawing.Point(302, 25);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(82, 20);
            this.nameLab.TabIndex = 25;
            this.nameLab.Text = "Fullname :";
            // 
            // FnameText
            // 
            this.FnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameText.Location = new System.Drawing.Point(390, 22);
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(89, 26);
            this.FnameText.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.svWarnLab);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(16, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 169);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Location = new System.Drawing.Point(1032, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.instBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 40);
            this.panel8.TabIndex = 21;
            // 
            // instBtn
            // 
            this.instBtn.AutoSize = true;
            this.instBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.instBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.instBtn.Depth = 0;
            this.instBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instBtn.Location = new System.Drawing.Point(0, 0);
            this.instBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.instBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.instBtn.Name = "instBtn";
            this.instBtn.Primary = false;
            this.instBtn.Size = new System.Drawing.Size(98, 38);
            this.instBtn.TabIndex = 3;
            this.instBtn.Text = "Insert";
            this.instBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.instBtn.UseVisualStyleBackColor = false;
            this.instBtn.Click += new System.EventHandler(this.instBtn_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.historyBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 40);
            this.panel9.TabIndex = 20;
            // 
            // historyBtn
            // 
            this.historyBtn.AutoSize = true;
            this.historyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.historyBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.historyBtn.Depth = 0;
            this.historyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBtn.Location = new System.Drawing.Point(0, 0);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.historyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Primary = false;
            this.historyBtn.Size = new System.Drawing.Size(98, 38);
            this.historyBtn.TabIndex = 4;
            this.historyBtn.Text = "history";
            this.historyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // svWarnLab
            // 
            this.svWarnLab.AutoSize = true;
            this.svWarnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svWarnLab.ForeColor = System.Drawing.Color.Maroon;
            this.svWarnLab.Location = new System.Drawing.Point(947, 15);
            this.svWarnLab.Name = "svWarnLab";
            this.svWarnLab.Size = new System.Drawing.Size(0, 13);
            this.svWarnLab.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(926, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.svBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 40);
            this.panel6.TabIndex = 21;
            // 
            // svBtn
            // 
            this.svBtn.AutoSize = true;
            this.svBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.svBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.svBtn.Depth = 0;
            this.svBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svBtn.Location = new System.Drawing.Point(0, 0);
            this.svBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.svBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.svBtn.Name = "svBtn";
            this.svBtn.Primary = false;
            this.svBtn.Size = new System.Drawing.Size(98, 38);
            this.svBtn.TabIndex = 3;
            this.svBtn.Text = "Save Changes";
            this.svBtn.UseVisualStyleBackColor = false;
            this.svBtn.Click += new System.EventHandler(this.svBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.delBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 40);
            this.panel5.TabIndex = 20;
            // 
            // delBtn
            // 
            this.delBtn.AutoSize = true;
            this.delBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.delBtn.Depth = 0;
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delBtn.Location = new System.Drawing.Point(0, 0);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBtn.Name = "delBtn";
            this.delBtn.Primary = false;
            this.delBtn.Size = new System.Drawing.Size(98, 38);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Remove";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // rtnBtn
            // 
            this.rtnBtn.AutoSize = true;
            this.rtnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rtnBtn.Depth = 0;
            this.rtnBtn.Location = new System.Drawing.Point(1107, 26);
            this.rtnBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rtnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtnBtn.Name = "rtnBtn";
            this.rtnBtn.Primary = false;
            this.rtnBtn.Size = new System.Drawing.Size(64, 36);
            this.rtnBtn.TabIndex = 1;
            this.rtnBtn.Text = "Return";
            this.rtnBtn.UseVisualStyleBackColor = true;
            this.rtnBtn.Click += new System.EventHandler(this.rtnBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.global_searchfill;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(602, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.valueBox);
            this.panel2.Controls.Add(this.collumBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.filterLab);
            this.panel2.Location = new System.Drawing.Point(16, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 46);
            this.panel2.TabIndex = 23;
            // 
            // valueBox
            // 
            this.valueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBox.Location = new System.Drawing.Point(108, 12);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(166, 20);
            this.valueBox.TabIndex = 16;
            // 
            // collumBox
            // 
            this.collumBox.FormattingEnabled = true;
            this.collumBox.Location = new System.Drawing.Point(324, 11);
            this.collumBox.Name = "collumBox";
            this.collumBox.Size = new System.Drawing.Size(121, 21);
            this.collumBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "by :";
            // 
            // filterLab
            // 
            this.filterLab.AutoSize = true;
            this.filterLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLab.Location = new System.Drawing.Point(19, 12);
            this.filterLab.Name = "filterLab";
            this.filterLab.Size = new System.Drawing.Size(83, 20);
            this.filterLab.TabIndex = 16;
            this.filterLab.Text = "Search for";
            // 
            // GUIDCol
            // 
            this.GUIDCol.DataPropertyName = "Id";
            this.GUIDCol.Frozen = true;
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            this.GUIDCol.ReadOnly = true;
            this.GUIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GUIDCol.Width = 40;
            // 
            // FnameCol
            // 
            this.FnameCol.DataPropertyName = "FirstName";
            this.FnameCol.HeaderText = "Fname";
            this.FnameCol.Name = "FnameCol";
            this.FnameCol.ReadOnly = true;
            this.FnameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FnameCol.Width = 70;
            // 
            // LnameCol
            // 
            this.LnameCol.DataPropertyName = "LastName";
            this.LnameCol.HeaderText = "Lname";
            this.LnameCol.Name = "LnameCol";
            this.LnameCol.ReadOnly = true;
            this.LnameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LnameCol.Width = 62;
            // 
            // EmailCol
            // 
            this.EmailCol.DataPropertyName = "Email";
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            this.EmailCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmailCol.Width = 150;
            // 
            // PhoneCol
            // 
            this.PhoneCol.DataPropertyName = "PhoneContact";
            this.PhoneCol.HeaderText = "Contact";
            this.PhoneCol.Name = "PhoneCol";
            this.PhoneCol.ReadOnly = true;
            this.PhoneCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhoneCol.Width = 130;
            // 
            // GenderCol
            // 
            this.GenderCol.DataPropertyName = "Gender";
            this.GenderCol.HeaderText = "Gender";
            this.GenderCol.Name = "GenderCol";
            this.GenderCol.ReadOnly = true;
            this.GenderCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GenderCol.Width = 45;
            // 
            // BirthCol
            // 
            this.BirthCol.DataPropertyName = "Birth";
            this.BirthCol.HeaderText = "Birth";
            this.BirthCol.Name = "BirthCol";
            this.BirthCol.ReadOnly = true;
            this.BirthCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BirthCol.Width = 130;
            // 
            // SSNCol
            // 
            this.SSNCol.DataPropertyName = "SSN";
            this.SSNCol.HeaderText = "SSN";
            this.SSNCol.Name = "SSNCol";
            this.SSNCol.ReadOnly = true;
            this.SSNCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SSNCol.Width = 130;
            // 
            // EmployDateCol
            // 
            this.EmployDateCol.DataPropertyName = "LastHistoryStart";
            this.EmployDateCol.HeaderText = "LastEmployment";
            this.EmployDateCol.Name = "EmployDateCol";
            this.EmployDateCol.ReadOnly = true;
            this.EmployDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployDateCol.Width = 130;
            // 
            // PayrateCol
            // 
            this.PayrateCol.DataPropertyName = "PayratePerHrs";
            this.PayrateCol.HeaderText = "Payrate [€]";
            this.PayrateCol.Name = "PayrateCol";
            this.PayrateCol.ReadOnly = true;
            this.PayrateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RoleCol
            // 
            this.RoleCol.DataPropertyName = "IsSystemManager";
            this.RoleCol.HeaderText = "IsSystemManager";
            this.RoleCol.Name = "RoleCol";
            this.RoleCol.ReadOnly = true;
            this.RoleCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoleCol.Width = 80;
            // 
            // ActiveCol
            // 
            this.ActiveCol.DataPropertyName = "Active";
            this.ActiveCol.HeaderText = "Active";
            this.ActiveCol.Name = "ActiveCol";
            this.ActiveCol.ReadOnly = true;
            this.ActiveCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ActiveCol.Width = 45;
            // 
            // StaffInfoManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.HDHD_1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 650);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtnBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfoManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfoManagment";
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox ssnText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox StatusRoleBox;
        private System.Windows.Forms.Label guidLab;
        private System.Windows.Forms.TextBox staffGUIDText;
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private MaterialSkin.Controls.MaterialFlatButton delBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.Label ssnLab;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phoneLab;
        private System.Windows.Forms.MaskedTextBox birthText;
        private System.Windows.Forms.Label birthLab;
        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.Label genderLab;
        private System.Windows.Forms.CheckedListBox genderBox;
        private System.Windows.Forms.TextBox payrateText;
        private System.Windows.Forms.Label payrateLab;
        private MaterialSkin.Controls.MaterialFlatButton instBtn;
        private System.Windows.Forms.Label svWarnLab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private MaterialSkin.Controls.MaterialFlatButton historyBtn;
        private MaterialSkin.Controls.MaterialFlatButton rtnBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox collumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filterLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSNCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveCol;
    }
}