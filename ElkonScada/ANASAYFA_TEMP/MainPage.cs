using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ElkonScada.ANASAYFA_TEMP
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void KatkiCountText_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
       
        private void AgregaButonTipiSelector_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            AgregaSiloYerlesimi();
            Su_kantarsayacbelirleme();
            Katki_kantarsayacbelirleme();
            Cimento_Kantarbelirleme();
            Mikseregoreboruzunluklari();
            Santral_belirleme();
        }
        public void AgregaSiloYerlesimi()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    _00_B11.Visible = true;
                    _01_B21.Visible = false;
                    _02_B31.Visible = false;
                    _03_B41.Visible = false;
                    _04_B51.Visible = false;
                    _05_B61.Visible = false;

                    _00_B11.Location = new Point(213, 356);
                    AgregaButonTipiSelector.Location = new Point(333, 480);
                    break;
                case 2:
                    _00_B11.Visible = true;
                    _01_B21.Visible = true;
                    _02_B31.Visible = false;
                    _03_B41.Visible = false;
                    _04_B51.Visible = false;
                    _05_B61.Visible = false;


                    _00_B11.Location = new Point(160, 356);
                    _01_B21.Location = new Point(265, 356);
                    AgregaButonTipiSelector.Location = new Point(385, 480);

                    break;
                case 3:
                    _00_B11.Visible = true;
                    _01_B21.Visible = true;
                    _02_B31.Visible = true;
                    _03_B41.Visible = false;
                    _04_B51.Visible = false;
                    _05_B61.Visible = false;

                    _00_B11.Location = new Point(97, 356);
                    _01_B21.Location = new Point(212, 356);
                    _02_B31.Location = new Point(317, 356);
                    AgregaButonTipiSelector.Location = new Point(437, 480);
                    break;
                case 4:
                    _00_B11.Visible = true;
                    _01_B21.Visible = true;
                    _02_B31.Visible = true;
                    _03_B41.Visible = true;
                    _04_B51.Visible = false;
                    _05_B61.Visible = false;

                    _00_B11.Location = new Point(55, 356);
                    _01_B21.Location = new Point(160, 356);
                    _02_B31.Location = new Point(265, 356);
                    _03_B41.Location = new Point(370, 356);
                    AgregaButonTipiSelector.Location = new Point(490, 480);
                    break;
                case 5:
                    _00_B11.Visible = true;
                    _01_B21.Visible = true;
                    _02_B31.Visible = true;
                    _03_B41.Visible = true;
                    _04_B51.Visible = true;
                    _05_B61.Visible = false;


                    _00_B11.Location = new Point(2, 356);
                    _01_B21.Location = new Point(107, 356);
                    _02_B31.Location = new Point(212, 356);
                    _03_B41.Location = new Point(317, 356);
                    _04_B51.Location = new Point(422, 356);
                    AgregaButonTipiSelector.Location = new Point(542, 480);
                    break;
                case 6:
                    _00_B11.Visible = true;
                    _01_B21.Visible = true;
                    _02_B31.Visible = true;
                    _03_B41.Visible = true;
                    _04_B51.Visible = true;
                    _05_B61.Visible = true;

                    _00_B11.Location = new Point(0, 356);
                    _01_B21.Location = new Point(105, 356);
                    _02_B31.Location = new Point(210, 356);
                    _03_B41.Location = new Point(315, 356);
                    _04_B51.Location = new Point(420, 356);
                    _05_B61.Location = new Point(525, 356);
                    AgregaButonTipiSelector.Location = new Point(645, 480);

                    break;
                default:

                    break;
            }
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                _00_B11.Bunker_Vibrator_01.Visible = true;
                _00_B11.is_ButonAgrega1Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg1Var_Yok)
            {
                _00_B11.Bunker_Vibrator_01.Visible = false;
                _00_B11.is_ButonAgrega1Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                _00_B11.XB19_Agrega1Nem.Visible = true;
                _00_B11.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg1Var_Yok)
            {
                _00_B11.XB19_Agrega1Nem.Visible = false;
                _00_B11.NemIcon.Visible = false;
            }
            //2-----------------

            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                _01_B21.Bunker_Vibrator_02.Visible = true;
                _01_B21.is_ButonAgrega2Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg2Var_Yok)
            {
                _01_B21.Bunker_Vibrator_02.Visible = false;
                _01_B21.is_ButonAgrega2Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                _01_B21.XB19_Agrega2Nem.Visible = true;
                _01_B21.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg2Var_Yok)
            {
                _01_B21.XB19_Agrega2Nem.Visible = false;
                _01_B21.NemIcon.Visible = false;
            }
            //3----------------------------------------
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                _02_B31.Bunker_Vibrator_03.Visible = true;
                _02_B31.is_ButonAgrega3Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg3Var_Yok)
            {
                _02_B31.Bunker_Vibrator_03.Visible = false;
                _02_B31.is_ButonAgrega3Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                _02_B31.XB19_Agrega3Nem.Visible = true;
                _02_B31.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg3Var_Yok)
            {
                _02_B31.XB19_Agrega3Nem.Visible = false;
                _02_B31.NemIcon.Visible = false;
            }
            //4----------------------------------------
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                _03_B41.Bunker_Vibrator_04.Visible = true;
                _03_B41.is_ButonAgrega4Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg4Var_Yok)
            {
                _03_B41.Bunker_Vibrator_04.Visible = false;
                _03_B41.is_ButonAgrega4Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                _03_B41.XB19_Agrega4Nem.Visible = true;
                _03_B41.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg4Var_Yok)
            {
                _03_B41.XB19_Agrega4Nem.Visible = false;
                _03_B41.NemIcon.Visible = false;
            }
            //5----------------------------------------
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                _04_B51.Bunker_Vibrator_05.Visible = true;
                _04_B51.is_ButonAgrega5Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                _04_B51.Bunker_Vibrator_05.Visible = false;
                _04_B51.is_ButonAgrega5Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                _04_B51.XB19_Agrega5Nem.Visible = true;
                _04_B51.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                _04_B51.XB19_Agrega5Nem.Visible = false;
                _04_B51.NemIcon.Visible = false;
            }

            //6----------------------------------------
            if (Properties.S000_Konfigrator_Tag.Default.VibratorAg6Var_Yok)
            {
                _05_B61.Bunker_Vibrator_06.Visible = true;
                _05_B61.is_ButonAgrega6Vibrator.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.VibratorAg5Var_Yok)
            {
                _05_B61.Bunker_Vibrator_06.Visible = false;
                _05_B61.is_ButonAgrega6Vibrator.Visible = false;
            }
            if (Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                _05_B61.XB19_Agrega6Nem.Visible = true;
                _05_B61.NemIcon.Visible = true;
            }
            else if (!Properties.S000_Konfigrator_Tag.Default.NemolcerAg5Var_Yok)
            {
                _05_B61.XB19_Agrega6Nem.Visible = false;
                _05_B61.NemIcon.Visible = false;
            }


            //TartimKonveyor secimi

            if (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi > 0)
            {
                quickTartimKovasi2.Visible = false;
            }
        }
        public void Su_kantarsayacbelirleme()
        {

            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi == 1)
            {
                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false)
                {
                    Susayacboru1.Location = new Point(803, 303);
                    Sukantarboru2.Location = new Point(700, 301);
                    Susayacboru3.Location = new Point(803, 455);
                    Susayacboru4.Location = new Point(810, 599);
                    Susayacboru4.Size = new Size(75, 8);
                    Susayacboru5.Location = new Point(889, 599);
                    Susayacboru6.Location = new Point(693, 292);
                    Susayacboru7.Location = new Point(794, 301);
                    Susayacboru8.Location = new Point(803, 590);
                    Susayacboru9.Location = new Point(880, 599);

                    Susayacboru1.Visible = true;
                    Sukantarboru2.Visible = true;
                    Susayacboru3.Visible = true;
                    Susayacboru4.Visible = true;
                    Susayacboru5.Visible = true;
                    Susayacboru6.Visible = true;
                    Susayacboru7.Visible = true;
                    Susayacboru8.Visible = true;
                    Susayacboru9.Visible = true;

                    suKantar_Temp1.Visible = false;
                    Sukantarboru1.Visible = false;
                    Susayacboru2.Visible = false;
                    Sukantarboru5.Visible = false;
                    Sukantarboru6.Visible = false;
                    Sukantarboru7.Visible = false;
                    Sukantarboru8.Visible = false;
                    Sukantarboru9.Visible = false;
                    Sukantarboru10.Visible = false;
                    Sukantarboru11.Visible = false;

                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;


                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;

                    }
                   
                }

                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true)
                {


                    Sukantarboru1.Location = new Point(803, 308);
                    Sukantarboru2.Location = new Point(700, 301);

                    Sukantarboru5.Location = new Point(812, 585);
                    Sukantarboru6.Location = new Point(897, 585);
                    Sukantarboru7.Location = new Point(693, 292);
                    Sukantarboru8.Location = new Point(794, 301);
                    Sukantarboru9.Location = new Point(803, 576);
                    Sukantarboru10.Location = new Point(888, 585);

                    suKantar_Temp1.Visible = true;
                    Sukantarboru1.Visible = true;
                    Sukantarboru2.Visible = true;
                    Sukantarboru5.Visible = true;
                    Sukantarboru6.Visible = true;
                    Sukantarboru7.Visible = true;
                    Sukantarboru8.Visible = true;
                    Sukantarboru9.Visible = true;
                    Sukantarboru10.Visible = true;

                    Susayacboru1.Visible = false;
                    Susayacboru2.Visible = false;
                    Susayacboru3.Visible = false;
                    Susayacboru4.Visible = false;
                    Susayacboru5.Visible = false;
                    Susayacboru6.Visible = false;
                    Susayacboru7.Visible = false;
                    Susayacboru8.Visible = false;
                    Susayacboru9.Visible = false;
                    //Su lambası1 kantar için koşullar
                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;

                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                        Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;

                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_Gray;

                    }

                }


            }
            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi == 2)
            {
                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false ||
                Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false)

                {

                    //Su sayac için Location bilgileri
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false)
                    {
                        // Hep sayac seçilen durum
                        Susayacboru1.Location = new Point(803, 301);

                        Susayacboru3.Location = new Point(803, 463);
                        Susayacboru4.Location = new Point(810, 599);
                        Susayacboru4.Size = new Size(75, 8);
                        Susayacboru5.Location = new Point(889, 599);
                        Susayacboru6.Location = new Point(693, 292);
                        Susayacboru7.Location = new Point(794, 301);
                        Susayacboru8.Location = new Point(803, 590);
                        Susayacboru9.Location = new Point(880, 599);
                        //Su kantar için Location bilgisi
                        Sukantarboru2.Location = new Point(700, 301);

                        Sukantarboru2.Visible = true;
                        Susayacboru2.Visible = false;
                        Sukantarboru11.Visible = false;

                        suKantar_Temp1.Visible = false;
                        Sukantarboru1.Visible = false;

                        Sukantarboru5.Visible = false;
                        Sukantarboru6.Visible = false;
                        Sukantarboru7.Visible = false;
                        Sukantarboru8.Visible = false;
                        Sukantarboru9.Visible = false;
                        Sukantarboru10.Visible = false;


                    }
                    else
                    {
                        Susayacboru1.Location = new Point(693, 301);
                        Susayacboru2.Location = new Point(700, 463);
                        Susayacboru3.Location = new Point(764, 463);
                        Susayacboru4.Location = new Point(775, 599);
                        Susayacboru4.Size = new Size(103, 8);
                        Susayacboru5.Location = new Point(883, 599);
                        Susayacboru6.Location = new Point(693, 454);
                        Susayacboru7.Location = new Point(755, 463);
                        Susayacboru8.Location = new Point(764, 590);
                        Susayacboru9.Location = new Point(874, 599);

                        Susayacboru2.Visible = true;
                        Sukantarboru11.Visible = true;

                        suKantar_Temp1.Visible = true;
                        Sukantarboru1.Visible = true;
                        Sukantarboru2.Visible = true;
                        Sukantarboru5.Visible = true;
                        Sukantarboru6.Visible = true;
                        // Sukantarboru7.Visible = true;
                        Sukantarboru8.Visible = true;
                        Sukantarboru9.Visible = true;
                        Sukantarboru10.Visible = true;

                    }

                    //Su sayaç için kontrol bilgileri
                    Susayacboru1.Visible = true;
                    Susayacboru3.Visible = true;
                    Susayacboru4.Visible = true;

                    Susayacboru5.Visible = true;
                    Susayacboru6.Visible = true;
                    Susayacboru7.Visible = true;
                    Susayacboru8.Visible = true;
                    Susayacboru9.Visible = true;





                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true && Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true && Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                    }

                    if (!Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {

                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_gray;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                        Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_Gray;
                    }

                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false)
                    {

                        if (Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
                        {
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
                        {
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        }

                    }
                }
                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)
                {
                    //Su kantar için location bilgileri
                    Sukantarboru1.Location = new Point(803, 308);
                    Sukantarboru2.Location = new Point(700, 301);

                    Sukantarboru5.Location = new Point(812, 585);
                    Sukantarboru6.Location = new Point(897, 585);
                    Sukantarboru7.Location = new Point(693, 292);
                    Sukantarboru8.Location = new Point(794, 301);
                    Sukantarboru9.Location = new Point(803, 576);
                    Sukantarboru10.Location = new Point(888, 585);

                    //Su kantar için kontrol bilgileri
                    suKantar_Temp1.Visible = true;
                    Sukantarboru1.Visible = true;
                    Sukantarboru2.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)
                    {
                        Sukantarboru11.Visible = false;
                        Sukantarboru7.Visible = true;

                        Susayacboru1.Visible = false;
                        Susayacboru2.Visible = false;
                        Susayacboru3.Visible = false;
                        Susayacboru4.Visible = false;
                        Susayacboru5.Visible = false;
                        Susayacboru6.Visible = false;
                        Susayacboru7.Visible = false;
                        Susayacboru8.Visible = false;
                        Susayacboru9.Visible = false;
                    }
                    else
                    {
                        Sukantarboru7.Visible = false;
                        Sukantarboru11.Visible = true;

                        Susayacboru1.Location = new Point(693, 301);
                        Susayacboru2.Location = new Point(700, 463);
                        Susayacboru3.Location = new Point(764, 463);
                        Susayacboru4.Location = new Point(775, 599);
                        Susayacboru4.Size = new Size(103, 8);
                        Susayacboru5.Location = new Point(883, 599);
                        Susayacboru6.Location = new Point(693, 454);
                        Susayacboru7.Location = new Point(755, 463);
                        Susayacboru8.Location = new Point(764, 590);
                        Susayacboru9.Location = new Point(874, 599);
                        Susayacboru1.Visible = true;
                        Susayacboru2.Visible = true;
                        Susayacboru3.Visible = true;
                        Susayacboru4.Visible = true;

                        Susayacboru5.Visible = true;
                        Susayacboru6.Visible = true;
                        Susayacboru7.Visible = true;
                        Susayacboru8.Visible = true;
                        Susayacboru9.Visible = true;

                    }
                    Sukantarboru5.Visible = true;
                    Sukantarboru6.Visible = true;

                    Sukantarboru8.Visible = true;
                    Sukantarboru9.Visible = true;
                    Sukantarboru10.Visible = true;



                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {

                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true && Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true && Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;

                        }
                        if (Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                    }

                    if (!Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {

                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_gray;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                        Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_Gray;
                    }

                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)

                    {

                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                        }

                    }

                }


            }
            if (Properties.S000_Konfigrator_Tag.Default.SuSayisi == 3)
            {
                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false ||
                Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false ||
                Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == false)
                {
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false &&
                         Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false &&
                         Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == false)
                    {
                        // Hep sayac seçilen durum
                        Susayacboru1.Location = new Point(803, 301);

                        Susayacboru3.Location = new Point(803, 463);
                        Susayacboru4.Location = new Point(810, 599);
                        Susayacboru4.Size = new Size(75, 8);
                        Susayacboru5.Location = new Point(889, 599);
                        Susayacboru6.Location = new Point(693, 292);
                        Susayacboru7.Location = new Point(794, 301);
                        Susayacboru8.Location = new Point(803, 590);
                        Susayacboru9.Location = new Point(880, 599);
                        //Su kantar için Location bilgisi
                        Sukantarboru2.Location = new Point(700, 301);

                        Sukantarboru2.Visible = true;
                        Susayacboru2.Visible = false;
                        Sukantarboru11.Visible = false;

                        suKantar_Temp1.Visible = false;
                        Sukantarboru1.Visible = false;

                        Sukantarboru5.Visible = false;
                        Sukantarboru6.Visible = false;
                        Sukantarboru7.Visible = false;
                        Sukantarboru8.Visible = false;
                        Sukantarboru9.Visible = false;
                        Sukantarboru10.Visible = false;


                    }
                    else
                    {
                        Susayacboru1.Location = new Point(693, 301);
                        Susayacboru2.Location = new Point(700, 463);
                        Susayacboru3.Location = new Point(764, 463);
                        Susayacboru4.Location = new Point(775, 599);
                        Susayacboru4.Size = new Size(103, 8);
                        Susayacboru5.Location = new Point(883, 599);
                        Susayacboru6.Location = new Point(693, 454);
                        Susayacboru7.Location = new Point(755, 463);
                        Susayacboru8.Location = new Point(764, 590);
                        Susayacboru9.Location = new Point(874, 599);

                        Susayacboru2.Visible = true;
                        Sukantarboru11.Visible = true;

                        suKantar_Temp1.Visible = true;
                        Sukantarboru1.Visible = true;
                        Sukantarboru2.Visible = true;
                        Sukantarboru5.Visible = true;
                        Sukantarboru6.Visible = true;
                        // Sukantarboru7.Visible = true;
                        Sukantarboru8.Visible = true;
                        Sukantarboru9.Visible = true;
                        Sukantarboru10.Visible = true;

                    }

                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi || Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true && Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true && Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == true && Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;

                        }
                        if (Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                    }

                    if (!Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        
                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru3.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        
                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi && !Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {
                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_gray;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                        Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_Gray;
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == false)

                    {



                        Sukantarboru2.Visible = true;
                        Susayacboru2.Visible = false;
                        Sukantarboru11.Visible = false;
                        if (Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
                        {
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
                        {
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        }


                    }
                }
                if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true ||
                Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true ||
                Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == true
                )
                {
                    //Su kantar için location bilgileri
                    Sukantarboru1.Location = new Point(803, 308);
                    Sukantarboru2.Location = new Point(700, 301);

                    Sukantarboru5.Location = new Point(812, 585);
                    Sukantarboru6.Location = new Point(897, 585);
                    Sukantarboru7.Location = new Point(693, 292);
                    Sukantarboru8.Location = new Point(794, 301);
                    Sukantarboru9.Location = new Point(803, 576);
                    Sukantarboru10.Location = new Point(888, 585);

                    //Su kantar için kontrol bilgileri
                    suKantar_Temp1.Visible = true;
                    Sukantarboru1.Visible = true;
                    Sukantarboru2.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)
                    {
                        Sukantarboru11.Visible = false;
                        Sukantarboru7.Visible = true;

                        Susayacboru1.Visible = false;
                        Susayacboru2.Visible = false;
                        Susayacboru3.Visible = false;
                        Susayacboru4.Visible = false;
                        Susayacboru5.Visible = false;
                        Susayacboru6.Visible = false;
                        Susayacboru7.Visible = false;
                        Susayacboru8.Visible = false;
                        Susayacboru9.Visible = false;
                    }
                    else
                    {
                        Sukantarboru7.Visible = false;
                        Sukantarboru11.Visible = true;

                        Susayacboru1.Location = new Point(693, 301);
                        Susayacboru2.Location = new Point(700, 463);
                        Susayacboru3.Location = new Point(764, 463);
                        Susayacboru4.Location = new Point(775, 599);
                        Susayacboru4.Size = new Size(103, 8);
                        Susayacboru5.Location = new Point(883, 599);
                        Susayacboru6.Location = new Point(693, 454);
                        Susayacboru7.Location = new Point(755, 463);
                        Susayacboru8.Location = new Point(764, 590);
                        Susayacboru9.Location = new Point(874, 599);
                        Susayacboru1.Visible = true;
                        Susayacboru2.Visible = true;
                        Susayacboru3.Visible = true;
                        Susayacboru4.Visible = true;

                        Susayacboru5.Visible = true;
                        Susayacboru6.Visible = true;
                        Susayacboru7.Visible = true;
                        Susayacboru8.Visible = true;
                        Susayacboru9.Visible = true;

                    }
                    Sukantarboru5.Visible = true;
                    Sukantarboru6.Visible = true;

                    Sukantarboru8.Visible = true;
                    Sukantarboru9.Visible = true;
                    Sukantarboru10.Visible = true;


                    if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi || Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {

                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true && Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true && Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == true && Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                            Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }

                    }
                   
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                    {
                        Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                    }

                    if (!Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {
                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi)
                        {
                            Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                            Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                        }
                        Su_Button_Yerlesimi.Suboru3.Image = Properties.Resources.Pipe_Horizontal_Gray;

                    }
                    if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi && !Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                    {
                        Sukantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                        Sukantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                        //Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_gray;
                        Sukantarboru8.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                        Sukantarboru11.Image = Properties.Resources.Pipe_T_Sol_Gray;
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true &&
                       Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true &&
                       Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == true)

                    {

                        if (Properties.M012_Lambalar.Default.qs_Su1Lambasi || Properties.M012_Lambalar.Default.qs_Su2Lambasi || Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                        }
                        if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi && !Properties.M012_Lambalar.Default.qs_Su2Lambasi && !Properties.M012_Lambalar.Default.qs_Su3Lambasi)
                        {
                            Sukantarboru7.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                        }

                    }

                }

            }
            if (!Properties.M012_Lambalar.Default.qs_Su1Lambasi &&
                  !Properties.M012_Lambalar.Default.qs_Su2Lambasi &&
                  !Properties.M012_Lambalar.Default.qs_Su3Lambasi)
            {
                Su_Button_Yerlesimi.Suboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Su_Button_Yerlesimi.Suboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                Su_Button_Yerlesimi.Suboru1_2.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                Su_Button_Yerlesimi.Suboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Su_Button_Yerlesimi.Suboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                Su_Button_Yerlesimi.Suboru2_2.Image = Properties.Resources.Pipe_T_Sag_Gray;
                Su_Button_Yerlesimi.Suboru3.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Su_Button_Yerlesimi.Suboru3_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                Su_Button_Yerlesimi.Suboru3_2.Image = Properties.Resources.Pipe_T_Sag_Gray;

            }
            if (Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
            {
                Susayacboru1.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                Susayacboru2.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                Susayacboru3.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                Susayacboru4.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                Susayacboru5.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                Susayacboru6.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                Susayacboru7.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                Susayacboru8.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                Susayacboru9.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;



            }
            if (!Properties.M012_Lambalar.Default.qs_SuBosaltLambasi)
            {
                Susayacboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                Susayacboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Susayacboru3.Image = Properties.Resources.Pipe_Vertical_Gray;
                Susayacboru4.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Susayacboru5.Image = Properties.Resources.Pipe_Vertical_Gray;
                Susayacboru6.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                Susayacboru7.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                Susayacboru8.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                Susayacboru9.Image = Properties.Resources.Pipe_90_SagUst_Gray;


            }
            if (Properties.M012_Lambalar.Default.qs_SuBosaltLambasi) // değişecek
            {
                Sukantarboru5.Image = Properties.Resources.Pipe_Horizontal_DodgerBlue;
                Sukantarboru6.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;
                Sukantarboru9.Image = Properties.Resources.Pipe_90_SolAlt_DodgerBlue;
                Sukantarboru10.Image = Properties.Resources.Pipe_90_SagUst_DodgerBlue;
                suKantar_Temp1.Sukantarboru3.Image = Properties.Resources.Pipe_Vertical_DodgerBlue;

            }
            if (!Properties.M012_Lambalar.Default.qs_SuBosaltLambasi) // değişecek
            {
                Sukantarboru5.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Sukantarboru6.Image = Properties.Resources.Pipe_Vertical_Gray;
                Sukantarboru9.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                Sukantarboru10.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                suKantar_Temp1.Sukantarboru3.Image = Properties.Resources.Pipe_Vertical_Gray;



            }

        }
        public void Katki_kantarsayacbelirleme()
        {


            //İs_ButonKatkiYikama oluştuktan sonra yapılacak.
            if (Properties.M011_ButonLar.Default.is_ButonKatkiYikama)
            {
                katki_Temp1.Katkiboru11.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                katki_Temp1.Katkiboru12.Image = Properties.Resources.Pipe_Horizontal_DarkRed;

            }
            if (!Properties.M011_ButonLar.Default.is_ButonKatkiYikama)
            {
                katki_Temp1.Katkiboru11.Image = Properties.Resources.Pipe_Horizontal_Gray;
                katki_Temp1.Katkiboru12.Image = Properties.Resources.Pipe_Horizontal_Gray;

            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 1)
            {
                

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                {
                    katkiKantar_Temp1.Location = new Point(889, 294);
                    katkiKantar_Temp1.Visible = true;
                    Katkikantarboru2.Location = new Point(935, 608);
                    Katkikantarboru2.Visible = true;

                    Katkisayacboru2.Visible = false;
                    Katkisayacboru2.Size = new Size(8, 350);
                    Katkisayacboru3.Visible = false;
                    Katkisayacboru4.Visible = false;
                    Katkisayacboru5.Visible = false;
                    Katkisayacboru6.Visible = false;
                    Katkisayacboru7.Visible = false;
                    katki_Temp1.Katkisayacboru1.Visible = false;
                   
                    if (Properties.M012_Lambalar.Default.qs_KatkiBosaltLambasi)
                    {
                        Katkikantarboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    }
                    

                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                {
                    // Kantar seçilmediği durumda Sayaç boruları katkı kantarın bulunduğu kısma alınıyor.
                    Katkisayacboru2.Location = new Point(935, 282);
                    Katkisayacboru2.Size = new Size(8, 335);
                    Katkisayacboru4.Location = new Point(935, 611);

                    Katkisayacboru2.Visible = true;
                    Katkisayacboru3.Visible = false;
                    Katkisayacboru4.Visible = true;

                    katkiKantar_Temp1.Visible = false;
                    Katkikantarboru2.Visible = false;
                    Katkisayacboru3.Visible = false;
                    Katkisayacboru5.Visible = false;
                    Katkisayacboru6.Visible = false;
                    Katkisayacboru7.Visible = false;
                    katki_Temp1.Katkisayacboru1.Visible = false;

                    if (Properties.M012_Lambalar.Default.qs_KatkiBosaltLambasi)
                    {
                        Katkisayacboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                        Katkisayacboru3.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                        Katkisayacboru4.Image = Properties.Resources.Pipe_Vertical_DarkRed;

                    }
                }
                if (Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    
                   

                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_Gray;
              
                    
                }
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 2)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                {

                    katkiKantar_Temp1.Location = new Point(889, 294);
                    katkiKantar_Temp1.Visible = true;
                    Katkikantarboru2.Location = new Point(935, 608);
                    Katkikantarboru2.Visible = true;
                    
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                    {
                        Katkisayacboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru4.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru2.Size = new Size(8, 350);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }
                   
                    



                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                {



                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        katkiKantar_Temp1.Visible = false;
                        Katkikantarboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;

                        Katkisayacboru2.Location = new Point(935, 282);
                        Katkisayacboru2.Size = new Size(8, 335);
                        Katkisayacboru4.Location = new Point(935, 611);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru4.Visible = true;


                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);

                        katkiKantar_Temp1.Visible = true;
                        Katkikantarboru2.Visible = true;
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }


                }
                if (Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_Gray;

                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_Gray;
                }
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 3)
            {

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true)
                {

                    katkiKantar_Temp1.Location = new Point(889, 294);
                    katkiKantar_Temp1.Visible = true;
                    Katkikantarboru2.Location = new Point(935, 608);
                    Katkikantarboru2.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true)
                    {
                        Katkisayacboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru4.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru2.Size = new Size(8, 350);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }
                   
                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                {
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                    {
                        katkiKantar_Temp1.Visible = false;
                        Katkikantarboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;

                        Katkisayacboru2.Location = new Point(935, 282);
                        Katkisayacboru2.Size = new Size(8, 335);
                        Katkisayacboru4.Location = new Point(935, 611);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru4.Visible = true;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);

                        katkiKantar_Temp1.Visible = true;
                        Katkikantarboru2.Visible = true;
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }


                }
                if (Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_Gray;

                }
                if (Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki2Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_Gray;
                }
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 4)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true)
                {

                    katkiKantar_Temp1.Location = new Point(889, 294);
                    Katkikantarboru2.Location = new Point(935, 608);
                    katkiKantar_Temp1.Visible = true;
                    Katkikantarboru2.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true)
                    {
                        Katkisayacboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru4.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru2.Size = new Size(8, 350);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }
                    
                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                {
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                    {
                        katkiKantar_Temp1.Visible = false;
                        Katkikantarboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;

                        Katkisayacboru2.Location = new Point(935, 282);
                        Katkisayacboru2.Size = new Size(8, 335);
                        Katkisayacboru4.Location = new Point(935, 611);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru4.Visible = true;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);

                        katkiKantar_Temp1.Visible = true;
                        Katkikantarboru2.Visible = true;
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }



                }
                if (Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_Gray;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru7_2.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru7_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_DarkRed;

                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_Gray;

                }
                if (Properties.M012_Lambalar.Default.qs_Katki4Lambasi)
                {
                    katki_Temp1.Katkiboru4.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru8_1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki4Lambasi)
                {
                    katki_Temp1.Katkiboru4.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru8_1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki2Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki3Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki4Lambasi)

                {
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_Gray;
                }
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 5)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                {
                    katkiKantar_Temp1.Location = new Point(889, 294);
                    Katkikantarboru2.Location = new Point(935, 608);
                    katkiKantar_Temp1.Visible = true;
                    Katkikantarboru2.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true)
                    {
                        Katkisayacboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru4.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;
                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru2.Size = new Size(8, 350);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }
                    

                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)
                {
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)
                    {
                        katkiKantar_Temp1.Visible = false;
                        Katkikantarboru2.Visible = false;
                        Katkisayacboru3.Visible = false;
                        Katkisayacboru5.Visible = false;
                        Katkisayacboru6.Visible = false;
                        Katkisayacboru7.Visible = false;
                        katki_Temp1.Katkisayacboru1.Visible = false;

                        Katkisayacboru2.Location = new Point(935, 282);
                        Katkisayacboru2.Size = new Size(8, 335);
                        Katkisayacboru4.Location = new Point(935, 611);
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru4.Visible = true;

                    }
                    else
                    {
                        Katkisayacboru2.Location = new Point(994, 255);
                        Katkisayacboru3.Location = new Point(955, 610);
                        Katkisayacboru4.Location = new Point(948, 624);
                        Katkisayacboru5.Location = new Point(985, 245);
                        Katkisayacboru6.Location = new Point(985, 601);
                        Katkisayacboru7.Location = new Point(948, 610);

                        katkiKantar_Temp1.Visible = true;
                        Katkikantarboru2.Visible = true;
                        Katkisayacboru2.Visible = true;
                        Katkisayacboru3.Visible = true;
                        Katkisayacboru4.Visible = true;
                        Katkisayacboru5.Visible = true;
                        Katkisayacboru6.Visible = true;
                        Katkisayacboru7.Visible = true;
                        katki_Temp1.Katkisayacboru1.Visible = true;
                    }


                }
                if (Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi)
                {
                    katki_Temp1.Katkiboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru6.Image = Properties.Resources.Pipe_Horizontal_Gray;
                    katki_Temp1.Katkiboru7_1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru7_2.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki2Lambasi)
                {
                    katki_Temp1.Katkiboru2.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru7_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_DarkRed;

                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki3Lambasi)
                {
                    katki_Temp1.Katkiboru3.Image = Properties.Resources.Pipe_Vertical_Gray;

                }
                if (Properties.M012_Lambalar.Default.qs_Katki4Lambasi)
                {
                    katki_Temp1.Katkiboru4.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru8_2.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki4Lambasi)
                {
                    katki_Temp1.Katkiboru4.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru8_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (Properties.M012_Lambalar.Default.qs_Katki5Lambasi)
                {
                    katki_Temp1.Katkiboru5.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katki_Temp1.Katkiboru8_1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    katki_Temp1.Katkiboru9.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki5Lambasi)
                {
                    katki_Temp1.Katkiboru5.Image = Properties.Resources.Pipe_Vertical_Gray;
                    katki_Temp1.Katkiboru8_1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                    katki_Temp1.Katkiboru9.Image = Properties.Resources.Pipe_Horizontal_Gray;
                }
                if (!Properties.M012_Lambalar.Default.qs_Katki1Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki2Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki3Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki4Lambasi &&
                    !Properties.M012_Lambalar.Default.qs_Katki5Lambasi)

                {
                    katki_Temp1.Katkiboru10.Image = Properties.Resources.Pipe_Vertical_Gray;
                }
            }
            if (Properties.M012_Lambalar.Default.qs_KatkiBosaltLambasi)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                {

                    Katkikantarboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    katkiKantar_Temp1.Katkikantarboru1.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)
                {

                    Katkisayacboru2.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    Katkisayacboru3.Image = Properties.Resources.Pipe_Horizontal_DarkRed;
                    Katkisayacboru4.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                    Katkisayacboru5.Image = Properties.Resources.Pipe_90_SagUst_DarkRed;
                    Katkisayacboru6.Image = Properties.Resources.Pipe_90_Sagalt_DarkRed;
                    Katkisayacboru7.Image = Properties.Resources.Pipe_90_SolUst_DarkRed;
                    katki_Temp1.Katkisayacboru1.Image = Properties.Resources.Pipe_Horizontal_DarkRed;

                }

            }
            if (!Properties.M012_Lambalar.Default.qs_KatkiBosaltLambasi)
            {
                Katkikantarboru2.Image = Properties.Resources.Pipe_Vertical_Gray;
                Katkisayacboru2.Image = Properties.Resources.Pipe_Vertical_Gray;
                Katkisayacboru3.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Katkisayacboru4.Image = Properties.Resources.Pipe_Vertical_Gray;
                Katkisayacboru5.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                Katkisayacboru6.Image = Properties.Resources.Pipe_90_SagAlt_Gray;
                Katkisayacboru7.Image = Properties.Resources.Pipe_90_SolUst_Gray;
                katki_Temp1.Katkisayacboru1.Image = Properties.Resources.Pipe_Horizontal_Gray;
                katkiKantar_Temp1.Katkikantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;

            }
            //if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
            //        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
            //        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
            //        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
            //        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
            //{
                if ((Properties.M012_Lambalar.Default.qs_Katki1Lambasi && Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true) ||
                    (Properties.M012_Lambalar.Default.qs_Katki2Lambasi && Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true) ||
                    (Properties.M012_Lambalar.Default.qs_Katki3Lambasi && Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true) ||
                    (Properties.M012_Lambalar.Default.qs_Katki4Lambasi && Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true) ||
                    (Properties.M012_Lambalar.Default.qs_Katki5Lambasi && Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true))

                {
                    katki_Temp1.Katkiboru13.Image = Properties.Resources.Pipe_Vertical_DarkRed;
                }
                else katki_Temp1.Katkiboru13.Image = Properties.Resources.Pipe_Vertical_Gray;
            //}
            //else katki_Temp1.Katkiboru13.Image = Properties.Resources.Pipe_Vertical_Gray;





        }
        public void Katkilocationbilgileri()
        {
            //Katki kantar için location bilgileri
            katkiKantar_Temp1.Location = new Point(889, 294);
            Katkikantarboru2.Location = new Point(935, 608);
            //Katki sayac için location bilgileri
            Katkisayacboru2.Location = new Point(994, 290);
            Katkisayacboru3.Location = new Point(955, 610);
            Katkisayacboru4.Location = new Point(948, 624);
            Katkisayacboru5.Location = new Point(985, 245);
            Katkisayacboru6.Location = new Point(985, 601);
            Katkisayacboru7.Location = new Point(948, 610);
        }
        public void Cimento_Kantarbelirleme()
        {
            cimentoKantar_Temp1.Location = new Point(1049, 334);
            Cimentokantarboru1.Location = new Point(1104, 332);
            Cimentokantarboru2.Location = new Point(1111, 322);
            Cimentokantarboru3.Location = new Point(1170, 322);
            Cimentokantarboru4.Location = new Point(1180, 542);
            Cimentokantarboru6.Location = new Point(1105, 541);
            Cimentokantarboru7.Location = new Point(980, 622);
            Cimentokantarboru8.Location = new Point(980, 637);
            Cimentokantarboru9.Location = new Point(1104, 322);
            Cimentokantarboru10.Location = new Point(1161, 322);
            Cimentokantarboru11.Location = new Point(1170, 533);
            Cimentokantarboru12.Location = new Point(1096, 613);
            Cimentokantarboru13.Location = new Point(980, 622);

            if (Properties.M012_Lambalar.Default.qs_Cimento1Lambasi)
            {
                cimento_Temp1.cimentoboru1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru1_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru1_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru1_3.Image = Properties.Resources.Pipe_90_SolAlt_Gold;
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento1Lambasi)

            {
                cimento_Temp1.cimentoboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru1_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru1_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru1_3.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
            }
            if (Properties.M012_Lambalar.Default.qs_Cimento2Lambasi)
            {
                cimento_Temp1.cimentoboru2.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru2_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru2_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru2_3.Image = Properties.Resources.Pipe_90_Sagalt_Gold;
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento2Lambasi)

            {
                cimento_Temp1.cimentoboru2.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru2_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru2_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru2_3.Image = Properties.Resources.Pipe_90_SagAlt_Gray;
            }
            if (Properties.M012_Lambalar.Default.qs_Cimento3Lambasi)
            {
                cimento_Temp1.cimentoboru3.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru3_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru3_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru3_4.Image = Properties.Resources.Pipe_90_SolAlt_Gold;
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento3Lambasi)

            {
                cimento_Temp1.cimentoboru3.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru3_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru3_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru3_4.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
            }
            if (Properties.M012_Lambalar.Default.qs_Cimento4Lambasi)
            {
                cimento_Temp1.cimentoboru4.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru4_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru4_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru4_4.Image = Properties.Resources.Pipe_90_Sagalt_Gold;
                if (Properties.M012_Lambalar.Default.qs_Cimento6Lambasi)
                {
                    cimento_Temp1.cimentoboru4_3.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                }
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento4Lambasi)

            {
                cimento_Temp1.cimentoboru4.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru4_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru4_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru4_4.Image = Properties.Resources.Pipe_90_SagAlt_Gray;

                if (!Properties.M012_Lambalar.Default.qs_Cimento6Lambasi)
                {
                    cimento_Temp1.cimentoboru4_3.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                }
            }
            if (Properties.M012_Lambalar.Default.qs_Cimento5Lambasi)
            {
                cimento_Temp1.cimentoboru5.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru5_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru5_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru5_3.Image = Properties.Resources.Pipe_90_Sagalt_Gold;
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento5Lambasi)

            {
                cimento_Temp1.cimentoboru5.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru5_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru5_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru5_3.Image = Properties.Resources.Pipe_90_SagAlt_Gray;
            }
            if (Properties.M012_Lambalar.Default.qs_Cimento6Lambasi)
            {
                cimento_Temp1.cimentoboru6.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru6_1.Image = Properties.Resources.Pipe_Vertical_Gold;
                cimento_Temp1.cimentoboru6_2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                cimento_Temp1.cimentoboru6_3.Image = Properties.Resources.Pipe_90_Sagalt_Gold;
            }
            if (!Properties.M012_Lambalar.Default.qs_Cimento6Lambasi)

            {
                cimento_Temp1.cimentoboru6.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru6_1.Image = Properties.Resources.Pipe_Vertical_Gray;
                cimento_Temp1.cimentoboru6_2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                cimento_Temp1.cimentoboru6_3.Image = Properties.Resources.Pipe_90_SagAlt_Gray;
            }
            if (Properties.M012_Lambalar.Default.qs_CimentoBosaltLambasi)
            {
                Cimentokantarboru1.Image = Properties.Resources.Pipe_Vertical_Gold;
                Cimentokantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gold;
                Cimentokantarboru3.Image = Properties.Resources.Pipe_Vertical_Gold;
                Cimentokantarboru4.Image = Properties.Resources.Pipe_Horizontal_Gold;
                Cimentokantarboru6.Image = Properties.Resources.Pipe_Vertical_Gold;
                Cimentokantarboru7.Image = Properties.Resources.Pipe_Horizontal_Gold;
                Cimentokantarboru8.Image = Properties.Resources.Pipe_Vertical_Gold;
                Cimentokantarboru9.Image = Properties.Resources.Pipe_90_SolUst_Gold;
                Cimentokantarboru10.Image = Properties.Resources.Pipe_90_SagUst_Gold;
                Cimentokantarboru11.Image = Properties.Resources.Pipe_90_SolAlt_Gold;
                Cimentokantarboru12.Image = Properties.Resources.Pipe_90_Sagalt_Gold;
                Cimentokantarboru13.Image = Properties.Resources.Pipe_90_SolUst_Gold;
                cimentoKantar_Temp1.Cimentokantarboru5.Image = Properties.Resources.Pipe_Vertical_Gold;

            }
            if (!Properties.M012_Lambalar.Default.qs_CimentoBosaltLambasi)
            {
                Cimentokantarboru1.Image = Properties.Resources.Pipe_Vertical_Gray;
                Cimentokantarboru2.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Cimentokantarboru3.Image = Properties.Resources.Pipe_Vertical_Gray;
                Cimentokantarboru4.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Cimentokantarboru6.Image = Properties.Resources.Pipe_Vertical_Gray;
                Cimentokantarboru7.Image = Properties.Resources.Pipe_Horizontal_Gray;
                Cimentokantarboru8.Image = Properties.Resources.Pipe_Vertical_Gray;
                Cimentokantarboru9.Image = Properties.Resources.Pipe_90_SolUst_Gray;
                Cimentokantarboru10.Image = Properties.Resources.Pipe_90_SagUst_Gray;
                Cimentokantarboru11.Image = Properties.Resources.Pipe_90_SolAlt_Gray;
                Cimentokantarboru12.Image = Properties.Resources.Pipe_90_SagAlt_Gray;
                Cimentokantarboru13.Image = Properties.Resources.Pipe_90_SolUst_Gray;
                cimentoKantar_Temp1.Cimentokantarboru5.Image = Properties.Resources.Pipe_Vertical_Gray;

            }

        }
        public void Mikseregoreboruzunluklari()
        {
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 1)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                {
                    Susayacboru5.Size = new Size(8, 110);
                    Sukantarboru6.Size = new Size(8, 55);
                    Katkisayacboru4.Size = new Size(8, 85);
                    Katkikantarboru2.Size = new Size(8, 100);
                    Cimentokantarboru8.Size = new Size(8, 100);
                }
                else
                {
                    Susayacboru5.Size = new Size(8, 110);
                    Sukantarboru6.Size = new Size(8, 55);
                    Katkisayacboru4.Size = new Size(8, 95);
                    Katkikantarboru2.Size = new Size(8, 100);
                    Cimentokantarboru8.Size = new Size(8, 100);
                }



            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 2)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                {
                    Susayacboru5.Size = new Size(8, 57);
                    Sukantarboru6.Size = new Size(8, 74);
                    Katkikantarboru2.Size = new Size(8, 47);
                    Katkisayacboru4.Size = new Size(8, 33);
                    Cimentokantarboru8.Size = new Size(8, 24);
                }
                else
                {
                    Susayacboru5.Size = new Size(8, 57);
                    Sukantarboru6.Size = new Size(8, 74);
                    Katkikantarboru2.Size = new Size(8, 47);
                    Katkisayacboru4.Size = new Size(8, 43);
                    Cimentokantarboru8.Size = new Size(8, 24);
                }

            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenMixerTip == 3)
            {
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                {
                    Susayacboru5.Size = new Size(8, 47);
                    Sukantarboru6.Size = new Size(8, 64);
                    Katkikantarboru2.Size = new Size(8, 40);
                    Katkisayacboru4.Size = new Size(8, 25);
                    Cimentokantarboru8.Size = new Size(8, 12);
                }
                else
                {
                    Susayacboru5.Size = new Size(8, 47);
                    Sukantarboru6.Size = new Size(8, 64);
                    Katkikantarboru2.Size = new Size(8, 40);
                    Katkisayacboru4.Size = new Size(8, 35);
                    Cimentokantarboru8.Size = new Size(8, 12);
                }


            }
        }
        public void Santral_belirleme()
        {

            duzTartımKonveyor_Temp1.Visible = false;
            quickTartimKovasi2.Visible = false;
            QuickTransferKovası.Visible = false;
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenSantralModeli)
            {

                case 1:
                    {
                        if (Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim == true)
                        {
                            duzTartımKonveyor_Temp1.Visible = true;
                            QuickTransferKovası.Visible = true;

                        }
                        if (Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim == false)
                        {
                            duzTartımKonveyor_Temp1.Visible = false;
                            quickTartimKovasi2.Visible = true;
                            QuickTransferKovası.Visible = true;
                        }
                        break;
                    }
                case 2:
                    {
                        duzTartımKonveyor_Temp1.Visible = true;
                        break;
                    }

            }
        }
        private void duzTartımKonveyor_Temp1_Load(object sender, EventArgs e)
        {

        }

        private void _00_B11_Load(object sender, EventArgs e)
        {

        }
    }
}
