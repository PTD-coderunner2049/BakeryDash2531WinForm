namespace SolbergBakery2531.UI.UserControls
{
    partial class ProdCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemFacePicBox = new System.Windows.Forms.PictureBox();
            this.ItemNameSmall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFacePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemFacePicBox
            // 
            this.ItemFacePicBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemFacePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ItemFacePicBox.Location = new System.Drawing.Point(0, 0);
            this.ItemFacePicBox.Name = "ItemFacePicBox";
            this.ItemFacePicBox.Size = new System.Drawing.Size(100, 100);
            this.ItemFacePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItemFacePicBox.TabIndex = 1;
            this.ItemFacePicBox.TabStop = false;
            // 
            // ItemNameSmall
            // 
            this.ItemNameSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameSmall.Location = new System.Drawing.Point(20, 78);
            this.ItemNameSmall.Name = "ItemNameSmall";
            this.ItemNameSmall.Size = new System.Drawing.Size(63, 13);
            this.ItemNameSmall.TabIndex = 2;
            this.ItemNameSmall.Text = "undefined";
            // 
            // ProdCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.Barrier;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.ItemNameSmall);
            this.Controls.Add(this.ItemFacePicBox);
            this.DoubleBuffered = true;
            this.Name = "ProdCardControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.ProdCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemFacePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ItemFacePicBox;
        private System.Windows.Forms.Label ItemNameSmall;
    }
}
