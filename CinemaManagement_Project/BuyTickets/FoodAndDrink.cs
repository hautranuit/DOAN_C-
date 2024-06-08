using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CinemaManagement_Project.SelectMovieState;

namespace CinemaManagement_Project.BuyTickets
{
    public partial class FoodAndDrink : Form
    {
        private decimal Total_FoodAndDrink_Money = 0m;
        private decimal initialMoney = 0m; // Store initial money from Theater1
        public static int countTickets = 0;
        public FoodAndDrink(string money, int count)
        {
            countTickets = count;
            InitializeComponent();
            if (money != null)
            {
                lb_totalMoney.Text = money;

                // Parse the initial money from Theater1
                initialMoney = ParsePrice(money);
            }
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeDomainUpDownControls();
            AttachEventHandlers();
        }
        private void InitializeDomainUpDownControls()
        {
            // Setting properties for DomainUpDown controls
            ConfigureDomainUpDown(dUD_ComboSolo);
            ConfigureDomainUpDown(dUD_ComboCouple);
            ConfigureDomainUpDown(dUD_ComboParty);
            ConfigureDomainUpDown(dUD_ComboSolo_2ngan);
            ConfigureDomainUpDown(dUD_ComboParty_2ngan);
            ConfigureDomainUpDown(dUD_ComboCouple_2ngan);
        }

        private void ConfigureDomainUpDown(DomainUpDown domainUpDown)
        {
            domainUpDown.Items.Clear();
            for (int i = 10; i >= 0; i--) // Điều chỉnh phạm vi theo nhu cầu
            {
                domainUpDown.Items.Add(i);
            }
            domainUpDown.SelectedIndex = 10;
            domainUpDown.Wrap = true;
            domainUpDown.KeyDown += DomainUpDown_KeyDown; // Gắn sự kiện KeyDown
        }
        private void DomainUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            DomainUpDown domainUpDown = sender as DomainUpDown;
            if (domainUpDown != null)
            {
                int currentValue = Convert.ToInt32(domainUpDown.SelectedItem);
                if ((e.KeyCode == Keys.Up && currentValue == 10) || (e.KeyCode == Keys.Down && currentValue == 0))
                {
                    e.SuppressKeyPress = true; // Ngăn chặn hành động khi giá trị đạt giới hạn
                }
            }
        }
        private void AttachEventHandlers()
        {
            // Attach event handlers to DomainUpDown controls
            dUD_ComboSolo.SelectedItemChanged += new EventHandler(UpdateTotalMoney);
            dUD_ComboCouple.SelectedItemChanged += new EventHandler(UpdateTotalMoney);
            dUD_ComboParty.SelectedItemChanged += new EventHandler(UpdateTotalMoney);
            dUD_ComboSolo_2ngan.SelectedItemChanged += new EventHandler(UpdateTotalMoney);
            dUD_ComboParty_2ngan.SelectedItemChanged += new EventHandler(UpdateTotalMoney);
            dUD_ComboCouple_2ngan.SelectedItemChanged += new EventHandler(UpdateTotalMoney);

            dUD_ComboSolo.SelectedItemChanged += new EventHandler(UpdateListView);
            dUD_ComboCouple.SelectedItemChanged += new EventHandler(UpdateListView);
            dUD_ComboParty.SelectedItemChanged += new EventHandler(UpdateListView);
            dUD_ComboSolo_2ngan.SelectedItemChanged += new EventHandler(UpdateListView);
            dUD_ComboParty_2ngan.SelectedItemChanged += new EventHandler(UpdateListView);
            dUD_ComboCouple_2ngan.SelectedItemChanged += new EventHandler(UpdateListView);
        }

        private void UpdateTotalMoney(object sender, EventArgs e)
        {
            try
            {
                // Parse the prices from the labels
                decimal priceComboSolo = ParsePrice(lb_money_combosolo.Text);
                decimal priceComboCouple = ParsePrice(lb_money_combocouple.Text);
                decimal priceComboParty = ParsePrice(lb_money_comboparty.Text);
                decimal priceComboSolo_2ngan = ParsePrice(lb_money_combosolo_2ngan.Text);
                decimal priceComboParty_2ngan = ParsePrice(lb_money_comboparty_2ngan.Text);
                decimal priceComboCouple_2ngan = ParsePrice(lb_money_combocouple_2ngan.Text);

                // Get the quantities from the DomainUpDown controls
                int quantityComboSolo = Convert.ToInt32(dUD_ComboSolo.SelectedItem);
                int quantityComboCouple = Convert.ToInt32(dUD_ComboCouple.SelectedItem);
                int quantityComboParty = Convert.ToInt32(dUD_ComboParty.SelectedItem);
                int quantityComboSolo_2ngan = Convert.ToInt32(dUD_ComboSolo_2ngan.SelectedItem);
                int quantityComboParty_2ngan = Convert.ToInt32(dUD_ComboParty_2ngan.SelectedItem);
                int quantityComboCouple_2ngan = Convert.ToInt32(dUD_ComboCouple_2ngan.SelectedItem);

                // Calculate the total money
                Total_FoodAndDrink_Money =
                    (priceComboSolo * quantityComboSolo) +
                    (priceComboCouple * quantityComboCouple) +
                    (priceComboParty * quantityComboParty) +
                    (priceComboSolo_2ngan * quantityComboSolo_2ngan) +
                    (priceComboParty_2ngan * quantityComboParty_2ngan) +
                    (priceComboCouple_2ngan * quantityComboCouple_2ngan) +
                    initialMoney; // Add initial money

                // Update the total display
                lb_totalMoney.Text = Total_FoodAndDrink_Money.ToString("N0") + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the total: " + ex.Message);
            }
        }

