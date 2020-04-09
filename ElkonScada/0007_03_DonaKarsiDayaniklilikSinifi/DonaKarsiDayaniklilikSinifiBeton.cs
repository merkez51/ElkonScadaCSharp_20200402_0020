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

namespace ElkonScada._0007_03_DonaKarsiDayaniklilikSinifi
{
    public partial class DonaKarsiDayaniklilikSinifiBeton : Form
    {

        public DonaKarsiDayaniklilikSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewResistanceClassToFrostOpenEvent(object sender, EventArgs e)
        {
            DonaKarsiDayaniklilikSinifiYeni NewResistanceClassToFrost = new DonaKarsiDayaniklilikSinifiYeni();
            NewResistanceClassToFrost.Show();
        }

        private void EditResistanceClassToFrostOpenEvent(object sender, EventArgs e)
        {
            DonaKarsiDayaniklilikSinifiDuzenle EditResistanceClassToFrost = new DonaKarsiDayaniklilikSinifiDuzenle();
            EditResistanceClassToFrost.Show();
        }

        private void ResistanceClassToFrostFileNameOpenEvent(object sender, EventArgs e)
        {
            DonaKarsiDayaniklilikSinifiDosyaAdi ResistanceClassToFrostFileName = new DonaKarsiDayaniklilikSinifiDosyaAdi();
            ResistanceClassToFrostFileName.Show();
        }

        private void DeleteResistanceClassToFrostOpenEvent(object sender, EventArgs e)
        {
            DonaKarsiDayaniklilikSinifiSil DeleteResistanceClassToFrost = new DonaKarsiDayaniklilikSinifiSil();
            DeleteResistanceClassToFrost.Show();
        }
        //

        public static SqlTableCheckDonaKarsiDS SqlTableCheck = new SqlTableCheckDonaKarsiDS();
        public string no;

        public void donakarsidayanikliliksinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            donakarsidayanikliliksinifidatagridview.DataSource = null;
            donakarsidayanikliliksinifidatagridview.DataSource = SqlTableCheck.ShowData();


            donakarsidayanikliliksinifidatagridview.Columns[1].Visible = false;
            donakarsidayanikliliksinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1541_1;
            donakarsidayanikliliksinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            donakarsidayanikliliksinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            donakarsidayanikliliksinifidatagridview.Columns[2].DataPropertyName = "DonaKarsiDayaniklilikSinifi";
            donakarsidayanikliliksinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            donakarsidayanikliliksinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void donakarsidayanikliliksinifidatagridview_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            no = donakarsidayanikliliksinifidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1541_1.Text = Localization.Localization.ES1541_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //
        private void BetonDonaKarsiDayaniklilikSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            donakarsidayanikliliksinifigetir();
        }

    }
}
