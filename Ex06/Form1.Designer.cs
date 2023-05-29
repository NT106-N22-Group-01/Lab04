namespace Ex06
{
    partial class Form1
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.flpNews = new System.Windows.Forms.FlowLayoutPanel();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 15);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(697, 20);
            this.tbURL.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(715, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(72, 22);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // flpNews
            // 
            this.flpNews.AutoScroll = true;
            this.flpNews.Location = new System.Drawing.Point(12, 81);
            this.flpNews.Name = "flpNews";
            this.flpNews.Size = new System.Drawing.Size(775, 357);
            this.flpNews.TabIndex = 3;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 46);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(774, 24);
            this.progBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.flpNews);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.FlowLayoutPanel flpNews;
        private System.Windows.Forms.ProgressBar progBar;
    }
}

