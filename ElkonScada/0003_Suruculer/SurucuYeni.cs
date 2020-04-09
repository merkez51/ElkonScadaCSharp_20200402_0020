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
    public partial class SurucuYeni : Form
    {
        public SurucuYeni()
        {
            InitializeComponent();
        }

        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = DurumuCbox.Text;
        }

        private void tamam_btn_click(object sender, EventArgs e)
        {
            if (surucuadisoyaditxt.Text != "" & durumutxt.Text != "" & telefonfakstxt.Text != "")
            {

                string sql = "insert into Suruculer(SurucuAdiSoyadi,Adres,TelefonFaks,Aciklama,Durumu)" +
                         "values('" + surucuadisoyaditxt.Text + "','" + adrestxt.Text + "','" + telefonfakstxt.Text + "','" + aciklamatxt.Text +
                         "','" + durumutxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, SqlTableCheckSuruculer.DatabaseConn);
                // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                if (SqlTableCheckSuruculer.DatabaseConn.State != ConnectionState.Open) SqlTableCheckSuruculer.DatabaseConn.Open();
                cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                SqlTableCheckSuruculer.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                ((Suruculer)Application.OpenForms["Suruculer"]).surucugetir();
                this.Close();
            }
            if (surucuadisoyaditxt.Text == "")
                errorProvider1.SetError(surucuadisoyaditxt, hatamsgsurucu.Text);
            if (durumutxt.Text == "")
                errorProvider1.SetError(durumutxt, hatamsgsurucu.Text);
            if (telefonfakstxt.Text == "")
                errorProvider1.SetError(telefonfakstxt, hatamsgsurucu.Text);
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

        private void YeniSurucu_Load(object sender, EventArgs e)
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
            ((Suruculer)Application.OpenForms["Suruculer"]).surucugetir();
        }


    }
}
