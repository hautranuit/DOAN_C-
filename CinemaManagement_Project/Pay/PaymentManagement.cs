using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CinemaManagement_Project.Pay
{
    public partial class PaymentManagement : Form
    {

        // Dictionary to store combo quantities
        private Dictionary<string, Tuple<int, int>> comboQuantities = new Dictionary<string, Tuple<int, int>>();

        private Chart chart1;
        public PaymentManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeChart();
            LoadTicketData();
            btn_Theater_Click(null, null); // Load voucher chart by default
        }
        private void InitializeChart()
        {
            chart1 = new Chart();
            chart1.Size = new Size(350, 350); // Set the size of the chart
            chart1.Location = new Point(500, 450); // Position it to the top-right corner with some padding
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Ensure it stays in place when the form resizes

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            this.Controls.Add(chart1);
        }
        private void LoadTicketData()
        {
            // Dictionary to store the count of tickets sold for each cinema
            Dictionary<int, int> ticketsSold = new Dictionary<int, int>();
            // Dictionary to store the total tickets and revenue for each cinema
            Dictionary<int, int> totalTickets = new Dictionary<int, int>();
            Dictionary<int, decimal> cinemaRevenue = new Dictionary<int, decimal>();

            // Read the BookedSeats.txt file
            string[] bookedSeatsLines = File.ReadAllLines("BookedSeats.txt");
            foreach (string line in bookedSeatsLines)
            {
                // Split the line by comma
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    // Get the cinema number
                    int cinemaNumber = int.Parse(parts[1]);

                    // Update the count for the cinema
                    if (ticketsSold.ContainsKey(cinemaNumber))
                    {
                        ticketsSold[cinemaNumber]++;
                    }
                    else
                    {
                        ticketsSold[cinemaNumber] = 1;
                    }
                }
            }

            // Read the DoanhThu.txt file
            string[] doanhThuLines = File.ReadAllLines("DoanhThu.txt");
            foreach (string line in doanhThuLines)
            {
                // Split the line by comma
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    // Get the cinema number, total tickets, and total revenue
                    int cinemaNumber = int.Parse(parts[0].Trim());
                    int totalTicketsCount = int.Parse(parts[1].Trim());
                    decimal revenue = decimal.Parse(parts[2].Trim());

                    totalTickets[cinemaNumber] = totalTicketsCount;
                    cinemaRevenue[cinemaNumber] = revenue;
                }
            }

            // Clear the existing items in listView1
            listView1.Items.Clear();

            // Add items to listView1 for each cinema
            foreach (var kvp in totalTickets)
            {
                int cinemaNumber = kvp.Key;
                string cinemaName = $"Vé Rạp {cinemaNumber}";
                int totalTicketsCount = kvp.Value;
                int ticketsSoldCount = ticketsSold.ContainsKey(cinemaNumber) ? ticketsSold[cinemaNumber] : 0;
                int remainingTickets = totalTicketsCount - ticketsSoldCount;
                string unitPrice = "Tùy vào ghế";
                decimal totalRevenue = cinemaRevenue.ContainsKey(cinemaNumber) ? cinemaRevenue[cinemaNumber] : 0;

                ListViewItem item = new ListViewItem(cinemaName);
                item.SubItems.Add(remainingTickets.ToString()); // Số lượng còn lại
                item.SubItems.Add(ticketsSoldCount.ToString()); // Số lượng đã bán
                item.SubItems.Add(unitPrice); // Đơn giá
                item.SubItems.Add(totalRevenue.ToString("N0") + " VND"); // Tổng doanh thu

                listView1.Items.Add(item);
            }

            // Load combo quantities from FoodAndDrink.txt
            LoadComboQuantitiesFromFile();

            // Load voucher data from Vouchers.txt
            LoadVoucherData();

        }


        private void LoadComboQuantitiesFromFile()
        {
            string filePath = "FoodAndDrink.txt";
            if (File.Exists(filePath))
            {
                string[] comboLines = File.ReadAllLines(filePath);
                foreach (string line in comboLines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string comboName = parts[0].Trim();
                        string[] quantities = parts[1].Split(',');
                        if (quantities.Length == 2)
                        {
                            int soldCount = int.Parse(quantities[0].Trim());
                            int remainingCount = int.Parse(quantities[1].Trim());
                            comboQuantities[comboName] = new Tuple<int, int>(soldCount, remainingCount);

                            AddPlaceholderItem(comboName, remainingCount, GetComboPrice(comboName));
                        }
                    }
                }
            }
        }

        private string GetComboPrice(string comboName)
        {
            switch (comboName)
            {
                case "COMBO SOLO - VOL 2":
                    return "79,000 VND";
                case "COMBO COUPLE - VOL 2":
                    return "109,000 VND";
                case "COMBO PARTY - VOL 2":
                    return "209,000 VND";
                case "COMBO SOLO 2 NGĂN":
                    return "99,000 VND";
                case "COMBO COUPLE 2 NGĂN":
                    return "239,000 VND";
                case "COMBO PARTY 2 NGĂN":
                    return "109,000 VND";
                default:
                    return "N/A";
            }
        }

        private void AddPlaceholderItem(string itemName, int initialCount, string price)
        {
            int soldCount = comboQuantities.ContainsKey(itemName) ? comboQuantities[itemName].Item1 : 0;
            decimal unitPrice = ParsePrice(price);
            decimal totalRevenue = soldCount * unitPrice;

            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add(initialCount.ToString()); // Số lượng còn lại
            item.SubItems.Add(soldCount.ToString()); // Số lượng đã bán
            item.SubItems.Add(price); // Đơn giá
            item.SubItems.Add(totalRevenue == 0 ? "N/A" : totalRevenue.ToString("N0") + " VND"); // Tổng doanh thu

            listView1.Items.Add(item);
        }

        private decimal ParsePrice(string price)
        {
            if (price == "N/A" || price == "Tùy vào ghế")
            {
                return 0;
            }

            string cleanedPrice = price.Replace("VND", "").Replace(",", "").Trim();
            return decimal.TryParse(cleanedPrice, out decimal result) ? result : 0;
        }

        private void LoadVoucherData()
        {
            string vouchersFilePath = "Vouchers.txt";
            if (File.Exists(vouchersFilePath))
            {
                string[] voucherLines = File.ReadAllLines(vouchersFilePath);
                foreach (string line in voucherLines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string voucherName = parts[0].Trim();
                        int soldCount = int.Parse(parts[1].Trim());
                        int remainingCount = int.Parse(parts[2].Trim());

                        string price = GetVoucherPrice(voucherName);
                        AddVoucherItem(voucherName, remainingCount, soldCount, price);
                    }
                }
            }
        }

        private string GetVoucherPrice(string voucherName)
        {
            switch (voucherName)
            {
                case "Giảm 20% bắp nước - CINEKING":
                    return "Giảm 20% bắp nước"; // Adjust price accordingly
                case "C'Ten: 45k phim 2D":
                    return "Đồng giá 45,000 VND";
                case "C'Member: 45k phim 2D":
                    return "Đồng giá 45,000 VND";
                default:
                    return "N/A";
            }
        }

        private void AddVoucherItem(string itemName, int remainingCount, int soldCount, string price)
        {
            decimal unitPrice = ParsePrice(price);
            decimal totalRevenue = soldCount * unitPrice;

            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add(remainingCount.ToString()); // Số lượng còn lại
            item.SubItems.Add(soldCount.ToString()); // Số lượng đã bán
            item.SubItems.Add(price); // Đơn giá
            item.SubItems.Add(totalRevenue == 0 ? "N/A" : totalRevenue.ToString("N0") + " VND"); // Tổng doanh thu

            listView1.Items.Add(item);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SignIn_SignUp.Select select = new SignIn_SignUp.Select();
            this.Close();
            select.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FormUpdateTicketsAndVouchers form = new FormUpdateTicketsAndVouchers();
            this.Close();
            form.Show();
        }
        private void UpdateChart(SeriesChartType chartType, Dictionary<string, decimal> data, string title, bool isRevenueChart = false)
        {
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "Data",
                ChartType = chartType
            };

            decimal totalValue = data.Values.Sum();

            foreach (var kvp in data)
            {
                if (kvp.Value > 0) // Chỉ thêm mục có giá trị lớn hơn 0
                {
                    double percentage = (double)kvp.Value / (double)totalValue * 100;
                    DataPoint point = new DataPoint
                    {
                        AxisLabel = kvp.Key,
                        YValues = new double[] { (double)kvp.Value },
                        Label = isRevenueChart ? $"{kvp.Key}: {kvp.Value:N0} VND ({percentage:F1}%)" : $"{kvp.Key}: {kvp.Value} ({percentage:F1}%)"
                    };
                    series.Points.Add(point);
                }
            }

            chart1.Series.Add(series);

            // Đặt tiêu đề biểu đồ
            chart1.Titles.Clear();
            Title chartTitle = new Title
            {
                Text = title,
                Font = new Font("Segoe UI Semibold", 10.8f, FontStyle.Bold),
                ForeColor = Color.White
            };
            chart1.Titles.Add(chartTitle);

            // Đặt màu nền cho biểu đồ
            chart1.BackColor = Color.Indigo;
            chart1.ChartAreas[0].BackColor = Color.Indigo;

            // Đặt màu nền cho khu vực vẽ
            chart1.ChartAreas[0].BackColor = Color.Indigo;

            // Đặt nhãn dữ liệu
            series.IsValueShownAsLabel = true;

            chart1.Invalidate();
        }



        private void btn_Theater_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> ticketData = new Dictionary<string, int>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.StartsWith("Vé Rạp"))
                {
                    string name = item.Text;
                    int soldCount = int.Parse(item.SubItems[2].Text);
                    if (soldCount > 0) // Chỉ thêm mục có giá trị lớn hơn 0
                    {
                        ticketData[name] = soldCount;
                    }
                }
            }

            UpdateChart(SeriesChartType.Pie, ticketData.ToDictionary(x => x.Key, x => (decimal)x.Value), "Biểu đồ biểu thị số vé đã bán theo từng rạp");
        }

        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> voucherData = new Dictionary<string, int>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.StartsWith("Giảm") || item.Text.StartsWith("C'"))
                {
                    string name = item.Text;
                    int usedCount = int.Parse(item.SubItems[2].Text);
                    if (usedCount > 0) // Chỉ thêm mục có giá trị lớn hơn 0
                    {
                        voucherData[name] = usedCount;
                    }
                }
            }

            UpdateChart(SeriesChartType.Pie, voucherData.ToDictionary(x => x.Key, x => (decimal)x.Value), "Biểu đồ biểu thị số Voucher đã dùng theo từng loại");
        }

        private void btn_Combo_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> comboData = new Dictionary<string, int>();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.StartsWith("COMBO"))
                {
                    string name = item.Text;
                    int soldCount = int.Parse(item.SubItems[2].Text);
                    if (soldCount > 0) // Chỉ thêm mục có giá trị lớn hơn 0
                    {
                        comboData[name] = soldCount;
                    }
                }
            }

            UpdateChart(SeriesChartType.Pie, comboData.ToDictionary(x => x.Key, x => (decimal)x.Value), "Biểu đồ biểu thị số Combo đã bán theo từng loại");
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            decimal totalTicketRevenue = 0;
            decimal totalComboRevenue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.StartsWith("Vé Rạp"))
                {
                    string revenueText = item.SubItems[4].Text;
                    decimal revenue = ParsePrice(revenueText);
                    totalTicketRevenue += revenue;
                }
                else if (item.Text.StartsWith("COMBO"))
                {
                    string revenueText = item.SubItems[4].Text;
                    decimal revenue = ParsePrice(revenueText);
                    totalComboRevenue += revenue;
                }
            }

            Dictionary<string, decimal> revenueData = new Dictionary<string, decimal>
    {
        { "Doanh thu từ bán vé", totalTicketRevenue },
        { "Doanh thu từ bán combo", totalComboRevenue }
    };

            UpdateChart(SeriesChartType.Pie, revenueData, "Biểu đồ biểu thị doanh thu từ việc bán vé và combo", true);
        }
    }
}
