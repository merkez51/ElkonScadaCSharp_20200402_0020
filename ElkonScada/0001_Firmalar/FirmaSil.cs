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
    public partial class FirmaSil : Form
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ElkonScada;Integrated Security=True");
        //SqlCommand komut;

        public FirmaSil()
        {
            InitializeComponent();
        }

        private void hayırbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void evetbtn_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Firmalar WHERE SiraNo=@No";
            SqlCommand cmd = new SqlCommand(sql, SqlTableCheckFirmalar.DatabaseConn);
            // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
            cmd.Parameters.AddWithValue("@No", ((Firmalar)Application.OpenForms["Firmalar"]).no);
            if (SqlTableCheckFirmalar.DatabaseConn.State != ConnectionState.Open) SqlTableCheckFirmalar.DatabaseConn.Open();
            cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
            SqlTableCheckFirmalar.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
            ((Firmalar)Application.OpenForms["Firmalar"]).firmagetir();
            this.Close();
            //string sorgu = "DELETE FROM Table_Companies WHERE firmaadi=@firmaadi";
            //komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@firmaadi", ((Firmalar)Application.OpenForms["Firmalar"]).firmaaditext);
            //baglanti.Open();
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //this.Close();
            //((Firmalar)Application.OpenForms["Firmalar"]).firmagetir();
        }
        //Dil Değiştirme
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

            ES798_1.Text = Localization.Localization.ES798_1;
            ES799_1.Text = Localization.Localization.ES799_1;
            ES838_1.Text = Localization.Localization.ES838_1;

        }
        //
        private void FirmaSil_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }
    }
}
