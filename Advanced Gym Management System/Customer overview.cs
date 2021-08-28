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
    public partial class Customer_overview : Form
    {
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf'; Integrated Security = True; Connect Timeout = 30";
        public Customer_overview()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_overview_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT cId, cName FROM dbo.Customer", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Home2 sistema = new Home2();
                sistema.ShowDialog();
                this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerinFrom c2 = new CustomerinFrom();
            c2.Show();
            this.Close();
        }
    }
}
