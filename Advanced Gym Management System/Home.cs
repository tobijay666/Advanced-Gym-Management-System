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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movepanel(button1);
            panel3.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            movepanel(button2);
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movepanel(button3);
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movepanel(button4);
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_overview sistema = new Customer_overview();
            sistema.ShowDialog();
            this.Close();
        }
    }
}