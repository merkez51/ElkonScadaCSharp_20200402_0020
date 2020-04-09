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
using System.Data;

namespace ElkonScada._0002_Araclar
{
    public partial class AracYeni : Form
    {

        public AracYeni()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdfirmalar = new SqlCommand("SELECT FirmaAdi FROM Firmalar", ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn);
        SqlCommand sqlCmdsuruculer = new SqlCommand("SELECT SurucuAdiSoyadi FROM Suruculer", ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn);
        //Cboxları textlere yazdırma
        private void FirmaAdiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaaditxt.Text = FirmaAdiCbox.Text;
        }
        private void SurucuAdiSoyadiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            surucuadisoyaditxt.Text = SurucuAdiSoyadiCbox.Text;
        }
        private void AracTipiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aractipitxt.Text = AracTipiCbox.Text;
        }
        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        //

        private void tamam_btn_click(object sender, EventArgs e)
        {
            if (aracplakanotxt.Text != "" & durumutxt.Text != "" & firmaaditxt.Text != "" & surucuadisoyaditxt.Text != "")
            {
                string sql = "insert into Araclar(AracPlakaNo,FirmaAdi,SurucuAdiSoyadi,Kapasite,AracTipi,AracMarkasi,Durumu)" +
                         "values('" + aracplakanotxt.Text + "','" + firmaaditxt.Text + "','" + surucuadisoyaditxt.Text + "','" + kapasitetxt.Text +
                         "','" + aractipitxt.Text + "','" + aracmarkasitxt.Text + "','" + durumutxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckAraclar.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckAraclar.DatabaseConn.State != ConnectionState.Open) SqlTableCheckAraclar.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckAraclar.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((Araclar)Application.OpenForms["Araclar"]).aracgetir();
                this.Close();
            }
           if(aracplakanotxt.Text == "")
            errorProvider1.SetError(aracplakanotxt,hatamsgarac.Text);
            if (durumutxt.Text == "")
            errorProvider1.SetError(durumutxt, hatamsgarac.Text);
            if(firmaaditxt.Text == "")
            errorProvider1.SetError(firmaaditxt, hatamsgarac.Text);
            if(surucuadisoyaditxt.Text != "")
            errorProvider1.SetError(surucuadisoyaditxt, hatamsgarac.Text);

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
            ES1534_1.Text = Localization.Localization.ES1534_1;
            ES2061_0.Text = Localization.Localization.ES2061_0;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES404_1.Text = Localization.Localization.ES404_1;
            ES437_1.Text = Localization.Localization.ES437_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES842_1.Text = Localization.Localization.ES842_1;
            hatamsgarac.Text = Localization.Localization.hatamsgarac;
        }
        //

        private void YeniArac_Load(object sender, EventArgs e)
        {
            DilDegistir();
            switch (Localization.DilSettings.Default.Dil)
            {

                case "ingilizce":

                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("active");
                    DurumuCbox.Items.Add("passive");
                    break;
                case "turkce":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktif");
                    DurumuCbox.Items.Add("pasif");
                    break;
                case "ispanyolca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("activo");
                    DurumuCbox.Items.Add("pasivo");
                    break;
                case "fransizca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("actif");
                    DurumuCbox.Items.Add("passif");
                    break;
                case "macarca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktív");
                    DurumuCbox.Items.Add("passzív");
                    break;
                case "polonyaca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktywny");
                    DurumuCbox.Items.Add("pasywny");
                    break;
                case "rusca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");
                    break;


            }

            ((Araclar)Application.OpenForms["Araclar"]).aracgetir();
            //sqltablecheckfirmalardan veri çekme
            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmdfirmalar.ExecuteReader();

            while (sqlReader.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReader["FirmaAdi"].ToString().Trim());
            }

            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Close();
            //
            //sqltablechecksuruculer veri çekme
            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Open();
            SqlDataReader sqlReader1 = sqlCmdsuruculer.ExecuteReader();

            while (sqlReader1.Read())
            {
                SurucuAdiSoyadiCbox.Items.Add(sqlReader1["SurucuAdiSoyadi"].ToString().Trim());
            }

            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Close();
            //
        }


    }
}
