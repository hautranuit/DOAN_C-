using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CinemaManagement_Project
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        public bool Check_username(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]{6,32}$");
        }
        public bool Check_password(string pass)
        {
            return Regex.IsMatch(pass, @"^[a-zA-Z0-9]{6,32}$");
        }
        public bool Check_email(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._]+@(gmail\.com|.+\.vn)$");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string tk = text_username.Text;
            string mk = text_password.Text;
            string nhapmk = text_repassword.Text;
            string email = text_email.Text;
            Modify modify = new Modify();
            if (!Check_username(tk))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ,Hãy nhập lại tên khác!");
            }
            else if (!Check_password(mk))
            {
                MessageBox.Show("Mật khẩu không hợp lệ,Hãy chọn mật khẩu khác!");
            }
            else if (nhapmk != mk)
            {
                MessageBox.Show("Mật khẩu nhập lại chưa đúng,hãy nhập lại!");
            }
            else if (!Check_email(email))
            {
                MessageBox.Show("Email không hợp lệ hãy nhập lại!");
            }
            else if (!modify.check(email))
            {
                MessageBox.Show("Email này đã được đăng ký");
            }
            else
            {
                try
                {
                    string query = "Insert into Thong_Tin_Dang_Nhap values ('" + tk + "','" + mk + "','" + email + "')";
                    modify.Add(query);
                    if (modify.check(query))
                    {
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Tên Tài Khoản đã tồn tại");
                }
            }

        }
    }
}
