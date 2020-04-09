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

namespace ElkonScada._0007_01_DayanimSinifi
{
    public partial class DayanimSinifiBeton : Form
    {

        public DayanimSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewResistanceClassOpenEvent(object sender, EventArgs e)
        {
            DayanimSinifiYeni NewResistanceClass = new DayanimSinifiYeni();
            NewResistanceClass.Show();
        }

        private void EditResistanceClassOpenEvent(object sender, EventArgs e)
        {
            DayanimSinifiDuzenle EditresistanceClass = new DayanimSinifiDuzenle();
            EditresistanceClass.Show();
        }


        private void ResistanceClassFileNameOpenEvent(object sender, EventArgs e)
        {
            DayanimSinifiDosyaAdi ResistanceClassFileName = new DayanimSinifiDosyaAdi();
            ResistanceClassFileName.Show();
        }

        private void DeleteResistanceClassOpenEvent(object sender, EventArgs e)
        {
            DayanimSinifiSil DeleteResistanceClass = new DayanimSinifiSil();
            DeleteResistanceClass.Show();
        }
        //

        public static SqlTableCheckDayanimSinifi SqlTableCheck = new SqlTableCheckDayanimSinifi();
        public string no;

        public void dayanimsinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
       
            dayanimsinifidatagridview.DataSource = null;
            dayanimsinifidatagridview.DataSource = SqlTableCheck.ShowData();


            dayanimsinifidatagridview.Columns[1].Visible = false;
            dayanimsinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1539_1;
            dayanimsinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            dayanimsinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            dayanimsinifidatagridview.Columns[2].DataPropertyName = "DayanimSinifi";
            dayanimsinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            dayanimsinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void dayanimsinifidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = dayanimsinifidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1539_1.Text = Localization.Localization.ES1539_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;

        }
        //

        private void BetonDayanimSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            dayanimsinifigetir();
        }


    }
}
