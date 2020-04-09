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

namespace ElkonScada._0007_08_CevreselEtki
{
    public partial class CevreselEtki : Form
    {

        public CevreselEtki()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void NewEnvironmentalImpactOpenEvent(object sender, EventArgs e)
        {
            CevreselEtkiYeni NewEnvironmentalImpact = new CevreselEtkiYeni();
            NewEnvironmentalImpact.Show();
        }

        private void EditEnvironmentalImpactOpenEvent(object sender, EventArgs e)
        {
            CevreselEtkiDuzenle EditEnvironmentalImpact = new CevreselEtkiDuzenle();
            EditEnvironmentalImpact.Show();
        }

        private void EnvironmentalImpactFileNameOpenEvent(object sender, EventArgs e)
        {
            CevreselEtkiDosyaAdi EnvironmentalImpactFileName = new CevreselEtkiDosyaAdi();
            EnvironmentalImpactFileName.Show();
        }

        private void DeleteEnvironmentalImpactOpenEvent(object sender, EventArgs e)
        {
            CevreselEtkiSil DeleteEnvironmentalImpact = new CevreselEtkiSil();
            DeleteEnvironmentalImpact.Show();
        }

        //


        public static SqlTableCheckCevreselEtki SqlTableCheck = new SqlTableCheckCevreselEtki();
        public string no;

        public void cevreseletkigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            cevreseletkidatagridview.DataSource = null;
            cevreseletkidatagridview.DataSource = SqlTableCheck.ShowData();


            cevreseletkidatagridview.Columns[1].Visible = false;
            cevreseletkidatagridview.Columns[2].HeaderText = Localization.Localization.ES2136_0;
            cevreseletkidatagridview.Columns[3].HeaderText = Localization.Localization.ES403_1;
            cevreseletkidatagridview.Columns[4].HeaderText = Localization.Localization.ES391_1;
            cevreseletkidatagridview.Columns[2].DataPropertyName = "CevreselEtki";
            cevreseletkidatagridview.Columns[3].DataPropertyName = "Aciklama";
            cevreseletkidatagridview.Columns[4].DataPropertyName = "Durumu";

        }

        private void cevreseletkidatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = cevreseletkidatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES2136_0.Text = Localization.Localization.ES2136_0;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void CevreselEtki_Load(object sender, EventArgs e)
        {
            DilDegistir();
            cevreseletkigetir();
        }

    }
}
