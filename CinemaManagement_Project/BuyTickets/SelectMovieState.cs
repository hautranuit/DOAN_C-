using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using CinemaManagement_Project.BuyTickets;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Data.SqlClient;
using CinemaManagement_Project.Pay;

namespace CinemaManagement_Project
{
    public partial class SelectMovieState : Form
    {
        private string Role;
        public static PictureBox pictureBox;
        public static PictureBox picMovie;

        public SelectMovieState(string role)
        {
            pictureBox = new PictureBox();
            picMovie = new PictureBox();

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Role = role;
            LoadMovieInfoFromDatabase();
        }

        private void panel_Movie1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel_Movie1_MouseLeave(object sender, EventArgs e)
        {
            panel_Movie1.Visible = false;
        }

        private void panel_Movie2_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel_Movie2_MouseLeave(object sender, EventArgs e)
        {
            panel_Movie2.Visible = false;
        }

        private void panel_Movie3_MouseHover(object sender, EventArgs e)
        {

        }
        private void panel_Movie3_MouseLeave(object sender, EventArgs e)
        {
            panel_Movie3.Visible = false;
        }

        private void panel_Movie4_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel_Movie4_MouseLeave(object sender, EventArgs e)
        {
            panel_Movie4.Visible = false;
        }

        private void pic_background_Click(object sender, EventArgs e)
        {

        }

        private void pic_Movie1_MouseHover(object sender, EventArgs e)
        {
            panel_Movie1.Visible = true;
        }

        private void pic_Movie1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pic_Movie2_MouseHover(object sender, EventArgs e)
        {
            panel_Movie2.Visible = true;
        }

        private void pic_Movie3_MouseHover(object sender, EventArgs e)
        {
            panel_Movie3.Visible = true;
        }

        private void pic_Movie4_MouseHover(object sender, EventArgs e)
        {
            panel_Movie4.Visible = true;
        }

        private void btn_Book1_Click(object sender, EventArgs e)
        {
            pn_SelectTheater.Visible = true;
            UpdateComboBoxWithTheaters(lab_Detail1_NumCinema.Text);
            selectedMovie = "1";
        }
        public static string NameOfMovie1 = null;
        public static string NameOfMovie2 = null;
        public static string NameOfMovie3 = null;
        public static string NameOfMovie4 = null;

