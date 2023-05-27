
namespace LAB4_BAI3
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
            this.Lab4_txtURL = new System.Windows.Forms.TextBox();
            this.Lab4_btnSearch = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Lab4_btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab4_txtURL
            // 
            this.Lab4_txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab4_txtURL.Location = new System.Drawing.Point(12, 12);
            this.Lab4_txtURL.Name = "Lab4_txtURL";
            this.Lab4_txtURL.Size = new System.Drawing.Size(731, 30);
            this.Lab4_txtURL.TabIndex = 1;
            this.Lab4_txtURL.Text = "https://";
            // 
            // Lab4_btnSearch
            // 
            this.Lab4_btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lab4_btnSearch.Location = new System.Drawing.Point(762, 12);
            this.Lab4_btnSearch.Name = "Lab4_btnSearch";
            this.Lab4_btnSearch.Size = new System.Drawing.Size(91, 40);
            this.Lab4_btnSearch.TabIndex = 2;
            this.Lab4_btnSearch.Text = "SEARCH";
            this.Lab4_btnSearch.UseVisualStyleBackColor = true;
            this.Lab4_btnSearch.Click += new System.EventHandler(this.Lab4_btnSearch_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1224, 530);
            this.webBrowser1.TabIndex = 5;
            // 
            // Lab4_btnDownload
            // 
            this.Lab4_btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lab4_btnDownload.Location = new System.Drawing.Point(859, 10);
            this.Lab4_btnDownload.Name = "Lab4_btnDownload";
            this.Lab4_btnDownload.Size = new System.Drawing.Size(102, 40);
            this.Lab4_btnDownload.TabIndex = 6;
            this.Lab4_btnDownload.Text = "DOWLOAD";
            this.Lab4_btnDownload.UseVisualStyleBackColor = true;
            this.Lab4_btnDownload.Click += new System.EventHandler(this.Lab4_btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 600);
            this.Controls.Add(this.Lab4_btnDownload);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Lab4_btnSearch);
            this.Controls.Add(this.Lab4_txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lab4_txtURL;
        private System.Windows.Forms.Button Lab4_btnSearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Lab4_btnDownload;
    }
}

