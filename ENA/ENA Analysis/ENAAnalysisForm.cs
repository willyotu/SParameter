using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Runtime.InteropServices;

//namespace ENA_Analysis
//{
//    public partial class Form1 : Form
//    {
//        private Excel.Application xlApp;
//        Workbook xlWorkBook;
//        Worksheet xlWorkSheet;
//        int points;
//        public Form1()
//        {
//            InitializeComponent();
//            xlApp = new Excel.Application();
//            tbFilePath.Text = @"C:\Users\wilattoh\Documents\csharp-Excel.xls";
//        }

//        private void bPlotSParameter_Click(object sender, EventArgs e)
//        {
//            PlotSParameter(xlWorkBook, points);
//        }

//        private void CreateExcel()
//        {

//            if (xlApp == null)
//            {
//                MessageBox.Show("Excel is not properly installed!!");
//                return;
//            }


//            object misValue = System.Reflection.Missing.Value;

//            xlWorkBook = xlApp.Workbooks.Add(misValue);
//            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

//            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
//            xlWorkBook.Close(true, misValue, misValue);
//            xlApp.Quit();

//            Marshal.ReleaseComObject(xlWorkSheet);
//            Marshal.ReleaseComObject(xlWorkBook);
//            Marshal.ReleaseComObject(xlApp);
//        }

//        private void ReleaseObject(object obj)
//        {
//            try
//            {
//                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
//                obj = null;
//            }
//            catch (Exception ex)
//            {
//                obj = null;
//                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
//            }
//            finally
//            {
//                GC.Collect();
//            }
//        }



//        private void PlotSParameter(Workbook xlWorkBook, int points)
//        {
//            Range oRng;
//            xlWorkBook = xlApp.Workbooks.Open(tbFilePath.Text, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

//            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

//            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
//            ChartObject myChart = (Excel.ChartObject)xlCharts.Add(700, 50, 300, 300);
//            Chart chart = myChart.Chart;
//            oRng = xlWorkSheet.Range["A1:A" + points + ",B1:B" + points + ""];
//            chart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
//            chart.ChartStyle = 7;
//            chart.ChartWizard(Source: oRng, Title: "S Parameter", HasLegend: true);
//            chart.ChartType = XlChartType.xlLine;
//            Axis axisS21 = (Axis)chart.Axes(XlAxisType.xlValue);
//            axisS21.TickLabels.NumberFormat = "#,##0.00";
//            axisS21.MaximumScale = 20;
//            axisS21.MinimumScale = -140;
//            axisS21.HasMajorGridlines = false;
//            Axis axisCatS21 = (Axis)chart.Axes(XlAxisType.xlCategory);
//            axisCatS21.TickLabels.NumberFormat = "0.00E+00";
//            axisCatS21.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;
//        }

//        // Select a file from directory using File browser and show selected file path on GUI
//        private void bFilePath_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                SaveFileDialog SaveFileDialog = new SaveFileDialog();
//                SaveFileDialog.InitialDirectory = @"C:\";
//                SaveFileDialog.Title = "Save Text Files";
//                SaveFileDialog.CheckFileExists = true;
//                SaveFileDialog.CheckPathExists = true;


//                SaveFileDialog.DefaultExt = "xls";
//                SaveFileDialog.Filter = "Excel files (*.xls)|*.xls|All files(*.*)|*.*";
//                SaveFileDialog.FilterIndex = 2;
//                SaveFileDialog.RestoreDirectory = true;
//                //openFileDialog.ReadOnlyChecked = true;
//                //openFileDialog.ShowReadOnly = true;

//                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    tbFilePath.Text = SaveFileDialog.FileName;
//                }

//            }
//            catch (Exception error)
//            {

//                MessageBox.Show(error.Message);
//            }
//        }
//    }
//}
