namespace CinemaManagement_Project.SignIn_SignUp
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            btn_MovieMana = new Button();
            btn_PaymentMana = new Button();
            btn_SignOut = new Button();
            SuspendLayout();
            // 
            // btn_MovieMana
            // 
            btn_MovieMana.BackColor = Color.Indigo;
            btn_MovieMana.FlatStyle = FlatStyle.Flat;
            btn_MovieMana.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MovieMana.ForeColor = Color.AliceBlue;
            btn_MovieMana.Location = new Point(96, 144);
            btn_MovieMana.Margin = new Padding(3, 4, 3, 4);
            btn_MovieMana.Name = "btn_MovieMana";
            btn_MovieMana.Size = new Size(238, 44);
            btn_MovieMana.TabIndex = 41;
            btn_MovieMana.Text = "QUẢN LÝ PHIM";
            btn_MovieMana.UseVisualStyleBackColor = true;
            btn_MovieMana.Click += btn_MovieMana_Click;
            // 
            // btn_PaymentMana
            // 
            btn_PaymentMana.BackColor = Color.Indigo;
            btn_PaymentMana.FlatStyle = FlatStyle.Flat;
            btn_PaymentMana.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_PaymentMana.ForeColor = Color.AliceBlue;
            btn_PaymentMana.Location = new Point(414, 144);
            btn_PaymentMana.Margin = new Padding(3, 4, 3, 4);
            btn_PaymentMana.Name = "btn_PaymentMana";
            btn_PaymentMana.Size = new Size(238, 44);
            btn_PaymentMana.TabIndex = 42;
            btn_PaymentMana.Text = "QUẢN LÝ BÁN HÀNG";
            btn_PaymentMana.UseVisualStyleBackColor = false;
            btn_PaymentMana.Click += btn_PaymentMana_Click;
            // 
            // btn_SignOut
            // 
            btn_SignOut.BackColor = Color.DarkSlateBlue;
            btn_SignOut.Cursor = Cursors.Hand;
            btn_SignOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SignOut.ForeColor = Color.AliceBlue;
            btn_SignOut.Location = new Point(283, 245);
            btn_SignOut.Name = "btn_SignOut";
            btn_SignOut.Size = new Size(180, 39);
            btn_SignOut.TabIndex = 49;
            btn_SignOut.Text = "ĐĂNG XUẤT";
            btn_SignOut.UseVisualStyleBackColor = false;
            btn_SignOut.Click += btn_SignOut_Click;
            // 
            // Select
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 317);
            Controls.Add(btn_SignOut);
            Controls.Add(btn_PaymentMana);
            Controls.Add(btn_MovieMana);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Select";
            Text = "Select";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_MovieMana;
        private Button btn_PaymentMana;
        private Button btn_SignOut;
    }
}