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

namespace LAB1_22520412
{
    public partial class Lab01_Bai5_P2_ : Form
    {
        int ticketPrice;
        string Name;
        string theater;
        public Lab01_Bai5_P2_(int price, string NameOfMovie, string number_theater)
        {
            InitializeComponent();
            ticketPrice = price;
            Name = NameOfMovie;
            theater = number_theater;   
        }

        private void Lab01_Bai5_P2__Load(object sender, EventArgs e)
        {
            label22.Text = Name;
            label19.Text = theater;
            standard.Parent = background;
            economy.Parent = background;
            vip.Parent = background;
            pictureBox1.Parent = background;
            pictureBox1.BackColor = Color.Transparent;  

            A2.Parent = background;
            A2.BackColor = Color.Transparent;

            A3.Parent = background;
            A3.BackColor = Color.Transparent;

            A4.Parent = background;
            A4.BackColor = Color.Transparent;

            C2.Parent = background;
            C2.BackColor = Color.Transparent;

            C3.Parent = background;
            C3.BackColor = Color.Transparent;

            C4.Parent = background;
            C4.BackColor = Color.Transparent;

            screen_label.Parent = background;
            screen_label.BackColor = Color.Transparent;
        }

        private void A1_MouseHover(object sender, EventArgs e)
        {
            A1_Click.Visible = true;
        }

        private void A1_Click_MouseLeave(object sender, EventArgs e)
        {
            A1_Click.Visible = false;
        }

        private void A2_MouseHover(object sender, EventArgs e)
        {
            A2_Click.Visible = true;
        }

        private void A2_Click_MouseLeave(object sender, EventArgs e)
        {
            A2_Click.Visible = false;
        }

        private void A3_MouseHover(object sender, EventArgs e)
        {
            A3_Click.Visible = true;
        }

        private void A3_Click_MouseLeave(object sender, EventArgs e)
        {
            A3_Click.Visible = false;
        }

        private void A4_MouseHover(object sender, EventArgs e)
        {
            A4_Click.Visible = true;
        }

        private void A4_Click_MouseLeave(object sender, EventArgs e)
        {
            A4_Click.Visible = false;
        }

        private void A5_MouseHover(object sender, EventArgs e)
        {
            A5_Click.Visible = true;
        }

        private void A5_Click_Click(object sender, EventArgs e)
        {
            A5.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();
        }

        private void A5_Click_MouseLeave(object sender, EventArgs e)
        {
            A5_Click.Visible = false;
        }

        private void B1_MouseHover(object sender, EventArgs e)
        {
            B1_Click.Visible = true;
        }

        private void B1_Click_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();
        }
        private void B1_Click_MouseLeave(object sender, EventArgs e)
        {
            B1_Click.Visible = false;
        }

        private void B2_MouseHover(object sender, EventArgs e)
        {
            B2_Click.Visible = true;
        }

        private void B2_Click_MouseLeave(object sender, EventArgs e)
        {
            B2_Click.Visible = false;
        }

        private void B3_MouseHover(object sender, EventArgs e)
        {
            B3_Click.Visible = true;
        }

        private void B3_Click_MouseLeave(object sender, EventArgs e)
        {
            B3_Click.Visible = false;
        }

        private void B4_MouseHover(object sender, EventArgs e)
        {
            B4_Click.Visible = true;
        }

        private void B4_Click_MouseLeave(object sender, EventArgs e)
        {
            B4_Click.Visible = false;
        }

        private void B5_MouseHover(object sender, EventArgs e)
        {
            B5_Click.Visible = true;
        }

        private void B5_Click_MouseLeave(object sender, EventArgs e)
        {
            B5_Click.Visible = false;
        }

        private void C1_MouseHover(object sender, EventArgs e)
        {
            C1_Click.Visible = true;
        }

        private void C1_Click_MouseLeave(object sender, EventArgs e)
        {
            C1_Click.Visible = false;
        }

        private void C2_MouseHover(object sender, EventArgs e)
        {
            C2_Click.Visible = true;
        }

        private void C2_Click_MouseLeave(object sender, EventArgs e)
        {
            C2_Click.Visible = false;
        }

        private void C3_MouseHover(object sender, EventArgs e)
        {
            C3_Click.Visible = true;
        }

        private void C3_Click_MouseLeave(object sender, EventArgs e)
        {
            C3_Click.Visible = false;
        }

