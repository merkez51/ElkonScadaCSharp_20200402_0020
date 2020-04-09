using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._006_Konfigurator._00_SantralTipTemplate
{
    public partial class _001_SantralTipiSecimi : Form
    {
        public _001_SantralTipiSecimi()
        {
            InitializeComponent();
        }
      Quick_Secenekler QuickSkipTip = new Quick_Secenekler();
      Compact_Secenekleri QuickKonveyorTip = new Compact_Secenekleri();
      Mobil_Secenekler MobilTip = new Mobil_Secenekler();
      Sabit_Secenekler SabitTip = new Sabit_Secenekler();
      Mixmaster MixMaster = new Mixmaster();

        private void _001_SantralTipiSecimi_Load(object sender, EventArgs e)
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli)
            {
                case 1:
                    SantralModeli.Controls.Clear();
                    SantralModeli.Controls.Add(QuickSkipTip);
                    break;
                case 2:
                    SantralModeli.Controls.Clear();
                    SantralModeli.Controls.Add(QuickKonveyorTip);
                    break;
                case 3:
                    SantralModeli.Controls.Clear();
                    SantralModeli.Controls.Add(MobilTip);
                    break;
                case 4:
                    SantralModeli.Controls.Clear();
                    SantralModeli.Controls.Add(SabitTip);
                    break;
                case 5:
                    SantralModeli.Controls.Clear();
                    SantralModeli.Controls.Add(MixMaster);
                    break;
                default:
                    break;
            }
            SantralTipiSec();
        }

        private void Pic_KompaktTipSkip_Click(object sender, EventArgs e)
        {
           
            SantralModeli.Controls.Clear();
            SantralModeli.Controls.Add(QuickSkipTip);
            Pic_KompaktTipSkip.Image = Properties.Resources.Elkomix_35;
            Pic_KompaktTipKoveyor.Image = Properties.Resources.Quick_120_1_Blur;
            Pic_MobilTip.Image = Properties.Resources.Jaguar_135_2_Blur;
            Pic_SabitTip.Image = Properties.Resources.Elkomix_180_1_Blur;
            Pic_MixMaster.Image = Properties.Resources.Mix_Blur;
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli = 1;

        }

        private void Pic_KompaktTipKoveyor_Click(object sender, EventArgs e)
        {
            Pic_KompaktTipSkip.Image = Properties.Resources.Elkomix_35_Blur;
            Pic_KompaktTipKoveyor.Image = Properties.Resources.Quick_120_1;
            Pic_MobilTip.Image = Properties.Resources.Jaguar_135_2_Blur;
            Pic_SabitTip.Image = Properties.Resources.Elkomix_180_1_Blur;
            Pic_MixMaster.Image = Properties.Resources.Mix_Blur;
            SantralModeli.Controls.Clear();
            SantralModeli.Controls.Add(QuickKonveyorTip);
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli = 2;

        }

        private void Pic_MobilTip_Click(object sender, EventArgs e)
        {
            Pic_KompaktTipSkip.Image = Properties.Resources.Elkomix_35_Blur;
            Pic_KompaktTipKoveyor.Image = Properties.Resources.Quick_120_1_Blur;
            Pic_MobilTip.Image = Properties.Resources.Jaguar_135_2;
            Pic_SabitTip.Image = Properties.Resources.Elkomix_180_1_Blur;
            Pic_MixMaster.Image = Properties.Resources.Mix_Blur;
            SantralModeli.Controls.Clear();
            SantralModeli.Controls.Add(MobilTip);
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli = 3;

        }

        private void Pic_SabitTip_Click(object sender, EventArgs e)
        {
            Pic_KompaktTipSkip.Image = Properties.Resources.Elkomix_35_Blur;
            Pic_KompaktTipKoveyor.Image = Properties.Resources.Quick_120_1_Blur;
            Pic_MobilTip.Image = Properties.Resources.Jaguar_135_2_Blur;
            Pic_SabitTip.Image = Properties.Resources.Elkomix_180_1;
            Pic_MixMaster.Image = Properties.Resources.Mix_Blur;
            SantralModeli.Controls.Clear();
            SantralModeli.Controls.Add(SabitTip);
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli = 4;


        }

        private void Pic_MixMaster_Click(object sender, EventArgs e)
        {
            Pic_KompaktTipSkip.Image = Properties.Resources.Elkomix_35_Blur;
            Pic_KompaktTipKoveyor.Image = Properties.Resources.Quick_120_1_Blur;
            Pic_MobilTip.Image = Properties.Resources.Jaguar_135_2_Blur;
            Pic_SabitTip.Image = Properties.Resources.Elkomix_180_1_Blur;
            Pic_MixMaster.Image = Properties.Resources.Mix;
            SantralModeli.Controls.Clear();
            SantralModeli.Controls.Add(MixMaster);
            Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli = 5;

        }

        public void SantralTipiSec()
        {

        
        }

        private void SantralModeli_BindingContextChanged(object sender, EventArgs e)
        {
           ;
        }

        private void SantralIndex_TextChanged(object sender, EventArgs e)
        {
        }

        private void _001_SantralTipiSecimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            SantralPicChange.Enabled = false;
        }

        private void SantralPicChange_Tick(object sender, EventArgs e)
        {
            SantralTipiSec();

        }

        private void MikserBunkerSecimi_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator.MikserBunkerSecimi MikserBunkerSecimi = new MikserBunkerSecimi();
            MikserBunkerSecimi.Show();
            this.Close();

        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void _001_SantralTipiSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }
    }
}
