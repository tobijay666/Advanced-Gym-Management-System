using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Gym_Management_System
{
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inRegForm reg1 = new inRegForm();
            reg1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerinFrom info1 = new CustomerinFrom();
            info1.Show();
            this.Close();
        }

        private void viewcus_Click(object sender, EventArgs e)
        {
            Customer_overview over1 = new Customer_overview();
            over1.Show();
            this.Close();
        }

        private void paynow_Click(object sender, EventArgs e)
        {
            CustomerPayment pay1 = new CustomerPayment();
            pay1.Show();
            this.Close();
        }

        private void paydet_Click(object sender, EventArgs e)
        {
            CustomerIndividualPayHistory payhis = new CustomerIndividualPayHistory();
            payhis.Show();
            this.Close();
        }

        private void payhist_Click(object sender, EventArgs e)
        {
            PaymentHistory hist = new PaymentHistory();
            hist.Show();
            this.Close();
        }

        private void workbut_Click(object sender, EventArgs e)
        {
            Workoutplan wp1 = new Workoutplan();
            wp1.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mealplan m1 = new Mealplan();
            m1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealandWorkplan mw = new MealandWorkplan();
            mw.Show();
            this.Close();
        }
    }
}
