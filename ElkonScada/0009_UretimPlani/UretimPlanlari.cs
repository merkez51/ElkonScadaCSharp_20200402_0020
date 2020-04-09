using System;
using System.Globalization;
using System.Windows.Forms;

namespace ElkonScada._0009_UretimPlani
{
    public partial class UretimPlanlari : Form
    {

        public UretimPlanlari()
        {
            InitializeComponent();
        }
        //sayfa açma
        private void NewProductionPlanOpenEvent(object sender, EventArgs e)
        {
            UretimPlaniYeni NewProductionPlan = new UretimPlaniYeni();
            NewProductionPlan.Show();
        }

        private void EditProductionPlanOpenEvent(object sender, EventArgs e)
        {
            UretimPlanDuzenle EditProductPlan = new UretimPlanDuzenle();
            EditProductPlan.Show();
        }

        private void ProductionPlanFileNameOpenEvent(object sender, EventArgs e)
        {
            UretimPlaniDosyaAdi ProductionPlanFileName = new UretimPlaniDosyaAdi();
            ProductionPlanFileName.Show();
        }

        private void DeleteProductionPlanOpenEvent(object sender, EventArgs e)
        {
            UretimPlaniSil DeleteProductionPlan = new UretimPlaniSil();
            DeleteProductionPlan.Show();
        }
        //

        public static SqlTableCheckUretimPlani SqlTableCheck = new SqlTableCheckUretimPlani();
        public string no;

        public void uretimplanigetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            uretimplanlaridatagridview.DataSource = null;
            uretimplanlaridatagridview.DataSource = SqlTableCheck.ShowData();


            uretimplanlaridatagridview.Columns[1].Visible = false;
            uretimplanlaridatagridview.Columns[2].HeaderText = Localization.Localization.ES952_1;
            uretimplanlaridatagridview.Columns[3].HeaderText = Localization.Localization.ES1862_1;
            uretimplanlaridatagridview.Columns[4].HeaderText = Localization.Localization.ES849_1;
            uretimplanlaridatagridview.Columns[5].HeaderText = Localization.Localization.ES834_1;
            uretimplanlaridatagridview.Columns[6].HeaderText = Localization.Localization.ES810_1;
            uretimplanlaridatagridview.Columns[7].HeaderText = Localization.Localization.ES842_1;
            uretimplanlaridatagridview.Columns[8].HeaderText = Localization.Localization.ES404_1;
            uretimplanlaridatagridview.Columns[9].HeaderText = Localization.Localization.ES950_1;
            uretimplanlaridatagridview.Columns[10].HeaderText = Localization.Localization.ES949_1;
            uretimplanlaridatagridview.Columns[11].HeaderText = Localization.Localization.ES956_1;
            uretimplanlaridatagridview.Columns[12].HeaderText = Localization.Localization.ES955_1;
            uretimplanlaridatagridview.Columns[13].HeaderText = Localization.Localization.ES848_1;
            uretimplanlaridatagridview.Columns[14].HeaderText = Localization.Localization.ES2067_0;
            uretimplanlaridatagridview.Columns[15].HeaderText = Localization.Localization.ES2064_0;
            uretimplanlaridatagridview.Columns[16].HeaderText = Localization.Localization.ES2065_0;
            uretimplanlaridatagridview.Columns[17].HeaderText = Localization.Localization.ES2066_0;
            uretimplanlaridatagridview.Columns[2].DataPropertyName = "SiparisNo";
            uretimplanlaridatagridview.Columns[3].DataPropertyName = "UretimNo";
            uretimplanlaridatagridview.Columns[4].DataPropertyName = "ToplamSiparis";
            uretimplanlaridatagridview.Columns[5].DataPropertyName = "FirmaAdi";
            uretimplanlaridatagridview.Columns[6].DataPropertyName = "SantiyeAdi";
            uretimplanlaridatagridview.Columns[7].DataPropertyName = "AracPlakaNo";
            uretimplanlaridatagridview.Columns[8].DataPropertyName = "SurucuAdiSoyadi";
            uretimplanlaridatagridview.Columns[9].DataPropertyName = "ReceteAdi";
            uretimplanlaridatagridview.Columns[10].DataPropertyName = "GirisMiktari";
            uretimplanlaridatagridview.Columns[11].DataPropertyName = "YapilanMiktar";
            uretimplanlaridatagridview.Columns[12].DataPropertyName = "KalanMiktar";
            uretimplanlaridatagridview.Columns[13].DataPropertyName = "UretilecekMiktar";
            uretimplanlaridatagridview.Columns[14].DataPropertyName = "IadeUretimNo";
            uretimplanlaridatagridview.Columns[15].DataPropertyName = "IadeBetonMiktari";
            uretimplanlaridatagridview.Columns[16].DataPropertyName = "IadeBetonSinifi";
            uretimplanlaridatagridview.Columns[17].DataPropertyName = "IadeBetonAciklamasi";

        }


        private void firmalardatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = uretimplanlaridatagridview.CurrentRow.Cells[1].Value.ToString();
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

            ES1213_1.Text = Localization.Localization.ES1213_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES1560_1.Text = Localization.Localization.ES1560_1;
            ES762_1.Text = Localization.Localization.ES762_1;
            ES764_1.Text = Localization.Localization.ES764_1;
            ES866_1.Text = Localization.Localization.ES866_1;
            ES965_1.Text = Localization.Localization.ES965_1;
        }
        //

        private void UretimPlanlari_Load(object sender, EventArgs e)
        {
            DilDegistir();
            uretimplanigetir();
        }

    }
}
