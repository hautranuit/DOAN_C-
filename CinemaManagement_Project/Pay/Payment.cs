using CinemaManagement_Project.Pay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using static CinemaManagement_Project.SelectMovieState;

namespace CinemaManagement_Project
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lb_PayInfo_Click(object sender, EventArgs e)
        {
            lb_CusInfo.ForeColor = Color.White;
            lb_TicketInfo.ForeColor = Color.White;
            lb_PayInfo.ForeColor = Color.Yellow;
            CheckCusInfo();
        }

        private void lb_TicketInfo_Click(object sender, EventArgs e)
        {
            lb_PayInfo.ForeColor = Color.White;
            lb_CusInfo.ForeColor = Color.White;
            lb_TicketInfo.ForeColor = Color.Yellow;
            CheckCusInfo();
            ShowTicketInfo();
        }

        private void lb_CusInfo_Click(object sender, EventArgs e)
        {
            lb_PayInfo.ForeColor = Color.White;
            lb_CusInfo.ForeColor = Color.Yellow;
            lb_TicketInfo.ForeColor = Color.White;
            pn_CusInfo.Visible = true;
            pn_PayInfo.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_PayInfo_Click(sender, e);
            CheckCusInfo();
        }

        private void pic_discount_Click(object sender, EventArgs e)
        {
            pn_Voucher.Visible = true;
        }
        double TotalPrice;
        private void btn_Countinue_Click(object sender, EventArgs e)
        {
            if (cb_Voucher1.Checked == true)
            {
                double Price = double.Parse(lb_Price.Text.Replace("VND", "").Trim());
                TotalPrice = (Price * 0.8);
                lb_Price.Text = TotalPrice.ToString("N0") + " VND";
                lb_AppliedVoucher.Visible = true;

            }
            pn_Voucher.Visible = false;
        }

        private void pn_Voucher1_Click(object sender, EventArgs e)
        {
            cb_Voucher1.Checked = true;
            pn_Voucher1.BackColor = Color.Yellow;
        }

        private void pn_Voucher1_MouseHover(object sender, EventArgs e)
        {
            pn_Voucher1.BackColor = Color.Yellow;
        }

        private void pn_Voucher1_MouseLeave(object sender, EventArgs e)
        {
            if (cb_Voucher1.Checked != true)
            {
                pn_Voucher1.BackColor = Color.White;
            }
        }
        private void CheckCusInfo()
        {
            if (tbx_Name.Text != null && tbx_PhoneNumber.Text != null && tbx_Email.Text != null && cb_1.Checked == true && cb_2.Checked == true)
            {
                pn_PayInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        public static string NameMovie = null;
        public static string Age = null;
        public static string Address1 = null;
        public static string Address2 = null;
        public static string Room = null;
        public static string Number = null;
        public static string Seat = null;
        public static string NumSeat = null;
        public static string CornAndDrink = null;
        public static string NumCornAndDrink = null;
        public static string voucher = null;
        public static string price = null;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NameMovie = lb_Movie.Text;
            Age = lb_Age.Text;
            Address1 = lb_Address1.Text;
            Address2 = lb_Address2.Text;
            Room = lb_RoomInfo.Text;
            Number = lb_NumberInfo.Text;
            Seat = lb_SeatInfo.Text;
            NumSeat = lb_NumberInfo.Text;
            CornAndDrink = lb_Corn_Drink_Info.Text;
            NumCornAndDrink = lb_Num_Corn_Drink_Info.Text;
            voucher = lb_AppliedVoucher.Text;
            price = lb_Price.Text;


            QRCodePayment qr = new QRCodePayment();
            qr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCusInfo();
            ShowTicketInfo();
        }
        private void ShowTicketInfo()
        {
            Ticket_NameMovie.Text = lb_Movie.Text;
            Ticket_Address1.Text = lb_Address1.Text;
            Ticket_Address2.Text = lb_Address2.Text;

            lb_CusInfo.ForeColor = Color.White;
            lb_PayInfo.ForeColor = Color.White;
            lb_TicketInfo.ForeColor = Color.Yellow;
            string transferContent = GenerateRandomString(20);
            lb_TicketCode.Text = transferContent;

            pn_TicketInfo.Visible = true;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(lb_TicketCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            picQRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);

            // Giải phóng tài nguyên
            qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if(selectedMovie == "1")
            {
                lb_Movie.Text = NameOfMovie1;
            }
            else if (selectedMovie == "2")
            {
                lb_Movie.Text = NameOfMovie2;
            }
            else if (selectedMovie == "3")
            {
                lb_Movie.Text = NameOfMovie3;
            }
            else if(selectedMovie == "4")
            {
                lb_Movie.Text = NameOfMovie4;
            }
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
