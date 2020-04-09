namespace ElkonScada._100_LaumasTemple
{
    partial class Laumas_Cimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laumas_Cimento));
            this.XB3_CMKantar = new System.Windows.Forms.TextBox();
            this.LaumasCimento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // XB3_CMKantar
            // 
            this.XB3_CMKantar.BackColor = System.Drawing.Color.Brown;
            this.XB3_CMKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB3_CMKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XB3_CMKantar.Location = new System.Drawing.Point(19, 31);
            this.XB3_CMKantar.Name = "XB3_CMKantar";
            this.XB3_CMKantar.ReadOnly = true;
            this.XB3_CMKantar.Size = new System.Drawing.Size(117, 39);
            this.XB3_CMKantar.TabIndex = 5;
            this.XB3_CMKantar.Text = "0,00 kg";
            // 
            // LaumasCimento
            // 
            this.LaumasCimento.AutoSize = true;
            this.LaumasCimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaumasCimento.ForeColor = System.Drawing.Color.White;
            this.LaumasCimento.Location = new System.Drawing.Point(6, 3);
            this.LaumasCimento.Name = "LaumasCimento";
            this.LaumasCimento.Size = new System.Drawing.Size(75, 20);
            this.LaumasCimento.TabIndex = 4;
            this.LaumasCimento.Text = "Cimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Laumas_Cimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.XB3_CMKantar);
            this.Controls.Add(this.LaumasCimento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Laumas_Cimento";
            this.Size = new System.Drawing.Size(150, 102);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaumasCimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox XB3_CMKantar;
    }
}
