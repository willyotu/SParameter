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
using Agilent.CommandExpert.ScpiNet.AgN99xx_NA_A_06_23  ; // Make sure you target .NET Framework 4.5.2 or later
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;




namespace ENA
{
    public partial class ENAForm : Form
    {
        Range oRng;
        Chart chart;
        ChartObjects xlCharts;
        ChartObject myChart;
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;
        private AgN99xx_NA eNA;
        private StimulusSettingsForm stimform;
        private Startup start;
        private Excel.Application xlApp;
        private string resultsFile = "Results.txt";
        private string resultsFileFullPath;
        private string fileDirectory = @"C:\Users\wilattoh\Documents";

        public ENAForm( string visaAddress)
        {
            eNA = new AgN99xx_NA(visaAddress);
            start = new Startup();
            stimform = new StimulusSettingsForm();
            xlApp = new Microsoft.Office.Interop.Excel.Application();
           

            resultsFileFullPath = fileDirectory + @"\" + resultsFile;
            InitializeComponent();

        }

        // Load the ENA Measurement Form 
        private void ENAForm_Load(object sender, EventArgs e)
        {
            MeasurementSetup();
        }

        // Run Button
        private void bRun_Click(object sender, EventArgs e)
        {
            SParamenterMeasurement();
        }

        // Stop Button
        private void bStop_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void MeasurementSetup()
        {
            eNA.SCPI.INSTrument.SELect.Command("NA");
            System.Threading.Thread.Sleep(200);
            eNA.SCPI.DISPlay.WINDow.SPLit.Command("D1");
            eNA.SCPI.SYSTem.PRESet.MODE.Command();
            eNA.SCPI.SENSe.SWEep.POINts.Command(stimform.Points);
            eNA.SCPI.SENSe.FREQuency.STARt.Command(stimform.StartFrequency);
            eNA.SCPI.SENSe.FREQuency.STOP.Command(stimform.StopFrequency);
            eNA.SCPI.SENSe.BWID.Command(stimform.IFBW);
            eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, stimform.SParameter);
        }


        // Measures S Parameter
        private void SParamenterMeasurement()
        {
            try
            {
             
                // Begin timing and start capturing data.
                DateTime startTime = DateTime.Now;
                bRun.Enabled = false;
                double elapsed = 0;
                int elapsedTime = 0;

                double[] result = null;
                double delta = 0;
                double frequencyDelta = 0;
               
                var csv = new StringBuilder();
                int interval = Convert.ToInt32(nudInterval.Value);
                int duration = Convert.ToInt32(nudDuration.Value);

                // Select Phase Noise App, switch to Spot Frequency, Autotune to carrier and fetch data


                eNA.SCPI.SENSe.SWEep.POINts.Command(stimform.Points);
                eNA.SCPI.SENSe.FREQuency.STARt.Command(stimform.StartFrequency);
                eNA.SCPI.SENSe.FREQuency.STOP.Command(stimform.StopFrequency);
                eNA.SCPI.SENSe.BWID.Command(stimform.IFBW);
                eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, stimform.SParameter);
                //eNA.SCPI.CALCulate.SELected.LIMit.STATe.Command("ON");
                //eNA.SCPI.CALCulate.SELected.LIMit.WARN.Command("ON");
                //// Start capturing data for specified duration at requested interval
                //while (elapsedTime < duration)
                //{
                //    DateTime stopTime = DateTime.Now;
                //    elapsed = stopTime.Subtract(startTime).TotalSeconds;
                //    elapsedTime = Convert.ToInt32(elapsed);
                //    eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, stimform.SParameter);
                //    eNA.SCPI.CALCulate.PARameter.SELect.Command(1u);
                //    eNA.SCPI.CALCulate.SELected.LIMit.LLData.Command(new double[] { 1, 1, 1, 0, 2, 30e6, 10, 9e9, 10 });
                //    eNA.SCPI.FORMat.DATA.Command("ASCii", 0);
                //    eNA.SCPI.CALCulate.SELected.DATA.FDATa.QueryAsciiReal(out result);
                //delta = result.ElementAt(3); // Parse only the Frequency Delta.
                //frequencyDelta = Math.Round(delta, 3);
                //System.Threading.Thread.Sleep(interval); // Here we are getting data at specified interval in msecs.
                //var first = frequencyDelta.ToString();
                //var newLine = string.Format("{0}{1}", first, Environment.NewLine);
                //csv.Append(newLine);

                //File.WriteAllText(ResultsFileFullPath, csv.ToString());

                ImportData();


                //CreateExcelSheet();

                // result = FillSpreadsheetData(eNA);

                //Plot S21
               



                System.Windows.Forms.Application.DoEvents();
              //  }
                bRun.Enabled = true;
                MessageBox.Show("Measurement Completed");

            }
            catch (Exception e)
            {

                MessageBox.Show("Check VISA Address \n{0}" + e);
            }

        }

       

       

        private void CreateExcel()
        {
            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

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

            xlNewSheet.Cells[1, 2] = stimform.SParameter;
            eNA.SCPI.CALCulate.PARameter.DEFine.Command(1, stimform.SParameter);
            eNA.SCPI.CALCulate.PARameter.SELect.Command(1u);
            eNA.SCPI.FORMat.DATA.Command("ASCii", 0);
            eNA.SCPI.CALCulate.SELected.DATA.FDATa.QueryAsciiReal(out results);

            row = 1;
            foreach (double result in results)
            {
                Convert.ToString(result);
                row = (row + 1);
                xlNewSheet.Cells[row, 2] = result;
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
            oRng = xlWorkSheet.Range["A1:A" + points + ",C1:C" + points + ""];
            chart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            chart.ChartStyle = 7;
            chart.ChartWizard(Source: oRng, Title: stimform.SParameter, HasLegend: true);
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

        private void stimulusToolStripMenuItem_Click(object sender, EventArgs e)
        {
           stimform.MdiParent = this;
            if (stimform.IsDisposed)
            {
                stimform = new StimulusSettingsForm();
            }

            stimform.Show();
            stimform.Left = (this.Width
                             - (stimform.Width - 20));
        }
    }
}
