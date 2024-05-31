namespace CinemaManagement_Project
{
    partial class DangKy
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
            label5 = new Label();
            text_email = new TextBox();
            label4 = new Label();
            text_repassword = new TextBox();
            label3 = new Label();
            text_password = new TextBox();
            label2 = new Label();
            text_username = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(352, 44);
            label1.Name = "label1";
            label1.Size = new Size(107, 37);
            label1.TabIndex = 14;
            label1.Text = "Sign up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(166, 291);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(48, 21);
            label5.TabIndex = 33;
            label5.Text = "Email";
            // 
            // text_email
            // 
            text_email.Location = new Point(251, 285);
            text_email.Multiline = true;
            text_email.Name = "text_email";
            text_email.Size = new Size(322, 36);
            text_email.TabIndex = 32;
            text_email.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(73, 231);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(143, 21);
            label4.TabIndex = 31;
            label4.Text = "Enter the password";
            // 
            // text_repassword
            // 
            text_repassword.Location = new Point(251, 228);
            text_repassword.Multiline = true;
            text_repassword.Name = "text_repassword";
            text_repassword.Size = new Size(322, 36);
            text_repassword.TabIndex = 30;
            text_repassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(138, 172);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(76, 21);
            label3.TabIndex = 29;
            label3.Text = "Password";
            // 
            // text_password
            // 
            text_password.Location = new Point(251, 172);
            text_password.Multiline = true;
            text_password.Name = "text_password";
            text_password.Size = new Size(322, 36);
            text_password.TabIndex = 28;
            text_password.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(135, 118);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(81, 21);
            label2.TabIndex = 27;
            label2.Text = "Username";
            // 
            // text_username
            // 
            text_username.Location = new Point(251, 111);
            text_username.Multiline = true;
            text_username.Name = "text_username";
            text_username.Size = new Size(322, 36);
            text_username.TabIndex = 26;
            text_username.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(184, 366);
            button2.Name = "button2";
            button2.Size = new Size(419, 33);
            button2.TabIndex = 25;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(text_email);
            Controls.Add(label4);
            Controls.Add(text_repassword);
            Controls.Add(label3);
            Controls.Add(text_password);
            Controls.Add(label2);
            Controls.Add(text_username);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "DangKy";
            Text = "Form1";
            Load += DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox text_email;
        private Label label4;
        private TextBox text_repassword;
        private Label label3;
        private TextBox text_password;
        private Label label2;
        private TextBox text_username;
        private Button button2;
    }
}