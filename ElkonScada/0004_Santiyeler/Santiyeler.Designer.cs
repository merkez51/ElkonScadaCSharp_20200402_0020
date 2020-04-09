namespace ElkonScada._0004_Santiyeler
{
    partial class Santiyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Santiyeler));
            this.ES23_1 = new System.Windows.Forms.Label();
            this.santiyelerdatagridview = new System.Windows.Forms.DataGridView();
            this.ES1560_1 = new System.Windows.Forms.Button();
            this.ES762_1 = new System.Windows.Forms.Button();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES764_1 = new System.Windows.Forms.Button();
            this.ES3017_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.santiyelerdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES23_1
            // 
            this.ES23_1.AutoSize = true;
            this.ES23_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES23_1.Location = new System.Drawing.Point(863, 17);
            this.ES23_1.Name = "ES23_1";
            this.ES23_1.Size = new System.Drawing.Size(207, 46);
            this.ES23_1.TabIndex = 28;
            this.ES23_1.Text = "Şantiyeler";
            // 
            // santiyelerdatagridview
            // 
            this.santiyelerdatagridview.AllowUserToAddRows = false;
            this.santiyelerdatagridview.AllowUserToDeleteRows = false;
            this.santiyelerdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.santiyelerdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.santiyelerdatagridview.Location = new System.Drawing.Point(12, 92);
            this.santiyelerdatagridview.Name = "santiyelerdatagridview";
            this.santiyelerdatagridview.ReadOnly = true;
            this.santiyelerdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.santiyelerdatagridview.Size = new System.Drawing.Size(1896, 704);
            this.santiyelerdatagridview.TabIndex = 23;
            this.santiyelerdatagridview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.santiyelerdatagridview_SelectionChanged);
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
            this.ES1560_1.TabIndex = 31;
            this.ES1560_1.Text = "      Yeni";
            this.ES1560_1.UseVisualStyleBackColor = false;
            this.ES1560_1.Click += new System.EventHandler(this.NewJobsiteOpenEvent);
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
            this.ES762_1.TabIndex = 37;
            this.ES762_1.Text = "        Düzenle";
            this.ES762_1.UseVisualStyleBackColor = false;
            this.ES762_1.Click += new System.EventHandler(this.EditJobsiteInfoOpenEvent);
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
            this.ES15_1.TabIndex = 41;
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
            this.ES764_1.TabIndex = 40;
            this.ES764_1.Text = "    Sil";
            this.ES764_1.UseVisualStyleBackColor = false;
            this.ES764_1.Click += new System.EventHandler(this.DeleteJobsiteOpenEvent);
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
            this.ES3017_1.TabIndex = 39;
            this.ES3017_1.Text = "           İçe Aktar";
            this.ES3017_1.UseVisualStyleBackColor = false;
            this.ES3017_1.Click += new System.EventHandler(this.JobsiteImportOpenEvent);
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
            this.ES1561_1.TabIndex = 38;
            this.ES1561_1.Text = "            Dışa Aktar";
            this.ES1561_1.UseVisualStyleBackColor = false;
            this.ES1561_1.Click += new System.EventHandler(this.JobsiteFileNameOpenEvent);
            // 
            // Santiyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 996);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES764_1);
            this.Controls.Add(this.ES3017_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES762_1);
            this.Controls.Add(this.ES1560_1);
            this.Controls.Add(this.ES23_1);
            this.Controls.Add(this.santiyelerdatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Santiyeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santiyeler";
            this.Load += new System.EventHandler(this.Santiyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.santiyelerdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES23_1;
        private System.Windows.Forms.Button ES1560_1;
        public System.Windows.Forms.DataGridView santiyelerdatagridview;
        public System.Windows.Forms.Button ES762_1;
        public System.Windows.Forms.Button ES15_1;
        public System.Windows.Forms.Button ES764_1;
        public System.Windows.Forms.Button ES3017_1;
        public System.Windows.Forms.Button ES1561_1;
    }
}