using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement_Project
{
    internal class Modify
    {
        public bool check(string tmp)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string check = tmp;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Thong_Tin_Dang_Nhap WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", check);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public void Add(string query)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sql = new SqlCommand(query, connection);
                sql.ExecuteNonQuery();
                MessageBox.Show("Đăng kí thành công");

            }
        }
        public void Connect_Sql(string query, int Mat_Khau_Moi, string Email_Dang_Ky)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatKhauMoi", Mat_Khau_Moi);
                    command.Parameters.AddWithValue("@Email", Email_Dang_Ky);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Số hàng đã được cập nhật: " + rowsAffected);
                }
            }
        }
    }
}
