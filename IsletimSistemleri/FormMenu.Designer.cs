
namespace IsletimSistemleri
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonFeatures = new System.Windows.Forms.Button();
            this.buttonControlPanel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTools
            // 
            this.buttonTools.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTools.Location = new System.Drawing.Point(290, 69);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(213, 85);
            this.buttonTools.TabIndex = 0;
            this.buttonTools.Text = "Araçlar";
            this.buttonTools.UseVisualStyleBackColor = false;
            this.buttonTools.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFeatures
            // 
            this.buttonFeatures.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFeatures.Location = new System.Drawing.Point(290, 201);
            this.buttonFeatures.Name = "buttonFeatures";
            this.buttonFeatures.Size = new System.Drawing.Size(213, 85);
            this.buttonFeatures.TabIndex = 1;
            this.buttonFeatures.Text = "Özellikler";
            this.buttonFeatures.UseVisualStyleBackColor = false;
            this.buttonFeatures.Click += new System.EventHandler(this.buttonFeatures_Click);
            // 
            // buttonControlPanel
            // 
            this.buttonControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonControlPanel.Location = new System.Drawing.Point(290, 343);
            this.buttonControlPanel.Name = "buttonControlPanel";
            this.buttonControlPanel.Size = new System.Drawing.Size(213, 85);
            this.buttonControlPanel.TabIndex = 2;
            this.buttonControlPanel.Text = "Kontrol Paneli";
            this.buttonControlPanel.UseVisualStyleBackColor = false;
            this.buttonControlPanel.Click += new System.EventHandler(this.buttonControlPanel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IsletimSistemleri.Properties.Resources.sdfvbn;
            this.pictureBox3.Location = new System.Drawing.Point(120, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IsletimSistemleri.Properties.Resources.csc;
            this.pictureBox2.Location = new System.Drawing.Point(120, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsletimSistemleri.Properties.Resources.support;
            this.pictureBox1.Location = new System.Drawing.Point(120, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonControlPanel);
            this.Controls.Add(this.buttonFeatures);
            this.Controls.Add(this.buttonTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÜ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonFeatures;
        private System.Windows.Forms.Button buttonControlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}