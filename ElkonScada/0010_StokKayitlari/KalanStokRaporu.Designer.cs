namespace ElkonScada._0010_StokKayitlari
{
    partial class KalanStokRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalanStokRaporu));
            this.ES32_1 = new System.Windows.Forms.Label();
            this.firmalardatagridview = new System.Windows.Forms.DataGridView();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmalardatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES32_1
            // 
            this.ES32_1.AutoSize = true;
            this.ES32_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES32_1.Location = new System.Drawing.Point(851, 17);
            this.ES32_1.Name = "ES32_1";
            this.ES32_1.Size = new System.Drawing.Size(264, 46);
            this.ES32_1.TabIndex = 32;
            this.ES32_1.Text = "Stok Durumu";
            // 
            // firmalardatagridview
            // 
            this.firmalardatagridview.AllowUserToAddRows = false;
            this.firmalardatagridview.AllowUserToDeleteRows = false;
            this.firmalardatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmalardatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmalardatagridview.Location = new System.Drawing.Point(12, 92);
            this.firmalardatagridview.Name = "firmalardatagridview";
            this.firmalardatagridview.ReadOnly = true;
            this.firmalardatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firmalardatagridview.Size = new System.Drawing.Size(1896, 704);
            this.firmalardatagridview.TabIndex = 31;
            // 
            // ES15_1
            // 
            this.ES15_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES15_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES15_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES15_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES15_1.Image = ((System.Drawing.Image)(resources.GetObject("ES15_1.Image")));
            this.ES15_1.Location = new System.Drawing.Point(12, 802);
            this.ES15_1.Name = "ES15_1";
            this.ES15_1.Size = new System.Drawing.Size(216, 74);
            this.ES15_1.TabIndex = 44;
            this.ES15_1.Text = "Kontrol Paneli";
            this.ES15_1.UseVisualStyleBackColor = false;
            // 
            // ES1561_1
            // 
            this.ES1561_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES1561_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES1561_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1561_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1561_1.Image = ((System.Drawing.Image)(resources.GetObject("ES1561_1.Image")));
            this.ES1561_1.Location = new System.Drawing.Point(1692, 12);
            this.ES1561_1.Name = "ES1561_1";
            this.ES1561_1.Size = new System.Drawing.Size(216, 74);
            this.ES1561_1.TabIndex = 41;
            this.ES1561_1.Text = "            Dışa Aktar";
            this.ES1561_1.UseVisualStyleBackColor = false;
            this.ES1561_1.Click += new System.EventHandler(this.RemainingInventoryReportFileNameOpenEvent);
            // 
            // KalanStokRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 996);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES32_1);
            this.Controls.Add(this.firmalardatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KalanStokRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KalanStokRaporu";
            this.Load += new System.EventHandler(this.KalanStokRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmalardatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES32_1;
        public System.Windows.Forms.DataGridView firmalardatagridview;
        public System.Windows.Forms.Button ES15_1;
        public System.Windows.Forms.Button ES1561_1;
    }
}