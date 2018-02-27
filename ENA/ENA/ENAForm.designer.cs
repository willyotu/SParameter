namespace ENA
{
    partial class ENAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bFilePath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.bStop = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stimulusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MeasurementTPage = new System.Windows.Forms.TabPage();
            this.lMeasurementDuration = new System.Windows.Forms.Label();
            this.lMeasurementInterval = new System.Windows.Forms.Label();
            this.TPLimitTest = new System.Windows.Forms.TabPage();
            this.CBLoadLimitLineTable = new System.Windows.Forms.CheckBox();
            this.GBLimitLine2 = new System.Windows.Forms.GroupBox();
            this.TBLimit2StopFrequency = new System.Windows.Forms.TextBox();
            this.TBLimit2StopAmplitude = new System.Windows.Forms.TextBox();
            this.TBLimit2StartAmplitude = new System.Windows.Forms.TextBox();
            this.TBLimit2StartFrequency = new System.Windows.Forms.TextBox();
            this.lLimit2StopFrequency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lLimit2StartFrequency = new System.Windows.Forms.Label();
            this.GBLimitLine1 = new System.Windows.Forms.GroupBox();
            this.TBLimit1StopFrequency = new System.Windows.Forms.TextBox();
            this.TBLimit1StopAmplitude = new System.Windows.Forms.TextBox();
            this.TBLimit1StartAmplitude = new System.Windows.Forms.TextBox();
            this.TBLimit1StartFrequency = new System.Windows.Forms.TextBox();
            this.lLimit1StopFrequency = new System.Windows.Forms.Label();
            this.lLimit1StopAmplitude = new System.Windows.Forms.Label();
            this.lLimit1StartAmplitude = new System.Windows.Forms.Label();
            this.lLimit1StartFrequency = new System.Windows.Forms.Label();
            this.ComboBLimitLineType = new System.Windows.Forms.ComboBox();
            this.lLimitLineType = new System.Windows.Forms.Label();
            this.NUDNumberLimitLines = new System.Windows.Forms.NumericUpDown();
            this.lNumberLimitLines = new System.Windows.Forms.Label();
            this.CBEnableLimitTest = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.MeasurementTPage.SuspendLayout();
            this.TPLimitTest.SuspendLayout();
            this.GBLimitLine2.SuspendLayout();
            this.GBLimitLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberLimitLines)).BeginInit();
            this.SuspendLayout();
            // 
            // bFilePath
            // 
            this.bFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilePath.Location = new System.Drawing.Point(15, 135);
            this.bFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(36, 33);
            this.bFilePath.TabIndex = 17;
            this.bFilePath.Text = "FP";
            this.toolTip1.SetToolTip(this.bFilePath, "File Path");
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.FilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(57, 140);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(268, 22);
            this.tbFilePath.TabIndex = 16;
            this.tbFilePath.Text = "C:\\Users\\wilattoh\\Documents\\Results.xlsx";
            this.toolTip1.SetToolTip(this.tbFilePath, "Browse path for .txt file");
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(219, 90);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4);
            this.nudDuration.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(75, 22);
            this.nudDuration.TabIndex = 15;
            this.toolTip1.SetToolTip(this.nudDuration, "Duration in seconds");
            this.nudDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(201, 42);
            this.nudInterval.Margin = new System.Windows.Forms.Padding(4);
            this.nudInterval.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(96, 22);
            this.nudInterval.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nudInterval, "Interval in msecs");
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(153, 247);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(95, 27);
            this.bStop.TabIndex = 11;
            this.bStop.Text = "Stop && Exit";
            this.toolTip1.SetToolTip(this.bStop, "Single click to stop and double click to exit");
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click_1);
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(153, 190);
            this.bRun.Margin = new System.Windows.Forms.Padding(4);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(95, 28);
            this.bRun.TabIndex = 10;
            this.bRun.Text = "Run";
            this.toolTip1.SetToolTip(this.bRun, "Greys out whilst measurement is running");
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stimulusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stimulusToolStripMenuItem
            // 
            this.stimulusToolStripMenuItem.Name = "stimulusToolStripMenuItem";
            this.stimulusToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.stimulusToolStripMenuItem.Text = "Stimulus";
            this.stimulusToolStripMenuItem.Click += new System.EventHandler(this.stimulusToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MeasurementTPage);
            this.TabControl.Controls.Add(this.TPLimitTest);
            this.TabControl.Location = new System.Drawing.Point(0, 31);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(778, 441);
            this.TabControl.TabIndex = 19;
            // 
            // MeasurementTPage
            // 
            this.MeasurementTPage.Controls.Add(this.bFilePath);
            this.MeasurementTPage.Controls.Add(this.tbFilePath);
            this.MeasurementTPage.Controls.Add(this.nudDuration);
            this.MeasurementTPage.Controls.Add(this.lMeasurementDuration);
            this.MeasurementTPage.Controls.Add(this.lMeasurementInterval);
            this.MeasurementTPage.Controls.Add(this.nudInterval);
            this.MeasurementTPage.Controls.Add(this.bStop);
            this.MeasurementTPage.Controls.Add(this.bRun);
            this.MeasurementTPage.Location = new System.Drawing.Point(4, 25);
            this.MeasurementTPage.Name = "MeasurementTPage";
            this.MeasurementTPage.Padding = new System.Windows.Forms.Padding(3);
            this.MeasurementTPage.Size = new System.Drawing.Size(770, 412);
            this.MeasurementTPage.TabIndex = 0;
            this.MeasurementTPage.Text = "Measurement";
            this.MeasurementTPage.UseVisualStyleBackColor = true;
            this.MeasurementTPage.Click += new System.EventHandler(this.MeasurementTPage_Click);
            // 
            // lMeasurementDuration
            // 
            this.lMeasurementDuration.AutoSize = true;
            this.lMeasurementDuration.Location = new System.Drawing.Point(47, 92);
            this.lMeasurementDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMeasurementDuration.Name = "lMeasurementDuration";
            this.lMeasurementDuration.Size = new System.Drawing.Size(152, 17);
            this.lMeasurementDuration.TabIndex = 14;
            this.lMeasurementDuration.Text = "Measurement Duration";
            // 
            // lMeasurementInterval
            // 
            this.lMeasurementInterval.AutoSize = true;
            this.lMeasurementInterval.Location = new System.Drawing.Point(47, 42);
            this.lMeasurementInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMeasurementInterval.Name = "lMeasurementInterval";
            this.lMeasurementInterval.Size = new System.Drawing.Size(144, 17);
            this.lMeasurementInterval.TabIndex = 13;
            this.lMeasurementInterval.Text = "Measurement Interval";
            // 
            // TPLimitTest
            // 
            this.TPLimitTest.Controls.Add(this.CBLoadLimitLineTable);
            this.TPLimitTest.Controls.Add(this.GBLimitLine2);
            this.TPLimitTest.Controls.Add(this.GBLimitLine1);
            this.TPLimitTest.Controls.Add(this.ComboBLimitLineType);
            this.TPLimitTest.Controls.Add(this.lLimitLineType);
            this.TPLimitTest.Controls.Add(this.NUDNumberLimitLines);
            this.TPLimitTest.Controls.Add(this.lNumberLimitLines);
            this.TPLimitTest.Controls.Add(this.CBEnableLimitTest);
            this.TPLimitTest.Location = new System.Drawing.Point(4, 25);
            this.TPLimitTest.Name = "TPLimitTest";
            this.TPLimitTest.Padding = new System.Windows.Forms.Padding(3);
            this.TPLimitTest.Size = new System.Drawing.Size(770, 412);
            this.TPLimitTest.TabIndex = 1;
            this.TPLimitTest.Text = "Limit Test";
            this.TPLimitTest.UseVisualStyleBackColor = true;
            // 
            // CBLoadLimitLineTable
            // 
            this.CBLoadLimitLineTable.AutoSize = true;
            this.CBLoadLimitLineTable.Location = new System.Drawing.Point(478, 17);
            this.CBLoadLimitLineTable.Name = "CBLoadLimitLineTable";
            this.CBLoadLimitLineTable.Size = new System.Drawing.Size(166, 21);
            this.CBLoadLimitLineTable.TabIndex = 7;
            this.CBLoadLimitLineTable.Text = "Load Limit Line Table";
            this.CBLoadLimitLineTable.UseVisualStyleBackColor = true;
            this.CBLoadLimitLineTable.CheckedChanged += new System.EventHandler(this.CBLoadLimitLineTable_CheckedChanged);
            // 
            // GBLimitLine2
            // 
            this.GBLimitLine2.Controls.Add(this.TBLimit2StopFrequency);
            this.GBLimitLine2.Controls.Add(this.TBLimit2StopAmplitude);
            this.GBLimitLine2.Controls.Add(this.TBLimit2StartAmplitude);
            this.GBLimitLine2.Controls.Add(this.TBLimit2StartFrequency);
            this.GBLimitLine2.Controls.Add(this.lLimit2StopFrequency);
            this.GBLimitLine2.Controls.Add(this.label2);
            this.GBLimitLine2.Controls.Add(this.label3);
            this.GBLimitLine2.Controls.Add(this.lLimit2StartFrequency);
            this.GBLimitLine2.Location = new System.Drawing.Point(24, 224);
            this.GBLimitLine2.Name = "GBLimitLine2";
            this.GBLimitLine2.Size = new System.Drawing.Size(620, 105);
            this.GBLimitLine2.TabIndex = 6;
            this.GBLimitLine2.TabStop = false;
            this.GBLimitLine2.Text = "Limit Line 2";
            // 
            // TBLimit2StopFrequency
            // 
            this.TBLimit2StopFrequency.Location = new System.Drawing.Point(164, 67);
            this.TBLimit2StopFrequency.Name = "TBLimit2StopFrequency";
            this.TBLimit2StopFrequency.Size = new System.Drawing.Size(129, 22);
            this.TBLimit2StopFrequency.TabIndex = 1;
            // 
            // TBLimit2StopAmplitude
            // 
            this.TBLimit2StopAmplitude.Location = new System.Drawing.Point(476, 71);
            this.TBLimit2StopAmplitude.Name = "TBLimit2StopAmplitude";
            this.TBLimit2StopAmplitude.Size = new System.Drawing.Size(129, 22);
            this.TBLimit2StopAmplitude.TabIndex = 1;
            // 
            // TBLimit2StartAmplitude
            // 
            this.TBLimit2StartAmplitude.Location = new System.Drawing.Point(476, 30);
            this.TBLimit2StartAmplitude.Name = "TBLimit2StartAmplitude";
            this.TBLimit2StartAmplitude.Size = new System.Drawing.Size(129, 22);
            this.TBLimit2StartAmplitude.TabIndex = 1;
            // 
            // TBLimit2StartFrequency
            // 
            this.TBLimit2StartFrequency.Location = new System.Drawing.Point(164, 21);
            this.TBLimit2StartFrequency.Name = "TBLimit2StartFrequency";
            this.TBLimit2StartFrequency.Size = new System.Drawing.Size(129, 22);
            this.TBLimit2StartFrequency.TabIndex = 1;
            // 
            // lLimit2StopFrequency
            // 
            this.lLimit2StopFrequency.AutoSize = true;
            this.lLimit2StopFrequency.Location = new System.Drawing.Point(6, 71);
            this.lLimit2StopFrequency.Name = "lLimit2StopFrequency";
            this.lLimit2StopFrequency.Size = new System.Drawing.Size(108, 17);
            this.lLimit2StopFrequency.TabIndex = 0;
            this.lLimit2StopFrequency.Text = "Stop Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stop Amplitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Amplitude";
            // 
            // lLimit2StartFrequency
            // 
            this.lLimit2StartFrequency.AutoSize = true;
            this.lLimit2StartFrequency.Location = new System.Drawing.Point(6, 29);
            this.lLimit2StartFrequency.Name = "lLimit2StartFrequency";
            this.lLimit2StartFrequency.Size = new System.Drawing.Size(109, 17);
            this.lLimit2StartFrequency.TabIndex = 0;
            this.lLimit2StartFrequency.Text = "Start Frequency";
            // 
            // GBLimitLine1
            // 
            this.GBLimitLine1.Controls.Add(this.TBLimit1StopFrequency);
            this.GBLimitLine1.Controls.Add(this.TBLimit1StopAmplitude);
            this.GBLimitLine1.Controls.Add(this.TBLimit1StartAmplitude);
            this.GBLimitLine1.Controls.Add(this.TBLimit1StartFrequency);
            this.GBLimitLine1.Controls.Add(this.lLimit1StopFrequency);
            this.GBLimitLine1.Controls.Add(this.lLimit1StopAmplitude);
            this.GBLimitLine1.Controls.Add(this.lLimit1StartAmplitude);
            this.GBLimitLine1.Controls.Add(this.lLimit1StartFrequency);
            this.GBLimitLine1.Location = new System.Drawing.Point(24, 113);
            this.GBLimitLine1.Name = "GBLimitLine1";
            this.GBLimitLine1.Size = new System.Drawing.Size(620, 105);
            this.GBLimitLine1.TabIndex = 5;
            this.GBLimitLine1.TabStop = false;
            this.GBLimitLine1.Text = "Limit Line 1";
            // 
            // TBLimit1StopFrequency
            // 
            this.TBLimit1StopFrequency.Location = new System.Drawing.Point(164, 67);
            this.TBLimit1StopFrequency.Name = "TBLimit1StopFrequency";
            this.TBLimit1StopFrequency.Size = new System.Drawing.Size(129, 22);
            this.TBLimit1StopFrequency.TabIndex = 1;
            // 
            // TBLimit1StopAmplitude
            // 
            this.TBLimit1StopAmplitude.Location = new System.Drawing.Point(476, 71);
            this.TBLimit1StopAmplitude.Name = "TBLimit1StopAmplitude";
            this.TBLimit1StopAmplitude.Size = new System.Drawing.Size(129, 22);
            this.TBLimit1StopAmplitude.TabIndex = 1;
            // 
            // TBLimit1StartAmplitude
            // 
            this.TBLimit1StartAmplitude.Location = new System.Drawing.Point(476, 30);
            this.TBLimit1StartAmplitude.Name = "TBLimit1StartAmplitude";
            this.TBLimit1StartAmplitude.Size = new System.Drawing.Size(129, 22);
            this.TBLimit1StartAmplitude.TabIndex = 1;
            // 
            // TBLimit1StartFrequency
            // 
            this.TBLimit1StartFrequency.Location = new System.Drawing.Point(164, 21);
            this.TBLimit1StartFrequency.Name = "TBLimit1StartFrequency";
            this.TBLimit1StartFrequency.Size = new System.Drawing.Size(129, 22);
            this.TBLimit1StartFrequency.TabIndex = 1;
            // 
            // lLimit1StopFrequency
            // 
            this.lLimit1StopFrequency.AutoSize = true;
            this.lLimit1StopFrequency.Location = new System.Drawing.Point(6, 71);
            this.lLimit1StopFrequency.Name = "lLimit1StopFrequency";
            this.lLimit1StopFrequency.Size = new System.Drawing.Size(108, 17);
            this.lLimit1StopFrequency.TabIndex = 0;
            this.lLimit1StopFrequency.Text = "Stop Frequency";
            // 
            // lLimit1StopAmplitude
            // 
            this.lLimit1StopAmplitude.AutoSize = true;
            this.lLimit1StopAmplitude.Location = new System.Drawing.Point(351, 67);
            this.lLimit1StopAmplitude.Name = "lLimit1StopAmplitude";
            this.lLimit1StopAmplitude.Size = new System.Drawing.Size(103, 17);
            this.lLimit1StopAmplitude.TabIndex = 0;
            this.lLimit1StopAmplitude.Text = "Stop Amplitude";
            // 
            // lLimit1StartAmplitude
            // 
            this.lLimit1StartAmplitude.AutoSize = true;
            this.lLimit1StartAmplitude.Location = new System.Drawing.Point(351, 30);
            this.lLimit1StartAmplitude.Name = "lLimit1StartAmplitude";
            this.lLimit1StartAmplitude.Size = new System.Drawing.Size(104, 17);
            this.lLimit1StartAmplitude.TabIndex = 0;
            this.lLimit1StartAmplitude.Text = "Start Amplitude";
            // 
            // lLimit1StartFrequency
            // 
            this.lLimit1StartFrequency.AutoSize = true;
            this.lLimit1StartFrequency.Location = new System.Drawing.Point(6, 29);
            this.lLimit1StartFrequency.Name = "lLimit1StartFrequency";
            this.lLimit1StartFrequency.Size = new System.Drawing.Size(109, 17);
            this.lLimit1StartFrequency.TabIndex = 0;
            this.lLimit1StartFrequency.Text = "Start Frequency";
            // 
            // ComboBLimitLineType
            // 
            this.ComboBLimitLineType.FormattingEnabled = true;
            this.ComboBLimitLineType.Items.AddRange(new object[] {
            "Select Limit  Type",
            "Upper Limit",
            "Lower Limit"});
            this.ComboBLimitLineType.Location = new System.Drawing.Point(188, 83);
            this.ComboBLimitLineType.Name = "ComboBLimitLineType";
            this.ComboBLimitLineType.Size = new System.Drawing.Size(123, 24);
            this.ComboBLimitLineType.TabIndex = 4;
            // 
            // lLimitLineType
            // 
            this.lLimitLineType.AutoSize = true;
            this.lLimitLineType.Location = new System.Drawing.Point(27, 83);
            this.lLimitLineType.Name = "lLimitLineType";
            this.lLimitLineType.Size = new System.Drawing.Size(120, 17);
            this.lLimitLineType.TabIndex = 3;
            this.lLimitLineType.Text = "Type of Limit Line";
            // 
            // NUDNumberLimitLines
            // 
            this.NUDNumberLimitLines.Location = new System.Drawing.Point(188, 48);
            this.NUDNumberLimitLines.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDNumberLimitLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumberLimitLines.Name = "NUDNumberLimitLines";
            this.NUDNumberLimitLines.Size = new System.Drawing.Size(58, 22);
            this.NUDNumberLimitLines.TabIndex = 2;
            this.NUDNumberLimitLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumberLimitLines.ValueChanged += new System.EventHandler(this.NUDNumberLimitLines_ValueChanged_1);
            // 
            // lNumberLimitLines
            // 
            this.lNumberLimitLines.AutoSize = true;
            this.lNumberLimitLines.Location = new System.Drawing.Point(24, 50);
            this.lNumberLimitLines.Name = "lNumberLimitLines";
            this.lNumberLimitLines.Size = new System.Drawing.Size(145, 17);
            this.lNumberLimitLines.TabIndex = 1;
            this.lNumberLimitLines.Text = "Number of Limit Lines";
            // 
            // CBEnableLimitTest
            // 
            this.CBEnableLimitTest.AutoSize = true;
            this.CBEnableLimitTest.Location = new System.Drawing.Point(24, 17);
            this.CBEnableLimitTest.Name = "CBEnableLimitTest";
            this.CBEnableLimitTest.Size = new System.Drawing.Size(139, 21);
            this.CBEnableLimitTest.TabIndex = 0;
            this.CBEnableLimitTest.Text = "Enable Limit Test";
            this.CBEnableLimitTest.UseVisualStyleBackColor = true;
            this.CBEnableLimitTest.CheckedChanged += new System.EventHandler(this.CBEnableLimitTest_CheckedChanged);
            // 
            // ENAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 609);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ENAForm";
            this.Text = "ENA Measurement";
            this.Load += new System.EventHandler(this.ENAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.MeasurementTPage.ResumeLayout(false);
            this.MeasurementTPage.PerformLayout();
            this.TPLimitTest.ResumeLayout(false);
            this.TPLimitTest.PerformLayout();
            this.GBLimitLine2.ResumeLayout(false);
            this.GBLimitLine2.PerformLayout();
            this.GBLimitLine1.ResumeLayout(false);
            this.GBLimitLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberLimitLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stimulusToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MeasurementTPage;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lMeasurementDuration;
        private System.Windows.Forms.Label lMeasurementInterval;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TPLimitTest;
        private System.Windows.Forms.GroupBox GBLimitLine1;
        private System.Windows.Forms.TextBox TBLimit1StopFrequency;
        private System.Windows.Forms.TextBox TBLimit1StartAmplitude;
        private System.Windows.Forms.TextBox TBLimit1StartFrequency;
        private System.Windows.Forms.Label lLimit1StopFrequency;
        private System.Windows.Forms.Label lLimit1StopAmplitude;
        private System.Windows.Forms.Label lLimit1StartAmplitude;
        private System.Windows.Forms.Label lLimit1StartFrequency;
        private System.Windows.Forms.ComboBox ComboBLimitLineType;
        private System.Windows.Forms.Label lLimitLineType;
        private System.Windows.Forms.NumericUpDown NUDNumberLimitLines;
        private System.Windows.Forms.Label lNumberLimitLines;
        private System.Windows.Forms.CheckBox CBEnableLimitTest;
        private System.Windows.Forms.GroupBox GBLimitLine2;
        private System.Windows.Forms.TextBox TBLimit2StopFrequency;
        private System.Windows.Forms.TextBox TBLimit2StopAmplitude;
        private System.Windows.Forms.TextBox TBLimit2StartAmplitude;
        private System.Windows.Forms.TextBox TBLimit2StartFrequency;
        private System.Windows.Forms.Label lLimit2StopFrequency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lLimit2StartFrequency;
        private System.Windows.Forms.TextBox TBLimit1StopAmplitude;
        private System.Windows.Forms.CheckBox CBLoadLimitLineTable;
    }
}

