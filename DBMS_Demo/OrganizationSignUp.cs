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
    public partial class OrganizationSignUp : Form
    {
        private SqlDataReader dr;
        private SqlConnection cn;

        public OrganizationSignUp()
        {
            InitializeComponent();
        }

        private void OrganizationSignUp_Load(object sender, EventArgs e)
        {
            const string constr = @"Data Source=DESKTOP-6G52RPU;Initial Catalog=Northwind;Integrated Security=SSPI";
           cn = new SqlConnection(constr);


            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginOrganization f3 = new LoginOrganization();
            f3.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (pass.Text != string.Empty || usename.Text != string.Empty || Name.Text != string.Empty|| city.Text != string.Empty|| Address.Text != string.Empty || email.Text != string.Empty)
            {
               
                
                SqlCommand cmd = new SqlCommand("select * from Organization where username='" + usename.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Organization values(@Name,@username,@password, @Address, @email)", cn);
                    cmd.Parameters.AddWithValue("Name", Name.Text);
                    cmd.Parameters.AddWithValue("usename", usename.Text);
                    cmd.Parameters.AddWithValue("password", pass.Text);
                    cmd.Parameters.AddWithValue("city", city.Text);
                    cmd.Parameters.AddWithValue("Address", Address.Text + city.Text);
                    cmd.Parameters.AddWithValue("email", email.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
               
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
        //OrganizationHome f4 = new OrganizationHome();
        //this.Hide();
        // f4.ShowDialog();

    }
    
}
