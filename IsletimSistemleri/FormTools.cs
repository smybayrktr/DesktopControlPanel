using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;

namespace IsletimSistemleri
{
    public partial class FormTools : System.Windows.Forms.Form
    {
        public CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        PowerStatus status = SystemInformation.PowerStatus;
        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);
        private static bool initialized = false;
        private static Int32 hdc;
        private static int a;
        public FormTools()
        {


            InitializeComponent();
            timer1.Start();
           


        }


        private void ShowPowerStatus() //Pilin güç durumunu gösterir.
        {
         
            var labelCharge = status.BatteryLifePercent.ToString("P0");
            var labelChargeStatusString = labelCharge.Substring(1);
            progressBar1.Value = Convert.ToInt32(labelChargeStatusString);
            labelChargeStatus.Text = labelCharge;

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
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void buttonTurnOffPc_Click(object sender, EventArgs e) //Bilgisayarı kapatır.
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
        private void MakeButtonBorderless(Button button) //Buton kenarlarını siler.
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
        private void labelCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //Zamanı gösterir.
        {
           
            ShowPowerStatus();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e) //Yeniden başlatır
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonSleepMode_Click(object sender, EventArgs e) //Uyku moduna alır.
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void trackBarSound_Scroll(object sender, EventArgs e) //Sesi ayarlar.
        {
            


        }

        private void trackBarSound_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);


            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);


            bmpScreenshot.Save(@"C:\Users\smyye\Desktop\Screenshot.png", ImageFormat.Png);
        }

        private void checkBoxFlightMode_CheckedChangedAsync(object sender, EventArgs e)
        {

        }
        //private async Task TurnOnFlightMode()
        //{
        //    var bluetooth = await Radio.FromIdAsync("88:b1:11:09:e0:5b");


        //    if (checkBoxFlightMode.Checked)
        //    {
        //        var result = await Radio.RequestAccessAsync();
        //        if (result == RadioAccessStatus.Allowed)
        //        {
        //             bluetooth = (await Radio.GetRadiosAsync()).FirstOrDefault(radio => radio.Kind == RadioKind.Bluetooth);
        //            if (bluetooth != null && bluetooth.State != RadioState.On)
        //                await bluetooth.SetStateAsync(RadioState.On);
        //        }
        //    }
        //    else
        //    {
        //        var result = await Radio.RequestAccessAsync();
        //        if (result == RadioAccessStatus.Allowed)
        //        {
        //             bluetooth = (await Radio.GetRadiosAsync()).FirstOrDefault(radio => radio.Kind == RadioKind.Bluetooth);
        //            if (bluetooth != null && bluetooth.State != RadioState.On)
        //                await bluetooth.SetStateAsync(RadioState.Off);
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {


            Process.Start(@"C:\Windows\System32\magnify.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPasswordShow_Click(object sender, EventArgs e)
        {
            WifiPassword();
        }
        private void WifiPassword()
        {
            List<string> wlName = new List<string>();
            List<string> wlPassword = new List<string>();
            string wifiname, password;
            using (var process1 = new Process())
            {
                process1.StartInfo = new ProcessStartInfo //Cmd yi çalıştırır
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C netsh wlan show profile", //Tüm wifi isimlerini getirir cmd den.
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                };
                process1.Start();
                wifiname = process1.StandardOutput.ReadToEnd(); //Çıktıyı okur.
                process1.WaitForExit();

                wifiname = wifiname.Trim();
            }
            var wifiLines = wifiname.Split('\n');
            for (int i = 8; i < wifiLines.Length; i++) //ilk 8 basamakta wifi isimleri olmadığı için
            {
                using (var process2 = new Process())
                {

                    process2.StartInfo = new ProcessStartInfo
                    {
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = "/C netsh wlan show profile " + wifiLines[i].Substring(26) + " key = clear" + "| findstr Key", //Şifreyi yazdırır
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    };
                    process2.Start();
                    password = process2.StandardOutput.ReadToEnd();
                    process2.WaitForExit();
                }
                password = password.Trim();
                if (password != String.Empty) //Şifre boş mu onu kontrol ediyor.
                {
                    wlName.Add(wifiLines[i].Substring(27));
                    wlPassword.Add(password.Substring(25));
                }
            }

            string path = @"C:\Users\smyye\Desktop\sifreler.txt";
            string ssid = "";
            for (int i = 0; i < wlName.Count; i++) //Şifreleri stringe atma kısmı
            {
                ssid += wlName[i] + "\n" + wlPassword[i] + "\n" + "--------------" + "\n";
            }

            if (!File.Exists(path)) //Dosya var mı kontrolünü yapar.
            {
                FileStream fs = File.Create(path); //Yoksa dosya oluşturur.
                fs.Close();
            }
            File.AppendAllText(path, ssid);

        }
    }
}