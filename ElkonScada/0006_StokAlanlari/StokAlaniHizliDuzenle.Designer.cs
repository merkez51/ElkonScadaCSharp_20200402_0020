namespace ElkonScada._0006_StokAlanlari
{
    partial class StokAlaniHizliDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokAlaniHizliDuzenle));
            this.malzemeadicmb = new System.Windows.Forms.ComboBox();
            this.malzemeadihizlitxt = new System.Windows.Forms.TextBox();
            this.ES807_1 = new System.Windows.Forms.Label();
            this.ES2025_0 = new System.Windows.Forms.Label();
            this.ES386_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // malzemeadicmb
            // 
            this.malzemeadicmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeadicmb.FormattingEnabled = true;
            this.malzemeadicmb.Location = new System.Drawing.Point(617, 84);
            this.malzemeadicmb.Name = "malzemeadicmb";
            this.malzemeadicmb.Size = new System.Drawing.Size(267, 33);
            this.malzemeadicmb.TabIndex = 52;
            // 
            // malzemeadihizlitxt
            // 
            this.malzemeadihizlitxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.malzemeadihizlitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeadihizlitxt.ForeColor = System.Drawing.SystemColors.Window;
            this.malzemeadihizlitxt.Location = new System.Drawing.Point(198, 84);
            this.malzemeadihizlitxt.Name = "malzemeadihizlitxt";
            this.malzemeadihizlitxt.Size = new System.Drawing.Size(413, 31);
            this.malzemeadihizlitxt.TabIndex = 51;
            // 
            // ES807_1
            // 
            this.ES807_1.AutoSize = true;
            this.ES807_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES807_1.Location = new System.Drawing.Point(12, 87);
            this.ES807_1.Name = "ES807_1";
            this.ES807_1.Size = new System.Drawing.Size(147, 25);
            this.ES807_1.TabIndex = 50;
            this.ES807_1.Text = "Malzeme Adı";
            // 
            // ES2025_0
            // 
            this.ES2025_0.AutoSize = true;
            this.ES2025_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2025_0.Location = new System.Drawing.Point(12, 9);
            this.ES2025_0.Name = "ES2025_0";
            this.ES2025_0.Size = new System.Drawing.Size(792, 31);
            this.ES2025_0.TabIndex = 49;
            this.ES2025_0.Text = "Stok alanındaki malzemeyi değiştirmek için yeni malzeme seçiniz";
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(772, 179);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 57;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
 
            // 
            // StokAlaniHizliDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 248);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.malzemeadicmb);
            this.Controls.Add(this.malzemeadihizlitxt);
            this.Controls.Add(this.ES807_1);
            this.Controls.Add(this.ES2025_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokAlaniHizliDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokAlaniHizliDuzenle";
            this.Load += new System.EventHandler(this.StokAlaniHizliDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox malzemeadicmb;
        private System.Windows.Forms.TextBox malzemeadihizlitxt;
        private System.Windows.Forms.Label ES807_1;
        private System.Windows.Forms.Label ES2025_0;
        private System.Windows.Forms.Button ES386_1;
    }
}