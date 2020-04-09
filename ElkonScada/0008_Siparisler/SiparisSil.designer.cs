namespace ElkonScada._0008_Siparisler
{
    partial class SiparisSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisSil));
            this.ES799_1 = new System.Windows.Forms.Button();
            this.ES798_1 = new System.Windows.Forms.Button();
            this.ES838_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ES799_1
            // 
            this.ES799_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES799_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES799_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ES799_1.Image = ((System.Drawing.Image)(resources.GetObject("ES799_1.Image")));
            this.ES799_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ES799_1.Location = new System.Drawing.Point(216, 70);
            this.ES799_1.Name = "ES799_1";
            this.ES799_1.Size = new System.Drawing.Size(112, 57);
            this.ES799_1.TabIndex = 16;
            this.ES799_1.Text = "HAYIR";
            this.ES799_1.UseVisualStyleBackColor = true;
            this.ES799_1.Click += new System.EventHandler(this.hayir_btn_click);
            // 
            // ES798_1
            // 
            this.ES798_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ES798_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES798_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ES798_1.Image = ((System.Drawing.Image)(resources.GetObject("ES798_1.Image")));
            this.ES798_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ES798_1.Location = new System.Drawing.Point(98, 70);
            this.ES798_1.Name = "ES798_1";
            this.ES798_1.Size = new System.Drawing.Size(112, 57);
            this.ES798_1.TabIndex = 15;
            this.ES798_1.Text = "EVET";
            this.ES798_1.UseVisualStyleBackColor = true;
            this.ES798_1.Click += new System.EventHandler(this.evet_btn_Click);
            // 
            // ES838_1
            // 
            this.ES838_1.AutoSize = true;
            this.ES838_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ES838_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ES838_1.Location = new System.Drawing.Point(12, 9);
            this.ES838_1.Name = "ES838_1";
            this.ES838_1.Size = new System.Drawing.Size(412, 25);
            this.ES838_1.TabIndex = 14;
            this.ES838_1.Text = "Silme işlemi yapmak istediğinize emin misiniz?";
            // 
            // SiparisSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 139);
            this.Controls.Add(this.ES799_1);
            this.Controls.Add(this.ES798_1);
            this.Controls.Add(this.ES838_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisSil";
            this.Load += new System.EventHandler(this.SiparisSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ES799_1;
        private System.Windows.Forms.Button ES798_1;
        private System.Windows.Forms.Label ES838_1;
    }
}