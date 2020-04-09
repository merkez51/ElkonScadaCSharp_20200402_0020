using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using ElkonScada._01_TempMainPage;
using System.Configuration;
using System.Windows.Input;

namespace ElkonScada._002.Sayfalar
{
    public partial class Anasayfa : Form
    {
        ElkonScada.XX_Connection.ModbusConnection ModbusClass = ElkonScada.XX_Connection.ModbusConnection.HetConnection();


        public Anasayfa()
        {
            InitializeComponent();
        }
        //sayfa açma
       
        //
        //Dil değiştirme
        public void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("");
            Localization.DilSettings.Default.Dil = "turkce";
            Localization.DilSettings.Default.Save();
            //Application.Restart();
            DilDegistir();

        }
        public void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("en-US");
            Localization.DilSettings.Default.Dil = "ingilizce";
            Localization.DilSettings.Default.Save();
            //  Application.Restart();
            DilDegistir();
            

        }
        public void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("es-ES");
            Localization.DilSettings.Default.Dil = "ispanyolca";
            Localization.DilSettings.Default.Save();
            //Application.Restart();
            DilDegistir();

        }
        public void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("fr-FR");
            Localization.DilSettings.Default.Dil = "fransizca";
            Localization.DilSettings.Default.Save();
            //Application.Restart();
            DilDegistir();

        }
        public void magyarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("hu-HU");
            Localization.DilSettings.Default.Dil = "macarca";
            Localization.DilSettings.Default.Save();
            // Application.Restart();
            DilDegistir();

        }
        public void polskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("pl-PL");
            Localization.DilSettings.Default.Dil = "polonyaca";
            Localization.DilSettings.Default.Save();
            //Application.Restart();
            DilDegistir();

        }
        public void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Localization.Culture = new CultureInfo("ru-RU");
            Localization.DilSettings.Default.Dil = "rusca";
            Localization.DilSettings.Default.Save();
            //Application.Restart();
            DilDegistir();

        }

    

        //
        //Dil değiştir
        public void DilDegistir()
        {

            if (Localization.DilSettings.Default.Dil == "turkce")
            {
                Localization.Localization.Culture = new CultureInfo("");
            }
            else if (Localization.DilSettings.Default.Dil == "ingilizce")
            {
                Localization.Localization.Culture = new CultureInfo("en-US");
            }
            else if (Localization.DilSettings.Default.Dil == "ispanyolca")
            {
                Localization.Localization.Culture = new CultureInfo("es-ES");
            }
            else if (Localization.DilSettings.Default.Dil == "fransizca")
            {
                Localization.Localization.Culture = new CultureInfo("fr-FR");
            }
            else if (Localization.DilSettings.Default.Dil == "macarca")
            {
                Localization.Localization.Culture = new CultureInfo("hu-HU");
            }
            else if (Localization.DilSettings.Default.Dil == "polonyaca")
            {
                Localization.Localization.Culture = new CultureInfo("pl-PL");
            }
            else if (Localization.DilSettings.Default.Dil == "rusca")
            {
                Localization.Localization.Culture = new CultureInfo("ru-RU");
            }

            ES6_1.Text = Localization.Localization.ES6_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES17_1.Text = Localization.Localization.ES17_1;
            ES19_1.Text = Localization.Localization.ES19_1;
            ES2807_1.Text = Localization.Localization.ES2807_1;
            ES3030_1.Text = Localization.Localization.ES2807_1;
            ES1525_1.Text = Localization.Localization.ES1525_1;
            ES21_1.Text = Localization.Localization.ES21_1;
            ES23_1.Text = Localization.Localization.ES23_1;
            ES24_1.Text = Localization.Localization.ES24_1;
            ES22_1.Text = Localization.Localization.ES22_1;
            ES8_1.Text = Localization.Localization.ES8_1;
            ES1538_1.Text = Localization.Localization.ES1538_1;
            ES1539_1.Text = Localization.Localization.ES1539_1;
            ES1540_1.Text = Localization.Localization.ES1540_1;
            ES1541_1.Text = Localization.Localization.ES1541_1;
            ES1542_1.Text = Localization.Localization.ES1542_1;
            ES1543_1.Text = Localization.Localization.ES1543_1;
            ES1544_1.Text = Localization.Localization.ES1544_1;
            ES1947_1.Text = Localization.Localization.ES1947_1;
            ES2136_0.Text = Localization.Localization.ES2136_0;
            ES1526_1.Text = Localization.Localization.ES1526_1;
            ES966_1.Text = Localization.Localization.ES966_1;
            ES965_1.Text = Localization.Localization.ES965_1;
            ES1011_1.Text = Localization.Localization.ES1011_1;
            ES27_1.Text = Localization.Localization.ES27_1;
            ES29_1.Text = Localization.Localization.ES29_1;
            ES30_1.Text = Localization.Localization.ES30_1;
            ES33_1.Text = Localization.Localization.ES33_1;
            ES34_1.Text = Localization.Localization.ES34_1;
            ES2838_1.Text = Localization.Localization.ES2838_1;
            ES2725_1.Text = Localization.Localization.ES2725_1;
            ES10_1.Text = Localization.Localization.ES10_1;
            ES25_1.Text = Localization.Localization.ES25_1;
            ES26_1.Text = Localization.Localization.ES26_1;
            ES36_1.Text = Localization.Localization.ES36_1;
            ES47_1.Text = Localization.Localization.ES47_1;
            ES32_1.Text = Localization.Localization.ES32_1;
            ES12_1.Text = Localization.Localization.ES12_1;
            ES13_1.Text = Localization.Localization.ES13_1;
            ES1201_1.Text = Localization.Localization.ES1201_1;
            ES1202_1.Text = Localization.Localization.ES1202_1;
            ES1203_1.Text = Localization.Localization.ES1203_1;
            ES1524_1.Text = Localization.Localization.ES1524_1;
            ES1629_1.Text = Localization.Localization.ES1629_1;
            ES3021_0.Text = Localization.Localization.ES3021_0;
            ES3022_0.Text = Localization.Localization.ES3022_0;
            ES1630_0.Text = Localization.Localization.ES1630_0;
            ES1631_0.Text = Localization.Localization.ES1631_0;
            ES1632_0.Text = Localization.Localization.ES1632_0;
            ES1680_1.Text = Localization.Localization.ES1680_1;
            ES1681_0.Text = Localization.Localization.ES1681_1;
            ES789_1.Text = Localization.Localization.ES789_1;
            ES1236_1.Text = Localization.Localization.ES1236_1;
            arızaKayıtlarıToolStripMenuItem1.Text = Localization.Localization.arızaKayıtlarıToolStripMenuItem1;
            ES3030_1.Text = Localization.Localization.ES3030_1;
            reçetelerToolStripMenuItem1.Text = Localization.Localization.reçetelerToolStripMenuItem1;
            ES1526_1.Text = Localization.Localization.ES1526_1;
            


        }
        //
        ElkonScada._006_Konfigurator._004_StokAlaniCimentoKatkiSuSecimi KonfigReload = new _006_Konfigurator._004_StokAlaniCimentoKatkiSuSecimi();

        Image closeImage, closeImageAct;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Size mysize = new System.Drawing.Size(20, 20); // co anh chen vao
            Bitmap bt = new Bitmap(Properties.Resources.close);
            // anh nay ban dau minh da them vao
            Bitmap btm = new Bitmap(bt, mysize);
            closeImageAct = btm;
            //
            //
            Bitmap bt2 = new Bitmap(Properties.Resources.closeBlack);
            // anh nay ban dau minh da them vao
            Bitmap btm2 = new Bitmap(bt2, mysize);
            closeImage = btm2;
            tabControl1.Padding = new Point(50);
            
            AddTabPage(new ANASAYFA_TEMP.MainControl(),"Conrol Page");

            
            DilDegistir();

            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.AgregaSiloYerlesimi();

            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.cimento_Temp1.BelirlenenSiloSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.Su_Button_Yerlesimi.BelirlenenSuSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.katki_Temp1.BelirlenenKatkiSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.Santral_belirleme();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.mixer_Temp_TW1.Miksersecimi();


            //KonfigReload.MalzemelerOlustur();
            //MainPageUserControl.otoUretimBilgileri1.GuncelleDatagriOtoUretim();
            //ModbusClass.ConnectPLC();

        }
       
        public void RefleshMainPage()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void LaumasSu()
        {

        }
       
        int Hz_1 = 0;
        int Hz_2 = 0;
        int Hz_5 = 0;
        int Hz_10 = 0;
        int Saniye1Sn_Sayac = 0;
            xx_Hetlibrary.ModBusText_HetMD RefleshText = new xx_Hetlibrary.ModBusText_HetMD();

        int connectionResetSayac =0;
        private void RefleshDataFromPLC_Timer_Tick(object sender, EventArgs e)
        {
            //  Hz_1++; Hz_2++; Hz_5++; Hz_10++;
            //if (Hz_1 == 20)
            //{
             
            //    Saniye1Sn_Sayac++;
            //}
            //else if (Hz_1 > 40)
            //{
            //    Hz_1 = 0;

            //}
            //if (Hz_2 == 8)
            //{

            //}
            //else if (Hz_2 > 16)
            //{
            //    Hz_2 = 0;

            //}
            //if (Hz_5 == 4)
            //{

            //}
            //else if (Hz_5 == 8)
            //{
            //    Hz_5 = 0;

            //}
            //if (Hz_10 == 2)
            //{

            //}
            //else if (Hz_10 > 4)
            //{
            //    Hz_10 = 0;


            //}
            //RefleshDataFromPLC_Timer.Enabled = false;
            //if (Saniye1Sn_Sayac > 1)
            //{
            //    Properties.M101_Array.Default.Save();
            //    Saniye1Sn_Sayac = 0;
            //    connectionResetSayac++;

            //}
            //if (Hz_1==20)
            //{
                
            //}
            
            //if (ModbusClass.ConnectionErrorState)
            //{
            //    ConnectionReset.Visible = true;
            //}
            //else if (!ModbusClass.ConnectionErrorState)
            //{
            //    ConnectionReset.Visible = false;

               
        
            //    ModbusClass.ReadPLCData();
                

            //    RefleshDataFromPLC_Timer.Enabled = true;
            //}
            //MainPageUserControl.laumasEnerjiAnalizoru1.RefleshValue();

            //RefleshDataFromPLC_Timer.Enabled = true;
            //MainPageUserControl._00_B11.AgregaBunker1();
            //MainPageUserControl._01_B21.AgregaBunker2();
            //MainPageUserControl._02_B31.AgregaBunker3();
            //MainPageUserControl._03_B41.AgregaBunker4();
            //MainPageUserControl._04_B51.AgregaBunker5();
            //MainPageUserControl._05_B61.AgregaBunker6();
            //MainPageUserControl.duzTartımKonveyor_Temp1.Lamps_TartiKonveyor();

            //MainPageUserControl.Su_kantarsayacbelirleme();
            //MainPageUserControl.Katki_kantarsayacbelirleme();
            //MainPageUserControl.Cimento_Kantarbelirleme();
            //if (Properties.S000_Konfigrator_Tag.Default.konfigrasyonYapiliyor)
            //{
            //    MainPageUserControl.otoUretimBilgileri1.ReflesOtoUretimValue();

            //}


            //  textBox1.Text = Properties.M101_Array.Default.VerilenUrunMiktarlari_SCADA_Gonderilen[10].ToString();
        }

        private void ConnectModbus_For_ConnectionError_Tick(object sender, EventArgs e)
        {

        }


       
      

        private void MainPageUserControl_Load(object sender, EventArgs e)
        {
            //ModbusClass.ConnectPLC();
        }


        private void AddTabPage(Form frm, String FormText)
        {
            int t = KTFormTonTai(frm, FormText);
            if (t >= 0) // frm da dc mo
            {
                // neu tap da dc chon
                if (tabControl1.SelectedTab == tabControl1.TabPages[t])
                    MessageBox.Show(FormText + "  This page opened!");
                else
                    tabControl1.SelectedTab = tabControl1.TabPages[t];
            }
            else // them 
            {
                TabPage newTab = new TabPage(FormText);
                newTab.BorderStyle = BorderStyle.Fixed3D;
                tabControl1.TabPages.Add(newTab);
                frm.TopLevel = false;
                frm.Parent = newTab;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                frm.Show();
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
            }
        }
        private int KTFormTonTai(Form frm, string FormText)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
                if (tabControl1.TabPages[i].Text == FormText)
                    return i;
            return -1;
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // minh viet san, khoi mat thoi gian
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                rect.Top + (rect.Height - closeImage.Height) / 2,
                closeImage.Width, closeImage.Height);
            // tang size rect
            rect.Size = new Size(rect.Width + 20, 38);

            Font f;
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            // neu tab dang duoc chon
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);

                // hinh mau do, hinh nay them tu properti
                e.Graphics.DrawImage(closeImageAct, imageRec);
                f = new Font("Arial", 12, FontStyle.Bold);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
            else
            {
                // Tap dang mo, nhung ko dc chon, hinh mau den
                e.Graphics.DrawImage(closeImage, imageRec);
                f = new Font("Arial", 12, FontStyle.Regular);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
        }

        private void tabControl1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Su kien click dong tabpage
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                // giong o DrawItem
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                    rect.Top + (rect.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (imageRec.Contains(e.Location) && tabControl1.SelectedIndex != 0)
                {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                }
                else if (imageRec.Contains(e.Location) && tabControl1.SelectedIndex == 0)
                {

                    CloseProgram();


                }



            }
        }


        private void CloseProgram()
        {
            if (MessageBox.Show(Localization.Localization.ES1234_1 + "?", "!!!---", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                     == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ES19_1_Click(object sender, EventArgs e)
        {
                CloseProgram();

        }

        private void ConnectionReset_Click(object sender, EventArgs e)
        {
          //  ModbusClass.ConnectPLC();
        }

        private void MainPageUserControl_Load_2(object sender, EventArgs e)
        {

        }

        private void ES6_1_Click(object sender, EventArgs e)
        {

        }
        private void CompaniesOpenEvent(object sender, EventArgs e)
        {
            //ElkonScada._0001_Firmalar.Firmalar Companies = new ElkonScada._0001_Firmalar.Firmalar();
            //Companies.Show();
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0001_Firmalar.Firmalar(), menuItem.Text);
        }
        private void JobsitesOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0004_Santiyeler.Santiyeler(), menuItem.Text);
        }
        private void DriversOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0003_Suruculer.Suruculer(), menuItem.Text);
        }
        private void VehiclesOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0002_Araclar.Araclar(), menuItem.Text);
        }
        private void RecipeOpenEvent(object sender, EventArgs e)
        {
            //ElkonScada._0007_ReceteReceipt.Recete Recipes = new ElkonScada._0007_ReceteReceipt.Recete();
            //Recipes.Show();
             ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_ReceteReceipt.Recete(), menuItem.Text);
        }
        private void ResistanceClassOpenEvent(object sender, EventArgs e)
        {
             ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_01_DayanimSinifi.DayanimSinifiBeton(), menuItem.Text);
        }
        private void ConsistencyClassOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_02_KivamSinifi.KivamSinifiBeton(), menuItem.Text);
        }
        private void ResistanceClassToFrostOpenEvent(object sender, EventArgs e)
        {
           ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_03_DonaKarsiDayaniklilikSinifi.DonaKarsiDayaniklilikSinifiBeton(), menuItem.Text);
        }
        private void ResistanceClassToWaterOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_04_SuyaKarsiDirencSinifi.SuyaKarsiDirencSinifiBeton(), menuItem.Text);
        }
        private void DensityClassOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_05_YogunlukSinifi.YogunlukSinifiBeton(), menuItem.Text);
        }
        private void ChlorideContentClassOpenEvent(object sender, EventArgs e)
        {
           ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_06_KlorurIcerigiSinifi.KlorurIcerigiSinifiBeton(), menuItem.Text);
        }
        private void ConcreteTypeOpenEvent(object sender, EventArgs e)
        {
           ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_07_BetonTipi.BetonTipi(), menuItem.Text);
        }
        private void EnvironmentalImpactOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0007_08_CevreselEtki.CevreselEtki(), menuItem.Text);
        }
        private void OrdersOpenEvent(object sender, EventArgs e)
        {
           ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0008_Siparisler.Siparisler(), menuItem.Text);
        }
        private void ProductionPlansOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0009_UretimPlani.UretimPlanlari(), menuItem.Text);
        }
        private void MaterialsOpenEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0005_Malzemeler.Malzemeler(), menuItem.Text);
        }
        private void StorageAreasOpenEvent(object sender, EventArgs e)
        {
            //ElkonScada._0006_StokAlanlari.StokAlanlari StorageAreas = new ElkonScada._0006_StokAlanlari.StokAlanlari();
            //StorageAreas.Show();
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0006_StokAlanlari.StokAlanlari(), menuItem.Text);
        }
        private void TotalMaterialUsageReportOpenEvent(object sender, EventArgs e)
        {
          ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _0011_ToplamHarcananMalzemeRaporu.ToplamHarcananMalzemeRaporu(), menuItem.Text);
        }
        private void ES789_1_Click(object sender, EventArgs e)//Konfigürator sayfası buttonu
        {
           ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new _006_Konfigurator._00_SantralTipTemplate._001_SantralTipiSecimi(), menuItem.Text);
        }

        private void ES1201_1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            AddTabPage(new KalibrasyonSayfasi(), menuItem.Text);


        }
    }
}
