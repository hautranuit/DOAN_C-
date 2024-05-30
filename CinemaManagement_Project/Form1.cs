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

namespace CinemaManagement_Project
{
    public partial class SelectMovieState : Form
    {
        public SelectMovieState()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void SelectMovieState_Load(object sender, EventArgs e)
        {
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
        }

        private void btn_Edit_Movie_Click(object sender, EventArgs e)
        {
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
            btn_Edit_Movie.Visible = true;

            lab_NameOfMovie1.Text = tbx_1.Text;
            lab_NameOfMovie2.Text = tbx_2.Text;
            lab_NameOfMovie3.Text = tbx_3.Text;
            lab_NameOfMovie4.Text = tbx_4.Text;
            btn_Apply.Visible = false;
            btn_Edit_Movie.Visible = false;
            tbx_1.Visible = false;
            tbx_2.Visible = false;
            tbx_3.Visible = false;
            tbx_4.Visible = false;
            btn_AddPic1.Visible = false;
            btn_AddPic2.Visible = false;
            btn_AddPic3.Visible = false;
            btn_AddPic4.Visible = false;
            lab_Title1.Visible = true;
            btn_Book1.Visible = true;
            btn_Book2.Visible = true;
            btn_Book3.Visible = true;
            btn_Book4.Visible = true;
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
            selectedTheater = comboBox1.SelectedItem as string;

            price_film1 = lab_Detail1_Money.Text.Replace(" đ", "");
            price_film2 = lab_Detail2_Money.Text.Replace(" đ", "");
            price_film3 = lab_Detail3_Money.Text.Replace(" đ", "");
            price_film4 = lab_Detail4_Money.Text.Replace(" đ", "");

            if (selectedTheater != null)
            {
                Theater1 theater1 = new Theater1();
                theater1.Show();
                this.Hide();
            }
        }
    }
}