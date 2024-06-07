using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

using QRCodeDecoderLibrary;
using static CinemaManagement_Project.Payment;


namespace CinemaManagement_Project.Pay
{
    public partial class QRCodePayment : Form
    {
        public QRCodePayment()
        {
            InitializeComponent();
        }

        private void QRCode_Load(object sender, EventArgs e)
        {   
            string transferContent = GenerateRandomString(10);

            lb_QRCode.Text = $"SỐ TIỀN CẦN THANH TOÁN: {price}\n" +
                             $"NGÂN HÀNG: VIETCOMBANK(VCB)\n" +
                             $"STK: 9868009253\n" +
                             $"Nội dung: {transferContent}\n" +
                             $"{NameMovie}\n" +
                             $"{Age}\n" +
                             $"{Address1}\n" +
                             $"{Address2}\n" +
                             $"Phòng chiếu: {Room}\n" +
                             $"Số vé: {Number}\n" +
                             $"Loại ghế: {Seat}\n" +
                             $"Số ghế: {NumSeat}\n" +
                             $"Bắp nước: {CornAndDrink}\n" +
                             $"Số Lượng: {NumCornAndDrink}\n" +
                             $"Mã giảm giá: {voucher}";


            // Sử dụng thư viện QRCoder để tạo QR Code từ lb_QRCode.Text
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(lb_QRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            picQRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);

            // Giải phóng tài nguyên
            qrGenerator.Dispose();
            qrCode.Dispose();
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void QRCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
