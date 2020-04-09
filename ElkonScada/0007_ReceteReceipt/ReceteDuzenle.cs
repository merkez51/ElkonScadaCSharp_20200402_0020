using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace ElkonScada._0007_ReceteReceipt
{
    public partial class ReceteDuzenle : Form
    {
        public ReceteDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdReceteler = new SqlCommand("SELECT ReceteAdi FROM Receteler", SqlTableCheckReceteler.DatabaseConn);
        SqlCommand sqlCmdDayanimSinifi = new SqlCommand("SELECT DayanimSinifi FROM DayanimSinifi", ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn);
        SqlCommand sqlCmdKivamSinifi = new SqlCommand("SELECT KivamSinifi FROM KivamSinifi", ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn);
        SqlCommand sqlCmdDonaKarsiDayaniklilikSinifi = new SqlCommand("SELECT DonaKarsiDayaniklilikSinifi FROM DonaKarsiDayaniklilikSinifi", ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn);
        SqlCommand sqlCmdSuyaKarsiDirencSinifi = new SqlCommand("SELECT SuyaKarsiDirencSinifi FROM SuyaKarsiDirencSinifi", ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn);
        SqlCommand sqlCmdYogunlukSinifi = new SqlCommand("SELECT YogunlukSinifi FROM YogunlukSinifi", ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn);
        SqlCommand sqlCmdKlorurIcerigiSinifi = new SqlCommand("SELECT KlorurIcerigiSinifi FROM KlorurIcerigiSinifi", ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn);
        SqlCommand sqlCmdBetonTipi = new SqlCommand("SELECT BetonTipi FROM BetonTipi", ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn);
        SqlCommand sqlCmdCevreselEtki = new SqlCommand("SELECT CevreselEtki FROM CevreselEtki", ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn);


        //combobox

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        private void DayanimSinifiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dayanimsinifitxt.Text = DayanimSinifiCbox.Text;
        }

        private void KivamSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kivamsinifitxt.Text = KivamSinifiCbox.Text;
        }

        private void DonaKarsiDayaniklilikSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            donakarsidayanikliliktxt.Text = DonaKarsiDayaniklilikSinifiCbox.Text;
        }

        private void SuyaKarsiDirencSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            suyakarsidirenctxt.Text = SuyaKarsiDirencSinifiCbox.Text;
        }

        private void YogunlukSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yogunluksinifitxt.Text = YogunlukSinifiCbox.Text;
        }

        private void KlorurIcerigiSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kloruricerigisinifitxt.Text = KlorurIcerigiSinifiCbox.Text;
        }

        private void BetonTipiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            betontipitxt.Text = BetonTipiCbox.Text;
        }

        private void CevreselEtkiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cevreseletkitxt.Text = CevreselEtkiCbox.Text;
        }

        private void ReceteAdiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }


        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            string sqlguncelle = "update Receteler set ReceteAciklama='" + aciklamatxt.Text +
                "',ReceteAgrega1='" + agrega1NupDown.Value + "',ReceteAgrega2='" + agrega2NupDown.Value +
                "',ReceteAgrega3='" + agrega3NupDown.Value + "',ReceteAgrega4='" + agrega4NupDown.Value +
                "',ReceteAgrega5='" + agrega5NupDown.Value + "',ReceteAgrega6='" + agrega6NupDown.Value +
                "',ReceteAgrega7='" + agrega7NupDown.Value + "',ReceteAgrega8='" + agrega8NupDown.Value +
                "',ReceteAgrega9='" + agrega9NupDown.Value + "',ReceteAgrega10='" + agrega10NupDown.Value +
                "',ReceteCimento1='" + cimento1NupDown.Value + "',ReceteCimento2='" + cimento2NupDown.Value +
                "',ReceteCimento3='" + cimento3NupDown.Value + "',ReceteCimento4='" + cimento4NupDown.Value +
                "',ReceteCimento5='" + cimento5NupDown.Value + "',ReceteCimento6='" + cimento6NupDown.Value +
                "',ReceteCimento7='" + cimento7NupDown.Value + "',ReceteCimento8='" + cimento8NupDown.Value +
                "',ReceteCimento9='" + cimento9NupDown.Value + "',ReceteCimento10='" + cimento10NupDown.Value +
                "',ReceteSu1='" + su1NupDown.Value + "',ReceteSu2='" + su2NupDown.Value +
                "',ReceteSu3='" + su3NupDown.Value + "',ReceteSu4='" + su4NupDown.Value +
                "',ReceteSu5='" + su5NupDown.Value + "',ReceteSu6='" + su6NupDown.Value +
                "',ReceteSu7='" + su7NupDown.Value + "',ReceteSu8='" + su8NupDown.Value +
                "',ReceteSu9='" + su9NupDown.Value + "',ReceteSu10='" + su10NupDown.Value +
                "',ReceteKatki1='" + katki1NupDown.Value + "',ReceteKatki2='" + katki2NupDown.Value +
                "',ReceteKatki3='" + katki3NupDown.Value + "',ReceteKatki4='" + katki4NupDown.Value +
                "',ReceteKatki5='" + katki5NupDown.Value + "',ReceteKatki6='" + katki6NupDown.Value +
                "',ReceteKatki7='" + katki7NupDown.Value + "',ReceteKatki8='" + katki8NupDown.Value +
                "',ReceteKatki9='" + katki9NupDown.Value + "',ReceteKatki10='" + katki10NupDown.Value +
                "',ReceteCimentoGecikmeSuresi='" + cimentoSureNupDown.Value + "',ReceteKatkıGecikmeSuresi='" + katkiSureNupDown.Value +
                "',ReceteSuGecikmeSuresi='" + suSureNupDown.Value + "',ReceteMikserBosaltmaSuresi='" + bosaltmaSureNupDown.Value +
                "',ReceteMikserKaristirmaSuresi='" + karistirmaSureNupDown.Value + "',ReceteMikserKapakAcmaSuresi='" + mikserKapakAcmaSureNupDown.Value +
                "',ReceteDurum='" + durumutxt.Text + "',ReceteDayanimSinifi='" + dayanimsinifitxt.Text +
                "',ReceteKivamSinifi='" + kivamsinifitxt.Text + "',ReceteDonaKarsiDayaniklikSinifi='" + donakarsidayanikliliktxt.Text +
                "',ReceteSuyaKarsiDirencSinifi='" + suyakarsidirenctxt.Text + "',ReceteYogunlukSinifi='" + yogunluksinifitxt.Text +
                "',ReceteBetonTipi='" + betontipitxt.Text + "',ReceteCevreselEtki='" + cevreseletkitxt.Text +
                "',ReceteKlorurIcerigiSinifi='" + kloruricerigisinifitxt.Text + "',ReceteMaxSuCimOrani='" + maksimumsucimentooraniNupDown.Value +
                "',ReceteMinCimIcerigi='" + minimumcimentoicerigitxt.Text + "',ReceteMinBetonDayanimSinifi='" + minimumbetondayanimsinifitxt.Text +
                "',ReceteMinBetonHavaIcerigi='" + betonunminimumhavaicerigitxt.Text + "' where ReceteAdi = '" + ReceteIsmi.ToString() + "' ";

            SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckReceteler.DatabaseConn);

            if (SqlTableCheckReceteler.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
            {
                SqlTableCheckReceteler.DatabaseConn.Open();
            }
            Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            SqlTableCheckReceteler.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
            ((Recete)Application.OpenForms["Recete"]).recetegetir();
            this.Close();
        }
        //
        //Dil değiştirme
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
            ES441_1.Text = Localization.Localization.ES441_1;
            ES442_1.Text = Localization.Localization.ES442_1;
            ES443_1.Text = Localization.Localization.ES443_1;
            ES444_1.Text = Localization.Localization.ES444_1;
            ES211_1.Text = Localization.Localization.ES211_1;
            Agrega1.Text = Localization.Localization.ES194_1;
            Agrega2.Text = Localization.Localization.ES197_1;
            Agrega3.Text = Localization.Localization.ES198_1;
            Agrega4.Text = Localization.Localization.ES199_1;
            Agrega5.Text = Localization.Localization.ES493_1;
            Agrega6.Text = Localization.Localization.ES494_1;
            ES495_1.Text = Localization.Localization.ES495_1;
            ES495_1.Text = Localization.Localization.ES495_1;
            ES497_1.Text = Localization.Localization.ES497_1;
            ES498_1.Text = Localization.Localization.ES498_1;
            Cimento1.Text = Localization.Localization.ES220_1;
            Cimento2.Text = Localization.Localization.ES499_1;
            Cimento3.Text = Localization.Localization.ES500_1;
            Cimento4.Text = Localization.Localization.ES501_1;
            Cimento5.Text = Localization.Localization.ES502_1;
            Cimento6.Text = Localization.Localization.ES503_1;
            ES504_1.Text = Localization.Localization.ES504_1;
            ES505_1.Text = Localization.Localization.ES505_1;
            ES506_1.Text = Localization.Localization.ES506_1;
            ES507_1.Text = Localization.Localization.ES507_1;
            Su1.Text = Localization.Localization.ES75_1;
            Su2.Text = Localization.Localization.ES76_1;
            Su3.Text = Localization.Localization.ES509_1;
            Su4.Text = Localization.Localization.ES510_1;
            ES511_1.Text = Localization.Localization.ES511_1;
            ES512_1.Text = Localization.Localization.ES512_1;
            ES513_1.Text = Localization.Localization.ES513_1;
            ES514_1.Text = Localization.Localization.ES514_1;
            ES515_1.Text = Localization.Localization.ES515_1;
            ES516_1.Text = Localization.Localization.ES516_1;
            Katki1.Text = Localization.Localization.ES1379_1;
            Katki2.Text = Localization.Localization.ES1380_1;
            Katki3.Text = Localization.Localization.ES1381_1;
            Katki4.Text = Localization.Localization.ES1382_1;
            Katki5.Text = Localization.Localization.ES1383_1;
            Katki6.Text = Localization.Localization.ES522_1;
            ES523_1.Text = Localization.Localization.ES523_1;
            ES524_1.Text = Localization.Localization.ES524_1;
            ES525_1.Text = Localization.Localization.ES525_1;
            ES526_1.Text = Localization.Localization.ES526_1;
            ES210_1.Text = Localization.Localization.ES210_1;
            ES208_1.Text = Localization.Localization.ES208_1;
            ES99_1.Text = Localization.Localization.ES99_1;
            ES98_1.Text = Localization.Localization.ES98_1;
            ES212_1.Text = Localization.Localization.ES212_1;
            ES206_1.Text = Localization.Localization.ES206_1;
            ES207_1.Text = Localization.Localization.ES207_1;
            ES2009_0.Text = Localization.Localization.ES2009_0;
            ES1538_1.Text = Localization.Localization.ES1538_1;
            ES1539_1.Text = Localization.Localization.ES1539_1;
            ES1539_1.Text = Localization.Localization.ES1540_1;
            ES1541_1.Text = Localization.Localization.ES1541_1;
            ES1542_1.Text = Localization.Localization.ES1542_1;
            ES1543_1.Text = Localization.Localization.ES1543_1;
            ES1544_1.Text = Localization.Localization.ES1544_1;
            ES1947_1.Text = Localization.Localization.ES1947_1;
            ES2136_0.Text = Localization.Localization.ES2136_0;
            ES1545_1.Text = Localization.Localization.ES1545_1;
            ES1546_1.Text = Localization.Localization.ES1546_1;
            ES1547_1.Text = Localization.Localization.ES1547_1;
            ES1548_1.Text = Localization.Localization.ES1548_1;
            ES1549_0.Text = Localization.Localization.ES1549_0;
            ES735_1.Text = Localization.Localization.ES735_1;
        }
        //
        public void ReceteElemanlariVisible()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = false;
                    agrega2NupDown.Visible = false;

                    Agrega3.Visible = false;
                    agrega3NupDown.Visible = false;

                    Agrega4.Visible = false;
                    agrega4NupDown.Visible = false;

                    Agrega5.Visible = false;
                    agrega5NupDown.Visible = false;

                    Agrega6.Visible = false;
                    agrega6NupDown.Visible = false;



                    break;
                case 2:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = true;
                    agrega2NupDown.Visible = true;

                    Agrega3.Visible = false;
                    agrega3NupDown.Visible = false;

                    Agrega4.Visible = false;
                    agrega4NupDown.Visible = false;

                    Agrega5.Visible = false;
                    agrega5NupDown.Visible = false;

                    Agrega6.Visible = false;
                    agrega6NupDown.Visible = false;

                    break;
                case 3:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = true;
                    agrega2NupDown.Visible = true;

                    Agrega3.Visible = true;
                    agrega3NupDown.Visible = true;

                    Agrega4.Visible = false;
                    agrega4NupDown.Visible = false;

                    Agrega5.Visible = false;
                    agrega5NupDown.Visible = false;

                    Agrega6.Visible = false;
                    agrega6NupDown.Visible = false;

                    break;
                case 4:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = true;
                    agrega2NupDown.Visible = true;

                    Agrega3.Visible = true;
                    agrega3NupDown.Visible = true;

                    Agrega4.Visible = true;
                    agrega4NupDown.Visible = true;

                    Agrega5.Visible = false;
                    agrega5NupDown.Visible = false;

                    Agrega6.Visible = false;
                    agrega6NupDown.Visible = false;

                    break;
                case 5:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = true;
                    agrega2NupDown.Visible = true;

                    Agrega3.Visible = true;
                    agrega3NupDown.Visible = true;

                    Agrega4.Visible = true;
                    agrega4NupDown.Visible = true;

                    Agrega5.Visible = true;
                    agrega5NupDown.Visible = true;

                    Agrega6.Visible = false;
                    agrega6NupDown.Visible = false;

                    break;
                case 6:
                    Agrega1.Visible = true;
                    agrega1NupDown.Visible = true;

                    Agrega2.Visible = true;
                    agrega2NupDown.Visible = true;

                    Agrega3.Visible = true;
                    agrega3NupDown.Visible = true;

                    Agrega4.Visible = true;
                    agrega4NupDown.Visible = true;

                    Agrega5.Visible = true;
                    agrega5NupDown.Visible = true;

                    Agrega6.Visible = true;
                    agrega6NupDown.Visible = true;

                    break;

                default:
                    break;
            }
            //-------------------------------------//
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi)
            {
                case 1:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = false;
                    cimento2NupDown.Visible = false;

                    Cimento3.Visible = false;
                    cimento3NupDown.Visible = false;

                    Cimento4.Visible = false;
                    cimento4NupDown.Visible = false;

                    Cimento5.Visible = false;
                    cimento5NupDown.Visible = false;

                    Cimento6.Visible = false;
                    cimento6NupDown.Visible = false;



                    break;
                case 2:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = true;
                    cimento2NupDown.Visible = true;

                    Cimento3.Visible = false;
                    cimento3NupDown.Visible = false;

                    Cimento4.Visible = false;
                    cimento4NupDown.Visible = false;

                    Cimento5.Visible = false;
                    cimento5NupDown.Visible = false;

                    Cimento6.Visible = false;
                    cimento6NupDown.Visible = false;

                    break;
                case 3:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = true;
                    cimento2NupDown.Visible = true;

                    Cimento3.Visible = true;
                    cimento3NupDown.Visible = true;

                    Cimento4.Visible = false;
                    cimento4NupDown.Visible = false;

                    Cimento5.Visible = false;
                    cimento5NupDown.Visible = false;

                    Cimento6.Visible = false;
                    cimento6NupDown.Visible = false;

                    break;
                case 4:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = true;
                    cimento2NupDown.Visible = true;

                    Cimento3.Visible = true;
                    cimento3NupDown.Visible = true;

                    Cimento4.Visible = true;
                    cimento5NupDown.Visible = true;

                    Cimento5.Visible = false;
                    agrega1NupDown.Visible = false;

                    Cimento6.Visible = false;
                    cimento6NupDown.Visible = false;

                    break;
                case 5:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = true;
                    cimento2NupDown.Visible = true;

                    Cimento3.Visible = true;
                    cimento3NupDown.Visible = true;

                    Cimento4.Visible = true;
                    cimento4NupDown.Visible = true;

                    Cimento5.Visible = true;
                    cimento5NupDown.Visible = true;

                    Cimento6.Visible = false;
                    cimento6NupDown.Visible = false;

                    break;
                case 6:
                    Cimento1.Visible = true;
                    cimento1NupDown.Visible = true;

                    Cimento2.Visible = true;
                    cimento2NupDown.Visible = true;

                    Cimento3.Visible = true;
                    cimento3NupDown.Visible = true;

                    Cimento4.Visible = true;
                    cimento4NupDown.Visible = true;

                    Cimento5.Visible = true;
                    cimento5NupDown.Visible = true;

                    Cimento6.Visible = true;
                    cimento6NupDown.Visible = true;

                    break;

                default:
                    break;
            }
            //-------------------------------------//
            switch (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
            {
                case 1:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = false;
                    katki2NupDown.Visible = false;

                    Katki3.Visible = false;
                    katki3NupDown.Visible = false;

                    Katki4.Visible = false;
                    katki4NupDown.Visible = false;

                    Katki5.Visible = false;
                    katki5NupDown.Visible = false;

                    Katki6.Visible = false;
                    katki6NupDown.Visible = false;



                    break;
                case 2:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = true;
                    katki2NupDown.Visible = true;

                    Katki3.Visible = false;
                    katki3NupDown.Visible = false;

                    Katki4.Visible = false;
                    katki4NupDown.Visible = false;

                    Katki5.Visible = false;
                    katki5NupDown.Visible = false;

                    Katki6.Visible = false;
                    katki6NupDown.Visible = false;

                    break;
                case 3:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = true;
                    katki2NupDown.Visible = true;

                    Katki3.Visible = true;
                    katki3NupDown.Visible = true;

                    Katki4.Visible = false;
                    katki4NupDown.Visible = false;

                    Katki5.Visible = false;
                    katki5NupDown.Visible = false;

                    Katki6.Visible = false;
                    katki6NupDown.Visible = false;

                    break;
                case 4:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = true;
                    katki2NupDown.Visible = true;

                    Katki3.Visible = true;
                    katki3NupDown.Visible = true;

                    Katki4.Visible = true;
                    katki4NupDown.Visible = true;

                    Katki5.Visible = false;
                    katki5NupDown.Visible = false;

                    Katki6.Visible = false;
                    katki6NupDown.Visible = false;

                    break;
                case 5:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = true;
                    katki2NupDown.Visible = true;

                    Katki3.Visible = true;
                    katki3NupDown.Visible = true;

                    Katki4.Visible = true;
                    katki4NupDown.Visible = true;

                    Katki5.Visible = true;
                    katki5NupDown.Visible = true;

                    Katki6.Visible = false;
                    katki6NupDown.Visible = false;

                    break;
                case 6:
                    Katki1.Visible = true;
                    katki1NupDown.Visible = true;

                    Katki2.Visible = true;
                    katki2NupDown.Visible = true;

                    Katki3.Visible = true;
                    katki3NupDown.Visible = true;

                    Katki4.Visible = true;
                    katki4NupDown.Visible = true;

                    Katki5.Visible = true;
                    katki5NupDown.Visible = true;

                    Katki6.Visible = true;
                    katki6NupDown.Visible = true;

                    break;

                default:
                    break;
            }
            //-------------------------------------//
            switch (Properties.S000_Konfigrator_Tag.Default.SuSayisi)
            {
                case 1:
                    Su1.Visible = true;
                    su1NupDown.Visible = true;

                    Su2.Visible = false;
                    su2NupDown.Visible = false;

                    Su3.Visible = false;
                    su3NupDown.Visible = false;

              



                    break;
                case 2:
                    Su1.Visible = true;
                    su1NupDown.Visible = true;

                    Su2.Visible = true;
                    su2NupDown.Visible = true;

                    Su3.Visible = false;
                    su3NupDown.Visible = false;

                

                    break;
                case 3:
                    Su1.Visible = true;
                    su1NupDown.Visible = true;

                    Su2.Visible = true;
                    su2NupDown.Visible = true;

                    Su3.Visible = true;
                    su3NupDown.Visible = true;



                    break;
                default:
                    break;
            }
            //MessageBox.Show(((ElkonScada._0007_ReceteReceipt.Recete)Application.OpenForms["Recete"]).recetelerdatagridview.CurrentCell.RowIndex.ToString());
           int RowCount = ((ElkonScada._0007_ReceteReceipt.Recete)Application.OpenForms["Recete"]).recetelerdatagridview.CurrentCell.RowIndex;
            ReceteIsmi.Text = ((_0007_ReceteReceipt.Recete)Application.OpenForms["Recete"]).recetelerdatagridview.Rows[RowCount].Cells[2].Value.ToString();

            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Receteler where ReceteAdi = '" + ReceteIsmi.Text + "'", SqlTableCheckReceteler.DatabaseConn);
            ReceteIsmi.Enabled = false;
            SqlTableCheckReceteler.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {
                aciklamatxt.Text = sqlReader["ReceteAciklama"].ToString().Trim();
                agrega1NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega1"]);
                agrega2NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega2"]);
                agrega3NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega3"]);
                agrega4NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega4"]);
                agrega5NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega5"]);
                agrega6NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega6"]);
                agrega7NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega7"]);
                agrega8NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega8"]);
                agrega9NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega9"]);
                agrega10NupDown.Value = Convert.ToDecimal(sqlReader["ReceteAgrega10"]);

                cimento1NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento1"]);
                cimento2NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento2"]);
                cimento3NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento3"]);
                cimento4NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento4"]);
                cimento5NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento5"]);
                cimento6NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento6"]);
                cimento7NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento7"]);
                cimento8NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento8"]);
                cimento9NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento9"]);
                cimento10NupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimento10"]);

                su1NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu1"]);
                su2NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu2"]);
                su3NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu3"]);
                su4NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu4"]);
                su5NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu5"]);
                su6NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu6"]);
                su7NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu7"]);
                su8NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu8"]);
                su9NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu9"]);
                su10NupDown.Value = Convert.ToDecimal(sqlReader["ReceteSu10"]);

                katki1NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki1"]);
                katki2NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki2"]);
                katki3NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki3"]);
                katki4NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki4"]);
                katki5NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki5"]);
                katki6NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki6"]);
                katki7NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki7"]);
                katki8NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki8"]);
                katki9NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki9"]);
                katki10NupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatki10"]);

                cimentoSureNupDown.Value = Convert.ToDecimal(sqlReader["ReceteCimentoGecikmeSuresi"]);
                katkiSureNupDown.Value = Convert.ToDecimal(sqlReader["ReceteKatkıGecikmeSuresi"]);
                suSureNupDown.Value = Convert.ToDecimal(sqlReader["ReceteSuGecikmeSuresi"]);
                bosaltmaSureNupDown.Value = Convert.ToDecimal(sqlReader["ReceteMikserBosaltmaSuresi"]);
                karistirmaSureNupDown.Value = Convert.ToDecimal(sqlReader["ReceteMikserKaristirmaSuresi"]);
                mikserKapakAcmaSureNupDown.Text = sqlReader["ReceteMikserKapakAcmaSuresi"].ToString().Trim();
                durumutxt.Text = sqlReader["ReceteDurum"].ToString().Trim();
                dayanimsinifitxt.Text = sqlReader["ReceteDayanimSinifi"].ToString().Trim();
                kivamsinifitxt.Text = sqlReader["ReceteKivamSinifi"].ToString().Trim();
                donakarsidayanikliliktxt.Text = sqlReader["ReceteDonaKarsiDayaniklikSinifi"].ToString().Trim();
                suyakarsidirenctxt.Text = sqlReader["ReceteSuyaKarsiDirencSinifi"].ToString().Trim();
                yogunluksinifitxt.Text = sqlReader["ReceteYogunlukSinifi"].ToString().Trim();
                betontipitxt.Text = sqlReader["ReceteBetonTipi"].ToString().Trim();
                cevreseletkitxt.Text = sqlReader["ReceteCevreselEtki"].ToString().Trim();
                kloruricerigisinifitxt.Text = sqlReader["ReceteKlorurIcerigiSinifi"].ToString().Trim();
                maksimumsucimentooraniNupDown.Value = Convert.ToDecimal(sqlReader["ReceteMaxSuCimOrani"]);
                minimumcimentoicerigitxt.Text = sqlReader["ReceteMinCimIcerigi"].ToString().Trim();
                minimumbetondayanimsinifitxt.Text = sqlReader["ReceteMinBetonDayanimSinifi"].ToString().Trim();
                betonunminimumhavaicerigitxt.Text = sqlReader["ReceteMinBetonHavaIcerigi"].ToString().Trim();

            }

            SqlTableCheckReceteler.DatabaseConn.Close();
           
            DurumuCbox.Items.Add(Localization.Localization.ES1363_1);
            DurumuCbox.Items.Add(Localization.Localization.ES1364_1);
            MessageBox.Show(durumutxt.Text);
            DurumuCbox.Text = durumutxt.Text;

        }

        private void ReceteDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            //receteAdi Çekme
            SqlTableCheckReceteler.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmdReceteler.ExecuteReader();

            while (sqlReader.Read())
            {
                
            }

            SqlTableCheckReceteler.DatabaseConn.Close();
            // 
            //DayanimSinifi Çekme
            try
            {
                ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn.Open();
                SqlDataReader sqlReaderDayanimSinifi = sqlCmdDayanimSinifi.ExecuteReader();

                while (sqlReaderDayanimSinifi.Read())
                {
                    DayanimSinifiCbox.Items.Add(sqlReaderDayanimSinifi["DayanimSinifi"].ToString().Trim());
                }

                ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn.Close();
            }
            catch (Exception)
            {

                DayanimSinifiCbox.Items.Add("-");
            }

            //
            //KivamSinifi Çekme
            try
            {
                ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn.Open();
                SqlDataReader sqlReaderKivamSinifi = sqlCmdKivamSinifi.ExecuteReader();

                while (sqlReaderKivamSinifi.Read())
                {
                    KivamSinifiCbox.Items.Add(sqlReaderKivamSinifi["KivamSinifi"].ToString().Trim());
                }

                ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn.Close();
            }
            catch (Exception)
            {

                KivamSinifiCbox.Items.Add("-");
            }
          
            //
            //DonaKarsiDayaniklilikSinifi Çekme
            try
            {
                ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn.Open();
                SqlDataReader sqlReaderDonaKarsiDayaniklilikSinifi = sqlCmdDonaKarsiDayaniklilikSinifi.ExecuteReader();

                while (sqlReaderDonaKarsiDayaniklilikSinifi.Read())
                {
                    DonaKarsiDayaniklilikSinifiCbox.Items.Add(sqlReaderDonaKarsiDayaniklilikSinifi["DonaKarsiDayaniklilikSinifi"].ToString().Trim());
                }

                ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn.Close();
            }
            catch (Exception)
            {

                DonaKarsiDayaniklilikSinifiCbox.Items.Add("-");
            }

            //
            //SuyaKarsiDirencSinifi Çekme
            try
            {
                ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
                SqlDataReader sqlReaderSuyaKarsiDirencSinifi = sqlCmdSuyaKarsiDirencSinifi.ExecuteReader();

                while (sqlReaderSuyaKarsiDirencSinifi.Read())
                {
                    SuyaKarsiDirencSinifiCbox.Items.Add(sqlReaderSuyaKarsiDirencSinifi["SuyaKarsiDirencSinifi"].ToString().Trim());
                }

                ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn.Close();
            }
            catch (Exception)
            {
                SuyaKarsiDirencSinifiCbox.Items.Add("-");
            }

            //
            //YogunlukSinifi Çekme
            try
            {
                ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn.Open();
                SqlDataReader sqlReaderYogunlukSinifi = sqlCmdYogunlukSinifi.ExecuteReader();

                while (sqlReaderYogunlukSinifi.Read())
                {
                    YogunlukSinifiCbox.Items.Add(sqlReaderYogunlukSinifi["YogunlukSinifi"].ToString().Trim());
                }

                ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn.Close();
            }
            catch (Exception)
            {

                YogunlukSinifiCbox.Items.Add("-");
            }

            //
            //KlorurIcerigiSinifi Çekme
            try
            {
                ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Open();
                SqlDataReader sqlReaderKlorurIcerigiSinifi = sqlCmdKlorurIcerigiSinifi.ExecuteReader();

                while (sqlReaderKlorurIcerigiSinifi.Read())
                {
                    KlorurIcerigiSinifiCbox.Items.Add(sqlReaderKlorurIcerigiSinifi["KlorurIcerigiSinifi"].ToString().Trim());
                }

                ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Close();
            }
            catch (Exception)
            {
                KlorurIcerigiSinifiCbox.Items.Add("-");
            }

            //
            //BetonTipi Çekme
            try
            {
                ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn.Open();
                SqlDataReader sqlReaderBetonTipi = sqlCmdBetonTipi.ExecuteReader();

                while (sqlReaderBetonTipi.Read())
                {
                    BetonTipiCbox.Items.Add(sqlReaderBetonTipi["BetonTipi"].ToString().Trim());
                }

                ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn.Close();
            }
            catch (Exception)
            {
                BetonTipiCbox.Items.Add("-");
            }

            //
            //CevreselEtki Çekme
            try
            {
                ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn.Open();
                SqlDataReader sqlReaderCevreselEtki = sqlCmdCevreselEtki.ExecuteReader();

                while (sqlReaderCevreselEtki.Read())
                {
                    CevreselEtkiCbox.Items.Add(sqlReaderCevreselEtki["CevreselEtki"].ToString().Trim());
                }

                ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn.Close();
            }
            catch (Exception)
            {
                CevreselEtkiCbox.Items.Add("-");
            }
            ReceteElemanlariVisible();

            //
        }
    }
}

