namespace ElkonScada._100_LaumasTemple
{
    partial class Laumas_Agrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laumas_Agrega));
            this.XB2_AgregaKantar = new System.Windows.Forms.TextBox();
            this.LaumasAgrega = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // XB2_AgregaKantar
            // 
            this.XB2_AgregaKantar.BackColor = System.Drawing.Color.Brown;
            this.XB2_AgregaKantar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB2_AgregaKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XB2_AgregaKantar.Location = new System.Drawing.Point(19, 31);
            this.XB2_AgregaKantar.Name = "XB2_AgregaKantar";
            this.XB2_AgregaKantar.ReadOnly = true;
            this.XB2_AgregaKantar.Size = new System.Drawing.Size(117, 39);
            this.XB2_AgregaKantar.TabIndex = 5;
            this.XB2_AgregaKantar.Text = "0,00 kg";
            // 
            // LaumasAgrega
            // 
            this.LaumasAgrega.AutoSize = true;
            this.LaumasAgrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaumasAgrega.ForeColor = System.Drawing.Color.White;
            this.LaumasAgrega.Location = new System.Drawing.Point(6, 3);
            this.LaumasAgrega.Name = "LaumasAgrega";
            this.LaumasAgrega.Size = new System.Drawing.Size(67, 20);
            this.LaumasAgrega.TabIndex = 4;
            this.LaumasAgrega.Text = "Agrega";
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
            // Laumas_Agrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.XB2_AgregaKantar);
            this.Controls.Add(this.LaumasAgrega);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Laumas_Agrega";
            this.Size = new System.Drawing.Size(150, 100);
            this.Load += new System.EventHandler(this.Laumas_Agrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LaumasAgrega;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox XB2_AgregaKantar;
    }
}
