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
    public partial class FirmaYeni : Form
    {
        public FirmaYeni()
        {
            InitializeComponent();
        }

        private void durumucmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = durumucmb.Text;
        }
       
        public void tamam_btn_click(object sender, EventArgs e)
        {
            if (firmaaditxt.Text != "" & durumutxt.Text != "")
            {
             
                string sql = "insert into Firmalar(FirmaAdi,TelefonFaks,Adres,IlgiliKisi,VergiDairesi,VergiNumarasi,Durumu)" +
                             "values('" + firmaaditxt.Text + "','" + telefonfakstxt.Text + "','" + adrestxt.Text + "','" + ilgilikisitxt.Text +
                             "','" + vergidairesitxt.Text + "','" + verginotxt.Text + "','" + durumutxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckFirmalar.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckFirmalar.DatabaseConn.State != ConnectionState.Open) SqlTableCheckFirmalar.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckFirmalar.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((Firmalar)Application.OpenForms["Firmalar"]).firmagetir();
                this.Close();
            }
            if (firmaaditxt.Text == "")
                errorProvider1.SetError(firmaaditxt, hatamsgfirma.Text);
            if (durumutxt.Text == "")
                errorProvider1.SetError(durumutxt, hatamsgfirma.Text);

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
        private void YeniFirma_Load(object sender, EventArgs e)
        {
            DilDegistir();
            switch (Localization.DilSettings.Default.Dil)
            {

                case "ingilizce":
                
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("active");
                    durumucmb.Items.Add("passive");
                    break;
                case "turkce":
                     durumucmb.Items.Clear();
                    durumucmb.Items.Add("aktif");
                    durumucmb.Items.Add("pasif");
                    break;
                case "ispanyolca":
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("activo");
                    durumucmb.Items.Add("pasivo");
                    break;
                case "fransizca":
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("actif");
                    durumucmb.Items.Add("passif");
                    break;
                case "macarca":
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("aktív");
                    durumucmb.Items.Add("passzív");
                    break;
                case "polonyaca":
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("aktywny");
                    durumucmb.Items.Add("pasywny");
                    break;
                case "rusca":
                    durumucmb.Items.Clear();
                    durumucmb.Items.Add("активный");
                    durumucmb.Items.Add("пассивный");
                    break;


            }
        }
        

      
    }
}

