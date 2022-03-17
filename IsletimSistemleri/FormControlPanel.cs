using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormControlPanel : System.Windows.Forms.Form
    {
       
       
        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);
        private static bool initialized = false;
        private static Int32 hdc;
        private static int a;
       
        public FormControlPanel()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonNext);
    
        }
        private void MakeButtonBorderless(Button button) //Buton kenarlarını siler.
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
        private static void InitializeClass()
        {
            if (initialized)
                return;
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
            initialized = true;


        }
        public static unsafe bool SetBrightness(int brightness) //Ekran parlaklığını ayarlar.
        {
            InitializeClass();
            if (brightness > 255)
                brightness = 255;
            if (brightness < 0)
                brightness = 0;
            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness + 128);
                    if (arrayVal > 65535)
                        arrayVal = 65535;
                    *idx = (short)arrayVal;
                    idx++;
                }
            }
            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            return retVal;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
                Set(trackBar1.Value);
            
            //    a = trackBar1.Value;
            //    SetBrightness(a);
        }
        public static void Set(int brightness)
        {
            try
            {
                var mclass = new ManagementClass("WmiMonitorBrightnessMethods")
                {
                    Scope = new ManagementScope(@"\\.\root\wmi")
                };
                var instances = mclass.GetInstances();
                var args = new object[] { 1, brightness };
                foreach (ManagementObject instance in instances)
                {
                    instance.InvokeMethod("WmiSetBrightness", args);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void trackBarSound_Scroll(object sender, EventArgs e)
        {
            
        }

        private void buttonTurnOffPc_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonSleepMode_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FormControlPanel1 form = new FormControlPanel1();
            form.Show();
        }

        private void FormControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
