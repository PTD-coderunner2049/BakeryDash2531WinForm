namespace SolbergBakery2531.UI.Forms.AdministForms
{
    partial class ProdInfoManagement
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.svBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.delBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.collumBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterLab = new System.Windows.Forms.Label();
            this.rtnBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.title = new System.Windows.Forms.Label();
            this.ProdGrid = new System.Windows.Forms.DataGridView();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscontinueDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdTree = new System.Windows.Forms.TreeView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.svWarnLab = new System.Windows.Forms.Label();
            this.VisualList = new System.Windows.Forms.ListView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NameLab = new System.Windows.Forms.Label();
            this.DesLab = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DesText = new System.Windows.Forms.TextBox();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PriceLab = new System.Windows.Forms.Label();
            this.NoteLab = new System.Windows.Forms.Label();
            this.ADateLab = new System.Windows.Forms.Label();
            this.DDateLab = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VisualFlowList = new System.Windows.Forms.FlowLayoutPanel();
            this.ADateText = new System.Windows.Forms.DateTimePicker();
            this.DDateText = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrid)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.global_searchfill;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(777, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 46);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.valueBox);
            this.panel2.Controls.Add(this.collumBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.filterLab);
            this.panel2.Location = new System.Drawing.Point(193, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 46);
            this.panel2.TabIndex = 29;
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
            // rtnBtn
            // 
            this.rtnBtn.AutoSize = true;
            this.rtnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rtnBtn.Depth = 0;
            this.rtnBtn.Location = new System.Drawing.Point(1110, 17);
            this.rtnBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rtnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtnBtn.Name = "rtnBtn";
            this.rtnBtn.Primary = false;
            this.rtnBtn.Size = new System.Drawing.Size(64, 36);
            this.rtnBtn.TabIndex = 26;
            this.rtnBtn.Text = "Return";
            this.rtnBtn.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(15, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 22);
            this.title.TabIndex = 25;
            this.title.Text = "Product\'s Managment Interface";
            // 
            // ProdGrid
            // 
            this.ProdGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.ProdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ProdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.DescriptionCol,
            this.NameCol,
            this.PricingCol,
            this.AvailableDateCol,
            this.DiscontinueDateCol});
            this.ProdGrid.GridColor = System.Drawing.Color.Brown;
            this.ProdGrid.Location = new System.Drawing.Point(193, 110);
            this.ProdGrid.MultiSelect = false;
            this.ProdGrid.Name = "ProdGrid";
            this.ProdGrid.ReadOnly = true;
            this.ProdGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProdGrid.Size = new System.Drawing.Size(630, 528);
            this.ProdGrid.TabIndex = 27;
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
            // DescriptionCol
            // 
            this.DescriptionCol.DataPropertyName = "Description";
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            this.DescriptionCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescriptionCol.Width = 115;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCol.Width = 115;
            // 
            // PricingCol
            // 
            this.PricingCol.DataPropertyName = "Pricing";
            this.PricingCol.HeaderText = "Pricing [€]";
            this.PricingCol.Name = "PricingCol";
            this.PricingCol.ReadOnly = true;
            this.PricingCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PricingCol.Width = 80;
            // 
            // AvailableDateCol
            // 
            this.AvailableDateCol.DataPropertyName = "AvailableDate";
            this.AvailableDateCol.HeaderText = "AvailableDate";
            this.AvailableDateCol.Name = "AvailableDateCol";
            this.AvailableDateCol.ReadOnly = true;
            this.AvailableDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AvailableDateCol.Width = 120;
            // 
            // DiscontinueDateCol
            // 
            this.DiscontinueDateCol.DataPropertyName = "DiscontinueDate";
            this.DiscontinueDateCol.HeaderText = "DiscontinueDate";
            this.DiscontinueDateCol.Name = "DiscontinueDateCol";
            this.DiscontinueDateCol.ReadOnly = true;
            this.DiscontinueDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiscontinueDateCol.Width = 120;
            // 
            // ProdTree
            // 
            this.ProdTree.BackColor = System.Drawing.Color.OldLace;
            this.ProdTree.Location = new System.Drawing.Point(19, 58);
            this.ProdTree.Name = "ProdTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            this.ProdTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.ProdTree.Size = new System.Drawing.Size(148, 580);
            this.ProdTree.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OldLace;
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Location = new System.Drawing.Point(851, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(323, 528);
            this.panel7.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 40);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialFlatButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 40);
            this.panel3.TabIndex = 23;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.PapayaWhip;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(291, 38);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Insert";
            this.materialFlatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.svWarnLab);
            this.groupBox1.Controls.Add(this.VisualList);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 135);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProductVisualList";
            // 
            // svWarnLab
            // 
            this.svWarnLab.AutoSize = true;
            this.svWarnLab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.svWarnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svWarnLab.ForeColor = System.Drawing.Color.Firebrick;
            this.svWarnLab.Location = new System.Drawing.Point(5, 135);
            this.svWarnLab.Name = "svWarnLab";
            this.svWarnLab.Size = new System.Drawing.Size(49, 16);
            this.svWarnLab.TabIndex = 33;
            this.svWarnLab.Text = "              ";
            this.svWarnLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VisualList
            // 
            this.VisualList.HideSelection = false;
            this.VisualList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.VisualList.Location = new System.Drawing.Point(1, 19);
            this.VisualList.Name = "VisualList";
            this.VisualList.Size = new System.Drawing.Size(292, 114);
            this.VisualList.TabIndex = 33;
            this.VisualList.UseCompatibleStateImageBehavior = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(15, 475);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(293, 40);
            this.panel9.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(100, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 40);
            this.panel4.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.svBtn);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(193, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 40);
            this.panel11.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.delBtn);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 40);
            this.panel10.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(947, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.NameLab);
            this.groupBox2.Controls.Add(this.DesLab);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.PriceLab);
            this.groupBox2.Controls.Add(this.NoteLab);
            this.groupBox2.Controls.Add(this.ADateLab);
            this.groupBox2.Controls.Add(this.DDateLab);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(15, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProductInfo";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLab.Location = new System.Drawing.Point(38, 25);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(50, 16);
            this.NameLab.TabIndex = 33;
            this.NameLab.Text = "Name :";
            // 
            // DesLab
            // 
            this.DesLab.AutoSize = true;
            this.DesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesLab.Location = new System.Drawing.Point(7, 53);
            this.DesLab.Name = "DesLab";
            this.DesLab.Size = new System.Drawing.Size(81, 16);
            this.DesLab.TabIndex = 17;
            this.DesLab.Text = "Description :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameText);
            this.flowLayoutPanel1.Controls.Add(this.DesText);
            this.flowLayoutPanel1.Controls.Add(this.NoteText);
            this.flowLayoutPanel1.Controls.Add(this.PriceText);
            this.flowLayoutPanel1.Controls.Add(this.ADateText);
            this.flowLayoutPanel1.Controls.Add(this.DDateText);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 250);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(3, 3);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(187, 22);
            this.NameText.TabIndex = 37;
            // 
            // DesText
            // 
            this.DesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesText.Location = new System.Drawing.Point(3, 31);
            this.DesText.Multiline = true;
            this.DesText.Name = "DesText";
            this.DesText.Size = new System.Drawing.Size(187, 61);
            this.DesText.TabIndex = 14;
            // 
            // NoteText
            // 
            this.NoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteText.Location = new System.Drawing.Point(3, 98);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(187, 61);
            this.NoteText.TabIndex = 33;
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(3, 165);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(187, 22);
            this.PriceText.TabIndex = 35;
            // 
            // PriceLab
            // 
            this.PriceLab.AutoSize = true;
            this.PriceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLab.Location = new System.Drawing.Point(16, 187);
            this.PriceLab.Name = "PriceLab";
            this.PriceLab.Size = new System.Drawing.Size(72, 16);
            this.PriceLab.TabIndex = 27;
            this.PriceLab.Text = "Pricing [€] :";
            this.PriceLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoteLab
            // 
            this.NoteLab.AutoSize = true;
            this.NoteLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLab.Location = new System.Drawing.Point(43, 92);
            this.NoteLab.Name = "NoteLab";
            this.NoteLab.Size = new System.Drawing.Size(45, 16);
            this.NoteLab.TabIndex = 21;
            this.NoteLab.Text = " Note :";
            // 
            // ADateLab
            // 
            this.ADateLab.AutoSize = true;
            this.ADateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADateLab.Location = new System.Drawing.Point(18, 217);
            this.ADateLab.Name = "ADateLab";
            this.ADateLab.Size = new System.Drawing.Size(70, 16);
            this.ADateLab.TabIndex = 25;
            this.ADateLab.Text = "Available :";
            this.ADateLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DDateLab
            // 
            this.DDateLab.AutoSize = true;
            this.DDateLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDateLab.Location = new System.Drawing.Point(5, 245);
            this.DDateLab.Name = "DDateLab";
            this.DDateLab.Size = new System.Drawing.Size(83, 16);
            this.DDateLab.TabIndex = 26;
            this.DDateLab.Text = "Discontinue :";
            this.DDateLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.edit_2fill;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1128, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // VisualFlowList
            // 
            this.VisualFlowList.Location = new System.Drawing.Point(562, 505);
            this.VisualFlowList.Name = "VisualFlowList";
            this.VisualFlowList.Size = new System.Drawing.Size(200, 100);
            this.VisualFlowList.TabIndex = 34;
            // 
            // ADateText
            // 
            this.ADateText.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADateText.Location = new System.Drawing.Point(3, 193);
            this.ADateText.Name = "ADateText";
            this.ADateText.Size = new System.Drawing.Size(187, 22);
            this.ADateText.TabIndex = 35;
            // 
            // DDateText
            // 
            this.DDateText.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDateText.Location = new System.Drawing.Point(3, 221);
            this.DDateText.Name = "DDateText";
            this.DDateText.Size = new System.Drawing.Size(187, 22);
            this.DDateText.TabIndex = 38;
            // 
            // ProdInfoManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.ClientSize = new System.Drawing.Size(1190, 650);
            this.Controls.Add(this.VisualFlowList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.ProdTree);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rtnBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ProdGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdInfoManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdInfoManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGrid)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private MaterialSkin.Controls.MaterialFlatButton delBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.ComboBox collumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filterLab;
        private MaterialSkin.Controls.MaterialFlatButton rtnBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView ProdGrid;
        private System.Windows.Forms.TreeView ProdTree;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label DesLab;
        private System.Windows.Forms.TextBox DesText;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.Label NoteLab;
        private System.Windows.Forms.Label ADateLab;
        private System.Windows.Forms.Label DDateLab;
        private System.Windows.Forms.Label PriceLab;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label svWarnLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscontinueDateCol;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.ListView VisualList;
        private System.Windows.Forms.FlowLayoutPanel VisualFlowList;
        private System.Windows.Forms.DateTimePicker ADateText;
        private System.Windows.Forms.DateTimePicker DDateText;
    }
}