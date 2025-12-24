namespace SolbergBakery2531.UI.Forms.StatisticForms
{
    partial class FinacialStatistician
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaleGroupBox = new System.Windows.Forms.GroupBox();
            this.TopsaleGrid = new System.Windows.Forms.DataGridView();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.GrossLab1 = new MaterialSkin.Controls.MaterialLabel();
            this.ProfitLab11 = new MaterialSkin.Controls.MaterialLabel();
            this.ProfitLab = new MaterialSkin.Controls.MaterialLabel();
            this.GrossLab = new MaterialSkin.Controls.MaterialLabel();
            this.FinancialChart_Gross = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthFilterComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.YearFilterComboBox = new System.Windows.Forms.ComboBox();
            this.FinancialChart_Profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SaleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopsaleGrid)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart_Gross)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart_Profit)).BeginInit();
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
            this.flowLayoutPanel2.Controls.Add(this.SaleGroupBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 534);
            this.flowLayoutPanel2.TabIndex = 49;
            // 
            // SaleGroupBox
            // 
            this.SaleGroupBox.Controls.Add(this.TopsaleGrid);
            this.SaleGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SaleGroupBox.Name = "SaleGroupBox";
            this.SaleGroupBox.Size = new System.Drawing.Size(433, 517);
            this.SaleGroupBox.TabIndex = 44;
            this.SaleGroupBox.TabStop = false;
            this.SaleGroupBox.Text = "Sale Sumarise";
            // 
            // TopsaleGrid
            // 
            this.TopsaleGrid.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.TopsaleGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopsaleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TopsaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TopsaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.NameCol,
            this.QuantityCol,
            this.TotalProfitCol});
            this.TopsaleGrid.GridColor = System.Drawing.Color.Brown;
            this.TopsaleGrid.Location = new System.Drawing.Point(-5, 19);
            this.TopsaleGrid.MultiSelect = false;
            this.TopsaleGrid.Name = "TopsaleGrid";
            this.TopsaleGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TopsaleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TopsaleGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TopsaleGrid.Size = new System.Drawing.Size(436, 492);
            this.TopsaleGrid.TabIndex = 28;
            // 
            // GUIDCol
            // 
            this.GUIDCol.DataPropertyName = "Id";
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
            // QuantityCol
            // 
            this.QuantityCol.DataPropertyName = "Quantity";
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalProfitCol
            // 
            this.TotalProfitCol.DataPropertyName = "Profit";
            this.TotalProfitCol.HeaderText = "TotalProfit";
            this.TotalProfitCol.Name = "TotalProfitCol";
            this.TotalProfitCol.ReadOnly = true;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.GrossLab1);
            this.panel8.Controls.Add(this.ProfitLab11);
            this.panel8.Controls.Add(this.ProfitLab);
            this.panel8.Controls.Add(this.GrossLab);
            this.panel8.Location = new System.Drawing.Point(3, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(542, 20);
            this.panel8.TabIndex = 42;
            // 
            // GrossLab1
            // 
            this.GrossLab1.AutoSize = true;
            this.GrossLab1.Depth = 0;
            this.GrossLab1.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrossLab1.Font = new System.Drawing.Font("Roboto", 11F);
            this.GrossLab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrossLab1.Location = new System.Drawing.Point(428, 0);
            this.GrossLab1.MouseState = MaterialSkin.MouseState.HOVER;
            this.GrossLab1.Name = "GrossLab1";
            this.GrossLab1.Size = new System.Drawing.Size(57, 19);
            this.GrossLab1.TabIndex = 44;
            this.GrossLab1.Text = "Gross: ";
            // 
            // ProfitLab11
            // 
            this.ProfitLab11.AutoSize = true;
            this.ProfitLab11.Depth = 0;
            this.ProfitLab11.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProfitLab11.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProfitLab11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfitLab11.Location = new System.Drawing.Point(54, 0);
            this.ProfitLab11.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProfitLab11.Name = "ProfitLab11";
            this.ProfitLab11.Size = new System.Drawing.Size(54, 19);
            this.ProfitLab11.TabIndex = 43;
            this.ProfitLab11.Text = "Profit: ";
            // 
            // ProfitLab
            // 
            this.ProfitLab.AutoSize = true;
            this.ProfitLab.Depth = 0;
            this.ProfitLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProfitLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProfitLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfitLab.Location = new System.Drawing.Point(0, 0);
            this.ProfitLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProfitLab.Name = "ProfitLab";
            this.ProfitLab.Size = new System.Drawing.Size(54, 19);
            this.ProfitLab.TabIndex = 41;
            this.ProfitLab.Text = "Profit: ";
            // 
            // GrossLab
            // 
            this.GrossLab.AutoSize = true;
            this.GrossLab.Depth = 0;
            this.GrossLab.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrossLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.GrossLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrossLab.Location = new System.Drawing.Point(485, 0);
            this.GrossLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.GrossLab.Name = "GrossLab";
            this.GrossLab.Size = new System.Drawing.Size(57, 19);
            this.GrossLab.TabIndex = 42;
            this.GrossLab.Text = "Gross: ";
            // 
            // FinancialChart_Gross
            // 
            this.FinancialChart_Gross.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.FinancialChart_Gross.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.FinancialChart_Gross.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.FinancialChart_Gross.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.FinancialChart_Gross.ChartAreas.Add(chartArea1);
            this.FinancialChart_Gross.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.FinancialChart_Gross.Legends.Add(legend1);
            this.FinancialChart_Gross.Location = new System.Drawing.Point(3, 56);
            this.FinancialChart_Gross.Name = "FinancialChart_Gross";
            this.FinancialChart_Gross.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.FinancialChart_Gross.Series.Add(series1);
            this.FinancialChart_Gross.Size = new System.Drawing.Size(554, 254);
            this.FinancialChart_Gross.TabIndex = 0;
            this.FinancialChart_Gross.Text = "FinancialChart_Gross";
            // 
            // MonthFilterComboBox
            // 
            this.MonthFilterComboBox.FormattingEnabled = true;
            this.MonthFilterComboBox.Location = new System.Drawing.Point(130, 3);
            this.MonthFilterComboBox.Name = "MonthFilterComboBox";
            this.MonthFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.MonthFilterComboBox.TabIndex = 53;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.YearFilterComboBox);
            this.flowLayoutPanel1.Controls.Add(this.MonthFilterComboBox);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.FinancialChart_Gross);
            this.flowLayoutPanel1.Controls.Add(this.FinancialChart_Profit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(552, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 587);
            this.flowLayoutPanel1.TabIndex = 54;
            // 
            // YearFilterComboBox
            // 
            this.YearFilterComboBox.FormattingEnabled = true;
            this.YearFilterComboBox.Location = new System.Drawing.Point(3, 3);
            this.YearFilterComboBox.Name = "YearFilterComboBox";
            this.YearFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.YearFilterComboBox.TabIndex = 55;
            // 
            // FinancialChart_Profit
            // 
            this.FinancialChart_Profit.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.FinancialChart_Profit.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.FinancialChart_Profit.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.FinancialChart_Profit.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Name = "ChartArea1";
            this.FinancialChart_Profit.ChartAreas.Add(chartArea2);
            this.FinancialChart_Profit.Cursor = System.Windows.Forms.Cursors.Cross;
            legend2.Name = "Legend1";
            this.FinancialChart_Profit.Legends.Add(legend2);
            this.FinancialChart_Profit.Location = new System.Drawing.Point(3, 316);
            this.FinancialChart_Profit.Name = "FinancialChart_Profit";
            this.FinancialChart_Profit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FinancialChart_Profit.Series.Add(series2);
            this.FinancialChart_Profit.Size = new System.Drawing.Size(554, 254);
            this.FinancialChart_Profit.TabIndex = 54;
            this.FinancialChart_Profit.Text = "FinancialChart_Profit";
            // 
            // FinacialStatistician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.ClientSize = new System.Drawing.Size(1165, 650);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinacialStatistician";
            this.Text = "FinacialAnalyer";
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.SaleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopsaleGrid)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart_Gross)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FinancialChart_Profit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox SaleGroupBox;
        private MaterialSkin.Controls.MaterialLabel ProfitLab;
        private System.Windows.Forms.DataGridView TopsaleGrid;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FinancialChart_Gross;
        private System.Windows.Forms.ComboBox MonthFilterComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FinancialChart_Profit;
        private System.Windows.Forms.ComboBox YearFilterComboBox;
        private MaterialSkin.Controls.MaterialLabel GrossLab;
        private MaterialSkin.Controls.MaterialLabel ProfitLab11;
        private MaterialSkin.Controls.MaterialLabel GrossLab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfitCol;
    }
}