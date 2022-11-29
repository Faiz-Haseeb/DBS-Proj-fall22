using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Demo
{
    public partial class DonorSignUp : Form
    {
        public DonorSignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DONOR SIGNUP
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //DONOR LOGIN
            Login f12 = new Login();
            f12.Show();
            this.Hide();
        }
    }
}
