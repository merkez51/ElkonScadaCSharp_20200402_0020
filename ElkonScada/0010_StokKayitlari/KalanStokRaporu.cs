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

namespace ElkonScada._0010_StokKayitlari
{
    public partial class KalanStokRaporu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Firmalar;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public int kalanstokraporuCount;
        public string stokalaniaditext, malzemeaditext, kalanmiktartext, dolulukoranitext;
        public KalanStokRaporu()
        {
            InitializeComponent();
        }
        //sayfa açma
        private void RemainingInventoryReportFileNameOpenEvent(object sender, EventArgs e)
        {
            KalanStokRaporuDosyaAdi RemainingInventoryReportFileName = new KalanStokRaporuDosyaAdi();
            RemainingInventoryReportFileName.Show();
        }
        //
        //Dil değiştirme
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

            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES32_1.Text = Localization.Localization.ES32_1;
        }
        //

        private void KalanStokRaporu_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }

    }
}
