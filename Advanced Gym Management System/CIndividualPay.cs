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
    public partial class CIndividualPay : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Advanced Gym Management App\Advanced Gym Management System\Slim Lady Fitness.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn3;
        SqlDataAdapter adapt;
        DataTable dt;
        
        public CIndividualPay()
        {
            InitializeComponent();
        }

        private void CIndividualPay_Load(object sender, EventArgs e)
        {
            conn3 = new SqlConnection(conString);
            conn3.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Payment", conn3);
            dt = new DataTable();
            dgvcIndCusPay.DataSource = dt;
            conn3.Close();

        }

       

        private void txtCId_TextChanged(object sender, EventArgs e)
        {
            conn3 = new SqlConnection(conString);
            conn3.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Payment WHERE cId LIKE'"+txtCId.Text+"%'", conn3);
            dt = new DataTable();
            adapt.Fill(dt);
            dgvcIndCusPay.DataSource = dt;
            conn3.Close();
        }

        private void viewBtn2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
