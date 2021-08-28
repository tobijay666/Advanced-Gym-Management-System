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
    public partial class MealandWorkplan : Form
    {
        public MealandWorkplan()
        {
            InitializeComponent();
        }

        private void Searchbut_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(CIDtxt.Text);

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            try
            {
                using (con1)
                {
                    con1.Open();
                    using (SqlCommand cmd1 = new SqlCommand("SELECT wID FROM Customer WHERE cId = " + cid + " ", con1))
                    {
                        SqlDataReader sdr1 = cmd1.ExecuteReader();
                        sdr1.Read();
                        string wid = sdr1["wID"].ToString();
                        lblwid.Text = wid;
                        sdr1.Close();

                        using (SqlCommand cmd2 = new SqlCommand("SELECT wName FROM Workout WHERE wId = '" + wid + "' ", con1))
                        {
                            SqlDataReader sdr2 = cmd2.ExecuteReader();
                            sdr2.Read();
                            lblwname.Text = sdr2["wName"].ToString();

                            sdr2.Close();
                        }
                    }
                    using (SqlCommand cmd3 = new SqlCommand("SELECT mID FROM Customer WHERE cId = " + cid + " ", con1))
                    {
                        SqlDataReader sdr3 = cmd3.ExecuteReader();
                        sdr3.Read();
                        string mid = sdr3["mID"].ToString();
                        lblmid.Text = mid;
                        sdr3.Close();

                        using (SqlCommand cmd4 = new SqlCommand("SELECT mName FROM Meal WHERE mId = '" + mid + "' ", con1))
                        {
                            SqlDataReader sdr4 = cmd4.ExecuteReader();
                            sdr4.Read();
                            lblmname.Text = sdr4["mName"].ToString();

                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Search Data\n" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
            }
        }

        private void wupdatebut_Click(object sender, EventArgs e)
        {
            int nwid = int.Parse(Nwidtxt.Text);
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");


            string qry = "UPDATE Customer SET wID = " + nwid + " ";

            SqlCommand cmd = new SqlCommand(qry, con2);

            try
            {
                con2.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to UPDATE data", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Update\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Nwidtxt.Text = "";
                con2.Close();
            }
        }

        private void mupdatebut_Click(object sender, EventArgs e)
        {
            int nmid = int.Parse(Nmidtxt.Text);
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\NSBM\Course\SEM 2\C#\C# course work\DB\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");


            string qry = "UPDATE Customer SET mID = " + nmid + " ";

            SqlCommand cmd = new SqlCommand(qry, con2);

            try
            {
                con2.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to UPDATE data", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Update\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Nmidtxt.Text = "";
                con2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h1 = new Home2();
            h1.ShowDialog();
            this.Close();
        }
    }
}

