using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Analysis
{
    public partial class AnalysisForm : Form
    {
        Workbook xlWorkBook;
        Worksheet xlWorkSheet;
        Range timeCellRange;
        Range cutOffFreqencyCellRange;
        Range maxAmplitudeCellRange;
        Range oRng;
        string ActWsName;
        string ActAddress;

        private Excel.Application xlApp;
        public AnalysisForm()
        {
            InitializeComponent();
            tbFilePath.Text = @"C:\Users\wilattoh\Documents\csharp-Excel.xls";
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {

        }

        private void PlotOverDay()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            int points = 401;
            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;

            object misValue = System.Reflection.Missing.Value;

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlWorkSheet.Name = DateTime.Now.ToString("yyMMddHHmmss");
            string currentDay = DateTime.Now.ToString("yyyyMMdd");


            timeCellRange = xlWorkSheet.Application.Cells[2, 3];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets timeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = timeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex = 0;
            List<string> iList = new List<string>();
            foreach (Worksheet Ws in timeExcel)
            {
                if ((Ws.Name.StartsWith(currentDay)))   
                {
                   timeCellRange.Offset[xIndex, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex = (xIndex + 1);
                }

            }

            xlWorkSheet.Application.ScreenUpdating = true;


            // Get cut off Frequency in each sheet
            cutOffFreqencyCellRange = xlWorkSheet.Application.Cells[2, 4];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets cutoffFrequencyExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = cutOffFreqencyCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex2 = 0;
            foreach (Worksheet Ws in cutoffFrequencyExcel)
            {
                if ((Ws.Name.StartsWith(currentDay)))
                {
                    cutOffFreqencyCellRange.Offset[xIndex2, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex2 = (xIndex2 + 1);
                }

            }

            xlWorkSheet.Application.ScreenUpdating = true;

            // Get max amplitude in each sheet
            maxAmplitudeCellRange = xlWorkSheet.Application.Cells[2, 5];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets amplitudeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = maxAmplitudeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex3 = 0;
            foreach (Worksheet Ws in amplitudeExcel)
            {
                if ((Ws.Name.StartsWith(currentDay)))
                {
                    maxAmplitudeCellRange.Offset[xIndex3, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex3 = (xIndex3 + 1);
                }
            }
            xlWorkSheet.Application.ScreenUpdating = true;


            // Plot Maximum Amplitude
            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(700, 50, 300, 300);
            Chart maxAmplitudeChart = myChart.Chart;

            oRng = xlWorkSheet.Range["C2:C" + 201 + ",E2:E" + 201 + ""];

            maxAmplitudeChart.ChartWizard(Source: oRng, Title: "Max Amplitude Trend", HasLegend: true);
            maxAmplitudeChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;

            // Y Axis
            Axis amplitudeMaxAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlValue);
            amplitudeMaxAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlCategory);
            timeAxis.TickLabels.NumberFormat = "h:mm:ss";
            timeAxis.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;


            // Plot CutOff Frequency
            ChartObjects xlCharts2 = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart2 = xlCharts2.Add(700, 400, 300, 300);
            Chart cutoFFFrequencyChart = myChart2.Chart;

            oRng = xlWorkSheet.Range["C2:C" + 201 + ",D2:D" + 201 + ""];
            cutoFFFrequencyChart.ChartWizard(Source: oRng, Title: "CutOff Frequency Trend", HasLegend: true);
            cutoFFFrequencyChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            // Y Axis
            Axis cutOffFrequencyAxis = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlValue);
            cutOffFrequencyAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis2 = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlCategory);
            timeAxis2.TickLabels.NumberFormat = "h:mm:ss";
            timeAxis2.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;




            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
            misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Application.Quit();
            xlApp.Quit();

            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            MessageBox.Show("Plot created");



        }
        private void PlotOverWeek()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            int points = 401;
            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;

            object misValue = System.Reflection.Missing.Value;

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlWorkSheet.Name = DateTime.Now.ToString("yyMMddHHmmss");
          


            timeCellRange = xlWorkSheet.Application.Cells[2, 3];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets timeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = timeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex = 0;
            
            foreach (Worksheet Ws in timeExcel)
            {
                if ((Ws.Name != ActWsName))
                { 
                    var wsName = Ws.Name.ToString();
                    var year = string.Concat(wsName[0], wsName[1], wsName[2], wsName[3]);
                    var month = string.Concat(wsName[4], wsName[5]);
                    var day = string.Concat(wsName[6], wsName[7]); ;

                    DateTime today = DateTime.Now;
                    DateTime wsNamedate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));

                    var timeDifference = DateTime.Now.Subtract(wsNamedate);
                    var numberOfDays  = timeDifference.Days;

                    if (Convert.ToInt32(numberOfDays) <= 7) 
                    {
                        timeCellRange.Offset[xIndex, 0].Value = ("=\'"+ (Ws.Name + ("\'!" + ActAddress)));
                        xIndex = (xIndex + 1);
                    }

                }

            }

            xlWorkSheet.Application.ScreenUpdating = true;


            // Get cut off Frequency in each sheet
            cutOffFreqencyCellRange = xlWorkSheet.Application.Cells[2, 4];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets cutoffFrequencyExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = cutOffFreqencyCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex2 = 0;
            foreach (Worksheet Ws in timeExcel)
            {
                if ((Ws.Name != ActWsName))
                {
                    var wsName = Ws.Name.ToString();
                    var year = string.Concat(wsName[0], wsName[1], wsName[2], wsName[3]);
                    var month = string.Concat(wsName[4], wsName[5]);
                    var day = string.Concat(wsName[6], wsName[7]); ;

                    DateTime today = DateTime.Now;
                    DateTime wsNamedate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));

                    var timeDifference = DateTime.Now.Subtract(wsNamedate);
                    var numberOfDays = timeDifference.Days;

                        if (Convert.ToInt32(numberOfDays) <= 7)
                        {
                        
                            cutOffFreqencyCellRange.Offset[xIndex2, 0].Value = ("=\'"
                                        + (Ws.Name + ("\'!" + ActAddress)));
                            xIndex2 = (xIndex2 + 1);
                        }
                    }
                }
                    xlWorkSheet.Application.ScreenUpdating = true;

            // Get max amplitude in each sheet
            maxAmplitudeCellRange = xlWorkSheet.Application.Cells[2, 5];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets amplitudeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = maxAmplitudeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex3 = 0;
            foreach (Worksheet Ws in amplitudeExcel)
            { 
                if ((Ws.Name != ActWsName))
                {
                    var wsName = Ws.Name.ToString();
                    var year = string.Concat(wsName[0], wsName[1], wsName[2], wsName[3]);
                    var month = string.Concat(wsName[4], wsName[5]);
                    var day = string.Concat(wsName[6], wsName[7]); ;

                    DateTime today = DateTime.Now;
                    DateTime wsNamedate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));

                    var timeDifference = DateTime.Now.Subtract(wsNamedate);
                    var numberOfDays = timeDifference.Days;

                    if (Convert.ToInt32(numberOfDays) <= 7)
                    {
                        maxAmplitudeCellRange.Offset[xIndex3, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                        xIndex3 = (xIndex3 + 1);
                    }
                }
            }
            xlWorkSheet.Application.ScreenUpdating = true;


            // Plot Maximum Amplitude
            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(700, 50, 300, 300);
            Chart maxAmplitudeChart = myChart.Chart;

            oRng = xlWorkSheet.Range["C2:C" + 201 + ",E2:E" + 201 + ""];

            maxAmplitudeChart.ChartWizard(Source: oRng, Title: "Max Amplitude Trend", HasLegend: true);
            maxAmplitudeChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;

            // Y Axis
            Axis amplitudeMaxAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlValue);
            amplitudeMaxAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlCategory);
           // timeAxis.TickLabels.NumberFormat = "[$-409]m/d/yy h:mm AM/PM;@";
            timeAxis.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;


            // Plot CutOff Frequency
            ChartObjects xlCharts2 = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart2 = xlCharts2.Add(700, 400, 300, 300);
            Chart cutoFFFrequencyChart = myChart2.Chart;

            oRng = xlWorkSheet.Range["C2:C" + 201 + ",D2:D" + 201 + ""];
            cutoFFFrequencyChart.ChartWizard(Source: oRng, Title: "CutOff Frequency Trend", HasLegend: true);
            cutoFFFrequencyChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            // Y Axis
            Axis cutOffFrequencyAxis = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlValue);
            cutOffFrequencyAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis2 = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlCategory);
           // timeAxis2.TickLabels.NumberFormat = "[$-409]m/d/yy h:mm AM/PM;@";
            timeAxis2.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;



            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
            misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Application.Quit();
            xlApp.Quit();

            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            MessageBox.Show("Plot created");


            //if (xlWorkSheet.Name.Contains(DateTime.Now.ToString("yyMMdd")))
            //{
            //    //DateTime d1 = new DateTime("yyMMdd");
            //    //d1.Subtract(d2);

            //    //DateTime myValue = Now();
            //    //DateTime myBirthdate = new DateTime(1969, 12, 7);
            //    //TimeSpan myAge;
            //    //Date.Now.Subtract(myBirthdate);
            //    //myAge = myAge.Add(new TimeSpan(100, 0, 0, 0));
            //    //Console.WriteLine(myAge.TotalDays);
            //    //Console.ReadLine();

            //}

        }

        private void ListSheets()
        {
            //int index = 0;

            //Microsoft.Office.Tools.Excel.NamedRange NamedRange1 =
            //    Globals.Sheet1.Controls.AddNamedRange(
            //    Globals.Sheet1.Range["A1"], "NamedRange1");

            //foreach (Excel.Worksheet displayWorksheet in Globals.ThisWorkbook.Worksheets)
            //{
            //    NamedRange1.Offset[index, 0].Value2 = displayWorksheet.Name;
            //    index++;
            //}
        }

        public void PlotsOverTime()
        {
      
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            int points = 401;
            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;

            object misValue = System.Reflection.Missing.Value;
          
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlWorkSheet.Name = DateTime.Now.ToString("yyMMddHHmmss");

            // Get time in each sheet
            timeCellRange = xlWorkSheet.Application.Cells[2, 3];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets timeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = timeCellRange.Address[false,false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int  xIndex = 0;
            foreach (Worksheet Ws in timeExcel )
            {
                if ((Ws.Name != ActWsName))
                {
                    timeCellRange.Offset[xIndex, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex = (xIndex + 1);
                }

            }

            xlWorkSheet.Application.ScreenUpdating = true;

            // Get cut off Frequency in each sheet
            cutOffFreqencyCellRange = xlWorkSheet.Application.Cells[2, 4];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets cutoffFrequencyExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = cutOffFreqencyCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex2 = 0;
            foreach (Worksheet Ws in cutoffFrequencyExcel)
            {
                if ((Ws.Name != ActWsName))
                {
                    cutOffFreqencyCellRange.Offset[xIndex2, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex2 = (xIndex2 + 1);
                }

            }

            xlWorkSheet.Application.ScreenUpdating = true;

            // Get max amplitude in each sheet
            maxAmplitudeCellRange =xlWorkSheet.Application.Cells[2,5];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets amplitudeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = maxAmplitudeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex3 = 0;
            foreach (Worksheet Ws in amplitudeExcel)
            {
                if ((Ws.Name != ActWsName))
                {
                    maxAmplitudeCellRange.Offset[xIndex3, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex3 = (xIndex3 + 1);
                }
            }
            xlWorkSheet.Application.ScreenUpdating = true;


            // Plot Maximum Amplitude
            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(700, 50, 300, 300);
            Chart maxAmplitudeChart = myChart.Chart;
                
            oRng = xlWorkSheet.Range["C2:C" + 201 + ",E2:E" +201+""];

            maxAmplitudeChart.ChartWizard(Source: oRng, Title: "Max Amplitude Trend", HasLegend: true);
            maxAmplitudeChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;

            // Y Axis
            Axis amplitudeMaxAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlValue);
            amplitudeMaxAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis = (Axis)maxAmplitudeChart.Axes(XlAxisType.xlCategory);
            timeAxis.TickLabels.NumberFormat = "h:mm:ss"; 
            timeAxis.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;


            // Plot CutOff Frequency
            ChartObjects xlCharts2 = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart2 = xlCharts2.Add(700, 400, 300, 300);
            Chart cutoFFFrequencyChart = myChart2.Chart;
            
            oRng = xlWorkSheet.Range["C2:C" + 201 + ",D2:D" + 201 + ""];
            cutoFFFrequencyChart.ChartWizard(Source: oRng, Title: "CutOff Frequency Trend", HasLegend: true);
            cutoFFFrequencyChart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            // Y Axis
            Axis cutOffFrequencyAxis = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlValue);
            cutOffFrequencyAxis.HasMajorGridlines = false;

            // X Axis
            Axis timeAxis2 = (Axis)cutoFFFrequencyChart.Axes(XlAxisType.xlCategory);
            timeAxis2.TickLabels.NumberFormat = "h:mm:ss"; 
            timeAxis2.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;

            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
             misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Application.Quit();
            xlApp.Quit();

            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            MessageBox.Show("Plot created");
        }
        private void PlotSParameter()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            int points = 401;
            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;
            
            object misValue = System.Reflection.Missing.Value;
            
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            Range oRng;
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            ChartObject myChart = xlCharts.Add(700, 50, 300, 300);
            Chart chart = myChart.Chart;
            oRng = xlWorkSheet.Range["A1:A" + points + ",B1:B" + points + ""];
            chart.ChartType = XlChartType.xlXYScatterSmoothNoMarkers;
            chart.ChartStyle = 7;
            chart.ChartWizard(Source: oRng, Title: "SParameter", HasLegend: true);
            chart.ChartType = XlChartType.xlLine;
            Axis axisS21 = (Axis)chart.Axes(XlAxisType.xlValue);
            axisS21.TickLabels.NumberFormat = "#,##0.00";
            axisS21.MaximumScale = 20;
            axisS21.MinimumScale = -140;
            axisS21.HasMajorGridlines = false;
            Axis axisCatS21 = (Axis)chart.Axes(XlAxisType.xlCategory);
            axisCatS21.TickLabels.NumberFormat = "0.00E+00";
            axisCatS21.TickLabelPosition = XlTickLabelPosition.xlTickLabelPositionHigh;

            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
                  misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Application.Quit();
            xlApp.Quit();
           
            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            MessageBox.Show("Plot created");
        }

        private void AverageCutOffFrequency()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            int points = 401;
            xlApp.DisplayAlerts = false;
            string filePath = tbFilePath.Text;

            object misValue = System.Reflection.Missing.Value;

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[1], Type.Missing, Type.Missing, Type.Missing);
            xlWorkSheet.Name = DateTime.Now.ToString("yyMMddHHmmss");

            // Get max amplitude in each sheet
            maxAmplitudeCellRange = xlWorkSheet.Application.Cells[2, 5];
            ActWsName = xlWorkSheet.Application.ActiveSheet.Name;
            Sheets amplitudeExcel = xlWorkSheet.Application.Worksheets;
            ActAddress = maxAmplitudeCellRange.Address[false, false];
            xlWorkSheet.Application.ScreenUpdating = false;
            int xIndex3 = 0;
            foreach (Worksheet Ws in amplitudeExcel)
            {
                if ((Ws.Name != ActWsName))
                {
                    maxAmplitudeCellRange.Offset[xIndex3, 0].Value = ("=\'"
                                + (Ws.Name + ("\'!" + ActAddress)));
                    xIndex3 = (xIndex3 + 1);
                }
            }
            xlWorkSheet.Application.ScreenUpdating = true;
            //long fullRow = xlWorkSheet.Rows.Count;
            //long lastRow = xlWorkSheet.Application.Cells[fullRow, 5].End(Excel.XlDirection.xlUp).Row;
           

            int lastUsedRow = xlWorkSheet.Application.Cells.Find("*", System.Reflection.Missing.Value,
                                System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSearchOrder.xlByRows,
                                Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
            int nonEmptyRow = lastUsedRow + 2;

            int lastUsedColumn = xlWorkSheet.Application.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;

            xlWorkSheet.Range["E2:E"+lastUsedRow+""].Select();
        
            xlWorkSheet.Range["E"+ nonEmptyRow + ""].Activate();

            // xlWorkSheet.Application.ActiveCell.FormulaR1C1 = "=AVERAGE(R[-10]C:R[-1]C)";
            xlWorkSheet.Application.ActiveCell.FormulaR1C1 = "=AVERAGE(R[-"+lastUsedRow+"]C:R[-1]C)";
            var averageCutOffFrequency =(xlWorkSheet.Application.Cells[nonEmptyRow,5] as Excel.Range).Value;
            richTextBox1.Text = Math.Round(averageCutOffFrequency,4).ToString();
            
            xlWorkBook.SaveAs(tbFilePath.Text, Excel.XlFileFormat.xlWorkbookNormal,
             misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Application.Quit();
            xlApp.Quit();

            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);
            MessageBox.Show("Plot created");
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

        private void bFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.InitialDirectory = @"C:\";
                OpenFileDialog.Title = "Open Text Files";
                OpenFileDialog.CheckFileExists = true;
                OpenFileDialog.CheckPathExists = true;


                OpenFileDialog.DefaultExt = "xls";
                OpenFileDialog.Filter = "Excel files (*.xls)|*.xls|All files(*.*)|*.*";
                OpenFileDialog.FilterIndex = 2;
                OpenFileDialog.RestoreDirectory = true;
                //openFileDialog.ReadOnlyChecked = true;
                //openFileDialog.ShowReadOnly = true;

                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbFilePath.Text = OpenFileDialog.FileName;
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
                        
        private void bPlotSParameter_Click(object sender, EventArgs e)
        {
            PlotSParameter();
        }

        private void bPlotOverTime_Click(object sender, EventArgs e)
        {
            PlotsOverTime();
        }

        private void bAverageCutOff_Click(object sender, EventArgs e)
        {
            AverageCutOffFrequency();
        }

        private void bPlotOverDay_Click(object sender, EventArgs e)
        {
            PlotOverDay();
        }

        private void bPlotOverWeek_Click(object sender, EventArgs e)
        {
            PlotOverWeek();
        }
    }
}
