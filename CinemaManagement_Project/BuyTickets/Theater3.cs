using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement_Project.BuyTickets;
using static CinemaManagement_Project.SelectMovieState;

namespace CinemaManagement_Project.BuyTickets
{
    public partial class Theater3 : Form
    {
        private int priceTicket;
        private double priceEconomy;
        private double priceVIP;
        private double priceBed;
        public static double TongTien;
        private int count;
        public Theater3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Theater3_Load(object sender, EventArgs e)
        {

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

        private void pic_return_Click(object sender, EventArgs e)
        {

            this.Hide();
            SelectMovieState selectMovieState = new SelectMovieState("guest");
            selectMovieState.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            List<PictureBox> bookedSeats = new List<PictureBox>
            {
                A1, A2, A3, A4, A5,
                B1, B2, B3, B4, B5,
                C1, C2, C3, C4, C5,
                D1, D2, D3
            };

            // Duyệt qua các ghế và khôi phục trạng thái ban đầu cho các ghế có tag "booked"
            foreach (var seat in bookedSeats)
            {
                if (seat.Tag != null && seat.Tag.ToString() == "booked")
                {
                    // Đặt màu sắc ban đầu cho từng ghế
                    if (seat == A1 || seat == A5 || seat == B1 || seat == B5 || seat == C1 || seat == C5)
                    {
                        seat.BackColor = Color.SteelBlue;
                    }
                    else if (seat == B2 || seat == B3 || seat == B4)
                    {
                        seat.BackColor = Color.Moccasin;
                    }
                    else
                    {
                        seat.BackColor = Color.Transparent;
                    }

                    seat.Tag = null; // Xóa tag
                    seat.Enabled = true;

                    // Xóa dòng tương ứng trong file BookedSeats.txt
                    RemoveSeatFromFile(selectedMovie, selectedTheater, seat.Name);
                }
            }

            // Cập nhật lại tổng tiền
            count = 0;
            TongTien = 0;
            UpdateTotalMoney();
        }
        private void RemoveSeatFromFile(string movieId, string theaterId, string seatId)
        {
            string filePath = "BookedSeats.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string lineMovieId = parts[0];
                    string lineTheaterId = parts[1];
                    string lineSeatId = parts[2];

                    if (lineMovieId == movieId && lineTheaterId == theaterId && lineSeatId == seatId)
                    {
                        // Không thêm dòng này vào danh sách updatedLines (nghĩa là xóa dòng này)
                        continue;
                    }
                    else
                    {
                        updatedLines.Add(line);
                    }
                }
            }

            File.WriteAllLines(filePath, updatedLines);
        }
        public static string TypeOfSeat;
        public static string NumSeat;
        private void button2_Click(object sender, EventArgs e)
        {
            // Initialize a list to keep track of the seat types
            List<string> seatTypes = new List<string>();
            List<string> bookedSeats = new List<string>();

            // List of seats to check
            List<PictureBox> seats = new List<PictureBox> {
            A1, A2, A3, A4, A5,
            B1, B2, B3, B4, B5,
            C1, C2, C3, C4, C5,
            D1, D2, D3
            };

            // Iterate through the seats to check if they are booked and determine their type
            foreach (var seat in seats)
            {
                if (seat.Tag != null && seat.Tag.ToString() == "booked")
                {
                    bookedSeats.Add(seat.Name);
                    if (seat == A1 || seat == A5 || seat == B1 || seat == B5 || seat == C1 || seat == C5)
                    {
                        if (!seatTypes.Contains("Economy"))
                        {
                            seatTypes.Add("Economy");
                        }
                    }
                    else if (seat == B2 || seat == B3 || seat == B4)
                    {
                        if (!seatTypes.Contains("VIP"))
                        {
                            seatTypes.Add("VIP");
                        }
                    }
                    else if (seat == D1 || seat == D2 || seat == D3)
                    {
                        if (!seatTypes.Contains("Couple"))
                        {
                            seatTypes.Add("Bed");
                        }
                    }
                    else
                    {
                        if (!seatTypes.Contains("Standard"))
                        {
                            seatTypes.Add("Standard");
                        }
                    }
                }
            }

            // Join the seat types into a single string separated by commas
            TypeOfSeat = string.Join(", ", seatTypes);
            NumSeat = string.Join(", ", bookedSeats);
            FoodAndDrink FandD = new FoodAndDrink(money, count);
            this.Hide();
            FandD.Show();
        }

