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

    public partial class _03_B4 : UserControl
    {
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();

        public _03_B4()
        {
            InitializeComponent();
            is_ButonAgrega4Vibrator.Parent = Bunker4;
            Bunker_Vibrator_04.Parent = Bunker4;
            NemIcon.Parent = Bunker4;

            is_ButonAgrega4.BackColor = Color.Transparent;
            Bunker_Vibrator_04.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega4.BackColor = Color.Transparent;

        }
        bool ButtonPreesed = false;

        private void is_ButonAgrega4_Click(object sender, EventArgs e)
        {
            HetagregaModbus.WriteBool(is_ButonAgrega4.ModbusAdress_S);

               
        }
        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        public void AgregaBunker4()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi>3)
            {
                AgregaAnimationTimer++;
                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega4Lambasi)
                {
                    is_ButonAgrega4.Image = ElkonScada.Properties.Resources.Button_Green;
                    ButtonPreesed = false;

                }
                else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega4Lambasi)
                {
                    is_ButonAgrega4.Image = ElkonScada.Properties.Resources.Button_Pressed;

                }
                else
                {
                    is_ButonAgrega4.Image = ElkonScada.Properties.Resources.Button_White;

                }
                XB19_Agrega4Nem.Text = "%" + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega4Nem);

                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega4Lambasi)
                {

                    AnimationFrameNumber++;
                    switch (AnimationFrameNumber)
                    {
                        case 1:
                            Bunker4.Image = ElkonScada.Properties.Resources.Bunker_02;
                            break;
                        case 2:
                            Bunker4.Image = ElkonScada.Properties.Resources.Bunker_03;
                            break;
                        case 3:
                            AnimationFrameNumber = 0;
                            break;
                        default:
                            Bunker4.Image = ElkonScada.Properties.Resources.Bunker;

                            break;
                    }
                }
                else
                {
                    Bunker4.Image = ElkonScada.Properties.Resources.Bunker;

                }
                AgregaAnimationTimer = 0;
            }
           
        



    }

        private void is_ButonAgrega4_MouseDown(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega4 = true;
                is_ButonAgrega4.Image = ElkonScada.Properties.Resources.Button_Pressed;

            }
          //  HetagregaModbus.ButtonWrite();
        }

        private void is_ButonAgrega4_MouseUp(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega4 = false;

            }
            //HetagregaModbus.ButtonWrite();
        }

        private void _03_B4_Load(object sender, EventArgs e)
        {
            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega4 = false;

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Bunker_Vibrator_04.Visible = true;
                is_ButonAgrega4Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                Bunker_Vibrator_04.Visible = false;
                is_ButonAgrega4Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                XB19_Agrega4Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                XB19_Agrega4Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
    }
}
