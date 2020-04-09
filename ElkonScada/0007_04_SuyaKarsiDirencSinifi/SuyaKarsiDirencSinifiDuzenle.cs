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

namespace ElkonScada._0007_04_SuyaKarsiDirencSinifi
{
    public partial class SuyaKarsiDirencSinifiDuzenle : Form
    {

        public SuyaKarsiDirencSinifiDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdSuyaKarsiDirencSinifi = new SqlCommand("SELECT SuyaKarsiDirencSinifi FROM SuyaKarsiDirencSinifi", SqlTableCheckSuyaKarsiDS.DatabaseConn);

        //combobox

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }

        private void SuyaKarsiDirencSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM SuyaKarsiDirencSinifi where SuyaKarsiDirencSinifi = '" + SuyaKarsiDirencSinifiCbox.SelectedItem.ToString() + "'", SqlTableCheckSuyaKarsiDS.DatabaseConn);

            SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                aciklamatxt.Text = sqlReader["Aciklama"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckSuyaKarsiDS.DatabaseConn.Close();
        }

        //
        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            string sqlguncelle = "update SuyaKarsiDirencSinifi set Aciklama='" + aciklamatxt.Text + "'," + "Durumu='" + durumutxt.Text + "' " +
                "where SuyaKarsiDirencSinifi='" + SuyaKarsiDirencSinifiCbox.SelectedItem.ToString() + "' ";


            SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckSuyaKarsiDS.DatabaseConn);

            if (SqlTableCheckSuyaKarsiDS.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
            {
                SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
            }
            Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            SqlTableCheckSuyaKarsiDS.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
            ((SuyaKarsiDirencSinifiBeton)Application.OpenForms["SuyaKarsiDirencSinifiBeton"]).suyakarsidirencsinifigetir();
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
            ES1542_1.Text = Localization.Localization.ES1542_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES403_1.Text = Localization.Localization.ES403_1;
        }
        //
        private void SuyaKarsiDirencSinifiDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            DurumuCbox.Items.Clear();
            switch (Localization.DilSettings.Default.Dil)
            {
                case "ingilizce":


                    DurumuCbox.Items.Add("active");
                    DurumuCbox.Items.Add("passive");
                    break;
                case "turkce":

                    DurumuCbox.Items.Add("aktif");
                    DurumuCbox.Items.Add("pasif");
                    break;
                case "ispanyolca":

                    DurumuCbox.Items.Add("activo");
                    DurumuCbox.Items.Add("pasivo");
                    break;

                case "fransizca":

                    DurumuCbox.Items.Add("actif");
                    DurumuCbox.Items.Add("passif");
                    break;
                case "macarca":

                    DurumuCbox.Items.Add("aktív");
                    DurumuCbox.Items.Add("passzív");
                    break;
                case "polonyaca":

                    DurumuCbox.Items.Add("aktywny");
                    DurumuCbox.Items.Add("pasywny");
                    break;
                case "rusca":

                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");
                    break;


            }
            //SuyaKarsiDirencSinifi çekme
            SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReaderSuyaKarsiDirencSinifi = sqlCmdSuyaKarsiDirencSinifi.ExecuteReader();

            while (sqlReaderSuyaKarsiDirencSinifi.Read())
            {
                SuyaKarsiDirencSinifiCbox.Items.Add(sqlReaderSuyaKarsiDirencSinifi["SuyaKarsiDirencSinifi"].ToString().Trim());
            }

            SqlTableCheckSuyaKarsiDS.DatabaseConn.Close();
            //
        }
    }
}
