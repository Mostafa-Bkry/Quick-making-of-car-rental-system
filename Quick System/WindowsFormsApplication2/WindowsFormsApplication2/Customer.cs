using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Check Entered Data");
            }
            else
            {
                MessageBox.Show("Welcome " + TextBox1.Text + " your request will be done Soon");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Control c = new Control();
            c.Show();
            this.Close();
        }
    }
}
