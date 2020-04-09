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
    public partial class MalzemeYeni : Form
    {

        public MalzemeYeni()
        {
            InitializeComponent();
        }
        bool malzemetipiSecildi = false;
        private void DurumuCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = MalzemeDurum.Text;
        }
        private void tamam_btn_click(object sender, EventArgs e)
        {

            if (durumutxt.Text != "" & malzemeadiitxt.Text != "")
            {

                if (malzemetipiSecildi == true)
                {
                    string sql = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                           "values('" + malzemeadiitxt.Text + "','" + (MalzemelerComboBox.SelectedIndex + 1).ToString() + "','" + aciklama1txt.Text + "','" + aciklama2txt.Text + "','" + durumutxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, SqlTableCheckMalzemeler.DatabaseConn);
                    // Bağlantı Açık mı diye kontrol ediyoruz değilse açıyoruz.
                    if (SqlTableCheckMalzemeler.DatabaseConn.State != ConnectionState.Open) SqlTableCheckMalzemeler.DatabaseConn.Open();
                    cmd.ExecuteNonQuery(); // veri ekleme sql sorgusunu çalıştıran komut
                    SqlTableCheckMalzemeler.DatabaseConn.Close(); // veri eklendikten sonra bağlantıyı burada kapatıyoruz.
                    ((Malzemeler)Application.OpenForms["Malzemeler"]).malzemegetir();
                    malzemetipiSecildi = false;

                    this.Close();
                }
            }
            if (durumutxt.Text == "")
                errorProvider1.SetError(durumutxt, hatamsgmalzeme.Text);
            if (malzemeadiitxt.Text == "")
                errorProvider1.SetError(malzemeadiitxt, hatamsgmalzeme.Text);
            
          
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
            MalzemeTipi.Text = Localization.Localization.MalzemeTipi;
            hatamsgmalzeme.Text = Localization.Localization.hatamsgmalzeme;

        }
        //

        private void YeniMalzeme_Load(object sender, EventArgs e)
        {
          
            DilDegistir();
            
            MalzemeDurum.Items.Add(Localization.Localization.ES1363_1);//aktif
            MalzemeDurum.Items.Add(Localization.Localization.ES1364_1);//Pasif
            MalzemeDurum.Text = Localization.Localization.ES1363_1;

            MalzemelerComboBox.Items.Add(Localization.Localization.ES96_1);//Agrega
            MalzemelerComboBox.Items.Add(Localization.Localization.ES208_1);//Çimento
            MalzemelerComboBox.Items.Add(Localization.Localization.ES99_1);//Katki
            MalzemelerComboBox.Items.Add(Localization.Localization.ES98_1);//Su

           
        }

        private void MalzemelerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            malzemetipiSecildi = true;

        }

        private void MalzemeDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            durumutxt.Text = MalzemeDurum.Text;
        }
    }
}
