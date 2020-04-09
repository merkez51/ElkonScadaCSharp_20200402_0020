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
    public partial class _003_StokAlaniAgregaSecimi : Form
    {
        public _003_StokAlaniAgregaSecimi()
        {
            InitializeComponent();
        }
        
        private void Pic_BunkerSecim1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 1;
            BunkerSelectionFunction();
        }

        private void Pic_BunkerSecim2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 2;
            BunkerSelectionFunction();
        }

        private void Pic_BunkerSecim3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 3;
            BunkerSelectionFunction();
        }

        private void Pic_BunkerSecim4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 4;
            BunkerSelectionFunction();

        }

        private void Pic_BunkerSecim5_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 5;
            BunkerSelectionFunction();

        }

        private void Pic_BunkerSecim6_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi = 6;
            BunkerSelectionFunction();
        }
        string VibrasyonHassasKapakButtonYokText="";
        string VibrasyonHassasKapakButtonVarText = "";

        string VibrasyonYokButtonText = "";
        string VibrasyonVarButtonText = "";

        string NemOlcerYokButtonText = "";
        string NemOlcerVarButtonText = "";


        private void BunkerSecimleri()
        {
            VibrasyonHassasKapakButtonYokText = Localization.Localization.ES561_1;
            VibrasyonHassasKapakButtonVarText = Localization.Localization.ES562_1;

            VibrasyonYokButtonText = Localization.Localization.ES563_1;
            VibrasyonVarButtonText = Localization.Localization.ES564_1;

            NemOlcerYokButtonText = Localization.Localization.ES559_1;
            NemOlcerVarButtonText = Localization.Localization.ES560_1;

            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok)
            {
                ES561_1.Text = VibrasyonHassasKapakButtonVarText;
                ES561_1.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok)
            {
                ES561_1.Text = VibrasyonHassasKapakButtonYokText;
                ES561_1.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                ES563_1.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon1.Visible = true;
                ES563_1.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                ES563_1.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon1.Visible = false;
                Pic_Vibrasyon1.Image = Properties.Resources.Kucuk_Vibrator;
                ES563_1.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                ES559_1.Text = NemOlcerVarButtonText;
                Logo_Nem1.Visible = true;
                ES559_1.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                ES559_1.Text = NemOlcerYokButtonText;
                Logo_Nem1.Visible = false;
                ES559_1.BackColor = Color.White;

            }
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok)
            {
                Button_VibrasyonSecim2.Text = VibrasyonHassasKapakButtonVarText;
                Button_VibrasyonSecim2.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok)
            {
                Button_VibrasyonSecim2.Text = VibrasyonHassasKapakButtonYokText;
                Button_VibrasyonSecim2.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Button_Vibrator_Secim_2.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon2.Visible = true;
                Pic_Vibrasyon2.Image = Properties.Resources.Kucuk_Vibrator;

                Button_Vibrator_Secim_2.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Button_Vibrator_Secim_2.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon2.Visible = false;
                Button_Vibrator_Secim_2.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                Button_NemOlcerSecimi_2.Text = NemOlcerVarButtonText;
                Logo_Nem2.Visible = true;
                Button_NemOlcerSecimi_2.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                Button_NemOlcerSecimi_2.Text = NemOlcerYokButtonText;
                Logo_Nem2.Visible = false;
                Button_NemOlcerSecimi_2.BackColor = Color.White;

            }
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok)
            {
                Button_VibrasyonSecim3.Text = VibrasyonHassasKapakButtonVarText;
                Button_VibrasyonSecim3.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok)
            {
                Button_VibrasyonSecim3.Text = VibrasyonHassasKapakButtonYokText;
                Button_VibrasyonSecim3.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Button_Vibrator_Secim_3.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon3.Visible = true;
                Pic_Vibrasyon3.Image = Properties.Resources.Kucuk_Vibrator;

                Button_Vibrator_Secim_3.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Button_Vibrator_Secim_3.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon3.Visible = false;
                Button_Vibrator_Secim_3.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                Button_NemOlcerSecimi_3.Text = NemOlcerVarButtonText;
                Logo_Nem3.Visible = true;
                Pic_Vibrasyon3.Image = Properties.Resources.Kucuk_Vibrator;

                Button_NemOlcerSecimi_3.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                Button_NemOlcerSecimi_3.Text = NemOlcerYokButtonText;
                Logo_Nem3.Visible = false;
                Button_NemOlcerSecimi_3.BackColor = Color.White;

            }
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok)
            {
                Button_VibrasyonSecim4.Text = VibrasyonHassasKapakButtonVarText;
                Button_VibrasyonSecim4.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok)
            {
                Button_VibrasyonSecim4.Text = VibrasyonHassasKapakButtonYokText;
                Button_VibrasyonSecim4.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Button_Vibrator_Secim_4.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon4.Visible = true;

                Button_Vibrator_Secim_4.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Button_Vibrator_Secim_4.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon4.Visible = false;
                Pic_Vibrasyon4.Image = Properties.Resources.Kucuk_Vibrator;

                Button_Vibrator_Secim_4.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                Button_NemOlcerSecimi_4.Text = NemOlcerVarButtonText;
                Logo_Nem4.Visible = true;
                Button_NemOlcerSecimi_4.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                Button_NemOlcerSecimi_4.Text = NemOlcerYokButtonText;
                Logo_Nem4.Visible = false;
                Button_NemOlcerSecimi_4.BackColor = Color.White;

            }
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok)
            {
                Button_VibrasyonSecim5.Text = VibrasyonHassasKapakButtonVarText;
                Button_VibrasyonSecim5.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok)
            {
                Button_VibrasyonSecim5.Text = VibrasyonHassasKapakButtonYokText;
                Button_VibrasyonSecim5.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Button_Vibrator_Secim_5.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon5.Visible = true;
                Button_Vibrator_Secim_5.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Button_Vibrator_Secim_5.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon5.Visible = false;
                Pic_Vibrasyon5.Image = Properties.Resources.Kucuk_Vibrator;

                Button_Vibrator_Secim_5.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                Button_NemOlcerSecimi_5.Text = NemOlcerVarButtonText;
                Logo_Nem5.Visible = true;
                Button_NemOlcerSecimi_5.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                Button_NemOlcerSecimi_5.Text = NemOlcerYokButtonText;
                Logo_Nem5.Visible = false;

                Button_NemOlcerSecimi_5.BackColor = Color.White;

            }
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok)
            {
                Button_VibrasyonSecim6.Text = VibrasyonHassasKapakButtonVarText;
                Button_VibrasyonSecim6.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok)
            {
                Button_VibrasyonSecim6.Text = VibrasyonHassasKapakButtonYokText;
                Button_VibrasyonSecim6.BackColor = Color.White;
            }

            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Button_Vibrator_Secim_6.Text = VibrasyonVarButtonText;
                Pic_Vibrasyon6.Visible = true;
                Button_Vibrator_Secim_6.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Button_Vibrator_Secim_6.Text = VibrasyonYokButtonText;
                Pic_Vibrasyon6.Visible = false;
                Pic_Vibrasyon6.Image = Properties.Resources.Kucuk_Vibrator;

                Button_Vibrator_Secim_6.BackColor = Color.White;

            }

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                Button_NemOlcerSecimi_6.Text = NemOlcerVarButtonText;
                Logo_Nem6.Visible = true;
                Button_NemOlcerSecimi_6.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                Button_NemOlcerSecimi_6.Text = NemOlcerYokButtonText;
                Logo_Nem6.Visible = false;
                Button_NemOlcerSecimi_6.BackColor = Color.White;

            }


            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    Pic_Vibrasyon2.Visible = false;
                    Logo_Nem2.Visible = false;
                    Pic_Vibrasyon3.Visible = false;
                    Logo_Nem3.Visible = false;
                    Pic_Vibrasyon4.Visible = false;
                    Logo_Nem4.Visible = false;
                    Pic_Vibrasyon5.Visible = false;
                    Logo_Nem5.Visible = false;
                    Pic_Vibrasyon6.Visible = false;
                    Logo_Nem6.Visible = false;


                    Button_VibrasyonSecim2.Visible = false;
                    Button_Vibrator_Secim_2.Visible = false;
                    Button_NemOlcerSecimi_2.Visible = false;


                    Button_VibrasyonSecim3.Visible = false;
                    Button_Vibrator_Secim_3.Visible = false;
                    Button_NemOlcerSecimi_3.Visible = false;


                    Button_VibrasyonSecim4.Visible = false;
                    Button_Vibrator_Secim_4.Visible = false;
                    Button_NemOlcerSecimi_4.Visible = false;

                    Button_VibrasyonSecim5.Visible = false;
                    Button_Vibrator_Secim_5.Visible = false;
                    Button_NemOlcerSecimi_5.Visible = false;


                    Button_VibrasyonSecim6.Visible = false;
                    Button_Vibrator_Secim_6.Visible = false;
                    Button_NemOlcerSecimi_6.Visible = false;

                    break;
                case 2:
                    Pic_Vibrasyon3.Visible = false;
                    Logo_Nem3.Visible = false;
                    Pic_Vibrasyon4.Visible = false;
                    Logo_Nem4.Visible = false;
                    Pic_Vibrasyon5.Visible = false;
                    Logo_Nem5.Visible = false;
                    Pic_Vibrasyon6.Visible = false;
                    Logo_Nem6.Visible = false;

                    Button_VibrasyonSecim2.Visible = true;
                    Button_Vibrator_Secim_2.Visible = true;
                    Button_NemOlcerSecimi_2.Visible = true;

                    Button_VibrasyonSecim3.Visible = false;
                    Button_Vibrator_Secim_3.Visible = false;
                    Button_NemOlcerSecimi_3.Visible = false;


                    Button_VibrasyonSecim4.Visible = false;
                    Button_Vibrator_Secim_4.Visible = false;
                    Button_NemOlcerSecimi_4.Visible = false;

                    Button_VibrasyonSecim5.Visible = false;
                    Button_Vibrator_Secim_5.Visible = false;
                    Button_NemOlcerSecimi_5.Visible = false;


                    Button_VibrasyonSecim6.Visible = false;
                    Button_Vibrator_Secim_6.Visible = false;
                    Button_NemOlcerSecimi_6.Visible = false;

                    break;
                case 3:

                    Button_VibrasyonSecim2.Visible = true;
                    Button_Vibrator_Secim_2.Visible = true;
                    Button_NemOlcerSecimi_2.Visible = true;

                    Button_VibrasyonSecim3.Visible = true;
                    Button_Vibrator_Secim_3.Visible = true;
                    Button_NemOlcerSecimi_3.Visible = true;

                    Pic_Vibrasyon4.Visible = false;
                    Logo_Nem4.Visible = false;
                    Pic_Vibrasyon5.Visible = false;
                    Logo_Nem5.Visible = false;
                    Pic_Vibrasyon6.Visible = false;
                    Logo_Nem6.Visible = false;

                    Button_VibrasyonSecim4.Visible = false;
                    Button_Vibrator_Secim_4.Visible = false;
                    Button_NemOlcerSecimi_4.Visible = false;

                    Button_VibrasyonSecim5.Visible = false;
                    Button_Vibrator_Secim_5.Visible = false;
                    Button_NemOlcerSecimi_5.Visible = false;


                    Button_VibrasyonSecim6.Visible = false;
                    Button_Vibrator_Secim_6.Visible = false;
                    Button_NemOlcerSecimi_6.Visible = false;
                    break;
                case 4:
                    Button_VibrasyonSecim2.Visible = true;
                    Button_Vibrator_Secim_2.Visible = true;
                    Button_NemOlcerSecimi_2.Visible = true;

                    Button_VibrasyonSecim3.Visible = true;
                    Button_Vibrator_Secim_3.Visible = true;
                    Button_NemOlcerSecimi_3.Visible = true;


                    Button_VibrasyonSecim4.Visible = true;
                    Button_Vibrator_Secim_4.Visible = true;
                    Button_NemOlcerSecimi_4.Visible = true;

                    Pic_Vibrasyon5.Visible = false;
                    Logo_Nem5.Visible = false;
                    Pic_Vibrasyon6.Visible = false;
                    Logo_Nem6.Visible = false;


                    Button_VibrasyonSecim5.Visible = false;
                    Button_Vibrator_Secim_5.Visible = false;
                    Button_NemOlcerSecimi_5.Visible = false;


                    Button_VibrasyonSecim6.Visible = false;
                    Button_Vibrator_Secim_6.Visible = false;
                    Button_NemOlcerSecimi_6.Visible = false;

                    break;
                case 5:
                    Button_VibrasyonSecim2.Visible = true;
                    Button_Vibrator_Secim_2.Visible = true;
                    Button_NemOlcerSecimi_2.Visible = true;

                    Button_VibrasyonSecim3.Visible = true;
                    Button_Vibrator_Secim_3.Visible = true;
                    Button_NemOlcerSecimi_3.Visible = true;

                    Button_VibrasyonSecim4.Visible = true;
                    Button_Vibrator_Secim_4.Visible = true;
                    Button_NemOlcerSecimi_4.Visible = true;

                    Button_VibrasyonSecim5.Visible = true;
                    Button_Vibrator_Secim_5.Visible = true;
                    Button_NemOlcerSecimi_5.Visible = true;

                    Pic_Vibrasyon6.Visible = false;
                    Logo_Nem6.Visible = false;

                    Button_VibrasyonSecim6.Visible = false;
                    Button_Vibrator_Secim_6.Visible = false;
                    Button_NemOlcerSecimi_6.Visible = false;

                    break;
                case 6:
                    Button_VibrasyonSecim2.Visible = true;
                    Button_Vibrator_Secim_2.Visible = true;
                    Button_NemOlcerSecimi_2.Visible = true;

                    Button_VibrasyonSecim3.Visible = true;
                    Button_Vibrator_Secim_3.Visible = true;
                    Button_NemOlcerSecimi_3.Visible = true;

                    Button_VibrasyonSecim4.Visible = true;
                    Button_Vibrator_Secim_4.Visible = true;
                    Button_NemOlcerSecimi_4.Visible = true;

                    Button_VibrasyonSecim5.Visible = true;
                    Button_Vibrator_Secim_5.Visible = true;
                    Button_NemOlcerSecimi_5.Visible = true;


                    Button_VibrasyonSecim6.Visible = true;
                    Button_Vibrator_Secim_6.Visible = true;
                    Button_NemOlcerSecimi_6.Visible = true;
                    break;
                default:
                    break;
            }


        }
        private void BunkerSelectionFunction()
        {
            


            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker_Temp_Blur;

                    

                    break;
                case 2:
                
                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker_Temp_Blur;


                    break;
                case 3:
                  
                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker_Temp_Blur;


                   
                    break;
                case 4:
                

                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker_Temp_Blur;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker_Temp_Blur;

                

                    break;
                case 5:
                 

                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker_Temp_Blur;

                   

                    break;
                case 6:
                  

                    Pic_BunkerSecim1.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim2.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim3.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim4.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim5.Image = Properties.Resources.Bunker;
                    Pic_BunkerSecim6.Image = Properties.Resources.Bunker;

                    break;

                default:
                    break;
            }
            BunkerSecimleri();
            AgregaBunkerSayisi.Text = Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi.ToString() ;
        }

        private void ES561_1_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok)
            {
                ES561_1.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok = false;
                ES561_1.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok)
            {
                ES561_1.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg1Var_Yok = true;
                ES561_1.BackColor = Color.Green;
            }
            BunkerSelectionFunction();
        }

        private void ES563_1_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                ES563_1.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok = false;
                Pic_Vibrasyon1.Visible = false;
                ES563_1.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                ES563_1.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok = true;
                Pic_Vibrasyon1.Visible = true;
                ES563_1.BackColor = Color.White;

            }
            BunkerSelectionFunction();

        }

        private void ES559_1_Click(object sender, EventArgs e)
        {

            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                ES559_1.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok = false;
                Logo_Nem1.Visible = false;
                ES559_1.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                ES559_1.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok = true;
                Logo_Nem1.Visible = true;
                ES559_1.BackColor = Color.White;

            }
            BunkerSelectionFunction();

        }

        private void _003_StokAlaniAgregaSecimi_Load(object sender, EventArgs e)
        {
            BunkerSelectionFunction();
        }

        private void Button_VibrasyonSecim2_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok)
            {
                Button_VibrasyonSecim2.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok = false;
                Button_VibrasyonSecim2.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok)
            {
                Button_VibrasyonSecim2.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg2Var_Yok = true;
                Button_VibrasyonSecim2.BackColor = Color.Green;
            }
            BunkerSelectionFunction();

        }
        private void Button_VibrasyonSecim3_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok)
            {
                Button_VibrasyonSecim3.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok = false;
                Button_VibrasyonSecim3.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok)
            {
                Button_VibrasyonSecim3.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg3Var_Yok = true;
                Button_VibrasyonSecim3.BackColor = Color.Green;
            }
            BunkerSelectionFunction();
        }
        private void Button_VibrasyonSecim4_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok)
            {
                Button_VibrasyonSecim4.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok = false;
                Button_VibrasyonSecim4.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok)
            {
                Button_VibrasyonSecim4.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg4Var_Yok = true;
                Button_VibrasyonSecim4.BackColor = Color.Green;
            }
            BunkerSelectionFunction();
        }
        private void Button_VibrasyonSecim5_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok)
            {
                Button_VibrasyonSecim5.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok = false;
                Button_VibrasyonSecim5.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok)
            {
                Button_VibrasyonSecim5.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg5Var_Yok = true;
                Button_VibrasyonSecim5.BackColor = Color.Green;
            }
            BunkerSelectionFunction();
        }
       

        private void Button_VibrasyonSecim6_Click(object sender, EventArgs e)
        {
            //HassasTartimSecimi
            if (Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok)
            {
                Button_VibrasyonSecim6.Text = VibrasyonHassasKapakButtonYokText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok = false;
                Button_VibrasyonSecim6.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok)
            {
                Button_VibrasyonSecim6.Text = VibrasyonHassasKapakButtonVarText;
                Properties.S000_Konfigrator_Tag.Default.HassasKapakAg6Var_Yok = true;
                Button_VibrasyonSecim6.BackColor = Color.Green;
            }
            BunkerSelectionFunction();
        }

        private void Button_Vibrator_Secim_2_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Button_Vibrator_Secim_2.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok = false;
                Pic_Vibrasyon2.Visible = false;
                Button_Vibrator_Secim_2.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Button_Vibrator_Secim_2.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok = true;
                Pic_Vibrasyon2.Visible = true;
                Button_Vibrator_Secim_2.BackColor = Color.White;

            }
            BunkerSelectionFunction();
        }

        private void Button_Vibrator_Secim3_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Button_Vibrator_Secim_3.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok = false;
                Pic_Vibrasyon3.Visible = false;
                Button_Vibrator_Secim_3.BackColor = Color.Green;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Button_Vibrator_Secim_3.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok = true;
                Pic_Vibrasyon3.Visible = true;
                Button_Vibrator_Secim_3.BackColor = Color.White;

            }
            BunkerSelectionFunction();
        }

        private void Button_Vibrator_Secim4_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Button_Vibrator_Secim_4.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok = false;
                Pic_Vibrasyon4.Visible = false;
                Button_Vibrator_Secim_4.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Button_Vibrator_Secim_4.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok = true;
                Pic_Vibrasyon4.Visible = true;
                Button_Vibrator_Secim_4.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_Vibrator_Secim_5_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Button_Vibrator_Secim_5.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok = false;
                Pic_Vibrasyon5.Visible = false;
                Button_Vibrator_Secim_5.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Button_Vibrator_Secim_5.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok = true;
                Pic_Vibrasyon5.Visible = true;
                Button_Vibrator_Secim_5.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_Vibrator_Secim_6_Click(object sender, EventArgs e)
        {
            //Vibrator Secimi
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Button_Vibrator_Secim_6.Text = VibrasyonYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok = false;
                Pic_Vibrasyon6.Visible = false;
                Button_Vibrator_Secim_6.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Button_Vibrator_Secim_6.Text = VibrasyonVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok = true;
                Pic_Vibrasyon6.Visible = true;
                Button_Vibrator_Secim_6.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_NemOlcerSecimi_2_Click(object sender, EventArgs e)
        {
            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                Button_NemOlcerSecimi_2.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok = false;
                Logo_Nem2.Visible = false;
                Button_NemOlcerSecimi_2.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                Button_NemOlcerSecimi_2.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok = true;
                Logo_Nem2.Visible = true;
                Button_NemOlcerSecimi_2.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_NemOlcerSecimi_3_Click(object sender, EventArgs e)
        {
            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                Button_NemOlcerSecimi_3.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok = false;
                Logo_Nem3.Visible = false;
                Button_NemOlcerSecimi_3.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                Button_NemOlcerSecimi_3.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok = true;
                Logo_Nem3.Visible = true;
                Button_NemOlcerSecimi_3.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_NemOlcerSecimi_4_Click(object sender, EventArgs e)
        {
            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                Button_NemOlcerSecimi_4.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok = false;
                Logo_Nem4.Visible = false;
                Button_NemOlcerSecimi_4.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                Button_NemOlcerSecimi_4.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok = true;
                Logo_Nem4.Visible = true;
                Button_NemOlcerSecimi_4.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_NemOlcerSecimi_5_Click(object sender, EventArgs e)
        {
            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                Button_NemOlcerSecimi_5.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok = false;
                Logo_Nem5.Visible = false;
                Button_NemOlcerSecimi_5.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                Button_NemOlcerSecimi_5.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok = true;
                Logo_Nem5.Visible = true;
                Button_NemOlcerSecimi_5.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void Button_NemOlcerSecimi_6_Click(object sender, EventArgs e)
        {
            //NemOlcer Secimi
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                Button_NemOlcerSecimi_6.Text = NemOlcerYokButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok = false;
                Logo_Nem6.Visible = false;
                Button_NemOlcerSecimi_6.BackColor = Color.White;

            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                Button_NemOlcerSecimi_6.Text = NemOlcerVarButtonText;
                Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok = true;
                Logo_Nem6.Visible = true;
                Button_NemOlcerSecimi_6.BackColor = Color.Green;

            }
            BunkerSelectionFunction();
        }

        private void BackWindow_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator.MikserBunkerSecimi MikseSecim = new MikserBunkerSecimi();
            MikseSecim.Show();
            this.Close();
        }

        private void MikserBunkerSecimi_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._0041_StokAlaniKatkiSuSecimi StokAlanlariKatkiSecimi = new _0041_StokAlaniKatkiSuSecimi();
            StokAlanlariKatkiSecimi.Show();
            this.Close();
        }

        private void _003_StokAlaniAgregaSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }
    }
}
