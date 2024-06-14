using CinemaManagement_Project.Pay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement_Project.SignIn_SignUp
{
    public partial class Select : Form
    {

        public Select()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_MovieMana_Click(object sender, EventArgs e)
        {
            SelectMovieState selectMovieState = new SelectMovieState("admin");
            selectMovieState.Show();
            this.Close();
        }

        private void btn_PaymentMana_Click(object sender, EventArgs e)
        {
            Pay.PaymentManagement paymentManagement = new Pay.PaymentManagement();
            this.Close();
            paymentManagement.Show();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Close();
            dn.Show();  
        }
    }
}
