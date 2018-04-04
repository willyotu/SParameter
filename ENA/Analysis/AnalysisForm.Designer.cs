namespace Analysis
{
    partial class AnalysisForm
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
            this.bFilePath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lCutOffFrequencyTrend = new System.Windows.Forms.Label();
            this.lPeakAmplitudeTrend = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bAverageCutOff = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bPlotSParameter = new System.Windows.Forms.Button();
            this.bPlotsOverTime = new System.Windows.Forms.Button();
            this.bPlotOverDay = new System.Windows.Forms.Button();
            this.bPlotOverWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFilePath
            // 
            this.bFilePath.Location = new System.Drawing.Point(12, 32);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(38, 20);
            this.bFilePath.TabIndex = 0;
            this.bFilePath.Text = "FP";
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(56, 32);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(368, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cut Off Frequency over Day",
            "Cut Off Frequency over Week",
            "Cut Off Frequency over Month",
            "Cut Off Frequency over Quarter",
            "Cut Off Frequency over Year"});
            this.comboBox1.Location = new System.Drawing.Point(159, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lCutOffFrequencyTrend
            // 
            this.lCutOffFrequencyTrend.AutoSize = true;
            this.lCutOffFrequencyTrend.Location = new System.Drawing.Point(23, 80);
            this.lCutOffFrequencyTrend.Name = "lCutOffFrequencyTrend";
            this.lCutOffFrequencyTrend.Size = new System.Drawing.Size(121, 13);
            this.lCutOffFrequencyTrend.TabIndex = 4;
            this.lCutOffFrequencyTrend.Text = "CutOff Frequency Trend";
            // 
            // lPeakAmplitudeTrend
            // 
            this.lPeakAmplitudeTrend.AutoSize = true;
            this.lPeakAmplitudeTrend.Location = new System.Drawing.Point(23, 131);
            this.lPeakAmplitudeTrend.Name = "lPeakAmplitudeTrend";
            this.lPeakAmplitudeTrend.Size = new System.Drawing.Size(112, 13);
            this.lPeakAmplitudeTrend.TabIndex = 5;
            this.lPeakAmplitudeTrend.Text = "Peak Amplitude Trend";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Peak Amplitude over Day",
            "Peak Amplitude over Week",
            "Peak Amplitude over Month",
            "Peak Amplitude over Quarter",
            "Peak Amplitude over Year"});
            this.comboBox2.Location = new System.Drawing.Point(161, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // bAverageCutOff
            // 
            this.bAverageCutOff.Location = new System.Drawing.Point(12, 177);
            this.bAverageCutOff.Name = "bAverageCutOff";
            this.bAverageCutOff.Size = new System.Drawing.Size(144, 22);
            this.bAverageCutOff.TabIndex = 7;
            this.bAverageCutOff.Text = "Average Cut Off Frequency";
            this.bAverageCutOff.UseVisualStyleBackColor = true;
            this.bAverageCutOff.Click += new System.EventHandler(this.bAverageCutOff_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(170, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 21);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // bPlotSParameter
            // 
            this.bPlotSParameter.Location = new System.Drawing.Point(26, 213);
            this.bPlotSParameter.Name = "bPlotSParameter";
            this.bPlotSParameter.Size = new System.Drawing.Size(101, 23);
            this.bPlotSParameter.TabIndex = 9;
            this.bPlotSParameter.Text = "Plot S Parameter";
            this.bPlotSParameter.UseVisualStyleBackColor = true;
            this.bPlotSParameter.Click += new System.EventHandler(this.bPlotSParameter_Click);
            // 
            // bPlotsOverTime
            // 
            this.bPlotsOverTime.Location = new System.Drawing.Point(26, 242);
            this.bPlotsOverTime.Name = "bPlotsOverTime";
            this.bPlotsOverTime.Size = new System.Drawing.Size(101, 23);
            this.bPlotsOverTime.TabIndex = 10;
            this.bPlotsOverTime.Text = "Plots Over Time";
            this.bPlotsOverTime.UseVisualStyleBackColor = true;
            this.bPlotsOverTime.Click += new System.EventHandler(this.bPlotOverTime_Click);
            // 
            // bPlotOverDay
            // 
            this.bPlotOverDay.Location = new System.Drawing.Point(26, 271);
            this.bPlotOverDay.Name = "bPlotOverDay";
            this.bPlotOverDay.Size = new System.Drawing.Size(101, 23);
            this.bPlotOverDay.TabIndex = 11;
            this.bPlotOverDay.Text = "Plot Over Day";
            this.bPlotOverDay.UseVisualStyleBackColor = true;
            this.bPlotOverDay.Click += new System.EventHandler(this.bPlotOverDay_Click);
            // 
            // bPlotOverWeek
            // 
            this.bPlotOverWeek.Location = new System.Drawing.Point(26, 300);
            this.bPlotOverWeek.Name = "bPlotOverWeek";
            this.bPlotOverWeek.Size = new System.Drawing.Size(101, 21);
            this.bPlotOverWeek.TabIndex = 12;
            this.bPlotOverWeek.Text = "Plot Over Week";
            this.bPlotOverWeek.UseVisualStyleBackColor = true;
            this.bPlotOverWeek.Click += new System.EventHandler(this.bPlotOverWeek_Click);
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 326);
            this.Controls.Add(this.bPlotOverWeek);
            this.Controls.Add(this.bPlotOverDay);
            this.Controls.Add(this.bPlotsOverTime);
            this.Controls.Add(this.bPlotSParameter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bAverageCutOff);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lPeakAmplitudeTrend);
            this.Controls.Add(this.lCutOffFrequencyTrend);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.bFilePath);
            this.Name = "AnalysisForm";
            this.Text = "S Parameter Analysis";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lCutOffFrequencyTrend;
        private System.Windows.Forms.Label lPeakAmplitudeTrend;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bAverageCutOff;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bPlotSParameter;
        private System.Windows.Forms.Button bPlotsOverTime;
        private System.Windows.Forms.Button bPlotOverDay;
        private System.Windows.Forms.Button bPlotOverWeek;
    }
}

