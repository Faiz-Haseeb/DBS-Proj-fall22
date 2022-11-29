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
    public partial class OrganizationHome : Form
    {
        public OrganizationHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f8 = new Form1();
            f8.Show();
            this.Hide();
        }
    }
}
