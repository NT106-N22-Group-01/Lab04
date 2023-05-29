namespace Ex06
{
    partial class News
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDescription.Location = new System.Drawing.Point(8, 58);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(545, 113);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            this.lbDescription.Click += new System.EventHandler(this.lbDescription_Click);
            this.lbDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbDescription_MouseDoubleClick);
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(559, 58);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(160, 113);
            this.pbThumbnail.TabIndex = 1;
            this.pbThumbnail.TabStop = false;
            this.pbThumbnail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbThumbnail_MouseDoubleClick);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(7, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(712, 28);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            this.lbTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDoubleClick);
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.lbDescription);
            this.Name = "News";
            this.Size = new System.Drawing.Size(722, 174);
            this.DoubleClick += new System.EventHandler(this.News_DoubleClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.News_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Label lbTitle;
    }
}
