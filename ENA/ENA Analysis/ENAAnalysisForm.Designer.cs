namespace ENA_Analysis
{
    partial class Form1
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
            this.bPlotSParameter = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.bFilePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPlotSParameter
            // 
            this.bPlotSParameter.Location = new System.Drawing.Point(12, 12);
            this.bPlotSParameter.Name = "bPlotSParameter";
            this.bPlotSParameter.Size = new System.Drawing.Size(122, 23);
            this.bPlotSParameter.TabIndex = 0;
            this.bPlotSParameter.Text = "Plot SParameter";
            this.bPlotSParameter.UseVisualStyleBackColor = true;
            this.bPlotSParameter.Click += new System.EventHandler(this.bPlotSParameter_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(84, 65);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(222, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // bFilePath
            // 
            this.bFilePath.Location = new System.Drawing.Point(3, 62);
            this.bFilePath.Name = "bFilePath";
            this.bFilePath.Size = new System.Drawing.Size(75, 23);
            this.bFilePath.TabIndex = 2;
            this.bFilePath.Text = "File Path";
            this.bFilePath.UseVisualStyleBackColor = true;
            this.bFilePath.Click += new System.EventHandler(this.bFilePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 364);
            this.Controls.Add(this.bFilePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.bPlotSParameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPlotSParameter;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button bFilePath;
    }
}

