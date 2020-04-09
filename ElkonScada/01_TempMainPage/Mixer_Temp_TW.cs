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
    public partial class Mixer_Temp_TW : UserControl
    {
        public Mixer_Temp_TW()
        {
            InitializeComponent();
            
    }
   
        public string MixerCalisButtonName;
    protected void RunMixer_ButtonClick(object sender, EventArgs e)
        {

        
       

        }

        private void Mixer_Temp_TW_Load(object sender, EventArgs e)
        {
            Miksersecimi();
        }
        public void Miksersecimi()
        {
            //Mikserler için location  bilgileri
            Planet.Location = new Point(0,0);
            TwinShaft.Location = new Point(0, 0);
            Pan.Location = new Point(0,0);
            //pan için de olcak

            //Textboxlar location bilgileri
            XB1_MikserKalanSure.Location = new Point(185, 15);
            XB1_MikserSlump.Location = new Point(64, 172);
            XB1_MikserKapakAcikKalmaSure.Location = new Point(73, 205);

            //Mikserler için kontrol  bilgileri
            Planet.Visible = false;
            TwinShaft.Visible = false;
            Pan.Visible = false;

            //Textboxlar visible kontrol
            XB1_MikserKalanSure.Visible = false;
            XB1_MikserSlump.Visible = false;
            XB1_MikserKapakAcikKalmaSure.Visible = false;

            //Ok işaret kısımları
            qs_TartiBandiCalisiyorLamp5.Visible = false;
            qs_TartiBandiCalisiyorLamp6.Visible = false;
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 1)
            {
                Planet.Location = new Point(0, 0);
                XB1_MikserKalanSure.Location = new Point(150, 127);
                XB1_MikserSlump.Location = new Point(37, 170);
                XB1_MikserKapakAcikKalmaSure.Location = new Point(120, 205);

                Planet.Visible = true;
                XB1_MikserKalanSure.Visible = true;
                XB1_MikserSlump.Visible = true;
                XB1_MikserKapakAcikKalmaSure.Visible = true;

                qs_TartiBandiCalisiyorLamp5.Visible = true;
                qs_TartiBandiCalisiyorLamp6.Visible = true;
            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 2)
            {
                Pan.Location = new Point(0, 0);
                XB1_MikserKalanSure.Location = new Point(185, 86);
                XB1_MikserSlump.Location = new Point(150, 156);
                XB1_MikserKapakAcikKalmaSure.Location = new Point(159, 189);

                Pan.Visible = true;
                XB1_MikserKalanSure.Visible = true;
                XB1_MikserSlump.Visible = true;
                XB1_MikserKapakAcikKalmaSure.Visible = true;

                qs_TartiBandiCalisiyorLamp5.Visible = true;
            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 3)
            {
                TwinShaft.Location = new Point(0, 0);
                XB1_MikserKalanSure.Location = new Point(185, 15);
                XB1_MikserSlump.Location = new Point(64, 172);
                XB1_MikserKapakAcikKalmaSure.Location = new Point(73, 205);

                TwinShaft.Visible = true;
                XB1_MikserKalanSure.Visible = true;
                XB1_MikserSlump.Visible = true;
                XB1_MikserKapakAcikKalmaSure.Visible = true;
            }
        }
        private void XB1_MikserKapakAcikKalmaSure_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pan_Click(object sender, EventArgs e)
        {

        }
    }
}
