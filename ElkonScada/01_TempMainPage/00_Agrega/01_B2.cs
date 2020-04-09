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
    public partial class _01_B2 : UserControl
    {
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();
        public _01_B2()
        {
            InitializeComponent();
            is_ButonAgrega2Vibrator.Parent = Bunker2;
            Bunker_Vibrator_02.Parent = Bunker2;
            NemIcon.Parent = Bunker2;

            is_ButonAgrega2.BackColor = Color.Transparent;
            Bunker_Vibrator_02.BackColor = Color.Transparent;
            NemIcon.BackColor = Color.Transparent;
            is_ButonAgrega2.BackColor = Color.Transparent;

        }
        bool ButtonPreesed = false;
        private void is_ButonAgrega2_Click(object sender, EventArgs e)
        {
            HetagregaModbus.WriteBool(is_ButonAgrega2.ModbusAdress_S);
          
            
        }
        int AgregaAnimationTimer = 0;//Timer 100 ms
        int AnimationFrameNumber = 0;
        public void AgregaBunker2()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi>1)
            {
              if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega2Lambasi)
                        {
                            is_ButonAgrega2.Image = ElkonScada.Properties.Resources.Button_Green;
                            ButtonPreesed = false;

                        }
                        else if (ButtonPreesed && !ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega2Lambasi)
                        {
                            is_ButonAgrega2.Image = ElkonScada.Properties.Resources.Button_Pressed;

                        }
                        else
                        {
                            is_ButonAgrega2.Image = ElkonScada.Properties.Resources.Button_White;

                        }
                        XB19_Agrega2Nem.Text = "%" + Convert.ToString(Properties.M015_Agrega.Default.XB19_Agrega2Nem);
                        if (ElkonScada.Properties.M012_Lambalar.Default.qs_Agrega2Lambasi)
                        {

                            AnimationFrameNumber++;
                            switch (AnimationFrameNumber)
                            {
                                case 1:
                                    Bunker2.Image = ElkonScada.Properties.Resources.Bunker_02;
                                    break;
                                case 2:
                                    Bunker2.Image = ElkonScada.Properties.Resources.Bunker_03;
                                    break;
                                case 3:
                                    AnimationFrameNumber = 0;
                                    break;
                 
                                default:
                                    Bunker2.Image = ElkonScada.Properties.Resources.Bunker;

                                    break;
                            }
                        }
                        else
                        {
                            Bunker2.Image = ElkonScada.Properties.Resources.Bunker;

                        }
                        AgregaAnimationTimer = 0;
            }
          
        }

        private void is_ButonAgrega2_MouseDown(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega2 = true;
            }
            //HetagregaModbus.ButtonWrite();
        }

        private void is_ButonAgrega2_MouseUp(object sender, MouseEventArgs e)
        {
            if (ElkonScada.Properties.Sys001_Anasayfa_System_Tag.Default.AgregaKaliciButton
                 && !ElkonScada.Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega2 = false;

            }
           // HetagregaModbus.ButtonWrite();
        }

        private void _01_B2_Load(object sender, EventArgs e)
        {
            ElkonScada.Properties.M011_ButonLar.Default.is_ButonAgrega2 = false;

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Bunker_Vibrator_02.Visible = true;
                is_ButonAgrega2Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                Bunker_Vibrator_02.Visible = false;
                is_ButonAgrega2Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                XB19_Agrega2Nem.Visible = true;
                NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                XB19_Agrega2Nem.Visible = false;
                NemIcon.Visible = false;
            }
        }
    }
    
}
