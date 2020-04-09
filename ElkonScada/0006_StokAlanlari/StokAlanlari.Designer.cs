namespace ElkonScada._0006_StokAlanlari
{
    partial class StokAlanlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokAlanlari));
            this.ES26_1 = new System.Windows.Forms.Label();
            this.stokalanlaridatagridview = new System.Windows.Forms.DataGridView();
            this.ES786_1 = new System.Windows.Forms.Button();
            this.ES2023_1 = new System.Windows.Forms.Button();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES764_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stokalanlaridatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES26_1
            // 
            this.ES26_1.AutoSize = true;
            this.ES26_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES26_1.Location = new System.Drawing.Point(862, 17);
            this.ES26_1.Name = "ES26_1";
            this.ES26_1.Size = new System.Drawing.Size(258, 46);
            this.ES26_1.TabIndex = 27;
            this.ES26_1.Text = "Stok Alanları";
            // 
            // stokalanlaridatagridview
            // 
            this.stokalanlaridatagridview.AllowUserToAddRows = false;
            this.stokalanlaridatagridview.AllowUserToDeleteRows = false;
            this.stokalanlaridatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stokalanlaridatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokalanlaridatagridview.Location = new System.Drawing.Point(12, 92);
            this.stokalanlaridatagridview.Name = "stokalanlaridatagridview";
            this.stokalanlaridatagridview.ReadOnly = true;
            this.stokalanlaridatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokalanlaridatagridview.Size = new System.Drawing.Size(1896, 704);
            this.stokalanlaridatagridview.TabIndex = 23;
            this.stokalanlaridatagridview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokalanlaridatagridview_CellEnter_1);
            // 
            // ES786_1
            // 
            this.ES786_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES786_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES786_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES786_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES786_1.Image = ((System.Drawing.Image)(resources.GetObject("ES786_1.Image")));
            this.ES786_1.Location = new System.Drawing.Point(12, 12);
            this.ES786_1.Name = "ES786_1";
            this.ES786_1.Size = new System.Drawing.Size(216, 74);
            this.ES786_1.TabIndex = 31;
            this.ES786_1.Text = "        Düzenle";
            this.ES786_1.UseVisualStyleBackColor = false;
            this.ES786_1.Click += new System.EventHandler(this.EditStorageAreaOpenEvent);
            // 
            // ES2023_1
            // 
            this.ES2023_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES2023_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES2023_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES2023_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2023_1.Image = ((System.Drawing.Image)(resources.GetObject("ES2023_1.Image")));
            this.ES2023_1.Location = new System.Drawing.Point(234, 12);
            this.ES2023_1.Name = "ES2023_1";
            this.ES2023_1.Size = new System.Drawing.Size(216, 74);
            this.ES2023_1.TabIndex = 37;
            this.ES2023_1.Text = "        Değiştir";
            this.ES2023_1.UseVisualStyleBackColor = false;
            this.ES2023_1.Click += new System.EventHandler(this.QuickEditStorageAreaOpenEvent);
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
            this.ES764_1.Click += new System.EventHandler(this.DeleteStorageAreaOpenEvent);
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
            this.ES1561_1.Click += new System.EventHandler(this.StorageAreaFileNameOpenEvent);
            // 
            // StokAlanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 996);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES764_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES2023_1);
            this.Controls.Add(this.ES786_1);
            this.Controls.Add(this.ES26_1);
            this.Controls.Add(this.stokalanlaridatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokAlanlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokAlanlari";
            this.Load += new System.EventHandler(this.StokAlanlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokalanlaridatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES26_1;
        private System.Windows.Forms.Button ES786_1;
        public System.Windows.Forms.DataGridView stokalanlaridatagridview;
        private System.Windows.Forms.Button ES2023_1;
        public System.Windows.Forms.Button ES15_1;
        public System.Windows.Forms.Button ES764_1;
        public System.Windows.Forms.Button ES1561_1;
    }
}