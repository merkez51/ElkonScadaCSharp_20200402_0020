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

namespace ElkonScada._0002_Araclar
{
    public partial class Araclar : Form
    {

        public Araclar()
        {
            InitializeComponent();
        }


        //sayfa açma
        private void NewVehicleOpenEvent(object sender, EventArgs e)
        {
            AracYeni NewVehicle = new AracYeni();
            NewVehicle.Show();
        }

        private void EditVehicleInfoOpenEvent(object sender, EventArgs e)
        {
            AracBilgileriDuzenle EditVehicleInfo = new AracBilgileriDuzenle();
            EditVehicleInfo.Show();
        }

        private void VehicleImportOpenEvent(object sender, EventArgs e)
        {
            AracDosyaYoluImport VehicleImport = new AracDosyaYoluImport();
            VehicleImport.Show();
        }

        private void VehicleFileNameOpenEvent(object sender, EventArgs e)
        {
            AracDosyaAdi VehicleFileName = new AracDosyaAdi();
            VehicleFileName.Show();
        }


        private void DeleteVehicleOpenEvent(object sender, EventArgs e)
        {
            AracSil DeleteVehicle = new AracSil();
            DeleteVehicle.Show();
        }
        //

        public static SqlTableCheckAraclar SqlTableCheck = new SqlTableCheckAraclar();
        public string no;

        public void aracgetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            araclardatagridview.DataSource = null;
            araclardatagridview.DataSource = SqlTableCheck.ShowData();


            araclardatagridview.Columns[1].Visible = false;
            araclardatagridview.Columns[2].HeaderText = Localization.Localization.ES22_1;
            araclardatagridview.Columns[3].HeaderText = Localization.Localization.ES834_1;
            araclardatagridview.Columns[4].HeaderText = Localization.Localization.ES404_1;
            araclardatagridview.Columns[5].HeaderText = Localization.Localization.ES437_1;
            araclardatagridview.Columns[6].HeaderText = Localization.Localization.ES1534_1;
            araclardatagridview.Columns[7].HeaderText = Localization.Localization.ES2061_0;
            araclardatagridview.Columns[8].HeaderText = Localization.Localization.ES391_1;
            araclardatagridview.Columns[2].DataPropertyName = "AracPlakaNo";
            araclardatagridview.Columns[3].DataPropertyName = "FirmaAdi";
            araclardatagridview.Columns[4].DataPropertyName = "SurucuAdiSoyadi";
            araclardatagridview.Columns[5].DataPropertyName = "Kapasite";
            araclardatagridview.Columns[6].DataPropertyName = "AracTipi";
            araclardatagridview.Columns[7].DataPropertyName = "AracMarkasi";
            araclardatagridview.Columns[8].DataPropertyName = "Durumu";

        }
        private void araclardatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = araclardatagridview.CurrentRow.Cells[1].Value.ToString();
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
            ES22_1.Text = Localization.Localization.ES22_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //
        private void Araclar_Load(object sender, EventArgs e)
        {
            DilDegistir();
            aracgetir();
        }
    }
}