        public static string AgeOfMovie1 = null;
        public static string AgeOfMovie2 = null;
        public static string AgeOfMovie3 = null;
        public static string AgeOfMovie4 = null;
        private void SelectMovieState_Load(object sender, EventArgs e)
        {
            NameOfMovie1 = lab_Detail1_Name.Text;
            NameOfMovie2 = lab_Detail2_Name.Text;
            NameOfMovie3 = lab_Detail3_Name.Text;
            NameOfMovie4 = lab_Detail4_Name.Text;

            AgeOfMovie1 = ExtractAgeFromLabel(lab_NameOfMovie1.Text);
            AgeOfMovie2 = ExtractAgeFromLabel(lab_NameOfMovie2.Text);
            AgeOfMovie3 = ExtractAgeFromLabel(lab_NameOfMovie3.Text);
            AgeOfMovie4 = ExtractAgeFromLabel(lab_NameOfMovie4.Text);

            lab_NameOfMovie1.Parent = pic_background;
            lab_NameOfMovie1.BackColor = Color.Transparent;

            lab_NameOfMovie2.Parent = pic_background;
            lab_NameOfMovie2.BackColor = Color.Transparent;

            lab_NameOfMovie3.Parent = pic_background;
            lab_NameOfMovie3.BackColor = Color.Transparent;

            lab_NameOfMovie4.Parent = pic_background;
            lab_NameOfMovie4.BackColor = Color.Transparent;

            lab_Title1.Parent = pic_background;
            lab_Title1.BackColor = Color.Transparent;

            lb_SelectTheater.Parent = pn_SelectTheater;
            lb_SelectTheater.BackColor = Color.Transparent;

            btn_cancel.Parent = pn_SelectTheater;
            lb_SelectTheater.BackColor = Color.Transparent;

            //check quyen dang nhap
            if (Role == "admin")
            {
                btn_Book1.Visible = false;
                btn_Book2.Visible = false;
                btn_Book3.Visible = false;
                btn_Book4.Visible = false;

                btn_Edit_Movie.Visible = true;

                btn_edit1.Visible = true;
                btn_edit2.Visible = true;
                btn_edit3.Visible = true;
                btn_edit4.Visible = true;
            }
        }
        private string ExtractAgeFromLabel(string labelText)
        {
            var match = System.Text.RegularExpressions.Regex.Match(labelText, @"\(([^)]*)\)");
            return match.Success ? match.Groups[1].Value : string.Empty;
        }
        private void btn_Edit_Movie_Click(object sender, EventArgs e)
        {
            btn_edit1.Visible = false;
            btn_edit2.Visible = false;
            btn_edit3.Visible = false;
            btn_edit4.Visible = false;
            btn_SignOut.Visible = false;
            btn_Book1.Visible = false;
            btn_Book2.Visible = false;
            btn_Book3.Visible = false;
            btn_Book4.Visible = false;
            btn_Apply.Visible = true;
            tbx_1.Visible = true;
            tbx_2.Visible = true;
            tbx_3.Visible = true;
            tbx_4.Visible = true;
            tbx_1.Text = lab_NameOfMovie1.Text;
            tbx_2.Text = lab_NameOfMovie2.Text;
            tbx_3.Text = lab_NameOfMovie3.Text;
            tbx_4.Text = lab_NameOfMovie4.Text;

            lab_Title1.Visible = false;

            btn_AddPic1.Visible = true;
            btn_AddPic2.Visible = true;
            btn_AddPic3.Visible = true;
            btn_AddPic4.Visible = true;

            btn_Edit_Movie.Visible = false;

            btn_blurred1.Visible = true;
            btn_blurred2.Visible = true;
            btn_blurred3.Visible = true;
            btn_blurred4.Visible = true;

            tbx_info1_name.Visible = true;
            tbx_info1_name.Text = lab_Detail1_Name.Text;
            tbx_info2_name.Visible = true;
            tbx_info2_name.Text = lab_Detail2_Name.Text;
            tbx_info3_name.Visible = true;
            tbx_info3_name.Text = lab_Detail3_Name.Text;
            tbx_info4_name.Visible = true;
            tbx_info4_name.Text = lab_Detail4_Name.Text;

            tbx_info1_price.Visible = true;
            tbx_info1_price.Text = lab_Detail1_Money.Text;
            tbx_info2_price.Visible = true;
            tbx_info2_price.Text = lab_Detail2_Money.Text;
            tbx_info3_price.Visible = true;
            tbx_info3_price.Text = lab_Detail3_Money.Text;
            tbx_info4_price.Visible = true;
            tbx_info4_price.Text = lab_Detail4_Money.Text;

            tbx_info1_theater.Visible = true;
            tbx_info1_theater.Text = lab_Detail1_NumCinema.Text;
            tbx_info2_theater.Visible = true;
            tbx_info2_theater.Text = lab_Detail2_NumCinema.Text;
            tbx_info3_theater.Visible = true;
            tbx_info3_theater.Text = lab_Detail3_NumCinema.Text;
            tbx_info4_theater.Visible = true;
            tbx_info4_theater.Text = lab_Detail4_NumCinema.Text;

            tbx_info1_country.Visible = true;
            tbx_info1_country.Text = lab_Detail1_Country.Text;
            tbx_info2_country.Visible = true;
            tbx_info2_country.Text = lab_Detail2_Country.Text;
            tbx_info3_country.Visible = true;
            tbx_info3_country.Text = lab_Detail3_Country.Text;
            tbx_info4_country.Visible = true;
            tbx_info4_country.Text = lab_Detail4_Country.Text;

            btn_Trailer1.Visible = false;
            btn_Trailer2.Visible = false;
            btn_Trailer3.Visible = false;
            btn_Trailer4.Visible = false;
        }

        private void btn_AddPic1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;

