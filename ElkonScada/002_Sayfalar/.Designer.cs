namespace ElkonScada
{
    partial class KalibrasyonSayfasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalibrasyonSayfasi));
            this.XB159_AgSec = new System.Windows.Forms.Button();
            this.XB159_CimSec = new System.Windows.Forms.Button();
            this.XB159_SuSec = new System.Windows.Forms.Button();
            this.XB159_KatkiSec = new System.Windows.Forms.Button();
            this.Agrega_Calib_Lamp = new System.Windows.Forms.Button();
            this.Cimento_Calib_Lamp = new System.Windows.Forms.Button();
            this.Su_Calib_Lamp = new System.Windows.Forms.Button();
            this.Katki_Calib_Lamp = new System.Windows.Forms.Button();
            this.Calib_Page_Step1 = new System.Windows.Forms.Label();
            this.Calib_Page_Step2 = new System.Windows.Forms.Label();
            this.Calib_Page_Step3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Bos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XB159_Kalibrasyon_Agirligi = new System.Windows.Forms.TextBox();
            this.XB159_KantarSifirla = new System.Windows.Forms.Button();
            this.XB159_KantarAgirliginiYaz = new System.Windows.Forms.Button();
            this.XB159_KalibreSon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RefleshKalibrasyonSayfasiTimer = new System.Windows.Forms.Timer(this.components);
            this.deneme1 = new System.Windows.Forms.TextBox();
            this.laumas_Katki1 = new ElkonScada._100_LaumasTemple.Laumas_Katki();
            this.laumas_Su1 = new ElkonScada._100_LaumasTemple.Laumas_Su();
            this.laumas_Agrega1 = new ElkonScada._100_LaumasTemple.Laumas_Agrega();
            this.laumas_Cimento1 = new ElkonScada._100_LaumasTemple.Laumas_Cimento();
            this.SuspendLayout();
            // 
            // XB159_AgSec
            // 
            this.XB159_AgSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB159_AgSec.Image = ((System.Drawing.Image)(resources.GetObject("XB159_AgSec.Image")));
            this.XB159_AgSec.Location = new System.Drawing.Point(9, 11);
            this.XB159_AgSec.Name = "XB159_AgSec";
            this.XB159_AgSec.Size = new System.Drawing.Size(215, 82);
            this.XB159_AgSec.TabIndex = 3;
            this.XB159_AgSec.Text = "Agrega";
            this.XB159_AgSec.UseVisualStyleBackColor = true;
            this.XB159_AgSec.Click += new System.EventHandler(this.XB159_AgSec_Click);
            this.XB159_AgSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_AgSec_MouseDown);
            this.XB159_AgSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_AgSec_MouseUp);
            // 
            // XB159_CimSec
            // 
            this.XB159_CimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.XB159_CimSec.Image = ((System.Drawing.Image)(resources.GetObject("XB159_CimSec.Image")));
            this.XB159_CimSec.Location = new System.Drawing.Point(9, 99);
            this.XB159_CimSec.Name = "XB159_CimSec";
            this.XB159_CimSec.Size = new System.Drawing.Size(215, 82);
            this.XB159_CimSec.TabIndex = 4;
            this.XB159_CimSec.Text = "Çimento";
            this.XB159_CimSec.UseVisualStyleBackColor = true;
            this.XB159_CimSec.Click += new System.EventHandler(this.XB159_CimSec_Click);
            this.XB159_CimSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_CimSec_MouseDown);
            this.XB159_CimSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_CimSec_MouseUp);
            // 
            // XB159_SuSec
            // 
            this.XB159_SuSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.XB159_SuSec.Image = ((System.Drawing.Image)(resources.GetObject("XB159_SuSec.Image")));
            this.XB159_SuSec.Location = new System.Drawing.Point(9, 187);
            this.XB159_SuSec.Name = "XB159_SuSec";
            this.XB159_SuSec.Size = new System.Drawing.Size(215, 82);
            this.XB159_SuSec.TabIndex = 5;
            this.XB159_SuSec.Text = "Su";
            this.XB159_SuSec.UseVisualStyleBackColor = true;
            this.XB159_SuSec.Click += new System.EventHandler(this.XB159_SuSec_Click);
            this.XB159_SuSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_SuSec_MouseDown);
            this.XB159_SuSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_SuSec_MouseUp);
            // 
            // XB159_KatkiSec
            // 
            this.XB159_KatkiSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.XB159_KatkiSec.Image = ((System.Drawing.Image)(resources.GetObject("XB159_KatkiSec.Image")));
            this.XB159_KatkiSec.Location = new System.Drawing.Point(9, 275);
            this.XB159_KatkiSec.Name = "XB159_KatkiSec";
            this.XB159_KatkiSec.Size = new System.Drawing.Size(215, 82);
            this.XB159_KatkiSec.TabIndex = 6;
            this.XB159_KatkiSec.Text = "Katkı";
            this.XB159_KatkiSec.UseVisualStyleBackColor = true;
            this.XB159_KatkiSec.Click += new System.EventHandler(this.XB159_KatkiSec_Click);
            this.XB159_KatkiSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_KatkiSec_MouseDown);
            this.XB159_KatkiSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_KatkiSec_MouseUp);
            // 
            // Agrega_Calib_Lamp
            // 
            this.Agrega_Calib_Lamp.AutoEllipsis = true;
            this.Agrega_Calib_Lamp.BackColor = System.Drawing.SystemColors.Control;
            this.Agrega_Calib_Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Agrega_Calib_Lamp.Image")));
            this.Agrega_Calib_Lamp.Location = new System.Drawing.Point(230, 11);
            this.Agrega_Calib_Lamp.Name = "Agrega_Calib_Lamp";
            this.Agrega_Calib_Lamp.Size = new System.Drawing.Size(64, 64);
            this.Agrega_Calib_Lamp.TabIndex = 7;
            this.Agrega_Calib_Lamp.TabStop = false;
            this.Agrega_Calib_Lamp.UseVisualStyleBackColor = false;
            // 
            // Cimento_Calib_Lamp
            // 
            this.Cimento_Calib_Lamp.AutoEllipsis = true;
            this.Cimento_Calib_Lamp.BackColor = System.Drawing.SystemColors.Control;
            this.Cimento_Calib_Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Cimento_Calib_Lamp.Image")));
            this.Cimento_Calib_Lamp.Location = new System.Drawing.Point(230, 99);
            this.Cimento_Calib_Lamp.Name = "Cimento_Calib_Lamp";
            this.Cimento_Calib_Lamp.Size = new System.Drawing.Size(64, 64);
            this.Cimento_Calib_Lamp.TabIndex = 8;
            this.Cimento_Calib_Lamp.TabStop = false;
            this.Cimento_Calib_Lamp.UseVisualStyleBackColor = false;
            // 
            // Su_Calib_Lamp
            // 
            this.Su_Calib_Lamp.AutoEllipsis = true;
            this.Su_Calib_Lamp.BackColor = System.Drawing.SystemColors.Control;
            this.Su_Calib_Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Su_Calib_Lamp.Image")));
            this.Su_Calib_Lamp.Location = new System.Drawing.Point(230, 187);
            this.Su_Calib_Lamp.Name = "Su_Calib_Lamp";
            this.Su_Calib_Lamp.Size = new System.Drawing.Size(64, 64);
            this.Su_Calib_Lamp.TabIndex = 9;
            this.Su_Calib_Lamp.TabStop = false;
            this.Su_Calib_Lamp.UseVisualStyleBackColor = false;
            // 
            // Katki_Calib_Lamp
            // 
            this.Katki_Calib_Lamp.AutoEllipsis = true;
            this.Katki_Calib_Lamp.BackColor = System.Drawing.SystemColors.Control;
            this.Katki_Calib_Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Katki_Calib_Lamp.Image")));
            this.Katki_Calib_Lamp.Location = new System.Drawing.Point(230, 275);
            this.Katki_Calib_Lamp.Name = "Katki_Calib_Lamp";
            this.Katki_Calib_Lamp.Size = new System.Drawing.Size(64, 64);
            this.Katki_Calib_Lamp.TabIndex = 10;
            this.Katki_Calib_Lamp.TabStop = false;
            this.Katki_Calib_Lamp.UseVisualStyleBackColor = false;
            // 
            // Calib_Page_Step1
            // 
            this.Calib_Page_Step1.AutoSize = true;
            this.Calib_Page_Step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Calib_Page_Step1.Location = new System.Drawing.Point(358, 15);
            this.Calib_Page_Step1.Name = "Calib_Page_Step1";
            this.Calib_Page_Step1.Size = new System.Drawing.Size(91, 25);
            this.Calib_Page_Step1.TabIndex = 11;
            this.Calib_Page_Step1.Text = "1. Adım";
            // 
            // Calib_Page_Step2
            // 
            this.Calib_Page_Step2.AutoSize = true;
            this.Calib_Page_Step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Calib_Page_Step2.Location = new System.Drawing.Point(678, 15);
            this.Calib_Page_Step2.Name = "Calib_Page_Step2";
            this.Calib_Page_Step2.Size = new System.Drawing.Size(91, 25);
            this.Calib_Page_Step2.TabIndex = 12;
            this.Calib_Page_Step2.Text = "2. Adım";
            // 
            // Calib_Page_Step3
            // 
            this.Calib_Page_Step3.AutoSize = true;
            this.Calib_Page_Step3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Calib_Page_Step3.Location = new System.Drawing.Point(998, 15);
            this.Calib_Page_Step3.Name = "Calib_Page_Step3";
            this.Calib_Page_Step3.Size = new System.Drawing.Size(91, 25);
            this.Calib_Page_Step3.TabIndex = 13;
            this.Calib_Page_Step3.Text = "3. Adım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(358, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kalibre Edilecek\r\nKantarı Seçiniz";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 482);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // Bos
            // 
            this.Bos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bos.Enabled = false;
            this.Bos.Location = new System.Drawing.Point(558, -2);
            this.Bos.Name = "Bos";
            this.Bos.Size = new System.Drawing.Size(10, 367);
            this.Bos.TabIndex = 16;
            this.Bos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(892, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 364);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(583, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kantar Üzerinde Bulunan \r\nAğırlığı Giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(907, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 50);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bitir Butonuna \r\nBasınız";
            // 
            // XB159_Kalibrasyon_Agirligi
            // 
            this.XB159_Kalibrasyon_Agirligi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.XB159_Kalibrasyon_Agirligi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XB159_Kalibrasyon_Agirligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.XB159_Kalibrasyon_Agirligi.ForeColor = System.Drawing.Color.White;
            this.XB159_Kalibrasyon_Agirligi.Location = new System.Drawing.Point(613, 161);
            this.XB159_Kalibrasyon_Agirligi.Name = "XB159_Kalibrasyon_Agirligi";
            this.XB159_Kalibrasyon_Agirligi.Size = new System.Drawing.Size(242, 35);
            this.XB159_Kalibrasyon_Agirligi.TabIndex = 20;
            this.XB159_Kalibrasyon_Agirligi.Text = "0.00 ";
            // 
            // XB159_KantarSifirla
            // 
            this.XB159_KantarSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB159_KantarSifirla.Image = ((System.Drawing.Image)(resources.GetObject("XB159_KantarSifirla.Image")));
            this.XB159_KantarSifirla.Location = new System.Drawing.Point(326, 272);
            this.XB159_KantarSifirla.Name = "XB159_KantarSifirla";
            this.XB159_KantarSifirla.Size = new System.Drawing.Size(215, 82);
            this.XB159_KantarSifirla.TabIndex = 21;
            this.XB159_KantarSifirla.Text = "Sıfırla";
            this.XB159_KantarSifirla.UseVisualStyleBackColor = true;
            this.XB159_KantarSifirla.Click += new System.EventHandler(this.Calib_Sifirla_Button_Click);
            this.XB159_KantarSifirla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_KantarSifirla_MouseDown);
            this.XB159_KantarSifirla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_KantarSifirla_MouseUp);
            // 
            // XB159_KantarAgirliginiYaz
            // 
            this.XB159_KantarAgirliginiYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB159_KantarAgirliginiYaz.Image = ((System.Drawing.Image)(resources.GetObject("XB159_KantarAgirliginiYaz.Image")));
            this.XB159_KantarAgirliginiYaz.Location = new System.Drawing.Point(626, 272);
            this.XB159_KantarAgirliginiYaz.Name = "XB159_KantarAgirliginiYaz";
            this.XB159_KantarAgirliginiYaz.Size = new System.Drawing.Size(215, 82);
            this.XB159_KantarAgirliginiYaz.TabIndex = 22;
            this.XB159_KantarAgirliginiYaz.Text = "Kalibre Et";
            this.XB159_KantarAgirliginiYaz.UseVisualStyleBackColor = true;
            this.XB159_KantarAgirliginiYaz.Click += new System.EventHandler(this.Calibre_Et_Button_Click);
            this.XB159_KantarAgirliginiYaz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_KantarAgirliginiYaz_MouseDown);
            this.XB159_KantarAgirliginiYaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_KantarAgirliginiYaz_MouseUp);
            // 
            // XB159_KalibreSon
            // 
            this.XB159_KalibreSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB159_KalibreSon.Image = ((System.Drawing.Image)(resources.GetObject("XB159_KalibreSon.Image")));
            this.XB159_KalibreSon.Location = new System.Drawing.Point(912, 272);
            this.XB159_KalibreSon.Name = "XB159_KalibreSon";
            this.XB159_KalibreSon.Size = new System.Drawing.Size(215, 82);
            this.XB159_KalibreSon.TabIndex = 23;
            this.XB159_KalibreSon.Text = "Bitir";
            this.XB159_KalibreSon.UseVisualStyleBackColor = true;
            this.XB159_KalibreSon.Click += new System.EventHandler(this.Calib_Bitir_Click);
            this.XB159_KalibreSon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XB159_KalibreSon_MouseDown);
            this.XB159_KalibreSon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XB159_KalibreSon_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(9, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1139, 13);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // RefleshKalibrasyonSayfasiTimer
            // 
            this.RefleshKalibrasyonSayfasiTimer.Interval = 1200;
            this.RefleshKalibrasyonSayfasiTimer.Tick += new System.EventHandler(this.KalibrasyonSayfasiTimer_Tick);
            // 
            // deneme1
            // 
            this.deneme1.Location = new System.Drawing.Point(613, 217);
            this.deneme1.Name = "deneme1";
            this.deneme1.Size = new System.Drawing.Size(100, 20);
            this.deneme1.TabIndex = 31;
            // 
            // laumas_Katki1
            // 
            this.laumas_Katki1.BackColor = System.Drawing.Color.Gray;
            this.laumas_Katki1.Location = new System.Drawing.Point(982, 379);
            this.laumas_Katki1.Name = "laumas_Katki1";
            this.laumas_Katki1.Size = new System.Drawing.Size(150, 98);
            this.laumas_Katki1.TabIndex = 29;
            // 
            // laumas_Su1
            // 
            this.laumas_Su1.BackColor = System.Drawing.Color.Gray;
            this.laumas_Su1.Location = new System.Drawing.Point(738, 379);
            this.laumas_Su1.Name = "laumas_Su1";
            this.laumas_Su1.Size = new System.Drawing.Size(150, 99);
            this.laumas_Su1.TabIndex = 28;
            // 
            // laumas_Agrega1
            // 
            this.laumas_Agrega1.BackColor = System.Drawing.Color.DimGray;
            this.laumas_Agrega1.Location = new System.Drawing.Point(250, 379);
            this.laumas_Agrega1.Name = "laumas_Agrega1";
            this.laumas_Agrega1.Size = new System.Drawing.Size(152, 100);
            this.laumas_Agrega1.TabIndex = 27;
            this.laumas_Agrega1.Load += new System.EventHandler(this.laumas_Agrega1_Load);
            // 
            // laumas_Cimento1
            // 
            this.laumas_Cimento1.BackColor = System.Drawing.Color.DimGray;
            this.laumas_Cimento1.Location = new System.Drawing.Point(494, 379);
            this.laumas_Cimento1.Name = "laumas_Cimento1";
            this.laumas_Cimento1.Size = new System.Drawing.Size(150, 102);
            this.laumas_Cimento1.TabIndex = 26;
            // 
            // KalibrasyonSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 482);
            this.Controls.Add(this.deneme1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laumas_Katki1);
            this.Controls.Add(this.laumas_Su1);
            this.Controls.Add(this.laumas_Agrega1);
            this.Controls.Add(this.laumas_Cimento1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.XB159_KalibreSon);
            this.Controls.Add(this.XB159_KantarAgirliginiYaz);
            this.Controls.Add(this.XB159_KantarSifirla);
            this.Controls.Add(this.XB159_Kalibrasyon_Agirligi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bos);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calib_Page_Step3);
            this.Controls.Add(this.Calib_Page_Step2);
            this.Controls.Add(this.Calib_Page_Step1);
            this.Controls.Add(this.Katki_Calib_Lamp);
            this.Controls.Add(this.Su_Calib_Lamp);
            this.Controls.Add(this.Cimento_Calib_Lamp);
            this.Controls.Add(this.Agrega_Calib_Lamp);
            this.Controls.Add(this.XB159_KatkiSec);
            this.Controls.Add(this.XB159_SuSec);
            this.Controls.Add(this.XB159_CimSec);
            this.Controls.Add(this.XB159_AgSec);
            this.Name = "KalibrasyonSayfasi";
            this.Text = "KalibrasyonSayfasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KalibrasyonSayfasi_FormClosing);
            this.Load += new System.EventHandler(this.KalibrasyonSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Agrega_Calib_Lamp;
        private System.Windows.Forms.Button Cimento_Calib_Lamp;
        private System.Windows.Forms.Button Su_Calib_Lamp;
        private System.Windows.Forms.Button Katki_Calib_Lamp;
        private System.Windows.Forms.Label Calib_Page_Step1;
        private System.Windows.Forms.Label Calib_Page_Step2;
        private System.Windows.Forms.Label Calib_Page_Step3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button Bos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XB159_Kalibrasyon_Agirligi;
        
        private System.Windows.Forms.Button button2;
        private _100_LaumasTemple.Laumas_Cimento laumas_Cimento1;
        private _100_LaumasTemple.Laumas_Agrega laumas_Agrega1;
        private _100_LaumasTemple.Laumas_Su laumas_Su1;
        private _100_LaumasTemple.Laumas_Katki laumas_Katki1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button XB159_AgSec;
        public System.Windows.Forms.Button XB159_CimSec;
        public System.Windows.Forms.Button XB159_KatkiSec;
        public System.Windows.Forms.Button XB159_KantarSifirla;
        public System.Windows.Forms.Button XB159_KantarAgirliginiYaz;
        public System.Windows.Forms.Button XB159_KalibreSon;
        public System.Windows.Forms.Button XB159_SuSec;
        private System.Windows.Forms.TextBox deneme1;
        public System.Windows.Forms.Timer RefleshKalibrasyonSayfasiTimer;
    }
}

