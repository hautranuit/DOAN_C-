using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CinemaManagement_Project.SelectMovieState;
using Button = System.Windows.Forms.Button;
using CinemaManagement_Project.BuyTickets;

namespace CinemaManagement_Project
{
    public partial class Theater1 : Form
    {
        private int priceTicket;
        private double priceEconomy;
        private double priceVIP;
        public static double TongTien = 0;
        public Theater1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void A1_MouseHover(object sender, EventArgs e)
        {
            A1_Click.Visible = true;
        }

        private void A2_MouseHover(object sender, EventArgs e)
        {
            A2_Click.Visible = true;
        }

        private void A3_MouseHover(object sender, EventArgs e)
        {
            A3_Click.Visible = true;
        }

        private void A4_MouseHover(object sender, EventArgs e)
        {
            A4_Click.Visible = true;
        }

        private void A5_MouseHover(object sender, EventArgs e)
        {
            A5_Click.Visible = true;
        }

        private void B1_MouseHover(object sender, EventArgs e)
        {
            B1_Click.Visible = true;
        }

        private void B2_MouseHover(object sender, EventArgs e)
        {
            B2_Click.Visible = true;
        }

        private void B3_MouseHover(object sender, EventArgs e)
        {
            B3_Click.Visible = true;
        }

        private void B4_MouseHover(object sender, EventArgs e)
        {
            B4_Click.Visible = true;
        }

        private void B5_MouseHover(object sender, EventArgs e)
        {
            B5_Click.Visible = true;
        }

        private void C1_MouseHover(object sender, EventArgs e)
        {
            C1_Click.Visible = true;
        }

        private void C2_MouseHover(object sender, EventArgs e)
        {
            C2_Click.Visible = true;
        }

        private void C3_MouseHover(object sender, EventArgs e)
        {
            C3_Click.Visible = true;
        }

        private void C4_MouseHover(object sender, EventArgs e)
        {
            C4_Click.Visible = true;
        }

        private void C5_MouseHover(object sender, EventArgs e)
        {
            C5_Click.Visible = true;
        }

        private void A1_Click_MouseLeave(object sender, EventArgs e)
        {
            A1_Click.Visible = false;
        }

        private void A2_Click_MouseLeave(object sender, EventArgs e)
        {
            A2_Click.Visible = false;
        }

        private void A3_Click_MouseLeave(object sender, EventArgs e)
        {
            A3_Click.Visible = false;
        }

        private void A4_Click_MouseLeave(object sender, EventArgs e)
        {
            A4_Click.Visible = false;
        }

        private void A5_Click_MouseLeave(object sender, EventArgs e)
        {
            A5_Click.Visible = false;
        }

        private void B1_Click_MouseLeave(object sender, EventArgs e)
        {
            B1_Click.Visible = false;
        }

        private void B2_Click_MouseLeave(object sender, EventArgs e)
        {
            B2_Click.Visible = false;
        }

        private void B3_Click_MouseLeave(object sender, EventArgs e)
        {
            B3_Click.Visible = false;
        }

        private void B4_Click_MouseLeave(object sender, EventArgs e)
        {
            B4_Click.Visible = false;
        }

        private void B5_Click_MouseLeave(object sender, EventArgs e)
        {
            B5_Click.Visible = false;
        }

        private void C1_Click_MouseLeave(object sender, EventArgs e)
        {
            C1_Click.Visible = false;
        }

        private void C2_Click_MouseLeave(object sender, EventArgs e)
        {
            C2_Click.Visible = false;
        }

        private void C3_Click_MouseLeave(object sender, EventArgs e)
        {
            C3_Click.Visible = false;
        }

        private void C4_Click_MouseLeave(object sender, EventArgs e)
        {
            C4_Click.Visible = false;
        }

        private void C5_Click_MouseLeave(object sender, EventArgs e)
        {
            C5_Click.Visible = false;
        }

