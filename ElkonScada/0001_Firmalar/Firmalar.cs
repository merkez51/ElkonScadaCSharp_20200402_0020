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
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace ElkonScada._0001_Firmalar
{

    public partial class Firmalar : Form
    {

        public Firmalar()
        {
            InitializeComponent();
        }

        //Sayfa Açma
        private void NewCompanyOpenEvent(object sender, EventArgs e)
        {
            FirmaYeni NewCompany = new FirmaYeni();
            NewCompany.Show();
        }

        private void EditCompanyInfoOpenEvent(object sender, EventArgs e)
        {
            FirmaBilgileriDuzenle EditCompanyInfo = new FirmaBilgileriDuzenle();
            EditCompanyInfo.Show();
        }

        private void DeleteCompanyOpenEvent(object sender, EventArgs e)
        {
            FirmaSil DeleteCompany = new FirmaSil();
            DeleteCompany.Show();
        }

        private void CompanyImportOpenEvent(object sender, EventArgs e)
        {
            FirmaDosyaYoluImport CompanyImport = new FirmaDosyaYoluImport();
            CompanyImport.Show();
        }

        private void CompanyFileNameOpenEvent(object sender, EventArgs e)
        {
            FirmaDosyaAdi CompanyFileName = new FirmaDosyaAdi();
            CompanyFileName.Show();
        }
        //

        public static SqlTableCheckFirmalar sqlTableCheck = new SqlTableCheckFirmalar();
        public string no;

        public void firmagetir()
        {

            bool tablo = sqlTableCheck.DataBaseOlustur();
           
            firmalardatagridview.DataSource = null;
            firmalardatagridview.DataSource = sqlTableCheck.ShowData();


            firmalardatagridview.Columns[1].Visible = false;
            firmalardatagridview.Columns[2].HeaderText = Localization.Localization.ES834_1;
            firmalardatagridview.Columns[3].HeaderText = Localization.Localization.ES147_1;
            firmalardatagridview.Columns[4].HeaderText = Localization.Localization.ES148_1;
            firmalardatagridview.Columns[5].HeaderText = Localization.Localization.ES128_1;
            firmalardatagridview.Columns[6].HeaderText = Localization.Localization.ES150_1;
            firmalardatagridview.Columns[7].HeaderText = Localization.Localization.ES130_1;
            firmalardatagridview.Columns[8].HeaderText = Localization.Localization.ES391_1;
            firmalardatagridview.Columns[2].DataPropertyName = "FirmaAdi";
            firmalardatagridview.Columns[3].DataPropertyName = "TelefonFaks";
            firmalardatagridview.Columns[4].DataPropertyName = "Adres";
            firmalardatagridview.Columns[5].DataPropertyName = "IlgiliKisi";
            firmalardatagridview.Columns[6].DataPropertyName = "VergiDairesi";
            firmalardatagridview.Columns[7].DataPropertyName = "VergiNumarasi";
            firmalardatagridview.Columns[8].DataPropertyName = "Durumu";

        }
        private void firmalardatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = firmalardatagridview.CurrentRow.Cells[1].Value.ToString();

        }

        //
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

            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES21_1.Text = Localization.Localization.ES21_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //
        private void Firmalar_Load(object sender, EventArgs e)
        {
            DilDegistir();
            firmagetir();

        }

        private void firmalardatagridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //firmalardatagridview.Rows[0].Selected = false;
        }

        public void disaaktar()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < firmalardatagridview.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = firmalardatagridview.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < firmalardatagridview.Rows.Count; i++)
            {
                for (int j = 0; j < firmalardatagridview.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = firmalardatagridview[j, i].Value == null ? "" : firmalardatagridview[j, i].Value;
                    myRange.Select();
                }
            }
        }

        //public void iceaktar()
        //{
        //    if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
        //    FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
        //    IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(file);
        //    DataSet dataSet = excelDataReader.AsDataSet();

        //    DataClasses1DataContext conn = new DataClasses1DataContext();
        //    int atla = 0;
        //    foreach (System.Data.DataTable table in dataSet.Tables)
        //    {
        //        foreach (DataRow dataRow in table.Rows)
        //        {
        //            if (atla > 0)
        //            {
        //                Receteler receteler = new Receteler()
        //                {



        //                }; conn.Recetelers.InsertOnSubmit(receteler);
        //            }
        //            atla++;
        //        }

        //    }
        //    conn.SubmitChanges();
        //    excelDataReader.Close();
        //    file.Close();
        //    MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "uyarı", MessageBoxButtons.OK);
        //}
    }
}

