namespace SolbergBakery2531.UI.Forms.AdministForms
{
    partial class InventoryReconcilier
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
            this.QuantityBar = new System.Windows.Forms.Panel();
            this.QuantityflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.QuantityToAddBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuantityToAddLab = new MaterialSkin.Controls.MaterialLabel();
            this.QLab = new MaterialSkin.Controls.MaterialLabel();
            this.viewGroup = new System.Windows.Forms.GroupBox();
            this.ProductFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.svBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currQuantityLab = new MaterialSkin.Controls.MaterialLabel();
            this.CLab = new MaterialSkin.Controls.MaterialLabel();
            this.QuantityBar.SuspendLayout();
            this.QuantityflowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityToAddBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.viewGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuantityBar
            // 
            this.QuantityBar.BackColor = System.Drawing.Color.OldLace;
            this.QuantityBar.Controls.Add(this.QuantityflowLayoutPanel);
            this.QuantityBar.Controls.Add(this.viewGroup);
            this.QuantityBar.Controls.Add(this.ProductTreeView);
            this.QuantityBar.Controls.Add(this.panel1);
            this.QuantityBar.Controls.Add(this.panel3);
            this.QuantityBar.Location = new System.Drawing.Point(12, 12);
            this.QuantityBar.Name = "QuantityBar";
            this.QuantityBar.Size = new System.Drawing.Size(516, 512);
            this.QuantityBar.TabIndex = 41;
            // 
            // QuantityflowLayoutPanel
            // 
            this.QuantityflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityflowLayoutPanel.Controls.Add(this.panel4);
            this.QuantityflowLayoutPanel.Controls.Add(this.QuantityToAddBar);
            this.QuantityflowLayoutPanel.Controls.Add(this.panel2);
            this.QuantityflowLayoutPanel.Location = new System.Drawing.Point(132, 342);
            this.QuantityflowLayoutPanel.Name = "QuantityflowLayoutPanel";
            this.QuantityflowLayoutPanel.Size = new System.Drawing.Size(381, 114);
            this.QuantityflowLayoutPanel.TabIndex = 48;
            // 
            // QuantityToAddBar
            // 
            this.QuantityToAddBar.Location = new System.Drawing.Point(3, 28);
            this.QuantityToAddBar.Maximum = 100;
            this.QuantityToAddBar.Minimum = -100;
            this.QuantityToAddBar.Name = "QuantityToAddBar";
            this.QuantityToAddBar.Size = new System.Drawing.Size(381, 45);
            this.QuantityToAddBar.TabIndex = 46;
            this.QuantityToAddBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QuantityToAddLab);
            this.panel2.Controls.Add(this.QLab);
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 19);
            this.panel2.TabIndex = 48;
            // 
            // QuantityToAddLab
            // 
            this.QuantityToAddLab.AutoSize = true;
            this.QuantityToAddLab.Depth = 0;
            this.QuantityToAddLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.QuantityToAddLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuantityToAddLab.Location = new System.Drawing.Point(144, 0);
            this.QuantityToAddLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuantityToAddLab.Name = "QuantityToAddLab";
            this.QuantityToAddLab.Size = new System.Drawing.Size(17, 19);
            this.QuantityToAddLab.TabIndex = 48;
            this.QuantityToAddLab.Text = "0";
            // 
            // QLab
            // 
            this.QLab.AutoSize = true;
            this.QLab.Depth = 0;
            this.QLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.QLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QLab.Location = new System.Drawing.Point(3, 0);
            this.QLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.QLab.Name = "QLab";
            this.QLab.Size = new System.Drawing.Size(135, 19);
            this.QLab.TabIndex = 47;
            this.QLab.Text = "Quantity modified :";
            // 
            // viewGroup
            // 
            this.viewGroup.Controls.Add(this.ProductFlowLayoutPanel);
            this.viewGroup.Location = new System.Drawing.Point(132, 50);
            this.viewGroup.Name = "viewGroup";
            this.viewGroup.Size = new System.Drawing.Size(381, 286);
            this.viewGroup.TabIndex = 44;
            this.viewGroup.TabStop = false;
            this.viewGroup.Text = "Avaiable";
            // 
            // ProductFlowLayoutPanel
            // 
            this.ProductFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductFlowLayoutPanel.Location = new System.Drawing.Point(0, 19);
            this.ProductFlowLayoutPanel.Name = "ProductFlowLayoutPanel";
            this.ProductFlowLayoutPanel.Size = new System.Drawing.Size(381, 267);
            this.ProductFlowLayoutPanel.TabIndex = 0;
            // 
            // ProductTreeView
            // 
            this.ProductTreeView.Location = new System.Drawing.Point(5, 50);
            this.ProductTreeView.Name = "ProductTreeView";
            this.ProductTreeView.Size = new System.Drawing.Size(121, 458);
            this.ProductTreeView.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 44);
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
            this.Title.Size = new System.Drawing.Size(330, 29);
            this.Title.TabIndex = 23;
            this.Title.Text = "Inventory Reconcilier Interface";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.svBtn);
            this.panel3.Location = new System.Drawing.Point(132, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 46);
            this.panel3.TabIndex = 42;
            // 
            // svBtn
            // 
            this.svBtn.AutoSize = true;
            this.svBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.svBtn.Depth = 0;
            this.svBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.svBtn.Location = new System.Drawing.Point(228, 0);
            this.svBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.svBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.svBtn.Name = "svBtn";
            this.svBtn.Primary = false;
            this.svBtn.Size = new System.Drawing.Size(153, 46);
            this.svBtn.TabIndex = 38;
            this.svBtn.Text = "Apply modification";
            this.svBtn.UseVisualStyleBackColor = true;
            this.svBtn.Click += new System.EventHandler(this.svBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.ARDECHOISVUEHAUTcopie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(535, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.currQuantityLab);
            this.panel4.Controls.Add(this.CLab);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 19);
            this.panel4.TabIndex = 49;
            // 
            // currQuantityLab
            // 
            this.currQuantityLab.AutoSize = true;
            this.currQuantityLab.Depth = 0;
            this.currQuantityLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.currQuantityLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currQuantityLab.Location = new System.Drawing.Point(253, 0);
            this.currQuantityLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.currQuantityLab.Name = "currQuantityLab";
            this.currQuantityLab.Size = new System.Drawing.Size(17, 19);
            this.currQuantityLab.TabIndex = 48;
            this.currQuantityLab.Text = "0";
            // 
            // CLab
            // 
            this.CLab.AutoSize = true;
            this.CLab.Depth = 0;
            this.CLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.CLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CLab.Location = new System.Drawing.Point(3, 0);
            this.CLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.CLab.Name = "CLab";
            this.CLab.Size = new System.Drawing.Size(244, 19);
            this.CLab.TabIndex = 47;
            this.CLab.Text = "Inventory Status by Potential Order:";
            // 
            // InventoryReconcilier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1174, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuantityBar);
            this.Name = "InventoryReconcilier";
            this.Text = "InventoryReconcilier";
            this.QuantityBar.ResumeLayout(false);
            this.QuantityflowLayoutPanel.ResumeLayout(false);
            this.QuantityflowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityToAddBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.viewGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuantityBar;
        private System.Windows.Forms.Label Title;
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private System.Windows.Forms.GroupBox viewGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView ProductTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel ProductFlowLayoutPanel;
        private System.Windows.Forms.TrackBar QuantityToAddBar;
        private System.Windows.Forms.FlowLayoutPanel QuantityflowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel QLab;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel QuantityToAddLab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel currQuantityLab;
        private MaterialSkin.Controls.MaterialLabel CLab;
    }
}