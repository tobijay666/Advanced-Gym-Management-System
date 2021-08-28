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
    public partial class WorkoutPlan : Form
    {
        public WorkoutPlan()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int workId = int.Parse(txtWorkId.Text);
            string workName = txtWorkName.Text;
            string workDes = txtWorkDesc.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "UPDATE Workout SET wName = '" + workName+"', wDesc = '"+workDes+"' WHERE wId = "+ workId + " ";

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

        private void WorkoutPlan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Workout";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Workout");

            workDGV.DataSource = set.Tables["Workout"];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWorkId.Text = null;
            txtWorkName.Text = null;
            txtWorkDesc.Text = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Workout";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Workout");

            workDGV.DataSource = set.Tables["Workout"];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string workName = txtWorkName.Text;
            string workDes = txtWorkDesc.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\NSBM\C#\DB\Slim Lady Fitness.mdf';Integrated Security=True;Connect Timeout=30");

            string qry = "INSERT INTO Workout (wName, wDesc) VALUES ('" + workName + "', '" + workDes + "') ";

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
            /*Form1 f1 = new Form1();
            f1.Show();
            this.Hide();*/
        }
    }
}
