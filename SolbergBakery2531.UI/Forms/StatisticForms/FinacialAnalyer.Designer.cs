namespace SolbergBakery2531.UI.Forms.StatisticForms
{
    partial class FinacialAnalyer
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.removeWarnLab = new MaterialSkin.Controls.MaterialLabel();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLimitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ClrBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.revBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.complieBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OldLace;
            this.panel5.Controls.Add(this.flowLayoutPanel2);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(45, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 587);
            this.panel5.TabIndex = 52;
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
            this.orderGroupBox.Controls.Add(this.removeWarnLab);
            this.orderGroupBox.Controls.Add(this.OrderGrid);
            this.orderGroupBox.Location = new System.Drawing.Point(3, 3);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(433, 476);
            this.orderGroupBox.TabIndex = 44;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Drafting";
            // 
            // removeWarnLab
            // 
            this.removeWarnLab.AutoSize = true;
            this.removeWarnLab.Depth = 0;
            this.removeWarnLab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeWarnLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.removeWarnLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeWarnLab.Location = new System.Drawing.Point(3, 454);
            this.removeWarnLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeWarnLab.Name = "removeWarnLab";
            this.removeWarnLab.Size = new System.Drawing.Size(82, 19);
            this.removeWarnLab.TabIndex = 41;
            this.removeWarnLab.Text = "Drafting.....";
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
            this.QuantityCol,
            this.StockLimitCol});
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
            this.OrderGrid.Size = new System.Drawing.Size(436, 435);
            this.OrderGrid.TabIndex = 28;
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
            // StockLimitCol
            // 
            this.StockLimitCol.HeaderText = "StockLimit";
            this.StockLimitCol.Name = "StockLimitCol";
            this.StockLimitCol.ReadOnly = true;
            this.StockLimitCol.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ClrBtn);
            this.panel8.Controls.Add(this.revBtn);
            this.panel8.Controls.Add(this.complieBtn);
            this.panel8.Location = new System.Drawing.Point(3, 485);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(426, 46);
            this.panel8.TabIndex = 42;
            // 
            // ClrBtn
            // 
            this.ClrBtn.AutoSize = true;
            this.ClrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClrBtn.Depth = 0;
            this.ClrBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClrBtn.Location = new System.Drawing.Point(271, 0);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClrBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Primary = false;
            this.ClrBtn.Size = new System.Drawing.Size(54, 46);
            this.ClrBtn.TabIndex = 41;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            // 
            // revBtn
            // 
            this.revBtn.AutoSize = true;
            this.revBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.revBtn.Depth = 0;
            this.revBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.revBtn.Location = new System.Drawing.Point(0, 0);
            this.revBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.revBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.revBtn.Name = "revBtn";
            this.revBtn.Primary = false;
            this.revBtn.Size = new System.Drawing.Size(109, 46);
            this.revBtn.TabIndex = 39;
            this.revBtn.Text = "Undraft Item";
            this.revBtn.UseVisualStyleBackColor = true;
            // 
            // complieBtn
            // 
            this.complieBtn.AutoSize = true;
            this.complieBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.complieBtn.Depth = 0;
            this.complieBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.complieBtn.Location = new System.Drawing.Point(325, 0);
            this.complieBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.complieBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.complieBtn.Name = "complieBtn";
            this.complieBtn.Primary = false;
            this.complieBtn.Size = new System.Drawing.Size(101, 46);
            this.complieBtn.TabIndex = 38;
            this.complieBtn.Text = "Complie Bill";
            this.complieBtn.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(447, 44);
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
            // FinacialAnalyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.ClientSize = new System.Drawing.Size(1165, 650);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinacialAnalyer";
            this.Text = "FinacialAnalyer";
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private MaterialSkin.Controls.MaterialLabel removeWarnLab;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLimitCol;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialFlatButton ClrBtn;
        private MaterialSkin.Controls.MaterialFlatButton revBtn;
        private MaterialSkin.Controls.MaterialFlatButton complieBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
    }
}