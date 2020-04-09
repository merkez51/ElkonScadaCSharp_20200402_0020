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
    public partial class Compact_Secenekleri : UserControl
    {
        public Compact_Secenekleri()
        {
            InitializeComponent();
        }
        
        private void Compact_Secenekleri_Load(object sender, EventArgs e)
        {
            CompactPictureSekection();
        }

        private void Pic_Elkomix60Konveyorlu_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 5;
            CompactPictureSekection();
        }

        private void Pic_Elkomix90Konveyorlu_Click(object sender, EventArgs e)
        {
         
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 6;
            CompactPictureSekection();
        }

        private void Pic_Elkomix120Konveyorlu_Click(object sender, EventArgs e)
        {
          
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 7;
            CompactPictureSekection();
        }

        private void Pic_Elkomix135Konveyorlu_Click(object sender, EventArgs e)
        {
     
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 8;
            CompactPictureSekection();
        }
        private void CompactPictureSekection()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi)
            {
                case 5:
                    Pic_Elkomix60Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_35;
                    Pic_Elkomix90Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_120_Blur;
                    Pic_Elkomix120Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_60_Blur;
                    Pic_Elkomix135Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_135_Blur;
                    break;
                case 6:
                    Pic_Elkomix60Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_35_Blur;
                    Pic_Elkomix90Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_120;
                    Pic_Elkomix120Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_60_Blur;
                    Pic_Elkomix135Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_135_Blur;
                    break;
                case 7:
                    Pic_Elkomix60Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_35_Blur;
                    Pic_Elkomix90Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_120_Blur;
                    Pic_Elkomix120Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_60;
                    Pic_Elkomix135Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_135_Blur;
                    break;
                case 8:
                    Pic_Elkomix60Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_35_Blur;
                    Pic_Elkomix90Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_120_Blur;
                    Pic_Elkomix120Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_60_Blur;
                    Pic_Elkomix135Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_135;
                    break;
            

                default:
                    Pic_Elkomix60Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_35_Blur;
                    Pic_Elkomix90Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_120_Blur;
                    Pic_Elkomix120Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_60_Blur;
                    Pic_Elkomix135Konveyorlu.Image = ElkonScada.Properties.Resources.Quick_135_Blur;
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
        private void ES1509_1_Click(object sender, EventArgs e)
        {

        }

        private void ES1510_1_Click(object sender, EventArgs e)
        {

        }

        private void ES602_1_Click(object sender, EventArgs e)
        {

        }

        private void ES605_1_Click(object sender, EventArgs e)
        {

        }
    }
}
