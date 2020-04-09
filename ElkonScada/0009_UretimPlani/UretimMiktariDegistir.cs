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

namespace ElkonScada._0009_UretimPlani
{
    public partial class UretimMiktariDegistir : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Firmalar;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public UretimMiktariDegistir()
        {
            InitializeComponent();
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
            ES386_1.Text = Localization.Localization.ES386_1;
            ES404_1.Text = Localization.Localization.ES404_1;
            ES842_1.Text = Localization.Localization.ES842_1;
            ES949_1.Text = Localization.Localization.ES949_1;
            ES952_1.Text = Localization.Localization.ES952_1;
            ES955_1.Text = Localization.Localization.ES955_1;
            ES956_1.Text = Localization.Localization.ES956_1;
        }
        //
        private void UretimMiktariDegistir_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }

        private void SurucuAdiSoyadiCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tamam_btn_click(object sender, EventArgs e)
        {

        }



    }
}
