using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ElkonScada
{
    public partial class KalibrasyonSayfasi : Form
    {
        //SRModbusTCP.ModbusTCP HetModbusTool = new SRModbusTCP.ModbusTCP();
        ElkonScada.XX_Connection.ModbusConnection HetagregaModbus = ElkonScada.XX_Connection.ModbusConnection.HetConnection();
        ElkonScada.XX_Connection.ModbusConnection ModbusClass = ElkonScada.XX_Connection.ModbusConnection.HetConnection();
        public KalibrasyonSayfasi()
        {
            InitializeComponent();
        }

        private void Calib_Sifirla_Button_Click(object sender, EventArgs e)    // Sıfırlama seçeneklerinin hangisinde aktif olduğunu belirlemek için oluşturuldu.
        {
            ((ElkonScada._002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).RefleshDataFromPLC_Timer.Enabled = true;

            if (Properties.M005_Modbus.Default.XB159_KantarSifirla)
            {
        
                Properties.M005_Modbus.Default.XB159_KantarSifirla = false;
                Properties.M005_Modbus.Default.KalibrasyonYapilacak = false;

            }
            else if (!Properties.M005_Modbus.Default.XB159_KantarSifirla)//XB159_KantarSifirla
            {
                
                Properties.M005_Modbus.Default.XB159_KantarSifirla = true;
                Properties.M005_Modbus.Default.KalibrasyonYapilacak = false;
            }
            //HetagregaModbus.DegerGonder();
            Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
            Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
            Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
            Su_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
            
            //HetagregaModbus.DegerGonder();
           // HetagregaModbus.ButtonWrite();
            


        }
        string b;
        public void YazKalibrasyonAgirligi()
        {

                ElkonScada.Properties.M005_Modbus.Default.XB159_Kalibrasyon_Agirligi = Convert.ToDouble(XB159_Kalibrasyon_Agirligi.Text);
                ElkonScada.Properties.M005_Modbus.Default.Save();
                deneme1.Text =Convert.ToString( ElkonScada.Properties.M005_Modbus.Default.XB159_Kalibrasyon_Agirligi); // Oldu
               
                //HetModbusTool.WriteSingleRegister.XB159_Kalibrasyon_Agirligi = ElkonScada.Properties.M005_Modbus.Default.XB159_Kalibrasyon_Agirligi;
        }
        
        private void Calibre_Et_Button_Click(object sender, EventArgs e)
        {
            ((ElkonScada._002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).RefleshDataFromPLC_Timer.Enabled = true;

            if (Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz)
            {
                Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz = false;
            }
            else if (!Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz)//XB159_KantarSifirla
            {
                Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz = true;
            }
          //  HetagregaModbus.ButtonWrite();
            // YazKalibrasyonAgirligi();        //Laumaslara Değer Yazdırma
            //HetagregaModbus.DegerGonder();    Laumastaki değerleri Plc global değişkenlere gönderme

        }

        private void Calib_Bitir_Click(object sender, EventArgs e)
        {
            ((ElkonScada._002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).RefleshDataFromPLC_Timer.Enabled = true;

            if (Properties.M005_Modbus.Default.XB159_KalibreSon)
            {
                Properties.M005_Modbus.Default.XB159_KalibreSon = false;
            }
            else if (!Properties.M005_Modbus.Default.XB159_KalibreSon)//XB159_KantarSifirla
            {
                Properties.M005_Modbus.Default.XB159_KalibreSon = true;
            }
           // HetagregaModbus.ButtonWrite();
            

            /*
            if (Agrega_Calib_Lamp.Enabled)
            {

            }
            if (Cimento_Calib_Lamp.Enabled)
            {

            }
            if (Su_Calib_Lamp.Enabled)
            {

            }
            if (Katki_Calib_Lamp.Enabled)
            {

            }
            */

        }
        //int a = 1;
        string kantar_adresi;

        public void KalibrasyonButton()
        {
            kantar_adresi = Properties.M005_Modbus.Default.XB158_KantarAdresi.ToString();
            textBox1.Text = kantar_adresi;
            
             switch (ElkonScada.Properties.M005_Modbus.Default.XB158_KantarAdresi)
             {
                 case 3:
                    Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Green_Kucuk;
                    Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Su_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    

                    break;
                 case 4:
                    Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Green_Kucuk;
                    Su_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    break;
                 case 5:
                    Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Su_Calib_Lamp.Image = Properties.Resources.Lamp_Green_Kucuk;
                    Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    break;
                 case 6:
                    Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Su_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Green_Kucuk;
                    break;

                 default:
                   /* Agrega_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Katki_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Cimento_Calib_Lamp.Image = Properties.Resources.Lamp_Black;
                    Su_Calib_Lamp.Image = Properties.Resources.Lamp_Black;*/
                    break;

             }
             
            //textBox1.Text = "5"; Bu oldu.
            

        }
        public static bool KalibrasyonYapılıyor = false;

        private void KalibrasyonSayfasi_Load(object sender, EventArgs e)
        {
            KalibrasyonYapılıyor = true;
            System.Drawing.Drawing2D.GraphicsPath grAgregaLampDuzen = new System.Drawing.Drawing2D.GraphicsPath();
            grAgregaLampDuzen.AddEllipse(2, 2, 60, 60);
            Agrega_Calib_Lamp.Region = new System.Drawing.Region(grAgregaLampDuzen);

            System.Drawing.Drawing2D.GraphicsPath grCimentoLampDuzen = new System.Drawing.Drawing2D.GraphicsPath();
            grCimentoLampDuzen.AddEllipse(2, 2, 60, 60);
            Cimento_Calib_Lamp.Region = new System.Drawing.Region(grCimentoLampDuzen);

            System.Drawing.Drawing2D.GraphicsPath grSuLampDuzen = new System.Drawing.Drawing2D.GraphicsPath();
            grSuLampDuzen.AddEllipse(2, 2, 60, 60);
            Su_Calib_Lamp.Region = new System.Drawing.Region(grSuLampDuzen);

            System.Drawing.Drawing2D.GraphicsPath grKatkiLampDuzen = new System.Drawing.Drawing2D.GraphicsPath();
            grKatkiLampDuzen.AddEllipse(2, 2, 60, 60);
            Katki_Calib_Lamp.Region = new System.Drawing.Region(grKatkiLampDuzen);
        }
        
        private void XB159_AgSec_Click(object sender, EventArgs e)
        {
            ((ElkonScada._002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).RefleshDataFromPLC_Timer.Enabled = true;
           // ((frmIslemler)Application.OpenForms["frmIslemler"]).Guncelle();
            


            if (ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec = false;

            }
            else if (!ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec = true;

            }
           // HetagregaModbus.ButtonWrite();
        }

        

        private void XB159_AgSec_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec = true;
              //  HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_AgSec_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_AgSec = false;
             //   HetagregaModbus.ButtonWrite();
            }
        }
        private void XB159_CimSec_Click(object sender, EventArgs e)
        {
            ((ElkonScada._002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).RefleshDataFromPLC_Timer.Enabled = true;


            if (ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec = false;

            }
            else if (!ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec = true;

            }

           // HetagregaModbus.ButtonWrite();
        }

        private void XB159_CimSec_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec = true;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_CimSec_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_CimSec = false;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_SuSec_Click(object sender, EventArgs e)
        {
            if (ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec = false;

            }
            else if (!ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec = true;

            }


           // HetagregaModbus.ButtonWrite();
        }

        private void XB159_SuSec_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec = true;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_SuSec_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_SuSec = false; // KISIMLARI FALSE İDİ
             //   HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KatkiSec_Click(object sender, EventArgs e)
        {
            if (ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec = false;

            }
            else if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec = true;

            }


            //HetagregaModbus.ButtonWrite();
        }

        private void XB159_KatkiSec_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec = true;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KatkiSec_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KatkiSec = false;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void KalibrasyonSayfasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            KalibrasyonYapılıyor = false;
        }

        //Değer Yazdırma Kısmı.............
        public void LaumasDegerleri()
        {/* 
            if (Properties.M005_Modbus.Default.XB158_KantarAdresi == 3)
            {
                laumas_Agrega1.Agrega1_Value_FromPLC.Text = deneme1.Text + " kg";
                laumas_Cimento1.Cimento1_Value_FromPLC.Text = "0.00 kg";
                laumas_Su1.Su1_Value_FromPLC.Text = "0.00 kg";
                laumas_Katki1.Katki1_Value_FromPLC.Text = "0.00 kg";
            }
            else if (Properties.M005_Modbus.Default.XB158_KantarAdresi == 4)
            {
                laumas_Agrega1.Agrega1_Value_FromPLC.Text = "0.00 kg";
                laumas_Cimento1.Cimento1_Value_FromPLC.Text = deneme1.Text + " kg";
                laumas_Su1.Su1_Value_FromPLC.Text = "0.00 kg";
                laumas_Katki1.Katki1_Value_FromPLC.Text = "0.00 kg";
            }
            else if (Properties.M005_Modbus.Default.XB158_KantarAdresi == 5)
            {
                laumas_Agrega1.Agrega1_Value_FromPLC.Text = "0.00 kg";
                laumas_Cimento1.Cimento1_Value_FromPLC.Text = "0.00 kg";
                laumas_Su1.Su1_Value_FromPLC.Text = deneme1.Text + " kg";
                laumas_Katki1.Katki1_Value_FromPLC.Text = "0.00 kg";
            }
            else if (Properties.M005_Modbus.Default.XB158_KantarAdresi == 6)
            {
                laumas_Agrega1.Agrega1_Value_FromPLC.Text = "0.00 kg";
                laumas_Cimento1.Cimento1_Value_FromPLC.Text = "0.00 kg";
                laumas_Su1.Su1_Value_FromPLC.Text = "0.00 kg";
                laumas_Katki1.Katki1_Value_FromPLC.Text = deneme1.Text + " kg";
            }
            */
        }

        private void KalibrasyonSayfasiTimer_Tick(object sender, EventArgs e)
        {
            RefleshKalibrasyonSayfasiTimer.Enabled = false;
            ModbusClass.ConnectPLC();
            if (KalibrasyonSayfasi.KalibrasyonYapılıyor)
            {
                KalibrasyonButton();
            }
            else
            {

            }
            //LaumasDegerleri();
           
            YazKalibrasyonAgirligi();
            // XB159_Kalibrasyon_Agirligi.Text = Convert.ToString(Properties.M005_Modbus.Default.XB159_Kalibrasyon_Agirligi); //PLC' deki kantar ağırlığını bilmek için
            ModbusClass.ReadPLCData();
            laumas_Agrega1.XB2_AgregaKantar.Text = Convert.ToString(Properties.M015_Agrega.Default.XB2_AgregaKantar)+" kg";
            laumas_Cimento1.XB3_CMKantar.Text = Convert.ToString(Properties.M016_Cimento.Default.XB3_CMKantar) + " kg";
            laumas_Su1.XB4_SuKantar.Text = Convert.ToString(Properties.M017_Su.Default.XB4_SuKantar) + " kg";
            laumas_Katki1.XB5_KatKantar.Text = Convert.ToString(Properties.M018_Katki.Default.XB5_KatKantar) + " kg";
            
            RefleshKalibrasyonSayfasiTimer.Enabled = true;
        }

        private void XB159_KantarSifirla_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KantarSifirla)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KantarSifirla = true;
              //  HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KantarSifirla_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KantarSifirla)//KalibrasyonYapilacak
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KantarSifirla = false;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KantarAgirliginiYaz_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz = true;
               //HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KantarAgirliginiYaz_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz = false;
                //HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KalibreSon_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KalibreSon)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KalibreSon = true;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void XB159_KalibreSon_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ElkonScada.Properties.M005_Modbus.Default.XB159_KalibreSon)
            {
                ElkonScada.Properties.M005_Modbus.Default.XB159_KalibreSon = false;
               // HetagregaModbus.ButtonWrite();
            }
        }

        private void laumas_Agrega1_Load(object sender, EventArgs e)
        {

        }

    }
}
