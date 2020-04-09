using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._006_Konfigurator._00_SantralTipTemplate
{
    public partial class Sabit_Secenekler : UserControl
    {
        public Sabit_Secenekler()
        {
            InitializeComponent();
        }
        private void Sabit_Secenekler_Load(object sender, EventArgs e)
        {
            SabitSeceneklerPicSelection();


        }
        public void Pic_Elkomix35_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 16;
            SabitSeceneklerPicSelection();

        }

        private void Pic_Elkomix60_Click(object sender, EventArgs e)
        {
            
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 17;
            SabitSeceneklerPicSelection();

        }

        private void Pic_Elkomix120_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 18;
            SabitSeceneklerPicSelection();

        }

        private void Pic_Elkomix135_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 19;
            SabitSeceneklerPicSelection();

        }

        private void Pic_Elkomix160_Click(object sender, EventArgs e)
        {
            
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 20;
            SabitSeceneklerPicSelection();

        }

        private void Pic_Elkomix180_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 21;
            SabitSeceneklerPicSelection();
        }
        private void SabitSeceneklerPicSelection()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi)
            {
                case 16:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
                case 17:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
                case 18:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
                case 19:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
                case 20:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
                case 21:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1;
                    break;
              
                default:
                    Pic_Elkomix35.Image = Properties.Resources.Elkomix_35_Blur;
                    Pic_Elkomix60.Image = Properties.Resources.Elkomix_60_Blur;
                    Pic_Elkomix120.Image = Properties.Resources.Elkomix_120_Blur;
                    Pic_Elkomix135.Image = Properties.Resources.Elkomix_135_Blur;
                    Pic_Elkomix160.Image = Properties.Resources.Elkomix_160_Blur;
                    Pic_Elkomix180.Image = Properties.Resources.Elkomix_180_1_Blur;
                    break;
            }
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi)
            {
                case 0:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_135;
                    break;
                case 1:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_35;
                    break;
                case 2:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_60;
                    break;
                case 3:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_120;
                    break;
                case 4:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_135;
                    break;
                case 5:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_35;
                    break;
                case 6:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_120;
                    break;
                case 7:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_60;
                    break;
                case 8:
                    SecilenSantral.BackgroundImage = Properties.Resources.Quick_135;
                    break;
                case 9:
                    SecilenSantral.BackgroundImage = Properties.Resources.Eagle_30;
                    break;
                case 10:
                    SecilenSantral.BackgroundImage = Properties.Resources.Pegasus_60;
                    break;
                case 11:
                    SecilenSantral.BackgroundImage = Properties.Resources.Pegasus_60;
                    break;
                case 12:
                    SecilenSantral.BackgroundImage = Properties.Resources.Bear_60;
                    break;
                case 13:
                    SecilenSantral.BackgroundImage = Properties.Resources.Lion_100;
                    break;
                case 14:
                    SecilenSantral.BackgroundImage = Properties.Resources.Jaguar_135;
                    break;
                case 15:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elephant_150;
                    break;
                case 16:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_35;
                    break;
                case 17:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_60;
                    break;
                case 18:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_120;
                    break;
                case 19:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_135;
                    break;
                case 20:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_160;
                    break;
                case 21:
                    SecilenSantral.BackgroundImage = Properties.Resources.Elkomix_180_1;
                    break;
                case 22:
                    SecilenSantral.BackgroundImage = Properties.Resources.MM_302;
                    break;
                case 23:
                    SecilenSantral.BackgroundImage = Properties.Resources.MM_304;
                    break;
                default:
                    break;
            }
        }
        private void Pic_SkipKonveyor_Click(object sender, EventArgs e)
        {
            if (Properties.S000_Konfigrator_Tag.Default.TransferbandıSecildi==true)
            {
                Pic_SkipKonveyor.Image = Properties.Resources.Kova_Konfig;
                Properties.S000_Konfigrator_Tag.Default.TransferbandıSecildi = false;
                Properties.S000_Konfigrator_Tag.Default.KovaSecildi = true;

            }
            else if (Properties.S000_Konfigrator_Tag.Default.KovaSecildi == true)
            {
                Pic_SkipKonveyor.Image = Properties.Resources.Transfer_Konveyor;
                Properties.S000_Konfigrator_Tag.Default.KovaSecildi = false;
                Properties.S000_Konfigrator_Tag.Default.TransferbandıSecildi = true;
            }
            else
            {
                Properties.S000_Konfigrator_Tag.Default.TransferbandıSecildi = true;
                Properties.S000_Konfigrator_Tag.Default.KovaSecildi = false;
                Pic_SkipKonveyor.Image = Properties.Resources.Transfer_Konveyor;

            }

        }

        private void Pic_TartıBandi_Click(object sender, EventArgs e)
        {
            if (Properties.S000_Konfigrator_Tag.Default.T_TipliTartiKonveyor == true)
            {
                Pic_TartıBandi.Image = Properties.Resources.Inline_Tartim_Konveyor;
                Properties.S000_Konfigrator_Tag.Default.T_TipliTartiKonveyor = false;
                Properties.S000_Konfigrator_Tag.Default.DuzTipTartıKonveyor = true;

            }
            else if (Properties.S000_Konfigrator_Tag.Default.DuzTipTartıKonveyor == true)
            {
                Pic_TartıBandi.Image = Properties.Resources.Inline_Tartim_Konveyor_T_Type;
                Properties.S000_Konfigrator_Tag.Default.DuzTipTartıKonveyor = false;
                Properties.S000_Konfigrator_Tag.Default.T_TipliTartiKonveyor = true;
            }
            else
            {
                Properties.S000_Konfigrator_Tag.Default.DuzTipTartıKonveyor = false;
                Properties.S000_Konfigrator_Tag.Default.T_TipliTartiKonveyor = true;
                Pic_TartıBandi.Image = Properties.Resources.Inline_Tartim_Konveyor_T_Type;

            }
        }

      
    }
}
