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
using System.Threading;

namespace ENA
{
    public partial class ENAForm : Form
    {
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;
        private AgENA_E5071 eNA;
        private Excel.Application xlApp;
        private BackgroundWorker myWorker = new BackgroundWorker();

        bool bStopClicked = false;

        public ENAForm(string visaAddress)
        {
            InitializeComponent();
          //  ENAForm.CheckForIllegalCrossThreadCalls = false; // this is bad!
            eNA = new AgENA_E5071(visaAddress);
            xlApp = new Excel.Application();
            myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            myWorker.WorkerReportsProgress = true;
            myWorker.WorkerSupportsCancellation = true;

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
            
            CBEnableLimitTest.Checked = true;
            CBBeeperWarning.Checked = false;
            
            GBPeakSearch.Show();
            GBLimitLine.Show();
       
            TBLimit1StartFrequency.Text = "1e9";
            TBLimit1StopFrequency.Text  = "1.1e9";
            TBLimitStartAmplitude.Text = "-30";

            nudInterval.Value = 10;
     
            bStop.Click += new System.EventHandler(bStop_Click);
         

            tbFilePath.Text = @"C:\Users\wilattoh\Documents\csharp-Excel.xls";
            string excelName = tbFilePath.Text;

        }
               
        private void ENAForm_Load(object sender, EventArgs e)
        {
            MeasurementSetup();
        }
        
        #region Stimulus Tab
        private void MeasurementSetup()
        {
            eNA.SCPI.SYSTem.PRESet.Command();
            eNA.SCPI.SENSe.SWEep.POINts.Command(1, Convert.ToInt32(Points));
            eNA.SCPI.SENSe.FREQuency.STARt.Command(1, Convert.ToDouble(StartFrequency));
            eNA.SCPI.SENSe.FREQuency.STOP.Command(1, Convert.ToDouble(StopFrequency));
            eNA.SCPI.SENSe.BANDwidth.RESolution.Command(1, Convert.ToDouble(IFBW));
            eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, 1, SParameter);
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
        #endregion

        #region Measurement Tab
        private void SParameterMeasurement()
        {
            try
            {
                //bRun.Enabled = false;
                double limitline1StartF = Convert.ToDouble(startFrequencyTB.Text);
                double limitline1StopF = Convert.ToDouble(stopFrequencyTB.Text);
                double limitline1Amplitude = Convert.ToDouble(TBLimitStartAmplitude.Text);
               

                eNA.SCPI.SENSe.SWEep.POINts.Command(1, Convert.ToInt32(Points));
                eNA.SCPI.SENSe.FREQuency.STARt.Command(1, Convert.ToDouble(StartFrequency));
                eNA.SCPI.SENSe.FREQuency.STOP.Command(1, Convert.ToDouble(StopFrequency));
                eNA.SCPI.SENSe.BANDwidth.RESolution.Command(1, Convert.ToDouble(IFBW));
                eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, 1, SParameter);
                eNA.SCPI.CALCulate.SELected.LIMit.STATe.Command(1, CBEnableLimitTest.Checked ? "ON" : "OFF");
                eNA.SCPI.CALCulate.SELected.LIMit.DISPlay.STATe.Command(1, true);
                eNA.SCPI.SYSTem.BEEPer.WARNing.STATe.Command(CBBeeperWarning.Checked);

                

                eNA.SCPI.CALCulate.SELected.LIMit.DATA.CommandAsciiReal(1,
                    new double[]
                    {
                        1, 1, limitline1StartF, limitline1StopF, limitline1Amplitude,
                        limitline1Amplitude
                    });
                eNA.SCPI.CALCulate.SELected.FUNCtion.TYPE.Command(1u, "MAXimum");
                eNA.SCPI.CALCulate.SELected.FUNCtion.EXECute.Command(1u);

                //bRun.Enabled = true;
              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        // Choose excel file to save.
        private void bFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog = new SaveFileDialog();
                SaveFileDialog.InitialDirectory = @"C:\";
                SaveFileDialog.Title = "Save Text Files";
                SaveFileDialog.CheckFileExists = true;
                SaveFileDialog.CheckPathExists = true;


                SaveFileDialog.DefaultExt = "xls";
                SaveFileDialog.Filter = "Excel files (*.xls)|*.xls|All files(*.*)|*.*";
                SaveFileDialog.FilterIndex = 2;
                SaveFileDialog.RestoreDirectory = true;
                //openFileDialog.ReadOnlyChecked = true;
                //openFileDialog.ShowReadOnly = true;

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilePath.Text = SaveFileDialog.FileName;
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

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
                GBLimitLine.Hide();
                GBPeakSearch.Hide();

            }
            else
            {
                GBLimitLine.Show();
                GBPeakSearch.Show();
            }
            

        }

       
        // Run Button
        //private void bRun_Click(object sender, EventArgs e)
        //{

