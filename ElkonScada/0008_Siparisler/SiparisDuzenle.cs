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

namespace ElkonScada._0008_Siparisler
{
    public partial class SiparisDuzenle : Form
    {
        public SiparisDuzenle()
        {
            InitializeComponent();
        }

        SqlCommand sqlCmdFirmalar = new SqlCommand("SELECT FirmaAdi FROM Firmalar", ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn);
        SqlCommand sqlCmdSantiyeler = new SqlCommand("SELECT SantiyeAdi FROM Santiyeler", ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn);
        SqlCommand sqlCmdReceteler = new SqlCommand("SELECT ReceteAdi FROM Receteler", SqlTableCheckReceteler.DatabaseConn);

        //combobox
        private void SantiyeAdiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            santiyeaditxt.Text = SantiyeAdiCbox.Text;
        }

        private void FirmaAdiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaaditxt.Text = FirmaAdiCbox.Text;
        }

        private void ReceteCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            recetetxt.Text = ReceteCbox.Text;
        }
        //

        private void GuncelleKaydet_Btn_Click(object sender, EventArgs e)
        {
            string sqlguncelle = "update Siparisler set SantiyeAdi='" + santiyeaditxt.Text + "',FirmaAdi='" + firmaaditxt.Text + "'," +
                "ReceteAdi='" + recetetxt.Text + "',SiparisMiktari='" + siparismiktaritxt.Text + "' " +
                "where SiraNo = '" + ((Siparisler)Application.OpenForms["Siparisler"]).no + "' ";

            SqlCommand Guncelleme = new SqlCommand(sqlguncelle, SqlTableCheckSiparisler.DatabaseConn);

            if (SqlTableCheckSiparisler.DatabaseConn.State != ConnectionState.Open) // bağlantı açık değilse açtırıyoruz.
            {
                SqlTableCheckSiparisler.DatabaseConn.Open();
            }
            Guncelleme.ExecuteNonQuery(); // sql sorgusunu işleme koyuyoruz.
            SqlTableCheckSiparisler.DatabaseConn.Close(); // bağlantıyı kapatıyoruz
            ((Siparisler)Application.OpenForms["Siparisler"]).siparisgetir();
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
            ES1845_1.Text = Localization.Localization.ES1845_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES810_1.Text = Localization.Localization.ES810_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES856_1.Text = Localization.Localization.ES856_1;
            ES950_1.Text = Localization.Localization.ES950_1;
        }
        //
        private void SiparisDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
            firmaaditxt.Text = ((Siparisler)Application.OpenForms["Siparisler"]).firmaadi;
            santiyeaditxt.Text = ((Siparisler)Application.OpenForms["Siparisler"]).santiyeadi;
            recetetxt.Text = ((Siparisler)Application.OpenForms["Siparisler"]).receteadi;
            siparismiktaritxt.Text = ((Siparisler)Application.OpenForms["Siparisler"]).siparismiktari;

            //firmalardan sql verilerini çekme
            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReaderFirmalar = sqlCmdFirmalar.ExecuteReader();

            while (sqlReaderFirmalar.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReaderFirmalar["FirmaAdi"].ToString().Trim());
            }

            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Close();
            //
            //Şantiye verileri çekme
            ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn.Open();
            SqlDataReader sqlReaderSantiyeler = sqlCmdSantiyeler.ExecuteReader();

            while (sqlReaderSantiyeler.Read())
            {
                SantiyeAdiCbox.Items.Add(sqlReaderSantiyeler["SantiyeAdi"].ToString().Trim());
            }

            ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn.Close();
            //
            //Reçete çekme
            SqlTableCheckReceteler.DatabaseConn.Open();
            SqlDataReader sqlReaderReceteler = sqlCmdReceteler.ExecuteReader();

            while (sqlReaderReceteler.Read())
            {
                ReceteCbox.Items.Add(sqlReaderReceteler["ReceteAdi"].ToString().Trim());
            }

            SqlTableCheckReceteler.DatabaseConn.Close();
            //
        }

    }
}
