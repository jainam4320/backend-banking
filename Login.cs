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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form dlg1 = new Form();
            //dlg1.ShowDialog();
            //System.Windows.Forms.Form f2 = this;
            //Registration f1 = new Registration();
            //f1.Show();
            //f2.Hide();
            if (textBox2.Text == "Jainam" && textBox3.Text == "123")
            {
                Form f2 = this;
                Registration f1 = new Registration();
                f1.Show();
                f2.Hide();
            }
            else
            {
                Form dlg1 = new Form();
                dlg1.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
