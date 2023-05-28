namespace Ex03
{
	partial class SourceForm
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
			richTextBoxSource = new RichTextBox();
			SuspendLayout();
			// 
			// richTextBoxSource
			// 
			richTextBoxSource.Dock = DockStyle.Fill;
			richTextBoxSource.Location = new Point(0, 0);
			richTextBoxSource.Name = "richTextBoxSource";
			richTextBoxSource.Size = new Size(794, 490);
			richTextBoxSource.TabIndex = 0;
			richTextBoxSource.Text = "";
			// 
			// SourceForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(794, 490);
			Controls.Add(richTextBoxSource);
			Name = "SourceForm";
			Text = "Source Form";
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox richTextBoxSource;
	}
}