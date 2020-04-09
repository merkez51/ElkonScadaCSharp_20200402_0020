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
    public partial class YeniSiparis : Form
    {
        public YeniSiparis()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmdfirmalar = new SqlCommand("SELECT FirmaAdi FROM Firmalar", ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn);
        SqlCommand sqlCmdsantiyeler = new SqlCommand("SELECT SantiyeAdi FROM Santiyeler", ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn);
        SqlCommand sqlCmdreceteler = new SqlCommand("SELECT ReceteAdi FROM Receteler", SqlTableCheckReceteler.DatabaseConn);

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



        private void tamam_btn_click(object sender, EventArgs e)
        {
            string sql = "insert into Siparisler(SiparisNo,FirmaAdi,SantiyeAdi,ReceteAdi,SiparisMiktari,YapilanMiktar,KalanMiktar)" +
                         "values('" + "SP" + +((Siparisler)Application.OpenForms["Siparisler"]).siparislerdatagridview.RowCount + "','" + firmaaditxt.Text + "','" + santiyeaditxt.Text + "','" + recetetxt.Text + "','"
                         + siparismiktaritxt.Text + "','" + firmaaditxt.Text + "','" + firmaaditxt.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, SqlTableCheckSiparisler.DatabaseConn);
            // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
            if (SqlTableCheckSiparisler.DatabaseConn.State != ConnectionState.Open) SqlTableCheckSiparisler.DatabaseConn.Open();
            cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
            SqlTableCheckSiparisler.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
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
        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            DilDegistir();
            //sqltablecheckfirmalardan veri çekme
            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Open();
            SqlDataReader sqlReader = sqlCmdfirmalar.ExecuteReader();

            while (sqlReader.Read())
            {
                FirmaAdiCbox.Items.Add(sqlReader["FirmaAdi"].ToString().Trim());
            }

            ElkonScada._0001_Firmalar.SqlTableCheckFirmalar.DatabaseConn.Close();
            //
            //sqltablechecksantiyelerden veri çekme
            ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn.Open();
            SqlDataReader sqlReader1 = sqlCmdsantiyeler.ExecuteReader();

            while (sqlReader1.Read())
            {
                SantiyeAdiCbox.Items.Add(sqlReader1["SantiyeAdi"].ToString().Trim());
            }

            ElkonScada._0004_Santiyeler.SqlTableCheckSantiyeler.DatabaseConn.Close();
            //
            //sqltablecheckrecetelerden veri çekme
            SqlTableCheckReceteler.DatabaseConn.Open();
            SqlDataReader sqlReader2 = sqlCmdreceteler.ExecuteReader();

            while (sqlReader2.Read())
            {
                ReceteCbox.Items.Add(sqlReader2["ReceteAdi"].ToString().Trim());
            }

            SqlTableCheckReceteler.DatabaseConn.Close();
            //
        }




    }
}
