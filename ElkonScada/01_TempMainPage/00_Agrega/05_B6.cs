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
    public partial class _05_B6 : UserControl
    {
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();

        public _05_B6()
        {
            InitializeComponent();
            is_ButonAgrega6Vibrator.Parent = Bunker6;
            Bunker_Vibrator_06.Parent = Bunker6;
            NemIcon.Parent = Bunker6;

            is_ButonAgrega6.BackColor = Color.Transparent;
            Bunker_Vibrator_06.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega6.BackColor = Color.Transparent;

        }
        bool ButtonPreesed = false;

        private void is_ButonAgrega6_Click(object sender, EventArgs e)
        {
            if (!ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                if (ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega1 == true)
                {
                    ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega1 = false;
                }
                else if (ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 == false )
                {
                    ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 = true;
                    ButtonPreesed = true;
                    is_ButonAgrega6.Image = ElkonScada.Properties.Resources.Button_Pressed;
                }
                //HetagregaModbus.ButtonWrite();
            }

            
        }
        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        public void AgregaBunker6()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi>5)
            {
                AgregaAnimationTimer++;
                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega6Lambasi)
                {
                    is_ButonAgrega6.Image = ElkonScada.Properties.Resources.Button_Green;
                    ButtonPreesed = false;

                }
                else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega6Lambasi)
                {
                    is_ButonAgrega6.Image = ElkonScada.Properties.Resources.Button_Pressed;

                }
                else
                {
                    is_ButonAgrega6.Image = ElkonScada.Properties.Resources.Button_White;

                }
                XB19_Agrega6Nem.Text = "%" + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega6Nem);

                if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega6Lambasi)
                {

                    AnimationFrameNumber++;
                    switch (AnimationFrameNumber)
                    {
                        case 1:
                            Bunker6.Image = ElkonScada.Properties.Resources.Bunker_02;
                            break;
                        case 2:
                            Bunker6.Image = ElkonScada.Properties.Resources.Bunker_03;
                            break;
                        case 3:
                            AnimationFrameNumber = 0;
                            break;
                        default:
                            Bunker6.Image = ElkonScada.Properties.Resources.Bunker;

                            break;
                    }
                }
                else
                {
                    Bunker6.Image = ElkonScada.Properties.Resources.Bunker;

                }
                AgregaAnimationTimer = 0;
            }
        
        }

        private void is_ButonAgrega6_MouseDown(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 = true;
                is_ButonAgrega6.Image = ElkonScada.Properties.Resources.Button_Pressed;

            }
           // HetagregaModbus.ButtonWrite();
        }

        private void is_ButonAgrega6_MouseUp(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 = false;

            }
         //   HetagregaModbus.ButtonWrite();
        }

        private void _05_B6_Load(object sender, EventArgs e)
        {
            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega6 = false;

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Bunker_Vibrator_06.Visible = true;
                is_ButonAgrega6Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                Bunker_Vibrator_06.Visible = false;
                is_ButonAgrega6Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                XB19_Agrega6Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg6Var_Yok)
            {
                XB19_Agrega6Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
    }
}
