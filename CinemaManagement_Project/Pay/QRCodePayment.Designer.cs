namespace CinemaManagement_Project.Pay
{
    partial class QRCodePayment
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
            lb_QRCode = new Label();
            picQRCode = new PictureBox();
            lb_Movie = new Label();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            SuspendLayout();
            // 
            // lb_QRCode
            // 
            lb_QRCode.BackColor = Color.Transparent;
            lb_QRCode.ForeColor = Color.DarkSlateBlue;
            lb_QRCode.Location = new Point(12, 9);
            lb_QRCode.Name = "lb_QRCode";
            lb_QRCode.Size = new Size(412, 124);
            lb_QRCode.TabIndex = 0;
            lb_QRCode.Text = "Thông tin tạo QRCode";
            lb_QRCode.Visible = false;
            // 
            // picQRCode
            // 
            picQRCode.Location = new Point(254, 38);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(301, 248);
            picQRCode.TabIndex = 1;
            picQRCode.TabStop = false;
            // 
            // lb_Movie
            // 
            lb_Movie.AutoSize = true;
            lb_Movie.BackColor = Color.Transparent;
            lb_Movie.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Movie.ForeColor = Color.White;
            lb_Movie.Location = new Point(150, 313);
            lb_Movie.Name = "lb_Movie";
            lb_Movie.Size = new Size(453, 25);
            lb_Movie.TabIndex = 69;
            lb_Movie.Text = "QUÉT MÃ ĐỂ HIỂN THỊ THÔNG TIN THANH TOÁN";
            // 
            // QRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(718, 367);
            Controls.Add(lb_Movie);
            Controls.Add(picQRCode);
            Controls.Add(lb_QRCode);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "QRCode";
            Text = "QRCode";
            FormClosed += QRCode_FormClosed;
            Load += QRCode_Load;
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_QRCode;
        private PictureBox picQRCode;
        private Label lb_Movie;
    }
}