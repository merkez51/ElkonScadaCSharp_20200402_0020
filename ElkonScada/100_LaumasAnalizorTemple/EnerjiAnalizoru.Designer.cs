namespace ElkonScada._100_LaumasAnalizorTemple
{
    partial class EnerjiAnalizoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnerjiAnalizoru));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Agrega1_Value_FromPLC = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Agrega1_Value_FromPLC
            // 
            this.Agrega1_Value_FromPLC.BackColor = System.Drawing.Color.Brown;
            this.Agrega1_Value_FromPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agrega1_Value_FromPLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Agrega1_Value_FromPLC.Location = new System.Drawing.Point(35, 14);
            this.Agrega1_Value_FromPLC.Name = "Agrega1_Value_FromPLC";
            this.Agrega1_Value_FromPLC.ReadOnly = true;
            this.Agrega1_Value_FromPLC.Size = new System.Drawing.Size(118, 39);
            this.Agrega1_Value_FromPLC.TabIndex = 6;
            this.Agrega1_Value_FromPLC.Text = "0,00 kg";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(35, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 39);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0,00 kg";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Brown;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(35, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(118, 39);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0,00 kg";
            // 
            // EnerjiAnalizoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Agrega1_Value_FromPLC);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EnerjiAnalizoru";
            this.Size = new System.Drawing.Size(200, 186);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Agrega1_Value_FromPLC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
