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

namespace ElkonScada._0005_Malzemeler
{
    public partial class MalzemeBilgileriDuzenle : Form
    {

        public MalzemeBilgileriDuzenle()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmdMalzemeler = new SqlCommand("SELECT MalzemeAdi FROM Malzemeler", SqlTableCheckMalzemeler.DatabaseConn);

        //combobox

        private void MalzemeAdiCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlCommand SecileniGetir = new SqlCommand("SELECT * FROM Malzemeler where MalzemeAdi = '" + MalzemeAdiCbox.SelectedItem.ToString() + "'", SqlTableCheckMalzemeler.DatabaseConn);

            SqlTableCheckMalzemeler.DatabaseConn.Open();
            SqlDataReader sqlReader = SecileniGetir.ExecuteReader();

            while (sqlReader.Read())
            {

                aciklama1txt.Text = sqlReader["Aciklama1"].ToString().Trim();
                aciklama2txt.Text = sqlReader["Aciklama2"].ToString().Trim();
                durumutxt.Text = sqlReader["Durumu"].ToString().Trim();

            }

            SqlTableCheckMalzemeler.DatabaseConn.Close();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            if (MalzemeAdiCbox.Text != "")
            {
                string sqlguncelle = "update Malzemeler set Aciklama1='" + aciklama1txt.Text + "',Aciklama2='" + aciklama2txt.Text + "',Durumu='" + durumutxt.Text + "' " +
                    "where MalzemeAdi='" + MalzemeAdiCbox.SelectedItem.ToString() + "' ";


                SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckMalzemeler.DatabaseConn);

                if (SqlTableCheckMalzemeler.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
                {
                    SqlTableCheckMalzemeler.DatabaseConn.Open();
                }
                Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
                SqlTableCheckMalzemeler.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
                ((Malzemeler)Application.OpenForms["Malzemeler"]).malzemegetir();
                this.Close();
            }
            if (MalzemeAdiCbox.Text == "")
                errorProvider1.SetError(MalzemeAdiCbox, hatamsgmalzeme.Text);
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
            ES1612_1.Text = Localization.Localization.ES1612_1;
            ES1613_1.Text = Localization.Localization.ES1613_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES391_1.Text = Localization.Localization.ES391_1;
            ES807_1.Text = Localization.Localization.ES807_1;
            hatamsgmalzeme.Text = Localization.Localization.hatamsgmalzeme;
        }
        //
        private void MalzemeBilgileriDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            switch (Localization.DilSettings.Default.Dil)
            {

                case "ingilizce":

                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Active");
                    DurumuCbox.Items.Add("Passive");
                    break;
                case "turkce":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Aktif");
                    DurumuCbox.Items.Add("Pasif");
                    break;
                case "ispanyolca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Activo");
                    DurumuCbox.Items.Add("Pasivo");
                    break;
                case "fransizca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Actif");
                    DurumuCbox.Items.Add("Passif");
                    break;
                case "macarca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Aktív");
                    DurumuCbox.Items.Add("Passzív");
                    break;
                case "polonyaca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("Aktywny");
                    DurumuCbox.Items.Add("Pasywny");
                    break;
                case "rusca":
                    DurumuCbox.Items.Clear();
                    DurumuCbox.Items.Add("активный");
                    DurumuCbox.Items.Add("пассивный");
                    break;
                                      
            }
            //Surucuadisoyadi çekme
            SqlTableCheckMalzemeler.DatabaseConn.Open();
            SqlDataReader sqlReaderMalzemeler = sqlCmdMalzemeler.ExecuteReader();

            while (sqlReaderMalzemeler.Read())
            {
                MalzemeAdiCbox.Items.Add(sqlReaderMalzemeler["MalzemeAdi"].ToString().Trim());
            }

            SqlTableCheckMalzemeler.DatabaseConn.Close();
            //
        }

        
    }
}
