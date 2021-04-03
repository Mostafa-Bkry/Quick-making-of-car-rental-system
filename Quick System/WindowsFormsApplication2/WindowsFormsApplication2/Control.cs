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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cars c = new Cars();
            c.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Offers f = new Offers();
            f.Show();
            this.Hide();
        }
    }
}
