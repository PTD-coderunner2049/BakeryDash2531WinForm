namespace SolbergBakery2531.UI.Forms.AdministForms
{
    partial class EmploymentHistory
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HRFeedbackText = new System.Windows.Forms.TextBox();
            this.feedbackGroup = new System.Windows.Forms.GroupBox();
            this.rtnBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.svBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.viewGroup = new System.Windows.Forms.GroupBox();
            this.historyView = new System.Windows.Forms.DataGridView();
            this.StartCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OngoingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            this.feedbackGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.viewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(86, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(352, 44);
            this.panel7.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.E1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 503);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SolbergBakery2531.UI.Properties.Resources.E2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(444, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 503);
            this.panel2.TabIndex = 26;
            // 
            // HRFeedbackText
            // 
            this.HRFeedbackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRFeedbackText.Location = new System.Drawing.Point(0, 19);
            this.HRFeedbackText.Multiline = true;
            this.HRFeedbackText.Name = "HRFeedbackText";
            this.HRFeedbackText.Size = new System.Drawing.Size(352, 197);
            this.HRFeedbackText.TabIndex = 36;
            // 
            // feedbackGroup
            // 
            this.feedbackGroup.Controls.Add(this.HRFeedbackText);
            this.feedbackGroup.Location = new System.Drawing.Point(86, 358);
            this.feedbackGroup.Name = "feedbackGroup";
            this.feedbackGroup.Size = new System.Drawing.Size(352, 130);
            this.feedbackGroup.TabIndex = 37;
            this.feedbackGroup.TabStop = false;
            this.feedbackGroup.Text = "Employment feedback";
            // 
            // rtnBtn
            // 
            this.rtnBtn.AutoSize = true;
            this.rtnBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rtnBtn.Depth = 0;
            this.rtnBtn.Location = new System.Drawing.Point(284, 6);
            this.rtnBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rtnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtnBtn.Name = "rtnBtn";
            this.rtnBtn.Primary = false;
            this.rtnBtn.Size = new System.Drawing.Size(64, 36);
            this.rtnBtn.TabIndex = 38;
            this.rtnBtn.Text = "Return";
            this.rtnBtn.UseVisualStyleBackColor = true;
            this.rtnBtn.Click += new System.EventHandler(this.rtnBtn_Click);
            // 
            // svBtn
            // 
            this.svBtn.AutoSize = true;
            this.svBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.svBtn.Depth = 0;
            this.svBtn.Location = new System.Drawing.Point(212, 6);
            this.svBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.svBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.svBtn.Name = "svBtn";
            this.svBtn.Primary = false;
            this.svBtn.Size = new System.Drawing.Size(64, 36);
            this.svBtn.TabIndex = 39;
            this.svBtn.Text = "Update";
            this.svBtn.UseVisualStyleBackColor = true;
            this.svBtn.Click += new System.EventHandler(this.svBtn_ClickAsync);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.svBtn);
            this.panel3.Controls.Add(this.rtnBtn);
            this.panel3.Location = new System.Drawing.Point(86, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 46);
            this.panel3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(81, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Employment History";
            // 
            // viewGroup
            // 
            this.viewGroup.Controls.Add(this.historyView);
            this.viewGroup.Location = new System.Drawing.Point(86, 49);
            this.viewGroup.Name = "viewGroup";
            this.viewGroup.Size = new System.Drawing.Size(352, 259);
            this.viewGroup.TabIndex = 38;
            this.viewGroup.TabStop = false;
            this.viewGroup.Text = "employee";
            // 
            // historyView
            // 
            this.historyView.BackgroundColor = System.Drawing.Color.Snow;
            this.historyView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartCol,
            this.EndCol,
            this.OngoingCol});
            this.historyView.Location = new System.Drawing.Point(0, 19);
            this.historyView.Name = "historyView";
            this.historyView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.historyView.Size = new System.Drawing.Size(352, 234);
            this.historyView.TabIndex = 0;
            // 
            // StartCol
            // 
            this.StartCol.DataPropertyName = "StartDate";
            this.StartCol.HeaderText = "Start";
            this.StartCol.Name = "StartCol";
            this.StartCol.ReadOnly = true;
            this.StartCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartCol.Width = 125;
            // 
            // EndCol
            // 
            this.EndCol.DataPropertyName = "EndDate";
            this.EndCol.HeaderText = "End";
            this.EndCol.Name = "EndCol";
            this.EndCol.ReadOnly = true;
            this.EndCol.Width = 125;
            // 
            // OngoingCol
            // 
            this.OngoingCol.DataPropertyName = "Ongoing";
            this.OngoingCol.HeaderText = "Ongoing";
            this.OngoingCol.Name = "OngoingCol";
            this.OngoingCol.ReadOnly = true;
            this.OngoingCol.Width = 60;
            // 
            // EmploymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(525, 500);
            this.Controls.Add(this.viewGroup);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.feedbackGroup);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EmploymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmploymentHistory";
            this.TopMost = true;
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.feedbackGroup.ResumeLayout(false);
            this.feedbackGroup.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.viewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox HRFeedbackText;
        private System.Windows.Forms.GroupBox feedbackGroup;
        private MaterialSkin.Controls.MaterialFlatButton rtnBtn;
        private MaterialSkin.Controls.MaterialFlatButton svBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox viewGroup;
        private System.Windows.Forms.DataGridView historyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OngoingCol;
    }
}