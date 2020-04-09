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

namespace ElkonScada._0002_Araclar
{
    public partial class AracBilgileriDuzenle : Form
    {

        public AracBilgileriDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdFirmalar = new SqlCommand("SELECT FirmaAdi FROM Firmalar", ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn);
        SqlCommand sqlCmdAraclar = new SqlCommand("SELECT AracPlakaNo FROM Araclar", SqlTableCheckAraclar.DatabaseConn);
        SqlCommand sqlCmdSuruculer = new SqlCommand("SELECT SurucuAdiSoyadi FROM Suruculer", ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn);

        //Combobox
        private void AracPlakaNoCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Araclar where AracPlakaNo = '" + AracPlakaNoCbox.SelectedItem.ToString() + "'", SqlTableCheckAraclar.DatabaseConn);

            SqlTableCheckAraclar.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                firmaaditxt.Text = sqlReader["FirmaAdi"].ToString().Trim();
                surucuadisoyaditxt.Text = sqlReader["SurucuAdiSoyadi"].ToString().Trim();
                kapasitetxt.Text = sqlReader["Kapasite"].ToString().Trim();
                aractipitxt.Text = sqlReader["AracTipi"].ToString().Trim();
                aracmarkasitxt.Text = sqlReader["AracMarkasi"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }
           

            SqlTableCheckAraclar.DatabaseConn.Close();
        }
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

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (AracPlakaNoCbox.Text != "" & firmaaditxt.Text != "" & surucuadisoyaditxt.Text != "")
            {
                string sqlguncelle = "update Araclar set FirmaAdi='" + firmaaditxt.Text + "',SurucuAdiSoyadi='" + surucuadisoyaditxt.Text + "'," +
                    "Kapasite='" + kapasitetxt.Text + "',AracTipi='" + aractipitxt.Text + "',AracMarkasi='" + aracmarkasitxt.Text + "',Durumu='" + durumutxt.Text + "' " +
                    "where AracPlakaNo = '" + AracPlakaNoCbox.SelectedItem.ToString() + "' ";

                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckAraclar.DatabaseConn);

                if (SqlTableCheckAraclar.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckAraclar.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckAraclar.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((Araclar)Application.OpenForms["Araclar"]).aracgetir();
                this.Close();
            }
           if( AracPlakaNoCbox.Text =="" )
                errorProvider1.SetError(AracPlakaNoCbox, hatamsgarac.Text);
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



        private void AracBilgileriDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            switch (Localization.DilSettings.Default.Dil)
            {

                case "ingilizce":

                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("active");
                    DurumuCbox.Items.Add("passive");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Truck");
                    AracTipiCbox.Items.Add("Mixer");
                    AracTipiCbox.Items.Add("Pump");

                    break;
                case "turkce":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktif");
                    DurumuCbox.Items.Add("pasif");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Kamyon ");
                    AracTipiCbox.Items.Add("Mikser");
                    AracTipiCbox.Items.Add("Beton Pompası");
                    break;
                case "ispanyolca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("activo");
                    DurumuCbox.Items.Add("pasivo");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Camión");
                    AracTipiCbox.Items.Add("Mezclador");
                    AracTipiCbox.Items.Add("Bomba de hormigón");
                    break;
                case "fransizca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("actif");
                    DurumuCbox.Items.Add("passif");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Camion");
                    AracTipiCbox.Items.Add("Mixer");
                    AracTipiCbox.Items.Add("Pompe à béton");
                    break;
                case "macarca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktív");
                    DurumuCbox.Items.Add("passzív");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Teherautó");
                    AracTipiCbox.Items.Add("keverő");
                    AracTipiCbox.Items.Add("Betonpumpa");
                    break;
                case "polonyaca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("aktywny");
                    DurumuCbox.Items.Add("pasywny");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("Ciężarówka");
                    AracTipiCbox.Items.Add("Mikser");
                    AracTipiCbox.Items.Add("Pompa do betonu");
                    break;
                case "rusca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");

                    AracTipiCbox.Items.Clear();
                    AracTipiCbox.Items.Add("грузовик");
                    AracTipiCbox.Items.Add("смеситель");
                    AracTipiCbox.Items.Add("бетононасос");
                    break;


            }
            //firmalardan sql verilerini çekme
            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReaderFirmalar = sqlCmdFirmalar.ExecuteReader();

            while (sqlReaderFirmalar.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReaderFirmalar["FirmaAdi"].ToString().Trim());
            }

            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Close();
            //
            //Arac plakalarını çekme
            SqlTableCheckAraclar.DatabaseConn.Open();
            SqlDataReader sqlReaderAraclar = sqlCmdAraclar.ExecuteReader();

            while (sqlReaderAraclar.Read())
            {
                AracPlakaNoCbox.Items.Add(sqlReaderAraclar["AracPlakaNo"].ToString().Trim());
            }

            SqlTableCheckAraclar.DatabaseConn.Close();
            //
            //Surucuadisoyadi çekme
            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Open();
            SqlDataReader sqlReaderSuruculer = sqlCmdSuruculer.ExecuteReader();

            while (sqlReaderSuruculer.Read())
            {
                SurucuAdiSoyadiCbox.Items.Add(sqlReaderSuruculer["SurucuAdiSoyadi"].ToString().Trim());
            }

            ElkonScada._0003_Suruculer.SqlTableCheckSuruculer.DatabaseConn.Close();
            //
        }

        private void firmaaditxt_TextChanged(object sender, EventArgs e)
        {
            FirmaAdiCbox.SelectedItem = firmaaditxt.Text;
        }

        private void surucuadisoyaditxt_TextChanged(object sender, EventArgs e)
        {
            SurucuAdiSoyadiCbox.SelectedItem = surucuadisoyaditxt.Text;
        }

        private void aractipitxt_TextChanged(object sender, EventArgs e)
        {
            AracTipiCbox.SelectedItem = aractipitxt.Text;
        }
    }
}
