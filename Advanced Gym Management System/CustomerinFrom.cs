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
    public partial class CustomerinFrom : Form
    {
        public CustomerinFrom()
        {
            InitializeComponent();
        }

        private void Searchbut_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(txtEnterId.Text);

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry1 = "SELECT * FROM Customer where cId =" + cid + "";

            SqlCommand cmd1 = new SqlCommand(qry1, con1);

            try
            {
                con1.Open();

                using (SqlDataReader read = cmd1.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Nametxt.Text = (read["cName"].ToString());
                        Agetxt.Text = (read["cAge"].ToString());
                        Nictxt.Text = (read["cNIC"].ToString());
                        Connotxt.Text = (read["cPno"].ToString());
                        Addresstxt.Text = (read["cAddress"].ToString());
                        Datetxt.Text = (read["cJdate"].ToString());
                        Emercontxt.Text = (read["cEcont"].ToString());
                        Heighttxt.Text = (read["height(cm)"].ToString());
                        Weighttxt.Text = (read["weight(Kg)"].ToString());
                        Breasttxt.Text = (read["breast"].ToString());
                        Waisttxt.Text = (read["waist"].ToString());
                        Hipstxt.Text = (read["hips"].ToString());
                        widtxt.Text = (read["mID"].ToString());
                        midtxt.Text = (read["wID"].ToString());



                    }
                }
            }

            catch (SqlException ee)
            {
                MessageBox.Show("Error! " + ee.ToString());
            }

            finally
            {
                con1.Close();
            }
        }

        private void Clearbut_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Agetxt.Text = "";
            Nictxt.Text = "";
            Connotxt.Text = "";
            Addresstxt.Text = "";
            Datetxt.Text = "";
            Emercontxt.Text = "";
            Heighttxt.Text = "";
            Weighttxt.Text = "";
            Breasttxt.Text = "";
            Waisttxt.Text = "";
            Hipstxt.Text = "";
            widtxt.Text = "";
            midtxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h1 = new Home2();
            h1.ShowDialog();
            this.Close();
        }

        private void Updatebut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerUpdateForm u1 = new CustomerUpdateForm();
            u1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MealandWorkplan mw = new MealandWorkplan();
            mw.Show();
            this.Close();
        }
    }
}
