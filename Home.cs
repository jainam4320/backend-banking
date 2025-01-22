using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Banking_OOSE
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lab_Click(object sender, EventArgs e)
        {

        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = this;
            Login f1 = new Login();
            f1.Show();
            f2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
