namespace ENA
{
    partial class StimulusSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startFrequencyTB = new System.Windows.Forms.TextBox();
            this.stopFrequencyTB = new System.Windows.Forms.TextBox();
            this.ifBWTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sParameterTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pointsNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stop";
            // 
            // startFrequencyTB
            // 
            this.startFrequencyTB.Location = new System.Drawing.Point(86, 59);
            this.startFrequencyTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startFrequencyTB.Name = "startFrequencyTB";
            this.startFrequencyTB.Size = new System.Drawing.Size(71, 20);
            this.startFrequencyTB.TabIndex = 10;
            this.startFrequencyTB.Text = "30000";
            this.startFrequencyTB.TextChanged += new System.EventHandler(this.startFrequencyTB_TextChanged);
            // 
            // stopFrequencyTB
            // 
            this.stopFrequencyTB.Location = new System.Drawing.Point(86, 93);
            this.stopFrequencyTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopFrequencyTB.Name = "stopFrequencyTB";
            this.stopFrequencyTB.Size = new System.Drawing.Size(71, 20);
            this.stopFrequencyTB.TabIndex = 10;
            this.stopFrequencyTB.Text = "9000000000";
            this.stopFrequencyTB.TextChanged += new System.EventHandler(this.stopFrequencyTB_TextChanged);
            // 
            // ifBWTB
            // 
            this.ifBWTB.Location = new System.Drawing.Point(280, 58);
            this.ifBWTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ifBWTB.Name = "ifBWTB";
            this.ifBWTB.Size = new System.Drawing.Size(50, 20);
            this.ifBWTB.TabIndex = 11;
            this.ifBWTB.Text = "30000";
            this.ifBWTB.TextChanged += new System.EventHandler(this.ifBWTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "IF BW";
            // 
            // sParameterTB
            // 
            this.sParameterTB.Location = new System.Drawing.Point(103, 138);
            this.sParameterTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sParameterTB.Name = "sParameterTB";
            this.sParameterTB.Size = new System.Drawing.Size(54, 20);
            this.sParameterTB.TabIndex = 14;
            this.sParameterTB.Text = "S21";
            this.sParameterTB.TextChanged += new System.EventHandler(this.sParameterTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "S Parameter";
            // 
            // pointsNUD
            // 
            this.pointsNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pointsNUD.Location = new System.Drawing.Point(280, 98);
            this.pointsNUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pointsNUD.TabIndex = 16;
            this.pointsNUD.Value = new decimal(new int[] {
            401,
            0,
            0,
            0});
            this.pointsNUD.ValueChanged += new System.EventHandler(this.pointsNUD_ValueChanged);
            // 
            // StimulusSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 328);
            this.Controls.Add(this.pointsNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sParameterTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ifBWTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopFrequencyTB);
            this.Controls.Add(this.startFrequencyTB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StimulusSettingsForm";
            this.Text = "Stimulus Settings";
            
            ((System.ComponentModel.ISupportInitialize)(this.pointsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startFrequencyTB;
        private System.Windows.Forms.TextBox stopFrequencyTB;
        private System.Windows.Forms.TextBox ifBWTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sParameterTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown pointsNUD;
    }
}