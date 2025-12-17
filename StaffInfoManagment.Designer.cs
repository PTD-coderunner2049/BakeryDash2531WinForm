namespace BakeryDash2531
{
    partial class StaffInfoManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guidLab = new System.Windows.Forms.Label();
            this.staffGUIDText = new System.Windows.Forms.TextBox();
            this.StaffCheckBox = new System.Windows.Forms.CheckedListBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.SSNText = new System.Windows.Forms.TextBox();
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
            this.valueBox = new System.Windows.Forms.TextBox();
            this.collumBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterLab = new System.Windows.Forms.Label();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LnameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSNCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayrateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssnLab = new System.Windows.Forms.Label();
            this.emailLab = new System.Windows.Forms.Label();
            this.phoneLab = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.birthLab = new System.Windows.Forms.Label();
            this.employdateText = new System.Windows.Forms.MaskedTextBox();
            this.birthText = new System.Windows.Forms.MaskedTextBox();
            this.empLab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.LnameText = new System.Windows.Forms.TextBox();
            this.genderLab = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.RoleCol,
            this.GenderCol,
            this.EmployDateCol,
            this.PhoneCol,
            this.EmailCol,
            this.SSNCol,
            this.Birth,
            this.ActiveCol,
            this.PayrateCol});
            this.StaffGrid.GridColor = System.Drawing.Color.Brown;
            this.StaffGrid.Location = new System.Drawing.Point(16, 119);
            this.StaffGrid.MultiSelect = false;
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StaffGrid.Size = new System.Drawing.Size(1156, 348);
            this.StaffGrid.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.genderBox);
            this.groupBox1.Controls.Add(this.empLab);
            this.groupBox1.Controls.Add(this.employdateText);
            this.groupBox1.Controls.Add(this.StaffCheckBox);
            this.groupBox1.Controls.Add(this.genderLab);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.phoneLab);
            this.groupBox1.Controls.Add(this.emailLab);
            this.groupBox1.Controls.Add(this.ssnLab);
            this.groupBox1.Controls.Add(this.LnameText);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.birthLab);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.birthText);
            this.groupBox1.Controls.Add(this.staffGUIDText);
            this.groupBox1.Controls.Add(this.guidLab);
            this.groupBox1.Controls.Add(this.SSNText);
            this.groupBox1.Controls.Add(this.nameLab);
            this.groupBox1.Controls.Add(this.FnameText);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
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
            // staffGUIDText
            // 
            this.staffGUIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGUIDText.Location = new System.Drawing.Point(105, 19);
            this.staffGUIDText.Multiline = true;
            this.staffGUIDText.Name = "staffGUIDText";
            this.staffGUIDText.Size = new System.Drawing.Size(190, 61);
            this.staffGUIDText.TabIndex = 14;
            // 
            // StaffCheckBox
            // 
            this.StaffCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffCheckBox.FormattingEnabled = true;
            this.StaffCheckBox.Items.AddRange(new object[] {
            "Is System Manager",
            "Is Activated"});
            this.StaffCheckBox.Location = new System.Drawing.Point(661, 101);
            this.StaffCheckBox.Name = "StaffCheckBox";
            this.StaffCheckBox.Size = new System.Drawing.Size(151, 38);
            this.StaffCheckBox.TabIndex = 3;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(390, 86);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(190, 26);
            this.emailText.TabIndex = 11;
            // 
            // SSNText
            // 
            this.SSNText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNText.Location = new System.Drawing.Point(105, 86);
            this.SSNText.Name = "SSNText";
            this.SSNText.Size = new System.Drawing.Size(190, 26);
            this.SSNText.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(16, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 169);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.svWarnLab);
            this.panel4.Location = new System.Drawing.Point(882, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.svBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(98, 40);
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
            this.svBtn.Size = new System.Drawing.Size(98, 36);
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
            this.svWarnLab.Size = new System.Drawing.Size(91, 39);
            this.svWarnLab.TabIndex = 17;
            this.svWarnLab.Text = "Non-existing entry\r\nwill be created\r\nautomatically.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.removeWarnLab);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(988, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 18;
            // 
            // removeWarnLab
            // 
            this.removeWarnLab.AutoSize = true;
            this.removeWarnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeWarnLab.ForeColor = System.Drawing.Color.Maroon;
            this.removeWarnLab.Location = new System.Drawing.Point(3, 43);
            this.removeWarnLab.Name = "removeWarnLab";
            this.removeWarnLab.Size = new System.Drawing.Size(101, 52);
            this.removeWarnLab.TabIndex = 16;
            this.removeWarnLab.Text = "Perma removal of\r\ndata is not advised.\r\nConsider deactivate\r\noption.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(98, 40);
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
            this.delBtn.Size = new System.Drawing.Size(98, 36);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Remove";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.valueBox);
            this.panel2.Controls.Add(this.collumBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.filterLab);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 46);
            this.panel2.TabIndex = 4;
            // 
            // valueBox
            // 
            this.valueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBox.Location = new System.Drawing.Point(104, 14);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(166, 20);
            this.valueBox.TabIndex = 16;
            // 
            // collumBox
            // 
            this.collumBox.FormattingEnabled = true;
            this.collumBox.Location = new System.Drawing.Point(320, 13);
            this.collumBox.Name = "collumBox";
            this.collumBox.Size = new System.Drawing.Size(121, 21);
            this.collumBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "by :";
            // 
            // filterLab
            // 
            this.filterLab.AutoSize = true;
            this.filterLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLab.Location = new System.Drawing.Point(15, 14);
            this.filterLab.Name = "filterLab";
            this.filterLab.Size = new System.Drawing.Size(83, 20);
            this.filterLab.TabIndex = 16;
            this.filterLab.Text = "Search for";
            // 
            // GUIDCol
            // 
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            this.GUIDCol.ReadOnly = true;
            this.GUIDCol.Width = 40;
            // 
            // FnameCol
            // 
            this.FnameCol.HeaderText = "Fname";
            this.FnameCol.Name = "FnameCol";
            this.FnameCol.ReadOnly = true;
            this.FnameCol.Width = 70;
            // 
            // LnameCol
            // 
            this.LnameCol.HeaderText = "Lname";
            this.LnameCol.Name = "LnameCol";
            this.LnameCol.ReadOnly = true;
            this.LnameCol.Width = 60;
            // 
            // RoleCol
            // 
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.Name = "RoleCol";
            this.RoleCol.ReadOnly = true;
            this.RoleCol.Width = 70;
            // 
            // GenderCol
            // 
            this.GenderCol.HeaderText = "Gender";
            this.GenderCol.Name = "GenderCol";
            this.GenderCol.ReadOnly = true;
            this.GenderCol.Width = 45;
            // 
            // EmployDateCol
            // 
            this.EmployDateCol.HeaderText = "EmployedAt";
            this.EmployDateCol.Name = "EmployDateCol";
            this.EmployDateCol.ReadOnly = true;
            // 
            // PhoneCol
            // 
            this.PhoneCol.HeaderText = "Contact";
            this.PhoneCol.Name = "PhoneCol";
            this.PhoneCol.ReadOnly = true;
            this.PhoneCol.Width = 150;
            // 
            // EmailCol
            // 
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            this.EmailCol.Width = 180;
            // 
            // SSNCol
            // 
            this.SSNCol.HeaderText = "SSN";
            this.SSNCol.Name = "SSNCol";
            this.SSNCol.ReadOnly = true;
            this.SSNCol.Width = 150;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Birth";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            this.Birth.Width = 150;
            // 
            // ActiveCol
            // 
            this.ActiveCol.HeaderText = "Active";
            this.ActiveCol.Name = "ActiveCol";
            this.ActiveCol.ReadOnly = true;
            this.ActiveCol.Width = 45;
            // 
            // PayrateCol
            // 
            this.PayrateCol.HeaderText = "Payrate";
            this.PayrateCol.Name = "PayrateCol";
            this.PayrateCol.ReadOnly = true;
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
            // phoneLab
            // 
            this.phoneLab.AutoSize = true;
            this.phoneLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLab.Location = new System.Drawing.Point(592, 25);
            this.phoneLab.Name = "phoneLab";
            this.phoneLab.Size = new System.Drawing.Size(63, 20);
            this.phoneLab.TabIndex = 18;
            this.phoneLab.Text = "Phone :";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(661, 22);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(190, 26);
            this.phoneText.TabIndex = 19;
            // 
            // birthLab
            // 
            this.birthLab.AutoSize = true;
            this.birthLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLab.Location = new System.Drawing.Point(334, 121);
            this.birthLab.Name = "birthLab";
            this.birthLab.Size = new System.Drawing.Size(50, 20);
            this.birthLab.TabIndex = 20;
            this.birthLab.Text = "Birth :";
            // 
            // employdateText
            // 
            this.employdateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employdateText.Location = new System.Drawing.Point(105, 118);
            this.employdateText.Mask = "00/00/0000";
            this.employdateText.Name = "employdateText";
            this.employdateText.Size = new System.Drawing.Size(190, 26);
            this.employdateText.TabIndex = 21;
            this.employdateText.ValidatingType = typeof(System.DateTime);
            // 
            // birthText
            // 
            this.birthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthText.Location = new System.Drawing.Point(390, 118);
            this.birthText.Mask = "00/00/0000";
            this.birthText.Name = "birthText";
            this.birthText.Size = new System.Drawing.Size(190, 26);
            this.birthText.TabIndex = 22;
            this.birthText.ValidatingType = typeof(System.DateTime);
            // 
            // empLab
            // 
            this.empLab.AutoSize = true;
            this.empLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLab.Location = new System.Drawing.Point(44, 121);
            this.empLab.Name = "empLab";
            this.empLab.Size = new System.Drawing.Size(55, 20);
            this.empLab.TabIndex = 23;
            this.empLab.Text = "Hired :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(390, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone :";
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
            // LnameText
            // 
            this.LnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameText.Location = new System.Drawing.Point(491, 22);
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(89, 26);
            this.LnameText.TabIndex = 32;
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
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderBox.Location = new System.Drawing.Point(661, 57);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(151, 38);
            this.genderBox.TabIndex = 20;
            // 
            // StaffInfoManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BakeryDash2531.Properties.Resources.HDHD_1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 654);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffInfoManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfoManagment";
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
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
        private System.Windows.Forms.TextBox SSNText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox StaffCheckBox;
        private System.Windows.Forms.Label guidLab;
        private System.Windows.Forms.TextBox staffGUIDText;
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private MaterialSkin.Controls.MaterialFlatButton delBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label svWarnLab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label removeWarnLab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label filterLab;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox collumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LnameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSNCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrateCol;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.Label ssnLab;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phoneLab;
        private System.Windows.Forms.MaskedTextBox birthText;
        private System.Windows.Forms.MaskedTextBox employdateText;
        private System.Windows.Forms.Label birthLab;
        private System.Windows.Forms.Label empLab;
        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.Label genderLab;
        private System.Windows.Forms.CheckedListBox genderBox;
    }
}