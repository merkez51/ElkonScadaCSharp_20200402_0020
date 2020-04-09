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

namespace ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi
{
    public partial class DonaKarsiDayaniklilikSinifiDuzenle : Form
    {

        public DonaKarsiDayaniklilikSinifiDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdDonaKarsiDayaniklilikSinifi = new SqlCommand("SELECT DonaKarsiDayaniklilikSinifi FROM DonaKarsiDayaniklilikSinifi", SqlTableCheckDonaKarsiDS.DatabaseConn);

        //combobox
        private void DonaKarsiDayaniklilikSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM DonaKarsiDayaniklilikSinifi where DonaKarsiDayaniklilikSinifi = '" + DonaKarsiDayaniklilikSinifiCbox.SelectedItem.ToString() + "'", SqlTableCheckDonaKarsiDS.DatabaseConn);

            SqlTableCheckDonaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                aciklamatxt.Text = sqlReader["Aciklama"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckDonaKarsiDS.DatabaseConn.Close();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (DonaKarsiDayaniklilikSinifiCbox.Text != "")
            {
                string sqlguncelle = "update DonaKarsiDayaniklilikSinifi set Aciklama='" + aciklamatxt.Text + "'," + "Durumu='" + durumutxt.Text + "' " +
                    "where DonaKarsiDayaniklilikSinifi ='" + DonaKarsiDayaniklilikSinifiCbox.SelectedItem.ToString() + "' ";


                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckDonaKarsiDS.DatabaseConn);

                if (SqlTableCheckDonaKarsiDS.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckDonaKarsiDS.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckDonaKarsiDS.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((DonaKarsiDayaniklilikSinifiBeton)Application.OpenForms["DonaKarsiDayaniklilikSinifiBeton"]).donakarsidayanikliliksinifigetir();
                this.Close();
            }
            else
                errorProvider1.SetError(DonaKarsiDayaniklilikSinifiCbox, hatamsgdon.Text);
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
            ES1541_1.Text = Localization.Localization.ES1541_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES403_1.Text = Localization.Localization.ES403_1;
            hatamsgdon.Text = Localization.Localization.hatamsgdon;
        }
        //
        private void DonaKarsiDayaniklilikSinifiDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            DurumuCbox.Items.Clear();
            switch (Localization.DilSettings.Default.Dil)
            {
                case "ingilizce":


                    DurumuCbox.Items.Add("Active");
                    DurumuCbox.Items.Add("Passive");
                    break;
                case "turkce":

                    DurumuCbox.Items.Add("Aktif");
                    DurumuCbox.Items.Add("Pasif");
                    break;
                case "ispanyolca":

                    DurumuCbox.Items.Add("Activo");
                    DurumuCbox.Items.Add("Pasivo");
                    break;

                case "fransizca":

                    DurumuCbox.Items.Add("Actif");
                    DurumuCbox.Items.Add("Passif");
                    break;
                case "macarca":

                    DurumuCbox.Items.Add("Aktív");
                    DurumuCbox.Items.Add("Passzív");
                    break;
                case "polonyaca":

                    DurumuCbox.Items.Add("Aktywny");
                    DurumuCbox.Items.Add("Pasywny");
                    break;
                case "rusca":

                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");
                    break;


            }
            //DonaKarsiDayaniklilikSinifi çekme
            SqlTableCheckDonaKarsiDS.DatabaseConn.Open();
            SqlDataReader sqlReaderDonaKarsiDayaniklilikSinifi = sqlCmdDonaKarsiDayaniklilikSinifi.ExecuteReader();

            while (sqlReaderDonaKarsiDayaniklilikSinifi.Read())
            {
                DonaKarsiDayaniklilikSinifiCbox.Items.Add(sqlReaderDonaKarsiDayaniklilikSinifi["DonaKarsiDayaniklilikSinifi"].ToString().Trim());
            }

            SqlTableCheckDonaKarsiDS.DatabaseConn.Close();
            //
        }




    }
}
