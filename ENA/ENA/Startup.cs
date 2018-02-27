using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            addressTB.Text = "TCPIP0::10.114.11.152::inst0::INSTR";
        }

        private void BStartupRun_Click(object sender, EventArgs e)
        {
            try
            {
                ENAForm enaForm = new ENAForm(addressTB.Text);
                enaForm.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Check VISA Address matches that set up in IO libraires and retry");
               
            }
            
        }

       
    }
}
