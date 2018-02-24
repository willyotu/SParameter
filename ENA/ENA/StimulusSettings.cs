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
    public partial class StimulusSettingsForm : Form
    {
        public StimulusSettingsForm()
        {
            InitializeComponent();
            IFBW = "20e3";
            ifBWTB.Text = IFBW;
            Points = "401";
            pointsNUD.Value = Convert.ToDecimal(Points);
            StartFrequency = "40e3";
            startFrequencyTB.Text = StartFrequency;
            StopFrequency = "8.5e9";
            stopFrequencyTB.Text = StopFrequency;
            SParameter = "S21";
            sParameterTB.Text = SParameter;
        }

        private string _iFBW;
        public string IFBW
        {
            get
            {
                return _iFBW;
            }
            set
            {
                _iFBW = value;
            }
        }
        private void ifBWTB_TextChanged(object sender, EventArgs e)
        {
            IFBW = ifBWTB.Text;
        }

        private string _points;
        public string Points
        {
            get
            {
                return _points ;
            }
            set
            {
                _points =value;
            }
        }
        private void pointsNUD_ValueChanged(object sender, EventArgs e)
        {
            Points = pointsNUD.Value.ToString();
            
        }

        private string _startFrequency;
        public string StartFrequency
        {
            get
            {
                return _startFrequency;
            }
            set
            {
                _startFrequency = value;
            }
        }
        private void startFrequencyTB_TextChanged(object sender, EventArgs e)
        {
            StartFrequency = startFrequencyTB.Text;
        }


        private string _stopFrequency;
        public string StopFrequency
        {
            get
            {
                return _stopFrequency;
            }
            set
            {
                _stopFrequency = value;
            }
        }
        private void stopFrequencyTB_TextChanged(object sender, EventArgs e)
        {
            StopFrequency = stopFrequencyTB.Text;
        }

        private string _sParameter;
        public string SParameter
        {
            get
            {
                return _sParameter; 
            }
            set
            {
                _sParameter = value;
            }
        }
        private void sParameterTB_TextChanged(object sender, EventArgs e)
        {
            SParameter = sParameterTB.Text;
        }

        
    }
}
