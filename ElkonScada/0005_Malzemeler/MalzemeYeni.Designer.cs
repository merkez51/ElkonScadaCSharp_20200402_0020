namespace ElkonScada._0005_Malzemeler
{
    partial class MalzemeYeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeYeni));
            this.durumutxt = new System.Windows.Forms.TextBox();
            this.aciklama2txt = new System.Windows.Forms.TextBox();
            this.aciklama1txt = new System.Windows.Forms.TextBox();
            this.malzemeadiitxt = new System.Windows.Forms.TextBox();
            this.ES807_1 = new System.Windows.Forms.Label();
            this.ES1613_1 = new System.Windows.Forms.Label();
            this.ES1612_1 = new System.Windows.Forms.Label();
            this.ES391_1 = new System.Windows.Forms.Label();
            this.ES386_1 = new System.Windows.Forms.Button();
            this.MalzemeDurum = new System.Windows.Forms.ComboBox();
            this.MalzemelerComboBox = new System.Windows.Forms.ComboBox();
            this.MalzemeTipi = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hatamsgmalzeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // durumutxt
            // 
            this.durumutxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.durumutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumutxt.ForeColor = System.Drawing.SystemColors.Window;
            this.durumutxt.Location = new System.Drawing.Point(555, 179);
            this.durumutxt.Name = "durumutxt";
            this.durumutxt.Size = new System.Drawing.Size(512, 31);
            this.durumutxt.TabIndex = 137;
            // 
            // aciklama2txt
            // 
            this.aciklama2txt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aciklama2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama2txt.ForeColor = System.Drawing.SystemColors.Window;
            this.aciklama2txt.Location = new System.Drawing.Point(555, 135);
            this.aciklama2txt.Name = "aciklama2txt";
            this.aciklama2txt.Size = new System.Drawing.Size(512, 31);
            this.aciklama2txt.TabIndex = 136;
            // 
            // aciklama1txt
            // 
            this.aciklama1txt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aciklama1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklama1txt.ForeColor = System.Drawing.SystemColors.Window;
            this.aciklama1txt.Location = new System.Drawing.Point(555, 91);
            this.aciklama1txt.Name = "aciklama1txt";
            this.aciklama1txt.Size = new System.Drawing.Size(512, 31);
            this.aciklama1txt.TabIndex = 135;
            // 
            // malzemeadiitxt
            // 
            this.malzemeadiitxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.malzemeadiitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.malzemeadiitxt.ForeColor = System.Drawing.SystemColors.Window;
            this.malzemeadiitxt.Location = new System.Drawing.Point(555, 9);
            this.malzemeadiitxt.Name = "malzemeadiitxt";
            this.malzemeadiitxt.Size = new System.Drawing.Size(512, 31);
            this.malzemeadiitxt.TabIndex = 134;
            // 
            // ES807_1
            // 
            this.ES807_1.AutoSize = true;
            this.ES807_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES807_1.Location = new System.Drawing.Point(12, 9);
            this.ES807_1.Name = "ES807_1";
            this.ES807_1.Size = new System.Drawing.Size(147, 25);
            this.ES807_1.TabIndex = 133;
            this.ES807_1.Text = "Malzeme Adı";
            // 
            // ES1613_1
            // 
            this.ES1613_1.AutoSize = true;
            this.ES1613_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1613_1.Location = new System.Drawing.Point(12, 135);
            this.ES1613_1.Name = "ES1613_1";
            this.ES1613_1.Size = new System.Drawing.Size(429, 25);
            this.ES1613_1.TabIndex = 132;
            this.ES1613_1.Text = "Açıklama 2 (max Tane Büyüklüğü (mm))";
            // 
            // ES1612_1
            // 
            this.ES1612_1.AutoSize = true;
            this.ES1612_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1612_1.Location = new System.Drawing.Point(12, 91);
            this.ES1612_1.Name = "ES1612_1";
            this.ES1612_1.Size = new System.Drawing.Size(281, 25);
            this.ES1612_1.TabIndex = 131;
            this.ES1612_1.Text = "Açıklama 1 (Tipi,Sınıfı vb)";
            // 
            // ES391_1
            // 
            this.ES391_1.AutoSize = true;
            this.ES391_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES391_1.Location = new System.Drawing.Point(12, 178);
            this.ES391_1.Name = "ES391_1";
            this.ES391_1.Size = new System.Drawing.Size(93, 25);
            this.ES391_1.TabIndex = 130;
            this.ES391_1.Text = "Durumu";
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(955, 216);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 139;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
            this.ES386_1.Click += new System.EventHandler(this.tamam_btn_click);
            // 
            // MalzemeDurum
            // 
            this.MalzemeDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MalzemeDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MalzemeDurum.FormattingEnabled = true;
            this.MalzemeDurum.Location = new System.Drawing.Point(295, 179);
            this.MalzemeDurum.Name = "MalzemeDurum";
            this.MalzemeDurum.Size = new System.Drawing.Size(254, 33);
            this.MalzemeDurum.TabIndex = 140;
            this.MalzemeDurum.SelectedIndexChanged += new System.EventHandler(this.MalzemeDurum_SelectedIndexChanged);
            // 
            // MalzemelerComboBox
            // 
            this.MalzemelerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MalzemelerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MalzemelerComboBox.FormattingEnabled = true;
            this.MalzemelerComboBox.Location = new System.Drawing.Point(555, 52);
            this.MalzemelerComboBox.Name = "MalzemelerComboBox";
            this.MalzemelerComboBox.Size = new System.Drawing.Size(512, 33);
            this.MalzemelerComboBox.TabIndex = 142;
            this.MalzemelerComboBox.SelectedIndexChanged += new System.EventHandler(this.MalzemelerComboBox_SelectedIndexChanged);
            // 
            // MalzemeTipi
            // 
            this.MalzemeTipi.AutoSize = true;
            this.MalzemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MalzemeTipi.Location = new System.Drawing.Point(12, 52);
            this.MalzemeTipi.Name = "MalzemeTipi";
            this.MalzemeTipi.Size = new System.Drawing.Size(152, 25);
            this.MalzemeTipi.TabIndex = 141;
            this.MalzemeTipi.Text = "Malzeme Tipi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // hatamsgmalzeme
            // 
            this.hatamsgmalzeme.AutoSize = true;
            this.hatamsgmalzeme.Location = new System.Drawing.Point(25, 227);
            this.hatamsgmalzeme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hatamsgmalzeme.Name = "hatamsgmalzeme";
            this.hatamsgmalzeme.Size = new System.Drawing.Size(35, 13);
            this.hatamsgmalzeme.TabIndex = 143;
            this.hatamsgmalzeme.Text = "label1";
            this.hatamsgmalzeme.Visible = false;
            // 
            // MalzemeYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 411);
            this.Controls.Add(this.hatamsgmalzeme);
            this.Controls.Add(this.MalzemelerComboBox);
            this.Controls.Add(this.MalzemeTipi);
            this.Controls.Add(this.MalzemeDurum);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.durumutxt);
            this.Controls.Add(this.aciklama2txt);
            this.Controls.Add(this.aciklama1txt);
            this.Controls.Add(this.malzemeadiitxt);
            this.Controls.Add(this.ES807_1);
            this.Controls.Add(this.ES1613_1);
            this.Controls.Add(this.ES1612_1);
            this.Controls.Add(this.ES391_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MalzemeYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniMalzeme";
            this.Load += new System.EventHandler(this.YeniMalzeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox durumutxt;
        private System.Windows.Forms.TextBox aciklama2txt;
        private System.Windows.Forms.TextBox aciklama1txt;
        private System.Windows.Forms.TextBox malzemeadiitxt;
        private System.Windows.Forms.Label ES807_1;
        private System.Windows.Forms.Label ES1613_1;
        private System.Windows.Forms.Label ES1612_1;
        private System.Windows.Forms.Label ES391_1;
        private System.Windows.Forms.Button ES386_1;
        private System.Windows.Forms.ComboBox MalzemeDurum;
        private System.Windows.Forms.ComboBox MalzemelerComboBox;
        private System.Windows.Forms.Label MalzemeTipi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label hatamsgmalzeme;
    }
}