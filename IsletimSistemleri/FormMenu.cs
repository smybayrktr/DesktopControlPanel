using System;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTools form = new FormTools();
            form.Show();
        }

        private void buttonControlPanel_Click(object sender, EventArgs e)
        {
            FormControlPanel form = new FormControlPanel();
            form.Show();
        }

        private void buttonFeatures_Click(object sender, EventArgs e)
        {
            FormFeatures form = new FormFeatures();
            form.Show();
        }
    }
}
