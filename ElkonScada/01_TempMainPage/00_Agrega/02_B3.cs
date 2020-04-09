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
    public partial class _02_B3 : UserControl
    {
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();

        public _02_B3()
        {
            InitializeComponent();
            is_ButonAgrega3Vibrator.Parent = Bunker3;
            Bunker_Vibrator_03.Parent = Bunker3;
            NemIcon.Parent = Bunker3;

            is_ButonAgrega3.BackColor = Color.Transparent;
            Bunker_Vibrator_03.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega3.BackColor = Color.Transparent;

        }
        bool ButtonPreesed = false;
        private void is_ButonAgrega3_Click(object sender, EventArgs e)
        {
            HetagregaModbus.WriteBool(is_ButonAgrega3.ModbusAdress_S);
              
        }

        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        public void AgregaBunker3()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi>2)
            {
                AgregaAnimationTimer++;
                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega3Lambasi)
                {
                    is_ButonAgrega3.Image = ElkonScada.Properties.Resources.Button_Green;
                    ButtonPreesed = false;

                }
                else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega3Lambasi)
                {
                    is_ButonAgrega3.Image = ElkonScada.Properties.Resources.Button_Pressed;

                }
                else
                {
                    is_ButonAgrega3.Image = ElkonScada.Properties.Resources.Button_White;

                }
                XB19_Agrega3Nem.Text = "%" + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega3Nem);

                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega3Lambasi)
                {

                    AnimationFrameNumber++;
                    switch (AnimationFrameNumber)
                    {
                        case 1:
                            Bunker3.Image = ElkonScada.Properties.Resources.Bunker_02;
                            break;
                        case 2:
                            Bunker3.Image = ElkonScada.Properties.Resources.Bunker_03;
                            break;
                        case 3:
                            AnimationFrameNumber = 0;
                            break;
                        default:
                            Bunker3.Image = ElkonScada.Properties.Resources.Bunker;

                            break;
                    }
                }
                else
                {
                    Bunker3.Image = ElkonScada.Properties.Resources.Bunker;

                }
                AgregaAnimationTimer = 0;
            }
           
        }

        private void is_ButonAgrega3_KeyDown(object sender, KeyEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega3 = true;
            }
            //HetagregaModbus.ButtonWrite();
        }

        private void is_ButonAgrega3_KeyUp(object sender, KeyEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega3 = false;

            }
           // HetagregaModbus.ButtonWrite();

        }

        private void _02_B3_Load(object sender, EventArgs e)
        {
            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega3 = false;

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Bunker_Vibrator_03.Visible = true;
                is_ButonAgrega3Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                Bunker_Vibrator_03.Visible = false;
                is_ButonAgrega3Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                XB19_Agrega3Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                XB19_Agrega3Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
    }
    
}
