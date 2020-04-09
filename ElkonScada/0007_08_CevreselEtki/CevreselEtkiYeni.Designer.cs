namespace ElkonScada._0007_08_CevreselEtki
{
    partial class CevreselEtkiYeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CevreselEtkiYeni));
            this.durumutxt = new System.Windows.Forms.TextBox();
            this.aciklamatxt = new System.Windows.Forms.TextBox();
            this.cevreseletkitxt = new System.Windows.Forms.TextBox();
            this.ES2136_0 = new System.Windows.Forms.Label();
            this.ES403_1 = new System.Windows.Forms.Label();
            this.ES391_1 = new System.Windows.Forms.Label();
            this.ES386_1 = new System.Windows.Forms.Button();
            this.DurumuCbox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hatamsgcevreseletki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // durumutxt
            // 
            this.durumutxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.durumutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumutxt.ForeColor = System.Drawing.SystemColors.Window;
            this.durumutxt.Location = new System.Drawing.Point(514, 97);
            this.durumutxt.Name = "durumutxt";
            this.durumutxt.Size = new System.Drawing.Size(555, 31);
            this.durumutxt.TabIndex = 202;
            // 
            // aciklamatxt
            // 
            this.aciklamatxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aciklamatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamatxt.ForeColor = System.Drawing.SystemColors.Window;
            this.aciklamatxt.Location = new System.Drawing.Point(514, 53);
            this.aciklamatxt.Name = "aciklamatxt";
            this.aciklamatxt.Size = new System.Drawing.Size(555, 31);
            this.aciklamatxt.TabIndex = 201;
            // 
            // cevreseletkitxt
            // 
            this.cevreseletkitxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cevreseletkitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevreseletkitxt.ForeColor = System.Drawing.SystemColors.Window;
            this.cevreseletkitxt.Location = new System.Drawing.Point(514, 9);
            this.cevreseletkitxt.Name = "cevreseletkitxt";
            this.cevreseletkitxt.Size = new System.Drawing.Size(555, 31);
            this.cevreseletkitxt.TabIndex = 200;
            // 
            // ES2136_0
            // 
            this.ES2136_0.AutoSize = true;
            this.ES2136_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES2136_0.Location = new System.Drawing.Point(12, 9);
            this.ES2136_0.Name = "ES2136_0";
            this.ES2136_0.Size = new System.Drawing.Size(152, 25);
            this.ES2136_0.TabIndex = 199;
            this.ES2136_0.Text = "Çevresel Etki";
            // 
            // ES403_1
            // 
            this.ES403_1.AutoSize = true;
            this.ES403_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES403_1.Location = new System.Drawing.Point(12, 53);
            this.ES403_1.Name = "ES403_1";
            this.ES403_1.Size = new System.Drawing.Size(107, 25);
            this.ES403_1.TabIndex = 198;
            this.ES403_1.Text = "Açıklama";
            // 
            // ES391_1
            // 
            this.ES391_1.AutoSize = true;
            this.ES391_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES391_1.Location = new System.Drawing.Point(12, 96);
            this.ES391_1.Name = "ES391_1";
            this.ES391_1.Size = new System.Drawing.Size(93, 25);
            this.ES391_1.TabIndex = 197;
            this.ES391_1.Text = "Durumu";
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(957, 134);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 204;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
            this.ES386_1.Click += new System.EventHandler(this.tamam_btn_click);
            // 
            // DurumuCbox
            // 
            this.DurumuCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurumuCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumuCbox.FormattingEnabled = true;
            this.DurumuCbox.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.DurumuCbox.Location = new System.Drawing.Point(254, 97);
            this.DurumuCbox.Name = "DurumuCbox";
            this.DurumuCbox.Size = new System.Drawing.Size(254, 33);
            this.DurumuCbox.TabIndex = 205;
            this.DurumuCbox.SelectedIndexChanged += new System.EventHandler(this.DurumuCbox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // hatamsgcevreseletki
            // 
            this.hatamsgcevreseletki.AutoSize = true;
            this.hatamsgcevreseletki.Location = new System.Drawing.Point(14, 158);
            this.hatamsgcevreseletki.Name = "hatamsgcevreseletki";
            this.hatamsgcevreseletki.Size = new System.Drawing.Size(35, 13);
            this.hatamsgcevreseletki.TabIndex = 206;
            this.hatamsgcevreseletki.Text = "label1";
            this.hatamsgcevreseletki.Visible = false;
            this.hatamsgcevreseletki.Click += new System.EventHandler(this.hatamsgcevreseletki_Click);
            // 
            // CevreselEtkiYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 411);
            this.Controls.Add(this.hatamsgcevreseletki);
            this.Controls.Add(this.DurumuCbox);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.durumutxt);
            this.Controls.Add(this.aciklamatxt);
            this.Controls.Add(this.cevreseletkitxt);
            this.Controls.Add(this.ES2136_0);
            this.Controls.Add(this.ES403_1);
            this.Controls.Add(this.ES391_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CevreselEtkiYeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniCevreselEtki";
            this.Load += new System.EventHandler(this.YeniCevreselEtki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox durumutxt;
        private System.Windows.Forms.TextBox aciklamatxt;
        private System.Windows.Forms.TextBox cevreseletkitxt;
        private System.Windows.Forms.Label ES2136_0;
        private System.Windows.Forms.Label ES403_1;
        private System.Windows.Forms.Label ES391_1;
        private System.Windows.Forms.Button ES386_1;
        private System.Windows.Forms.ComboBox DurumuCbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label hatamsgcevreseletki;
    }
}