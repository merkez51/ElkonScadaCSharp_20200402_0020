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

namespace ElkonScada._0004_Santiyeler
{
    public partial class SantiyeBilgileriDuzenle : Form
    {

        public SantiyeBilgileriDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdSantiyeler = new SqlCommand("SELECT SantiyeAdi FROM Santiyeler", SqlTableCheckSantiyeler.DatabaseConn);

        //Combobox
        private void FirmaAdiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaaditxt.Text = FirmaAdiCbox.Text;
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }

        private void SantiyeAdiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Santiyeler where SantiyeAdi = '" + SantiyeAdiCbox.SelectedItem.ToString() + "'", SqlTableCheckSantiyeler.DatabaseConn);

            SqlTableCheckSantiyeler.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                telefonfakstxt.Text = sqlReader["TelefonFaks"].ToString().Trim();
                adrestxt.Text = sqlReader["Adres"].ToString().Trim();
                firmaaditxt.Text = sqlReader["FirmaAdi"].ToString().Trim();
                mesafetxt.Text = sqlReader["Mesafe"].ToString().Trim();
                aciklamatxt.Text = sqlReader["Aciklama"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckSantiyeler.DatabaseConn.Close();
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (SantiyeAdiCbox.Text != "")
            {
                string sqlguncelle = "update Santiyeler set TelefonFaks='" + telefonfakstxt.Text + "',Adres='" + adrestxt.Text + "',FirmaAdi='" + firmaaditxt.Text + "'," +
                    "Mesafe='" + mesafetxt.Text + "',Aciklama='" + aciklamatxt.Text + "',Durumu='" + durumutxt.Text + "' " +
                    "where SantiyeAdi = '" + SantiyeAdiCbox.SelectedItem.ToString() + "' ";

                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckSantiyeler.DatabaseConn);

                if (SqlTableCheckSantiyeler.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckSantiyeler.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckSantiyeler.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((Santiyeler)Application.OpenForms["Santiyeler"]).santiyegetir();
                this.Close();
            }
            if (SantiyeAdiCbox.Text == "")
                errorProvider1.SetError(SantiyeAdiCbox, hatamsg.Text);

        }

        //dildeğiştirme
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
            ES413_1.Text = Localization.Localization.ES413_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES810_1.Text = Localization.Localization.ES810_1;
            hatamsg.Text = Localization.Localization.hatamsg;
        }
        //
        private void SantiyeBilgileriDuzenle_Load(object sender, EventArgs e)
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
            //SantiyeAdi çekme
            SqlTableCheckSantiyeler.DatabaseConn.Open();
            SqlDataReader sqlReaderSantiyeler = sqlCmdSantiyeler.ExecuteReader();

            while (sqlReaderSantiyeler.Read())
            {
                SantiyeAdiCbox.Items.Add(sqlReaderSantiyeler["SantiyeAdi"].ToString().Trim());
            }

            SqlTableCheckSantiyeler.DatabaseConn.Close();
            //
        }


    }
}
