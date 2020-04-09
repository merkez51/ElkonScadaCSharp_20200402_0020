using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ElkonScada.XX_Connection
{
    public class TabControlZ : TabControl
    {
        private Color nonactive_color1 = Color.LightGreen;
        private Color nonactive_color2 = Color.DarkBlue;
        private Color active_color1 = Color.Yellow;
        private Color active_color2 = Color.DarkOrange;
        public Color forecolor = Color.Navy;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private int angle = 90;
        private Color closebuttoncolor = Color.Red;

        //Create Properties to read values  
        public Color ActiveTabStartColor
        {
            get { return active_color1; }
            set { active_color1 = value; Invalidate(); }
        }


        public Color ActiveTabEndColor
        {
            get { return active_color2; }
            set { active_color2 = value; Invalidate(); }
        }


        public Color NonActiveTabStartColor
        {
            get { return nonactive_color1; }
            set { nonactive_color1 = value; Invalidate(); }
        }


        public Color NonActiveTabEndColor
        {
            get { return nonactive_color2; }
            set { nonactive_color2 = value; Invalidate(); }
        }


        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }


        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }


        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }


        public Color TextColor
        {
            get { return forecolor; }
            set { forecolor = value; Invalidate(); }
        }

        public Color CloseButtonColor
        {
            get { return closebuttoncolor; }
            set { closebuttoncolor = value; Invalidate(); }
        }



        public TabControlZ()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new System.Drawing.Point(22, 4);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        //method for drawing tab items   
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Rectangle rc = GetTabRect(e.Index);

            //if tab is selected  
            if (this.SelectedTab == this.TabPages[e.Index])
            {
                Color c1 = Color.FromArgb(color1Transparent, active_color1);
                Color c2 = Color.FromArgb(color2Transparent, active_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
            else
            {
                Color c1 = Color.FromArgb(color1Transparent, nonactive_color1);
                Color c2 = Color.FromArgb(color2Transparent, nonactive_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }

            this.TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            this.TabPages[e.Index].ForeColor = SystemColors.ControlText;

            //draw close button on tabs  

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-5, -4);
            e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(forecolor), paddedBounds);

            Point pad = this.Padding;

            //drawing close button to tab items  
            e.Graphics.DrawString("X", new Font("Microsoft YaHei UI", 10, FontStyle.Bold), new SolidBrush(closebuttoncolor), e.Bounds.Right + 1 - 18, e.Bounds.Top + pad.Y - 2);
            e.DrawFocusRectangle();
        }
        public void AcilacakForm(TabPage Acilacak)
        {
            // Not: Ana Form (Form1) hariç, sadece Form2 olduğu için sadece Form2'yi ele alıyoruz.
            // Başka formlarda olursa hepsini kontrol eder.
            bool durum = false;
            // Burada AnaForm üzerinde açık olan mdi formlar içerisinde arama yapıyoruz.
            foreach (TabPage eleman in Application.OpenForms) //this.mdichildren
            {
                if (eleman.Text == Acilacak.Text) // Eğer Form2 Form1 üzerinde açık ise : 
                {
                    durum = true; // Eğer Form2 AnaForm üzerinde açık ise durum true olacak.
                    eleman.Show(); // Form2 zaten açık olduğundan önümüze Form2 gelecektir.
                }
            }
            if (!durum) // Eğer Form2 AnaForm üzerinde açık değilse : 
            {
                // Form2'nin ana penceresi olarak AnaForm'u ayarlar.
                Acilacak.Show(); // Form2'yi açar
            }
        }
        public int azalan = 0;
        //action for when mouse click on close button  
        public class OptionsDialog : Form
        {
            private static OptionsDialog openForm = null;
            // No need for locking - you'll be doing all this on the UI thread...
            public static OptionsDialog GetInstance()
            {
                if (openForm == null)
                {
                    openForm = new OptionsDialog();
                    openForm.FormClosed += delegate { openForm = null; };
                }
                return openForm;
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            azalan = 0;
            base.OnMouseDown(e);

            //  TabPage MevcutTabPage = tabControlZ1.SelectedTab;
            //TabPage MevcutTabPage= this.TabPages.
            //tabControlZ1.TabPages.Remove(MevcutTabPage);
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                Rectangle r = this.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right + 1 - 15, r.Top + 4, 12, 12);
                if (closeButton.Contains(e.Location))
                //if(closeButton.Contains(this.PointToClient()
                {
                    //if (MessageBox.Show("Do you want to Close this Tab ?", "Close or Not", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        public delegate bool PreRemoveTab(int indx);
        public PreRemoveTab PreRemoveTabPage;
        private void CloseTab(int i)
        {

            if (PreRemoveTabPage != null)
            {
                bool closeIt = PreRemoveTabPage(i);
                if (!closeIt)
                    return;
            }
            TabPages.Remove(TabPages[i]);
        }

    }
}