                pic_Movie1.Image = Image.FromFile(imagePath);
            }

        }

        private void btn_AddPic2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog2.FileName;

                pic_Movie2.Image = Image.FromFile(imagePath);
            }
        }

        private void btn_AddPic3_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog3.FileName;

                pic_Movie3.Image = Image.FromFile(imagePath);
            }
        }

        private void btn_AddPic4_Click(object sender, EventArgs e)
        {
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog4.FileName;

                pic_Movie4.Image = Image.FromFile(imagePath);
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

            btn_edit1.Visible = true;
            btn_edit2.Visible = true;
            btn_edit3.Visible = true;
            btn_edit4.Visible = true;

            btn_Edit_Movie.Visible = true;
            btn_SignOut.Visible = true;
            lab_NameOfMovie1.Text = tbx_1.Text;
            lab_NameOfMovie2.Text = tbx_2.Text;
            lab_NameOfMovie3.Text = tbx_3.Text;
            lab_NameOfMovie4.Text = tbx_4.Text;
            btn_Apply.Visible = false;

            tbx_1.Visible = false;
            tbx_2.Visible = false;
            tbx_3.Visible = false;
            tbx_4.Visible = false;
            btn_AddPic1.Visible = false;
            btn_AddPic2.Visible = false;
            btn_AddPic3.Visible = false;
            btn_AddPic4.Visible = false;
            lab_Title1.Visible = true;
            btn_Book1.Visible = false;
            btn_Book2.Visible = false;
            btn_Book3.Visible = false;
            btn_Book4.Visible = false;
            btn_blurred1.Visible = false;
            btn_blurred2.Visible = false;
            btn_blurred3.Visible = false;
            btn_blurred4.Visible = false;

            tbx_info1_name.Visible = false;
            lab_Detail1_Name.Text = tbx_info1_name.Text;
            tbx_info2_name.Visible = false;
            lab_Detail2_Name.Text = tbx_info2_name.Text;
            tbx_info3_name.Visible = false;
            lab_Detail3_Name.Text = tbx_info3_name.Text;
            tbx_info4_name.Visible = false;
            lab_Detail4_Name.Text = tbx_info4_name.Text;

            tbx_info1_price.Visible = false;
            lab_Detail1_Money.Text = tbx_info1_price.Text;
            tbx_info2_price.Visible = false;
            lab_Detail2_Money.Text = tbx_info2_price.Text;
            tbx_info3_price.Visible = false;
            lab_Detail3_Money.Text = tbx_info1_price.Text;
            tbx_info4_price.Visible = false;
            lab_Detail4_Money.Text = tbx_info4_price.Text;

            tbx_info1_theater.Visible = false;
            lab_Detail1_NumCinema.Text = tbx_info1_theater.Text;
            tbx_info2_theater.Visible = false;
            lab_Detail2_NumCinema.Text = tbx_info2_theater.Text;
            tbx_info3_theater.Visible = false;
            lab_Detail3_NumCinema.Text = tbx_info3_theater.Text;
            tbx_info4_theater.Visible = false;
            lab_Detail4_NumCinema.Text = tbx_info4_theater.Text;

            tbx_info1_country.Visible = false;
            lab_Detail1_Country.Text = tbx_info1_country.Text;
            tbx_info2_country.Visible = false;
            lab_Detail2_Country.Text = tbx_info2_country.Text;
            tbx_info3_country.Visible = false;
            lab_Detail3_Country.Text = tbx_info3_country.Text;
            tbx_info4_country.Visible = false;
            lab_Detail4_Country.Text = tbx_info4_country.Text;

            btn_Trailer1.Visible = true;
            btn_Trailer2.Visible = true;
            btn_Trailer3.Visible = true;
            btn_Trailer4.Visible = true;

            //CapnhatPhim
            UpdateMovieInfoInDatabase(1, tbx_info1_name.Text, tbx_info1_price.Text, tbx_info1_theater.Text, tbx_info1_country.Text);
            UpdateMovieInfoInDatabase(2, tbx_info2_name.Text, tbx_info2_price.Text, tbx_info2_theater.Text, tbx_info2_country.Text);
            UpdateMovieInfoInDatabase(3, tbx_info3_name.Text, tbx_info3_price.Text, tbx_info3_theater.Text, tbx_info3_country.Text);
            UpdateMovieInfoInDatabase(4, tbx_info4_name.Text, tbx_info4_price.Text, tbx_info4_theater.Text, tbx_info4_country.Text);

        }
        public static string price_film1 = null;
        public static string price_film2 = null;
        public static string price_film3 = null;
        public static string price_film4 = null;
        private void btn_blurred1_Click(object sender, EventArgs e)
        {
            if (openFileDialog5.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog5.FileName;

                panel_Movie1.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void btn_blurred2_Click(object sender, EventArgs e)
        {
            if (openFileDialog6.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog6.FileName;

                panel_Movie2.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void btn_blurred3_Click(object sender, EventArgs e)
        {
            if (openFileDialog7.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog7.FileName;

                panel_Movie3.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void btn_blurred4_Click(object sender, EventArgs e)
        {
            if (openFileDialog8.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog8.FileName;

                panel_Movie4.BackgroundImage = Image.FromFile(imagePath);
            }
        }

        private void btn_Trailer2_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie2.Image;
            OpenTrailerForm(2);
        }

        private void btn_Book2_Click(object sender, EventArgs e)
        {
            pn_SelectTheater.Visible = true;
            UpdateComboBoxWithTheaters(lab_Detail2_NumCinema.Text);
            selectedMovie = "2";
        }

        private void btn_Book3_Click(object sender, EventArgs e)
        {
            pn_SelectTheater.Visible = true;
            UpdateComboBoxWithTheaters(lab_Detail3_NumCinema.Text);
            selectedMovie = "3";
        }

        private void btn_Book4_Click(object sender, EventArgs e)
        {
            pn_SelectTheater.Visible = true;
            UpdateComboBoxWithTheaters(lab_Detail4_NumCinema.Text);
            selectedMovie = "4";
        }

        private void UpdateComboBoxWithTheaters(string theaters)
        {
            // Clear the existing items
            comboBox1.Items.Clear();

            // Remove the first 4 characters and then split the string by comma
            if (theaters.Length > 4)
            {
                string processedTheaters = theaters.Substring(4);
                string[] theaterList = processedTheaters.Split(',');

                foreach (var theater in theaterList)
                {
                    comboBox1.Items.Add(theater.Trim());
                }
            }
        }
        public static string selectedTheater;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pn_SelectTheater.Visible = false;
        }
        public static string selectedMovie;
        private void btn_Book_Click(object sender, EventArgs e)
        {
            if (selectedMovie == "1")
            {
                pictureBox.Image = pic_Movie1.Image;
            }
            else if (selectedMovie == "2")
            {
                pictureBox.Image = pic_Movie2.Image;
            }
            else if (selectedMovie == "3")
            {
                pictureBox.Image = pic_Movie3.Image;
            }
            else if (selectedMovie == "4")
            {
                pictureBox.Image = pic_Movie4.Image;
            }
            selectedTheater = comboBox1.SelectedItem as string;

            price_film1 = lab_Detail1_Money.Text.Replace(" đ", "");
            price_film2 = lab_Detail2_Money.Text.Replace(" đ", "");
            price_film3 = lab_Detail3_Money.Text.Replace(" đ", "");
            price_film4 = lab_Detail4_Money.Text.Replace(" đ", "");

            if (selectedTheater == "1")
            {
                Theater1 theater1 = new Theater1();
                theater1.Show();
                this.Hide();
            }
            else if (selectedTheater == "2")
            {
                Theater2 theater2 = new Theater2();
                theater2.Show();
                this.Hide();
            }
            else if (selectedTheater == "3")
            {
                Theater3 theater3 = new Theater3();
                theater3.Show();
                this.Hide();
            }
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            if (Role == "guest")
            {
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
            else
            {
                this.Close();
                SignIn_SignUp.Select sl = new SignIn_SignUp.Select();
                sl.Show();
            }
        }

        //Cac ham load phim tu SQL
        private void UpdateMovieInfoInDatabase(int movieId, string name, string price, string theater, string country)
        {
            string connectionString = "Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Movies SET Name = @Name, Image = @Image, BlurredImage = @BlurredImage, Price = @Price, Theater = @Theater, Country = @Country WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", tbx_info1_name.Text);
                    command.Parameters.AddWithValue("@Image", ImageToByteArray(pic_Movie1.Image));
                    command.Parameters.AddWithValue("@BlurredImage", ImageToByteArray(panel_Movie1.BackgroundImage));
                    command.Parameters.AddWithValue("@Price", tbx_info1_price.Text);
                    command.Parameters.AddWithValue("@Theater", tbx_info1_theater.Text);
                    command.Parameters.AddWithValue("@Country", tbx_info1_country.Text);
                    command.Parameters.AddWithValue("@Id", 1);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", tbx_info2_name.Text);
                    command.Parameters.AddWithValue("@Image", ImageToByteArray(pic_Movie2.Image));
                    command.Parameters.AddWithValue("@BlurredImage", ImageToByteArray(panel_Movie2.BackgroundImage));
                    command.Parameters.AddWithValue("@Price", tbx_info2_price.Text);
                    command.Parameters.AddWithValue("@Theater", tbx_info2_theater.Text);
                    command.Parameters.AddWithValue("@Country", tbx_info2_country.Text);
                    command.Parameters.AddWithValue("@Id", 2);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", tbx_info3_name.Text);
                    command.Parameters.AddWithValue("@Image", ImageToByteArray(pic_Movie3.Image));
                    command.Parameters.AddWithValue("@BlurredImage", ImageToByteArray(panel_Movie3.BackgroundImage));
                    command.Parameters.AddWithValue("@Price", tbx_info3_price.Text);
                    command.Parameters.AddWithValue("@Theater", tbx_info3_theater.Text);
                    command.Parameters.AddWithValue("@Country", tbx_info3_country.Text);
                    command.Parameters.AddWithValue("@Id", 3);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", tbx_info4_name.Text);
                    command.Parameters.AddWithValue("@Image", ImageToByteArray(pic_Movie4.Image));
                    command.Parameters.AddWithValue("@BlurredImage", ImageToByteArray(panel_Movie4.BackgroundImage));
                    command.Parameters.AddWithValue("@Price", tbx_info4_price.Text);
                    command.Parameters.AddWithValue("@Theater", tbx_info4_theater.Text);
                    command.Parameters.AddWithValue("@Country", tbx_info4_country.Text);
                    command.Parameters.AddWithValue("@Id", 4);
                    command.ExecuteNonQuery();
                }
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void LoadMovieInfoFromDatabase()
        {
            string connectionString = @"Data Source=.;Initial Catalog=Bai_Thuc_Hanh_01;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Movies";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tbx_info1_name.Text = reader["Name"].ToString();
                    lab_Detail1_Name.Text = reader["Name"].ToString();
                    lab_NameOfMovie1.Text = reader["Name"].ToString();
                    lab_Detail1_Money.Text = reader["Price"].ToString();
                    lab_Detail1_NumCinema.Text = reader["Theater"].ToString();
                    lab_Detail1_Country.Text = reader["Country"].ToString();
                    pic_Movie1.Image = ByteArrayToImage((byte[])reader["Image"]);
                    panel_Movie1.BackgroundImage = ByteArrayToImage((byte[])reader["BlurredImage"]);
                }

                if (reader.Read())
                {
                    tbx_info2_name.Text = reader["Name"].ToString();
                    lab_Detail2_Name.Text = reader["Name"].ToString();
                    lab_NameOfMovie2.Text = reader["Name"].ToString();
                    lab_Detail2_Money.Text = reader["Price"].ToString();
                    lab_Detail2_NumCinema.Text = reader["Theater"].ToString();
                    lab_Detail2_Country.Text = reader["Country"].ToString();
                    pic_Movie2.Image = ByteArrayToImage((byte[])reader["Image"]);
                    panel_Movie2.BackgroundImage = ByteArrayToImage((byte[])reader["BlurredImage"]);
                }

                if (reader.Read())
                {
                    tbx_info3_name.Text = reader["Name"].ToString();
                    lab_Detail3_Name.Text = reader["Name"].ToString();
                    lab_NameOfMovie3.Text = reader["Name"].ToString();
                    lab_Detail3_Money.Text = reader["Price"].ToString();
                    lab_Detail3_NumCinema.Text = reader["Theater"].ToString();
                    lab_Detail3_Country.Text = reader["Country"].ToString();
                    pic_Movie3.Image = ByteArrayToImage((byte[])reader["Image"]);
                    panel_Movie3.BackgroundImage = ByteArrayToImage((byte[])reader["BlurredImage"]);
                }

                if (reader.Read())
                {
                    tbx_info4_name.Text = reader["Name"].ToString();
                    lab_Detail4_Name.Text = reader["Name"].ToString();
                    lab_NameOfMovie4.Text = reader["Name"].ToString();
                    lab_Detail4_Money.Text = reader["Price"].ToString();
                    lab_Detail4_NumCinema.Text = reader["Theater"].ToString();
                    lab_Detail4_Country.Text = reader["Country"].ToString();
                    pic_Movie4.Image = ByteArrayToImage((byte[])reader["Image"]);
                    panel_Movie4.BackgroundImage = ByteArrayToImage((byte[])reader["BlurredImage"]);
                }
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_Trailer1_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie1.Image;
            OpenTrailerForm(1);

        }

        private void btn_Trailer3_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie3.Image;
            OpenTrailerForm(3);
        }

        private void btn_Trailer4_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie4.Image;
            OpenTrailerForm(4);
        }
        private void OpenTrailerForm(int selectedMovieId)
        {
            Trailer trailerForm = new Trailer(selectedMovieId);
            trailerForm.Show();
            this.Close();
        }

        private void btn_edit1_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie1.Image;
            EditTrailer edit = new EditTrailer(1);
            edit.Show();
            this.Close();
        }

        private void btn_edit2_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie2.Image;
            EditTrailer edit = new EditTrailer(2);
            edit.Show();
            this.Close();
        }

        private void btn_edit3_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie3.Image;
            EditTrailer edit = new EditTrailer(3);
            edit.Show();
            this.Close();
        }

        private void btn_edit4_Click(object sender, EventArgs e)
        {
            picMovie.Image = pic_Movie4.Image;
            EditTrailer edit = new EditTrailer(4);
            edit.Show();
            this.Close();
        }
    }
}