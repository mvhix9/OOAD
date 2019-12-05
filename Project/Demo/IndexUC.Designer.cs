namespace Demo
{
    partial class IndexUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexUC));
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(384, 227);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(250, 250);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(174)))));
            this.lblTitle.Location = new System.Drawing.Point(320, 451);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PHÒNG MẠCH TƯ";
            // 
            // IndexUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.logoPicture);
            this.Name = "IndexUC";
            this.Size = new System.Drawing.Size(1007, 733);
            this.Load += new System.EventHandler(this.IndexUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label lblTitle;
    }
}
