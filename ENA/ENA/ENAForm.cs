using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agilent.CommandExpert.ScpiNet.AgENA_E5071_A_11_22; // Make sure you target .NET Framework 4.5.2 or later
using System.IO;
using System.Runtime.InteropServices;

using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace ENA
{
    public partial class ENAForm : Form
    {
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;
        private AgENA_E5071 eNA;
       
        private Excel.Application xlApp;
        private string resultsFile = "Results.txt";
        private string resultsFileFullPath;
        private string fileDirectory = @"C:\Users\wilattoh\Documents";

       
        public ENAForm( string visaAddress)
        {
            InitializeComponent();
            eNA = new AgENA_E5071(visaAddress);
            xlApp = new Excel.Application();
            IFBW = "70e3";
            ifBWTB.Text = IFBW;
            Points = "401";
            pointsNUD.Value = Convert.ToDecimal(Points);
            StartFrequency = "300e3";
            startFrequencyTB.Text = StartFrequency;
            StopFrequency = "8.5e9";
            stopFrequencyTB.Text = StopFrequency;
            SParameter = "S21";
            sParameterTB.Text = SParameter;
            
            CBEnableLimitTest.Checked = false;
            CBBeeperWarning.Checked = false;
            ComboBLimitLineType.SelectedIndex = 0;
            ComboBLimitLineType.Hide();
            lLimitLineType.Hide();
            GBLimitLine1.Hide();
       
            TBLimit1StartFrequency.Text = "1000000000";
            TBLimit1StopFrequency.Text  = "1100000000";
            TBLimit1StartAmplitude.Text = "0";

            nudInterval.Value = 3;
            resultsFileFullPath = fileDirectory + @"\" + resultsFile;
          }

        // Load the ENA Measurement Form 
        private void ENAForm_Load(object sender, EventArgs e)
        {
            MeasurementSetup();
        }

        // Run Button
        private void bRun_Click(object sender, EventArgs e)
        {
            SParameterMeasurement();
        }

        // Stop Button
        private void bStop_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void MeasurementSetup()
        {
            eNA.SCPI.SYSTem.PRESet.Command();
            eNA.SCPI.SENSe.SWEep.POINts.Command(1, Convert.ToInt32(Points));
            eNA.SCPI.SENSe.FREQuency.STARt.Command(1, Convert.ToDouble(StartFrequency));
            eNA.SCPI.SENSe.FREQuency.STOP.Command(1, Convert.ToDouble(StopFrequency));
            eNA.SCPI.SENSe.BANDwidth.RESolution.Command(1, Convert.ToDouble(IFBW));
            eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, 1, SParameter);
        }
        
        // Measures S Parameter
        private void SParameterMeasurement()
        {
            try
            {
                // Begin timing and start capturing data.
                DateTime startTime = DateTime.Now;
                bRun.Enabled = false;
                double elapsed = 0;
                int elapsedTime = 0;
                
                int interval = Convert.ToInt32(nudInterval.Value);
                int intervalConverted = interval * 1000;
                double limitline1StartF = Convert.ToDouble(TBLimit1StartFrequency.Text);
                double limitline1StopF = Convert.ToDouble(TBLimit1StopFrequency.Text);
                double limitline1Amplitude = Convert.ToDouble(TBLimit1StartAmplitude.Text);


                // Start capturing data 
             //while{bStop_Click event has not changed}
                    DateTime stopTime = DateTime.Now;
                    elapsed = stopTime.Subtract(startTime).TotalSeconds;
                    elapsedTime = Convert.ToInt32(elapsed);

                    double limitLineType;
                   
                    eNA.SCPI.SENSe.SWEep.POINts.Command(1, Convert.ToInt32(Points));
                    eNA.SCPI.SENSe.FREQuency.STARt.Command(1, Convert.ToDouble(StartFrequency));
                    eNA.SCPI.SENSe.FREQuency.STOP.Command(1, Convert.ToDouble(StopFrequency));
                    eNA.SCPI.SENSe.BANDwidth.RESolution.Command(1, Convert.ToDouble(IFBW));
                    eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, 1, SParameter);
                    eNA.SCPI.CALCulate.SELected.LIMit.STATe.Command(1, CBEnableLimitTest.Checked ? "ON" : "OFF");
                    eNA.SCPI.CALCulate.SELected.LIMit.DISPlay.STATe.Command(1, true);
                    eNA.SCPI.SYSTem.BEEPer.WARNing.STATe.Command(CBBeeperWarning.Checked);


                    if ((ComboBLimitLineType.SelectedIndex == 0))
                        limitLineType = 1;
                    else if (ComboBLimitLineType.SelectedIndex == 1)
                        limitLineType = 2;
                    else
                    {
                        limitLineType = 0;
                    }

                    eNA.SCPI.CALCulate.SELected.LIMit.DATA.CommandAsciiReal(1,
                        new double[]
                        {
                            1, limitLineType, limitline1StartF, limitline1StopF, limitline1Amplitude,
                            limitline1Amplitude
                        });
                
                    ImportData();
                    bRun.Enabled = true;
                    System.Threading.Thread.Sleep(intervalConverted);
                    System.Windows.Forms.Application.DoEvents();
            

               
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Check VISA Address \n{0}" + e);
            }
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
                return _points;
            }
            set
            {
                _points = value;
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
        
        private void CreateExcel()
        {
            
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

                       
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                       
            xlWorkBook.SaveAs(@"C:\Users\wilattoh\Documents\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void ImportData()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            xlApp.DisplayAlerts = false;
            string filePath = @"C:\Users\wilattoh\Documents\csharp-Excel.xls";
            if (!System.IO.File.Exists(filePath))
            {
                CreateExcel();
            }
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Sheets worksheets = xlWorkBook.Worksheets;

            var xlNewSheet = (Excel.Worksheet)worksheets.Add(worksheets[1], Type.Missing, Type.Missing, Type.Missing);

            xlNewSheet.Name = DateTime.Now.ToString("yyyyMMddHHmmss");
       
            double[] results;
            double[] failedPoints;
            xlNewSheet.Cells[1, 1] = "Frequency";

            double startFrequency;
            double stopFrequency;
            int points;
            double steps;
            eNA.SCPI.SENSe.FREQuency.STARt.Query(out startFrequency);
            eNA.SCPI.SENSe.FREQuency.STOP.Query(out stopFrequency);
            eNA.SCPI.SENSe.SWEep.POINts.Query(out points);

            int row;
            steps = (stopFrequency - startFrequency) / points;
            row = 1;
            double frequency;
            for (frequency = startFrequency; (frequency <= stopFrequency); frequency = (frequency + steps))
            {
                row = row + 1;
                xlNewSheet.Cells[row, 1] = frequency;
            }
            xlNewSheet.Cells[1, 2] = SParameter;
            eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, 1, SParameter);
            eNA.SCPI.CALCulate.PARameter.SELect.Command(1u);
            eNA.SCPI.FORMat.DATA.Command("ASCii");
            eNA.SCPI.CALCulate.SELected.DATA.FDATa.QueryAsciiReal(1, out results);

            row = 1;
            int i;
            for (i = 0; (i <= results.Length); i = (i + 2))
            {
                object result = null;
                result = results.ElementAt(i);
                row = (row + 1);

                xlNewSheet.Cells[row, 2] = result;
                if ((row == (points + 1)))
                {
                    break;
                }
            }


            xlNewSheet.Cells[1, 3] = "Failed Points";
            eNA.SCPI.CALCulate.SELected.LIMit.REPort.DATA.QueryAsciiReal(1, out failedPoints);
            row = 1;
            
            foreach(var point in failedPoints)
            {
                row = row + 1;
                xlNewSheet.Cells[row, 3] = point;

            }

                
             PlotSParameter(xlWorkBook, points);

            xlNewSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlNewSheet.Select();

            xlWorkBook.SaveAs(@"C:\Users\wilattoh\Documents\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlNewSheet);
            releaseObject(worksheets);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
                      
        }

        private void PlotSParameter(Workbook xlWorkBook, int points)
        {
            Range oRng;
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = (Excel.ChartObject)xlCharts.Add(700, 50, 300, 300);
            Chart chart = myChart.Chart;
            oRng = xlWorkSheet.Range["A1:A" + points + ",B1:B" + points + ""];
            chart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            chart.ChartStyle = 7;
            chart.ChartWizard(Source: oRng, Title: SParameter, HasLegend: true);
            chart.ChartType = XlChartType.xlLine;
            Axis axisS21 = (Axis)chart.Axes(XlAxisType.xlValue);
            axisS21.TickLabels.NumberFormat = "#,##0.00";
            axisS21.MaximumScale = 20;
            axisS21.MinimumScale = -140;
            axisS21.HasMajorGridlines = false;
            Axis axisCatS21 = (Axis)chart.Axes(XlAxisType.xlCategory);
            axisCatS21.TickLabels.NumberFormat = "0.00E+00";
            axisCatS21.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;
        }

        // Select a file from directory using File browser.
        private void Select_File(ref string Filename, ref bool Filename_Changed, string InitialDirectory = ".")
        {
            Filename_Changed = false;

            OpenFileDialog openFileDialogReadFile = new OpenFileDialog();
            openFileDialogReadFile.InitialDirectory = InitialDirectory;
            openFileDialogReadFile.RestoreDirectory = true;

            openFileDialogReadFile.Multiselect = false;

            if (openFileDialogReadFile.ShowDialog() == DialogResult.OK)
            {
                Filename = openFileDialogReadFile.FileName;
                Filename_Changed = true;
            }

        }

        // Show selected file path on GUI
        private void FilePath_Click(object sender, EventArgs e)
        {
            bool Filename_Changed = false;

            Select_File(ref resultsFile, ref Filename_Changed, fileDirectory);
            resultsFileFullPath = resultsFile;
            if (Filename_Changed) { tbFilePath.Text = resultsFile; };
        }
        private void CBLoadLimitLineTable_CheckedChanged(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\wilattoh\Documents\csharp-Excel.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;


            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                    MessageBox.Show(str);
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
        private void CBEnableLimitTest_CheckedChanged(object sender, EventArgs e)
        {
            if (!CBEnableLimitTest.Checked)
            {
                ComboBLimitLineType.Hide();
                lLimitLineType.Hide();
                GBLimitLine1.Hide();
               
            }
            else
            {
                ComboBLimitLineType.Show();
                lLimitLineType.Show();
                GBLimitLine1.Show();
             }

        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 