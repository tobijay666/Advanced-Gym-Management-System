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
    public partial class CustomerUpdateForm : Form
    {
        public CustomerUpdateForm()
        {
            InitializeComponent();
        }

        private void Searchbut_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(CIDtxt.Text);

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry1 = "SELECT * FROM Customer where cId ="+cid+"" ;

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



                    }
                }
            }
            
            catch(SqlException ee)
            {
                MessageBox.Show("Error! "+ ee.ToString());
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
        }

        private void Updatebut_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(CIDtxt.Text);
            string cname = Nametxt.Text;
            int age = int.Parse(Agetxt.Text);
            string nic = Nictxt.Text;
            string pno = Connotxt.Text;
            string address = Addresstxt.Text;
            string jdate = Datetxt.Text;
            string emercon = Emercontxt.Text;
            float height = float.Parse(Heighttxt.Text);
            float weight = float.Parse(Weighttxt.Text);
            float bmi = (weight / ((height * height) / 10000));
            int breast = int.Parse(Breasttxt.Text);
            int waist = int.Parse(Waisttxt.Text);
            int hips = int.Parse(Hipstxt.Text);
            //int temp = 1;

            SqlConnection con = new SqlConnection( @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf'; Integrated Security = True; Connect Timeout = 30");

            string upqry = " UPDATE Customer SET cName = '" + cname + "', cAge = " + age + ", cNIC = '" + nic + "', cPno = '" + pno + "', cAddress = '" + address + "', cJdate = '" + jdate + "', cEcont = '" + emercon + "', [height(cm)] = " + height + ",[weight(Kg)] = " + weight + ", bmi =" + bmi + ", breast = " + breast + ", waist = " + waist + ", hips = " + hips + "  WHERE cId = " + cid + " ";
           // string upqry = " UPDATE Customer SET cName = '"+cname+"', cAge = "+age+", cNIC = '"+nic+"', cPno = '"+pno+ "', cAddress = '" +address+ "', cJdate = '" + jdate + "', cEcont = '" + emercon + "', height(cm) = " + height + ", weight(Kg) = " + weight + ", bmi =" + bmi + ", breast = " + breast + ", waist = " + waist + ", hips = " + hips + " WHERE cId = " + cid + " ";
           // string upqry1 = " UPDATE Customer ( cName , cAge, cNIC , cPno , cAddress , cJdate , cEcont , height(cm) , weight(Kg) , bmi , breast , waist , hips,mID,wID) VALUES ('" + cname + "', " + age + ", '" + nic + "', '" + pno + "', '" + address + "', '" + jdate + "', '" + emercon + "', '" + height + "', '" + weight + "', '" + bmi + "', " + breast + ", " + waist + ", " + hips + "," + temp + "," + temp + ") WHERE cId =" + cid + " ";



            SqlCommand cmd = new SqlCommand( upqry , con);

            try
            { 
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show( "Customer information Updated");
            }

            catch (SqlException q1)
            {
                MessageBox.Show("Error! "+ q1.ToString() );
            }

            finally
            {
                con.Close();
            }

        }

        private void CIDtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
