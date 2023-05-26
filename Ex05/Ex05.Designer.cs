namespace Ex05
{
    partial class Ex05
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
            usrText = new TextBox();
            postButton = new Button();
            label2 = new Label();
            label3 = new Label();
            Output = new TextBox();
            urlText = new TextBox();
            pwdText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // usrText
            // 
            usrText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usrText.Location = new Point(150, 80);
            usrText.Name = "usrText";
            usrText.Size = new Size(200, 25);
            usrText.TabIndex = 1;
            // 
            // postButton
            // 
            postButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            postButton.Location = new Point(375, 90);
            postButton.Name = "postButton";
            postButton.Size = new Size(100, 45);
            postButton.TabIndex = 2;
            postButton.Text = "POST";
            postButton.UseVisualStyleBackColor = true;
            postButton.Click += postButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 120);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // Output
            // 
            Output.Location = new Point(30, 160);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.Size = new Size(465, 250);
            Output.TabIndex = 5;
            // 
            // urlText
            // 
            urlText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            urlText.Location = new Point(150, 30);
            urlText.Name = "urlText";
            urlText.Size = new Size(325, 25);
            urlText.TabIndex = 6;
            // 
            // pwdText
            // 
            pwdText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pwdText.Location = new Point(150, 120);
            pwdText.Name = "pwdText";
            pwdText.PasswordChar = '*';
            pwdText.Size = new Size(200, 25);
            pwdText.TabIndex = 7;
            // 
            // Ex05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 441);
            Controls.Add(pwdText);
            Controls.Add(urlText);
            Controls.Add(Output);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(postButton);
            Controls.Add(usrText);
            Controls.Add(label1);
            Name = "Ex05";
            Text = "Ex05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usrText;
        private Button postButton;
        private Label label2;
        private Label label3;
        private TextBox Output;
        private TextBox urlText;
        private TextBox pwdText;
    }
}