namespace ElkonScada._100_LaumasTemple
{
    partial class Laumas_Katki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laumas_Katki));
            this.XB5_KatKantar = new System.Windows.Forms.TextBox();
            this.LaumasKatki = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // XB5_KatKantar
            // 
            this.XB5_KatKantar.BackColor = System.Drawing.Color.Brown;
            this.XB5_KatKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB5_KatKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XB5_KatKantar.Location = new System.Drawing.Point(19, 28);
            this.XB5_KatKantar.Name = "XB5_KatKantar";
            this.XB5_KatKantar.ReadOnly = true;
            this.XB5_KatKantar.Size = new System.Drawing.Size(117, 39);
            this.XB5_KatKantar.TabIndex = 8;
            this.XB5_KatKantar.Text = "0,00 kg";
            // 
            // LaumasKatki
            // 
            this.LaumasKatki.AutoSize = true;
            this.LaumasKatki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaumasKatki.ForeColor = System.Drawing.Color.White;
            this.LaumasKatki.Location = new System.Drawing.Point(6, 0);
            this.LaumasKatki.Name = "LaumasKatki";
            this.LaumasKatki.Size = new System.Drawing.Size(49, 20);
            this.LaumasKatki.TabIndex = 7;
            this.LaumasKatki.Text = "Katki";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Laumas_Katki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.XB5_KatKantar);
            this.Controls.Add(this.LaumasKatki);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Laumas_Katki";
            this.Size = new System.Drawing.Size(150, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaumasKatki;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox XB5_KatKantar;
    }
}
