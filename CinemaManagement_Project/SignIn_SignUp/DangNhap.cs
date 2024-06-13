using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CinemaManagement_Project
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void DangKy_Click(object sender, EventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.ShowDialog();
        }
        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
        private void Click_DangNhap_Click(object sender, EventArgs e)
        {
            //Check quyen admin
            if (username.Text == "admin" && password.Text == "adminadminadmin")
            {
                this.Hide();
                //SelectMovieState selectMovieState = new SelectMovieState("admin");
                //selectMovieState.Show();
                SignIn_SignUp.Select sl = new SignIn_SignUp.Select();
                sl.Show();
            }
            else
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                try
                {
                    connect.Open();
                    string tk = username.Text;
                    string mk = password.Text;
                    string sql = "select * from Thong_Tin_Dang_Nhap where TenTk='" + tk + "' and MatKhau='" + mk + "'";
                    SqlCommand sqlcommand = new SqlCommand(sql, connect);
                    SqlDataReader reader = sqlcommand.ExecuteReader();
                    if (reader.Read() == true)
                    {

                        this.Hide();
                        //dang nhap voi tu cach khach
                        SelectMovieState selectMovieState = new SelectMovieState("guest");
                        selectMovieState.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai thông tin đăng nhập");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }

        }
        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password_CheckedChanged != null)
            {
                password.PasswordChar = '\0';
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void show_password_CheckedChanged_1(object sender, EventArgs e)
        {
            if (show_password.Checked == true)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }
    }
}

