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

namespace ElkonScada._0009_UretimPlani
{
    public partial class UretimPlaniYeni : Form
    {
        public UretimPlaniYeni()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmdsipariser = new SqlCommand("SELECT SiparisNo FROM Siparisler", ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn);
        SqlCommand sqlCmdaraclar = new SqlCommand("SELECT AracPlakaNo FROM Araclar", ElkonScada._0002_Araclar.SqlTableCheckAraclar.DatabaseConn);
        SqlCommand sqlCmdsuruculer = new SqlCommand("SELECT SurucuAdiSoyadi FROM Suruculer", ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn);

        private void SiparisNoCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            siparisnotxt.Text = SiparisNoCbox.Text;
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Siparisler where SiparisNo = '" + SiparisNoCbox.SelectedItem.ToString() + "'", ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn);

            ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                aracplakanotxt.Text = sqlReader["FirmaAdi"].ToString().Trim();
                siparisnotxt.Text = sqlReader["SantiyeAdi"].ToString().Trim();
                surucuadisoyaditxt.Text = sqlReader["ReceteAdi"].ToString().Trim();

            }

            ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn.Close();
        }

        private void AracPlakaNoCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aracplakanotxt.Text = AracPlakaNoCbox.Text;
        }

        private void SurucuAdiSoyadiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            surucuadisoyaditxt.Text = SurucuAdiSoyadiCbox.Text;
        }
        private void tamam_btn_click(object sender, EventArgs e)
        {
            string sql = "insert into UretimPlani(SiparisNo ,UretimNo ,ToplamSiparis , AracPlakaNo ,SurucuAdiSoyadi, YapilanMiktar, KalanMiktar, SantiyeAdi, FirmaAdi, ReceteAdi, GirisMiktari," +
            "UretilecekMiktar , IadeUretimNo , IadeBetonMiktari , IadeBetonSinifi , IadeBetonAciklamasi)" +
              "values('" + siparisnotxt.Text + "', '" + "       " + "', '" + "       " + "' ,'" + aracplakanotxt.Text + "','" + surucuadisoyaditxt.Text + "','" + yapilantxt.Text + "','" + kalantxt.Text +
              "','" + siparisnotxt.Text + "','" + aracplakanotxt.Text + "','" + surucuadisoyaditxt.Text + "','" + girismiktaritxt.Text + "','" + uretilecekmiktartxt.Text + "','" + iadeuretimnotxt.Text +
              "','" + iadebetonmiktaritxt.Text + "','" + iadebetonsinifitxt.Text + "','" + iadebetonaciklamasitxt.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, SqlTableCheckUretimPlani.DatabaseConn);
            // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
            if (SqlTableCheckUretimPlani.DatabaseConn.State != ConnectionState.Open) SqlTableCheckUretimPlani.DatabaseConn.Open();
            cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
            SqlTableCheckUretimPlani.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
            ((UretimPlanlari)Application.OpenForms["UretimPlanlari"]).uretimplanigetir();
            this.Close();
        }

        //dil değiştirme
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
            ES1845_1.Text = Localization.Localization.ES1845_1;
            ES2064_0.Text = Localization.Localization.ES2064_0;
            ES2065_0.Text = Localization.Localization.ES2065_0;
            ES2066_0.Text = Localization.Localization.ES2066_0;
            ES2067_0.Text = Localization.Localization.ES2067_0;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES404_1.Text = Localization.Localization.ES404_1;
            ES810_1.Text = Localization.Localization.ES810_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES842_1.Text = Localization.Localization.ES842_1;
            ES848_1.Text = Localization.Localization.ES848_1;
            ES949_1.Text = Localization.Localization.ES949_1;
            ES950_1.Text = Localization.Localization.ES950_1;
            ES952_1.Text = Localization.Localization.ES952_1;
            ES955_1.Text = Localization.Localization.ES955_1;
            ES956_1.Text = Localization.Localization.ES956_1;
            sirano.HeaderText = Localization.Localization.sirano;
            siparisno.HeaderText = Localization.Localization.siparisno;
            firmaadi.HeaderText = Localization.Localization.firmaadi;
            santiyeadi.HeaderText = Localization.Localization.santiyeadi;
            siparismiktari.HeaderText = Localization.Localization.siparismiktari;
            receteadi.HeaderText = Localization.Localization.receteadi;
            yapilanmiktar.HeaderText = Localization.Localization.yapilanmiktar;
            kalanmiktar.HeaderText = Localization.Localization.kalanmiktar;
        }
        //
        private void YeniPlan_Load(object sender, EventArgs e)
        {
            DilDegistir();
            
            //sqltablechecksiparislerden veri çekme
            ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmdsipariser.ExecuteReader();

            while (sqlReader.Read())
            {
                SiparisNoCbox.Items.Add(sqlReader["SiparisNo"].ToString().Trim());
            }

            ElkonScada._0008_Siparisler.SqlTableCheckSiparisler.DatabaseConn.Close();
            //
            //sqltablecheckaraclardan veri çekme
            ElkonScada._0002_Araclar.SqlTableCheckAraclar.DatabaseConn.Open();
            SqlDataReader sqlReader1 = sqlCmdaraclar.ExecuteReader();

            while (sqlReader1.Read())
            {
                AracPlakaNoCbox.Items.Add(sqlReader1["AracPlakaNo"].ToString().Trim());
            }

            ElkonScada._0002_Araclar.SqlTableCheckAraclar.DatabaseConn.Close();
            //
            //sqltablechecksuruculerden veri çekme
            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Open();
            SqlDataReader sqlReader2 = sqlCmdsuruculer.ExecuteReader();

            while (sqlReader2.Read())
            {
                SurucuAdiSoyadiCbox.Items.Add(sqlReader2["SurucuAdiSoyadi"].ToString().Trim());
            }

            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Close();
            
            //
        }

        private void siparislerdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
