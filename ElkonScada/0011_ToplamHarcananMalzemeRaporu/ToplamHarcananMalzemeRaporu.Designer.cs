namespace ElkonScada._0011_ToplamHarcananMalzemeRaporu
{
    partial class ToplamHarcananMalzemeRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToplamHarcananMalzemeRaporu));
            this.ES30_1 = new System.Windows.Forms.Label();
            this.toplamharcananmalzemeraporudatagridview = new System.Windows.Forms.DataGridView();
            this.ES1621_1 = new System.Windows.Forms.Button();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toplamharcananmalzemeraporudatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES30_1
            // 
            this.ES30_1.AutoSize = true;
            this.ES30_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES30_1.Location = new System.Drawing.Point(623, 17);
            this.ES30_1.Name = "ES30_1";
            this.ES30_1.Size = new System.Drawing.Size(681, 46);
            this.ES30_1.TabIndex = 47;
            this.ES30_1.Text = "Toplam Harcanan Malzeme Raporu";
            // 
            // toplamharcananmalzemeraporudatagridview
            // 
            this.toplamharcananmalzemeraporudatagridview.AllowUserToAddRows = false;
            this.toplamharcananmalzemeraporudatagridview.AllowUserToDeleteRows = false;
            this.toplamharcananmalzemeraporudatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toplamharcananmalzemeraporudatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toplamharcananmalzemeraporudatagridview.Location = new System.Drawing.Point(12, 92);
            this.toplamharcananmalzemeraporudatagridview.Name = "toplamharcananmalzemeraporudatagridview";
            this.toplamharcananmalzemeraporudatagridview.ReadOnly = true;
            this.toplamharcananmalzemeraporudatagridview.RowHeadersWidth = 51;
            this.toplamharcananmalzemeraporudatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toplamharcananmalzemeraporudatagridview.Size = new System.Drawing.Size(1896, 704);
            this.toplamharcananmalzemeraporudatagridview.TabIndex = 42;
            // 
            // ES1621_1
            // 
            this.ES1621_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES1621_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES1621_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1621_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1621_1.Image = ((System.Drawing.Image)(resources.GetObject("ES1621_1.Image")));
            this.ES1621_1.Location = new System.Drawing.Point(12, 12);
            this.ES1621_1.Name = "ES1621_1";
            this.ES1621_1.Size = new System.Drawing.Size(216, 74);
            this.ES1621_1.TabIndex = 52;
            this.ES1621_1.Text = "          Arşiv";
            this.ES1621_1.UseVisualStyleBackColor = false;
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
            this.ES15_1.TabIndex = 56;
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
            this.ES1561_1.TabIndex = 53;
            this.ES1561_1.Text = "            Dışa Aktar";
            this.ES1561_1.UseVisualStyleBackColor = false;
            this.ES1561_1.Click += new System.EventHandler(this.TotalMaterialUsageReportFileNameOpenEvent);
            // 
            // ToplamHarcananMalzemeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 749);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES1621_1);
            this.Controls.Add(this.ES30_1);
            this.Controls.Add(this.toplamharcananmalzemeraporudatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToplamHarcananMalzemeRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToplamHarcananMalzemeRaporu";
            this.Load += new System.EventHandler(this.ToplamHarcananMalzemeRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplamharcananmalzemeraporudatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES30_1;
        private System.Windows.Forms.Button ES1621_1;
        public System.Windows.Forms.DataGridView toplamharcananmalzemeraporudatagridview;
        public System.Windows.Forms.Button ES15_1;
        public System.Windows.Forms.Button ES1561_1;
    }
}