        //    while (!bStopClicked)
        //    {
        //        SParameterMeasurement();
        //        System.Windows.Forms.Application.DoEvents();
        //        SaveSParameterExcel();
        //        System.Windows.Forms.Application.DoEvents();
        //        Timing();
        //        System.Windows.Forms.Application.DoEvents();

        //    }
        //}

        private void bRun_Click(object sender, EventArgs e)
        {

            if (!myWorker.IsBusy)//Check if the worker is already in progress
            {
                bRun.Enabled = false;//Disable the Start button
                myWorker.RunWorkerAsync();//Call the background worker
            }

        }

        private void bStop_Click(object sender, EventArgs e)
        {
           // bStopClicked = true;
            myWorker.CancelAsync();//Issue a cancellation request to stop the background worker
        }

        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker sendingWorker = (BackgroundWorker)sender;//Capture the BackgroundWorker that fired the event

            while (!e.Cancel)//Continue measurement till  stop button clicked
            {
                if (!sendingWorker.CancellationPending)//At each iteration of the loop, check if there is a cancellation request pending 
                {
                    SParameterMeasurement();
                    SaveSParameterExcel();
                   // bRun.Enabled = true;
                    Timing();
                }
                else
                {
                    e.Cancel = true;//If a cancellation request is pending, assign this flag a value of true
                    break;         // If a cancellation request is pending, break to exit the loop
                }
             }
        }
    
        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)//Check if the worker has been canceled or if an error occurred
            {

                lblStatus.Text = "Measurement Completed";
            }
            else if (e.Cancelled)
            {
                lblStatus.Text = "User Cancelled";
            }
            else
            {
                lblStatus.Text = "An error has occurred";
            }
            bRun.Enabled = true; // re enable start button

        }

        protected void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Show the progress to the user based on the input we got from the background worker
            lblStatus.Text = string.Format("To to next capture: {0}...", e.ProgressPercentage);
        }


        #endregion
                
        #region Excel functions and Timing
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

            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
        private void ReleaseObject(object obj)
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
        private void SaveSParameterExcel()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;
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
            double[] maxAmplitude;
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

            xlNewSheet.Cells[1, 3] = "Time captured";
            row = 1;
            row = row + 1;
            xlNewSheet.Cells[row, 3] = DateTime.Now;
          // xlNewSheet.Range["C2"].NumberFormat = "yy/MM/d/HH:mm:ss";
            xlNewSheet.Columns.AutoFit();

            xlNewSheet.Cells[1, 4] = "Cut Off Frequency";
            eNA.SCPI.CALCulate.SELected.LIMit.REPort.DATA.QueryAsciiReal(1, out failedPoints);
            row = 1;
            row = row + 1;
            xlNewSheet.Cells[row, 4] = failedPoints[0];


            xlNewSheet.Cells[1, 5] = "Maximum Amplitude";
            eNA.SCPI.CALCulate.SELected.FUNCtion.DATA.QueryAsciiReal(1, out maxAmplitude);
            row = 1;
            row = row + 1;
            xlNewSheet.Cells[row, 5] = maxAmplitude[0];

           

            PlotSParameter(xlWorkBook, points);

            xlNewSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlNewSheet.Select();
            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
                  misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

             xlWorkBook.Close(true, misValue, misValue);
           
            xlApp.Application.Quit();
            xlApp.Quit();
            ReleaseObject(xlNewSheet);
            ReleaseObject(worksheets);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            KillSpecificExcelFileProcess(tbFilePath.Text);
        }
        private void PlotSParameter(Workbook xlWorkBook, int points)
        {
            Range oRng;
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(700, 50, 300, 300);
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
        private void Timing()
        {
            //Create an instance of StopWatch
            Stopwatch watch = new Stopwatch();

            //Start the StopWatch
            watch.Start();

            //Perform Some Action
            System.Threading.Thread.Sleep(Convert.ToInt32(nudInterval.Value) * 1000);

            //Stop the StopWatch
            watch.Stop();

            //Check Elapsed Time
            Console.WriteLine("Time elapsed as per stopwatch: {0} ",

            watch.Elapsed);

        }

        #endregion

        private void KillSpecificExcelFileProcess(string excelName)
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
            {
                if (process.MainWindowTitle == "Microsoft Excel - " + excelName)
                    process.Kill();
            }
        }
        private void ComboBLimitLineType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 