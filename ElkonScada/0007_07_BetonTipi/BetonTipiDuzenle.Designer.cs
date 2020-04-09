namespace ElkonScada._0007_07_BetonTipi
{
    partial class BetonTipiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetonTipiDuzenle));
            this.ES386_1 = new System.Windows.Forms.Button();
            this.durumutxt = new System.Windows.Forms.TextBox();
            this.aciklamatxt = new System.Windows.Forms.TextBox();
            this.ES1947_1 = new System.Windows.Forms.Label();
            this.ES403_1 = new System.Windows.Forms.Label();
            this.ES391_1 = new System.Windows.Forms.Label();
            this.BetonTipiCbox = new System.Windows.Forms.ComboBox();
            this.DurumuCbox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hatamsgbetontipi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ES386_1
            // 
            this.ES386_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES386_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES386_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES386_1.Image = ((System.Drawing.Image)(resources.GetObject("ES386_1.Image")));
            this.ES386_1.Location = new System.Drawing.Point(955, 134);
            this.ES386_1.Name = "ES386_1";
            this.ES386_1.Size = new System.Drawing.Size(112, 57);
            this.ES386_1.TabIndex = 211;
            this.ES386_1.Text = "TAMAM";
            this.ES386_1.UseVisualStyleBackColor = true;
            this.ES386_1.Click += new System.EventHandler(this.GuncelleKaydet_Btn_Click);
            // 
            // durumutxt
            // 
            this.durumutxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.durumutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumutxt.ForeColor = System.Drawing.SystemColors.Window;
            this.durumutxt.Location = new System.Drawing.Point(512, 97);
            this.durumutxt.Name = "durumutxt";
            this.durumutxt.Size = new System.Drawing.Size(555, 31);
            this.durumutxt.TabIndex = 209;
            // 
            // aciklamatxt
            // 
            this.aciklamatxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aciklamatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamatxt.ForeColor = System.Drawing.SystemColors.Window;
            this.aciklamatxt.Location = new System.Drawing.Point(512, 53);
            this.aciklamatxt.Name = "aciklamatxt";
            this.aciklamatxt.Size = new System.Drawing.Size(555, 31);
            this.aciklamatxt.TabIndex = 208;
            // 
            // ES1947_1
            // 
            this.ES1947_1.AutoSize = true;
            this.ES1947_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES1947_1.Location = new System.Drawing.Point(12, 9);
            this.ES1947_1.Name = "ES1947_1";
            this.ES1947_1.Size = new System.Drawing.Size(119, 25);
            this.ES1947_1.TabIndex = 206;
            this.ES1947_1.Text = "Beton Tipi";
            // 
            // ES403_1
            // 
            this.ES403_1.AutoSize = true;
            this.ES403_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES403_1.Location = new System.Drawing.Point(12, 53);
            this.ES403_1.Name = "ES403_1";
            this.ES403_1.Size = new System.Drawing.Size(107, 25);
            this.ES403_1.TabIndex = 205;
            this.ES403_1.Text = "Açıklama";
            // 
            // ES391_1
            // 
            this.ES391_1.AutoSize = true;
            this.ES391_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ES391_1.Location = new System.Drawing.Point(12, 96);
            this.ES391_1.Name = "ES391_1";
            this.ES391_1.Size = new System.Drawing.Size(93, 25);
            this.ES391_1.TabIndex = 204;
            this.ES391_1.Text = "Durumu";
            // 
            // BetonTipiCbox
            // 
            this.BetonTipiCbox.BackColor = System.Drawing.SystemColors.Window;
            this.BetonTipiCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BetonTipiCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BetonTipiCbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BetonTipiCbox.FormattingEnabled = true;
            this.BetonTipiCbox.Location = new System.Drawing.Point(512, 7);
            this.BetonTipiCbox.Name = "BetonTipiCbox";
            this.BetonTipiCbox.Size = new System.Drawing.Size(555, 32);
            this.BetonTipiCbox.TabIndex = 214;
            this.BetonTipiCbox.SelectedIndexChanged += new System.EventHandler(this.BetonTipiCbox_SelectedIndexChanged);
            // 
            // DurumuCbox
            // 
            this.DurumuCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurumuCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumuCbox.FormattingEnabled = true;
            this.DurumuCbox.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.DurumuCbox.Location = new System.Drawing.Point(252, 96);
            this.DurumuCbox.Name = "DurumuCbox";
            this.DurumuCbox.Size = new System.Drawing.Size(254, 33);
            this.DurumuCbox.TabIndex = 213;
            this.DurumuCbox.SelectedIndexChanged += new System.EventHandler(this.DurumuCbox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // hatamsgbetontipi
            // 
            this.hatamsgbetontipi.AutoSize = true;
            this.hatamsgbetontipi.Location = new System.Drawing.Point(14, 178);
            this.hatamsgbetontipi.Name = "hatamsgbetontipi";
            this.hatamsgbetontipi.Size = new System.Drawing.Size(35, 13);
            this.hatamsgbetontipi.TabIndex = 215;
            this.hatamsgbetontipi.Text = "label1";
            this.hatamsgbetontipi.Visible = false;
            // 
            // BetonTipiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 411);
            this.Controls.Add(this.hatamsgbetontipi);
            this.Controls.Add(this.BetonTipiCbox);
            this.Controls.Add(this.DurumuCbox);
            this.Controls.Add(this.ES386_1);
            this.Controls.Add(this.durumutxt);
            this.Controls.Add(this.aciklamatxt);
            this.Controls.Add(this.ES1947_1);
            this.Controls.Add(this.ES403_1);
            this.Controls.Add(this.ES391_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BetonTipiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetonTipiDuzenle";
            this.Load += new System.EventHandler(this.BetonTipiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ES386_1;
        private System.Windows.Forms.TextBox durumutxt;
        private System.Windows.Forms.TextBox aciklamatxt;
        private System.Windows.Forms.Label ES1947_1;
        private System.Windows.Forms.Label ES403_1;
        private System.Windows.Forms.Label ES391_1;
        private System.Windows.Forms.ComboBox BetonTipiCbox;
        private System.Windows.Forms.ComboBox DurumuCbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label hatamsgbetontipi;
    }
}