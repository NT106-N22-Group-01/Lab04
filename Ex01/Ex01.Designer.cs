namespace Ex01
{
	partial class Ex01
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
			txtURL = new TextBox();
			btnGet = new Button();
			rtxResponse = new RichTextBox();
			SuspendLayout();
			// 
			// txtURL
			// 
			txtURL.Font = new Font("Open Sans Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
			txtURL.Location = new Point(21, 33);
			txtURL.Margin = new Padding(4, 5, 4, 5);
			txtURL.Multiline = true;
			txtURL.Name = "txtURL";
			txtURL.Size = new Size(619, 66);
			txtURL.TabIndex = 0;
			txtURL.Text = "http://";
			// 
			// btnGet
			// 
			btnGet.Font = new Font("Open Sans Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
			btnGet.Location = new Point(669, 36);
			btnGet.Margin = new Padding(4, 5, 4, 5);
			btnGet.Name = "btnGet";
			btnGet.Size = new Size(212, 64);
			btnGet.TabIndex = 1;
			btnGet.Text = "GET";
			btnGet.UseVisualStyleBackColor = true;
			btnGet.Click += btnGet_Click;
			// 
			// rtxResponse
			// 
			rtxResponse.Location = new Point(13, 135);
			rtxResponse.Margin = new Padding(4, 5, 4, 5);
			rtxResponse.Name = "rtxResponse";
			rtxResponse.Size = new Size(858, 474);
			rtxResponse.TabIndex = 2;
			rtxResponse.Text = "";
			// 
			// Ex01
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(896, 635);
			Controls.Add(rtxResponse);
			Controls.Add(btnGet);
			Controls.Add(txtURL);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Ex01";
			Text = "Exercise 01";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.RichTextBox rtxResponse;
	}
}

