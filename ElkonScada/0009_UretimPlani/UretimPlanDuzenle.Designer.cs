namespace ElkonScada._0009_UretimPlani
{
    partial class UretimPlanDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UretimPlanDuzenle));
            this.ES1845_1 = new System.Windows.Forms.Label();
            this.ES386_1 = new System.Windows.Forms.Button();
            this.siparislerdatagridview = new System.Windows.Forms.DataGridView();
            this.sirano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.santiyeadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparismiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapilanmiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanmiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.ES2066_0 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ES2065_0 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ES2064_0 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ES2067_0 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ES848_1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ES949_1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ES950_1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ES834_1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ES810_1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ES955_1 = new System.Windows.Forms.Label();
            this.manuelgirischeckbox2 = new System.Windows.Forms.CheckBox();
            this.manuelgirischeckbox1 = new System.Windows.Forms.CheckBox();
            this.siparismiktaritxt = new System.Windows.Forms.TextBox();
            this.recetetxt = new System.Windows.Forms.TextBox();
            this.ES956_1 = new System.Windows.Forms.Label();
            this.firmaaditxt = new System.Windows.Forms.TextBox();
            this.ES404_1 = new System.Windows.Forms.Label();
            this.santiyeaditxt = new System.Windows.Forms.TextBox();
            this.ES952_1 = new System.Windows.Forms.Label();
            this.ES842_1 = new System.Windows.Forms.Label();
            this.SurucuAdiSoyadiCbox = new System.Windows.Forms.ComboBox();
            this.AracPlakaNoCbox = new System.Windows.Forms.ComboBox();
            this.SiparisNoCbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES1845_1
            // 
            this.ES1845_1.AutoSize = true;
            this.ES1845_1.Location = new System.Drawing.Point(996, 9);
            this.ES1845_1.Name = "ES1845_1";
            this.ES1845_1.Size = new System.Drawing.Size(65, 13);
            this.ES1845_1.TabIndex = 190;
            this.ES1845_1.Text = "Manuel Giriş";
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(866, 615);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 189;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
            this.ES386_1.Click += new System.EventHandler(this.tamam_btn_click);
            // 
            // siparislerdatagridview
            // 
            this.siparislerdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparislerdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sirano,
            this.siparisno,
            this.firmaadi,
            this.santiyeadi,
            this.siparismiktari,
            this.receteadi,
            this.yapilanmiktar,
            this.kalanmiktar});
            this.siparislerdatagridview.Location = new System.Drawing.Point(17, 678);
            this.siparislerdatagridview.Name = "siparislerdatagridview";
            this.siparislerdatagridview.Size = new System.Drawing.Size(961, 171);
            this.siparislerdatagridview.TabIndex = 188;
            // 
            // sirano
            // 
            this.sirano.HeaderText = "Sıra No";
            this.sirano.Name = "sirano";
            this.sirano.Width = 70;
            // 
            // siparisno
            // 
            this.siparisno.HeaderText = "Sipariş No";
            this.siparisno.Name = "siparisno";
            this.siparisno.Width = 180;
            // 
            // firmaadi
            // 
            this.firmaadi.HeaderText = "Firma Adı";
            this.firmaadi.Name = "firmaadi";
            this.firmaadi.Width = 180;
            // 
            // santiyeadi
            // 
            this.santiyeadi.HeaderText = "Şantiye Adı";
            this.santiyeadi.Name = "santiyeadi";
            this.santiyeadi.Width = 180;
            // 
            // siparismiktari
            // 
            this.siparismiktari.HeaderText = "Sipariş Miktarı";
            this.siparismiktari.Name = "siparismiktari";
            this.siparismiktari.Width = 180;
            // 
            // receteadi
            // 
            this.receteadi.HeaderText = "Reçete Adı";
            this.receteadi.Name = "receteadi";
            this.receteadi.Width = 180;
            // 
            // yapilanmiktar
            // 
            this.yapilanmiktar.HeaderText = "Yapılan Miktar";
            this.yapilanmiktar.Name = "yapilanmiktar";
            this.yapilanmiktar.Width = 180;
            // 
            // kalanmiktar
            // 
            this.kalanmiktar.HeaderText = "Kalan Miktar";
            this.kalanmiktar.Name = "kalanmiktar";
            this.kalanmiktar.Width = 180;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox10.Location = new System.Drawing.Point(526, 578);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(452, 31);
            this.textBox10.TabIndex = 187;
            // 
            // ES2066_0
            // 
            this.ES2066_0.AutoSize = true;
            this.ES2066_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2066_0.Location = new System.Drawing.Point(12, 588);
            this.ES2066_0.Name = "ES2066_0";
            this.ES2066_0.Size = new System.Drawing.Size(245, 25);
            this.ES2066_0.TabIndex = 186;
            this.ES2066_0.Text = "İade Beton Açıklaması";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(526, 534);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(452, 31);
            this.textBox2.TabIndex = 185;
            // 
            // ES2065_0
            // 
            this.ES2065_0.AutoSize = true;
            this.ES2065_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2065_0.Location = new System.Drawing.Point(12, 544);
            this.ES2065_0.Name = "ES2065_0";
            this.ES2065_0.Size = new System.Drawing.Size(185, 25);
            this.ES2065_0.TabIndex = 184;
            this.ES2065_0.Text = "İade Beton Sınıfı";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(526, 490);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(452, 31);
            this.textBox4.TabIndex = 183;
            // 
            // ES2064_0
            // 
            this.ES2064_0.AutoSize = true;
            this.ES2064_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2064_0.Location = new System.Drawing.Point(12, 500);
            this.ES2064_0.Name = "ES2064_0";
            this.ES2064_0.Size = new System.Drawing.Size(203, 25);
            this.ES2064_0.TabIndex = 182;
            this.ES2064_0.Text = "İade Beton Miktarı";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(526, 446);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(452, 31);
            this.textBox6.TabIndex = 181;
            // 
            // ES2067_0
            // 
            this.ES2067_0.AutoSize = true;
            this.ES2067_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2067_0.Location = new System.Drawing.Point(12, 456);
            this.ES2067_0.Name = "ES2067_0";
            this.ES2067_0.Size = new System.Drawing.Size(168, 25);
            this.ES2067_0.TabIndex = 180;
            this.ES2067_0.Text = "İade Üretim No";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(526, 402);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(452, 31);
            this.textBox8.TabIndex = 179;
            // 
            // ES848_1
            // 
            this.ES848_1.AutoSize = true;
            this.ES848_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES848_1.Location = new System.Drawing.Point(12, 412);
            this.ES848_1.Name = "ES848_1";
            this.ES848_1.Size = new System.Drawing.Size(239, 25);
            this.ES848_1.TabIndex = 178;
            this.ES848_1.Text = "Üretilecek Miktar m^3";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox9.Location = new System.Drawing.Point(526, 358);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(452, 31);
            this.textBox9.TabIndex = 177;
            // 
            // ES949_1
            // 
            this.ES949_1.AutoSize = true;
            this.ES949_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES949_1.Location = new System.Drawing.Point(12, 368);
            this.ES949_1.Name = "ES949_1";
            this.ES949_1.Size = new System.Drawing.Size(139, 25);
            this.ES949_1.TabIndex = 176;
            this.ES949_1.Text = "Giriş Miktarı";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(526, 314);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(452, 31);
            this.textBox7.TabIndex = 175;
            // 
            // ES950_1
            // 
            this.ES950_1.AutoSize = true;
            this.ES950_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES950_1.Location = new System.Drawing.Point(12, 324);
            this.ES950_1.Name = "ES950_1";
            this.ES950_1.Size = new System.Drawing.Size(86, 25);
            this.ES950_1.TabIndex = 174;
            this.ES950_1.Text = "Reçete";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(526, 270);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(452, 31);
            this.textBox5.TabIndex = 173;
            // 
            // ES834_1
            // 
            this.ES834_1.AutoSize = true;
            this.ES834_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES834_1.Location = new System.Drawing.Point(12, 280);
            this.ES834_1.Name = "ES834_1";
            this.ES834_1.Size = new System.Drawing.Size(112, 25);
            this.ES834_1.TabIndex = 172;
            this.ES834_1.Text = "Firma Adı";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(526, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(452, 31);
            this.textBox3.TabIndex = 171;
            // 
            // ES810_1
            // 
            this.ES810_1.AutoSize = true;
            this.ES810_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES810_1.Location = new System.Drawing.Point(12, 236);
            this.ES810_1.Name = "ES810_1";
            this.ES810_1.Size = new System.Drawing.Size(132, 25);
            this.ES810_1.TabIndex = 170;
            this.ES810_1.Text = "Şantiye Adı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(526, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 31);
            this.textBox1.TabIndex = 169;
            // 
            // ES955_1
            // 
            this.ES955_1.AutoSize = true;
            this.ES955_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES955_1.Location = new System.Drawing.Point(12, 192);
            this.ES955_1.Name = "ES955_1";
            this.ES955_1.Size = new System.Drawing.Size(72, 25);
            this.ES955_1.TabIndex = 168;
            this.ES955_1.Text = "Kalan";
            // 
            // manuelgirischeckbox2
            // 
            this.manuelgirischeckbox2.AutoSize = true;
            this.manuelgirischeckbox2.Location = new System.Drawing.Point(1023, 61);
            this.manuelgirischeckbox2.Name = "manuelgirischeckbox2";
            this.manuelgirischeckbox2.Size = new System.Drawing.Size(15, 14);
            this.manuelgirischeckbox2.TabIndex = 167;
            this.manuelgirischeckbox2.UseVisualStyleBackColor = true;
            // 
            // manuelgirischeckbox1
            // 
            this.manuelgirischeckbox1.AutoSize = true;
            this.manuelgirischeckbox1.Location = new System.Drawing.Point(1023, 106);
            this.manuelgirischeckbox1.Name = "manuelgirischeckbox1";
            this.manuelgirischeckbox1.Size = new System.Drawing.Size(15, 14);
            this.manuelgirischeckbox1.TabIndex = 166;
            this.manuelgirischeckbox1.UseVisualStyleBackColor = true;
            // 
            // siparismiktaritxt
            // 
            this.siparismiktaritxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.siparismiktaritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparismiktaritxt.ForeColor = System.Drawing.SystemColors.Window;
            this.siparismiktaritxt.Location = new System.Drawing.Point(526, 138);
            this.siparismiktaritxt.Name = "siparismiktaritxt";
            this.siparismiktaritxt.Size = new System.Drawing.Size(452, 31);
            this.siparismiktaritxt.TabIndex = 162;
            // 
            // recetetxt
            // 
            this.recetetxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recetetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recetetxt.ForeColor = System.Drawing.SystemColors.Window;
            this.recetetxt.Location = new System.Drawing.Point(526, 94);
            this.recetetxt.Name = "recetetxt";
            this.recetetxt.Size = new System.Drawing.Size(452, 31);
            this.recetetxt.TabIndex = 163;
            // 
            // ES956_1
            // 
            this.ES956_1.AutoSize = true;
            this.ES956_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES956_1.Location = new System.Drawing.Point(12, 148);
            this.ES956_1.Name = "ES956_1";
            this.ES956_1.Size = new System.Drawing.Size(92, 25);
            this.ES956_1.TabIndex = 158;
            this.ES956_1.Text = "Yapılan";
            // 
            // firmaaditxt
            // 
            this.firmaaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.firmaaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.firmaaditxt.Location = new System.Drawing.Point(526, 50);
            this.firmaaditxt.Name = "firmaaditxt";
            this.firmaaditxt.Size = new System.Drawing.Size(452, 31);
            this.firmaaditxt.TabIndex = 164;
            // 
            // ES404_1
            // 
            this.ES404_1.AutoSize = true;
            this.ES404_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES404_1.Location = new System.Drawing.Point(12, 100);
            this.ES404_1.Name = "ES404_1";
            this.ES404_1.Size = new System.Drawing.Size(206, 25);
            this.ES404_1.TabIndex = 159;
            this.ES404_1.Text = "Sürücü Adı Soyadı";
            // 
            // santiyeaditxt
            // 
            this.santiyeaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.santiyeaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.santiyeaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.santiyeaditxt.Location = new System.Drawing.Point(526, 6);
            this.santiyeaditxt.Name = "santiyeaditxt";
            this.santiyeaditxt.Size = new System.Drawing.Size(452, 31);
            this.santiyeaditxt.TabIndex = 165;
            // 
            // ES952_1
            // 
            this.ES952_1.AutoSize = true;
            this.ES952_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES952_1.Location = new System.Drawing.Point(12, 9);
            this.ES952_1.Name = "ES952_1";
            this.ES952_1.Size = new System.Drawing.Size(121, 25);
            this.ES952_1.TabIndex = 160;
            this.ES952_1.Text = "Sipariş No";
            // 
            // ES842_1
            // 
            this.ES842_1.AutoSize = true;
            this.ES842_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES842_1.Location = new System.Drawing.Point(12, 55);
            this.ES842_1.Name = "ES842_1";
            this.ES842_1.Size = new System.Drawing.Size(162, 25);
            this.ES842_1.TabIndex = 161;
            this.ES842_1.Text = "Araç Plaka No";
            // 
            // SurucuAdiSoyadiCbox
            // 
            this.SurucuAdiSoyadiCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurucuAdiSoyadiCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SurucuAdiSoyadiCbox.FormattingEnabled = true;
            this.SurucuAdiSoyadiCbox.Location = new System.Drawing.Point(248, 92);
            this.SurucuAdiSoyadiCbox.Name = "SurucuAdiSoyadiCbox";
            this.SurucuAdiSoyadiCbox.Size = new System.Drawing.Size(272, 33);
            this.SurucuAdiSoyadiCbox.TabIndex = 191;
            // 
            // AracPlakaNoCbox
            // 
            this.AracPlakaNoCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AracPlakaNoCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracPlakaNoCbox.FormattingEnabled = true;
            this.AracPlakaNoCbox.Location = new System.Drawing.Point(248, 47);
            this.AracPlakaNoCbox.Name = "AracPlakaNoCbox";
            this.AracPlakaNoCbox.Size = new System.Drawing.Size(272, 33);
            this.AracPlakaNoCbox.TabIndex = 192;
            // 
            // SiparisNoCbox
            // 
            this.SiparisNoCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SiparisNoCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisNoCbox.FormattingEnabled = true;
            this.SiparisNoCbox.Location = new System.Drawing.Point(248, 4);
            this.SiparisNoCbox.Name = "SiparisNoCbox";
            this.SiparisNoCbox.Size = new System.Drawing.Size(272, 33);
            this.SiparisNoCbox.TabIndex = 193;
            // 
            // UretimPlanDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.SurucuAdiSoyadiCbox);
            this.Controls.Add(this.AracPlakaNoCbox);
            this.Controls.Add(this.SiparisNoCbox);
            this.Controls.Add(this.ES1845_1);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.siparislerdatagridview);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.ES2066_0);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ES2065_0);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ES2064_0);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ES2067_0);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.ES848_1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.ES949_1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ES950_1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ES834_1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ES810_1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ES955_1);
            this.Controls.Add(this.manuelgirischeckbox2);
            this.Controls.Add(this.manuelgirischeckbox1);
            this.Controls.Add(this.siparismiktaritxt);
            this.Controls.Add(this.recetetxt);
            this.Controls.Add(this.ES956_1);
            this.Controls.Add(this.firmaaditxt);
            this.Controls.Add(this.ES404_1);
            this.Controls.Add(this.santiyeaditxt);
            this.Controls.Add(this.ES952_1);
            this.Controls.Add(this.ES842_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UretimPlanDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanDuzenle";
            this.Load += new System.EventHandler(this.PlanDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparislerdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ES1845_1;
        private System.Windows.Forms.Button ES386_1;
        private System.Windows.Forms.DataGridView siparislerdatagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirano;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisno;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn santiyeadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparismiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanmiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanmiktar;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label ES2066_0;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ES2065_0;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ES2064_0;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label ES2067_0;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label ES848_1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label ES949_1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label ES950_1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label ES834_1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ES810_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ES955_1;
        private System.Windows.Forms.CheckBox manuelgirischeckbox2;
        private System.Windows.Forms.CheckBox manuelgirischeckbox1;
        private System.Windows.Forms.TextBox siparismiktaritxt;
        private System.Windows.Forms.TextBox recetetxt;
        private System.Windows.Forms.Label ES956_1;
        private System.Windows.Forms.TextBox firmaaditxt;
        private System.Windows.Forms.Label ES404_1;
        private System.Windows.Forms.TextBox santiyeaditxt;
        private System.Windows.Forms.Label ES952_1;
        private System.Windows.Forms.Label ES842_1;
        private System.Windows.Forms.ComboBox SurucuAdiSoyadiCbox;
        private System.Windows.Forms.ComboBox AracPlakaNoCbox;
        private System.Windows.Forms.ComboBox SiparisNoCbox;
    }
}