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
    public partial class UretimPlanDuzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Firmalar;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public UretimPlanDuzenle()
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
            ES1845_1.Text = Localization.Localization.ES1845_1;
            ES2064_0.Text = Localization.Localization.ES2064_0;
            ES2065_0.Text = Localization.Localization.ES2065_0;
            ES2066_0.Text = Localization.Localization.ES2066_0;
            ES2067_0.Text = Localization.Localization.ES2067_0;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES404_1.Text = Localization.Localization.ES404_1;
            ES810_1.Text = Localization.Localization.ES810_1;
            ES834_1.Text = Localization.Localization.ES834_1;
            ES842_1.Text = Localization.Localization.ES842_1;
            ES848_1.Text = Localization.Localization.ES848_1;
            ES949_1.Text = Localization.Localization.ES949_1;
            ES950_1.Text = Localization.Localization.ES950_1;
            ES952_1.Text = Localization.Localization.ES952_1;
            ES955_1.Text = Localization.Localization.ES955_1;
            ES956_1.Text = Localization.Localization.ES956_1;
            sirano.HeaderText = Localization.Localization.sirano;
            siparisno.HeaderText = Localization.Localization.siparisno;
            firmaadi.HeaderText = Localization.Localization.firmaadi;
            santiyeadi.HeaderText = Localization.Localization.santiyeadi;
            siparismiktari.HeaderText = Localization.Localization.siparismiktari;
            receteadi.HeaderText = Localization.Localization.receteadi;
            yapilanmiktar.HeaderText = Localization.Localization.yapilanmiktar;
            kalanmiktar.HeaderText = Localization.Localization.kalanmiktar;
        }
        //
        private void PlanDuzenle_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }
        private void tamam_btn_click(object sender, EventArgs e)
        {
        
        }
    }
}
