namespace ElkonScada._0007_ReceteReceipt
{
	partial class Recete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recete));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ES740_1 = new System.Windows.Forms.Button();
            this.ES757_1 = new System.Windows.Forms.Button();
            this.ES15_1 = new System.Windows.Forms.Button();
            this.ES729_1 = new System.Windows.Forms.Label();
            this.ES3017_1 = new System.Windows.Forms.Button();
            this.ES1561_1 = new System.Windows.Forms.Button();
            this.ES762_1 = new System.Windows.Forms.Button();
            this.ES1560_1 = new System.Windows.Forms.Button();
            this.recetelerdatagridview = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.recetelerdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(663, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 30);
            this.textBox1.TabIndex = 48;
            // 
            // ES740_1
            // 
            this.ES740_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES740_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES740_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES740_1.Image = ((System.Drawing.Image)(resources.GetObject("ES740_1.Image")));
            this.ES740_1.Location = new System.Drawing.Point(1248, 12);
            this.ES740_1.Name = "ES740_1";
            this.ES740_1.Size = new System.Drawing.Size(216, 74);
            this.ES740_1.TabIndex = 46;
            this.ES740_1.Text = "          Reçete Aktar";
            this.ES740_1.UseVisualStyleBackColor = true;
            this.ES740_1.Click += new System.EventHandler(this.ES740_1_Click);
            // 
            // ES757_1
            // 
            this.ES757_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES757_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES757_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES757_1.Image = ((System.Drawing.Image)(resources.GetObject("ES757_1.Image")));
            this.ES757_1.Location = new System.Drawing.Point(1692, 802);
            this.ES757_1.Name = "ES757_1";
            this.ES757_1.Size = new System.Drawing.Size(216, 74);
            this.ES757_1.TabIndex = 39;
            this.ES757_1.Text = "Sil";
            this.ES757_1.UseVisualStyleBackColor = true;
            this.ES757_1.Click += new System.EventHandler(this.DeleteRecipeOpenEvent);
            // 
            // ES15_1
            // 
            this.ES15_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES15_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES15_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES15_1.Image = ((System.Drawing.Image)(resources.GetObject("ES15_1.Image")));
            this.ES15_1.Location = new System.Drawing.Point(12, 802);
            this.ES15_1.Name = "ES15_1";
            this.ES15_1.Size = new System.Drawing.Size(216, 74);
            this.ES15_1.TabIndex = 38;
            this.ES15_1.Text = "Kontrol Paneli";
            this.ES15_1.UseVisualStyleBackColor = true;
            // 
            // ES729_1
            // 
            this.ES729_1.AutoSize = true;
            this.ES729_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES729_1.Location = new System.Drawing.Point(699, 12);
            this.ES729_1.Name = "ES729_1";
            this.ES729_1.Size = new System.Drawing.Size(246, 25);
            this.ES729_1.TabIndex = 37;
            this.ES729_1.Text = "Devam Eden Recete Adı";
            // 
            // ES3017_1
            // 
            this.ES3017_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES3017_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES3017_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES3017_1.Image = ((System.Drawing.Image)(resources.GetObject("ES3017_1.Image")));
            this.ES3017_1.Location = new System.Drawing.Point(1470, 12);
            this.ES3017_1.Name = "ES3017_1";
            this.ES3017_1.Size = new System.Drawing.Size(216, 74);
            this.ES3017_1.TabIndex = 36;
            this.ES3017_1.Text = "       İçe Aktar";
            this.ES3017_1.UseVisualStyleBackColor = true;
            this.ES3017_1.Click += new System.EventHandler(this.RecipeImportOpenEvent);
            // 
            // ES1561_1
            // 
            this.ES1561_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES1561_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1561_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1561_1.Image = ((System.Drawing.Image)(resources.GetObject("ES1561_1.Image")));
            this.ES1561_1.Location = new System.Drawing.Point(1692, 12);
            this.ES1561_1.Name = "ES1561_1";
            this.ES1561_1.Size = new System.Drawing.Size(216, 74);
            this.ES1561_1.TabIndex = 35;
            this.ES1561_1.Text = "     Dısa Aktar";
            this.ES1561_1.UseVisualStyleBackColor = true;
            this.ES1561_1.Click += new System.EventHandler(this.RecipeFileNameOpenEvent);
            // 
            // ES762_1
            // 
            this.ES762_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES762_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES762_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES762_1.Image = ((System.Drawing.Image)(resources.GetObject("ES762_1.Image")));
            this.ES762_1.Location = new System.Drawing.Point(234, 12);
            this.ES762_1.Name = "ES762_1";
            this.ES762_1.Size = new System.Drawing.Size(216, 74);
            this.ES762_1.TabIndex = 34;
            this.ES762_1.Text = "            Reçete Düzenle";
            this.ES762_1.UseVisualStyleBackColor = true;
            this.ES762_1.Click += new System.EventHandler(this.EditRecipeOpenEvent);
            // 
            // ES1560_1
            // 
            this.ES1560_1.BackColor = System.Drawing.SystemColors.Control;
            this.ES1560_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES1560_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1560_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1560_1.Image = ((System.Drawing.Image)(resources.GetObject("ES1560_1.Image")));
            this.ES1560_1.Location = new System.Drawing.Point(12, 12);
            this.ES1560_1.Name = "ES1560_1";
            this.ES1560_1.Size = new System.Drawing.Size(216, 74);
            this.ES1560_1.TabIndex = 33;
            this.ES1560_1.Text = "        Yeni Reçete";
            this.ES1560_1.UseVisualStyleBackColor = false;
            this.ES1560_1.Click += new System.EventHandler(this.NewRecipeOpenEvent);
            // 
            // recetelerdatagridview
            // 
            this.recetelerdatagridview.AllowUserToAddRows = false;
            this.recetelerdatagridview.AllowUserToDeleteRows = false;
            this.recetelerdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetelerdatagridview.Location = new System.Drawing.Point(12, 92);
            this.recetelerdatagridview.MultiSelect = false;
            this.recetelerdatagridview.Name = "recetelerdatagridview";
            this.recetelerdatagridview.ReadOnly = true;
            this.recetelerdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recetelerdatagridview.Size = new System.Drawing.Size(1896, 704);
            this.recetelerdatagridview.TabIndex = 49;
            this.recetelerdatagridview.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.recetelerdatagridview_CellEnter);
            this.recetelerdatagridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recetelerdatagridview_CellMouseClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = " \"Excel files |*.xls;*.xlsx;*.xlsm;\"";
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 996);
            this.Controls.Add(this.recetelerdatagridview);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ES740_1);
            this.Controls.Add(this.ES757_1);
            this.Controls.Add(this.ES15_1);
            this.Controls.Add(this.ES729_1);
            this.Controls.Add(this.ES3017_1);
            this.Controls.Add(this.ES1561_1);
            this.Controls.Add(this.ES762_1);
            this.Controls.Add(this.ES1560_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recete";
            this.Text = "Recete";
            this.Load += new System.EventHandler(this.Recete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recetelerdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button ES740_1;
		private System.Windows.Forms.Button ES757_1;
		private System.Windows.Forms.Button ES15_1;
		private System.Windows.Forms.Label ES729_1;
		private System.Windows.Forms.Button ES3017_1;
		private System.Windows.Forms.Button ES1561_1;
		private System.Windows.Forms.Button ES762_1;
		private System.Windows.Forms.Button ES1560_1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.DataGridView recetelerdatagridview;
    }
}