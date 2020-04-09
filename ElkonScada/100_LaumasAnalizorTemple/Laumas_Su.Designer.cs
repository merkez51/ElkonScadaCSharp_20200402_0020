namespace ElkonScada._100_LaumasTemple
{
    partial class Laumas_Su
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laumas_Su));
            this.XB4_SuKantar = new System.Windows.Forms.TextBox();
            this.LaumasSu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // XB4_SuKantar
            // 
            this.XB4_SuKantar.BackColor = System.Drawing.Color.Brown;
            this.XB4_SuKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB4_SuKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XB4_SuKantar.Location = new System.Drawing.Point(19, 30);
            this.XB4_SuKantar.Name = "XB4_SuKantar";
            this.XB4_SuKantar.ReadOnly = true;
            this.XB4_SuKantar.Size = new System.Drawing.Size(117, 39);
            this.XB4_SuKantar.TabIndex = 8;
            this.XB4_SuKantar.Text = "0,00 kg";
            // 
            // LaumasSu
            // 
            this.LaumasSu.AutoSize = true;
            this.LaumasSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaumasSu.ForeColor = System.Drawing.Color.White;
            this.LaumasSu.Location = new System.Drawing.Point(6, 2);
            this.LaumasSu.Name = "LaumasSu";
            this.LaumasSu.Size = new System.Drawing.Size(31, 20);
            this.LaumasSu.TabIndex = 7;
            this.LaumasSu.Text = "Su";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Laumas_Su
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.XB4_SuKantar);
            this.Controls.Add(this.LaumasSu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Laumas_Su";
            this.Size = new System.Drawing.Size(150, 99);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaumasSu;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox XB4_SuKantar;
    }
}
