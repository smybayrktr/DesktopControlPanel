
namespace IsletimSistemleri
{
    partial class FormControlPanel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlPanel1));
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarSound = new System.Windows.Forms.TrackBar();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSleepMode = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonTurnOffPc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ses arttır ya da azalt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBarSound
            // 
            this.trackBarSound.LargeChange = 1;
            this.trackBarSound.Location = new System.Drawing.Point(17, 184);
            this.trackBarSound.Maximum = 100;
            this.trackBarSound.Name = "trackBarSound";
            this.trackBarSound.Size = new System.Drawing.Size(666, 56);
            this.trackBarSound.TabIndex = 26;
            this.trackBarSound.Value = 50;
            this.trackBarSound.Scroll += new System.EventHandler(this.trackBarSound_Scroll);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = global::IsletimSistemleri.Properties.Resources.icons8_back_to_24;
            this.buttonBack.Location = new System.Drawing.Point(17, 406);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(57, 53);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // buttonSleepMode
            // 
            this.buttonSleepMode.BackColor = System.Drawing.Color.Transparent;
            this.buttonSleepMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSleepMode.Image = global::IsletimSistemleri.Properties.Resources.night_mode;
            this.buttonSleepMode.Location = new System.Drawing.Point(511, 419);
            this.buttonSleepMode.Name = "buttonSleepMode";
            this.buttonSleepMode.Size = new System.Drawing.Size(52, 40);
            this.buttonSleepMode.TabIndex = 32;
            this.buttonSleepMode.UseVisualStyleBackColor = false;
            this.buttonSleepMode.Click += new System.EventHandler(this.buttonSleepMode_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Image = global::IsletimSistemleri.Properties.Resources.restart;
            this.buttonRestart.Location = new System.Drawing.Point(569, 419);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(52, 40);
            this.buttonRestart.TabIndex = 31;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonTurnOffPc
            // 
            this.buttonTurnOffPc.BackColor = System.Drawing.Color.Transparent;
            this.buttonTurnOffPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurnOffPc.Image = global::IsletimSistemleri.Properties.Resources.turn_off;
            this.buttonTurnOffPc.Location = new System.Drawing.Point(627, 419);
            this.buttonTurnOffPc.Name = "buttonTurnOffPc";
            this.buttonTurnOffPc.Size = new System.Drawing.Size(52, 40);
            this.buttonTurnOffPc.TabIndex = 30;
            this.buttonTurnOffPc.UseVisualStyleBackColor = false;
            this.buttonTurnOffPc.Click += new System.EventHandler(this.buttonTurnOffPc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IsletimSistemleri.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(286, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormControlPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSleepMode);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonTurnOffPc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBarSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormControlPanel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormControlPanel1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBarSound;
        private System.Windows.Forms.Button buttonSleepMode;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonTurnOffPc;
        private System.Windows.Forms.Button buttonBack;
    }
}