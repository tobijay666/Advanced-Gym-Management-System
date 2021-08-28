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
    public partial class PaymentHistory : Form
    {
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet4.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.slim_Lady_FitnessDataSet4.Payment);

        }

        private void Searchbut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Payment";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "pay");

            PayDGV.DataSource = set.Tables["pay"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h1 = new Home2();
            h1.ShowDialog();
            this.Close();
        }
    }
}
