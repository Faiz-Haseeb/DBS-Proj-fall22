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
    public partial class DonorHome : Form
    {
        public DonorHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDonor f3 = new ViewDonor();
            f3.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
