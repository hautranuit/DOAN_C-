using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement_Project
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Modify modifies = new Modify();
            if (modifies.check(Email_Dang_Ky.Text))
            {
                MessageBox.Show("Email chưa được đăng ký");
            }
            else
            {
                MailMessage mail = new MailMessage();

                mail.From = new System.Net.Mail.MailAddress("22521465@gm.uit.edu.vn");

                SmtpClient smtp = new SmtpClient();

                smtp.Port = 587;

                smtp.EnableSsl = true;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential(mail.From.Address, "sjgo tdej vnby ptwd");

                smtp.Host = "smtp.gmail.com";

                try
                {
                    mail.To.Add(new MailAddress(Email_Dang_Ky.Text));
                    mail.IsBodyHtml = true;
                    mail.Subject = "Mật khẩu mới của bạn";
                    Random random_pass = new Random();
                    int Mat_Khau_Moi = random_pass.Next(100000, 999999);
                    string sqlquery = "UPDATE Thong_Tin_Dang_Nhap SET MatKhau = @MatKhauMoi WHERE Email = @Email";
                    Modify modify = new Modify();
                    modify.Connect_Sql(sqlquery, Mat_Khau_Moi, Email_Dang_Ky.Text);
                    mail.Body = "" + Mat_Khau_Moi;
                    smtp.Send(mail);
                    MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while sending the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mail.Dispose();
                }
            }
        }
    }
}
