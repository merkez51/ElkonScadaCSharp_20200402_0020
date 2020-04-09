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

namespace ElkonScada._0001_Firmalar
{
    public partial class FirmaBilgileriDuzenle : Form
    {

        public FirmaBilgileriDuzenle()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmd = new SqlCommand("SELECT FirmaAdi FROM Firmalar", SqlTableCheckFirmalar.DatabaseConn);

        //Combobox
        private void durumucmb_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   durumutxt.Text = DurumuCbox.Text; durumucmb aracı kullanılmıyor ya da bu isimdeki araç yok
        }
        private void FirmaAdiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Firmalar where FirmaAdi = '" + FirmaAdiCbox.SelectedItem.ToString() + "'", SqlTableCheckFirmalar.DatabaseConn);

            SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {
                telefonfakstxt.Text = sqlReader["TelefonFaks"].ToString().Trim();
                adrestxt.Text = sqlReader["Adres"].ToString().Trim();
                ilgilikisitxt.Text = sqlReader["IlgiliKisi"].ToString().Trim();
                vergidairesitxt.Text = sqlReader["VergiDairesi"].ToString().Trim();
                verginotxt.Text = sqlReader["VergiNumarasi"].ToString().Trim();
                DurumuCbox.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckFirmalar.DatabaseConn.Close();
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (FirmaAdiCbox.Text != "")
            {
                string sqlguncelle = "update Firmalar set TelefonFaks='" + telefonfakstxt.Text + "',Adres='" + adrestxt.Text + "',IlgiliKisi='" + ilgilikisitxt.Text + "'," +
                    "VergiDairesi='" + vergidairesitxt.Text + "',VergiNumarasi='" + verginotxt.Text + "',Durumu='" + durumutxt.Text + "'" +
                    " where FirmaAdi = '" + FirmaAdiCbox.SelectedItem.ToString() + "' ";

                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckFirmalar.DatabaseConn);

                if (SqlTableCheckFirmalar.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckFirmalar.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckFirmalar.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((Firmalar)Application.OpenForms["Firmalar"]).firmagetir();
                this.Close();
            }
            if (FirmaAdiCbox.Text == "")
                errorProvider1.SetError(FirmaAdiCbox, hatamsgfirma.Text);
            

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
            ES128_1.Text = Localization.Localization.ES128_1;
            ES130_1.Text = Localization.Localization.ES130_1;
            ES147_1.Text = Localization.Localization.ES147_1;
            ES148_1.Text = Localization.Localization.ES148_1;
            ES150_1.Text = Localization.Localization.ES150_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            hatamsgfirma.Text = Localization.Localization.hatamsgfirma;
        }
        //



        private void FirmaBilgileriDuzenle_Load(object sender, EventArgs e)
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
            SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReader["FirmaAdi"].ToString().Trim());
            }

            SqlTableCheckFirmalar.DatabaseConn.Close();


        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
    }
}
