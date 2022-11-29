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
    public partial class LoginOrganization : Form
    {

        const string constr = @"Data Source=DESKTOP-6G52RPU;Initial Catalog=Northwind;Integrated Security=SSPI";
        SqlConnection cn = new SqlConnection(constr);
        public LoginOrganization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pass.Text != string.Empty || Username.Text != string.Empty)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Organization$ where Username='" + Username.Text + "' and Password='" + pass.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    OrganizationHome home = new OrganizationHome();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrganizationSignUp registration = new OrganizationSignUp();
            registration.ShowDialog();
        }

        private void LoginOrganization_Load(object sender, EventArgs e)
        {
            


        }
    }
}