        private void A1_Click_Click(object sender, EventArgs e)
        {
            A1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A1");
            count++;
            A1.Tag = "booked";
        }

        private void A2_Click_Click(object sender, EventArgs e)
        {
            A2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A2");
            count++;
            A2.Tag = "booked";
        }

        private void A3_Click_Click(object sender, EventArgs e)
        {
            A3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A3");
            count++;
            A3.Tag = "booked";
        }

        private void A4_Click_Click(object sender, EventArgs e)
        {
            A4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A4");
            count++;
            A4.Tag = "booked";
        }

        private void A5_Click_Click(object sender, EventArgs e)
        {
            A5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "A5");
            count++;
            A5.Tag = "booked";
        }

        private void B1_Click_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B1");
            count++;
            B1.Tag = "booked";
        }

        private void B2_Click_Click(object sender, EventArgs e)
        {
            B2.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B2");
            count++;
            B2.Tag = "booked";
        }

        private void B3_Click_Click(object sender, EventArgs e)
        {
            B3.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B3");
            count++;
            B3.Tag = "booked";
        }

        private void B4_Click_Click(object sender, EventArgs e)
        {
            B4.BackColor = Color.Maroon;
            TongTien += priceVIP;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B4");
            count++;
            B4.Tag = "booked";
        }

        private void B5_Click_Click(object sender, EventArgs e)
        {
            B5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "B5");
            count++;
            B5.Tag = "booked";
        }

        private void C1_Click_Click(object sender, EventArgs e)
        {
            C1.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C1");
            count++;
            C1.Tag = "booked";
        }

        private void C2_Click_Click(object sender, EventArgs e)
        {
            C2.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C2");
            count++;
            C2.Tag = "booked";
        }

        private void C3_Click_Click(object sender, EventArgs e)
        {
            C3.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C3");
            count++;
            C3.Tag = "booked";
        }

        private void C4_Click_Click(object sender, EventArgs e)
        {
            C4.BackColor = Color.Maroon;
            TongTien += priceTicket;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C4");
            count++;
            C4.Tag = "booked";
        }

        private void C5_Click_Click(object sender, EventArgs e)
        {
            C5.BackColor = Color.Maroon;
            TongTien += priceEconomy;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "C5");
            count++;
            C5.Tag = "booked";
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

        private void Theater3_Load_1(object sender, EventArgs e)
        {

        }

        private void Theater3_Load_2(object sender, EventArgs e)
        {
            LoadBookedSeats();

            count = 0;
            TongTien = 0;
            lb_total_money.Text = "";

            D1.Parent = pn_Theater1;
            D2.Parent = pn_Theater1;
            D3.Parent = pn_Theater1;
            pn_Theater1.Parent = pic_Background;
            pn_Theater1.BackColor = Color.Transparent;

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

            A3.Parent = pn_Theater1;

            A4.Parent = pn_Theater1;

            C2.Parent = pn_Theater1;

            C3.Parent = pn_Theater1;

            C4.Parent = pn_Theater1;


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
                priceBed = priceTicket * 2.25;


                lb_PriceStandard.Text = priceTicket.ToString() + " đ";
                lb_PriceEconomy.Text = priceEconomy.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên
                lb_PriceVIP.Text = priceVIP.ToString("F0") + " đ";  // "F0" để làm tròn xuống số nguyên
                lb_PriceCouple.Text = priceBed.ToString("F0") + " đ";

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

        private void D1_Click_Click(object sender, EventArgs e)
        {
            D1.BackColor = Color.Maroon;
            TongTien += priceBed;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D1");
            count++;
            D1.Tag = "booked";
        }

        private void D2_Click_Click(object sender, EventArgs e)
        {
            D2.BackColor = Color.Maroon;
            TongTien += priceBed;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D2");
            count++;
            D2.Tag = "booked";
        }

        private void D3_Click_Click(object sender, EventArgs e)
        {

            D3.BackColor = Color.Maroon;
            TongTien += priceBed;
            UpdateTotalMoney();
            SaveSeatSelection(selectedMovie, selectedTheater, "D3");
            count++;
            D3.Tag = "booked";
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
    }
}
