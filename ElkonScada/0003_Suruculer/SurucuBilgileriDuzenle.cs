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

namespace ElkonScada._0003_Suruculer
{
    public partial class SurucuBilgileriDuzenle : Form
    {
        public SurucuBilgileriDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdSuruculer = new SqlCommand("SELECT SurucuAdiSoyadi FROM Suruculer", SqlTableCheckSuruculer.DatabaseConn);

        //Combobox

        private void SurucuAdiSoyadiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Suruculer where SurucuAdiSoyadi = '" + SurucuAdiSoyadiCbox.SelectedItem.ToString() + "'", SqlTableCheckSuruculer.DatabaseConn);

            SqlTableCheckSuruculer.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                telefonfakstxt.Text = sqlReader["TelefonFaks"].ToString().Trim();
                adrestxt.Text = sqlReader["Adres"].ToString().Trim();
                aciklamatxt.Text = sqlReader["Aciklama"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckSuruculer.DatabaseConn.Close();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        //


        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (SurucuAdiSoyadiCbox.Text != "")
            {
                string sqlguncelle = "update Suruculer set TelefonFaks='" + telefonfakstxt.Text + "',Adres='" + adrestxt.Text + "', Aciklama='" + aciklamatxt.Text + "'," +
                    "Durumu='" + durumutxt.Text + "' where SurucuAdiSoyadi = '" + SurucuAdiSoyadiCbox.SelectedItem.ToString() + "' ";

                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckSuruculer.DatabaseConn);

                if (SqlTableCheckSuruculer.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckSuruculer.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckSuruculer.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((Suruculer)Application.OpenForms["Suruculer"]).surucugetir();
                this.Close();
            }
            if(SurucuAdiSoyadiCbox.Text == "")
                errorProvider1.SetError(SurucuAdiSoyadiCbox, hatamsgsurucu.Text);
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
            ES147_1.Text = Localization.Localization.ES147_1;
            ES148_1.Text = Localization.Localization.ES148_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES403_1.Text = Localization.Localization.ES403_1;
            ES404_1.Text = Localization.Localization.ES404_1;
            hatamsgsurucu.Text = Localization.Localization.hatamsgsurucu;
        }

        //
        private void SurucuBilgileriDuzenle_Load(object sender, EventArgs e)
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
            //Surucuadisoyadi çekme
            SqlTableCheckSuruculer.DatabaseConn.Open();
            SqlDataReader sqlReaderSuruculer = sqlCmdSuruculer.ExecuteReader();

            while (sqlReaderSuruculer.Read())
            {
                SurucuAdiSoyadiCbox.Items.Add(sqlReaderSuruculer["SurucuAdiSoyadi"].ToString().Trim());
            }

            SqlTableCheckSuruculer.DatabaseConn.Close();
            //
        }

       
    }
}
