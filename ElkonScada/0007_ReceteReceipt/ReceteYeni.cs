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
using System.Threading;
using System.Globalization;

namespace ElkonScada._0007_ReceteReceipt
{
    public partial class ReceteYeni : Form
    {
        public ReceteYeni()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmddayanimsinifi = new SqlCommand("SELECT DayanimSinifi FROM DayanimSinifi", ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn);
        SqlCommand sqlCmdkivamsinifi = new SqlCommand("SELECT KivamSinifi FROM KivamSinifi", ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn);
        SqlCommand sqlCmddonakarsidayanikliliksinifi = new SqlCommand("SELECT DonaKarsiDayaniklilikSinifi FROM DonaKarsiDayaniklilikSinifi", ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn);
        SqlCommand sqlCmdsuyakarsidirencsinifi = new SqlCommand("SELECT SuyaKarsiDirencSinifi FROM SuyaKarsiDirencSinifi", ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn);
        SqlCommand sqlCmdyogunluksinifi = new SqlCommand("SELECT YogunlukSinifi FROM YogunlukSinifi", ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn);
        SqlCommand sqlCmdkloruricerigisinifi = new SqlCommand("SELECT KlorurIcerigiSinifi FROM KlorurIcerigiSinifi", ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn);
        SqlCommand sqlCmdbetontipi = new SqlCommand("SELECT BetonTipi FROM BetonTipi", ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn);
        SqlCommand sqlCmdcevreseletki = new SqlCommand("SELECT CevreselEtki FROM CevreselEtki", ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn);

