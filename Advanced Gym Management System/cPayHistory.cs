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
    public partial class cPayHistory : Form
    {
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataTable dt;
        public cPayHistory()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cDetails cDobj = new cDetails();
            cDobj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB\Slim Lady Fitness.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM Payment";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Payment");
            dgvPayHistory.DataSource = ds.Tables["Payment"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cPayHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.slim_Lady_FitnessDataSet1.Payment);
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.slim_Lady_FitnessDataSet.Payment);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvPayHistory.CurrentCell.RowIndex;
            dgvPayHistory.Rows.RemoveAt(rowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cPayments cPobj = new cPayments();
            cPobj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cPayments cPobj = new cPayments();
            cPobj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
