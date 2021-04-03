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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if ((TextBox1.Text == "Ahmed" && TextBox2.Text == "121") || (TextBox1.Text == "Karim" && TextBox2.Text == "111"))
                {
                    Control c = new Control();
                    c.Show();
                    this.Hide();

                }
                else
                {
                    TextBox1.Clear();
                    TextBox2.Clear();
                    MessageBox.Show("Check username or password");

                }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
