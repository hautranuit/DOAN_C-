using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CinemaManagement_Project.Theater1;

namespace CinemaManagement_Project.BuyTickets
{   
    public partial class FoodAndDrink : Form
    {
        private decimal Total_FoodAndDrink_Money = 0m;
        private decimal initialMoney = 0m; // Store initial money from Theater1

        public FoodAndDrink()
        {
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
            for (int i = 10; i >= 0; i--) // Adjust the range as needed
            {
                domainUpDown.Items.Add(i);
            }
            domainUpDown.SelectedIndex = 10;
            domainUpDown.Wrap = true;
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
    }
}
