namespace ElkonScada._0002_Araclar
{
    partial class Araclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Araclar));
            this.ES22_1 = new System.Windows.Forms.Label();
            this.araclardatagridview = new System.Windows.Forms.DataGridView();
            this.ES1560_1 = new System.Windows.Forms.Button();
            this.ES762_1 = new System.Windows.Forms.Button();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES764_1 = new System.Windows.Forms.Button();
            this.ES3017_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.araclardatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES22_1
            // 
            this.ES22_1.AutoSize = true;
            this.ES22_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES22_1.Location = new System.Drawing.Point(897, 17);
            this.ES22_1.Name = "ES22_1";
            this.ES22_1.Size = new System.Drawing.Size(154, 46);
            this.ES22_1.TabIndex = 28;
            this.ES22_1.Text = "Araçlar";
            // 
            // araclardatagridview
            // 
            this.araclardatagridview.AllowUserToAddRows = false;
            this.araclardatagridview.AllowUserToDeleteRows = false;
            this.araclardatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.araclardatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.araclardatagridview.Location = new System.Drawing.Point(22, 84);
            this.araclardatagridview.Name = "araclardatagridview";
            this.araclardatagridview.ReadOnly = true;
            this.araclardatagridview.RowHeadersWidth = 51;
            this.araclardatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.araclardatagridview.Size = new System.Drawing.Size(1896, 704);
            this.araclardatagridview.TabIndex = 23;
            this.araclardatagridview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.araclardatagridview_CellEnter);
            // 
            // ES1560_1
            // 
            this.ES1560_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES1560_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES1560_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1560_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1560_1.Image = ((System.Drawing.Image)(resources.GetObject("ES1560_1.Image")));
            this.ES1560_1.Location = new System.Drawing.Point(12, 12);
            this.ES1560_1.Name = "ES1560_1";
            this.ES1560_1.Size = new System.Drawing.Size(216, 74);
            this.ES1560_1.TabIndex = 29;
            this.ES1560_1.Text = "      Yeni";
            this.ES1560_1.UseVisualStyleBackColor = false;
            this.ES1560_1.Click += new System.EventHandler(this.NewVehicleOpenEvent);
            // 
            // ES762_1
            // 
            this.ES762_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES762_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES762_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES762_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES762_1.Image = ((System.Drawing.Image)(resources.GetObject("ES762_1.Image")));
            this.ES762_1.Location = new System.Drawing.Point(234, 12);
            this.ES762_1.Name = "ES762_1";
            this.ES762_1.Size = new System.Drawing.Size(216, 74);
            this.ES762_1.TabIndex = 35;
            this.ES762_1.Text = "        Düzenle";
            this.ES762_1.UseVisualStyleBackColor = false;
            this.ES762_1.Click += new System.EventHandler(this.EditVehicleInfoOpenEvent);
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
            this.ES15_1.TabIndex = 39;
            this.ES15_1.Text = "Kontrol Paneli";
            this.ES15_1.UseVisualStyleBackColor = false;
            // 
            // ES764_1
            // 
            this.ES764_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES764_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES764_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES764_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES764_1.Image = ((System.Drawing.Image)(resources.GetObject("ES764_1.Image")));
            this.ES764_1.Location = new System.Drawing.Point(1692, 802);
            this.ES764_1.Name = "ES764_1";
            this.ES764_1.Size = new System.Drawing.Size(216, 74);
            this.ES764_1.TabIndex = 38;
            this.ES764_1.Text = "    Sil";
            this.ES764_1.UseVisualStyleBackColor = false;
            this.ES764_1.Click += new System.EventHandler(this.DeleteVehicleOpenEvent);
            // 
            // ES3017_1
            // 
            this.ES3017_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES3017_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES3017_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES3017_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES3017_1.Image = ((System.Drawing.Image)(resources.GetObject("ES3017_1.Image")));
            this.ES3017_1.Location = new System.Drawing.Point(1470, 12);
            this.ES3017_1.Name = "ES3017_1";
            this.ES3017_1.Size = new System.Drawing.Size(216, 74);
            this.ES3017_1.TabIndex = 37;
            this.ES3017_1.Text = "           İçe Aktar";
            this.ES3017_1.UseVisualStyleBackColor = false;
            this.ES3017_1.Click += new System.EventHandler(this.VehicleImportOpenEvent);
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
            this.ES1561_1.TabIndex = 36;
            this.ES1561_1.Text = "            Dışa Aktar";
            this.ES1561_1.UseVisualStyleBackColor = false;
            this.ES1561_1.Click += new System.EventHandler(this.VehicleFileNameOpenEvent);
            // 
            // Araclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES764_1);
            this.Controls.Add(this.ES3017_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES762_1);
            this.Controls.Add(this.ES1560_1);
            this.Controls.Add(this.ES22_1);
            this.Controls.Add(this.araclardatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Araclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araclar";
            this.Load += new System.EventHandler(this.Araclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.araclardatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES22_1;
        private System.Windows.Forms.Button ES1560_1;
        public System.Windows.Forms.DataGridView araclardatagridview;
        public System.Windows.Forms.Button ES762_1;
        public System.Windows.Forms.Button ES15_1;
        public System.Windows.Forms.Button ES764_1;
        public System.Windows.Forms.Button ES3017_1;
        public System.Windows.Forms.Button ES1561_1;
    }
}