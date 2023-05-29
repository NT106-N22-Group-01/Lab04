namespace Ex06
{
	partial class Ex06
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
			tbURL = new TextBox();
			btnGet = new Button();
			flpNews = new FlowLayoutPanel();
			progBar = new ProgressBar();
			SuspendLayout();
			// 
			// tbURL
			// 
			tbURL.Location = new Point(20, 29);
			tbURL.Margin = new Padding(5, 6, 5, 6);
			tbURL.Name = "tbURL";
			tbURL.Size = new Size(1127, 31);
			tbURL.TabIndex = 1;
			// 
			// btnGet
			// 
			btnGet.Location = new Point(1157, 23);
			btnGet.Margin = new Padding(5, 6, 5, 6);
			btnGet.Name = "btnGet";
			btnGet.Size = new Size(120, 42);
			btnGet.TabIndex = 2;
			btnGet.Text = "Get";
			btnGet.UseVisualStyleBackColor = true;
			btnGet.Click += btnGet_Click;
			// 
			// flpNews
			// 
			flpNews.AutoScroll = true;
			flpNews.Location = new Point(20, 156);
			flpNews.Margin = new Padding(5, 6, 5, 6);
			flpNews.Name = "flpNews";
			flpNews.Size = new Size(1257, 687);
			flpNews.TabIndex = 3;
			// 
			// progBar
			// 
			progBar.Location = new Point(20, 88);
			progBar.Margin = new Padding(5, 6, 5, 6);
			progBar.Name = "progBar";
			progBar.Size = new Size(1257, 46);
			progBar.TabIndex = 4;
			// 
			// Ex06
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1297, 865);
			Controls.Add(progBar);
			Controls.Add(flpNews);
			Controls.Add(btnGet);
			Controls.Add(tbURL);
			Margin = new Padding(5, 6, 5, 6);
			Name = "Ex06";
			Text = "Exercise 06";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.FlowLayoutPanel flpNews;
		private System.Windows.Forms.ProgressBar progBar;
	}
}

