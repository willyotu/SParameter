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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MeasurementTPage = new System.Windows.Forms.TabPage();
            this.TPLimitTest = new System.Windows.Forms.TabPage();
            this.GBLimitLine1 = new System.Windows.Forms.GroupBox();
            this.TBLimit1StopFrequency = new System.Windows.Forms.TextBox();
            this.TBLimit1StartAmplitude = new System.Windows.Forms.TextBox();
            this.TBLimit1StartFrequency = new System.Windows.Forms.TextBox();
            this.lLimit1StopFrequency = new System.Windows.Forms.Label();
            this.lLimit1StartAmplitude = new System.Windows.Forms.Label();
            this.lLimit1StartFrequency = new System.Windows.Forms.Label();
            this.ComboBLimitLineType = new System.Windows.Forms.ComboBox();
            this.lLimitLineType = new System.Windows.Forms.Label();
            this.CBEnableLimitTest = new System.Windows.Forms.CheckBox();
            this.CBBeeperWarning = new System.Windows.Forms.CheckBox();
            this.bFilePath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lMeasurementDuration = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.bRun = new System.Windows.Forms.Button();
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
            this.GBStimulusSetup = new System.Windows.Forms.GroupBox();
            this.TabControl.SuspendLayout();
            this.MeasurementTPage.SuspendLayout();
            this.TPLimitTest.SuspendLayout();
            this.GBLimitLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).BeginInit();
            this.GBStimulusSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
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
            this.MeasurementTPage.Controls.Add(this.GBStimulusSetup);
            this.MeasurementTPage.Location = new System.Drawing.Point(4, 25);
            this.MeasurementTPage.Name = "MeasurementTPage";
            this.MeasurementTPage.Padding = new System.Windows.Forms.Padding(3);
            this.MeasurementTPage.Size = new System.Drawing.Size(770, 412);
            this.MeasurementTPage.TabIndex = 0;
            this.MeasurementTPage.Text = "Stimulus Setup";
            this.MeasurementTPage.UseVisualStyleBackColor = true;
            this.MeasurementTPage.Click += new System.EventHandler(this.MeasurementTPage_Click);
            // 
            // TPLimitTest
            // 
            this.TPLimitTest.Controls.Add(this.bFilePath);
            this.TPLimitTest.Controls.Add(this.tbFilePath);
            this.TPLimitTest.Controls.Add(this.nudDuration);
            this.TPLimitTest.Controls.Add(this.lMeasurementDuration);
            this.TPLimitTest.Controls.Add(this.bStop);
            this.TPLimitTest.Controls.Add(this.bRun);
            this.TPLimitTest.Controls.Add(this.CBBeeperWarning);
            this.TPLimitTest.Controls.Add(this.GBLimitLine1);
            this.TPLimitTest.Controls.Add(this.ComboBLimitLineType);
            this.TPLimitTest.Controls.Add(this.lLimitLineType);
            this.TPLimitTest.Controls.Add(this.CBEnableLimitTest);
            this.TPLimitTest.Location = new System.Drawing.Point(4, 25);
            this.TPLimitTest.Name = "TPLimitTest";
            this.TPLimitTest.Padding = new System.Windows.Forms.Padding(3);
            this.TPLimitTest.Size = new System.Drawing.Size(770, 412);
            this.TPLimitTest.TabIndex = 1;
            this.TPLimitTest.Text = "Measurement";
            this.TPLimitTest.UseVisualStyleBackColor = true;
            // 
            // GBLimitLine1
            // 
            this.GBLimitLine1.Controls.Add(this.TBLimit1StopFrequency);
            this.GBLimitLine1.Controls.Add(this.TBLimit1StartAmplitude);
            this.GBLimitLine1.Controls.Add(this.TBLimit1StartFrequency);
            this.GBLimitLine1.Controls.Add(this.lLimit1StopFrequency);
            this.GBLimitLine1.Controls.Add(this.lLimit1StartAmplitude);
            this.GBLimitLine1.Controls.Add(this.lLimit1StartFrequency);
            this.GBLimitLine1.Location = new System.Drawing.Point(24, 82);
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
            // TBLimit1StartAmplitude
            // 
            this.TBLimit1StartAmplitude.Location = new System.Drawing.Point(455, 29);
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
            // lLimit1StartAmplitude
            // 
            this.lLimit1StartAmplitude.AutoSize = true;
            this.lLimit1StartAmplitude.Location = new System.Drawing.Point(358, 29);
            this.lLimit1StartAmplitude.Name = "lLimit1StartAmplitude";
            this.lLimit1StartAmplitude.Size = new System.Drawing.Size(70, 17);
            this.lLimit1StartAmplitude.TabIndex = 0;
            this.lLimit1StartAmplitude.Text = "Amplitude";
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
            this.ComboBLimitLineType.Location = new System.Drawing.Point(188, 52);
            this.ComboBLimitLineType.Name = "ComboBLimitLineType";
            this.ComboBLimitLineType.Size = new System.Drawing.Size(123, 24);
            this.ComboBLimitLineType.TabIndex = 4;
            // 
            // lLimitLineType
            // 
            this.lLimitLineType.AutoSize = true;
            this.lLimitLineType.Location = new System.Drawing.Point(27, 52);
            this.lLimitLineType.Name = "lLimitLineType";
            this.lLimitLineType.Size = new System.Drawing.Size(120, 17);
            this.lLimitLineType.TabIndex = 3;
            this.lLimitLineType.Text = "Type of Limit Line";
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
            // CBBeeperWarning
            // 
            this.CBBeeperWarning.AutoSize = true;
            this.CBBeeperWarning.Location = new System.Drawing.Point(479, 17);
            this.CBBeeperWarning.Name = "CBBeeperWarning";
            this.CBBeeperWarning.Size = new System.Drawing.Size(181, 21);
            this.CBBeeperWarning.TabIndex = 7;
            this.CBBeeperWarning.Text = "Enable Beeper Warning";
            this.CBBeeperWarning.UseVisualStyleBackColor = true;
            this.CBBeeperWarning.CheckedChanged += new System.EventHandler(this.CBLoadLimitLineTable_CheckedChanged);
            // 
            // bFilePath
            // 
            this.bFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilePath.Location = new System.Drawing.Point(151, 268);
            this.bFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(36, 33);
            this.bFilePath.TabIndex = 33;
            this.bFilePath.Text = "FP";
            this.toolTip1.SetToolTip(this.bFilePath, "File Path");
            this.bFilePath.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(193, 273);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(268, 22);
            this.tbFilePath.TabIndex = 32;
            this.tbFilePath.Text = "C:\\Users\\wilattoh\\Documents\\Results.xlsx";
            this.toolTip1.SetToolTip(this.tbFilePath, "Browse path for .txt file");
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(355, 223);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4);
            this.nudDuration.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(75, 22);
            this.nudDuration.TabIndex = 31;
            this.toolTip1.SetToolTip(this.nudDuration, "Duration in seconds");
            this.nudDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lMeasurementDuration
            // 
            this.lMeasurementDuration.AutoSize = true;
            this.lMeasurementDuration.Location = new System.Drawing.Point(183, 225);
            this.lMeasurementDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMeasurementDuration.Name = "lMeasurementDuration";
            this.lMeasurementDuration.Size = new System.Drawing.Size(152, 17);
            this.lMeasurementDuration.TabIndex = 30;
            this.lMeasurementDuration.Text = "Measurement Duration";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(289, 369);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(95, 27);
            this.bStop.TabIndex = 27;
            this.bStop.Text = "Stop && Exit";
            this.toolTip1.SetToolTip(this.bStop, "Single click to stop and double click to exit");
            this.bStop.UseVisualStyleBackColor = true;
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(289, 323);
            this.bRun.Margin = new System.Windows.Forms.Padding(4);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(95, 28);
            this.bRun.TabIndex = 26;
            this.bRun.Text = "Run";
            this.toolTip1.SetToolTip(this.bRun, "Greys out whilst measurement is running");
            this.bRun.UseVisualStyleBackColor = true;
            // 
            // pointsNUD
            // 
            this.pointsNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pointsNUD.Location = new System.Drawing.Point(332, 65);
            this.pointsNUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.pointsNUD.Size = new System.Drawing.Size(64, 22);
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
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "S Parameter";
            // 
            // sParameterTB
            // 
            this.sParameterTB.Location = new System.Drawing.Point(111, 102);
            this.sParameterTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sParameterTB.Name = "sParameterTB";
            this.sParameterTB.Size = new System.Drawing.Size(71, 22);
            this.sParameterTB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "IF BW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start";
            // 
            // ifBWTB
            // 
            this.ifBWTB.Location = new System.Drawing.Point(332, 22);
            this.ifBWTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ifBWTB.Name = "ifBWTB";
            this.ifBWTB.Size = new System.Drawing.Size(65, 22);
            this.ifBWTB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Stop";
            // 
            // stopFrequencyTB
            // 
            this.stopFrequencyTB.Location = new System.Drawing.Point(111, 64);
            this.stopFrequencyTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopFrequencyTB.Name = "stopFrequencyTB";
            this.stopFrequencyTB.Size = new System.Drawing.Size(93, 22);
            this.stopFrequencyTB.TabIndex = 20;
            // 
            // startFrequencyTB
            // 
            this.startFrequencyTB.Location = new System.Drawing.Point(111, 25);
            this.startFrequencyTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startFrequencyTB.Name = "startFrequencyTB";
            this.startFrequencyTB.Size = new System.Drawing.Size(93, 22);
            this.startFrequencyTB.TabIndex = 21;
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
            this.GBStimulusSetup.Location = new System.Drawing.Point(25, 23);
            this.GBStimulusSetup.Name = "GBStimulusSetup";
            this.GBStimulusSetup.Size = new System.Drawing.Size(411, 142);
            this.GBStimulusSetup.TabIndex = 27;
            this.GBStimulusSetup.TabStop = false;
            this.GBStimulusSetup.Text = "Stimulus";
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
            this.TabControl.ResumeLayout(false);
            this.MeasurementTPage.ResumeLayout(false);
            this.TPLimitTest.ResumeLayout(false);
            this.TPLimitTest.PerformLayout();
            this.GBLimitLine1.ResumeLayout(false);
            this.GBLimitLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).EndInit();
            this.GBStimulusSetup.ResumeLayout(false);
            this.GBStimulusSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MeasurementTPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TPLimitTest;
        private System.Windows.Forms.GroupBox GBLimitLine1;
        private System.Windows.Forms.TextBox TBLimit1StopFrequency;
        private System.Windows.Forms.TextBox TBLimit1StartAmplitude;
        private System.Windows.Forms.TextBox TBLimit1StartFrequency;
        private System.Windows.Forms.Label lLimit1StopFrequency;
        private System.Windows.Forms.Label lLimit1StartAmplitude;
        private System.Windows.Forms.Label lLimit1StartFrequency;
        private System.Windows.Forms.ComboBox ComboBLimitLineType;
        private System.Windows.Forms.Label lLimitLineType;
        private System.Windows.Forms.CheckBox CBEnableLimitTest;
        private System.Windows.Forms.CheckBox CBBeeperWarning;
        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.NumericUpDown nudDuration;
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
    }
}

