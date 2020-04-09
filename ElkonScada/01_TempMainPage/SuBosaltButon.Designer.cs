namespace ElkonScada._01_TempMainPage
{
    partial class SuBosaltButon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.is_ButonSuBosalt = new System.Windows.Forms.Button();
			this.denemetextBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// is_ButonSuBosalt
			// 
			this.is_ButonSuBosalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.is_ButonSuBosalt.ForeColor = System.Drawing.SystemColors.Control;
			this.is_ButonSuBosalt.Image = global::ElkonScada.Properties.Resources.Button_White;
			this.is_ButonSuBosalt.Location = new System.Drawing.Point(0, 0);
			this.is_ButonSuBosalt.Name = "is_ButonSuBosalt";
			this.is_ButonSuBosalt.Size = new System.Drawing.Size(65, 70);
			this.is_ButonSuBosalt.TabIndex = 0;
			this.is_ButonSuBosalt.UseMnemonic = false;
			this.is_ButonSuBosalt.UseVisualStyleBackColor = true;
			this.is_ButonSuBosalt.Click += new System.EventHandler(this.is_ButonSuBosalt_Click);
			this.is_ButonSuBosalt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.is_ButonSuBosalt_MouseClick);
			// 
			// denemetextBox1
			// 
			this.denemetextBox1.Location = new System.Drawing.Point(4, 28);
			this.denemetextBox1.Name = "denemetextBox1";
			this.denemetextBox1.Size = new System.Drawing.Size(52, 20);
			this.denemetextBox1.TabIndex = 1;
			this.denemetextBox1.TextChanged += new System.EventHandler(this.denemetextBox1_TextChanged);
			// 
			// SuBosaltButon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.denemetextBox1);
			this.Controls.Add(this.is_ButonSuBosalt);
			this.Name = "SuBosaltButon";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button is_ButonSuBosalt;
        private System.Windows.Forms.TextBox denemetextBox1;
    }
}
