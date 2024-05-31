namespace CinemaManagement_Project
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            Click_DangNhap = new Button();
            QuenMatKhau = new Button();
            DangKy = new Button();
            show_password = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(250, 155);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(322, 36);
            username.TabIndex = 23;
            // 
            // Click_DangNhap
            // 
            Click_DangNhap.BackColor = Color.Navy;
            Click_DangNhap.FlatStyle = FlatStyle.Flat;
            Click_DangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Click_DangNhap.ForeColor = SystemColors.ButtonHighlight;
            Click_DangNhap.Location = new Point(251, 318);
            Click_DangNhap.Name = "Click_DangNhap";
            Click_DangNhap.Size = new Size(323, 33);
            Click_DangNhap.TabIndex = 22;
            Click_DangNhap.Text = "Sign in ";
            Click_DangNhap.UseVisualStyleBackColor = false;
            Click_DangNhap.Click += Click_DangNhap_Click;
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.BackColor = Color.Navy;
            QuenMatKhau.FlatStyle = FlatStyle.Flat;
            QuenMatKhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuenMatKhau.ForeColor = SystemColors.ButtonHighlight;
            QuenMatKhau.Location = new Point(465, 378);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(323, 33);
            QuenMatKhau.TabIndex = 21;
            QuenMatKhau.Text = "Forgot your password? ";
            QuenMatKhau.UseVisualStyleBackColor = false;
            QuenMatKhau.Click += QuenMatKhau_Click;
            // 
            // DangKy
            // 
            DangKy.BackColor = Color.Navy;
            DangKy.FlatStyle = FlatStyle.Flat;
            DangKy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DangKy.ForeColor = SystemColors.ButtonHighlight;
            DangKy.Location = new Point(12, 378);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(323, 33);
            DangKy.TabIndex = 20;
            DangKy.Text = "Create new account";
            DangKy.UseVisualStyleBackColor = false;
            DangKy.Click += DangKy_Click;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Font = new Font("Segoe UI", 10F);
            show_password.ForeColor = Color.Gray;
            show_password.Location = new Point(449, 283);
            show_password.Name = "show_password";
            show_password.Size = new Size(123, 23);
            show_password.TabIndex = 19;
            show_password.Text = "Show Password";
            show_password.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(249, 203);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(76, 21);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(249, 120);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(81, 21);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // password
            // 
            password.Location = new Point(249, 227);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(322, 36);
            password.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(263, 87);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 15;
            label1.Text = " Log in to get started";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(341, 53);
            label4.Name = "label4";
            label4.Size = new Size(137, 24);
            label4.TabIndex = 24;
            label4.Text = "Get Started";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(Click_DangNhap);
            Controls.Add(QuenMatKhau);
            Controls.Add(DangKy);
            Controls.Add(show_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Button Click_DangNhap;
        private Button QuenMatKhau;
        private Button DangKy;
        private CheckBox show_password;
        private Label label3;
        private Label label2;
        private TextBox password;
        private Label label1;
        private Label label4;
        private EventHandler password_TextChanged_1;
    }
}