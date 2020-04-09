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
    public partial class Mixmaster : UserControl
    {
        public Mixmaster()
        {
            InitializeComponent();
        }

        private void Mixmaster_Load(object sender, EventArgs e)
        {
            MixmasterPicSelection();
        }

        private void Mixmaster2x5_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 22;
            MixmasterPicSelection();

        }

        private void Mixmaster4x5_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi = 23;
            MixmasterPicSelection();
        }
        private void MixmasterPicSelection()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi)
            {
                case 22:
                    Mixmaster2x5.Image = Properties.Resources.MM_302;
                    Mixmaster4x5.Image = Properties.Resources.MM_304_Blur;
                    break;
                case 23:
                    Mixmaster2x5.Image = Properties.Resources.MM_302_Blur;
                    Mixmaster4x5.Image = Properties.Resources.MM_304;
                    break;
                default:
                    Mixmaster2x5.Image = Properties.Resources.MM_302_Blur;
                    Mixmaster4x5.Image = Properties.Resources.MM_304_Blur;
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
