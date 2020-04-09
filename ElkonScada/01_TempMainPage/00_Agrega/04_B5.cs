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
    public partial class _04_B5 : UserControl
    {
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();

        public _04_B5()
        {
            InitializeComponent();
            is_ButonAgrega5Vibrator.Parent = Bunker5;
            Bunker_Vibrator_05.Parent = Bunker5;
            NemIcon.Parent = Bunker5;

            is_ButonAgrega5.BackColor = Color.Transparent;
            Bunker_Vibrator_05.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega5.BackColor = Color.Transparent;

        }
        bool ButtonPreesed = false;

        private void is_ButonAgrega5_Click(object sender, EventArgs e)
        {
            HetagregaModbus.WriteBool(is_ButonAgrega5.ModbusAdress_S);
        }
        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        public void AgregaBunker5()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi>4)
            {
                AgregaAnimationTimer++;
                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega5Lambasi)
                {
                    is_ButonAgrega5.Image = ElkonScada.Properties.Resources.Button_Green;
                    ButtonPreesed = false;
                }
                else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega1Lambasi)
                {
                    is_ButonAgrega5.Image = ElkonScada.Properties.Resources.Button_Pressed;

                }
                else
                {
                    is_ButonAgrega5.Image = ElkonScada.Properties.Resources.Button_White;

                }
                XB19_Agrega5Nem.Text = "%" + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega5Nem);

                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega5Lambasi)
                {

                    AnimationFrameNumber++;
                    switch (AnimationFrameNumber)
                    {
                        case 1:
                            Bunker5.Image = ElkonScada.Properties.Resources.Bunker_02;
                            break;
                        case 2:
                            Bunker5.Image = ElkonScada.Properties.Resources.Bunker_03;
                            break;
                        case 3:
                            AnimationFrameNumber = 0;
                            break;
                        default:
                            Bunker5.Image = ElkonScada.Properties.Resources.Bunker;

                            break;
                    }
                }
                else
                {
                    Bunker5.Image = ElkonScada.Properties.Resources.Bunker;

                }
                AgregaAnimationTimer = 0;
            }
         
        }

        private void is_ButonAgrega5_MouseDown(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 = true;
                is_ButonAgrega5.Image = ElkonScada.Properties.Resources.Button_Pressed;

            }
          // HetagregaModbus.ButtonWrite();
        }

        private void is_ButonAgrega5_MouseUp(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega5 = false;

            }
            //HetagregaModbus.ButtonWrite();
        }

        private void _04_B5_Load(object sender, EventArgs e)
        {
            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega5 = false;

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Bunker_Vibrator_05.Visible = true;
                is_ButonAgrega5Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                Bunker_Vibrator_05.Visible = false;
                is_ButonAgrega5Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                XB19_Agrega5Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                XB19_Agrega5Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
    }
}
