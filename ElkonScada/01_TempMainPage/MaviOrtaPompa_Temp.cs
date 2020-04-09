using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._01_TempMainPage
{
    public partial class MaviOrtaPompa_Temp : UserControl
    {
        
        public MaviOrtaPompa_Temp()
        {
            
            InitializeComponent();
        }

        private void XB4_Su1Istenen_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaviOrtaPompa_Temp_Load(object sender, EventArgs e)
        {
            BelirlenenSuSayisi();
        }
        public void BelirlenenSuSayisi()
        {
            //MaviOrtaPompaTempleri location ayarları

            //Su1 için default location bilgileri;
            s_Su1PompaRenk.Location = new Point(0 , 0);
            XB4_Su1Istenen.Location = new Point(0, 52);
            XB19_Su1Verilen.Location = new Point(0, 77);
            Su1Al.Location = new Point(67,0);

            //Su2 için default location bilgileri;
            s_Su2PompaRenk.Location = new Point(0, 112);
            XB4_Su2Istenen.Location = new Point(0, 164);
            XB19_Su2Verilen.Location = new Point(0, 189);
            Su2Al.Location = new Point(67, 112);

            //Su3 için default location bilgileri;
            s_Su3PompaRenk.Location = new Point(0, 224);
            XB4_Su3Istenen.Location = new Point(0, 276);
            XB19_Su3Verilen.Location = new Point(0, 301);
            Su3Al.Location = new Point(67, 224);

            //Su borular location bilgileri
            Suboru1.Location = new Point(130, 29);
            Suboru1_1.Location = new Point(172, 35);
            Suboru1_1.Size = new Size(8, 107);
            Suboru1_2.Location = new Point(163, 29);
            Suboru2.Location = new Point(130, 141);
            Suboru2_1.Location = new Point(172, 148);
            Suboru2_1.Size = new Size(8, 107);
            Suboru2_2.Location = new Point(162, 137);
            Suboru3.Location = new Point(130, 253);
            Suboru3_1.Location = new Point(172, 261);
            Suboru3_1.Size = new Size(8, 46);
            Suboru3_2.Location = new Point(162, 249);

            //MaviOrtaPompaTempleri visible kontrol ayarları

            //Su1 için default visible bilgileri;
            s_Su1PompaRenk.Visible = false;
            XB4_Su1Istenen.Visible = false;
            XB19_Su1Verilen.Visible = false;
            Su1Al.Visible = false;

            //Su2 için default visible bilgileri;
            s_Su2PompaRenk.Visible = false;
            XB4_Su2Istenen.Visible = false;
            XB19_Su2Verilen.Visible = false;
            Su2Al.Visible = false;

            //Su3 için default visible bilgileri;
            s_Su3PompaRenk.Visible = false;
            XB4_Su3Istenen.Visible = false;
            XB19_Su3Verilen.Visible = false;
            Su3Al.Visible = false;

            //Su boruları için default visible bilgileri;
            Suboru1.Visible = false;
            Suboru1_1.Visible = false;
            Suboru1_2.Visible = false;
            Suboru2.Visible = false;
            Suboru2_1.Visible = false;
            Suboru2_2.Visible = false;
            Suboru3.Visible = false;
            Suboru3_1.Visible = false;
            Suboru3_2.Visible = false;


            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi==1)
            {
                //Pic_SuKantar1 için location bilgileri
                s_Su1PompaRenk.Location = new Point(0, 112);
                XB4_Su1Istenen.Location = new Point(0, 164);
                XB19_Su1Verilen.Location = new Point(0, 189);
                Su1Al.Location = new  Point(67, 112);

                //Pic_SuKantar1 boruları için location bilgileri
                Suboru1.Location = new Point(130, 141);
                Suboru1_1.Location = new Point(172, 148);
                Suboru1_1.Size = new Size(8, 150);
                Suboru1_2.Location = new Point(163, 141);

                //Su1 visible Kontrol
                s_Su1PompaRenk.Visible = true;
                XB4_Su1Istenen.Visible = true;
                XB19_Su1Verilen.Visible = true;
                Su1Al.Visible = true;

                //Su borusu visible Kontrol
                Suboru1.Visible = true;
                Suboru1_1.Visible = true;
                Suboru1_2.Visible = true;
            }
            //Pic_SuKantar2 seçildi
            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi == 2)
            {
                //Pic_SuKantar2 için location bilgileri
                s_Su1PompaRenk.Location = new Point(0, 56);
                XB4_Su1Istenen.Location = new Point(0, 108);
                XB19_Su1Verilen.Location = new Point(0, 133);
                Su1Al.Location = new Point(67, 56);

                s_Su2PompaRenk.Location = new Point(0, 168);
                XB4_Su2Istenen.Location = new Point(0, 220);
                XB19_Su2Verilen.Location = new Point(0, 245);
                Su2Al.Location = new Point(67, 168);

                //Pic_SuKantar2 boruları için location bilgileri
                Suboru1.Location = new Point(130, 80);
                Suboru1_1.Location = new Point(172, 87);
                Suboru1_1.Size = new Size(8, 115);
                Suboru1_2.Location = new Point(163, 80);
                Suboru2.Location = new Point(130, 202);
                Suboru2_1.Location = new Point(172, 209);
                Suboru2_1.Size = new Size(8, 90);
                Suboru2_2.Location = new Point(162, 198);

                //Su1 visible Kontrol
                s_Su1PompaRenk.Visible = true;
                XB4_Su1Istenen.Visible = true;
                XB19_Su1Verilen.Visible = true;
                Su1Al.Visible = true;

                //Su2 visible Kontrol
                s_Su2PompaRenk.Visible = true;
                XB4_Su2Istenen.Visible = true;
                XB19_Su2Verilen.Visible = true;
                Su2Al.Visible = true;

                //Su borusuları visible Kontrol
                Suboru1.Visible = true;
                Suboru1_1.Visible = true;
                Suboru1_2.Visible = true;
                Suboru2.Visible = true;
                Suboru2_1.Visible = true;
                Suboru2_2.Visible = true;
            }
            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi == 3)
            {
                //Pic_SuKantar3 için location bilgileri
                s_Su1PompaRenk.Location = new Point(0, 0);
                XB4_Su1Istenen.Location = new Point(0, 52);
                XB19_Su1Verilen.Location = new Point(0, 77);
                Su1Al.Location = new Point(67, 0);

                
                s_Su2PompaRenk.Location = new Point(0, 112);
                XB4_Su2Istenen.Location = new Point(0, 164);
                XB19_Su2Verilen.Location = new Point(0, 189);
                Su2Al.Location = new Point(67, 112);

                
                s_Su3PompaRenk.Location = new Point(0, 224);
                XB4_Su3Istenen.Location = new Point(0, 276);
                XB19_Su3Verilen.Location = new Point(0, 301);
                Su3Al.Location = new Point(67, 224);

                //Su borular location bilgileri
                Suboru1.Location = new Point(130, 29);
                Suboru1_1.Location = new Point(172, 35);
                Suboru1_1.Size = new Size(8, 107);
                Suboru1_2.Location = new Point(163, 29);
                Suboru2.Location = new Point(130, 141);
                Suboru2_1.Location = new Point(172, 148);
                Suboru2_1.Size = new Size(8, 107);
                Suboru2_2.Location = new Point(162, 137);
                Suboru3.Location = new Point(130, 253);
                Suboru3_1.Location = new Point(172, 261);
                Suboru3_1.Size = new Size(8, 40);
                Suboru3_2.Location = new Point(162, 249);

                //MaviOrtaPompaTempleri visible kontrol ayarları

                //Su1 visible Kontrol
                s_Su1PompaRenk.Visible = true;
                XB4_Su1Istenen.Visible = true;
                XB19_Su1Verilen.Visible = true;
                Su1Al.Visible = true;

                //Su2 visible Kontrol
                s_Su2PompaRenk.Visible = true;
                XB4_Su2Istenen.Visible = true;
                XB19_Su2Verilen.Visible = true;
                Su2Al.Visible = true;

                //Su3 visible Kontrol
                s_Su3PompaRenk.Visible = true;
                XB4_Su3Istenen.Visible = true;
                XB19_Su3Verilen.Visible = true;
                Su3Al.Visible = true;

                //Su boruları visible Kontrol
                Suboru1.Visible = true;
                Suboru1_1.Visible = true;
                Suboru1_2.Visible = true;
                Suboru2.Visible = true;
                Suboru2_1.Visible = true;
                Suboru2_2.Visible = true;
                Suboru3.Visible = true;
                Suboru3_1.Visible = true;
                Suboru3_2.Visible = true;
            }
        }
    }
}
