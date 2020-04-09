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

namespace ElkonScada._0007_02_KivamSinifi
{
    public partial class KivamSinifiBeton : Form
    {

        public KivamSinifiBeton()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewConsistencyClassOpenEvent(object sender, EventArgs e)
        {
            KivamSinifiYeni NewConsistencyClass = new KivamSinifiYeni();
            NewConsistencyClass.Show();
        }

        private void EditConsistencyClassOpenEvent(object sender, EventArgs e)
        {
            KivamSinifiDuzenle EditConsistencyClass = new KivamSinifiDuzenle();
            EditConsistencyClass.Show();
        }

        private void ConsistencyClassFileNameOpenEvent(object sender, EventArgs e)
        {
            KivamSinifiDosyaAdi ConsistencyClassFileName = new KivamSinifiDosyaAdi();
            ConsistencyClassFileName.Show();
        }

        private void DeleteConsistencyClassOpenEvent(object sender, EventArgs e)
        {
            KivamSinifiSil DeleteConsistencyClass = new KivamSinifiSil();
            DeleteConsistencyClass.Show();
        }
        //

        public static SqlTableCheckKivamSinifi SqlTableCheck = new SqlTableCheckKivamSinifi();
        public string no;

        public void kivamsinifigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
  
            kivamsinifidatagridview.DataSource = null;
            kivamsinifidatagridview.DataSource = SqlTableCheck.ShowData();


            kivamsinifidatagridview.Columns[1].Visible = false;
            kivamsinifidatagridview.Columns[2].HeaderText = Localization.Localization.ES1540_1;
            kivamsinifidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            kivamsinifidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            kivamsinifidatagridview.Columns[2].DataPropertyName = "KivamSinifi";
            kivamsinifidatagridview.Columns[3].DataPropertyName = "Aciklama";
            kivamsinifidatagridview.Columns[4].DataPropertyName = "Durumu";

        }
        private void kivamsinifidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = kivamsinifidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1540_1.Text = Localization.Localization.ES1540_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void BetonKivamSinifi_Load(object sender, EventArgs e)
        {
            DilDegistir();
            kivamsinifigetir();
        }


    }
}
