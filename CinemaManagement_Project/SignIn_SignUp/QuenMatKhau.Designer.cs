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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
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
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(258, 463);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(493, 65);
            button2.TabIndex = 16;
            button2.Text = "Send your new password via email";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(177, 297);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(134, 28);
            label2.TabIndex = 15;
            label2.Text = "Email đăng ký";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(346, 200);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 13;
            label1.Text = "Reset your password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(415, 108);
            label6.Name = "label6";
            label6.Size = new Size(173, 30);
            label6.TabIndex = 37;
            label6.Text = "Get Started";
            // 
            // Email_Dang_Ky
            // 
            Email_Dang_Ky.Location = new Point(312, 288);
            Email_Dang_Ky.Margin = new Padding(3, 4, 3, 4);
            Email_Dang_Ky.Multiline = true;
            Email_Dang_Ky.Name = "Email_Dang_Ky";
            Email_Dang_Ky.PasswordChar = '*';
            Email_Dang_Ky.Size = new Size(367, 47);
            Email_Dang_Ky.TabIndex = 38;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 600);
            Controls.Add(Email_Dang_Ky);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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