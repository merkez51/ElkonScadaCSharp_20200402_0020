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
    public partial class Katki_Temp : UserControl
    {

        public Katki_Temp()
        {

            InitializeComponent();
        }



        private void Katki_Temp_Load(object sender, EventArgs e)
        {
            BelirlenenKatkiSayisi();
        }
        public void BelirlenenKatkiSayisi()
        {
            //Katki Yikama location bilgiler
            KatkiYikama.Location = new Point(34, 259);
            is_ButonKatkiYikama.Location = new Point(122, 294);

            //Katkı1 için default location bilgileri
            Katki1KritikBlink.Location = new Point(1, 48);
            StoktaBulunanKatki1.Location = new Point(26, 49);
            XB5_Katki1Istenen.Location = new Point(0, 69);
            XB19_Katki1Verilen.Location = new Point(0, 88);
            KatkiMotor1.Location = new Point(11, 122);
            is_ButonKatki1.Location = new Point(0, 209);

            //Katkı2 için default location bilgileri
            Katki2KritikBlink.Location = new Point(101, 48);
            StoktaBulunanKatki2.Location = new Point(126, 49);
            XB5_Katki2Istenen.Location = new Point(100, 69);
            XB19_Katki2Verilen.Location = new Point(100, 88);
            KatkiMotor2.Location = new Point(111, 122);
            is_ButonKatki2.Location = new Point(100, 209);

            //Katkı3 için default location bilgileri
            Katki3KritikBlink.Location = new Point(201, 48);
            StoktaBulunanKatki3.Location = new Point(226, 49);
            XB5_Katki3Istenen.Location = new Point(200, 69);
            XB19_Katki3Verilen.Location = new Point(200, 88);
            KatkiMotor3.Location = new Point(211, 122);
            is_ButonKatki3.Location = new Point(200, 209);

            //Katkı4 için default location bilgileri
            Katki4KritikBlink.Location = new Point(301, 48);
            StoktaBulunanKatki4.Location = new Point(326, 49);
            XB5_Katki4Istenen.Location = new Point(300, 69);
            XB19_Katki4Verilen.Location = new Point(300, 88);
            KatkiMotor4.Location = new Point(311, 122);
            is_ButonKatki4.Location = new Point(300, 209);

            //Katkı5 için default location bilgileri
            Katki5KritikBlink.Location = new Point(401, 48);
            StoktaBulunanKatki5.Location = new Point(426, 49);
            XB5_Katki5Istenen.Location = new Point(400, 69);
            XB19_Katki5Verilen.Location = new Point(400, 88);
            KatkiMotor5.Location = new Point(411, 122);
            is_ButonKatki5.Location = new Point(400, 209);

            //Katki yıkama için visible kontrol
            KatkiYikama.Visible = false;
            is_ButonKatkiYikama.Visible = false;

            //Katkı1 için visible kontrol
            Katki1KritikBlink.Visible = false;
            StoktaBulunanKatki1.Visible = false;
            XB5_Katki1Istenen.Visible = false;
            XB19_Katki1Verilen.Visible = false;
            KatkiMotor1.Visible = false;
            is_ButonKatki1.Visible = false;

            //Katkı2 için visible kontrol
            Katki2KritikBlink.Visible = false;
            StoktaBulunanKatki2.Visible = false;
            XB5_Katki2Istenen.Visible = false;
            XB19_Katki2Verilen.Visible = false;
            KatkiMotor2.Visible = false;
            is_ButonKatki2.Visible = false;

            //Katkı3 için visible kontrol
            Katki3KritikBlink.Visible = false;
            StoktaBulunanKatki3.Visible = false;
            XB5_Katki3Istenen.Visible = false;
            XB19_Katki3Verilen.Visible = false;
            KatkiMotor3.Visible = false;
            is_ButonKatki3.Visible = false;

            //Katkı4 için visible kontrol
            Katki4KritikBlink.Visible = false;
            StoktaBulunanKatki4.Visible = false;
            XB5_Katki4Istenen.Visible = false;
            XB19_Katki4Verilen.Visible = false;
            KatkiMotor4.Visible = false;
            is_ButonKatki4.Visible = false;

            //Katkı5 için visible kontrol
            Katki5KritikBlink.Visible = false;
            StoktaBulunanKatki5.Visible = false;
            XB5_Katki5Istenen.Visible = false;
            XB19_Katki5Verilen.Visible = false;
            KatkiMotor5.Visible = false;
            is_ButonKatki5.Visible = false;

            //Katki boruları için default location bilgileri
            Katkiboru1.Location = new Point(27, 200);
            Katkiboru2.Location = new Point(127, 200);
            Katkiboru3.Location = new Point(227, 200);
            Katkiboru4.Location = new Point(327, 200);
            Katkiboru5.Location = new Point(427, 200);
            Katkiboru6.Location = new Point(63, 244);
            Katkiboru7_1.Location = new Point(163, 244);
            Katkiboru7_2.Location = new Point(163, 234);
            Katkiboru8_1.Location = new Point(263, 244);
            Katkiboru8_2.Location = new Point(163, 234);
            Katkiboru9.Location = new Point(363, 244);
            Katkiboru10.Location = new Point(229, 251);
            Katkiboru11.Location = new Point(106, 323);
            Katkiboru12.Location = new Point(185, 323);
            Katkiboru13.Location = new Point(229, 301);
            Katkisayacboru1.Location = new Point(236, 293);

            //Katkı Boruları
            Katkiboru1.Visible = false;
            Katkiboru2.Visible = false;
            Katkiboru3.Visible = false;
            Katkiboru4.Visible = false;
            Katkiboru5.Visible = false;
            Katkiboru6.Visible = false;
            Katkiboru7_1.Visible = false;
            Katkiboru7_2.Visible = false;
            Katkiboru8_1.Visible = false;
            Katkiboru8_2.Visible = false;
            Katkiboru9.Visible = false;
            Katkiboru10.Visible = true;
            Katkiboru11.Visible = true;
            Katkiboru12.Visible = true;
            Katkiboru13.Visible = true;

            Katkisayacboru1.Visible = false;

            //Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 5;
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 1)
            {
                //Pic_KatkiKantar1 için location bilgileri
                Katki1KritikBlink.Location = new Point(201, 48);
                StoktaBulunanKatki1.Location = new Point(226, 49);
                XB5_Katki1Istenen.Location = new Point(200, 69);
                XB19_Katki1Verilen.Location = new Point(200, 88);
                KatkiMotor1.Location = new Point(211, 122);
                is_ButonKatki1.Location = new Point(200, 209);

                //Pic_KatkiKantar1 için boru location bilgileri
                Katkiboru1.Location = new Point(227, 200);

                //Katkı1 visible kontrol 
                Katki1KritikBlink.Visible = true;
                StoktaBulunanKatki1.Visible = true;
                XB5_Katki1Istenen.Visible = true;
                XB19_Katki1Verilen.Visible = true;
                KatkiMotor1.Visible = true;
                is_ButonKatki1.Visible = true;

                //Katkı1 boru visible kontrol 
                Katkiboru1.Visible = true;
                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)

                {
                    Katkisayacboru1.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Katkisayacboru1.Visible = false;
                    }
                }


                KatkiYikamaTrue();
                
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 2)
            {
                //Pic_KatkiKantar2 için location bilgileri
                Katki1KritikBlink.Location = new Point(101, 48);
                StoktaBulunanKatki1.Location = new Point(126, 49);
                XB5_Katki1Istenen.Location = new Point(100, 69);
                XB19_Katki1Verilen.Location = new Point(100, 88);
                KatkiMotor1.Location = new Point(111, 122);
                is_ButonKatki1.Location = new Point(100, 209);


                Katki2KritikBlink.Location = new Point(201, 48);
                StoktaBulunanKatki2.Location = new Point(226, 49);
                XB5_Katki2Istenen.Location = new Point(200, 69);
                XB19_Katki2Verilen.Location = new Point(200, 88);
                KatkiMotor2.Location = new Point(211, 122);
                is_ButonKatki2.Location = new Point(200, 209);

                //Pic_KatkiKantar2 için boru location bilgileri
                Katkiboru1.Location = new Point(127, 200);
                Katkiboru2.Location = new Point(227, 200);
                Katkiboru6.Location = new Point(163, 244);



                //Katkı1 visible kontrol 
                Katki1KritikBlink.Visible = true;
                StoktaBulunanKatki1.Visible = true;
                XB5_Katki1Istenen.Visible = true;
                XB19_Katki1Verilen.Visible = true;
                KatkiMotor1.Visible = true;
                is_ButonKatki1.Visible = true;

                //Katkı2 visible kontrol 
                Katki2KritikBlink.Visible = true;
                StoktaBulunanKatki2.Visible = true;
                XB5_Katki2Istenen.Visible = true;
                XB19_Katki2Verilen.Visible = true;
                KatkiMotor2.Visible = true;
                is_ButonKatki2.Visible = true;

                //Katkı1 boru visible kontrol 
                Katkiboru1.Visible = true;
                Katkiboru2.Visible = true;
                Katkiboru6.Visible = true;

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false )
                    
                {
                    Katkisayacboru1.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        Katkisayacboru1.Visible = false;
                    }
                }
                else Katkisayacboru1.Visible = false;
                KatkiYikamaTrue();


            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 3)
            {
                //Pic_KatkiKantar3 için location bilgileri
                Katki1KritikBlink.Location = new Point(101, 48);
                StoktaBulunanKatki1.Location = new Point(126, 49);
                XB5_Katki1Istenen.Location = new Point(100, 69);
                XB19_Katki1Verilen.Location = new Point(100, 88);
                KatkiMotor1.Location = new Point(111, 122);
                is_ButonKatki1.Location = new Point(100, 209);

                
                Katki2KritikBlink.Location = new Point(201, 48);
                StoktaBulunanKatki2.Location = new Point(226, 49);
                XB5_Katki2Istenen.Location = new Point(200, 69);
                XB19_Katki2Verilen.Location = new Point(200, 88);
                KatkiMotor2.Location = new Point(211, 122);
                is_ButonKatki2.Location = new Point(200, 209);

              
                Katki3KritikBlink.Location = new Point(301, 48);
                StoktaBulunanKatki3.Location = new Point(326, 49);
                XB5_Katki3Istenen.Location = new Point(300, 69);
                XB19_Katki3Verilen.Location = new Point(300, 88);
                KatkiMotor3.Location = new Point(311, 122);
                is_ButonKatki3.Location = new Point(300, 209);

                //Pic_KatkiKantar3 için boru location bilgileri
                Katkiboru1.Location = new Point(127, 200);
                Katkiboru2.Location = new Point(227, 200);
                Katkiboru3.Location = new Point(327, 200);
                Katkiboru6.Location = new Point(163, 244);
                Katkiboru7_1.Location = new Point(263, 244);

                //Katkı1 için visible kontrol
                Katki1KritikBlink.Visible = true;
                StoktaBulunanKatki1.Visible = true;
                XB5_Katki1Istenen.Visible = true;
                XB19_Katki1Verilen.Visible = true;
                KatkiMotor1.Visible = true;
                is_ButonKatki1.Visible = true;

                //Katkı2 için visible kontrol
                Katki2KritikBlink.Visible = true;
                StoktaBulunanKatki2.Visible = true;
                XB5_Katki2Istenen.Visible = true;
                XB19_Katki2Verilen.Visible = true;
                KatkiMotor2.Visible = true;
                is_ButonKatki2.Visible = true;

                //Katkı3 için visible kontrol
                Katki3KritikBlink.Visible = true;
                StoktaBulunanKatki3.Visible = true;
                XB5_Katki3Istenen.Visible = true;
                XB19_Katki3Verilen.Visible = true;
                KatkiMotor3.Visible = true;
                is_ButonKatki3.Visible = true;

                //Katkı3 boruları için visible kontrol
                Katkiboru1.Visible = true;
                Katkiboru2.Visible = true;
                Katkiboru3.Visible = true;
                Katkiboru6.Visible = true;
                Katkiboru7_1.Visible = true;

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                    

                {
                    Katkisayacboru1.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false )
                        
                    {
                        Katkisayacboru1.Visible = false;
                    }
                }
                else Katkisayacboru1.Visible = false;
                KatkiYikamaTrue();
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 4)
            {

                //Pic_KatkiKantar4 için location bilgileri

                Katki1KritikBlink.Location = new Point(1, 48);
                StoktaBulunanKatki1.Location = new Point(26, 49);
                XB5_Katki1Istenen.Location = new Point(0, 69);
                XB19_Katki1Verilen.Location = new Point(0, 88);
                KatkiMotor1.Location = new Point(11, 122);
                is_ButonKatki1.Location = new Point(0, 209);


                Katki2KritikBlink.Location = new Point(101, 48);
                StoktaBulunanKatki2.Location = new Point(126, 49);
                XB5_Katki2Istenen.Location = new Point(100, 69);
                XB19_Katki2Verilen.Location = new Point(100, 88);
                KatkiMotor2.Location = new Point(111, 122);
                is_ButonKatki2.Location = new Point(100, 209);


                Katki3KritikBlink.Location = new Point(201, 48);
                StoktaBulunanKatki3.Location = new Point(226, 49);
                XB5_Katki3Istenen.Location = new Point(200, 69);
                XB19_Katki3Verilen.Location = new Point(200, 88);
                KatkiMotor3.Location = new Point(211, 122);
                is_ButonKatki3.Location = new Point(200, 209);


                Katki4KritikBlink.Location = new Point(301, 48);
                StoktaBulunanKatki4.Location = new Point(326, 49);
                XB5_Katki4Istenen.Location = new Point(300, 69);
                XB19_Katki4Verilen.Location = new Point(300, 88);
                KatkiMotor4.Location = new Point(311, 122);
                is_ButonKatki4.Location = new Point(300, 209);


                //Pic_KatkiKantar4 için boru location bilgileri
                Katkiboru1.Location = new Point(27, 200);
                Katkiboru2.Location = new Point(127, 200);
                Katkiboru3.Location = new Point(227, 200);
                Katkiboru4.Location = new Point(327, 200);
                Katkiboru5.Location = new Point(427, 200);
                Katkiboru6.Location = new Point(63, 244);
                Katkiboru7_1.Location = new Point(163, 244);
                Katkiboru7_2.Location = new Point(163, 234);
                Katkiboru8_1.Location = new Point(263, 244);


                //Katkı1 visible kontrol 
                Katki1KritikBlink.Visible = true;
                StoktaBulunanKatki1.Visible = true;
                XB5_Katki1Istenen.Visible = true;
                XB19_Katki1Verilen.Visible = true;
                KatkiMotor1.Visible = true;
                is_ButonKatki1.Visible = true;

                //Katkı2 visible kontrol 
                Katki2KritikBlink.Visible = true;
                StoktaBulunanKatki2.Visible = true;
                XB5_Katki2Istenen.Visible = true;
                XB19_Katki2Verilen.Visible = true;
                KatkiMotor2.Visible = true;
                is_ButonKatki2.Visible = true;

                //Katkı3 için visible kontrol
                Katki3KritikBlink.Visible = true;
                StoktaBulunanKatki3.Visible = true;
                XB5_Katki3Istenen.Visible = true;
                XB19_Katki3Verilen.Visible = true;
                KatkiMotor3.Visible = true;
                is_ButonKatki3.Visible = true;

                //Katkı4 için visible kontrol
                Katki4KritikBlink.Visible = true;
                StoktaBulunanKatki4.Visible = true;
                XB5_Katki4Istenen.Visible = true;
                XB19_Katki4Verilen.Visible = true;
                KatkiMotor4.Visible = true;
                is_ButonKatki4.Visible = true;

                //Katki boruları için kontrol
                Katkiboru1.Visible = true;
                Katkiboru2.Visible = true;
                Katkiboru3.Visible = true;
                Katkiboru4.Visible = true;
                Katkiboru6.Visible = true;
                Katkiboru7_1.Visible = true;
                Katkiboru7_2.Visible = true;
                Katkiboru8_1.Visible = true;

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                    
                {
                    Katkisayacboru1.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                        

                    {
                        Katkisayacboru1.Visible = false;
                    }
                }
                else Katkisayacboru1.Visible = false;
                KatkiYikamaTrue();
            }
            if (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi == 5)
            {
                //Pic_KatkiKantar5 için location bilgileri
                                             
                Katki1KritikBlink.Location = new Point(1, 48);
                StoktaBulunanKatki1.Location = new Point(26, 49);
                XB5_Katki1Istenen.Location = new Point(0, 69);
                XB19_Katki1Verilen.Location = new Point(0, 88);
                KatkiMotor1.Location = new Point(11, 122);
                is_ButonKatki1.Location = new Point(0, 209);

               
                Katki2KritikBlink.Location = new Point(101, 48);
                StoktaBulunanKatki2.Location = new Point(126, 49);
                XB5_Katki2Istenen.Location = new Point(100, 69);
                XB19_Katki2Verilen.Location = new Point(100, 88);
                KatkiMotor2.Location = new Point(111, 122);
                is_ButonKatki2.Location = new Point(100, 209);

                
                Katki3KritikBlink.Location = new Point(201, 48);
                StoktaBulunanKatki3.Location = new Point(226, 49);
                XB5_Katki3Istenen.Location = new Point(200, 69);
                XB19_Katki3Verilen.Location = new Point(200, 88);
                KatkiMotor3.Location = new Point(211, 122);
                is_ButonKatki3.Location = new Point(200, 209);

                
                Katki4KritikBlink.Location = new Point(301, 48);
                StoktaBulunanKatki4.Location = new Point(326, 49);
                XB5_Katki4Istenen.Location = new Point(300, 69);
                XB19_Katki4Verilen.Location = new Point(300, 88);
                KatkiMotor4.Location = new Point(311, 122);
                is_ButonKatki4.Location = new Point(300, 209);

            
                Katki5KritikBlink.Location = new Point(401, 48);
                StoktaBulunanKatki5.Location = new Point(426, 49);
                XB5_Katki5Istenen.Location = new Point(400, 69);
                XB19_Katki5Verilen.Location = new Point(400, 88);
                KatkiMotor5.Location = new Point(411, 122);
                is_ButonKatki5.Location = new Point(400, 209);

                //Pic_KatkiKantar5 için boru location bilgileri
                Katkiboru1.Location = new Point(27, 200);
                Katkiboru2.Location = new Point(127, 200);
                Katkiboru3.Location = new Point(227, 200);
                Katkiboru4.Location = new Point(327, 200);
                Katkiboru5.Location = new Point(427, 200);
                Katkiboru6.Location = new Point(63, 244);
                Katkiboru7_1.Location = new Point(163, 244);
                Katkiboru7_2.Location = new Point(163, 234);
                Katkiboru8_1.Location = new Point(263, 244);
                Katkiboru8_2.Location = new Point(263, 234);
                Katkiboru9.Location = new Point(363, 244);

                //Katkı1 visible kontrol 
                Katki1KritikBlink.Visible = true;
                StoktaBulunanKatki1.Visible = true;
                XB5_Katki1Istenen.Visible = true;
                XB19_Katki1Verilen.Visible = true;
                KatkiMotor1.Visible = true;
                is_ButonKatki1.Visible = true;

                //Katkı2 visible kontrol 
                Katki2KritikBlink.Visible = true;
                StoktaBulunanKatki2.Visible = true;
                XB5_Katki2Istenen.Visible = true;
                XB19_Katki2Verilen.Visible = true;
                KatkiMotor2.Visible = true;
                is_ButonKatki2.Visible = true;

                //Katkı3 için visible kontrol
                Katki3KritikBlink.Visible = true;
                StoktaBulunanKatki3.Visible = true;
                XB5_Katki3Istenen.Visible = true;
                XB19_Katki3Verilen.Visible = true;
                KatkiMotor3.Visible = true;
                is_ButonKatki3.Visible = true;

                //Katkı4 için visible kontrol
                Katki4KritikBlink.Visible = true;
                StoktaBulunanKatki4.Visible = true;
                XB5_Katki4Istenen.Visible = true;
                XB19_Katki4Verilen.Visible = true;
                KatkiMotor4.Visible = true;
                is_ButonKatki4.Visible = true;

                //Katkı5 için visible kontrol
                Katki5KritikBlink.Visible = true;
                StoktaBulunanKatki5.Visible = true;
                XB5_Katki5Istenen.Visible = true;
                XB19_Katki5Verilen.Visible = true;
                KatkiMotor5.Visible = true;
                is_ButonKatki5.Visible = true;

                //Katki boruları için kontrol
                Katkiboru1.Visible = true;
                Katkiboru2.Visible = true;
                Katkiboru3.Visible = true;
                Katkiboru4.Visible = true;
                Katkiboru5.Visible = true;
                Katkiboru6.Visible = true;
                Katkiboru7_1.Visible = true;
                Katkiboru7_2.Visible = true;
                Katkiboru8_1.Visible = true;
                Katkiboru8_2.Visible = true;
                Katkiboru9.Visible = true;

                if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false ||
                    Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)
                    

                {
                    Katkisayacboru1.Visible = true;
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false &&
                        Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)


                    {
                        Katkisayacboru1.Visible = false;
                    }
                }
                else Katkisayacboru1.Visible = false;
                KatkiYikamaTrue();
            }
            
        } 
        public void KatkiYikamaTrue()
        {
            //Katki Yikama location bilgiler
            KatkiYikama.Location = new Point(34, 259);
            is_ButonKatkiYikama.Location = new Point(122, 294);

            //Katki yıkama için visible kontrol
            KatkiYikama.Visible = true;
            is_ButonKatkiYikama.Visible = true;
            

        }
        public event EventHandler Runkatki;
        public string KatkiBasilanButtonName;
        public bool butonState = false;

    }
    }