        private decimal ParsePrice(string priceText)
        {
            // Remove "VND" and convert to decimal
            return decimal.Parse(priceText.Replace("VND", "").Trim());
        }

        private void UpdateListView(object sender, EventArgs e)
        {
            // Clear existing items in ListView
            while (listView1.Items.Count > 1)
            {
                listView1.Items.RemoveAt(1);
            }

            // Add items to ListView with their respective prices
            AddListViewItem(lb_ComboSolo.Text, dUD_ComboSolo.SelectedItem.ToString(), lb_money_combosolo.Text);
            AddListViewItem(lb_ComboCouple.Text, dUD_ComboCouple.SelectedItem.ToString(), lb_money_combocouple.Text);
            AddListViewItem(lb_ComboParty.Text, dUD_ComboParty.SelectedItem.ToString(), lb_money_comboparty.Text);
            AddListViewItem(lb_ComboSolo_2Ngan.Text, dUD_ComboSolo_2ngan.SelectedItem.ToString(), lb_money_combosolo_2ngan.Text);
            AddListViewItem(lb_ComboParty_2Ngan.Text, dUD_ComboParty_2ngan.SelectedItem.ToString(), lb_money_comboparty_2ngan.Text);
            AddListViewItem(lb_ComboCouple_2Ngan.Text, dUD_ComboCouple_2ngan.SelectedItem.ToString(), lb_money_combocouple_2ngan.Text);

            HideRowsWithSoLuongZero();
        }
        private void AddListViewItem(string name, string quantity, string price)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(quantity);
            item.SubItems.Add(price);
            listView1.Items.Add(item);
        }
        private void HideRowsWithSoLuongZero()
        {
            // Create a list to store the items to be removed
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            // Iterate through the items in the ListView
            for (int i = 1; i < listView1.Items.Count; i++) // Skip the first item (movie info)
            {
                ListViewItem item = listView1.Items[i];
                // Check if the value of the SoLuong column is equal to 0
                if (item.SubItems[1].Text == "0") // Assuming SoLuong is the second column
                {
                    // Add the item to the list of items to be removed
                    itemsToRemove.Add(item);
                }
            }

            // Remove the items from the ListView
            foreach (ListViewItem itemToRemove in itemsToRemove)
            {
                listView1.Items.Remove(itemToRemove);
            }
        }

        private void FoodAndDrink_Load(object sender, EventArgs e)
        {
            string movieName = string.Empty;
            switch (selectedMovie)
            {
                case "1":
                    movieName = NameOfMovie1;
                    break;
                case "2":
                    movieName = NameOfMovie2;
                    break;
                case "3":
                    movieName = NameOfMovie3;
                    break;
                case "4":
                    movieName = NameOfMovie4;
                    break;
                default:
                    return;
            }

            // Add movie info to ListView
            AddListViewItem(movieName, countTickets.ToString(), lb_totalMoney.Text);
        }
        public static string totalMoney = null;
        DataTable comboTable = new DataTable();
        private void btn_Buy_Click(object sender, EventArgs e)
        {   
            totalMoney = lb_totalMoney.Text;
            comboTable.Columns.Add("ComboName", typeof(string));
            comboTable.Columns.Add("Quantity", typeof(int));

            foreach (ListViewItem item in listView1.Items)
            {
                // Kiểm tra nếu cột "Name" bắt đầu bằng "COMBO"
                if (item.Text.StartsWith("COMBO"))
                {
                    // Lấy giá trị của cột "SoLuong"
                    string comboName = item.Text;
                    int quantity = int.Parse(item.SubItems[1].Text);

                    // Thêm vào bảng
                    comboTable.Rows.Add(comboName, quantity);
                }
            }
            Payment payment = new Payment(comboTable);
           this.Hide();
           payment.Show();
        }
    }
}
