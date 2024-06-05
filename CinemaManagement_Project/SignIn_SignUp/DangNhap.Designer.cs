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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
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
            username.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(286, 207);
            username.Margin = new Padding(3, 4, 3, 4);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(367, 47);
            username.TabIndex = 23;
            // 
            // Click_DangNhap
            // 
            Click_DangNhap.BackColor = Color.SteelBlue;
            Click_DangNhap.FlatStyle = FlatStyle.Flat;
            Click_DangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Click_DangNhap.ForeColor = Color.AliceBlue;
            Click_DangNhap.Location = new Point(287, 424);
            Click_DangNhap.Margin = new Padding(3, 4, 3, 4);
            Click_DangNhap.Name = "Click_DangNhap";
            Click_DangNhap.Size = new Size(369, 44);
            Click_DangNhap.TabIndex = 22;
            Click_DangNhap.Text = "Sign in ";
            Click_DangNhap.UseVisualStyleBackColor = false;
            Click_DangNhap.Click += Click_DangNhap_Click;
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.BackColor = Color.SteelBlue;
            QuenMatKhau.FlatStyle = FlatStyle.Flat;
            QuenMatKhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuenMatKhau.ForeColor = Color.AliceBlue;
            QuenMatKhau.Location = new Point(548, 504);
            QuenMatKhau.Margin = new Padding(3, 4, 3, 4);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(369, 44);
            QuenMatKhau.TabIndex = 21;
            QuenMatKhau.Text = "Forgot your password? ";
            QuenMatKhau.UseVisualStyleBackColor = false;
            QuenMatKhau.Click += QuenMatKhau_Click;
            // 
            // DangKy
            // 
            DangKy.BackColor = Color.SteelBlue;
            DangKy.FlatStyle = FlatStyle.Flat;
            DangKy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DangKy.ForeColor = Color.AliceBlue;
            DangKy.Location = new Point(14, 504);
            DangKy.Margin = new Padding(3, 4, 3, 4);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(369, 44);
            DangKy.TabIndex = 20;
            DangKy.Text = "Create new account";
            DangKy.UseVisualStyleBackColor = false;
            DangKy.Click += DangKy_Click;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.BackColor = Color.Transparent;
            show_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            show_password.ForeColor = Color.AliceBlue;
            show_password.Location = new Point(513, 377);
            show_password.Margin = new Padding(3, 4, 3, 4);
            show_password.Name = "show_password";
            show_password.Size = new Size(148, 27);
            show_password.TabIndex = 19;
            show_password.Text = "Show Password";
            show_password.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(285, 271);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(93, 28);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(285, 160);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(99, 28);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(285, 303);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(367, 47);
            password.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(297, 104);
            label1.Name = "label1";
            label1.Size = new Size(335, 46);
            label1.TabIndex = 15;
            label1.Text = " Log in to get started";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(377, 63);
            label4.Name = "label4";
            label4.Size = new Size(179, 41);
            label4.TabIndex = 24;
            label4.Text = "Get Started";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 600);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangNhap";
            Text = "Form1";
            Load += DangNhap_Load;
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