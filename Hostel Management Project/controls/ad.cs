using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOSTEL_ANAGEMENT;
using System.Web.UI.WebControls;

namespace HOSTEL_ANAGEMENT.controls
{
    public partial class ad : UserControl
    {
        public ad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrationcontrol rf = new registrationcontrol();
            rf.Show();
            rf.Dock = DockStyle.Fill;
            
    

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registrationcontrol rf = new registrationcontrol();
            rf.Show();
            rf.Size = MaximumSize;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           

            

            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            registrationcontrol rf = new registrationcontrol();
            rf.Show();
            rf.Dock = DockStyle.Fill;
         
           
            

        }
      
    }
}
