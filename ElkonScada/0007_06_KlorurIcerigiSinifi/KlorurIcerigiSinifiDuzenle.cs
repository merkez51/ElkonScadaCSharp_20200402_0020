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

namespace ElkonScada._0007_06_KlorurIcerigiSinifi
{
    public partial class KlorurIcerigiSinifiDuzenle : Form
    {
        public KlorurIcerigiSinifiDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdKlorurIcerigiSinifi = new SqlCommand("SELECT KlorurIcerigiSinifi FROM KlorurIcerigiSinifi", SqlTableCheckKlorurIcerigiSinifi.DatabaseConn);
        //combobox
        private void KlorurIcerigiSinifiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM KlorurIcerigiSinifi where KlorurIcerigiSinifi = '" + KlorurIcerigiSinifiCbox.SelectedItem.ToString() + "'", SqlTableCheckKlorurIcerigiSinifi.DatabaseConn);

            SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                aciklamatxt.Text = sqlReader["Aciklama"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Close();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (KlorurIcerigiSinifiCbox.Text != "")
            {
                string sqlguncelle = "update KlorurIcerigiSinifi set Aciklama='" + aciklamatxt.Text + "'," + "Durumu='" + durumutxt.Text + "' " +
                    "where KlorurIcerigiSinifi='" + KlorurIcerigiSinifiCbox.SelectedItem.ToString() + "' ";


                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckKlorurIcerigiSinifi.DatabaseConn);

                if (SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((KlorurIcerigiSinifiBeton)Application.OpenForms["KlorurIcerigiSinifiBeton"]).kloruricerigisinifigetir();
                this.Close();
            }
            else
                errorProvider1.SetError(KlorurIcerigiSinifiCbox, hatamsgklorursinifi.Text);
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
            ES1544_1.Text = Localization.Localization.ES1544_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES403_1.Text = Localization.Localization.ES403_1;
            hatamsgklorursinifi.Text = Localization.Localization.hatamsgklorursinifi;
        }
        //
        private void KlorurIcerigiSinifiDuzenle_Load(object sender, EventArgs e)
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
            //KlorurIcerigiSinifi çekme
            SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Open();
            SqlDataReader sqlReaderKlorurIcerigiSinifi = sqlCmdKlorurIcerigiSinifi.ExecuteReader();

            while (sqlReaderKlorurIcerigiSinifi.Read())
            {
                KlorurIcerigiSinifiCbox.Items.Add(sqlReaderKlorurIcerigiSinifi["KlorurIcerigiSinifi"].ToString().Trim());
            }

            SqlTableCheckKlorurIcerigiSinifi.DatabaseConn.Close();
            //
        }

    }
}