        //COMBOBOX
        private void DayanimSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
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
        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        // // //
        private void kaydet_btn_click(object sender, EventArgs e)
        {

      
              
                string sql = "insert into Receteler(ReceteAdi,ReceteAciklama,ReceteAgrega1,ReceteAgrega2,ReceteAgrega3," +
                        "ReceteAgrega4,ReceteAgrega5,ReceteAgrega6,ReceteAgrega7,ReceteAgrega8,ReceteAgrega9,ReceteAgrega10," +
                           "ReceteCimento1, ReceteCimento2,ReceteCimento3, ReceteCimento4,ReceteCimento5, ReceteCimento6, ReceteCimento7, ReceteCimento8, ReceteCimento9 , ReceteCimento10," +
                           "ReceteSu1,ReceteSu2,ReceteSu3,ReceteSu4,ReceteSu5,ReceteSu6,ReceteSu7,ReceteSu8,ReceteSu9,ReceteSu10," +
                        "ReceteKatki1,ReceteKatki2,ReceteKatki3,ReceteKatki4,ReceteKatki5,ReceteKatki6,ReceteKatki7,ReceteKatki8,ReceteKatki9,ReceteKatki10," +
                        "ReceteCimentoGecikmeSuresi,ReceteKatkıGecikmeSuresi,ReceteSuGecikmeSuresi," +
                        "ReceteMikserBosaltmaSuresi,ReceteMikserKaristirmaSuresi,ReceteMikserKapakAcmaSuresi," +
                        "ReceteDurum, ReceteDayanimSinifi,ReceteKivamSinifi," +
                        "ReceteDonaKarsiDayaniklikSinifi,ReceteSuyaKarsiDirencSinifi," +
                        "ReceteYogunlukSinifi,ReceteBetonTipi,ReceteCevreselEtki," +
                        "ReceteKlorurIcerigiSinifi,ReceteMaxSuCimOrani,ReceteMinCimIcerigi," +
                        "ReceteMinBetonDayanimSinifi,ReceteMinBetonHavaIcerigi)" +
                        "values('" + receteaditxt.Text + "','" + aciklamatxt.Text + "','" + agrega1NupDown.Value + "','" + agrega2NupDown.Value +
                        "','" + agrega3NupDown.Value + "','" + agrega4NupDown.Value + "','" + agrega5NupDown.Value + "','" + agrega6NupDown.Value +
                        "','" + agrega7NupDown.Value + "','" + agrega8NupDown.Value + "','" + agrega9NupDown.Value + "','" + agrega10NupDown.Value +
                        "','" + cimento1NupDown.Value + "','" + cimento2NupDown.Value + "','" + cimento3NupDown.Value + "','" + cimento4NupDown.Value +
                        "','" + cimento5NupDown.Value + "','" + cimento6NupDown.Value + "','" + cimento7NupDown.Value + "','" + cimento8NupDown.Value +
                         "','" + cimento9NupDown.Value + "','" + cimento10NupDown.Value + "','" + su1NupDown.Value + "','" + su2NupDown.Value +
                        "','" + su3NupDown.Value + "','" + su4NupDown.Value + "','" + su5NupDown.Value + "','" + su6NupDown.Text + "','" + su7NupDown.Value +
                        "','" + su8NupDown.Value + "','" + su9NupDown.Value + "','" + su10NupDown.Value + "','" + katki1NupDown.Value +
                        "','" + katki2NupDown.Value + "','" + katki3NupDown.Value + "','" + katki4NupDown.Value + "','" + katki5NupDown.Value +
                        "','" + katki6NupDown.Value + "','" + katki7NupDown.Value + "','" + katki8NupDown.Value + "','" + katki9NupDown.Value + "','" + katki10NupDown.Value +
                        "','" + cimentoSureNupDown.Value + "','" + katkiSureNupDown.Value + "','" + suSureNupDown.Value + "','" + bosaltmaSureNupDown.Value +
                        "','" + karistirmaSureNupDown.Value + "','" + mikserKapakAcmaSureNupDown.Text + "','" + durumutxt.Text + "','" + dayanimsinifitxt.Text +
                        "','" + kivamsinifitxt.Text + "','" + donakarsidayanikliliktxt.Text + "','" + suyakarsidirenctxt.Text + "','" + yogunluksinifitxt.Text +
                        "','" + betontipitxt.Text + "','" + cevreseletkitxt.Text + "','" + kloruricerigisinifitxt.Text + "','" + maksimumsucimentooraniNupDown.Value +
                        "','" + minimumcimentoicerigitxt.Text + "','" + minimumbetondayanimsinifitxt.Text + "','" + betonunminimumhavaicerigitxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckReceteler.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckReceteler.DatabaseConn.State != ConnectionState.Open) SqlTableCheckReceteler.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckReceteler.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((Recete)Application.OpenForms["Recete"]).recetegetir();
                ((ElkonScada._0007_ReceteReceipt.Recete)Application.OpenForms["Recete"]).receteKonfig();
                this.Close();
       
          
           
        }

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
            Cimento7.Text = Localization.Localization.ES504_1;
            ES505_1.Text = Localization.Localization.ES505_1;
            ES506_1.Text = Localization.Localization.ES506_1;
            ES507_1.Text = Localization.Localization.ES507_1;
            Su1.Text = Localization.Localization.ES75_1;
            Su2.Text = Localization.Localization.ES76_1;
            Su3.Text = Localization.Localization.ES509_1;
            ES510_1.Text = Localization.Localization.ES510_1;
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
            ES1540_1.Text = Localization.Localization.ES1540_1;
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
            Agrega1.Text = Localization.Localization.Agrega1;
            Agrega2.Text = Localization.Localization.Agrega2;


        }
        //
        private void YeniRecete_Load(object sender, EventArgs e)
        {
            DilDegistir();

            //sqltablecheckdayanimsinifi veri çekme
            ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmddayanimsinifi.ExecuteReader();

            while (sqlReader.Read())
            {
                DayanimSinifiCbox.Items.Add(sqlReader["DayanimSinifi"].ToString().Trim());
            }

            ElkonScada._0007_01_DayanimSinifi.SqlTableCheckDayanimSinifi.DatabaseConn.Close();
            ////sqltablecheckkivamsinifi veri çekme
            ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn.Open();
            SqlDataReader sqlReader1 = sqlCmdkivamsinifi.ExecuteReader();

            while (sqlReader1.Read())
            {
                KivamSinifiCbox.Items.Add(sqlReader1["KivamSinifi"].ToString().Trim());
            }

            ElkonScada._0007_02_KivamSinifi.SqlTableCheckKivamSinifi.DatabaseConn.Close();
            //
            //sqltablecheckdonakarsidayanikliliksinifi veri çekme
            ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReader2 = sqlCmddonakarsidayanikliliksinifi.ExecuteReader();

            while (sqlReader2.Read())
            {
                DonaKarsiDayaniklilikSinifiCbox.Items.Add(sqlReader2["DonaKarsiDayaniklilikSinifi"].ToString().Trim());
            }

            ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi.SqlTableCheckDonaKarsiDS.DatabaseConn.Close();
            //
            //sqltablechecksuyakarsidirencsinifi veri çekme
            ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReader3 = sqlCmdsuyakarsidirencsinifi.ExecuteReader();

            while (sqlReader3.Read())
            {
                SuyaKarsiDirencSinifiCbox.Items.Add(sqlReader3["SuyaKarsiDirencSinifi"].ToString().Trim());
            }

            ElkonScada._0007_04_SuyaKarsiDirencSinifi.SqlTableCheckSuyaKarsiDS.DatabaseConn.Close();
            //
            //sqltablecheckyogunluksinifi veri çekme
            ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn.Open();
            SqlDataReader sqlReader4 = sqlCmdyogunluksinifi.ExecuteReader();

            while (sqlReader4.Read())
            {
                YogunlukSinifiCbox.Items.Add(sqlReader4["YogunlukSinifi"].ToString().Trim());
            }

            ElkonScada._0007_05_YogunlukSinifi.SqlTableCheckYogunlukSinifi.DatabaseConn.Close();
            //
            //sqltablecheckkloruricerigisinifi veri çekme
            ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Open();
            SqlDataReader sqlReader5 = sqlCmdkloruricerigisinifi.ExecuteReader();

            while (sqlReader5.Read())
            {
                KlorurIcerigiSinifiCbox.Items.Add(sqlReader5["KlorurIcerigiSinifi"].ToString().Trim());
            }

            ElkonScada._0007_06_KlorurIcerigiSinifi.SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Close();
            //
            //sqltablecheckbetontipi veri çekme
            ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn.Open();
            SqlDataReader sqlReader6 = sqlCmdbetontipi.ExecuteReader();

            while (sqlReader6.Read())
            {
                BetonTipiCbox.Items.Add(sqlReader6["BetonTipi"].ToString().Trim());
            }

            ElkonScada._0007_07_BetonTipi.SqlTableCheckBetonTipi.DatabaseConn.Close();
            //
            //sqltablecheckcevreseletki veri çekme
            ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn.Open();
            SqlDataReader sqlReader7 = sqlCmdcevreseletki.ExecuteReader();

            while (sqlReader7.Read())
            {
                CevreselEtkiCbox.Items.Add(sqlReader7["CevreselEtki"].ToString().Trim());
            }

            ElkonScada._0007_08_CevreselEtki.SqlTableCheckCevreselEtki.DatabaseConn.Close();
            //
        }

        private void ES735_1_Click(object sender, EventArgs e)
        {

        }

        private void ReceteYeni_Load(object sender, EventArgs e)
        {
            ReceteElemanlariVisible();
        }
        public void ReceteElemanlariVisible()
        {
            DurumuCbox.Items.Add(Localization.Localization.ES1363_1);
            DurumuCbox.Items.Add(Localization.Localization.ES1364_1);
            DurumuCbox.Text = Localization.Localization.ES1363_1;
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
        }

        private void receteaditxt_TextChanged(object sender, EventArgs e)
        {
            receteaditxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
        }

        private void ES442_1_Click(object sender, EventArgs e)
        {

        }
    }
}
