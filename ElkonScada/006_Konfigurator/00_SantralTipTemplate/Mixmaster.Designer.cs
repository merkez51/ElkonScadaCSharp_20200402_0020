namespace ElkonScada._006_Konfigurator._00_SantralTipTemplate
{
    partial class Mixmaster
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ES3035_0 = new System.Windows.Forms.Label();
            this.ES3034_0 = new System.Windows.Forms.Label();
            this.Mixmaster4x5 = new System.Windows.Forms.PictureBox();
            this.Mixmaster2x5 = new System.Windows.Forms.PictureBox();
            this.SecilenSantral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Mixmaster4x5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mixmaster2x5)).BeginInit();
            this.SuspendLayout();
            // 
            // ES3035_0
            // 
            this.ES3035_0.AutoSize = true;
            this.ES3035_0.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES3035_0.Location = new System.Drawing.Point(418, 197);
            this.ES3035_0.Name = "ES3035_0";
            this.ES3035_0.Size = new System.Drawing.Size(130, 22);
            this.ES3035_0.TabIndex = 25;
            this.ES3035_0.Text = "Mixmaster 4x5";
            // 
            // ES3034_0
            // 
            this.ES3034_0.AutoSize = true;
            this.ES3034_0.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES3034_0.Location = new System.Drawing.Point(80, 197);
            this.ES3034_0.Name = "ES3034_0";
            this.ES3034_0.Size = new System.Drawing.Size(130, 22);
            this.ES3034_0.TabIndex = 24;
            this.ES3034_0.Text = "Mixmaster 2x5";
            // 
            // Mixmaster4x5
            // 
            this.Mixmaster4x5.Image = global::ElkonScada.Properties.Resources.MM_304;
            this.Mixmaster4x5.Location = new System.Drawing.Point(323, 3);
            this.Mixmaster4x5.Name = "Mixmaster4x5";
            this.Mixmaster4x5.Size = new System.Drawing.Size(297, 191);
            this.Mixmaster4x5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mixmaster4x5.TabIndex = 23;
            this.Mixmaster4x5.TabStop = false;
            this.Mixmaster4x5.Click += new System.EventHandler(this.Mixmaster4x5_Click);
            // 
            // Mixmaster2x5
            // 
            this.Mixmaster2x5.Image = global::ElkonScada.Properties.Resources.MM_302;
            this.Mixmaster2x5.Location = new System.Drawing.Point(3, 3);
            this.Mixmaster2x5.Name = "Mixmaster2x5";
            this.Mixmaster2x5.Size = new System.Drawing.Size(297, 191);
            this.Mixmaster2x5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mixmaster2x5.TabIndex = 22;
            this.Mixmaster2x5.TabStop = false;
            this.Mixmaster2x5.Click += new System.EventHandler(this.Mixmaster2x5_Click);
            // 
            // SecilenSantral
            // 
            this.SecilenSantral.BackgroundImage = global::ElkonScada.Properties.Resources.Elkomix_180_1_Blur;
            this.SecilenSantral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecilenSantral.Location = new System.Drawing.Point(626, 3);
            this.SecilenSantral.Name = "SecilenSantral";
            this.SecilenSantral.Size = new System.Drawing.Size(548, 406);
            this.SecilenSantral.TabIndex = 26;
            // 
            // Mixmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SecilenSantral);
            this.Controls.Add(this.ES3035_0);
            this.Controls.Add(this.ES3034_0);
            this.Controls.Add(this.Mixmaster4x5);
            this.Controls.Add(this.Mixmaster2x5);
            this.Name = "Mixmaster";
            this.Size = new System.Drawing.Size(1184, 521);
            this.Load += new System.EventHandler(this.Mixmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mixmaster4x5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mixmaster2x5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ES3035_0;
        private System.Windows.Forms.Label ES3034_0;
        private System.Windows.Forms.PictureBox Mixmaster4x5;
        private System.Windows.Forms.PictureBox Mixmaster2x5;
        public System.Windows.Forms.Panel SecilenSantral;
    }
}
