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
    public partial class Cimento_Temp : UserControl
    {
     
        public Cimento_Temp()
        {
           
            InitializeComponent();
        }
        public event EventHandler RunCimento;
        public string CimentoCalisButtonName;
        public bool butonState = false;

        protected void RunCimento_ButtonClick(object sender, EventArgs e)
        {
     

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        XX_Connection.ModbusConnection HetmodBusTool = XX_Connection.ModbusConnection.HetConnection();

        private void Cimento_Temp_Load(object sender, EventArgs e)
        {
            BelirlenenSiloSayisi();
        }
        public void BelirlenenSiloSayisi()
        {
            //soklama buton  için defult location bilgileri;
            is_ButonSoklama.Location = new Point(10, 290);
            qs_SoklamaLambasi.Location = new Point(10, 365);
         

            //Silo1 için defult location bilgileri;
            is_ButonFiltre1.Location = new Point(90, 0);
            Cimento1KritikBlink.Location = new Point(70, 80);
            StoktaBulunanCimento1.Location = new Point(95, 80);
            Silo1.Location = new Point(70, 70);
            XB3_Cimento1Istenen.Location = new Point(80, 190);
            XB3_Cimento1Verilen.Location = new Point(80, 220);
            qs_SoklamaLambasi1.Location = new Point(90, 250);
            is_ButonCimento1.Location = new Point(90, 390);
            //Silo2 için defult location bilgileri;
            is_ButonFiltre2.Location = new Point(200, 0);
            Cimento2KritikBlink.Location = new Point(180, 80);
            StoktaBulunanCimento2.Location = new Point(205, 80);
            Silo2.Location = new Point(180, 70);
            XB3_Cimento2Istenen.Location = new Point(190, 190);
            XB3_Cimento2Verilen.Location = new Point(190, 220);
            qs_SoklamaLambasi2.Location = new Point(200, 250);
            is_ButonCimento2.Location = new Point(200, 390);
            //Silo3 için defult location bilgileri;
            is_ButonFiltre3.Location = new Point(310, 0);
            Cimento3KritikBlink.Location = new Point(290, 80);
            StoktaBulunanCimento3.Location = new Point(315, 80);
            Silo3.Location = new Point(290, 70);
            XB3_Cimento3Istenen.Location = new Point(300, 190);
            XB3_Cimento3Verilen.Location = new Point(300, 220);
            qs_SoklamaLambasi3.Location = new Point(310, 250);
            is_ButonCimento3.Location = new Point(310, 390);
            //Silo4 için defult location bilgileri;
            is_ButonFiltre4.Location = new Point(420, 0);
            Cimento4KritikBlink.Location = new Point(400, 80);
            StoktaBulunanCimento4.Location = new Point(425, 80);
            Silo4.Location = new Point(400, 70);
            XB3_Cimento4Istenen.Location = new Point(410, 190);
            XB3_Cimento4Verilen.Location = new Point(410, 220);
            qs_SoklamaLambasi4.Location = new Point(420, 250);
            is_ButonCimento4.Location = new Point(420, 390);
            //Silo5 için defult location bilgileri;
            is_ButonFiltre5.Location = new Point(530, 0);
            Cimento5KritikBlink.Location = new Point(510, 80);
            StoktaBulunanCimento5.Location = new Point(535, 80);
            Silo5.Location = new Point(510, 70);
            XB3_Cimento5Istenen.Location = new Point(520, 190);
            XB3_Cimento5Verilen.Location = new Point(520, 220);
            qs_SoklamaLambasi5.Location = new Point(530, 250);
            is_ButonCimento5.Location = new Point(530, 390);
            //Silo6 için defult location bilgileri;
            is_ButonFiltre6.Location = new Point(640, 0);
            Cimento6KritikBlink.Location = new Point(620, 80);
            StoktaBulunanCimento6.Location = new Point(645, 80);
            Silo6.Location = new Point(620, 70);
            XB3_Cimento6Istenen.Location = new Point(630, 190);
            XB3_Cimento6Verilen.Location = new Point(630, 220);
            qs_SoklamaLambasi6.Location = new Point(640, 250);
            is_ButonCimento6.Location = new Point(640, 390);


            //Çimento borular için location bilgileri
            //Çimentoboru1 için location bilgileri
            cimentoboru1.Location = new Point(120, 335);
            cimentoboru1_1.Location = new Point(120, 451);
            cimentoboru1_2.Location = new Point(128, 500);
            cimentoboru1_3.Location = new Point(120, 491);

            //Çimentoboru2 için location bilgileri
            cimentoboru2.Location = new Point(230, 335);
            cimentoboru2_1.Location = new Point(230, 451);
            cimentoboru2_2.Location = new Point(159, 500);
            cimentoboru2_3.Location = new Point(221, 491);

            //Çimentoboru3 için location bilgileri
            cimentoboru3.Location = new Point(340, 335);
            cimentoboru3_1.Location = new Point(340, 451);
            cimentoboru3_2.Location = new Point(276, 500);
            cimentoboru3_3.Location = new Point(331, 491);
            cimentoboru3_4.Location = new Point(340, 491);

            //Çimentoboru4 için location bilgileri
            cimentoboru4.Location = new Point(450, 335);
            cimentoboru4_1.Location = new Point(450, 451);
            cimentoboru4_2.Location = new Point(458, 500);
            cimentoboru4_3.Location = new Point(450, 491);
            cimentoboru4_4.Location = new Point(441, 491);

            //Çimentoboru5 için location bilgileri
            cimentoboru5.Location = new Point(560, 335);
            cimentoboru5_1.Location = new Point(560, 451);
            cimentoboru5_2.Location = new Point(472, 500);
            cimentoboru5_3.Location = new Point(573, 491);



            //Çimentoboru6 için location bilgileri
            cimentoboru6.Location = new Point(670, 335);
            cimentoboru6_1.Location = new Point(670, 451);
            cimentoboru6_2.Location = new Point(560, 500);
            cimentoboru6_3.Location = new Point(661, 491);


            //soklama buton  içinvisible

            is_ButonSoklama.Visible = false;
            qs_SoklamaLambasi.Visible = false; // Borular yerleştikten sonra false olucak.


        
            //Silo1 visible Kontrol
            is_ButonFiltre1.Visible = false;
            Cimento1KritikBlink.Visible = false;
            StoktaBulunanCimento1.Visible = false;
            Silo1.Visible = false;
            XB3_Cimento1Istenen.Visible = false;
            XB3_Cimento1Verilen.Visible = false;
            qs_SoklamaLambasi1.Visible = false;
            is_ButonCimento1.Visible = false;

            //Silo2 visible Kontrol
            is_ButonFiltre2.Visible = false;
            Cimento2KritikBlink.Visible = false;
            StoktaBulunanCimento2.Visible = false;
            Silo2.Visible = false;
            XB3_Cimento2Istenen.Visible = false;
            XB3_Cimento2Verilen.Visible = false;
            qs_SoklamaLambasi2.Visible = false;
            is_ButonCimento2.Visible = false;

            //Silo3 visible Kontrol
            is_ButonFiltre3.Visible = false;
            Cimento3KritikBlink.Visible = false;
            StoktaBulunanCimento3.Visible = false;
            Silo3.Visible = false;
            XB3_Cimento3Istenen.Visible = false;
            XB3_Cimento3Verilen.Visible = false;
            qs_SoklamaLambasi3.Visible = false;
            is_ButonCimento3.Visible = false;

            //Silo4 visible Kontrol
            is_ButonFiltre4.Visible = false;
            Cimento4KritikBlink.Visible = false;
            StoktaBulunanCimento4.Visible = false;
            Silo4.Visible = false;
            XB3_Cimento4Istenen.Visible = false;
            XB3_Cimento4Verilen.Visible = false;
            qs_SoklamaLambasi4.Visible = false;
            is_ButonCimento4.Visible = false;

            //Silo5 visible Kontrol
            is_ButonFiltre5.Visible = false;
            Cimento5KritikBlink.Visible = false;
            StoktaBulunanCimento5.Visible = false;
            Silo5.Visible = false;
            XB3_Cimento5Istenen.Visible = false;
            XB3_Cimento5Verilen.Visible = false;
            qs_SoklamaLambasi5.Visible = false;
            is_ButonCimento5.Visible = false;

            //Silo6 visible Kontrol
            is_ButonFiltre6.Visible = false;
            Cimento6KritikBlink.Visible = false;
            StoktaBulunanCimento6.Visible = false;
            Silo6.Visible = false;
            XB3_Cimento6Istenen.Visible = false;
            XB3_Cimento6Verilen.Visible = false;
            qs_SoklamaLambasi6.Visible = false;
            is_ButonCimento6.Visible = false;

            //Cimentoboru1 visible Kontrol
            cimentoboru1.Visible = false;
            cimentoboru1_1.Visible = false;
            cimentoboru1_2.Visible = false;
            cimentoboru1_3.Visible = false;

            //Cimentoboru2 visible Kontrol
            cimentoboru2.Visible = false;
            cimentoboru2_1.Visible = false;
            cimentoboru2_3.Visible = false;
            cimentoboru2_2.Visible = false;


            //Cimentoboru3 visible Kontrol
            cimentoboru3.Visible = false;
            cimentoboru3_1.Visible = false;
            cimentoboru3_2.Visible = false;
            cimentoboru3_3.Visible = false;
            cimentoboru3_4.Visible = false;


            //Cimentoboru4 visible Kontrol
            cimentoboru4.Visible = false;
            cimentoboru4_1.Visible = false;
            cimentoboru4_2.Visible = false;
            cimentoboru4_3.Visible = false;
            cimentoboru4_4.Visible = false;

            //Cimentoboru5 visible Kontrol
            cimentoboru5.Visible = false;
            cimentoboru5_1.Visible = false;
            cimentoboru5_2.Visible = false;
            cimentoboru5_3.Visible = false;


            //Cimentoboru6 visible Kontrol
            cimentoboru6.Visible = false;
            cimentoboru6_1.Visible = false;
            cimentoboru6_2.Visible = false;
            cimentoboru6_3.Visible = false;



            int siloKaydir1Secim = 82;
            int siloKaydir2Secim = 192;
            int siloKaydir3Secim = 366;
            int siloKaydir4Secim = 477;
            int siloKaydir5Secim = 502;
            // Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 6;
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 1)
            {
               
                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10 + siloKaydir1Secim, 290);
                qs_SoklamaLambasi.Location = new Point(10 + siloKaydir1Secim, 365);

                is_ButonFiltre1.Location = new Point(90 + siloKaydir1Secim, 0);
                Cimento1KritikBlink.Location = new Point(70 + siloKaydir1Secim, 80);
                StoktaBulunanCimento1.Location = new Point(95 + siloKaydir1Secim, 80);
                Silo1.Location = new Point(70 + siloKaydir1Secim, 70);
                XB3_Cimento1Istenen.Location = new Point(80 + siloKaydir1Secim, 190);
                XB3_Cimento1Verilen.Location = new Point(80 + siloKaydir1Secim, 220);
                qs_SoklamaLambasi1.Location = new Point(90 + siloKaydir1Secim, 250);
                is_ButonCimento1.Location = new Point(90 + siloKaydir1Secim, 390);
            
                // Çimentoboru1 için location bilgileri
                cimentoboru1.Location = new Point(120 + siloKaydir1Secim, 335);
                cimentoboru1_1.Location = new Point(120 + siloKaydir1Secim, 451);
                cimentoboru1_2.Location = new Point(128 + siloKaydir1Secim, 500);
                cimentoboru1_2.Size = new Size(35, 8);
                cimentoboru1_3.Location = new Point(120 + siloKaydir1Secim, 491);


                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;
            
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 2)
            {
                
                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10 + siloKaydir1Secim, 290);
                qs_SoklamaLambasi.Location = new Point(10 + siloKaydir1Secim, 365);
          

                is_ButonFiltre1.Location = new Point(90 + siloKaydir1Secim, 0);
                Cimento1KritikBlink.Location = new Point(70 + siloKaydir1Secim, 80);
                StoktaBulunanCimento1.Location = new Point(95 + siloKaydir1Secim, 80);
                Silo1.Location = new Point(70 + siloKaydir1Secim, 70);
                XB3_Cimento1Istenen.Location = new Point(80 + siloKaydir1Secim, 190);
                XB3_Cimento1Verilen.Location = new Point(80 + siloKaydir1Secim, 220);
                qs_SoklamaLambasi1.Location = new Point(90 + siloKaydir1Secim, 250);
                is_ButonCimento1.Location = new Point(90 + siloKaydir1Secim, 390);

                is_ButonFiltre2.Location = new Point(90 + siloKaydir2Secim, 0);
                Cimento2KritikBlink.Location = new Point(70 + siloKaydir2Secim , 80);
                StoktaBulunanCimento2.Location = new Point(95 + siloKaydir2Secim , 80);
                Silo2.Location = new Point(70 + siloKaydir2Secim, 70);
                XB3_Cimento2Istenen.Location = new Point(80 + siloKaydir2Secim, 190);
                XB3_Cimento2Verilen.Location = new Point(80 + siloKaydir2Secim, 220);
                qs_SoklamaLambasi2.Location = new Point(90 + siloKaydir2Secim, 250);
                is_ButonCimento2.Location = new Point(90 + siloKaydir2Secim, 390);

                // Çimentoboru1 için location bilgileri
                cimentoboru1.Location = new Point(120 + siloKaydir1Secim, 335);
                cimentoboru1_1.Location = new Point(120 + siloKaydir1Secim, 451);
                cimentoboru1_2.Location = new Point(128 + siloKaydir1Secim, 500);
                cimentoboru1_2.Size = new Size(35, 8);
                cimentoboru1_3.Location = new Point(120 + siloKaydir1Secim, 491);

                //Çimentoboru2 için location bilgileri
                cimentoboru2.Location = new Point(120+siloKaydir2Secim, 335);
                cimentoboru2_1.Location = new Point(120 + siloKaydir2Secim, 451);
                cimentoboru2_2.Location = new Point(83 + siloKaydir2Secim, 500);
                cimentoboru2_2.Size = new Size(30, 8);
                cimentoboru2_3.Location = new Point(111 + siloKaydir2Secim, 491);

                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;

                //Silo1 visible Kontrol
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Silo2 visible Kontrol
                is_ButonFiltre2.Visible = true;
                Cimento2KritikBlink.Visible = true;
                StoktaBulunanCimento2.Visible = true;
                Silo2.Visible = true;
                XB3_Cimento2Istenen.Visible = true;
                XB3_Cimento2Verilen.Visible = true;
                qs_SoklamaLambasi2.Visible = true;
                is_ButonCimento2.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

                //Cimentoboru2 visible Kontrol
                cimentoboru2.Visible = true;
                cimentoboru2_1.Visible = true;
                cimentoboru2_3.Visible = true;
                cimentoboru2_2.Visible = true;



            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 3)
            {

                
                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10 + siloKaydir1Secim, 290);
                qs_SoklamaLambasi.Location = new Point(10 + siloKaydir1Secim, 365);


                is_ButonFiltre1.Location = new Point(90 + siloKaydir1Secim, 0);
                Cimento1KritikBlink.Location = new Point(70 + siloKaydir1Secim, 80);
                StoktaBulunanCimento1.Location = new Point(95 + siloKaydir1Secim, 80);
                Silo1.Location = new Point(70 + siloKaydir1Secim, 70);
                XB3_Cimento1Istenen.Location = new Point(80 + siloKaydir1Secim, 190);
                XB3_Cimento1Verilen.Location = new Point(80 + siloKaydir1Secim, 220);
                qs_SoklamaLambasi1.Location = new Point(90 + siloKaydir1Secim, 250);
                is_ButonCimento1.Location = new Point(90 + siloKaydir1Secim, 390);

                is_ButonFiltre2.Location = new Point(90 + siloKaydir2Secim, 0);
                Cimento2KritikBlink.Location = new Point(70 + siloKaydir2Secim, 80);
                StoktaBulunanCimento2.Location = new Point(95 + siloKaydir2Secim, 80);
                Silo2.Location = new Point(70 + siloKaydir2Secim, 70);
                XB3_Cimento2Istenen.Location = new Point(80 + siloKaydir2Secim, 190);
                XB3_Cimento2Verilen.Location = new Point(80 + siloKaydir2Secim, 220);
                qs_SoklamaLambasi2.Location = new Point(90 + siloKaydir2Secim, 250);
                is_ButonCimento2.Location = new Point(90 + siloKaydir2Secim, 390);

                is_ButonFiltre3.Location = new Point(90 + siloKaydir3Secim, 0);
                Cimento3KritikBlink.Location = new Point(70 + siloKaydir3Secim, 80);
                StoktaBulunanCimento3.Location = new Point(95 + siloKaydir3Secim, 80);
                Silo3.Location = new Point(70 + siloKaydir3Secim, 70);
                XB3_Cimento3Istenen.Location = new Point(80 + siloKaydir3Secim, 190);
                XB3_Cimento3Verilen.Location = new Point(80 + siloKaydir3Secim, 220);
                qs_SoklamaLambasi3.Location = new Point(90 + siloKaydir3Secim, 250);
                is_ButonCimento3.Location = new Point(90 + siloKaydir3Secim, 390);


                // Çimentoboru1 için location bilgileri
                cimentoboru1.Location = new Point(120 + siloKaydir1Secim, 335);
                cimentoboru1_1.Location = new Point(120 + siloKaydir1Secim, 451);
                cimentoboru1_2.Location = new Point(128 + siloKaydir1Secim, 500);
                cimentoboru1_2.Size = new Size(35, 8);
                cimentoboru1_3.Location = new Point(120 + siloKaydir1Secim, 491);

                //Çimentoboru2 için location bilgileri
                cimentoboru2.Location = new Point(120 + siloKaydir2Secim, 335);
                cimentoboru2_1.Location = new Point(120 + siloKaydir2Secim, 451);
                cimentoboru2_2.Location = new Point(83 + siloKaydir2Secim, 500);
                cimentoboru2_2.Size = new Size(30, 8);
                cimentoboru2_3.Location = new Point(111 + siloKaydir2Secim, 491);


                //Çimentoboru3 için location bilgileri
                cimentoboru3.Location = new Point(120 + siloKaydir3Secim, 335);
                cimentoboru3_1.Location = new Point(120 + siloKaydir3Secim, 451);
                cimentoboru3_1.Size = new Size(8, 47);
                cimentoboru3_2.Location = new Point(128 + siloKaydir3Secim, 500);
                cimentoboru3_2.Size = new Size(35, 8);
                cimentoboru3_4.Location = new Point(120 + siloKaydir3Secim, 491);

                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;

                //Silo1 visible Kontrol
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Silo2 visible Kontrol
                is_ButonFiltre2.Visible = true;
                Cimento2KritikBlink.Visible = true;
                StoktaBulunanCimento2.Visible = true;
                Silo2.Visible = true;
                XB3_Cimento2Istenen.Visible = true;
                XB3_Cimento2Verilen.Visible = true;
                qs_SoklamaLambasi2.Visible = true;
                is_ButonCimento2.Visible = true;

                //Silo3 visible Kontrol
                is_ButonFiltre3.Visible = true;
                Cimento3KritikBlink.Visible = true;
                StoktaBulunanCimento3.Visible = true;
                Silo3.Visible = true;
                XB3_Cimento3Istenen.Visible = true;
                XB3_Cimento3Verilen.Visible = true;
                qs_SoklamaLambasi3.Visible = true;
                is_ButonCimento3.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

                //Cimentoboru2 visible Kontrol
                cimentoboru2.Visible = true;
                cimentoboru2_1.Visible = true;
                cimentoboru2_2.Visible = true;
                cimentoboru2_3.Visible = true;


                //Cimentoboru3 visible Kontrol
                cimentoboru3.Visible = true;
                cimentoboru3_1.Visible = true;
                cimentoboru3_2.Visible = true;
                cimentoboru3_4.Visible = true;
            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 4)
            {

                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10 + siloKaydir1Secim, 290);
                qs_SoklamaLambasi.Location = new Point(10 + siloKaydir1Secim, 365);


                is_ButonFiltre1.Location = new Point(90 + siloKaydir1Secim, 0);
                Cimento1KritikBlink.Location = new Point(70 + siloKaydir1Secim, 80);
                StoktaBulunanCimento1.Location = new Point(95 + siloKaydir1Secim, 80);
                Silo1.Location = new Point(70 + siloKaydir1Secim, 70);
                XB3_Cimento1Istenen.Location = new Point(80 + siloKaydir1Secim, 190);
                XB3_Cimento1Verilen.Location = new Point(80 + siloKaydir1Secim, 220);
                qs_SoklamaLambasi1.Location = new Point(90 + siloKaydir1Secim, 250);
                is_ButonCimento1.Location = new Point(90 + siloKaydir1Secim, 390);

                is_ButonFiltre2.Location = new Point(90 + siloKaydir2Secim, 0);
                Cimento2KritikBlink.Location = new Point(70 + siloKaydir2Secim, 80);
                StoktaBulunanCimento2.Location = new Point(95 + siloKaydir2Secim, 80);
                Silo2.Location = new Point(70 + siloKaydir2Secim, 70);
                XB3_Cimento2Istenen.Location = new Point(80 + siloKaydir2Secim, 190);
                XB3_Cimento2Verilen.Location = new Point(80 + siloKaydir2Secim, 220);
                qs_SoklamaLambasi2.Location = new Point(90 + siloKaydir2Secim, 250);
                is_ButonCimento2.Location = new Point(90 + siloKaydir2Secim, 390);

                is_ButonFiltre3.Location = new Point(90 + siloKaydir3Secim, 0);
                Cimento3KritikBlink.Location = new Point(70 + siloKaydir3Secim, 80);
                StoktaBulunanCimento3.Location = new Point(95 + siloKaydir3Secim, 80);
                Silo3.Location = new Point(70 + siloKaydir3Secim, 70);
                XB3_Cimento3Istenen.Location = new Point(80 + siloKaydir3Secim, 190);
                XB3_Cimento3Verilen.Location = new Point(80 + siloKaydir3Secim, 220);
                qs_SoklamaLambasi3.Location = new Point(90 + siloKaydir3Secim, 250);
                is_ButonCimento3.Location = new Point(90 + siloKaydir3Secim, 390);

                is_ButonFiltre4.Location = new Point(90 + siloKaydir4Secim, 0);
                Cimento4KritikBlink.Location = new Point(70 + siloKaydir4Secim, 80);
                StoktaBulunanCimento4.Location = new Point(95 + siloKaydir4Secim, 80);
                Silo4.Location = new Point(70 + siloKaydir4Secim, 70);
                XB3_Cimento4Istenen.Location = new Point(80 + siloKaydir4Secim, 190);
                XB3_Cimento4Verilen.Location = new Point(80 + siloKaydir4Secim, 220);
                qs_SoklamaLambasi4.Location = new Point(90 + siloKaydir4Secim, 250);
                is_ButonCimento4.Location = new Point(90 + siloKaydir4Secim, 390);

                // Çimentoboru1 için location bilgileri
                cimentoboru1.Location = new Point(120 + siloKaydir1Secim, 335);
                cimentoboru1_1.Location = new Point(120 + siloKaydir1Secim, 451);
                cimentoboru1_2.Location = new Point(128 + siloKaydir1Secim, 500);
                cimentoboru1_2.Size = new Size(35, 8);
                cimentoboru1_3.Location = new Point(120 + siloKaydir1Secim, 491);

                //Çimentoboru2 için location bilgileri
                cimentoboru2.Location = new Point(120 + siloKaydir2Secim, 335);
                cimentoboru2_1.Location = new Point(120 + siloKaydir2Secim, 451);
                cimentoboru2_2.Location = new Point(83 + siloKaydir2Secim, 500);
                cimentoboru2_2.Size = new Size(30, 8);
                cimentoboru2_3.Location = new Point(111 + siloKaydir2Secim, 491);


                //Çimentoboru3 için location bilgileri
                cimentoboru3.Location = new Point(120 + siloKaydir3Secim, 335);
                cimentoboru3_1.Location = new Point(120 + siloKaydir3Secim, 451);
                cimentoboru3_1.Size = new Size(8, 47);
                cimentoboru3_2.Location = new Point(128 + siloKaydir3Secim, 500);
                cimentoboru3_2.Size = new Size(35, 8);
                cimentoboru3_4.Location = new Point(120 + siloKaydir3Secim, 491);

                //Çimentoboru4 için location bilgileri
                cimentoboru4.Location = new Point(120 + siloKaydir4Secim, 335);
                cimentoboru4_1.Location = new Point(120 + siloKaydir4Secim, 451);
                cimentoboru4_2.Location = new Point(83 + siloKaydir4Secim, 500);
                cimentoboru4_2.Size = new Size(30, 8);
                cimentoboru4_4.Location = new Point(111 + siloKaydir4Secim, 491);

                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;

                //Silo1 visible Kontrol
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Silo2 visible Kontrol
                is_ButonFiltre2.Visible = true;
                Cimento2KritikBlink.Visible = true;
                StoktaBulunanCimento2.Visible = true;
                Silo2.Visible = true;
                XB3_Cimento2Istenen.Visible = true;
                XB3_Cimento2Verilen.Visible = true;
                qs_SoklamaLambasi2.Visible = true;
                is_ButonCimento2.Visible = true;

                //Silo3 visible Kontrol
                is_ButonFiltre3.Visible = true;
                Cimento3KritikBlink.Visible = true;
                StoktaBulunanCimento3.Visible = true;
                Silo3.Visible = true;
                XB3_Cimento3Istenen.Visible = true;
                XB3_Cimento3Verilen.Visible = true;
                qs_SoklamaLambasi3.Visible = true;
                is_ButonCimento3.Visible = true;

                //Silo4 visible Kontrol
                is_ButonFiltre4.Visible = true;
                Cimento4KritikBlink.Visible = true;
                StoktaBulunanCimento4.Visible = true;
                Silo4.Visible = true;
                XB3_Cimento4Istenen.Visible = true;
                XB3_Cimento4Verilen.Visible = true;
                qs_SoklamaLambasi4.Visible = true;
                is_ButonCimento4.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

                //Cimentoboru2 visible Kontrol
                cimentoboru2.Visible = true;
                cimentoboru2_1.Visible = true;
                cimentoboru2_2.Visible = true;
                cimentoboru2_3.Visible = true;


                //Cimentoboru3 visible Kontrol
                cimentoboru3.Visible = true;
                cimentoboru3_1.Visible = true;
                cimentoboru3_2.Visible = true;
                cimentoboru3_4.Visible = true;

                //Cimentoboru4 visible Kontrol
                cimentoboru4.Visible = true;
                cimentoboru4_1.Visible = true;
                cimentoboru4_2.Visible = true;
                cimentoboru4_4.Visible = true;
            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 5)
            {
                int Cikar = 85; // 3 ve 4. çimentoları 1 ve 2'ye yaklaştırmak için yazdım.
                int Cikariki = 20; // 1 ve 2. cimentoları sola kaydırmak için yapıldı

                //soklama buton  için defult location bilgileri;
                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10 + siloKaydir1Secim - Cikariki, 290);
                qs_SoklamaLambasi.Location = new Point(10 + siloKaydir1Secim - Cikariki, 365);


                is_ButonFiltre1.Location = new Point(90 + siloKaydir1Secim-Cikariki, 0);
                Cimento1KritikBlink.Location = new Point(70 + siloKaydir1Secim - Cikariki, 80);
                StoktaBulunanCimento1.Location = new Point(95 + siloKaydir1Secim - Cikariki, 80);
                Silo1.Location = new Point(70 + siloKaydir1Secim - Cikariki, 70);
                XB3_Cimento1Istenen.Location = new Point(80 + siloKaydir1Secim - Cikariki, 190);
                XB3_Cimento1Verilen.Location = new Point(80 + siloKaydir1Secim - Cikariki, 220);
                qs_SoklamaLambasi1.Location = new Point(90 + siloKaydir1Secim - Cikariki, 250);
                is_ButonCimento1.Location = new Point(90 + siloKaydir1Secim - Cikariki, 390);

                is_ButonFiltre2.Location = new Point(90 + siloKaydir2Secim - Cikariki, 0);
                Cimento2KritikBlink.Location = new Point(70 + siloKaydir2Secim - Cikariki, 80);
                StoktaBulunanCimento2.Location = new Point(95 + siloKaydir2Secim - Cikariki, 80);
                Silo2.Location = new Point(70 + siloKaydir2Secim - Cikariki, 70);
                XB3_Cimento2Istenen.Location = new Point(80 + siloKaydir2Secim - Cikariki, 190);
                XB3_Cimento2Verilen.Location = new Point(80 + siloKaydir2Secim - Cikariki, 220);
                qs_SoklamaLambasi2.Location = new Point(90 + siloKaydir2Secim - Cikariki, 250);
                is_ButonCimento2.Location = new Point(90 + siloKaydir2Secim - Cikariki, 390);

                is_ButonFiltre3.Location = new Point(90 + siloKaydir3Secim - Cikar, 0);
                Cimento3KritikBlink.Location = new Point(70 + siloKaydir3Secim - Cikar, 80);
                StoktaBulunanCimento3.Location = new Point(95 + siloKaydir3Secim - Cikar, 80);
                Silo3.Location = new Point(70 + siloKaydir3Secim - Cikar, 70);
                XB3_Cimento3Istenen.Location = new Point(80 + siloKaydir3Secim - Cikar, 190);
                XB3_Cimento3Verilen.Location = new Point(80 + siloKaydir3Secim - Cikar, 220);
                qs_SoklamaLambasi3.Location = new Point(90 + siloKaydir3Secim - Cikar, 250);
                is_ButonCimento3.Location = new Point(90 + siloKaydir3Secim - Cikar, 390);

                is_ButonFiltre4.Location = new Point(90 + siloKaydir4Secim - Cikar, 0);
                Cimento4KritikBlink.Location = new Point(70 + siloKaydir4Secim - Cikar, 80);
                StoktaBulunanCimento4.Location = new Point(95 + siloKaydir4Secim - Cikar, 80);
                Silo4.Location = new Point(70 + siloKaydir4Secim - Cikar, 70);
                XB3_Cimento4Istenen.Location = new Point(80 + siloKaydir4Secim - Cikar, 190);
                XB3_Cimento4Verilen.Location = new Point(80 + siloKaydir4Secim - Cikar, 220);
                qs_SoklamaLambasi4.Location = new Point(90 + siloKaydir4Secim - Cikar, 250);
                is_ButonCimento4.Location = new Point(90 + siloKaydir4Secim - Cikar, 390);

                is_ButonFiltre5.Location = new Point(90 + siloKaydir5Secim, 0);
                Cimento5KritikBlink.Location = new Point(70 + siloKaydir5Secim, 80);
                StoktaBulunanCimento5.Location = new Point(95 + siloKaydir5Secim, 80);
                Silo5.Location = new Point(70 + siloKaydir5Secim, 70);
                XB3_Cimento5Istenen.Location = new Point(80 + siloKaydir5Secim, 190);
                XB3_Cimento5Verilen.Location = new Point(80 + siloKaydir5Secim, 220);
                qs_SoklamaLambasi5.Location = new Point(90 + siloKaydir5Secim, 250);
                is_ButonCimento5.Location = new Point(90 + siloKaydir5Secim, 390);


                // Çimentoboru1 için location bilgileri
                cimentoboru1.Location = new Point(120 + siloKaydir1Secim - Cikariki, 335);
                cimentoboru1_1.Location = new Point(120 + siloKaydir1Secim - Cikariki, 451);
                cimentoboru1_2.Location = new Point(128 + siloKaydir1Secim - Cikariki, 500);
                cimentoboru1_2.Size = new Size(55, 8);
                cimentoboru1_3.Location = new Point(120 + siloKaydir1Secim - Cikariki, 491);

                //Çimentoboru2 için location bilgileri
                cimentoboru2.Location = new Point(120 + siloKaydir2Secim - Cikariki, 335);
                cimentoboru2_1.Location = new Point(120 + siloKaydir2Secim - Cikariki, 451);
                cimentoboru2_2.Location = new Point(102 + siloKaydir2Secim - Cikariki, 500);
                cimentoboru2_2.Size = new Size(10, 8);
                cimentoboru2_3.Location = new Point(111 + siloKaydir2Secim - Cikariki, 491);


                //Çimentoboru3 için location bilgileri
                cimentoboru3.Location = new Point(120 + siloKaydir3Secim - Cikar, 335);
                cimentoboru3_1.Location = new Point(120 + siloKaydir3Secim - Cikar, 451);
                cimentoboru3_1.Size = new Size(8, 47);
                cimentoboru3_2.Location = new Point(128 + siloKaydir3Secim - Cikar, 500);
                cimentoboru3_2.Size = new Size(118, 8);
                cimentoboru3_4.Location = new Point(120 + siloKaydir3Secim - Cikar, 491);

                //Çimentoboru4 için location bilgileri
                cimentoboru4.Location = new Point(120 + siloKaydir4Secim - Cikar, 335);
                cimentoboru4_1.Location = new Point(120 + siloKaydir4Secim - Cikar, 451);
                //cimentoboru4_2.Location = new Point(83 + siloKaydir4Secim - Cikar, 500);
                //cimentoboru4_2.Size = new Size(30, 8);w
                //cimentoboru4_3.Location = new Point(120 + siloKaydir4Secim - Cikar, 491);

                //Çimentoboru5 için location bilgileri
                cimentoboru5.Location = new Point(120 + siloKaydir5Secim, 335);
                cimentoboru5_1.Location = new Point(120 + siloKaydir5Secim, 451);
                cimentoboru5_2.Location = new Point(57 + siloKaydir5Secim , 500);
                cimentoboru5_2.Size = new Size(60, 8);
                cimentoboru5_3.Location = new Point(111 + siloKaydir5Secim, 491);


                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;

                //Silo1 visible Kontrol
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Silo2 visible Kontrol
                is_ButonFiltre2.Visible = true;
                Cimento2KritikBlink.Visible = true;
                StoktaBulunanCimento2.Visible = true;
                Silo2.Visible = true;
                XB3_Cimento2Istenen.Visible = true;
                XB3_Cimento2Verilen.Visible = true;
                qs_SoklamaLambasi2.Visible = true;
                is_ButonCimento2.Visible = true;

                //Silo3 visible Kontrol
                is_ButonFiltre3.Visible = true;
                Cimento3KritikBlink.Visible = true;
                StoktaBulunanCimento3.Visible = true;
                Silo3.Visible = true;
                XB3_Cimento3Istenen.Visible = true;
                XB3_Cimento3Verilen.Visible = true;
                qs_SoklamaLambasi3.Visible = true;
                is_ButonCimento3.Visible = true;

                //Silo4 visible Kontrol
                is_ButonFiltre4.Visible = true;
                Cimento4KritikBlink.Visible = true;
                StoktaBulunanCimento4.Visible = true;
                Silo4.Visible = true;
                XB3_Cimento4Istenen.Visible = true;
                XB3_Cimento4Verilen.Visible = true;
                qs_SoklamaLambasi4.Visible = true;
                is_ButonCimento4.Visible = true;

                //Silo5 visible Kontrol
                is_ButonFiltre5.Visible = true;
                Cimento5KritikBlink.Visible = true;
                StoktaBulunanCimento5.Visible = true;
                Silo5.Visible = true;
                XB3_Cimento5Istenen.Visible = true;
                XB3_Cimento5Verilen.Visible = true;
                qs_SoklamaLambasi5.Visible = true;
                is_ButonCimento5.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

                //Cimentoboru2 visible Kontrol
                cimentoboru2.Visible = true;
                cimentoboru2_1.Visible = true;
                cimentoboru2_2.Visible = true;
                cimentoboru2_3.Visible = true;


                //Cimentoboru3 visible Kontrol
                cimentoboru3.Visible = true;
                cimentoboru3_1.Visible = true;
                cimentoboru3_2.Visible = true;
                cimentoboru3_4.Visible = true;

                //Cimentoboru4 visible Kontrol
                cimentoboru4.Visible = true;
                cimentoboru4_1.Visible = true;
                //cimentoboru4_2.Visible = true;
                //cimentoboru4_3.Visible = true;

                //Cimentoboru5 visible Kontrol
                cimentoboru5.Visible = true;
                cimentoboru5_1.Visible = true;
                cimentoboru5_2.Visible = true;
                cimentoboru5_3.Visible = true;


            }
            if (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi == 6)
            {
                //soklama buton  için defult location bilgileri;
                is_ButonSoklama.Location = new Point(10, 290);
                qs_SoklamaLambasi.Location = new Point(10, 365);
            
                //Silo1 için defult location bilgileri;
                is_ButonFiltre1.Location = new Point(90, 0);
                Cimento1KritikBlink.Location = new Point(70, 80);
                StoktaBulunanCimento1.Location = new Point(95, 80);
                Silo1.Location = new Point(70, 70);
                XB3_Cimento1Istenen.Location = new Point(80, 190);
                XB3_Cimento1Verilen.Location = new Point(80, 220);
                qs_SoklamaLambasi1.Location = new Point(90, 250);
                is_ButonCimento1.Location = new Point(90, 390);
                //Silo2 için defult location bilgileri;
                is_ButonFiltre2.Location = new Point(200, 0);
                Cimento2KritikBlink.Location = new Point(180, 80);
                StoktaBulunanCimento2.Location = new Point(205, 80);
                Silo2.Location = new Point(180, 70);
                XB3_Cimento2Istenen.Location = new Point(190, 190);
                XB3_Cimento2Verilen.Location = new Point(190, 220);
                qs_SoklamaLambasi2.Location = new Point(200, 250);
                is_ButonCimento2.Location = new Point(200, 390);
                //Silo3 için defult location bilgileri;
                is_ButonFiltre3.Location = new Point(310, 0);
                Cimento3KritikBlink.Location = new Point(290, 80);
                StoktaBulunanCimento3.Location = new Point(315, 80);
                Silo3.Location = new Point(290, 70);
                XB3_Cimento3Istenen.Location = new Point(300, 190);
                XB3_Cimento3Verilen.Location = new Point(300, 220);
                qs_SoklamaLambasi3.Location = new Point(310, 250);
                is_ButonCimento3.Location = new Point(310, 390);
                //Silo4 için defult location bilgileri;
                is_ButonFiltre4.Location = new Point(420, 0);
                Cimento4KritikBlink.Location = new Point(400, 80);
                StoktaBulunanCimento4.Location = new Point(425, 80);
                Silo4.Location = new Point(400, 70);
                XB3_Cimento4Istenen.Location = new Point(410, 190);
                XB3_Cimento4Verilen.Location = new Point(410, 220);
                qs_SoklamaLambasi4.Location = new Point(420, 250);
                is_ButonCimento4.Location = new Point(420, 390);
                //Silo5 için defult location bilgileri;
                is_ButonFiltre5.Location = new Point(530, 0);
                Cimento5KritikBlink.Location = new Point(510, 80);
                StoktaBulunanCimento5.Location = new Point(535, 80);
                Silo5.Location = new Point(510, 70);
                XB3_Cimento5Istenen.Location = new Point(520, 190);
                XB3_Cimento5Verilen.Location = new Point(520, 220);
                qs_SoklamaLambasi5.Location = new Point(530, 250);
                is_ButonCimento5.Location = new Point(530, 390);
                //Silo6 için defult location bilgileri;
                is_ButonFiltre6.Location = new Point(640, 0);
                Cimento6KritikBlink.Location = new Point(620, 80);
                StoktaBulunanCimento6.Location = new Point(645, 80);
                Silo6.Location = new Point(620, 70);
                XB3_Cimento6Istenen.Location = new Point(630, 190);
                XB3_Cimento6Verilen.Location = new Point(630, 220);
                qs_SoklamaLambasi6.Location = new Point(640, 250);
                is_ButonCimento6.Location = new Point(640, 390);

                //Çimento borular için location bilgileri
                //Çimentoboru1 için location ve size bilgileri
                cimentoboru1.Location = new Point(120, 335);
                cimentoboru1_1.Location = new Point(120, 451);
                cimentoboru1_1.Size = new Size(8, 50);
                cimentoboru1_2.Location = new Point(127, 500);
                cimentoboru1_2.Size = new Size(117, 8);
                cimentoboru1_3.Location = new Point(120, 491);

                //Çimentoboru2 için location ve size bilgileri
                cimentoboru2.Location = new Point(230, 335);
                cimentoboru2_1.Location = new Point(230, 451);
                cimentoboru2_1.Size = new Size(8, 50);
               

                //Çimentoboru3 için location bilgileri
                cimentoboru3.Location = new Point(340, 335);
                cimentoboru3_1.Location = new Point(340, 451);
                cimentoboru3_1.Size = new Size(8, 50);
                cimentoboru3_2.Location = new Point(276, 500);
                cimentoboru3_2.Size = new Size(65, 8);
                cimentoboru3_3.Location = new Point(331, 491);

                //Çimentoboru4 için location bilgileri
                cimentoboru4.Location = new Point(450, 335);
                cimentoboru4_1.Location = new Point(450, 451);
                cimentoboru4_1.Size = new Size(8, 50);
                cimentoboru4_2.Location = new Point(457, 500);
                cimentoboru4_2.Size = new Size(71, 8);
                cimentoboru4_3.Location = new Point(450, 491);

                //Çimentoboru5 için location bilgileri
                cimentoboru5.Location = new Point(560, 335);
                cimentoboru5_1.Location = new Point(560, 451);
                cimentoboru5_1.Size = new Size(8, 50);
                

                //Çimentoboru6 için location bilgileri
                cimentoboru6.Location = new Point(670, 335);
                cimentoboru6_1.Location = new Point(670, 451);
                cimentoboru6_1.Size = new Size(8, 50);
                cimentoboru6_2.Location = new Point(560, 500);
                cimentoboru6_2.Size = new Size(111, 8);
                cimentoboru6_3.Location = new Point(661, 491);

                is_ButonSoklama.Visible = true;
                qs_SoklamaLambasi.Visible = true;

                //Silo1 visible Kontrol
                is_ButonFiltre1.Visible = true;
                Cimento1KritikBlink.Visible = true;
                StoktaBulunanCimento1.Visible = true;
                Silo1.Visible = true;
                XB3_Cimento1Istenen.Visible = true;
                XB3_Cimento1Verilen.Visible = true;
                qs_SoklamaLambasi1.Visible = true;
                is_ButonCimento1.Visible = true;

                //Silo2 visible Kontrol
                is_ButonFiltre2.Visible = true;
                Cimento2KritikBlink.Visible = true;
                StoktaBulunanCimento2.Visible = true;
                Silo2.Visible = true;
                XB3_Cimento2Istenen.Visible = true;
                XB3_Cimento2Verilen.Visible = true;
                qs_SoklamaLambasi2.Visible = true;
                is_ButonCimento2.Visible = true;

                //Silo3 visible Kontrol
                is_ButonFiltre3.Visible = true;
                Cimento3KritikBlink.Visible = true;
                StoktaBulunanCimento3.Visible = true;
                Silo3.Visible = true;
                XB3_Cimento3Istenen.Visible = true;
                XB3_Cimento3Verilen.Visible = true;
                qs_SoklamaLambasi3.Visible = true;
                is_ButonCimento3.Visible = true;

                //Silo4 visible Kontrol
                is_ButonFiltre4.Visible = true;
                Cimento4KritikBlink.Visible = true;
                StoktaBulunanCimento4.Visible = true;
                Silo4.Visible = true;
                XB3_Cimento4Istenen.Visible = true;
                XB3_Cimento4Verilen.Visible = true;
                qs_SoklamaLambasi4.Visible = true;
                is_ButonCimento4.Visible = true;

                //Silo5 visible Kontrol
                is_ButonFiltre5.Visible = true;
                Cimento5KritikBlink.Visible = true;
                StoktaBulunanCimento5.Visible = true;
                Silo5.Visible = true;
                XB3_Cimento5Istenen.Visible = true;
                XB3_Cimento5Verilen.Visible = true;
                qs_SoklamaLambasi5.Visible = true;
                is_ButonCimento5.Visible = true;

                //Silo6 visible Kontrol
                is_ButonFiltre6.Visible = true;
                Cimento6KritikBlink.Visible = true;
                StoktaBulunanCimento6.Visible = true;
                Silo6.Visible = true;
                XB3_Cimento6Istenen.Visible = true;
                XB3_Cimento6Verilen.Visible = true;
                qs_SoklamaLambasi6.Visible = true;
                is_ButonCimento6.Visible = true;

                //Cimentoboru1 visible Kontrol
                cimentoboru1.Visible = true;
                cimentoboru1_1.Visible = true;
                cimentoboru1_2.Visible = true;
                cimentoboru1_3.Visible = true;

                //Cimentoboru2 visible Kontrol
                cimentoboru2.Visible = true;
                cimentoboru2_1.Visible = true;


                //Cimentoboru3 visible Kontrol
                cimentoboru3.Visible = true;
                cimentoboru3_1.Visible = true;
                cimentoboru3_2.Visible = true;
                cimentoboru3_3.Visible = true;


                //Cimentoboru4 visible Kontrol
                cimentoboru4.Visible = true;
                cimentoboru4_1.Visible = true;
                cimentoboru4_2.Visible = true;
                cimentoboru4_3.Visible = true;

                //Cimentoboru5 visible Kontrol
                cimentoboru5.Visible = true;
                cimentoboru5_1.Visible = true;


                //Cimentoboru6 visible Kontrol
                cimentoboru6.Visible = true;
                cimentoboru6_1.Visible = true;
                cimentoboru6_2.Visible = true;
                cimentoboru6_3.Visible = true;
            }
        }
    
        private void is_ButonCimento1_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento1.ModbusAdress_S);
        }

        private void is_ButonCimento2_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento2.ModbusAdress_S);

        }

        private void is_ButonCimento3_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento3.ModbusAdress_S);

        }

        private void is_ButonCimento4_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento4.ModbusAdress_S);

        }

        private void is_ButonCimento5_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento5.ModbusAdress_S);

        }

        private void is_ButonCimento6_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonCimento6.ModbusAdress_S);

        }

        private void is_ButonSoklama_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonSoklama.ModbusAdress_S);

        }

        private void is_ButonFiltre1_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonFiltre1.ModbusAdress_S);

        }

        private void is_ButonFiltre2_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonFiltre2.ModbusAdress_S);

        }

        private void is_ButonFiltre3_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonFiltre3.ModbusAdress_S);

        }

        private void is_ButonFiltre4_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonFiltre4.ModbusAdress_S);

        }

        private void is_ButonFiltre5_Click(object sender, EventArgs e)
        {

            HetmodBusTool.WriteBool(is_ButonFiltre5.ModbusAdress_S);
        }

        private void is_ButonFiltre6_Click(object sender, EventArgs e)
        {
            HetmodBusTool.WriteBool(is_ButonFiltre6.ModbusAdress_S);

        }
       
    }
}
