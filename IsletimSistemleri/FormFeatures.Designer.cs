
namespace IsletimSistemleri
{
    partial class FormFeatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeatures));
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelRam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartCPU = new MetroFramework.Controls.MetroProgressSpinner();
            this.chartRam = new MetroFramework.Controls.MetroProgressSpinner();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU:";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCPU.ForeColor = System.Drawing.Color.White;
            this.labelCPU.Location = new System.Drawing.Point(188, 288);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(0, 25);
            this.labelCPU.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.BackColor = System.Drawing.Color.Transparent;
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRam.ForeColor = System.Drawing.Color.White;
            this.labelRam.Location = new System.Drawing.Point(489, 288);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(0, 25);
            this.labelRam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(421, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAM:";
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chartCPU.CustomBackground = true;
            this.chartCPU.Location = new System.Drawing.Point(110, 130);
            this.chartCPU.Maximum = 100;
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Size = new System.Drawing.Size(162, 140);
            this.chartCPU.Spinning = false;
            this.chartCPU.TabIndex = 4;
            // 
            // chartRam
            // 
            this.chartRam.CustomBackground = true;
            this.chartRam.Location = new System.Drawing.Point(399, 130);
            this.chartRam.Maximum = 8000;
            this.chartRam.Name = "chartRam";
            this.chartRam.Size = new System.Drawing.Size(162, 140);
            this.chartRam.Spinning = false;
            this.chartRam.TabIndex = 5;
            this.chartRam.Click += new System.EventHandler(this.chartRam_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labelCurrentTime.Location = new System.Drawing.Point(483, 9);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(0, 24);
            this.labelCurrentTime.TabIndex = 9;
            // 
            // FormFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.chartRam);
            this.Controls.Add(this.chartCPU);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFeatures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özellikler";
            this.Load += new System.EventHandler(this.FormFeatures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroProgressSpinner chartCPU;
        private MetroFramework.Controls.MetroProgressSpinner chartRam;
        private System.Windows.Forms.Label labelCurrentTime;
    }
}