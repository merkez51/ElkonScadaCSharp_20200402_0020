using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._01_TempMainPage._00_Agrega
{
    public partial class _00_B1 : UserControl
    {
        XX_Connection.ModbusConnection HetmodBusTool = XX_Connection.ModbusConnection.HetConnection();

        public _00_B1()
        {
            InitializeComponent();
            is_ButonAgrega1Vibrator.Parent = Bunker1;
            Bunker_Vibrator_01.Parent = Bunker1;
            NemIcon.Parent = Bunker1;
          

            is_ButonAgrega1.BackColor = Color.Transparent;
            Bunker_Vibrator_01.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega1.BackColor = Color.Transparent;
        }
       private void _00_B1_Load(object sender, EventArgs e)
        {

            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega1 = false;
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                Bunker_Vibrator_01.Visible = true;
                is_ButonAgrega1Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                Bunker_Vibrator_01.Visible = false;
                is_ButonAgrega1Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                XB19_Agrega1Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                XB19_Agrega1Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
        bool ButtonPreesed = false;
        private void is_ButonAgrega1_Click(object sender, EventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                HetmodBusTool.WriteBool(is_ButonAgrega1.ModbusAdress_S);
            }

        }
        public void ButtonPressed(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                HetmodBusTool.WriteBool(is_ButonAgrega1.ModbusAdress_S);
            }
        }
        
        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        int AnimationFrameError = 0;
        public void AgregaBunker1()
        {
            //Vibrator ile ilgili işlemler
            if (Properties.M012_Lambalar.Default.qs_Agrega1VibratorLambasi &&
                Properties.M011_ButonLar.Default.is_ButonAgrega1Vibrator
                )
            {
                is_ButonAgrega1Vibrator.Image = Properties.Resources.Lamp_Vibrator_ON_Q;
               
            }
            else if (!Properties.M012_Lambalar.Default.qs_Agrega1VibratorLambasi &&
                Properties.M011_ButonLar.Default.is_ButonAgrega1Vibrator && Properties.M010_Alarm.Default.AL_A202_2_AgregaBunker2VibratorTMSArizasi)
            {
                is_ButonAgrega1Vibrator.Image = Properties.Resources.Lamp_Vibrator_ON;

            }
          
            else if (!Properties.M011_ButonLar.Default.is_ButonAgrega1Vibrator
           && !Properties.M012_Lambalar.Default.qs_Agrega1VibratorLambasi 
           && Properties.M010_Alarm.Default.AL_A202_2_AgregaBunker2VibratorTMSArizasi)
            {
                is_ButonAgrega1Vibrator.Image = Properties.Resources.Lamp_Vibrator_OFF;

            }
            else if (!Properties.M010_Alarm.Default.AL_A202_2_AgregaBunker2VibratorTMSArizasi && Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                AnimationFrameError++;
                switch (AnimationFrameError)
                {
                    case 2:
                        is_ButonAgrega1Vibrator.Image = Properties.Resources.Lamp_Vibrator_OFF;
                        is_ButonAgrega1Vibrator.Visible = true;
                        break;

                    case 4:
                        is_ButonAgrega1Vibrator.Image = Properties.Resources.Logo_Icon;
                        is_ButonAgrega1Vibrator.Visible = true;

                        break;

                    case 6:
                        is_ButonAgrega1Vibrator.Image = Properties.Resources.Lamp_Vibrator_OFF;
                        is_ButonAgrega1Vibrator.Visible = true;

                        AnimationFrameError = 0;
                        break;
                    default:
                        break;
                }
            }
            else if (Properties.M010_Alarm.Default.AL_A202_2_AgregaBunker2VibratorTMSArizasi 
                && Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                is_ButonAgrega1Vibrator.Visible = true;

            }
            else if(!Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                is_ButonAgrega1Vibrator.Visible = false;
            }
            //Vibrator ile ilgili işlemler

            AgregaAnimationTimer++;
            if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega1Lambasi)
            {
                is_ButonAgrega1.StartColor = Color.Green;
                ButtonPreesed = false;
            }
            else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega1Lambasi)
            {
                is_ButonAgrega1.StartColor = Color.White;

            }
            else
            {
                is_ButonAgrega1.StartColor = Color.White;
            }

            XB19_Agrega1Nem.Text = Localization.Localization.ES918_1 + " " + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega1Nem);
            XB2_Agrega1Istenen.Text = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1 + Localization.Localization.ES193_1;
            XB19_Agrega1Verilen.Text = Convert.ToString(Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01) + Localization.Localization.ES193_1;

            if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega1Lambasi)
            {

                AnimationFrameNumber++;
                switch (AnimationFrameNumber)
                {
                    case 1:
                        Bunker1.Image = ElkonScada.Properties.Resources.Bunker_02;
                        break;
                    case 2:
                        Bunker1.Image = ElkonScada.Properties.Resources.Bunker_03;
                        break;
                    case 3:
                        AnimationFrameNumber = 0;
                        break;
                    default:
                        Bunker1.Image = ElkonScada.Properties.Resources.Bunker;

                        break;
                }
            }
            else
            {
                Bunker1.Image = ElkonScada.Properties.Resources.Bunker;

            }
                AgregaAnimationTimer = 0;

      
            }

        private void is_ButonAgrega1Vibrator_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool("MX.0.73.6");
        }
    }
}
