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
    public partial class Suruculer : Form
    {

        public Suruculer()
        {
            InitializeComponent();
        }
        //sayfa açma
        private void NewDriverOpenEvent(object sender, EventArgs e)
        {
            SurucuYeni NewDriver = new SurucuYeni();
            NewDriver.Show();
        }

        private void EditDriverInfoOpenEvent(object sender, EventArgs e)
        {
            SurucuBilgileriDuzenle EditDriverInfo = new SurucuBilgileriDuzenle();
            EditDriverInfo.Show();
        }

        private void DriverImportOpenEvent(object sender, EventArgs e)
        {
            SurucuDosyaYoluImport DriverImport = new SurucuDosyaYoluImport();
            DriverImport.Show();
        }

        private void DriverFileNameOpenEvent(object sender, EventArgs e)
        {
            SurucuDosyaAdi DriverFileName = new SurucuDosyaAdi();
            DriverFileName.Show();
        }

        private void DeleteDriverOpenEvent(object sender, EventArgs e)
        {
            SurucuSil DeleteDriver = new SurucuSil();
            DeleteDriver.Show();
        }
        //

        public static SqlTableCheckSuruculer SqlTableCheck = new SqlTableCheckSuruculer();
        public string no;

        public void surucugetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
       
            suruculerdatagridview.DataSource = null;
            suruculerdatagridview.DataSource = SqlTableCheck.ShowData();


            suruculerdatagridview.Columns[1].Visible = false;
            suruculerdatagridview.Columns[2].HeaderText = Localization.Localization.ES404_1;
            suruculerdatagridview.Columns[3].HeaderText = Localization.Localization.ES148_1;
            suruculerdatagridview.Columns[4].HeaderText = Localization.Localization.ES147_1;
            suruculerdatagridview.Columns[5].HeaderText = Localization.Localization.ES403_1;
            suruculerdatagridview.Columns[6].HeaderText = Localization.Localization.ES391_1;
            suruculerdatagridview.Columns[2].DataPropertyName = "SurucuAdiSoyadi";
            suruculerdatagridview.Columns[3].DataPropertyName = "Adres";
            suruculerdatagridview.Columns[4].DataPropertyName = "TelefonFaks";
            suruculerdatagridview.Columns[5].DataPropertyName = "Aciklama";
            suruculerdatagridview.Columns[6].DataPropertyName = "Durumu";

        }

        private void suruculerdatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = suruculerdatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES24_1.Text = Localization.Localization.ES24_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void Suruculer_Load(object sender, EventArgs e)
        {
            DilDegistir();
            surucugetir();
        }


    }
}
