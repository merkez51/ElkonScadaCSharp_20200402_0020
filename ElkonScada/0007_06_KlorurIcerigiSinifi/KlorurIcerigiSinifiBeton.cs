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

namespace ElkonScada._0007_06_KlorurIcerigiSinifi
{
    public partial class KlorurIcerigiSinifiBeton : Form
    {
        public KlorurIcerigiSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewChlorideContentClassOpenEvent(object sender, EventArgs e)
        {
            KlorurIcerigiSinifiYeni NewChlorideContentClass = new KlorurIcerigiSinifiYeni();
            NewChlorideContentClass.Show();
        }

        private void EditChlorideContentClassOpenEvent(object sender, EventArgs e)
        {
            KlorurIcerigiSinifiDuzenle EditChlorideContentClass = new KlorurIcerigiSinifiDuzenle();
            EditChlorideContentClass.Show();
        }

        private void ChlorideContentClassFileNameOpenEvent(object sender, EventArgs e)
        {
            KlorurIcerigiSinifiDosyaAdi ChlorideContentClassFileName = new KlorurIcerigiSinifiDosyaAdi();
            ChlorideContentClassFileName.Show();
        }

        private void DeleteChlorideContentClassOpenEvent(object sender, EventArgs e)
        {
            KlorurIcerigiSinifiSil DeleteChlorideContentClass = new KlorurIcerigiSinifiSil();
            DeleteChlorideContentClass.Show();
        }

        //

        public static SqlTableCheckKlorurIcerigiSinifi SqlTableCheck = new SqlTableCheckKlorurIcerigiSinifi();
        public string no;

        public void kloruricerigisinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            kloruricerigisinifidatagridview.DataSource = null;
            kloruricerigisinifidatagridview.DataSource = SqlTableCheck.ShowData();


            kloruricerigisinifidatagridview.Columns[1].Visible = false;
            kloruricerigisinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1544_1;
            kloruricerigisinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            kloruricerigisinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            kloruricerigisinifidatagridview.Columns[2].DataPropertyName = "kloruricerigisinifi";
            kloruricerigisinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            kloruricerigisinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void kloruricerigisinifidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = kloruricerigisinifidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1544_1.Text = Localization.Localization.ES1544_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void BetonKlorurIcerigiSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            kloruricerigisinifigetir();
        }

    }
}
