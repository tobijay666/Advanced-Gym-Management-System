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
    public partial class cDetails : Form
    {
        public cDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cPayHistory cPHisobj = new cPayHistory();
            cPHisobj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB\Slim Lady Fitness.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM Customer";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            dgvAllCustomers.DataSource = ds.Tables["Customer"];
        }

        private void cDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet4.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.slim_Lady_FitnessDataSet4.Customer);
            // TODO: This line of code loads data into the 'slim_Lady_FitnessDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.slim_Lady_FitnessDataSet3.Customer);

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtEnterCId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvPayHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cDbtnUpdt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
