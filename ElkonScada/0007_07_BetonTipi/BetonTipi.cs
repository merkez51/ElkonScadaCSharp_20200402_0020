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

namespace ElkonScada._0007_07_BetonTipi
{
    public partial class BetonTipi : Form
    {

        public BetonTipi()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewConcreteTypeOpenEvent(object sender, EventArgs e)
        {
            BetonTipiYeni NewConcreteType = new BetonTipiYeni();
            NewConcreteType.Show();
        }

        private void EditConcreteTypeOpenEvent(object sender, EventArgs e)
        {
            BetonTipiDuzenle EditConcreteType = new BetonTipiDuzenle();
            EditConcreteType.Show();
        }


        private void ConcreteTypeFileNameOpenEvent(object sender, EventArgs e)
        {
            BetonTipiDosyaAdi ConcreteTypeFileName = new BetonTipiDosyaAdi();
            ConcreteTypeFileName.Show();
        }

        private void DeleteConcreteTypeOpenEvent(object sender, EventArgs e)
        {
            BetonTipiSil DeleteConcreteType = new BetonTipiSil();
            DeleteConcreteType.Show();
        }


        //

        public static SqlTableCheckBetonTipi SqlTableCheck = new SqlTableCheckBetonTipi();
        public string no;

        public void betontipigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
      
            betontipidatagridview.DataSource = null;
            betontipidatagridview.DataSource = SqlTableCheck.ShowData();


            betontipidatagridview.Columns[1].Visible = false;
            betontipidatagridview.Columns[2].HeaderText = Localization.Localization.ES1947_1;
            betontipidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            betontipidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            betontipidatagridview.Columns[2].DataPropertyName = "betontipi";
            betontipidatagridview.Columns[3].DataPropertyName = "Aciklama";
            betontipidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void betontipidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = betontipidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1947_1.Text = Localization.Localization.ES1947_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void BetonTipi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            betontipigetir();
        }
    }
}
