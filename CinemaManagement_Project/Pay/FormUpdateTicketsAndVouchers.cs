using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement_Project.Pay
{
    public partial class FormUpdateTicketsAndVouchers : Form
    {
        public FormUpdateTicketsAndVouchers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeTextBoxValues();
        }
        private void UpdateTicketQuantity(int theaterNumber, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity))
            {
                string[] lines = File.ReadAllLines("DoanhThu.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && int.TryParse(parts[0].Trim(), out int theater) && theater == theaterNumber)
                    {
                        parts[1] = quantity.ToString(); // Cập nhật số vé còn lại
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines("DoanhThu.txt", lines);
            }
        }
        private void InitializeTextBoxValues()
        {
            // Đọc giá trị từ file DoanhThu.txt và đặt giá trị vào các TextBoxes
            string[] doanhThuLines = File.ReadAllLines("DoanhThu.txt");
            foreach (string line in doanhThuLines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    int theaterNumber = int.Parse(parts[0].Trim());
                    int totalTickets = int.Parse(parts[1].Trim());

                    switch (theaterNumber)
                    {
                        case 1:
                            tbx_TicketTheater1.Text = totalTickets.ToString();
                            break;
                        case 2:
                            tbx_TicketTheater2.Text = totalTickets.ToString();
                            break;
                        case 3:
                            tbx_TicketTheater3.Text = totalTickets.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
            // Đọc giá trị từ các file và đặt giá trị vào TextBoxes
            string[] voucherLines = File.ReadAllLines("Vouchers.txt");
            foreach (string line in voucherLines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string voucherName = parts[0].Trim();
                    int remainingCount = int.Parse(parts[2].Trim());

                    switch (voucherName)
                    {
                        case "Giảm 20% bắp nước - CINEKING":
                            tbx_Vouchers1.Text = remainingCount.ToString();
                            break;
                        case "C'Ten: 45k phim 2D":
                            tbx_Vouchers2.Text = remainingCount.ToString();
                            break;
                        case "C'Member: 45k phim 2D":
                            tbx_Vouchers3.Text = remainingCount.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }

            string[] comboLines = File.ReadAllLines("FoodAndDrink.txt");
            foreach (string line in comboLines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string comboName = parts[0].Trim();
                    string[] quantities = parts[1].Split(',');
                    if (quantities.Length == 2)
                    {
                        int remainingCount = int.Parse(quantities[1].Trim());

                        switch (comboName)
                        {
                            case "COMBO SOLO - VOL 2":
                                tbx_Combo1.Text = remainingCount.ToString();
                                break;
                            case "COMBO COUPLE - VOL 2":
                                tbx_Combo2.Text = remainingCount.ToString();
                                break;
                            case "COMBO PARTY - VOL 2":
                                tbx_Combo3.Text = remainingCount.ToString();
                                break;
                            case "COMBO SOLO 2 NGĂN":
                                tbx_Combo4.Text = remainingCount.ToString();
                                break;
                            case "COMBO COUPLE 2 NGĂN":
                                tbx_Combo5.Text = remainingCount.ToString();
                                break;
                            case "COMBO PARTY 2 NGĂN":
                                tbx_Combo6.Text = remainingCount.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Cập nhật số vé còn lại
            UpdateTicketQuantity(1, tbx_TicketTheater1.Text);
            UpdateTicketQuantity(2, tbx_TicketTheater2.Text);
            UpdateTicketQuantity(3, tbx_TicketTheater3.Text);

            // Cập nhật số voucher còn lại
            UpdateVoucherQuantity("Giảm 20% bắp nước - CINEKING", tbx_Vouchers1.Text);
            UpdateVoucherQuantity("C'Ten: 45k phim 2D", tbx_Vouchers2.Text);
            UpdateVoucherQuantity("C'Member: 45k phim 2D", tbx_Vouchers3.Text);

            // Cập nhật số lượng còn lại của các combo
            UpdateComboQuantity("COMBO SOLO - VOL 2", tbx_Combo1.Text);
            UpdateComboQuantity("COMBO COUPLE - VOL 2", tbx_Combo2.Text);
            UpdateComboQuantity("COMBO PARTY - VOL 2", tbx_Combo3.Text);
            UpdateComboQuantity("COMBO SOLO 2 NGĂN", tbx_Combo4.Text);
            UpdateComboQuantity("COMBO PARTY 2 NGĂN", tbx_Combo5.Text);
            UpdateComboQuantity("COMBO COUPLE 2 NGĂN", tbx_Combo6.Text);

            MessageBox.Show("Cập nhật thành công!");
            PaymentManagement manager = new PaymentManagement();
            this.Close();
            manager.Show();
        }

        private void UpdateVoucherQuantity(string voucherName, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity))
            {
                string[] lines = File.ReadAllLines("Vouchers.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 3 && parts[0].Trim() == voucherName)
                    {
                        parts[2] = quantity.ToString();
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines("Vouchers.txt", lines);
            }
        }

        private void UpdateComboQuantity(string comboName, string quantityText)
        {
            if (int.TryParse(quantityText, out int quantity))
            {
                string[] lines = File.ReadAllLines("FoodAndDrink.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    if (parts.Length == 2 && parts[0].Trim() == comboName)
                    {
                        string[] quantities = parts[1].Split(',');
                        if (quantities.Length == 2)
                        {
                            quantities[1] = quantity.ToString();
                            parts[1] = string.Join(",", quantities);
                            lines[i] = string.Join(":", parts);
                        }
                        break;
                    }
                }
                File.WriteAllLines("FoodAndDrink.txt", lines);
            }
        }
    }
}