        private void Theater1_Load(object sender, EventArgs e)
        {


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            A2.Parent = pic_Background;
            A2.BackColor = Color.Transparent;

            A3.Parent = pic_Background;
            A3.BackColor = Color.Transparent;

            A4.Parent = pic_Background;
            A4.BackColor = Color.Transparent;

            C2.Parent = pic_Background;
            C2.BackColor = Color.Transparent;

            C3.Parent = pic_Background;
            C3.BackColor = Color.Transparent;

            C4.Parent = pic_Background;
            C4.BackColor = Color.Transparent;

            A1.BackColor = Color.SteelBlue;
            A5.BackColor = Color.SteelBlue;
            B1.BackColor = Color.SteelBlue;
            B5.BackColor = Color.SteelBlue;
            C1.BackColor = Color.SteelBlue;
            C5.BackColor = Color.SteelBlue;

            B2.BackColor = Color.Moccasin;
            B3.BackColor = Color.Moccasin;
            B4.BackColor = Color.Moccasin;
        }
        private void Theater1_Load_1(object sender, EventArgs e)
        {
            LoadBookedSeats();

            pic_return.Parent = pic_Background;
            pic_return.BackColor = Color.Transparent;
            standard.Parent = pic_Background;
            economy.Parent = pic_Background;
            vip.Parent = pic_Background;
            standard.BackColor = Color.Transparent;
            economy.BackColor = Color.Transparent;
            vip.BackColor = Color.Transparent;

            A2.Parent = pic_Background;
            A2.BackColor = Color.Transparent;

            A3.Parent = pic_Background;
            A3.BackColor = Color.Transparent;

            A4.Parent = pic_Background;
            A4.BackColor = Color.Transparent;

            C2.Parent = pic_Background;
            C2.BackColor = Color.Transparent;

            C3.Parent = pic_Background;
            C3.BackColor = Color.Transparent;

            C4.Parent = pic_Background;
            C4.BackColor = Color.Transparent;

            pic_Screen.Parent = pic_Background;
            pic_Screen.BackColor = Color.Transparent;
            lab_screen.Parent = pic_Background;
            lab_screen.BackColor = Color.Transparent;

            lb_PriceStandard.Parent = pic_Background;
            lb_PriceEconomy.Parent = pic_Background;
            lb_PriceVIP.Parent = pic_Background;
            lb_Theater.Parent = pic_Background;


            string selectedPrice = "";
            switch (selectedMovie)
            {
                case "1":
                    selectedPrice = price_film1;
                    break;
                case "2":
                    selectedPrice = price_film2;
                    break;
                case "3":
                    selectedPrice = price_film3;
                    break;
                case "4":
                    selectedPrice = price_film4;
                    break;
                default:
                    MessageBox.Show("Lựa chọn không hợp lệ.");
                    return;
            }

            // Chuyển đổi giá trị đã chọn thành số nguyên và tính toán giá vé
            if (int.TryParse(selectedPrice, out int price))
            {
                priceTicket = price;
                priceEconomy = priceTicket * 0.7;
                priceVIP = priceTicket * 1.3;


                lb_PriceStandard.Text = priceTicket.ToString() + " đ";
                lb_PriceEconomy.Text = priceEconomy.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên
                lb_PriceVIP.Text = priceVIP.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên

                UpdateTotalMoney(); // Cập nhật lb_total_money khi tải form
            }
            else
            {
                MessageBox.Show("Lỗi: Giá vé không hợp lệ.");
            }
            switch (selectedTheater)
            {
                case "1":
                    lb_Theater.Text = "RẠP 1";
                    break;
                case "2":
                    lb_Theater.Text = "RẠP 2";
                    break;
                case "3":
                    lb_Theater.Text = "RẠP 3";
                    break;
                default:
                    MessageBox.Show("Lựa chọn không hợp lệ.");
                    return;
            }
        }

        private void A1_Click_Click(object sender, EventArgs e)
        {
            A1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A1");
        }

        private void A2_Click_Click(object sender, EventArgs e)
        {
            A2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void A3_Click_Click(object sender, EventArgs e)
        {
            A3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void A4_Click_Click(object sender, EventArgs e)
        {
            A4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void A5_Click_Click(object sender, EventArgs e)
        {
            A5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
        }

        private void B1_Click_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
        }

        private void B2_Click_Click(object sender, EventArgs e)
        {
            B2.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
        }

        private void B3_Click_Click(object sender, EventArgs e)
        {
            B3.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
        }

        private void B4_Click_Click(object sender, EventArgs e)
        {
            B4.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
        }

        private void B5_Click_Click(object sender, EventArgs e)
        {
            B5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
        }

        private void C1_Click_Click(object sender, EventArgs e)
        {
            C1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
        }

        private void C2_Click_Click(object sender, EventArgs e)
        {
            C2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void C3_Click_Click(object sender, EventArgs e)
        {
            C3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void C4_Click_Click(object sender, EventArgs e)
        {
            C4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
        }

        private void C5_Click_Click(object sender, EventArgs e)
        {
            C5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
        }
        public static string money = null;
        private void UpdateTotalMoney()
        {
            lb_total_money.Text = TongTien.ToString("N0") + " VND"; // "N0" to display with thousand separators
            money = lb_total_money.Text;
        }
        private void SaveSeatSelection(string movieId, string theaterId, string seatId)
        {
            string filePath = "BookedSeats.txt";
            string line = $"{movieId},{theaterId},{seatId}";

            // Append the new seat booking to the file
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(line);
            }
        }
        private void LoadBookedSeats()
        {
            string[] lines = File.ReadAllLines("BookedSeats.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    int movieId = int.Parse(parts[0]);
                    int theaterId = int.Parse(parts[1]);
                    string seatId = parts[2];

                    // Chuyển đổi selectedMovie từ string sang int
                    int selectedMovieId = int.Parse(selectedMovie);
                    int selectedTheaterID = int.Parse(selectedTheater);

                    if (movieId == selectedMovieId && theaterId == selectedTheaterID)
                    {
                        PictureBox Seat = this.Controls.Find(seatId, true).FirstOrDefault() as PictureBox;

                        Seat.BackColor = Color.Maroon; // Màu đỏ cho ghế đã được đặt
                        Seat.Enabled = false;
                    }
                }
            }
        }

        private void pic_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectMovieState selectMovieState = new SelectMovieState();
            selectMovieState.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoodAndDrink FandD = new FoodAndDrink();
            this.Hide();
            FandD.Show();
        }
    }
}
