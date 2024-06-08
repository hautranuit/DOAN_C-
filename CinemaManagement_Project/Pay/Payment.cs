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
using static CinemaManagement_Project.BuyTickets.FoodAndDrink;
using static CinemaManagement_Project.BuyTickets.Theater2;
using static CinemaManagement_Project.BuyTickets.Theater3;
using static CinemaManagement_Project.Theater1;
using CinemaManagement_Project.BuyTickets;
using System.Net.Mail;
using System.Net;
using System.Drawing.Imaging;
using System.Net.Mime;

namespace CinemaManagement_Project
{
    public partial class Payment : Form
    {
        private DataTable comboTable;
        public Payment(DataTable table)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboTable = table;
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
        private string emailReceived;
        private void button2_Click(object sender, EventArgs e)
        {   
            emailReceived = tbx_Email.Text;
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
            if (selectedMovie == "1")
            {
                lb_Movie.Text = NameOfMovie1;
                lb_Age.Text = AgeOfMovie1;
            }
            else if (selectedMovie == "2")
            {
                lb_Movie.Text = NameOfMovie2;
                lb_Age.Text = AgeOfMovie2;
            }
            else if (selectedMovie == "3")
            {
                lb_Movie.Text = NameOfMovie3;
                lb_Age.Text = AgeOfMovie3;
            }
            else if (selectedMovie == "4")
            {
                lb_Movie.Text = NameOfMovie4;
                lb_Age.Text = AgeOfMovie4;
            }
            
            lb_RoomInfo.Text = selectedTheater;
            lb_NumberInfo.Text = countTickets.ToString();

            if (selectedTheater == "1")
            {
                lb_SeatInfo.Text = Theater1.TypeOfSeat;
                lb_NumSeatInfo.Text = Theater1.NumSeat;
            }
            else if (selectedTheater == "2")
            {
                lb_SeatInfo.Text = BuyTickets.Theater2.TypeOfSeat;
                lb_NumSeatInfo.Text = BuyTickets.Theater2.NumSeat;
            }
            else if (selectedTheater == "3")
            {
                lb_SeatInfo.Text = BuyTickets.Theater3.TypeOfSeat;
                lb_NumSeatInfo.Text = BuyTickets.Theater3.NumSeat;
            }
            // Cập nhật lb_Corn_Drink_Info.Text và lb_Num_Corn_Drink_Info.Text từ comboTable
            StringBuilder cornDrinkInfo = new StringBuilder();
            StringBuilder numCornDrinkInfo = new StringBuilder();

            foreach (DataRow row in comboTable.Rows)
            {
                cornDrinkInfo.AppendLine(row["ComboName"].ToString());
                numCornDrinkInfo.AppendLine(row["Quantity"].ToString());
            }

            lb_Corn_Drink_Info.Text = cornDrinkInfo.ToString();
            lb_Num_Corn_Drink_Info.Text = numCornDrinkInfo.ToString();

            lb_Price.Text = totalMoney;

        }
        private string GenerateRandomString(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btn_Complete_Click(object sender, EventArgs e)
        {
            
            string recipientEmail = emailReceived;
            string subject = "Thông tin vé xem phim của bạn";
            string body = GenerateEmailBody();
            SendEmail(recipientEmail, subject, body, "smtp.gmail.com", "22520412@gm.uit.edu.vn", "qlar xdqm most pyjx");
            MessageBox.Show("Vé xem phim của bạn đã được gửi qua email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show ThankYou form and close the current form
            ThankYou thankYou = new ThankYou();
            this.Close();
            thankYou.Show();

        }
        private string GenerateEmailBody()
        {
            string movieName = lb_Movie.Text;
            string ticketCode = lb_TicketCode.Text;
            string address = lb_Address2.Text;
            string roomInfo = lb_RoomInfo.Text;
            string seatInfo = lb_NumSeatInfo.Text;
            string comboInfo = lb_Corn_Drink_Info.Text != "" ? lb_Corn_Drink_Info.Text : "Không có";
            string voucherInfo = lb_AppliedVoucher.Text != "" ? lb_AppliedVoucher.Text : "Không có";
            string totalPrice = lb_Price.Text;

            return $@"
        <html>
        <head>
            <style>
                body {{
                    font-family: Arial, sans-serif;
                    color: #333;
                }}
                h1 {{
                    color: #800080; /* Màu tím đậm */
                }}
                p {{
                    font-size: 14px;
                }}
                .label {{
                    font-weight: bold;
                    color: #D8BFD8; /* Màu tím nhạt */
                }}
                .value {{
                    color: #FFFF66;
                }}
            </style>
        </head>
        <body>
            <h1>THÔNG TIN VÉ XEM PHIM CỦA BẠN</h1>
            <p><span class='label'>Tên phim:</span> <span class='value'>{movieName}</span></p>
            <p><span class='label'>Mã vé:</span> <span class='value'>{ticketCode}</span></p>
            <p><span class='label'>Địa chỉ:</span> <span class='value'>{address}</span></p>
            <p><span class='label'>Phòng chiếu:</span> <span class='value'>{roomInfo}</span></p>
            <p><span class='label'>Thông tin ghế:</span> <span class='value'>{seatInfo}</span></p>
            <p><span class='label'>Combo:</span> <span class='value'>{comboInfo}</span></p>
            <p><span class='label'>Voucher:</span> <span class='value'>{voucherInfo}</span></p>
            <p><span class='label'>Tổng tiền:</span> <span class='value'>{totalPrice}</span></p>
            <img src='cid:movieTicketImage' alt='Movie Ticket' />
            <p><strong>Lưu ý / Note:</strong><br>
                    Vé đã mua không thể hủy, đổi hoặc trả lại. Vui lòng liên hệ Ban Quản Lý rạp hoặc tra cứu thông tin tại mục Điều khoản mua và sử dụng vé xem phim để biết thêm chi tiết. Cảm ơn bạn đã lựa chọn mua vé qua Ứng dụng Ví điện tử VNPAY. Chúc bạn xem phim vui vẻ!<br>
                    The successful movie ticket cannot be canceled, exchanged or refunded. If you have any question or problems with this order, you can contact Theater Manager or see our Condition to purchase and use movie tickets for more information. Thank you for choosing Ứng dụng Ví điện tử VNPAY and Enjoy the movie!
                    </p>
                </body>
                </html>"";      
    ";
        }
        private void SendEmail(string recipientEmail, string subject, string body, string smtpHost, string smtpUser, string smtpPass)
        {
            var smtpClient = new SmtpClient(smtpHost)
            {
                Port = 587,
                Credentials = new NetworkCredential(smtpUser, smtpPass),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(smtpUser),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(recipientEmail);

            // Convert PictureBox image to MemoryStream
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, ImageFormat.Png);
            ms.Position = 0;
            // Add image as an attachment
            var inlineLogo = new Attachment(ms, "movieTicketImage.png", "image/png");
            inlineLogo.ContentId = "movieTicketImage";
            inlineLogo.ContentDisposition.Inline = true;
            inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            mailMessage.Attachments.Add(inlineLogo);

            // Chuyển đổi PictureBox image (QRCode) thành MemoryStream
            MemoryStream msQRCode = new MemoryStream();
            picQRCode.Image.Save(msQRCode, ImageFormat.Png);
            msQRCode.Position = 0;

            // Thêm QRCode dưới dạng tệp đính kèm
            var qrCodeAttachment = new Attachment(msQRCode, "QRCodeMaDatVe.png", "image/png");
            qrCodeAttachment.ContentId = "QRCodeMaDatVe";
            qrCodeAttachment.ContentDisposition.Inline = true;
            qrCodeAttachment.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            mailMessage.Attachments.Add(qrCodeAttachment);

            smtpClient.Send(mailMessage);
        }
    }
}