        private void C4_MouseHover(object sender, EventArgs e)
        {
            C4_Click.Visible = true;
        }

        private void C4_Click_MouseLeave(object sender, EventArgs e)
        {
            C4_Click.Visible = false;
        }

        private void C5_MouseHover(object sender, EventArgs e)
        {
            C5_Click.Visible = true;
        }

        private void C5_Click_MouseLeave(object sender, EventArgs e)
        {
            C5_Click.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            datebutton.Visible = true;
            datebutton.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void datebutton_Click(object sender, EventArgs e)
        {
            datebutton.Visible = false;
            monthCalendar1.Visible = true;
        }
        double total_price = 0;
        private void A1_Click_Click(object sender, EventArgs e)
        {
            A1.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();        
        }

        private void A2_Click_Click(object sender, EventArgs e)
        {
            A2.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void A3_Click_Click(object sender, EventArgs e)
        {
            A3.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void A4_Click_Click(object sender, EventArgs e)
        {
            A4.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void B2_Click_Click(object sender, EventArgs e)
        {
            B2.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 2;
            total_money.Text = total_price.ToString();
        }

        private void B3_Click_Click(object sender, EventArgs e)
        {
            B3.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 2;
            total_money.Text = total_price.ToString();
        }

        private void B4_Click_Click(object sender, EventArgs e)
        {
            B4.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 2;
            total_money.Text = total_price.ToString();
        }

        private void B5_Click_Click(object sender, EventArgs e)
        {
            B5.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();
        }

        private void C1_Click_Click(object sender, EventArgs e)
        {
            C1.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();
        }

        private void C2_Click_Click(object sender, EventArgs e)
        {
            C2.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void C3_Click_Click(object sender, EventArgs e)
        {
            C3.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void C4_Click_Click(object sender, EventArgs e)
        {
            C4.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice;
            total_money.Text = total_price.ToString();
        }

        private void C5_Click_Click(object sender, EventArgs e)
        {
            C5.BackColor = Color.Maroon;
            total_price = total_price + ticketPrice * 0.25;
            total_money.Text = total_price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            textBox1.Text = textBox5.Text;
            textBox2.Text = datebutton.Text;
            textBox6.Text = textBox3.Text;
            textBox7.Text = textBox4.Text;
            label21.Text = total_money.Text;
            label18.Text = label22.Text;

            //Tao mot danh sach de luu tru cac ghe da chon 
            List<string> selectedSeats = new List<string>();

            //Nhung ghe nao co back color là color.Maroon la nhung ghe da duoc chon
            if (A1.BackColor == Color.Maroon)
                selectedSeats.Add("A1");
            if (A2.BackColor == Color.Maroon)
                selectedSeats.Add("A2");
            if (A3.BackColor == Color.Maroon)
                selectedSeats.Add("A3");
            if (A4.BackColor == Color.Maroon)
                selectedSeats.Add("A4");
            if (A5.BackColor == Color.Maroon)
                selectedSeats.Add("A5");
            if (B1.BackColor == Color.Maroon)
                selectedSeats.Add("B1");
            if (B2.BackColor == Color.Maroon)
                selectedSeats.Add("B2");
            if (B3.BackColor == Color.Maroon)
                selectedSeats.Add("B3");
            if (B4.BackColor == Color.Maroon)
                selectedSeats.Add("B4");
            if (B5.BackColor == Color.Maroon)
                selectedSeats.Add("B5");
            if (C1.BackColor == Color.Maroon)
                selectedSeats.Add("C1");
            if (C2.BackColor == Color.Maroon)
                selectedSeats.Add("C2");
            if (C3.BackColor == Color.Maroon)
                selectedSeats.Add("C3");
            if (C4.BackColor == Color.Maroon)
                selectedSeats.Add("C4");
            if (C5.BackColor == Color.Maroon)
                selectedSeats.Add("C5");

            label20.Text = string.Join(", ", selectedSeats);
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //dat lai mau nen cho cac ghe ve ban dau
            A2.Parent = background;
            A2.BackColor = Color.Transparent;

            A3.Parent = background;
            A3.BackColor = Color.Transparent;

            A4.Parent = background;
            A4.BackColor = Color.Transparent;

            C2.Parent = background;
            C2.BackColor = Color.Transparent;

            C3.Parent = background;
            C3.BackColor = Color.Transparent;

            C4.Parent = background;
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

            total_price = 0;
            total_money.Text = total_price.ToString();
        }
    }
}
