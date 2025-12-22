namespace SolbergBakery2531.UI.Forms
{
    partial class OrderComplier
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
            this.ProductTreeView = new System.Windows.Forms.TreeView();
            this.ProductFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.viewGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectionBox = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SelectionBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductTreeView
            // 
            this.ProductTreeView.Location = new System.Drawing.Point(5, 50);
            this.ProductTreeView.Name = "ProductTreeView";
            this.ProductTreeView.Size = new System.Drawing.Size(121, 517);
            this.ProductTreeView.TabIndex = 45;
            // 
            // ProductFlowLayoutPanel
            // 
            this.ProductFlowLayoutPanel.AutoScroll = true;
            this.ProductFlowLayoutPanel.BackColor = System.Drawing.Color.DimGray;
            this.ProductFlowLayoutPanel.Location = new System.Drawing.Point(0, 19);
            this.ProductFlowLayoutPanel.Name = "ProductFlowLayoutPanel";
            this.ProductFlowLayoutPanel.Size = new System.Drawing.Size(426, 495);
            this.ProductFlowLayoutPanel.TabIndex = 0;
            // 
            // viewGroup
            // 
            this.viewGroup.Controls.Add(this.ProductFlowLayoutPanel);
            this.viewGroup.Location = new System.Drawing.Point(3, 3);
            this.viewGroup.Name = "viewGroup";
            this.viewGroup.Size = new System.Drawing.Size(433, 514);
            this.viewGroup.TabIndex = 44;
            this.viewGroup.TabStop = false;
            this.viewGroup.Text = "Avaiable";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.viewGroup);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 517);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // SelectionBox
            // 
            this.SelectionBox.BackColor = System.Drawing.Color.OldLace;
            this.SelectionBox.Controls.Add(this.flowLayoutPanel1);
            this.SelectionBox.Controls.Add(this.ProductTreeView);
            this.SelectionBox.Controls.Add(this.panel1);
            this.SelectionBox.Location = new System.Drawing.Point(12, 12);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(575, 587);
            this.SelectionBox.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OldLace;
            this.panel5.Controls.Add(this.flowLayoutPanel2);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(707, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(462, 587);
            this.panel5.TabIndex = 51;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.orderGroupBox);
            this.flowLayoutPanel2.Controls.Add(this.panel8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 534);
            this.flowLayoutPanel2.TabIndex = 49;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.OrderGrid);
            this.orderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(433, 476);
            this.orderGroupBox.TabIndex = 44;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Drafting";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.materialFlatButton1);
            this.panel8.Location = new System.Drawing.Point(3, 485);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(426, 46);
            this.panel8.TabIndex = 42;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialFlatButton1.Location = new System.Drawing.Point(325, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(101, 46);
            this.materialFlatButton1.TabIndex = 38;
            this.materialFlatButton1.Text = "Complie Bill";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // OrderGrid
            // 
            this.OrderGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.NameCol,
            this.PricingCol,
            this.QuantityCol});
            this.OrderGrid.GridColor = System.Drawing.Color.Brown;
            this.OrderGrid.Location = new System.Drawing.Point(-5, 19);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderGrid.Size = new System.Drawing.Size(436, 451);
            this.OrderGrid.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 44);
            this.panel1.TabIndex = 42;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(270, 29);
            this.Title.TabIndex = 23;
            this.Title.Text = "Order Complier Interface";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(462, 44);
            this.panel9.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Drafting Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUIDCol
            // 
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            this.GUIDCol.ReadOnly = true;
            this.GUIDCol.Visible = false;
            // 
            // NameCol
            // 
            this.NameCol.DataPropertyName = "Name";
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCol.Width = 200;
            // 
            // PricingCol
            // 
            this.PricingCol.DataPropertyName = "Pricing";
            this.PricingCol.HeaderText = "Pricing [€]";
            this.PricingCol.Name = "PricingCol";
            this.PricingCol.ReadOnly = true;
            this.PricingCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QuantityCol
            // 
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderComplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.ClientSize = new System.Drawing.Size(1190, 650);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.SelectionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderComplier";
            this.Text = "OrderComplier";
            this.viewGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.SelectionBox.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.orderGroupBox.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView ProductTreeView;
        private System.Windows.Forms.FlowLayoutPanel ProductFlowLayoutPanel;
        private System.Windows.Forms.GroupBox viewGroup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel SelectionBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
    }
}