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

namespace ElkonScada._0010_StokKayitlari
{
    public partial class StokKayitlari : Form
    {

        public StokKayitlari()
        {
            InitializeComponent();
        }


        //sayfa açma
        private void NewInventoryRecordOpenEvent(object sender, EventArgs e)
        {
            StokGirisiYeni NewInventoryRecord = new StokGirisiYeni();
            NewInventoryRecord.Show();
        }

        private void InventoryRecordFileNameOpenEvent(object sender, EventArgs e)
        {
            StokKayitlariDosyaAdi InventoryRecordFileName = new StokKayitlariDosyaAdi();
            InventoryRecordFileName.Show();
        }

        private void DeleteInventoryRecordOpenEvent(object sender, EventArgs e)
        {
            StokKayitlariSil DeleteInventoryRecord = new StokKayitlariSil();
            DeleteInventoryRecord.Show();
        }
        //

        public static SqlTableCheckStokKayitlari SqlTableCheck = new SqlTableCheckStokKayitlari();
        public string no;

        public void stokkaydigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
          
            stokkayitlaridatagridview.DataSource = null;
            stokkayitlaridatagridview.DataSource = SqlTableCheck.ShowData();


            stokkayitlaridatagridview.Columns[1].Visible = false;
            stokkayitlaridatagridview.Columns[2].HeaderText = Localization.Localization.ES910_1;
            stokkayitlaridatagridview.Columns[3].HeaderText = Localization.Localization.ES907_1;
            stokkayitlaridatagridview.Columns[4].HeaderText = Localization.Localization.ES807_1;
            stokkayitlaridatagridview.Columns[5].HeaderText = Localization.Localization.ES1612_1;
            stokkayitlaridatagridview.Columns[6].HeaderText = Localization.Localization.ES1613_1;
            stokkayitlaridatagridview.Columns[7].HeaderText = Localization.Localization.ES909_1;
            stokkayitlaridatagridview.Columns[8].HeaderText = Localization.Localization.ES1694_1;
            stokkayitlaridatagridview.Columns[9].HeaderText = Localization.Localization.ES912_1;
            stokkayitlaridatagridview.Columns[10].HeaderText = Localization.Localization.ES1691_1;
            stokkayitlaridatagridview.Columns[11].HeaderText = Localization.Localization.ES158_1;
            stokkayitlaridatagridview.Columns[2].DataPropertyName = "StokNo";
            stokkayitlaridatagridview.Columns[3].DataPropertyName = "StokAlaniAdi";
            stokkayitlaridatagridview.Columns[4].DataPropertyName = "MalzemeAdi";
            stokkayitlaridatagridview.Columns[5].DataPropertyName = "Aciklama1";
            stokkayitlaridatagridview.Columns[6].DataPropertyName = "Aciklama2";
            stokkayitlaridatagridview.Columns[7].DataPropertyName = "GirisMiktari";
            stokkayitlaridatagridview.Columns[8].DataPropertyName = "StokGirisiYapanKullanici";
            stokkayitlaridatagridview.Columns[9].DataPropertyName = "StokGirisTarihi";
            stokkayitlaridatagridview.Columns[10].DataPropertyName = "StokGirisSaati";
            stokkayitlaridatagridview.Columns[11].DataPropertyName = "Kapasite";

        }

        private void stokkayitlaridatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = stokkayitlaridatagridview.CurrentRow.Cells[1].Value.ToString();
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
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES764_1.Text = Localization.Localization.ES764_1;
            ES36_1.Text = Localization.Localization.ES36_1;
        }
        //

        private void StokKayitlari_Load(object sender, EventArgs e)
        {
            DilDegistir();
            stokkaydigetir();
        }

    }
}
