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

namespace ElkonScada._0008_Siparisler
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }


        //sayfa açma
        private void NewOrderOpenEvent(object sender, EventArgs e)
        {
            YeniSiparis NewOrder = new YeniSiparis();
            NewOrder.Show();
        }
        
        private void DeleteOrderOpenEvent(object sender, EventArgs e)
        {
            SiparisSil DeleteOrder = new SiparisSil();
            DeleteOrder.Show();
        }

        private void EditOrderOpenEvent(object sender, EventArgs e)
        {
            SiparisDuzenle EditOrder = new SiparisDuzenle();
            EditOrder.Show();
        }

        private void OrderImportOpenEvent(object sender, EventArgs e)
        {
            SiparisDosyaYoluImport OrderImport = new SiparisDosyaYoluImport();
            OrderImport.Show();
        }

        private void OrderFileNameOpenEvent(object sender, EventArgs e)
        {
            SiparisDosyaAdi OrderFileName = new SiparisDosyaAdi();
            OrderFileName.Show();
        }

        //

        public static SqlTableCheckSiparisler SqlTableCheck = new SqlTableCheckSiparisler();
        public string no, santiyeadi, firmaadi, receteadi, siparismiktari;

        public void siparisgetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
           
            siparislerdatagridview.DataSource = null;
            siparislerdatagridview.DataSource = SqlTableCheck.ShowData();


            siparislerdatagridview.Columns[1].Visible = false;
            siparislerdatagridview.Columns[2].HeaderText = Localization.Localization.ES952_1;
            siparislerdatagridview.Columns[3].HeaderText = Localization.Localization.ES834_1;
            siparislerdatagridview.Columns[4].HeaderText = Localization.Localization.ES810_1;
            siparislerdatagridview.Columns[5].HeaderText = Localization.Localization.ES856_1;
            siparislerdatagridview.Columns[6].HeaderText = Localization.Localization.ES950_1;
            siparislerdatagridview.Columns[7].HeaderText = Localization.Localization.ES956_1;
            siparislerdatagridview.Columns[8].HeaderText = Localization.Localization.ES955_1;
            siparislerdatagridview.Columns[2].DataPropertyName = "SiparisNo";
            siparislerdatagridview.Columns[3].DataPropertyName = "FirmaAdi";
            siparislerdatagridview.Columns[4].DataPropertyName = "SantiyeAdi";
            siparislerdatagridview.Columns[5].DataPropertyName = "SiparisMiktari";
            siparislerdatagridview.Columns[6].DataPropertyName = "ReceteAdi";
            siparislerdatagridview.Columns[7].DataPropertyName = "YapilanMiktar";
            siparislerdatagridview.Columns[8].DataPropertyName = "KalanMiktar";

        }

        private void siparislerdatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = siparislerdatagridview.CurrentRow.Cells[1].Value.ToString();
            firmaadi = siparislerdatagridview.CurrentRow.Cells[3].Value.ToString();
            santiyeadi = siparislerdatagridview.CurrentRow.Cells[4].Value.ToString();
            receteadi = siparislerdatagridview.CurrentRow.Cells[6].Value.ToString();
            siparismiktari = siparislerdatagridview.CurrentRow.Cells[5].Value.ToString();
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

            ES843_1.Text = Localization.Localization.ES843_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
        }
        //

        private void Siparisler_Load(object sender, EventArgs e)
        {
            DilDegistir();
            siparisgetir();
        }
    }
}
