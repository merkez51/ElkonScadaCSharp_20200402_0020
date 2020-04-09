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

namespace ElkonScada._0005_Malzemeler
{
    public partial class Malzemeler : Form
    {

        public Malzemeler()
        {
            InitializeComponent();
        }

        private void NewMaterialOpenEvent(object sender, EventArgs e)
        {
            MalzemeYeni NewMaterial = new MalzemeYeni();
            NewMaterial.Show();
        }

        private void EditMaterialInfoOpenEvent(object sender, EventArgs e)
        {
            MalzemeBilgileriDuzenle EditMaterialInfo = new MalzemeBilgileriDuzenle();
            EditMaterialInfo.Show();
        }

        private void FiberMaterialOpenEvent(object sender, EventArgs e)
        {
            MalzemeFiber FiberMaterial = new MalzemeFiber();
            FiberMaterial.Show();
        }

        private void MaterialFileNameOpenEvent(object sender, EventArgs e)
        {
            MalzemeDosyaAdi MaterialFileName = new MalzemeDosyaAdi();
            MaterialFileName.Show();

        }

        private void DeleteMaterialOpenEvent(object sender, EventArgs e)
        {
            MalzemeSil DeleteMaterial = new MalzemeSil();
            DeleteMaterial.Show();
        }
        //

        public static SqlTableCheckMalzemeler SqlTableCheck = new SqlTableCheckMalzemeler();
        public string no;

        public void malzemegetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();

            malzemelerdatagridview.DataSource = null;
            malzemelerdatagridview.DataSource = SqlTableCheck.ShowData();

            malzemelerdatagridview.Columns[1].Visible = false;
            malzemelerdatagridview.Columns[2].HeaderText = Localization.Localization.ES807_1;
            malzemelerdatagridview.Columns[3].HeaderText = "Malzeme Tipi";
            malzemelerdatagridview.Columns[4].HeaderText = Localization.Localization.ES1612_1;
            malzemelerdatagridview.Columns[5].HeaderText = Localization.Localization.ES1613_1;
            malzemelerdatagridview.Columns[6].HeaderText = Localization.Localization.ES391_1;


            malzemelerdatagridview.Columns[2].DataPropertyName = "MalzemeAdi";
            malzemelerdatagridview.Columns[3].DataPropertyName = "MalzemeType";
            malzemelerdatagridview.Columns[4].DataPropertyName = "Aciklama1";
            malzemelerdatagridview.Columns[5].DataPropertyName = "Aciklama2";
            malzemelerdatagridview.Columns[6].DataPropertyName = "Durumu";

         
            for (int i = 0; i < malzemelerdatagridview.Rows.Count; i++)
            {
                char[] TrimKey = malzemelerdatagridview.Rows[i].Cells[3].Value.ToString().ToCharArray();
                switch (TrimKey[0])
                {
                    case '1':
                        malzemelerdatagridview.Rows[i].Cells[3].Value = Localization.Localization.ES96_1;
                        break;
                    case '2':
                        malzemelerdatagridview.Rows[i].Cells[3].Value = Localization.Localization.ES208_1;

                        break;
                    case '3':
                        malzemelerdatagridview.Rows[i].Cells[3].Value = Localization.Localization.ES99_1;

                        break;
                    case '4':
                        malzemelerdatagridview.Rows[i].Cells[3].Value = Localization.Localization.ES98_1;

                        break;
                    default:
                        //  malzemelerdatagridview.Rows[i].Cells[3].Value = "-";
                        break;
                }
            }
        }

        private void malzemelerdatagridview_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            no = malzemelerdatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES25_1.Text = Localization.Localization.ES25_1;
            ES2030_0.Text = Localization.Localization.ES2030_0;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
        }
        //

        private void Malzemeler_Load(object sender, EventArgs e)
        {
            DilDegistir();
            malzemegetir();
        }


    }
}
