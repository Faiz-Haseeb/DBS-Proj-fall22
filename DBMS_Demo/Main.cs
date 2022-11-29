using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            const string constr = @"Data Source=DESKTOP-6G52RPU;Initial Catalog=Northwind;Integrated Security=SSPI";
            SqlConnection cn = new SqlConnection(constr);
            
           
            cn.Open();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
               
        {   




            if ((radioButton3.Checked)==true){
                OrganizationSignUp f2 = new OrganizationSignUp();
                this.Hide();
                f2.Show();
            }
            if ((radioButton1.Checked)==true){
                VolunteerSignup f2 = new VolunteerSignup();
                this.Hide();
                f2.Show();
            }
            if ((radioButton2.Checked)== true)
            {
                DonorSignUp f2 = new DonorSignUp();
                this.Hide();
                f2.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((radioButton3.Checked) == true)
            {
                LoginOrganization f2 = new LoginOrganization();
                this.Hide();
                f2.Show();
            }
            if ((radioButton1.Checked) == true)
            {
                Login f2 = new Login();
                this.Hide();
                f2.Show();
            }
            if ((radioButton2.Checked) == true)
            {
                LoginDonor f2 = new LoginDonor();
                this.Hide();
                f2.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
