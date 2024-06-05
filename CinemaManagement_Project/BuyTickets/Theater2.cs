using System;
using System.Collections.Generic;
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

namespace CinemaManagement_Project.BuyTickets
{
    public partial class Theater2 : Form
    {
        private int priceTicket;
        private double priceEconomy;
        private double priceVIP;
        private double priceCouple;
        public static double TongTien = 0;
        public Theater2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Theater2_Load(object sender, EventArgs e)
        {
            LoadBookedSeats();

            D1.Parent = pn_Theater1;
            D2.Parent = pn_Theater1;
            D3.Parent = pn_Theater1;
            pn_Theater1.Parent = pic_Background;

            pic_return.Parent = pic_Background;
            pic_return.BackColor = Color.Transparent;
            standard.Parent = pic_Background;
            economy.Parent = pic_Background;
            vip.Parent = pic_Background;
            couple.Parent = pic_Background;

            standard.BackColor = Color.Transparent;
            economy.BackColor = Color.Transparent;
            vip.BackColor = Color.Transparent;

            A2.Parent = pn_Theater1;
            A2.BackColor = Color.Transparent;

            A3.Parent = pn_Theater1;
            A3.BackColor = Color.Transparent;

            A4.Parent = pn_Theater1;
            A4.BackColor = Color.Transparent;

            C2.Parent = pn_Theater1;
            C2.BackColor = Color.Transparent;

            C3.Parent = pn_Theater1;
            C3.BackColor = Color.Transparent;

            C4.Parent = pn_Theater1;
            C4.BackColor = Color.Transparent;

            pic_Screen.Parent = pic_Background;
            pic_Screen.BackColor = Color.Transparent;
            lab_screen.Parent = pic_Background;
            lab_screen.BackColor = Color.Transparent;

            lb_PriceCouple.Parent = pic_Background;
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
                priceCouple = priceTicket * 2.0;


                lb_PriceStandard.Text = priceTicket.ToString() + " đ";
                lb_PriceEconomy.Text = priceEconomy.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên
                lb_PriceVIP.Text = priceVIP.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên
                lb_PriceCouple.Text = priceCouple.ToString("F0") + " đ";

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

        private void button2_Click(object sender, EventArgs e)
        {
            FoodAndDrink FandD = new FoodAndDrink();
            this.Hide();
            FandD.Show();
        }

        private void pic_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectMovieState selectMovieState = new SelectMovieState("guest");
            selectMovieState.Show();
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
            SaveSeatSelection(selectedMovie, selectedTheater, "A2");
        }

        private void A3_Click_Click(object sender, EventArgs e)
        {
            A3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A3");
        }

        private void A4_Click_Click(object sender, EventArgs e)
        {
            A4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A4");
        }

        private void A5_Click_Click(object sender, EventArgs e)
        {
            A5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A5");
        }

        private void B1_Click_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B1");
        }

        private void B2_Click_Click(object sender, EventArgs e)
        {
            B2.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B2");
        }

        private void B3_Click_Click(object sender, EventArgs e)
        {
            B3.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B3");
        }

        private void B4_Click_Click(object sender, EventArgs e)
        {
            B4.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B4");
        }

        private void B5_Click_Click(object sender, EventArgs e)
        {
            B5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B5");
        }

        private void C1_Click_Click(object sender, EventArgs e)
        {
            C1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C1");
        }

        private void C2_Click_Click(object sender, EventArgs e)
        {
            C2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C2");
        }

        private void C3_Click_Click(object sender, EventArgs e)
        {
            C3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C3");
        }

        private void C4_Click_Click(object sender, EventArgs e)
        {
            C4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C4");
        }

        private void C5_Click_Click(object sender, EventArgs e)
        {
            C5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C5");
        }

        private void A1_Click_1(object sender, EventArgs e)
        {
        }

        private void A2_Click_1(object sender, EventArgs e)
        {
        }

        private void A3_Click_1(object sender, EventArgs e)
        {
        }

        private void A4_Click_1(object sender, EventArgs e)
        {
        }

        private void A5_Click_1(object sender, EventArgs e)
        {
        }

        private void B1_Click_1(object sender, EventArgs e)
        {
        }

        private void B2_Click_1(object sender, EventArgs e)
        {
        }

        private void B3_Click_1(object sender, EventArgs e)
        {
        }

        private void B4_Click_1(object sender, EventArgs e)
        {
        }

        private void B5_Click_1(object sender, EventArgs e)
        {
        }

        private void C1_Click_1(object sender, EventArgs e)
        {
        }

        private void C2_Click_1(object sender, EventArgs e)
        {

        }

        private void C3_Click_1(object sender, EventArgs e)
        {
        }

        private void C5_Click_1(object sender, EventArgs e)
        {

        }

        private void C4_Click_1(object sender, EventArgs e)
        {
        }

        private void pn_Theater1_Paint(object sender, PaintEventArgs e)
        {

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

        private void D1_MouseHover(object sender, EventArgs e)
        {
            D1_Click.Visible = true;
        }

        private void D2_MouseHover(object sender, EventArgs e)
        {
            D2_Click.Visible = true;
        }

        private void D3_MouseHover(object sender, EventArgs e)
        {
            D3_Click.Visible = true;
        }

        private void A1_Click_MouseLeave(object sender, EventArgs e)
        {
            A1_Click.Visible = false;
        }

        private void A2_Click_MouseLeave(object sender, EventArgs e)
        {
            A2_Click.Visible = false;
        }

        private void A4_Click_MouseLeave(object sender, EventArgs e)
        {
            A4_Click.Visible = false;
        }

        private void A3_Click_MouseLeave(object sender, EventArgs e)
        {
            A3_Click.Visible = false;
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

        private void D1_Click_MouseLeave(object sender, EventArgs e)
        {
            D1_Click.Visible = false;
        }

        private void D2_Click_MouseLeave(object sender, EventArgs e)
        {
            D2_Click.Visible = false;
        }

        private void D3_Click_MouseLeave(object sender, EventArgs e)
        {
            D3_Click.Visible = false;
        }

        private void D1_Click_Click(object sender, EventArgs e)
        {
            D1.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D1");
        }

        private void D2_Click_Click(object sender, EventArgs e)
        {
            D2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D2");
        }

        private void D3_Click_Click(object sender, EventArgs e)
        {
            D3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D3");
        }
    }
}
