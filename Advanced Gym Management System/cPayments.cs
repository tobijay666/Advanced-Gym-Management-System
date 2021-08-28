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
    public partial class cPayments : Form
    {
        public cPayments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string Date = dateTimePicker1.Text;
            int CusId = int.Parse(textBox3.Text);
            int PaidAmt = int.Parse(textBox4.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB\Slim Lady Fitness.mdf;Integrated Security=True;Connect Timeout=30");

            string qry = "INSERT INTO Payment(pDate,cId,pAmount) Values ('"+Date+"',"+CusId+","+PaidAmt+")";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error occured " + ex.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadLine();
            }
        }

        private void cPayments_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cPayHistory CPHobj = new cPayHistory();
            CPHobj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
