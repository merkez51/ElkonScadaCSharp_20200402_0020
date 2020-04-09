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
    public partial class StokGirisiYeni : Form
    {
        public StokGirisiYeni()
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
            ES158_1.Text = Localization.Localization.ES158_1;
            ES1612_1.Text = Localization.Localization.ES1612_1;
            ES1613_1.Text = Localization.Localization.ES1613_1;
            ES386_1.Text = Localization.Localization.ES386_1;
            ES807_1.Text = Localization.Localization.ES807_1;
            ES907_1.Text = Localization.Localization.ES907_1;
            ES909_1.Text = Localization.Localization.ES909_1;
        }
        //
        private void YeniStokGirisi_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }

        private void tamam_btn_click(object sender, EventArgs e)
        {

        }
    }
}
