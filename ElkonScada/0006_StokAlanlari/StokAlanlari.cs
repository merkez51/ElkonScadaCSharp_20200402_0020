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

namespace ElkonScada._0006_StokAlanlari
{
    public partial class StokAlanlari : Form
    {

        public StokAlanlari()
        {
            InitializeComponent();
        }


        //sayfa açma
        private void EditStorageAreaOpenEvent(object sender, EventArgs e)
        {
            StokAlaniDuzenle EditStorageArea = new StokAlaniDuzenle();
            EditStorageArea.Show();
        }

        private void StorageAreaFileNameOpenEvent(object sender, EventArgs e)
        {
            StokAlaniDosyaAdi StorageAreaFileName = new StokAlaniDosyaAdi();
            StorageAreaFileName.Show();
        }

        private void DeleteStorageAreaOpenEvent(object sender, EventArgs e)
        {
            StokAlaniSil DeleteStorageArea = new StokAlaniSil();
            DeleteStorageArea.Show();
        }

        private void QuickEditStorageAreaOpenEvent(object sender, EventArgs e)
        {
            StokAlaniHizliDuzenle QuickEditStorageArea = new StokAlaniHizliDuzenle();
            QuickEditStorageArea.Show();
        }
        //

        public static SqlTableCheckStokAlanlari SqlTableCheck = new SqlTableCheckStokAlanlari();
        public string no;

        public void stokalanigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
      
            stokalanlaridatagridview.DataSource = null;
            stokalanlaridatagridview.DataSource = SqlTableCheck.ShowData();


            stokalanlaridatagridview.Columns[1].Visible = false;
            stokalanlaridatagridview.Columns[2].HeaderText = Localization.Localization.ES907_1;
            stokalanlaridatagridview.Columns[3].HeaderText = Localization.Localization.ES807_1;
            stokalanlaridatagridview.Columns[4].HeaderText = Localization.Localization.ES1612_1;
            stokalanlaridatagridview.Columns[5].HeaderText = Localization.Localization.ES1613_1;
            stokalanlaridatagridview.Columns[6].HeaderText = Localization.Localization.ES437_1;
            stokalanlaridatagridview.Columns[7].HeaderText = Localization.Localization.ES438_1;
            stokalanlaridatagridview.Columns[8].HeaderText = Localization.Localization.ES391_1;
            stokalanlaridatagridview.Columns[2].DataPropertyName = "StokAlaniAdi";
            stokalanlaridatagridview.Columns[3].DataPropertyName = "MalzemeAdi";
            stokalanlaridatagridview.Columns[4].DataPropertyName = "Aciklama1";
            stokalanlaridatagridview.Columns[5].DataPropertyName = "Aciklama2";
            stokalanlaridatagridview.Columns[6].DataPropertyName = "Kapasite";
            stokalanlaridatagridview.Columns[7].DataPropertyName = "KritikSeviye";
            stokalanlaridatagridview.Columns[8].DataPropertyName = "Durumu";

        }

        private void stokalanlaridatagridview_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            no = stokalanlaridatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES2023_1.Text = Localization.Localization.ES2023_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES26_1.Text = Localization.Localization.ES26_1;
            ES786_1.Text = Localization.Localization.ES786_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void StokAlanlari_Load(object sender, EventArgs e)
        {
            DilDegistir();
            stokalanigetir();
        }


    }
}
