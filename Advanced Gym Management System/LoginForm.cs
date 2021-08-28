using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Gym_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbut_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = passtxt.Text;

            if ((username=="admin") && (password=="admin"))
            {
                this.Close();
                CustomerUpdateForm cuf1 = new CustomerUpdateForm();
                cuf1.Show();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
    }
}
