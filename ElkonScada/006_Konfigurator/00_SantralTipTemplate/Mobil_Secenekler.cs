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
    public partial class Mobil_Secenekler : UserControl
    {
        public Mobil_Secenekler()
        {
            InitializeComponent();
        }
        private void Mobil_Secenekler_Load(object sender, EventArgs e)
        {
            MobilPicSelection();
        }

        private void Eagle_30_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 9;
            MobilPicSelection();

        }

        private void Pagasus_60_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 10;
            MobilPicSelection();

        }

        private void Panthera_60_Click(object sender, EventArgs e)
        {
            
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 11;
            MobilPicSelection();

        }
        private void Bear_60_Click(object sender, EventArgs e)
        {
            
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 12;
            MobilPicSelection();

        }


        private void Lion_100_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 13;
            MobilPicSelection();

        }

        private void Jaguar_135_Click(object sender, EventArgs e)
        {
            
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 14;
            MobilPicSelection();

        }

        private void Elephant_150_Click(object sender, EventArgs e)
        {
         
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 15;
            MobilPicSelection();

        }

        private void MobilPicSelection()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi)
            {
                case 9:
                    Eagle_30.Image = Properties.Resources.Eagle_30;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 10:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 11:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 12:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 13:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 14:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135;
                    Elephant_150.Image = Properties.Resources.Elephant_150_Blur;
                    break;
                case 15:
                    Eagle_30.Image = Properties.Resources.Eagle_30_Blur;
                    Pagasus_60.Image = Properties.Resources.Pegasus_60_Blur;
                    Panthera_60.Image = Properties.Resources.Panthera_60_Blur;
                    Bear_60.Image = Properties.Resources.Bear_60_Blur;
                    Lion_100.Image = Properties.Resources.Lion_100_Blur;
                    Jaguar_135.Image = Properties.Resources.Jaguar_135_Blur;
                    Elephant_150.Image = Properties.Resources.Elephant_150;
                    break;
                default:
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
    }
}
