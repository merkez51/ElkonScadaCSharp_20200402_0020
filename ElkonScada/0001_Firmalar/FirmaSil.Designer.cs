namespace ElkonScada._0001_Firmalar
{
    partial class FirmaSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaSil));
            this.ES838_1 = new System.Windows.Forms.Label();
            this.ES799_1 = new System.Windows.Forms.Button();
            this.ES798_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ES838_1
            // 
            resources.ApplyResources(this.ES838_1, "ES838_1");
            this.ES838_1.Name = "ES838_1";
            // 
            // ES799_1
            // 
            this.ES799_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ES799_1, "ES799_1");
            this.ES799_1.Name = "ES799_1";
            this.ES799_1.UseVisualStyleBackColor = true;
            this.ES799_1.Click += new System.EventHandler(this.hayırbtn_Click);
            // 
            // ES798_1
            // 
            this.ES798_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ES798_1, "ES798_1");
            this.ES798_1.Name = "ES798_1";
            this.ES798_1.UseVisualStyleBackColor = true;
            this.ES798_1.Click += new System.EventHandler(this.evetbtn_Click);
            // 
            // FirmaSil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ES799_1);
            this.Controls.Add(this.ES798_1);
            this.Controls.Add(this.ES838_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmaSil";
            this.Load += new System.EventHandler(this.FirmaSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ES838_1;
        private System.Windows.Forms.Button ES799_1;
        private System.Windows.Forms.Button ES798_1;
    }
}