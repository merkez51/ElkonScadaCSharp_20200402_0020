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

namespace ElkonScada._0007_05_YogunlukSinifi
{
    public partial class YogunlukSinifiBeton : Form
    {
        public YogunlukSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewDensityClassOpenEvent(object sender, EventArgs e)
        {
            YogunlukSinifiYeni NewDensityClass = new YogunlukSinifiYeni();
            NewDensityClass.Show();
        }

        private void EditDensityClassOpenEvent(object sender, EventArgs e)
        {
            YogunlukSinifiDuzenle EditDensityClass = new YogunlukSinifiDuzenle();
            EditDensityClass.Show();
        }

        private void DensityClassFileNameOpenEvent(object sender, EventArgs e)
        {
            YogunlukSinifiDosyaAdi DensityClassFileName = new YogunlukSinifiDosyaAdi();
            DensityClassFileName.Show();
        }

        private void DeleteDensityClassOpenEvent(object sender, EventArgs e)
        {
            YogunlukSinifiSil DeleteDensityClass = new YogunlukSinifiSil();
            DeleteDensityClass.Show();
        }
        //

        public static SqlTableCheckYogunlukSinifi SqlTableCheck = new SqlTableCheckYogunlukSinifi();
        public string no;

        public void yogunluksinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
          
            yogunluksinifidatagridview.DataSource = null;
            yogunluksinifidatagridview.DataSource = SqlTableCheck.ShowData();


            yogunluksinifidatagridview.Columns[1].Visible = false;
            yogunluksinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1543_1;
            yogunluksinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            yogunluksinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            yogunluksinifidatagridview.Columns[2].DataPropertyName = "yogunluksinifi";
            yogunluksinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            yogunluksinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }
        private void yogunluksinifidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = yogunluksinifidatagridview.CurrentRow.Cells[1].Value.ToString();
        }

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

            ES1543_1.Text = Localization.Localization.ES1543_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void BetonYogunlukSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            yogunluksinifigetir();
        }

    }
}
