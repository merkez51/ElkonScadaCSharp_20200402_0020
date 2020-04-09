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
    public partial class SantiyeYeni : Form
    {
        public SantiyeYeni()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmdfirmalar = new SqlCommand("SELECT FirmaAdi FROM Firmalar", ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn);

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }

        private void FirmaAdiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaaditxt.Text = FirmaAdiCbox.Text;
        }

        private void tamam_btn_click(object sender, EventArgs e)
        {
            if (santiyeaditxt.Text != "" & durumutxt.Text != "" & firmaaditxt.Text != "")
            {
                string sql = "insert into Santiyeler(SantiyeAdi,TelefonFaks,Adres,FirmaAdi,Mesafe,Aciklama,Durumu)" +
                         "values('" + santiyeaditxt.Text + "','" + telefonfakstxt.Text + "','" + adrestxt.Text + "','" + firmaaditxt.Text +
                         "','" + mesafetxt.Text + "','" + aciklamatxt.Text + "','" + durumutxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckSantiyeler.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckSantiyeler.DatabaseConn.State != ConnectionState.Open) SqlTableCheckSantiyeler.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckSantiyeler.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((Santiyeler)Application.OpenForms["Santiyeler"]).santiyegetir();
                this.Close();
            }
            if(santiyeaditxt.Text=="")
                errorProvider1.SetError(santiyeaditxt, hatamsg.Text);
            if(durumutxt.Text == "")
                errorProvider1.SetError(durumutxt, hatamsg.Text);
            if(firmaaditxt.Text == "")
                errorProvider1.SetError(firmaaditxt, hatamsg.Text);
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
            ES413_1.Text = Localization.Localization.ES413_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES810_1.Text = Localization.Localization.ES810_1;
            hatamsg.Text = Localization.Localization.hatamsg;
        }
        //

        private void YeniSantiye_Load(object sender, EventArgs e)
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
            ((Santiyeler)Application.OpenForms["Santiyeler"]).santiyegetir();
            //sqltablecheckfirmalardan veri çekme
            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmdfirmalar.ExecuteReader();

            while (sqlReader.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReader["FirmaAdi"].ToString().Trim());
            }

            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Close();
            //
        }


    }
}
