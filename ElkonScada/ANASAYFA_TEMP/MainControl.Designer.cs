namespace ElkonScada.ANASAYFA_TEMP
{
    partial class MainControl
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
            this.mainPage1 = new ElkonScada.ANASAYFA_TEMP.MainPage();
            this.SuspendLayout();
            // 
            // mainPage1
            // 
            this.mainPage1.BackColor = System.Drawing.Color.Transparent;
            this.mainPage1.Location = new System.Drawing.Point(0, 0);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(1920, 1017);
            this.mainPage1.TabIndex = 0;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1017);
            this.Controls.Add(this.mainPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainControl";
            this.Text = "MainControl";
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MainPage mainPage1;
    }
}