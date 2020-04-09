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

namespace ElkonScada._0004_Santiyeler
{
    public partial class Santiyeler : Form
    {

        public Santiyeler()
        {
            InitializeComponent();
        }
        //sayfa açma
        private void NewJobsiteOpenEvent(object sender, EventArgs e)
        {
            SantiyeYeni NewJobsite = new SantiyeYeni();
            NewJobsite.Show();
        }

        private void EditJobsiteInfoOpenEvent(object sender, EventArgs e)
        {
            SantiyeBilgileriDuzenle EditJobsiteInfo = new SantiyeBilgileriDuzenle();
            EditJobsiteInfo.Show();
        }

        private void JobsiteImportOpenEvent(object sender, EventArgs e)
        {
            SantiyeDosyaYoluImport JobsiteImport = new SantiyeDosyaYoluImport();
            JobsiteImport.Show();
        }

        private void JobsiteFileNameOpenEvent(object sender, EventArgs e)
        {
            SantiyeDosyaAdi JobsiteFileName = new SantiyeDosyaAdi();
            JobsiteFileName.Show();
        }

        private void DeleteJobsiteOpenEvent(object sender, EventArgs e)
        {
            SantiyeSil DeleteJobsite = new SantiyeSil();
            DeleteJobsite.Show();
        }
        //

        public static SqlTableCheckSantiyeler SqlTableCheck = new SqlTableCheckSantiyeler();
        public string no;

        public void santiyegetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
          
            santiyelerdatagridview.DataSource = null;
            santiyelerdatagridview.DataSource = SqlTableCheck.ShowData();

            santiyelerdatagridview.Columns[1].Visible = false;
            santiyelerdatagridview.Columns[2].HeaderText = Localization.Localization.ES810_1;
            santiyelerdatagridview.Columns[3].HeaderText = Localization.Localization.ES147_1;
            santiyelerdatagridview.Columns[4].HeaderText = Localization.Localization.ES148_1;
            santiyelerdatagridview.Columns[5].HeaderText = Localization.Localization.ES834_1;
            santiyelerdatagridview.Columns[6].HeaderText = Localization.Localization.ES413_1;
            santiyelerdatagridview.Columns[7].HeaderText = Localization.Localization.ES403_1;
            santiyelerdatagridview.Columns[8].HeaderText = Localization.Localization.ES391_1;
            santiyelerdatagridview.Columns[2].DataPropertyName = "SantiyeAdi";
            santiyelerdatagridview.Columns[3].DataPropertyName = "TelefonFaks";
            santiyelerdatagridview.Columns[4].DataPropertyName = "Adres";
            santiyelerdatagridview.Columns[5].DataPropertyName = "FirmaAdi";
            santiyelerdatagridview.Columns[6].DataPropertyName = "Mesafe";
            santiyelerdatagridview.Columns[7].DataPropertyName = "Aciklama";
            santiyelerdatagridview.Columns[8].DataPropertyName = "Durumu";

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
            ES23_1.Text = Localization.Localization.ES23_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
            
        }
        //

        private void Santiyeler_Load(object sender, EventArgs e)
        {
            DilDegistir();
            santiyegetir();
        }

     
        private void santiyelerdatagridview_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            no = santiyelerdatagridview.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
