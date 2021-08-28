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
    public partial class inRegForm : Form
    {
        public inRegForm()
        {
            InitializeComponent();
        }

        private void Connotxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Submitbut_Click(object sender, EventArgs e)
        {
            string cname = Nametxt.Text;
            int age = int.Parse(Agetxt.Text);
            string nic = Nictxt.Text;
            string pno = Connotxt.Text;
            string address = Addresstxt.Text;
            string jdate = Datetxt.Text;
            string emercon = Emercontxt.Text;
            float height = float.Parse(Heighttxt.Text);
            float weight = float.Parse(Weighttxt.Text);
            float bmi = (weight/((height*height)/10000));
            int breast = int.Parse(Breasttxt.Text);
            int waist = int.Parse(Waisttxt.Text);
            int hips = int.Parse(Hipstxt.Text);
            int temp = 1;

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string inqry1 = "INSERT INTO Customer VALUES ('" + cname + "'," + age + ",'" + nic + "','" + pno + "','" + address + "','" + jdate + "','" + emercon + "',"+height+","+weight+","+bmi+","+breast+","+waist+","+hips+","+temp+ "," + temp + ")";
            SqlCommand cmd1 = new SqlCommand(inqry1,con1);

            try
            {
                con1.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("New Customer information added");
            }

            catch(SqlException ez)
            {
                MessageBox.Show("Error! "+ ez.ToString());
            }

            finally
            {
                con1.Close();
                this.Hide();
                Customer_overview c1 = new Customer_overview();
                c1.Show();
                this.Close();
            }

            
            
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h1 = new Home2();
            h1.Show();
            this.Close();
            
        }

        private void inRegForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
