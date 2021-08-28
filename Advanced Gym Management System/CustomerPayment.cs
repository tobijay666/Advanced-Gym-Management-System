using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Advanced_Gym_Management_System
{
    public partial class CustomerPayment : Form
    {
        public CustomerPayment()
        {
            InitializeComponent();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            string Date = Datetxt.Text;
            int CusId = int.Parse(txtCID.Text);
            int PaidAmt = int.Parse(txtAmount.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "INSERT INTO Payment(pDate,cId,pAmount) Values ('" + Date + "'," + CusId + "," + PaidAmt + ")";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occured " + ex.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadLine();
                this.Hide();
                PaymentHistory p2 = new PaymentHistory();
                p2.Show();
                this.Close();
            }

        }

        private void butHis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h1 = new Home2();
            h1.ShowDialog();
            this.Close();
        }
    }
}
