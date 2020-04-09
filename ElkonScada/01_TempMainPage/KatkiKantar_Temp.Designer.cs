namespace ElkonScada._01_TempMainPage
{
    partial class KatkiKantar_Temp
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
            this.XB5_KatKantar = new System.Windows.Forms.TextBox();
            this.s_KatkiKantari1_2Seviye = new System.Windows.Forms.PictureBox();
            this.Katkikantarboru1 = new System.Windows.Forms.PictureBox();
            this.is_KatkiBosaltButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.s_KatkiKantari1_2Seviye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katkikantarboru1)).BeginInit();
            this.SuspendLayout();
            // 
            // XB5_KatKantar
            // 
            this.XB5_KatKantar.BackColor = System.Drawing.Color.Navy;
            this.XB5_KatKantar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.XB5_KatKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.XB5_KatKantar.Location = new System.Drawing.Point(7, 78);
            this.XB5_KatKantar.Name = "XB5_KatKantar";
            this.XB5_KatKantar.Size = new System.Drawing.Size(84, 24);
            this.XB5_KatKantar.TabIndex = 1;
            this.XB5_KatKantar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // s_KatkiKantari1_2Seviye
            // 
            this.s_KatkiKantari1_2Seviye.Image = global::ElkonScada.Properties.Resources.Katki_Kantar_01;
            this.s_KatkiKantari1_2Seviye.Location = new System.Drawing.Point(-109, -7);
            this.s_KatkiKantari1_2Seviye.Name = "s_KatkiKantari1_2Seviye";
            this.s_KatkiKantari1_2Seviye.Size = new System.Drawing.Size(326, 255);
            this.s_KatkiKantari1_2Seviye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.s_KatkiKantari1_2Seviye.TabIndex = 0;
            this.s_KatkiKantari1_2Seviye.TabStop = false;
            // 
            // Katkikantarboru1
            // 
            this.Katkikantarboru1.Image = global::ElkonScada.Properties.Resources.Pipe_Vertical_Gray;
            this.Katkikantarboru1.Location = new System.Drawing.Point(46, 245);
            this.Katkikantarboru1.Name = "Katkikantarboru1";
            this.Katkikantarboru1.Size = new System.Drawing.Size(8, 8);
            this.Katkikantarboru1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Katkikantarboru1.TabIndex = 9;
            this.Katkikantarboru1.TabStop = false;
            // 
            // is_KatkiBosaltButon
            // 
            this.is_KatkiBosaltButon.FlatAppearance.BorderSize = 0;
            this.is_KatkiBosaltButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.is_KatkiBosaltButon.ForeColor = System.Drawing.Color.Transparent;
            this.is_KatkiBosaltButon.Image = global::ElkonScada.Properties.Resources.Button_White;
            this.is_KatkiBosaltButon.Location = new System.Drawing.Point(17, 249);
            this.is_KatkiBosaltButon.Name = "is_KatkiBosaltButon";
            this.is_KatkiBosaltButon.Size = new System.Drawing.Size(65, 70);
            this.is_KatkiBosaltButon.TabIndex = 8;
            this.is_KatkiBosaltButon.UseMnemonic = false;
            this.is_KatkiBosaltButon.UseVisualStyleBackColor = true;
            // 
            // KatkiKantar_Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Katkikantarboru1);
            this.Controls.Add(this.is_KatkiBosaltButon);
            this.Controls.Add(this.XB5_KatKantar);
            this.Controls.Add(this.s_KatkiKantari1_2Seviye);
            this.Name = "KatkiKantar_Temp";
            this.Size = new System.Drawing.Size(100, 321);
            ((System.ComponentModel.ISupportInitialize)(this.s_KatkiKantari1_2Seviye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katkikantarboru1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox s_KatkiKantari1_2Seviye;
        private System.Windows.Forms.TextBox XB5_KatKantar;
        private System.Windows.Forms.Button is_KatkiBosaltButon;
        public System.Windows.Forms.PictureBox Katkikantarboru1;
    }
}
