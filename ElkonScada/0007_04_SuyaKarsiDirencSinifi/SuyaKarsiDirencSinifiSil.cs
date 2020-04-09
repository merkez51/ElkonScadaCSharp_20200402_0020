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

namespace ElkonScada._0007_04_SuyaKarsiDirencSinifi
{
    public partial class SuyaKarsiDirencSinifiSil : Form
    {

        public SuyaKarsiDirencSinifiSil()
        {
            InitializeComponent();
        }
        private void evet_btn_click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SuyaKarsiDirencSinifi WHERE SiraNo=@No";
            SqlCommand cmd = new SqlCommand(sql, SqlTableCheckSuyaKarsiDS.DatabaseConn);
            // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
            cmd.Parameters.AddWithValue("@No", ((SuyaKarsiDirencSinifiBeton)Application.OpenForms["SuyaKarsiDirencSinifiBeton"]).no);
            if (SqlTableCheckSuyaKarsiDS.DatabaseConn.State != ConnectionState.Open) SqlTableCheckSuyaKarsiDS.DatabaseConn.Open();
            cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
            SqlTableCheckSuyaKarsiDS.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
            ((SuyaKarsiDirencSinifiBeton)Application.OpenForms["SuyaKarsiDirencSinifiBeton"]).suyakarsidirencsinifigetir();
            this.Close();
        }

        private void hayir_btn_click(object sender, EventArgs e)
        {
            this.Close();
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
        private void SuyaKarsiDirencSinifiSil_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }


    }
}
