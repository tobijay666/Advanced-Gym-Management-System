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
    public partial class MealPlan : Form
    {
        public MealPlan()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int mealId = int.Parse(txtMealId.Text);
            string mealName = txtMealName.Text;
            string mealDes = txtMealDesc.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "UPDATE Meal SET mName = '"+mealName+"', mDesc = '" + mealDes + "' WHERE mID = "+mealId+ " ";

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

        private void MealPlan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Meal";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Meal");

            mealDGV.DataSource = set.Tables["Meal"].DefaultView;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMealId.Text = null;
            txtMealName.Text = null;
            txtMealDesc.Text = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Meal";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Meal");

            mealDGV.DataSource = set.Tables["Meal"].DefaultView;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string mealName = txtMealName.Text;
            string mealDes = txtMealDesc.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "INSERT INTO Meal (mName, mDesc) VALUES ('" + mealName + "', '" + mealDes + "') ";
            
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Are you sure you want to INSERT data", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! Failed to Insert Data\n" + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
