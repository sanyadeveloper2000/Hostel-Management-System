using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOSTEL_ANAGEMENT.controls;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace HOSTEL_ANAGEMENT.controls
{
    public partial class staffcontrol : UserControl
    {
        public staffcontrol()
        {
            InitializeComponent();
        }
      



        private void button1_Click_1(object sender, EventArgs e)
        {
            staffc1 sc = new staffc1();
            sc.Show();
            sc.Size = MaximumSize;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
