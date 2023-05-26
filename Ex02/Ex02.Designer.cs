namespace Ex02
{
    partial class Ex02
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
            label1 = new Label();
            urlText = new TextBox();
            downloadButton = new Button();
            Output = new TextBox();
            pathText = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // urlText
            // 
            urlText.Location = new Point(150, 30);
            urlText.Name = "urlText";
            urlText.Size = new Size(200, 23);
            urlText.TabIndex = 1;
            // 
            // downloadButton
            // 
            downloadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            downloadButton.Location = new Point(375, 30);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(100, 50);
            downloadButton.TabIndex = 2;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // Output
            // 
            Output.Location = new Point(30, 125);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.Size = new Size(465, 285);
            Output.TabIndex = 3;
            // 
            // pathText
            // 
            pathText.Location = new Point(150, 75);
            pathText.Name = "pathText";
            pathText.Size = new Size(200, 23);
            pathText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "File Path:";
            // 
            // Ex02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(label2);
            Controls.Add(pathText);
            Controls.Add(Output);
            Controls.Add(downloadButton);
            Controls.Add(urlText);
            Controls.Add(label1);
            Name = "Ex02";
            Text = "Exercise 2: Download HTML Data from a random URL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox urlText;
        private Button downloadButton;
        private TextBox Output;
        private TextBox pathText;
        private Label label2;
    }
}