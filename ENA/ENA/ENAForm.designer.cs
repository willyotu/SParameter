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
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.bStop = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MeasurementTPage = new System.Windows.Forms.TabPage();
            this.GBStimulusSetup = new System.Windows.Forms.GroupBox();
            this.pointsNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.sParameterTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ifBWTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopFrequencyTB = new System.Windows.Forms.TextBox();
            this.startFrequencyTB = new System.Windows.Forms.TextBox();
            this.TPLimitTest = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSaveToDB = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.GBLimitLine = new System.Windows.Forms.GroupBox();
            this.TBLimitStartAmplitude = new System.Windows.Forms.TextBox();
            this.lLimitAmplitude = new System.Windows.Forms.Label();
            this.lMeasurementDuration = new System.Windows.Forms.Label();
            this.CBBeeperWarning = new System.Windows.Forms.CheckBox();
            this.GBPeakSearch = new System.Windows.Forms.GroupBox();
            this.TBLimit1StopFrequency = new System.Windows.Forms.TextBox();
            this.TBLimit1StartFrequency = new System.Windows.Forms.TextBox();
            this.lLimit1StopFrequency = new System.Windows.Forms.Label();
            this.lLimit1StartFrequency = new System.Windows.Forms.Label();
            this.CBEnableLimitTest = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.TabControl.SuspendLayout();
            this.MeasurementTPage.SuspendLayout();
            this.GBStimulusSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).BeginInit();
            this.TPLimitTest.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.GBLimitLine.SuspendLayout();
            this.GBPeakSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFilePath
            // 
            this.bFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilePath.Location = new System.Drawing.Point(12, 5);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(27, 27);
            this.bFilePath.TabIndex = 33;
            this.bFilePath.Text = "FP";
            this.toolTip1.SetToolTip(this.bFilePath, "File Path");
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(44, 9);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(340, 20);
            this.tbFilePath.TabIndex = 32;
            this.toolTip1.SetToolTip(this.tbFilePath, "Browse path for .txt file");
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(218, 188);
            this.nudInterval.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(71, 20);
            this.nudInterval.TabIndex = 31;
            this.toolTip1.SetToolTip(this.nudInterval, "Interval in seconds");
            this.nudInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(218, 266);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(71, 22);
            this.bStop.TabIndex = 27;
            this.bStop.Text = "Stop && Exit";
            this.toolTip1.SetToolTip(this.bStop, "Single click to stop and double click to exit");
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(218, 228);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(71, 23);
            this.bRun.TabIndex = 26;
            this.bRun.Text = "Run";
            this.toolTip1.SetToolTip(this.bRun, "Greys out whilst measurement is running");
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MeasurementTPage);
            this.TabControl.Controls.Add(this.TPLimitTest);
            this.TabControl.Location = new System.Drawing.Point(0, 25);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(563, 348);
            this.TabControl.TabIndex = 19;
            // 
            // MeasurementTPage
            // 
            this.MeasurementTPage.Controls.Add(this.GBStimulusSetup);
            this.MeasurementTPage.Location = new System.Drawing.Point(4, 22);
            this.MeasurementTPage.Margin = new System.Windows.Forms.Padding(2);
            this.MeasurementTPage.Name = "MeasurementTPage";
            this.MeasurementTPage.Padding = new System.Windows.Forms.Padding(2);
            this.MeasurementTPage.Size = new System.Drawing.Size(555, 322);
            this.MeasurementTPage.TabIndex = 0;
            this.MeasurementTPage.Text = "Stimulus Setup";
            this.MeasurementTPage.UseVisualStyleBackColor = true;
            // 
            // GBStimulusSetup
            // 
            this.GBStimulusSetup.Controls.Add(this.pointsNUD);
            this.GBStimulusSetup.Controls.Add(this.label5);
            this.GBStimulusSetup.Controls.Add(this.sParameterTB);
            this.GBStimulusSetup.Controls.Add(this.label1);
            this.GBStimulusSetup.Controls.Add(this.label4);
            this.GBStimulusSetup.Controls.Add(this.label2);
            this.GBStimulusSetup.Controls.Add(this.ifBWTB);
            this.GBStimulusSetup.Controls.Add(this.label3);
            this.GBStimulusSetup.Controls.Add(this.stopFrequencyTB);
            this.GBStimulusSetup.Controls.Add(this.startFrequencyTB);
            this.GBStimulusSetup.Location = new System.Drawing.Point(19, 19);
            this.GBStimulusSetup.Margin = new System.Windows.Forms.Padding(2);
            this.GBStimulusSetup.Name = "GBStimulusSetup";
            this.GBStimulusSetup.Padding = new System.Windows.Forms.Padding(2);
            this.GBStimulusSetup.Size = new System.Drawing.Size(308, 115);
            this.GBStimulusSetup.TabIndex = 27;
            this.GBStimulusSetup.TabStop = false;
            this.GBStimulusSetup.Text = "Stimulus";
            // 
            // pointsNUD
            // 
            this.pointsNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pointsNUD.Location = new System.Drawing.Point(249, 53);
            this.pointsNUD.Margin = new System.Windows.Forms.Padding(2);
            this.pointsNUD.Maximum = new decimal(new int[] {
            100001,
            0,
            0,
            0});
            this.pointsNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pointsNUD.Name = "pointsNUD";
            this.pointsNUD.Size = new System.Drawing.Size(48, 20);
            this.pointsNUD.TabIndex = 26;
            this.pointsNUD.Value = new decimal(new int[] {
            401,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "S Parameter";
            // 
            // sParameterTB
            // 
            this.sParameterTB.Location = new System.Drawing.Point(83, 83);
            this.sParameterTB.Margin = new System.Windows.Forms.Padding(2);
            this.sParameterTB.Name = "sParameterTB";
            this.sParameterTB.Size = new System.Drawing.Size(54, 20);
            this.sParameterTB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "IF BW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start";
            // 
            // ifBWTB
            // 
            this.ifBWTB.Location = new System.Drawing.Point(249, 18);
            this.ifBWTB.Margin = new System.Windows.Forms.Padding(2);
            this.ifBWTB.Name = "ifBWTB";
            this.ifBWTB.Size = new System.Drawing.Size(50, 20);
            this.ifBWTB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stop";
            // 
            // stopFrequencyTB
            // 
            this.stopFrequencyTB.Location = new System.Drawing.Point(83, 52);
            this.stopFrequencyTB.Margin = new System.Windows.Forms.Padding(2);
            this.stopFrequencyTB.Name = "stopFrequencyTB";
            this.stopFrequencyTB.Size = new System.Drawing.Size(71, 20);
            this.stopFrequencyTB.TabIndex = 20;
            // 
            // startFrequencyTB
            // 
            this.startFrequencyTB.Location = new System.Drawing.Point(83, 20);
            this.startFrequencyTB.Margin = new System.Windows.Forms.Padding(2);
            this.startFrequencyTB.Name = "startFrequencyTB";
            this.startFrequencyTB.Size = new System.Drawing.Size(71, 20);
            this.startFrequencyTB.TabIndex = 21;
            // 
            // TPLimitTest
            // 
            this.TPLimitTest.Controls.Add(this.textBox2);
            this.TPLimitTest.Controls.Add(this.textBox1);
            this.TPLimitTest.Controls.Add(this.button1);
            this.TPLimitTest.Controls.Add(this.cbSaveToDB);
            this.TPLimitTest.Controls.Add(this.statusStrip1);
            this.TPLimitTest.Controls.Add(this.GBLimitLine);
            this.TPLimitTest.Controls.Add(this.bFilePath);
            this.TPLimitTest.Controls.Add(this.tbFilePath);
            this.TPLimitTest.Controls.Add(this.nudInterval);
            this.TPLimitTest.Controls.Add(this.lMeasurementDuration);
            this.TPLimitTest.Controls.Add(this.bStop);
            this.TPLimitTest.Controls.Add(this.bRun);
            this.TPLimitTest.Controls.Add(this.CBBeeperWarning);
            this.TPLimitTest.Controls.Add(this.GBPeakSearch);
            this.TPLimitTest.Controls.Add(this.CBEnableLimitTest);
            this.TPLimitTest.Location = new System.Drawing.Point(4, 22);
            this.TPLimitTest.Margin = new System.Windows.Forms.Padding(2);
            this.TPLimitTest.Name = "TPLimitTest";
            this.TPLimitTest.Padding = new System.Windows.Forms.Padding(2);
            this.TPLimitTest.Size = new System.Drawing.Size(555, 322);
            this.TPLimitTest.TabIndex = 1;
            this.TPLimitTest.Text = "Measurement";
            this.TPLimitTest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbSaveToDB
            // 
            this.cbSaveToDB.AutoSize = true;
            this.cbSaveToDB.Location = new System.Drawing.Point(382, 190);
            this.cbSaveToDB.Name = "cbSaveToDB";
            this.cbSaveToDB.Size = new System.Drawing.Size(116, 17);
            this.cbSaveToDB.TabIndex = 36;
            this.cbSaveToDB.Text = "Save To Database";
            this.cbSaveToDB.UseVisualStyleBackColor = true;
            this.cbSaveToDB.CheckedChanged += new System.EventHandler(this.cbSaveToDB_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(2, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // GBLimitLine
            // 
            this.GBLimitLine.Controls.Add(this.TBLimitStartAmplitude);
            this.GBLimitLine.Controls.Add(this.lLimitAmplitude);
            this.GBLimitLine.Location = new System.Drawing.Point(12, 77);
            this.GBLimitLine.Name = "GBLimitLine";
            this.GBLimitLine.Size = new System.Drawing.Size(256, 85);
            this.GBLimitLine.TabIndex = 34;
            this.GBLimitLine.TabStop = false;
            this.GBLimitLine.Text = "Limit Line";
            // 
            // TBLimitStartAmplitude
            // 
            this.TBLimitStartAmplitude.Location = new System.Drawing.Point(81, 21);
            this.TBLimitStartAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.TBLimitStartAmplitude.Name = "TBLimitStartAmplitude";
            this.TBLimitStartAmplitude.Size = new System.Drawing.Size(58, 20);
            this.TBLimitStartAmplitude.TabIndex = 1;
            // 
            // lLimitAmplitude
            // 
            this.lLimitAmplitude.AutoSize = true;
            this.lLimitAmplitude.Location = new System.Drawing.Point(5, 24);
            this.lLimitAmplitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLimitAmplitude.Name = "lLimitAmplitude";
            this.lLimitAmplitude.Size = new System.Drawing.Size(53, 13);
            this.lLimitAmplitude.TabIndex = 0;
            this.lLimitAmplitude.Text = "Amplitude";
            // 
            // lMeasurementDuration
            // 
            this.lMeasurementDuration.AutoSize = true;
            this.lMeasurementDuration.Location = new System.Drawing.Point(90, 190);
            this.lMeasurementDuration.Name = "lMeasurementDuration";
            this.lMeasurementDuration.Size = new System.Drawing.Size(109, 13);
            this.lMeasurementDuration.TabIndex = 30;
            this.lMeasurementDuration.Text = "Measurement Interval";
            // 
            // CBBeeperWarning
            // 
            this.CBBeeperWarning.AutoSize = true;
            this.CBBeeperWarning.Location = new System.Drawing.Point(359, 55);
            this.CBBeeperWarning.Margin = new System.Windows.Forms.Padding(2);
            this.CBBeeperWarning.Name = "CBBeeperWarning";
            this.CBBeeperWarning.Size = new System.Drawing.Size(139, 17);
            this.CBBeeperWarning.TabIndex = 7;
            this.CBBeeperWarning.Text = "Enable Beeper Warning";
            this.CBBeeperWarning.UseVisualStyleBackColor = true;
            this.CBBeeperWarning.CheckedChanged += new System.EventHandler(this.CBLoadLimitLineTable_CheckedChanged);
            // 
            // GBPeakSearch
            // 
            this.GBPeakSearch.Controls.Add(this.TBLimit1StopFrequency);
            this.GBPeakSearch.Controls.Add(this.TBLimit1StartFrequency);
            this.GBPeakSearch.Controls.Add(this.lLimit1StopFrequency);
            this.GBPeakSearch.Controls.Add(this.lLimit1StartFrequency);
            this.GBPeakSearch.Location = new System.Drawing.Point(288, 77);
            this.GBPeakSearch.Margin = new System.Windows.Forms.Padding(2);
            this.GBPeakSearch.Name = "GBPeakSearch";
            this.GBPeakSearch.Padding = new System.Windows.Forms.Padding(2);
            this.GBPeakSearch.Size = new System.Drawing.Size(251, 85);
            this.GBPeakSearch.TabIndex = 5;
            this.GBPeakSearch.TabStop = false;
            this.GBPeakSearch.Text = "Peak Search";
            // 
            // TBLimit1StopFrequency
            // 
            this.TBLimit1StopFrequency.Location = new System.Drawing.Point(123, 54);
            this.TBLimit1StopFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.TBLimit1StopFrequency.Name = "TBLimit1StopFrequency";
            this.TBLimit1StopFrequency.Size = new System.Drawing.Size(111, 20);
            this.TBLimit1StopFrequency.TabIndex = 1;
            // 
            // TBLimit1StartFrequency
            // 
            this.TBLimit1StartFrequency.Location = new System.Drawing.Point(123, 17);
            this.TBLimit1StartFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.TBLimit1StartFrequency.Name = "TBLimit1StartFrequency";
            this.TBLimit1StartFrequency.Size = new System.Drawing.Size(111, 20);
            this.TBLimit1StartFrequency.TabIndex = 1;
            // 
            // lLimit1StopFrequency
            // 
            this.lLimit1StopFrequency.AutoSize = true;
            this.lLimit1StopFrequency.Location = new System.Drawing.Point(4, 58);
            this.lLimit1StopFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLimit1StopFrequency.Name = "lLimit1StopFrequency";
            this.lLimit1StopFrequency.Size = new System.Drawing.Size(82, 13);
            this.lLimit1StopFrequency.TabIndex = 0;
            this.lLimit1StopFrequency.Text = "Stop Frequency";
            // 
            // lLimit1StartFrequency
            // 
            this.lLimit1StartFrequency.AutoSize = true;
            this.lLimit1StartFrequency.Location = new System.Drawing.Point(4, 24);
            this.lLimit1StartFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLimit1StartFrequency.Name = "lLimit1StartFrequency";
            this.lLimit1StartFrequency.Size = new System.Drawing.Size(82, 13);
            this.lLimit1StartFrequency.TabIndex = 0;
            this.lLimit1StartFrequency.Text = "Start Frequency";
            // 
            // CBEnableLimitTest
            // 
            this.CBEnableLimitTest.AutoSize = true;
            this.CBEnableLimitTest.Location = new System.Drawing.Point(18, 55);
            this.CBEnableLimitTest.Margin = new System.Windows.Forms.Padding(2);
            this.CBEnableLimitTest.Name = "CBEnableLimitTest";
            this.CBEnableLimitTest.Size = new System.Drawing.Size(107, 17);
            this.CBEnableLimitTest.TabIndex = 0;
            this.CBEnableLimitTest.Text = "Enable Limit Test";
            this.CBEnableLimitTest.UseVisualStyleBackColor = true;
            this.CBEnableLimitTest.CheckedChanged += new System.EventHandler(this.CBEnableLimitTest_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "john";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.Text = "smith";
            // 
            // ENAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 374);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ENAForm";
            this.Text = "ENA Measurement";
            this.Load += new System.EventHandler(this.ENAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.MeasurementTPage.ResumeLayout(false);
            this.GBStimulusSetup.ResumeLayout(false);
            this.GBStimulusSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).EndInit();
            this.TPLimitTest.ResumeLayout(false);
            this.TPLimitTest.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GBLimitLine.ResumeLayout(false);
            this.GBLimitLine.PerformLayout();
            this.GBPeakSearch.ResumeLayout(false);
            this.GBPeakSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MeasurementTPage;
        private System.Windows.Forms.TabPage TPLimitTest;
        private System.Windows.Forms.GroupBox GBPeakSearch;
        private System.Windows.Forms.TextBox TBLimit1StopFrequency;
        private System.Windows.Forms.TextBox TBLimitStartAmplitude;
        private System.Windows.Forms.TextBox TBLimit1StartFrequency;
        private System.Windows.Forms.Label lLimit1StopFrequency;
        private System.Windows.Forms.Label lLimitAmplitude;
        private System.Windows.Forms.Label lLimit1StartFrequency;
        private System.Windows.Forms.CheckBox CBEnableLimitTest;
        private System.Windows.Forms.CheckBox CBBeeperWarning;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lMeasurementDuration;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.NumericUpDown pointsNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sParameterTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ifBWTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stopFrequencyTB;
        private System.Windows.Forms.TextBox startFrequencyTB;
        private System.Windows.Forms.GroupBox GBStimulusSetup;
        private System.Windows.Forms.GroupBox GBLimitLine;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox cbSaveToDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

