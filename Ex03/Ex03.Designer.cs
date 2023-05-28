
namespace Ex03
{
	partial class Ex03
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
			Lab4_txtURL = new TextBox();
			Lab4_btnSearch = new Button();
			Lab4_btnDownload = new Button();
			webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
			buttonViewSource = new Button();
			buttonDownloadHTML = new Button();
			((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
			SuspendLayout();
			// 
			// Lab4_txtURL
			// 
			Lab4_txtURL.Font = new Font("Open Sans Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
			Lab4_txtURL.Location = new Point(15, 27);
			Lab4_txtURL.Margin = new Padding(4, 5, 4, 5);
			Lab4_txtURL.Name = "Lab4_txtURL";
			Lab4_txtURL.Size = new Size(1143, 37);
			Lab4_txtURL.TabIndex = 1;
			Lab4_txtURL.Text = "https://";
			Lab4_txtURL.KeyPress += Lab4_txtURL_KeyPress;
			// 
			// Lab4_btnSearch
			// 
			Lab4_btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
			Lab4_btnSearch.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Lab4_btnSearch.Location = new Point(1166, 9);
			Lab4_btnSearch.Margin = new Padding(4, 5, 4, 5);
			Lab4_btnSearch.Name = "Lab4_btnSearch";
			Lab4_btnSearch.Size = new Size(69, 76);
			Lab4_btnSearch.TabIndex = 2;
			Lab4_btnSearch.Text = "GO";
			Lab4_btnSearch.UseVisualStyleBackColor = true;
			Lab4_btnSearch.Click += Lab4_btnSearch_Click;
			// 
			// Lab4_btnDownload
			// 
			Lab4_btnDownload.BackgroundImageLayout = ImageLayout.Stretch;
			Lab4_btnDownload.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Lab4_btnDownload.Location = new Point(1379, 9);
			Lab4_btnDownload.Margin = new Padding(4, 5, 4, 5);
			Lab4_btnDownload.Name = "Lab4_btnDownload";
			Lab4_btnDownload.Size = new Size(128, 76);
			Lab4_btnDownload.TabIndex = 6;
			Lab4_btnDownload.Text = "Download Resource";
			Lab4_btnDownload.UseVisualStyleBackColor = true;
			Lab4_btnDownload.Click += Lab4_btnDownload_Click;
			// 
			// webView2
			// 
			webView2.AllowExternalDrop = true;
			webView2.CreationProperties = null;
			webView2.DefaultBackgroundColor = Color.White;
			webView2.Location = new Point(15, 98);
			webView2.Name = "webView2";
			webView2.Size = new Size(1629, 944);
			webView2.TabIndex = 7;
			webView2.ZoomFactor = 1D;
			webView2.NavigationCompleted += webView2_NavigationCompleted;
			// 
			// buttonViewSource
			// 
			buttonViewSource.BackgroundImageLayout = ImageLayout.Stretch;
			buttonViewSource.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonViewSource.Location = new Point(1515, 9);
			buttonViewSource.Margin = new Padding(4, 5, 4, 5);
			buttonViewSource.Name = "buttonViewSource";
			buttonViewSource.Size = new Size(128, 76);
			buttonViewSource.TabIndex = 8;
			buttonViewSource.Text = "ViewSource";
			buttonViewSource.UseVisualStyleBackColor = true;
			buttonViewSource.Click += buttonViewSource_Click;
			// 
			// buttonDownloadHTML
			// 
			buttonDownloadHTML.BackgroundImageLayout = ImageLayout.Stretch;
			buttonDownloadHTML.Font = new Font("Open Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonDownloadHTML.Location = new Point(1243, 9);
			buttonDownloadHTML.Margin = new Padding(4, 5, 4, 5);
			buttonDownloadHTML.Name = "buttonDownloadHTML";
			buttonDownloadHTML.Size = new Size(128, 76);
			buttonDownloadHTML.TabIndex = 9;
			buttonDownloadHTML.Text = "Download HTML";
			buttonDownloadHTML.UseVisualStyleBackColor = true;
			buttonDownloadHTML.Click += buttonDownloadHTML_Click;
			// 
			// Ex03
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1656, 1054);
			Controls.Add(buttonDownloadHTML);
			Controls.Add(buttonViewSource);
			Controls.Add(webView2);
			Controls.Add(Lab4_btnDownload);
			Controls.Add(Lab4_btnSearch);
			Controls.Add(Lab4_txtURL);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Ex03";
			Load += Ex03_Load;
			((System.ComponentModel.ISupportInitialize)webView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox Lab4_txtURL;
		private System.Windows.Forms.Button Lab4_btnSearch;
		private System.Windows.Forms.Button Lab4_btnDownload;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
		private Button buttonViewSource;
		private Button buttonDownloadHTML;
	}
}

