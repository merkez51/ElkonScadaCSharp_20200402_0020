namespace ElkonScada._0009_UretimPlani
{
    partial class UretimPlaniYeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UretimPlaniYeni));
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
            this.iadebetonaciklamasitxt = new System.Windows.Forms.TextBox();
            this.ES2066_0 = new System.Windows.Forms.Label();
            this.iadebetonsinifitxt = new System.Windows.Forms.TextBox();
            this.ES2065_0 = new System.Windows.Forms.Label();
            this.iadebetonmiktaritxt = new System.Windows.Forms.TextBox();
            this.ES2064_0 = new System.Windows.Forms.Label();
            this.iadeuretimnotxt = new System.Windows.Forms.TextBox();
            this.ES2067_0 = new System.Windows.Forms.Label();
            this.uretilecekmiktartxt = new System.Windows.Forms.TextBox();
            this.ES848_1 = new System.Windows.Forms.Label();
            this.girismiktaritxt = new System.Windows.Forms.TextBox();
            this.ES949_1 = new System.Windows.Forms.Label();
            this.recetetxt = new System.Windows.Forms.TextBox();
            this.ES950_1 = new System.Windows.Forms.Label();
            this.firmaaditxt = new System.Windows.Forms.TextBox();
            this.ES834_1 = new System.Windows.Forms.Label();
            this.santiyeaditxt = new System.Windows.Forms.TextBox();
            this.ES810_1 = new System.Windows.Forms.Label();
            this.kalantxt = new System.Windows.Forms.TextBox();
            this.ES955_1 = new System.Windows.Forms.Label();
            this.manuelgirischeckbox2 = new System.Windows.Forms.CheckBox();
            this.manuelgirischeckbox1 = new System.Windows.Forms.CheckBox();
            this.yapilantxt = new System.Windows.Forms.TextBox();
            this.surucuadisoyaditxt = new System.Windows.Forms.TextBox();
            this.ES956_1 = new System.Windows.Forms.Label();
            this.aracplakanotxt = new System.Windows.Forms.TextBox();
            this.ES404_1 = new System.Windows.Forms.Label();
            this.siparisnotxt = new System.Windows.Forms.TextBox();
            this.ES952_1 = new System.Windows.Forms.Label();
            this.ES842_1 = new System.Windows.Forms.Label();
            this.ES1845_1 = new System.Windows.Forms.Label();
            this.SurucuAdiSoyadiCbox = new System.Windows.Forms.ComboBox();
            this.AracPlakaNoCbox = new System.Windows.Forms.ComboBox();
            this.SiparisNoCbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(1155, 757);
            this.ES386_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(149, 70);
            this.ES386_1.TabIndex = 153;
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
            this.siparislerdatagridview.Location = new System.Drawing.Point(23, 832);
            this.siparislerdatagridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siparislerdatagridview.Name = "siparislerdatagridview";
            this.siparislerdatagridview.RowHeadersWidth = 51;
            this.siparislerdatagridview.Size = new System.Drawing.Size(1281, 210);
            this.siparislerdatagridview.TabIndex = 152;
            this.siparislerdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparislerdatagridview_CellContentClick);
            // 
            // sirano
            // 
            this.sirano.HeaderText = "Sıra No";
            this.sirano.MinimumWidth = 6;
            this.sirano.Name = "sirano";
            this.sirano.Width = 70;
            // 
            // siparisno
            // 
            this.siparisno.HeaderText = "Sipariş No";
            this.siparisno.MinimumWidth = 6;
            this.siparisno.Name = "siparisno";
            this.siparisno.Width = 180;
            // 
            // firmaadi
            // 
            this.firmaadi.HeaderText = "Firma Adı";
            this.firmaadi.MinimumWidth = 6;
            this.firmaadi.Name = "firmaadi";
            this.firmaadi.Width = 180;
            // 
            // santiyeadi
            // 
            this.santiyeadi.HeaderText = "Şantiye Adı";
            this.santiyeadi.MinimumWidth = 6;
            this.santiyeadi.Name = "santiyeadi";
            this.santiyeadi.Width = 180;
            // 
            // siparismiktari
            // 
            this.siparismiktari.HeaderText = "Sipariş Miktarı";
            this.siparismiktari.MinimumWidth = 6;
            this.siparismiktari.Name = "siparismiktari";
            this.siparismiktari.Width = 180;
            // 
            // receteadi
            // 
            this.receteadi.HeaderText = "Reçete Adı";
            this.receteadi.MinimumWidth = 6;
            this.receteadi.Name = "receteadi";
            this.receteadi.Width = 180;
            // 
            // yapilanmiktar
            // 
            this.yapilanmiktar.HeaderText = "Yapılan Miktar";
            this.yapilanmiktar.MinimumWidth = 6;
            this.yapilanmiktar.Name = "yapilanmiktar";
            this.yapilanmiktar.Width = 180;
            // 
            // kalanmiktar
            // 
            this.kalanmiktar.HeaderText = "Kalan Miktar";
            this.kalanmiktar.MinimumWidth = 6;
            this.kalanmiktar.Name = "kalanmiktar";
            this.kalanmiktar.Width = 180;
            // 
            // iadebetonaciklamasitxt
            // 
            this.iadebetonaciklamasitxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iadebetonaciklamasitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadebetonaciklamasitxt.ForeColor = System.Drawing.SystemColors.Window;
            this.iadebetonaciklamasitxt.Location = new System.Drawing.Point(701, 711);
            this.iadebetonaciklamasitxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iadebetonaciklamasitxt.Name = "iadebetonaciklamasitxt";
            this.iadebetonaciklamasitxt.Size = new System.Drawing.Size(601, 37);
            this.iadebetonaciklamasitxt.TabIndex = 151;
            // 
            // ES2066_0
            // 
            this.ES2066_0.AutoSize = true;
            this.ES2066_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2066_0.Location = new System.Drawing.Point(16, 724);
            this.ES2066_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES2066_0.Name = "ES2066_0";
            this.ES2066_0.Size = new System.Drawing.Size(303, 31);
            this.ES2066_0.TabIndex = 150;
            this.ES2066_0.Text = "İade Beton Açıklaması";
            // 
            // iadebetonsinifitxt
            // 
            this.iadebetonsinifitxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iadebetonsinifitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadebetonsinifitxt.ForeColor = System.Drawing.SystemColors.Window;
            this.iadebetonsinifitxt.Location = new System.Drawing.Point(701, 657);
            this.iadebetonsinifitxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iadebetonsinifitxt.Name = "iadebetonsinifitxt";
            this.iadebetonsinifitxt.Size = new System.Drawing.Size(601, 37);
            this.iadebetonsinifitxt.TabIndex = 149;
            // 
            // ES2065_0
            // 
            this.ES2065_0.AutoSize = true;
            this.ES2065_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2065_0.Location = new System.Drawing.Point(16, 670);
            this.ES2065_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES2065_0.Name = "ES2065_0";
            this.ES2065_0.Size = new System.Drawing.Size(228, 31);
            this.ES2065_0.TabIndex = 148;
            this.ES2065_0.Text = "İade Beton Sınıfı";
            // 
            // iadebetonmiktaritxt
            // 
            this.iadebetonmiktaritxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iadebetonmiktaritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadebetonmiktaritxt.ForeColor = System.Drawing.SystemColors.Window;
            this.iadebetonmiktaritxt.Location = new System.Drawing.Point(701, 603);
            this.iadebetonmiktaritxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iadebetonmiktaritxt.Name = "iadebetonmiktaritxt";
            this.iadebetonmiktaritxt.Size = new System.Drawing.Size(601, 37);
            this.iadebetonmiktaritxt.TabIndex = 147;
            // 
            // ES2064_0
            // 
            this.ES2064_0.AutoSize = true;
            this.ES2064_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2064_0.Location = new System.Drawing.Point(16, 615);
            this.ES2064_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES2064_0.Name = "ES2064_0";
            this.ES2064_0.Size = new System.Drawing.Size(250, 31);
            this.ES2064_0.TabIndex = 146;
            this.ES2064_0.Text = "İade Beton Miktarı";
            // 
            // iadeuretimnotxt
            // 
            this.iadeuretimnotxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iadeuretimnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iadeuretimnotxt.ForeColor = System.Drawing.SystemColors.Window;
            this.iadeuretimnotxt.Location = new System.Drawing.Point(701, 549);
            this.iadeuretimnotxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iadeuretimnotxt.Name = "iadeuretimnotxt";
            this.iadeuretimnotxt.Size = new System.Drawing.Size(601, 37);
            this.iadeuretimnotxt.TabIndex = 145;
            // 
            // ES2067_0
            // 
            this.ES2067_0.AutoSize = true;
            this.ES2067_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2067_0.Location = new System.Drawing.Point(16, 561);
            this.ES2067_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES2067_0.Name = "ES2067_0";
            this.ES2067_0.Size = new System.Drawing.Size(210, 31);
            this.ES2067_0.TabIndex = 144;
            this.ES2067_0.Text = "İade Üretim No";
            // 
            // uretilecekmiktartxt
            // 
            this.uretilecekmiktartxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.uretilecekmiktartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uretilecekmiktartxt.ForeColor = System.Drawing.SystemColors.Window;
            this.uretilecekmiktartxt.Location = new System.Drawing.Point(701, 495);
            this.uretilecekmiktartxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uretilecekmiktartxt.Name = "uretilecekmiktartxt";
            this.uretilecekmiktartxt.Size = new System.Drawing.Size(601, 37);
            this.uretilecekmiktartxt.TabIndex = 143;
            // 
            // ES848_1
            // 
            this.ES848_1.AutoSize = true;
            this.ES848_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES848_1.Location = new System.Drawing.Point(16, 507);
            this.ES848_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES848_1.Name = "ES848_1";
            this.ES848_1.Size = new System.Drawing.Size(295, 31);
            this.ES848_1.TabIndex = 142;
            this.ES848_1.Text = "Üretilecek Miktar m^3";
            // 
            // girismiktaritxt
            // 
            this.girismiktaritxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.girismiktaritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girismiktaritxt.ForeColor = System.Drawing.SystemColors.Window;
            this.girismiktaritxt.Location = new System.Drawing.Point(701, 441);
            this.girismiktaritxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.girismiktaritxt.Name = "girismiktaritxt";
            this.girismiktaritxt.Size = new System.Drawing.Size(601, 37);
            this.girismiktaritxt.TabIndex = 141;
            // 
            // ES949_1
            // 
            this.ES949_1.AutoSize = true;
            this.ES949_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES949_1.Location = new System.Drawing.Point(16, 453);
            this.ES949_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES949_1.Name = "ES949_1";
            this.ES949_1.Size = new System.Drawing.Size(170, 31);
            this.ES949_1.TabIndex = 140;
            this.ES949_1.Text = "Giriş Miktarı";
            // 
            // recetetxt
            // 
            this.recetetxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recetetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recetetxt.ForeColor = System.Drawing.SystemColors.Window;
            this.recetetxt.Location = new System.Drawing.Point(701, 386);
            this.recetetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recetetxt.Name = "recetetxt";
            this.recetetxt.Size = new System.Drawing.Size(601, 37);
            this.recetetxt.TabIndex = 139;
            // 
            // ES950_1
            // 
            this.ES950_1.AutoSize = true;
            this.ES950_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES950_1.Location = new System.Drawing.Point(16, 399);
            this.ES950_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES950_1.Name = "ES950_1";
            this.ES950_1.Size = new System.Drawing.Size(107, 31);
            this.ES950_1.TabIndex = 138;
            this.ES950_1.Text = "Reçete";
            // 
            // firmaaditxt
            // 
            this.firmaaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.firmaaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firmaaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.firmaaditxt.Location = new System.Drawing.Point(701, 332);
            this.firmaaditxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaaditxt.Name = "firmaaditxt";
            this.firmaaditxt.Size = new System.Drawing.Size(601, 37);
            this.firmaaditxt.TabIndex = 137;
            // 
            // ES834_1
            // 
            this.ES834_1.AutoSize = true;
            this.ES834_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES834_1.Location = new System.Drawing.Point(16, 345);
            this.ES834_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES834_1.Name = "ES834_1";
            this.ES834_1.Size = new System.Drawing.Size(138, 31);
            this.ES834_1.TabIndex = 136;
            this.ES834_1.Text = "Firma Adı";
            // 
            // santiyeaditxt
            // 
            this.santiyeaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.santiyeaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.santiyeaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.santiyeaditxt.Location = new System.Drawing.Point(701, 278);
            this.santiyeaditxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.santiyeaditxt.Name = "santiyeaditxt";
            this.santiyeaditxt.Size = new System.Drawing.Size(601, 37);
            this.santiyeaditxt.TabIndex = 135;
            // 
            // ES810_1
            // 
            this.ES810_1.AutoSize = true;
            this.ES810_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES810_1.Location = new System.Drawing.Point(16, 290);
            this.ES810_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES810_1.Name = "ES810_1";
            this.ES810_1.Size = new System.Drawing.Size(162, 31);
            this.ES810_1.TabIndex = 134;
            this.ES810_1.Text = "Şantiye Adı";
            // 
            // kalantxt
            // 
            this.kalantxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kalantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalantxt.ForeColor = System.Drawing.SystemColors.Window;
            this.kalantxt.Location = new System.Drawing.Point(701, 224);
            this.kalantxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kalantxt.Name = "kalantxt";
            this.kalantxt.Size = new System.Drawing.Size(601, 37);
            this.kalantxt.TabIndex = 133;
            // 
            // ES955_1
            // 
            this.ES955_1.AutoSize = true;
            this.ES955_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES955_1.Location = new System.Drawing.Point(16, 236);
            this.ES955_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES955_1.Name = "ES955_1";
            this.ES955_1.Size = new System.Drawing.Size(88, 31);
            this.ES955_1.TabIndex = 132;
            this.ES955_1.Text = "Kalan";
            // 
            // manuelgirischeckbox2
            // 
            this.manuelgirischeckbox2.AutoSize = true;
            this.manuelgirischeckbox2.Location = new System.Drawing.Point(1364, 75);
            this.manuelgirischeckbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manuelgirischeckbox2.Name = "manuelgirischeckbox2";
            this.manuelgirischeckbox2.Size = new System.Drawing.Size(18, 17);
            this.manuelgirischeckbox2.TabIndex = 131;
            this.manuelgirischeckbox2.UseVisualStyleBackColor = true;
            // 
            // manuelgirischeckbox1
            // 
            this.manuelgirischeckbox1.AutoSize = true;
            this.manuelgirischeckbox1.Location = new System.Drawing.Point(1364, 130);
            this.manuelgirischeckbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manuelgirischeckbox1.Name = "manuelgirischeckbox1";
            this.manuelgirischeckbox1.Size = new System.Drawing.Size(18, 17);
            this.manuelgirischeckbox1.TabIndex = 130;
            this.manuelgirischeckbox1.UseVisualStyleBackColor = true;
            // 
            // yapilantxt
            // 
            this.yapilantxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.yapilantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapilantxt.ForeColor = System.Drawing.SystemColors.Window;
            this.yapilantxt.Location = new System.Drawing.Point(701, 170);
            this.yapilantxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yapilantxt.Name = "yapilantxt";
            this.yapilantxt.Size = new System.Drawing.Size(601, 37);
            this.yapilantxt.TabIndex = 126;
            // 
            // surucuadisoyaditxt
            // 
            this.surucuadisoyaditxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.surucuadisoyaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surucuadisoyaditxt.ForeColor = System.Drawing.SystemColors.Window;
            this.surucuadisoyaditxt.Location = new System.Drawing.Point(701, 116);
            this.surucuadisoyaditxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surucuadisoyaditxt.Name = "surucuadisoyaditxt";
            this.surucuadisoyaditxt.Size = new System.Drawing.Size(601, 37);
            this.surucuadisoyaditxt.TabIndex = 127;
            // 
            // ES956_1
            // 
            this.ES956_1.AutoSize = true;
            this.ES956_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES956_1.Location = new System.Drawing.Point(16, 182);
            this.ES956_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES956_1.Name = "ES956_1";
            this.ES956_1.Size = new System.Drawing.Size(111, 31);
            this.ES956_1.TabIndex = 122;
            this.ES956_1.Text = "Yapılan";
            // 
            // aracplakanotxt
            // 
            this.aracplakanotxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aracplakanotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracplakanotxt.ForeColor = System.Drawing.SystemColors.Window;
            this.aracplakanotxt.Location = new System.Drawing.Point(701, 62);
            this.aracplakanotxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aracplakanotxt.Name = "aracplakanotxt";
            this.aracplakanotxt.Size = new System.Drawing.Size(601, 37);
            this.aracplakanotxt.TabIndex = 128;
            // 
            // ES404_1
            // 
            this.ES404_1.AutoSize = true;
            this.ES404_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES404_1.Location = new System.Drawing.Point(16, 123);
            this.ES404_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES404_1.Name = "ES404_1";
            this.ES404_1.Size = new System.Drawing.Size(253, 31);
            this.ES404_1.TabIndex = 123;
            this.ES404_1.Text = "Sürücü Adı Soyadı";
            // 
            // siparisnotxt
            // 
            this.siparisnotxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.siparisnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisnotxt.ForeColor = System.Drawing.SystemColors.Window;
            this.siparisnotxt.Location = new System.Drawing.Point(701, 7);
            this.siparisnotxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siparisnotxt.Name = "siparisnotxt";
            this.siparisnotxt.Size = new System.Drawing.Size(601, 37);
            this.siparisnotxt.TabIndex = 129;
            // 
            // ES952_1
            // 
            this.ES952_1.AutoSize = true;
            this.ES952_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES952_1.Location = new System.Drawing.Point(16, 11);
            this.ES952_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES952_1.Name = "ES952_1";
            this.ES952_1.Size = new System.Drawing.Size(149, 31);
            this.ES952_1.TabIndex = 124;
            this.ES952_1.Text = "Sipariş No";
            // 
            // ES842_1
            // 
            this.ES842_1.AutoSize = true;
            this.ES842_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES842_1.Location = new System.Drawing.Point(16, 68);
            this.ES842_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES842_1.Name = "ES842_1";
            this.ES842_1.Size = new System.Drawing.Size(200, 31);
            this.ES842_1.TabIndex = 125;
            this.ES842_1.Text = "Araç Plaka No";
            // 
            // ES1845_1
            // 
            this.ES1845_1.AutoSize = true;
            this.ES1845_1.Location = new System.Drawing.Point(1328, 11);
            this.ES1845_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ES1845_1.Name = "ES1845_1";
            this.ES1845_1.Size = new System.Drawing.Size(87, 17);
            this.ES1845_1.TabIndex = 154;
            this.ES1845_1.Text = "Manuel Giriş";
            // 
            // SurucuAdiSoyadiCbox
            // 
            this.SurucuAdiSoyadiCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurucuAdiSoyadiCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SurucuAdiSoyadiCbox.FormattingEnabled = true;
            this.SurucuAdiSoyadiCbox.Location = new System.Drawing.Point(331, 116);
            this.SurucuAdiSoyadiCbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SurucuAdiSoyadiCbox.Name = "SurucuAdiSoyadiCbox";
            this.SurucuAdiSoyadiCbox.Size = new System.Drawing.Size(361, 38);
            this.SurucuAdiSoyadiCbox.TabIndex = 155;
            this.SurucuAdiSoyadiCbox.SelectedIndexChanged += new System.EventHandler(this.SurucuAdiSoyadiCbox_SelectedIndexChanged);
            // 
            // AracPlakaNoCbox
            // 
            this.AracPlakaNoCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AracPlakaNoCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracPlakaNoCbox.FormattingEnabled = true;
            this.AracPlakaNoCbox.Location = new System.Drawing.Point(331, 60);
            this.AracPlakaNoCbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AracPlakaNoCbox.Name = "AracPlakaNoCbox";
            this.AracPlakaNoCbox.Size = new System.Drawing.Size(361, 38);
            this.AracPlakaNoCbox.TabIndex = 156;
            this.AracPlakaNoCbox.SelectedIndexChanged += new System.EventHandler(this.AracPlakaNoCbox_SelectedIndexChanged);
            // 
            // SiparisNoCbox
            // 
            this.SiparisNoCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SiparisNoCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparisNoCbox.FormattingEnabled = true;
            this.SiparisNoCbox.Location = new System.Drawing.Point(331, 7);
            this.SiparisNoCbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SiparisNoCbox.Name = "SiparisNoCbox";
            this.SiparisNoCbox.Size = new System.Drawing.Size(361, 38);
            this.SiparisNoCbox.TabIndex = 157;
            this.SiparisNoCbox.SelectedIndexChanged += new System.EventHandler(this.SiparisNoCbox_SelectedIndexChanged);
            // 
            // UretimPlaniYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1055);
            this.Controls.Add(this.SurucuAdiSoyadiCbox);
            this.Controls.Add(this.AracPlakaNoCbox);
            this.Controls.Add(this.SiparisNoCbox);
            this.Controls.Add(this.ES1845_1);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.siparislerdatagridview);
            this.Controls.Add(this.iadebetonaciklamasitxt);
            this.Controls.Add(this.ES2066_0);
            this.Controls.Add(this.iadebetonsinifitxt);
            this.Controls.Add(this.ES2065_0);
            this.Controls.Add(this.iadebetonmiktaritxt);
            this.Controls.Add(this.ES2064_0);
            this.Controls.Add(this.iadeuretimnotxt);
            this.Controls.Add(this.ES2067_0);
            this.Controls.Add(this.uretilecekmiktartxt);
            this.Controls.Add(this.ES848_1);
            this.Controls.Add(this.girismiktaritxt);
            this.Controls.Add(this.ES949_1);
            this.Controls.Add(this.recetetxt);
            this.Controls.Add(this.ES950_1);
            this.Controls.Add(this.firmaaditxt);
            this.Controls.Add(this.ES834_1);
            this.Controls.Add(this.santiyeaditxt);
            this.Controls.Add(this.ES810_1);
            this.Controls.Add(this.kalantxt);
            this.Controls.Add(this.ES955_1);
            this.Controls.Add(this.manuelgirischeckbox2);
            this.Controls.Add(this.manuelgirischeckbox1);
            this.Controls.Add(this.yapilantxt);
            this.Controls.Add(this.surucuadisoyaditxt);
            this.Controls.Add(this.ES956_1);
            this.Controls.Add(this.aracplakanotxt);
            this.Controls.Add(this.ES404_1);
            this.Controls.Add(this.siparisnotxt);
            this.Controls.Add(this.ES952_1);
            this.Controls.Add(this.ES842_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UretimPlaniYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniPlan";
            this.Load += new System.EventHandler(this.YeniPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparislerdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox iadebetonaciklamasitxt;
        private System.Windows.Forms.Label ES2066_0;
        private System.Windows.Forms.TextBox iadebetonsinifitxt;
        private System.Windows.Forms.Label ES2065_0;
        private System.Windows.Forms.TextBox iadebetonmiktaritxt;
        private System.Windows.Forms.Label ES2064_0;
        private System.Windows.Forms.TextBox iadeuretimnotxt;
        private System.Windows.Forms.Label ES2067_0;
        private System.Windows.Forms.TextBox uretilecekmiktartxt;
        private System.Windows.Forms.Label ES848_1;
        private System.Windows.Forms.TextBox girismiktaritxt;
        private System.Windows.Forms.Label ES949_1;
        private System.Windows.Forms.TextBox recetetxt;
        private System.Windows.Forms.Label ES950_1;
        private System.Windows.Forms.TextBox firmaaditxt;
        private System.Windows.Forms.Label ES834_1;
        private System.Windows.Forms.TextBox santiyeaditxt;
        private System.Windows.Forms.Label ES810_1;
        private System.Windows.Forms.TextBox kalantxt;
        private System.Windows.Forms.Label ES955_1;
        private System.Windows.Forms.CheckBox manuelgirischeckbox2;
        private System.Windows.Forms.CheckBox manuelgirischeckbox1;
        private System.Windows.Forms.TextBox yapilantxt;
        private System.Windows.Forms.TextBox surucuadisoyaditxt;
        private System.Windows.Forms.Label ES956_1;
        private System.Windows.Forms.TextBox aracplakanotxt;
        private System.Windows.Forms.Label ES404_1;
        private System.Windows.Forms.TextBox siparisnotxt;
        private System.Windows.Forms.Label ES952_1;
        private System.Windows.Forms.Label ES842_1;
        private System.Windows.Forms.Label ES1845_1;
        private System.Windows.Forms.ComboBox SurucuAdiSoyadiCbox;
        private System.Windows.Forms.ComboBox AracPlakaNoCbox;
        private System.Windows.Forms.ComboBox SiparisNoCbox;
    }
}