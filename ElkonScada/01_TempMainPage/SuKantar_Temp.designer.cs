namespace ElkonScada._01_TempMainPage
{
    partial class SuKantar_Temp
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
            this.XB4_SuKantar = new System.Windows.Forms.TextBox();
            this.s_SuKantarSeviye = new System.Windows.Forms.PictureBox();
            this.Sukantarboru3 = new System.Windows.Forms.PictureBox();
            this.is_ButonSuBosalt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.s_SuKantarSeviye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sukantarboru3)).BeginInit();
            this.SuspendLayout();
            // 
            // XB4_SuKantar
            // 
            this.XB4_SuKantar.BackColor = System.Drawing.Color.Silver;
            this.XB4_SuKantar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.XB4_SuKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.XB4_SuKantar.ForeColor = System.Drawing.Color.Black;
            this.XB4_SuKantar.Location = new System.Drawing.Point(7, 41);
            this.XB4_SuKantar.Name = "XB4_SuKantar";
            this.XB4_SuKantar.Size = new System.Drawing.Size(84, 19);
            this.XB4_SuKantar.TabIndex = 3;
            this.XB4_SuKantar.Text = "0.00";
            this.XB4_SuKantar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XB4_SuKantar.TextChanged += new System.EventHandler(this.XB4_SuKantar_TextChanged);
            // 
            // s_SuKantarSeviye
            // 
            this.s_SuKantarSeviye.Image = global::ElkonScada.Properties.Resources.Su_Kantar_01;
            this.s_SuKantarSeviye.Location = new System.Drawing.Point(-91, 0);
            this.s_SuKantarSeviye.Name = "s_SuKantarSeviye";
            this.s_SuKantarSeviye.Size = new System.Drawing.Size(303, 225);
            this.s_SuKantarSeviye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.s_SuKantarSeviye.TabIndex = 2;
            this.s_SuKantarSeviye.TabStop = false;
            // 
            // Sukantarboru3
            // 
            this.Sukantarboru3.Image = global::ElkonScada.Properties.Resources.Pipe_Vertical_Gray;
            this.Sukantarboru3.Location = new System.Drawing.Point(46, 204);
            this.Sukantarboru3.Name = "Sukantarboru3";
            this.Sukantarboru3.Size = new System.Drawing.Size(8, 8);
            this.Sukantarboru3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sukantarboru3.TabIndex = 7;
            this.Sukantarboru3.TabStop = false;
            // 
            // is_ButonSuBosalt
            // 
            this.is_ButonSuBosalt.FlatAppearance.BorderSize = 0;
            this.is_ButonSuBosalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.is_ButonSuBosalt.ForeColor = System.Drawing.Color.Transparent;
            this.is_ButonSuBosalt.Image = global::ElkonScada.Properties.Resources.Button_White;
            this.is_ButonSuBosalt.Location = new System.Drawing.Point(17, 208);
            this.is_ButonSuBosalt.Name = "is_ButonSuBosalt";
            this.is_ButonSuBosalt.Size = new System.Drawing.Size(65, 70);
            this.is_ButonSuBosalt.TabIndex = 6;
            this.is_ButonSuBosalt.UseMnemonic = false;
            this.is_ButonSuBosalt.UseVisualStyleBackColor = true;
            // 
            // SuKantar_Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Sukantarboru3);
            this.Controls.Add(this.is_ButonSuBosalt);
            this.Controls.Add(this.XB4_SuKantar);
            this.Controls.Add(this.s_SuKantarSeviye);
            this.Name = "SuKantar_Temp";
            this.Size = new System.Drawing.Size(101, 292);
            ((System.ComponentModel.ISupportInitialize)(this.s_SuKantarSeviye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sukantarboru3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XB4_SuKantar;
        private System.Windows.Forms.PictureBox s_SuKantarSeviye;
		private System.Windows.Forms.Button is_ButonSuBosalt;
        public System.Windows.Forms.PictureBox Sukantarboru3;
    }
}
