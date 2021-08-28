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
    public partial class CustomerIndividualPayHistory : Form
    {
        
         string conString =   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30";

        SqlConnection conn3;
        SqlDataAdapter adapt;
        DataTable dt;

        public CustomerIndividualPayHistory()
        {
            InitializeComponent();
        }

        private void CustomerIndividualPayHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet3.Payment' table. You can move, or remove it, as needed.
            //this.paymentTableAdapter.Fill(this.slim_Lady_FitnessDataSet3.Payment);
            conn3 = new SqlConnection(conString);
            conn3.Open();
            adapt = new SqlDataAdapter("SELECT pId, pDate, pAmount FROM Payment", conn3);
            dt = new DataTable();
            PayDGV.DataSource = dt;
            conn3.Close();

        }

        private void Searchbut_Click(object sender, EventArgs e)
        {
            conn3 = new SqlConnection(conString);
            conn3.Open();
            string cid = txtEnterId.Text;
            adapt = new SqlDataAdapter("SELECT pId, pDate, pAmount FROM Payment WHERE cId ='" + cid + "'", conn3);
            dt = new DataTable();
            adapt.Fill(dt);
            PayDGV.DataSource = dt;
            conn3.Close();

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
