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
    public partial class CustomerPlans : Form
    {
        public CustomerPlans()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int cuId = int.Parse(txtCuId.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            try
            {
                using (con)
                {
                    con.Open();
                    using (SqlCommand cmd1 = new SqlCommand("SELECT wID FROM Customer WHERE cId = " + cuId + " ", con))
                    {
                        SqlDataReader sdr1 = cmd1.ExecuteReader();
                        sdr1.Read();
                        string wid = sdr1["wID"].ToString();
                        sdr1.Close();

                        using (SqlCommand cmd2 = new SqlCommand("SELECT wName, wDesc FROM Workout WHERE wId = '"+wid+"' ", con))
                        {
                            SqlDataReader sdr2 = cmd2.ExecuteReader();
                            sdr2.Read();
                            lblWorkName.Text = sdr2["wName"].ToString();
                            lblWorkDesc.Text = sdr2["wDesc"].ToString();
                            sdr2.Close();
                        }
                    }
                    using (SqlCommand cmd3 = new SqlCommand("SELECT mID FROM Customer WHERE cId = "+cuId+" ", con))
                    {
                        SqlDataReader sdr3 = cmd3.ExecuteReader();
                        sdr3.Read();
                        string mid = sdr3["mID"].ToString();
                        sdr3.Close();

                        using (SqlCommand cmd4 = new SqlCommand("SELECT mName, mDesc FROM Meal WHERE mId = '"+mid+"' ", con))
                        {
                            SqlDataReader sdr4 = cmd4.ExecuteReader();
                            sdr4.Read();
                            lblMealName.Text = sdr4["mName"].ToString();
                            lblMealDesc.Text = sdr4["mDesc"].ToString();
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
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCuId.Text = null;
            lblWorkName.Text = null;
            lblWorkDesc.Text = null;
            lblMealName.Text = null;
            lblMealDesc.Text = null;
            txtWorkIdnew.Text = null;
            txtMealIdnew.Text = null;
        }

        private void btnUpdateWork_Click(object sender, EventArgs e)
        {
            int workId = int.Parse(txtWorkIdnew.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "UPDATE Customer SET wID = "+ workId + " ";

            SqlCommand cmd = new SqlCommand(qry, con);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to UPDATE data", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Update\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            int mealId = int.Parse(txtMealIdnew.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "UPDATE Customer SET mID = " + mealId + " ";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to UPDATE data", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Update\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            /*Form1 f1 = new Form1();
            f1.Show();
            this.Hide();*/
        }
    }
}
