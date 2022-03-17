using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormFeatures : Form
    {
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        public FormFeatures()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FormFeatures_Load(object sender, EventArgs e)
        {

        }
        private void GetCPUUsage()
        {
            var value = (int)cpuCounter.NextValue();
            labelCPU.Text = " " +value + " " + "%";
            chartCPU.Value = value;
        }
        private void GetRAMUsage()
        {
            var value = (int)ramCounter.NextValue();
            labelRam.Text =  " " + value + " " + "mb";
            chartRam.Value = value;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCPUUsage();
            GetRAMUsage();
            DateTime datetime = DateTime.Now;
            this.labelCurrentTime.Text = datetime.ToString();

        }

        private void chartRam_Click(object sender, EventArgs e)
        {

        }
    }
}
