namespace CinemaManagement_Project
{
    partial class QuenMatKhau
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
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            Email_Dang_Ky = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(226, 347);
            button2.Name = "button2";
            button2.Size = new Size(431, 49);
            button2.TabIndex = 16;
            button2.Text = "Send your new password via email";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(155, 223);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(107, 21);
            label2.TabIndex = 15;
            label2.Text = "Email đăng ký";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(303, 150);
            label1.Name = "label1";
            label1.Size = new Size(260, 37);
            label1.TabIndex = 13;
            label1.Text = "Reset your password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(363, 81);
            label6.Name = "label6";
            label6.Size = new Size(137, 24);
            label6.TabIndex = 37;
            label6.Text = "Get Started";
            // 
            // Email_Dang_Ky
            // 
            Email_Dang_Ky.Location = new Point(273, 216);
            Email_Dang_Ky.Multiline = true;
            Email_Dang_Ky.Name = "Email_Dang_Ky";
            Email_Dang_Ky.PasswordChar = '*';
            Email_Dang_Ky.Size = new Size(322, 36);
            Email_Dang_Ky.TabIndex = 38;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Email_Dang_Ky);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuenMatKhau";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox Email_Dang_Ky;
    }
}