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
            addressTB.Text = "TCPIP0::10.10.10.10::inst0::INSTR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ENAForm enaForm = new ENAForm(addressTB.Text);
            enaForm.ShowDialog();
        }

       
       
    }
}
