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
    public partial class cIndividualDetails : Form
    {
        public cIndividualDetails()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            int CUSid = int.Parse(txtEnterId.Text);

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Advanced Gym Management App\Advanced Gym Management System\Slim Lady Fitness.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "SELECT * FROM Customer WHERE cId="+CUSid+"";

            SqlCommand cmmd = new SqlCommand(query, con1);

            try
            {
                con1.Open();
                using (SqlDataReader read = cmmd.ExecuteReader())
                {
                    while(read.Read())
                    {
                        txtName.Text = (read["cName"].ToString());
                        txtAge.Text = (read["cAge"].ToString());
                        txtAddr.Text = (read["cAddress"].ToString());
                        txtNIC.Text = (read["cNIC"].ToString());
                        txtCNo.Text = (read["cPno"].ToString());
                        txtECNo.Text = (read["cEcont"].ToString());
                        txtJDate.Text = (read["cJdate"].ToString());
                        txtHeight.Text = (read["height(cm)"].ToString());
                        txtWeight.Text = (read["weight(Kg)"].ToString());
                        txtBMI.Text = (read["bmi"].ToString());
                        txtBreast.Text = (read["breast"].ToString());
                        txtWaist.Text = (read["waist"].ToString());
                        txtHips.Text = (read["hips"].ToString());
                        txtWork.Text = (read["mID"].ToString());
                        txtMeal.Text = (read["wID"].ToString());
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            finally
            {
                con1.Close();
            }

        }
    }
}
