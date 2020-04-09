using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._006_Konfigurator
{
    public partial class MikserBunkerSecimi : Form
    {
        public MikserBunkerSecimi()
        {
            InitializeComponent();
        }

        private void Pic_Planet_Click(object sender, EventArgs e)
        {
           
            Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip = 1;
            Properties.R004_Parametreler.Default.XB111_YaglamaOto = true;
            MixerUpdatePic();
        }

        private void Pic_Pan_Click(object sender, EventArgs e)
        {
            
            Properties.R004_Parametreler.Default.XB111_YaglamaOto = true;
            Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip = 2;
            MixerUpdatePic();

        }
        private void Pic_TwinShaft_Click(object sender, EventArgs e)
            {
               
            Properties.R004_Parametreler.Default.XB111_YaglamaOto = false;   // Sor bu kısmı!!!!!!!!!!!!!!!!!!
            Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip = 3;
            MixerUpdatePic();
        }

        public void MixerUpdatePic()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip)
            {
                case 1:
                    Pic_Planet.Image = Properties.Resources.Mixer_Planet;
                    Pic_Pan.Image = Properties.Resources.Mixer_Pan_Blur;
                    Pic_TwinShaft.Image = Properties.Resources.Mixer_TwinShaft_Blur;

                    Pic_SecilenMixerTip.Image = Properties.Resources.Mixer_Planet;
                    break;
                case 2:
                    Pic_Planet.Image = Properties.Resources.Mixer_Planet_Blur;
                    Pic_Pan.Image = Properties.Resources.Mixer_Pan_Kapali;
                    Pic_TwinShaft.Image = Properties.Resources.Mixer_TwinShaft_Blur;
                    Pic_SecilenMixerTip.Image = Properties.Resources.Mixer_Pan_Kapali;
                    break;
                case 3:
                    Pic_Planet.Image = Properties.Resources.Mixer_Planet_Blur;
                    Pic_Pan.Image = Properties.Resources.Mixer_Pan_Blur;
                    Pic_TwinShaft.Image = Properties.Resources.Mixer_TwinShaft;

                    Pic_SecilenMixerTip.Image = Properties.Resources.Mixer_TwinShaft;
                    break;

                default:
                    Pic_SecilenMixerTip.Image = Properties.Resources.Mixer_TwinShaft;

                    break;
            }
        }
        private void MikserBunkerSecimi_Load(object sender, EventArgs e)
        {
            MixerUpdatePic();

            Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip = 1;
       
            

            if (Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim)
            {
                ES1672_1.Text = Localization.Localization.ES1671_1;

            }
            else if (!Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim)
            {
                ES1672_1.Text = Localization.Localization.ES1672_1;
            }

        }

        private void Pic_KareTipBunker_Click(object sender, EventArgs e)
        {
            Pic_KareTipBunker.Image = Properties.Resources.Bunker_Kare_04;

            Pic_LineerBunker.Image = Properties.Resources.Bunker_04_Blur;

            BunkerSecimLineerKareTip.Image = Properties.Resources.Bunker_Kare_04;
            Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim = false;

        }

        private void Pic_LineerBunker_Click(object sender, EventArgs e)
        {
            Pic_KareTipBunker.Image = Properties.Resources.Bunker_Kare_04_Blur;
            Pic_LineerBunker.Image = Properties.Resources.Bunker_04;

            //BunkerSecimLineerKareTip.Image = Properties.Resources.Bunker_04 ;

            //Konfigrasyonu PLC ye yaz
            Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim = true;

            BunkerSecimLineerKareTip.Image = Properties.Resources.Bunker_Lineer;
        }

     

        private void ES1672_1_Click(object sender, EventArgs e)
        {
            if (Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim)
            {
                Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim = false;
                ES1672_1.Text = Localization.Localization.ES1672_1;
                ES1672_1.BackColor = Color.Transparent;


            }
            else if (!Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim)
            {
                Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim = true;
                ES1672_1.BackColor = Color.Green;
                ES1672_1.Text = Localization.Localization.ES1671_1;
            }
           
        }

        private void ES559_1_Click(object sender, EventArgs e)
        {
            if (Properties.S000_Konfigrator_Tag. Default.MikserNemOlcerVar)
            {
                ES559_1.Text = Localization.Localization.ES559_1;
                Properties.S000_Konfigrator_Tag.Default.MikserNemOlcerVar = false;
                ES559_1.BackColor = Color.Transparent;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.MikserNemOlcerVar)
            {
                ES559_1.Text = Localization.Localization.ES560_1;
                ES559_1.BackColor = Color.Green;

                Properties.S000_Konfigrator_Tag.Default.MikserNemOlcerVar = true ;

            }
        }

        private void ES3037_0_Click(object sender, EventArgs e)
        {
            if (Properties.S000_Konfigrator_Tag.Default.BetonTasimaVarYok)
            {
                ES3037_0.Text = Localization.Localization.ES3037_0;
                Properties.S000_Konfigrator_Tag.Default.BetonTasimaVarYok = false;
                ES3037_0.BackColor = Color.Transparent ;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.BetonTasimaVarYok)
            {
                ES3037_0.Text = Localization.Localization.ES3038_0;
                ES3037_0.BackColor = Color.Green;

                Properties.S000_Konfigrator_Tag.Default.BetonTasimaVarYok = true;

            }
        }

     

        private void PrevisuonPage_Click(object sender, EventArgs e)
        {
            _006_Konfigurator._00_SantralTipTemplate._001_SantralTipiSecimi SantralTipiSecimPage = new _00_SantralTipTemplate._001_SantralTipiSecimi();

            SantralTipiSecimPage.Show();
            this.Close();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._003_StokAlaniAgregaSecimi StokalaniPageAc = new _003_StokAlaniAgregaSecimi();
            StokalaniPageAc.Show();
            this.Close();
        }

        

       
    }
}
