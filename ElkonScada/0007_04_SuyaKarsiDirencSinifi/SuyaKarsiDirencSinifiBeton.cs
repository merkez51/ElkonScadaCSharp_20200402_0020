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

namespace ElkonScada._0007_04_SuyaKarsiDirencSinifi
{
    public partial class SuyaKarsiDirencSinifiBeton : Form
    {

        public SuyaKarsiDirencSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void ResistanceClassToWaterOpenEvent(object sender, EventArgs e)
        {
            SuyaKarsiDirencSinifiYeni NewResistanceClassToWater = new SuyaKarsiDirencSinifiYeni();
            NewResistanceClassToWater.Show();
        }

        private void EditResistanceClassToWaterOpenEvent(object sender, EventArgs e)
        {
            SuyaKarsiDirencSinifiDuzenle EditResistanceClassToWater = new SuyaKarsiDirencSinifiDuzenle();
            EditResistanceClassToWater.Show();
        }

        private void ResistanceClassToWaterFileNameOpenEvent(object sender, EventArgs e)
        {
            SuyaKarsiDirencSinifiDosyaAdi ResistanceClassToWaterFileName = new SuyaKarsiDirencSinifiDosyaAdi();
            ResistanceClassToWaterFileName.Show();
        }

        private void DeleteResistanceClassToWaterOpenEvent(object sender, EventArgs e)
        {
            SuyaKarsiDirencSinifiSil DeleteResistanceClassToWater = new SuyaKarsiDirencSinifiSil();
            DeleteResistanceClassToWater.Show();
        }
        //

        public static SqlTableCheckSuyaKarsiDS SqlTableCheck = new SqlTableCheckSuyaKarsiDS();
        public string no;

        public void suyakarsidirencsinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
      
            suyakarsidirencsinifidatagridview.DataSource = null;
            suyakarsidirencsinifidatagridview.DataSource = SqlTableCheck.ShowData();


            suyakarsidirencsinifidatagridview.Columns[1].Visible = false;
            suyakarsidirencsinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1542_1;
            suyakarsidirencsinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            suyakarsidirencsinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            suyakarsidirencsinifidatagridview.Columns[2].DataPropertyName = "suyakarsidirencsinifi";
            suyakarsidirencsinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            suyakarsidirencsinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void suyakarsidirencsinifidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = suyakarsidirencsinifidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1542_1.Text = Localization.Localization.ES1542_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void BetonSuyaKarsiDirencSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            suyakarsidirencsinifigetir();
        }


    }
}
