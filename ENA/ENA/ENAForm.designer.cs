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
            this.bRun = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.lMeasurementInterval = new System.Windows.Forms.Label();
            this.lMeasurementDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stimulusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bRun
            // 
            this.bRun.Location = new System.Drawing.Point(134, 249);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(71, 23);
            this.bRun.TabIndex = 2;
            this.bRun.Text = "Run";
            this.toolTip1.SetToolTip(this.bRun, "Greys out whilst measurement is running");
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(134, 295);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(71, 22);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop && Exit";
            this.toolTip1.SetToolTip(this.bStop, "Single click to stop and double click to exit");
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(170, 128);
            this.nudInterval.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(72, 20);
            this.nudInterval.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudInterval, "Interval in msecs");
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lMeasurementInterval
            // 
            this.lMeasurementInterval.AutoSize = true;
            this.lMeasurementInterval.Location = new System.Drawing.Point(55, 128);
            this.lMeasurementInterval.Name = "lMeasurementInterval";
            this.lMeasurementInterval.Size = new System.Drawing.Size(109, 13);
            this.lMeasurementInterval.TabIndex = 5;
            this.lMeasurementInterval.Text = "Measurement Interval";
            // 
            // lMeasurementDuration
            // 
            this.lMeasurementDuration.AutoSize = true;
            this.lMeasurementDuration.Location = new System.Drawing.Point(55, 169);
            this.lMeasurementDuration.Name = "lMeasurementDuration";
            this.lMeasurementDuration.Size = new System.Drawing.Size(114, 13);
            this.lMeasurementDuration.TabIndex = 6;
            this.lMeasurementDuration.Text = "Measurement Duration";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(184, 167);
            this.nudDuration.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(56, 20);
            this.nudDuration.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nudDuration, "Duration in seconds");
            this.nudDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(62, 208);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(202, 20);
            this.tbFilePath.TabIndex = 8;
            this.tbFilePath.Text = "C:\\Users\\wilattoh\\Documents\\Results.xlsx";
            this.toolTip1.SetToolTip(this.tbFilePath, "Browse path for .txt file");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "FP";
            this.toolTip1.SetToolTip(this.button1, "File Path");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stimulusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // stimulusToolStripMenuItem
            // 
            this.stimulusToolStripMenuItem.Name = "stimulusToolStripMenuItem";
            this.stimulusToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.stimulusToolStripMenuItem.Text = "Stimulus";
            this.stimulusToolStripMenuItem.Click += new System.EventHandler(this.stimulusToolStripMenuItem_Click);
            // 
            // ENAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lMeasurementDuration);
            this.Controls.Add(this.lMeasurementInterval);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ENAForm";
            this.Text = "ENA Measurement";
            this.Load += new System.EventHandler(this.ENAForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lMeasurementInterval;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lMeasurementDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stimulusToolStripMenuItem;
    }
}

