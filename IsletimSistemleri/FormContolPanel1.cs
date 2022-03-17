using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormControlPanel1 : Form
    {
        public CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        public FormControlPanel1()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonRestart);
            MakeButtonBorderless(buttonSleepMode);
            MakeButtonBorderless(buttonTurnOffPc);
            MakeButtonBorderless(buttonBack);
         
        }
        private void MakeButtonBorderless(Button button) //Buton kenarlarını siler.
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
        private void trackBarSound_Scroll(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = trackBarSound.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
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

        private void FormControlPanel1_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultPlaybackDevice.Dispose();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
