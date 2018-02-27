namespace ENA
{
    partial class Startup
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
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BStartupRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(67, 69);
            this.addressTB.Margin = new System.Windows.Forms.Padding(4);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(276, 22);
            this.addressTB.TabIndex = 0;
            this.addressTB.Text = "TCPIP0::IP Address:inst0::INSTR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analyzer Visa Address";
            // 
            // BStartupRun
            // 
            this.BStartupRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BStartupRun.Location = new System.Drawing.Point(92, 114);
            this.BStartupRun.Margin = new System.Windows.Forms.Padding(4);
            this.BStartupRun.Name = "BStartupRun";
            this.BStartupRun.Size = new System.Drawing.Size(139, 38);
            this.BStartupRun.TabIndex = 2;
            this.BStartupRun.Text = "Run";
            this.BStartupRun.UseVisualStyleBackColor = true;
            this.BStartupRun.Click += new System.EventHandler(this.BStartupRun_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 452);
            this.Controls.Add(this.BStartupRun);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BStartupRun;
    }
}