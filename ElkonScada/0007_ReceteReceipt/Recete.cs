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
using System.IO;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Threading;

namespace ElkonScada._0007_ReceteReceipt
{
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }
        ElkonScada.XX_Connection.ModbusConnection PLCyeReceteGonder = ElkonScada.XX_Connection.ModbusConnection.HetConnection();
        //sayfa açma
        private void NewRecipeOpenEvent(object sender, EventArgs e)
        {
            ElkonScada._0007_ReceteReceipt.ReceteYeni NewRecipe = new ElkonScada._0007_ReceteReceipt.ReceteYeni();
            NewRecipe.Show();

        }

        private void EditRecipeOpenEvent(object sender, EventArgs e)
        {
            ElkonScada._0007_ReceteReceipt.ReceteDuzenle EditRecipe = new ElkonScada._0007_ReceteReceipt.ReceteDuzenle();
            EditRecipe.Show();
        }

        private void RecipeImportOpenEvent(object sender, EventArgs e)
        {
          //  iceaktarbtn_Click();
            ElkonScada._0007_ReceteReceipt.ReceteDosyaYoluImport RecipeImport = new ElkonScada._0007_ReceteReceipt.ReceteDosyaYoluImport();
            RecipeImport.Show();
        }

        private void RecipeFileNameOpenEvent(object sender, EventArgs e)
        {
            //disaaktarbtn_Click();
            ElkonScada._0007_ReceteReceipt.ReceteDosyaAdi RecipeFileName = new ElkonScada._0007_ReceteReceipt.ReceteDosyaAdi();
            RecipeFileName.Show();
        }

        private void DeleteRecipeOpenEvent(object sender, EventArgs e)
        {
            ElkonScada._0007_ReceteReceipt.ReceteSil DeleteRecipe = new ElkonScada._0007_ReceteReceipt.ReceteSil();
            DeleteRecipe.Show();
        }

        SqlTableCheckReceteler SqlTableCheck = new SqlTableCheckReceteler();
        public string no;

        public void recetegetir()
        {
            bool tablo = SqlTableCheck.DataBaseOlustur();

            recetelerdatagridview.DataSource = null;
            recetelerdatagridview.DataSource = SqlTableCheck.ShowData();
            

            recetelerdatagridview.Columns[1].Visible = false;
            recetelerdatagridview.Columns[2].HeaderText = Localization.Localization.ES442_1;
            recetelerdatagridview.Columns[3].HeaderText = Localization.Localization.ES444_1;
            recetelerdatagridview.Columns[4].HeaderText = Localization.Localization.ES194_1;
            recetelerdatagridview.Columns[5].HeaderText = Localization.Localization.ES197_1;
            recetelerdatagridview.Columns[6].HeaderText = Localization.Localization.ES198_1;
            recetelerdatagridview.Columns[7].HeaderText = Localization.Localization.ES199_1;
            recetelerdatagridview.Columns[8].HeaderText = Localization.Localization.ES493_1;
            recetelerdatagridview.Columns[9].HeaderText = Localization.Localization.ES494_1;
            recetelerdatagridview.Columns[10].HeaderText = Localization.Localization.ES495_1;
            recetelerdatagridview.Columns[11].HeaderText = Localization.Localization.ES495_1;
            recetelerdatagridview.Columns[12].HeaderText = Localization.Localization.ES497_1;
            recetelerdatagridview.Columns[13].HeaderText = Localization.Localization.ES498_1;
            recetelerdatagridview.Columns[14].HeaderText = Localization.Localization.ES220_1;
            recetelerdatagridview.Columns[15].HeaderText = Localization.Localization.ES499_1;
            recetelerdatagridview.Columns[16].HeaderText = Localization.Localization.ES500_1;
            recetelerdatagridview.Columns[17].HeaderText = Localization.Localization.ES501_1;
            recetelerdatagridview.Columns[18].HeaderText = Localization.Localization.ES502_1;
            recetelerdatagridview.Columns[19].HeaderText = Localization.Localization.ES503_1;
            recetelerdatagridview.Columns[20].HeaderText = Localization.Localization.ES504_1;
            recetelerdatagridview.Columns[21].HeaderText = Localization.Localization.ES505_1;
            recetelerdatagridview.Columns[22].HeaderText = Localization.Localization.ES506_1;
            recetelerdatagridview.Columns[23].HeaderText = Localization.Localization.ES507_1;
            recetelerdatagridview.Columns[24].HeaderText = Localization.Localization.ES75_1;
            recetelerdatagridview.Columns[25].HeaderText = Localization.Localization.ES76_1;
            recetelerdatagridview.Columns[26].HeaderText = Localization.Localization.ES509_1;
            recetelerdatagridview.Columns[27].HeaderText = Localization.Localization.ES510_1;
            recetelerdatagridview.Columns[28].HeaderText = Localization.Localization.ES511_1;
            recetelerdatagridview.Columns[29].HeaderText = Localization.Localization.ES512_1;
            recetelerdatagridview.Columns[30].HeaderText = Localization.Localization.ES513_1;
            recetelerdatagridview.Columns[31].HeaderText = Localization.Localization.ES514_1;
            recetelerdatagridview.Columns[32].HeaderText = Localization.Localization.ES515_1;
            recetelerdatagridview.Columns[33].HeaderText = Localization.Localization.ES516_1;
            recetelerdatagridview.Columns[34].HeaderText = Localization.Localization.ES1379_1;
            recetelerdatagridview.Columns[35].HeaderText = Localization.Localization.ES1380_1;
            recetelerdatagridview.Columns[36].HeaderText = Localization.Localization.ES1381_1;
            recetelerdatagridview.Columns[37].HeaderText = Localization.Localization.ES1382_1;
            recetelerdatagridview.Columns[38].HeaderText = Localization.Localization.ES1383_1;
            recetelerdatagridview.Columns[39].HeaderText = Localization.Localization.ES522_1;
            recetelerdatagridview.Columns[40].HeaderText = Localization.Localization.ES523_1;
            recetelerdatagridview.Columns[41].HeaderText = Localization.Localization.ES524_1;
            recetelerdatagridview.Columns[42].HeaderText = Localization.Localization.ES525_1;
            recetelerdatagridview.Columns[43].HeaderText = Localization.Localization.ES526_1;
            recetelerdatagridview.Columns[44].HeaderText = Localization.Localization.ES528_1;
            recetelerdatagridview.Columns[45].HeaderText = Localization.Localization.ES529_1;
            recetelerdatagridview.Columns[46].HeaderText = Localization.Localization.ES530_1;
            recetelerdatagridview.Columns[47].HeaderText = Localization.Localization.ES207_1;
            recetelerdatagridview.Columns[48].HeaderText = Localization.Localization.ES206_1;
            recetelerdatagridview.Columns[49].HeaderText = Localization.Localization.ES2009_0;
            recetelerdatagridview.Columns[50].HeaderText = Localization.Localization.ES443_1;
            recetelerdatagridview.Columns[51].HeaderText = Localization.Localization.ES1539_1;
            recetelerdatagridview.Columns[52].HeaderText = Localization.Localization.ES1540_1;
            recetelerdatagridview.Columns[53].HeaderText = Localization.Localization.ES1541_1;
            recetelerdatagridview.Columns[54].HeaderText = Localization.Localization.ES1542_1;
            recetelerdatagridview.Columns[55].HeaderText = Localization.Localization.ES1543_1;
            recetelerdatagridview.Columns[56].HeaderText = Localization.Localization.ES1947_1;
            recetelerdatagridview.Columns[57].HeaderText = Localization.Localization.ES2136_0;
            recetelerdatagridview.Columns[58].HeaderText = Localization.Localization.ES1544_1;
            recetelerdatagridview.Columns[59].HeaderText = Localization.Localization.ES1546_1;
            recetelerdatagridview.Columns[60].HeaderText = Localization.Localization.ES1547_1;
            recetelerdatagridview.Columns[61].HeaderText = Localization.Localization.ES1548_1;
            recetelerdatagridview.Columns[62].HeaderText = Localization.Localization.ES1549_0;

            recetelerdatagridview.Columns[2].DataPropertyName = "ReceteAdi";
            recetelerdatagridview.Columns[3].DataPropertyName = "ReceteAciklama";
            recetelerdatagridview.Columns[4].DataPropertyName = "ReceteAgrega1";
            recetelerdatagridview.Columns[5].DataPropertyName = "ReceteAgrega2";
            recetelerdatagridview.Columns[6].DataPropertyName = "ReceteAgrega3";
            recetelerdatagridview.Columns[7].DataPropertyName = "ReceteAgrega4";
            recetelerdatagridview.Columns[8].DataPropertyName = "ReceteAgrega5";
            recetelerdatagridview.Columns[9].DataPropertyName = "ReceteAgrega6";
            recetelerdatagridview.Columns[10].DataPropertyName = "ReceteAgrega7";
            recetelerdatagridview.Columns[11].DataPropertyName = "ReceteAgrega8";
            recetelerdatagridview.Columns[12].DataPropertyName = "ReceteAgrega9";
            recetelerdatagridview.Columns[13].DataPropertyName = "ReceteAgrega10";
            recetelerdatagridview.Columns[14].DataPropertyName = "ReceteCimento1";
            recetelerdatagridview.Columns[15].DataPropertyName = "ReceteCimento2";
            recetelerdatagridview.Columns[16].DataPropertyName = "ReceteCimento3";
            recetelerdatagridview.Columns[17].DataPropertyName = "ReceteCimento4";
            recetelerdatagridview.Columns[18].DataPropertyName = "ReceteCimento5";
            recetelerdatagridview.Columns[19].DataPropertyName = "ReceteCimento6";
            recetelerdatagridview.Columns[20].DataPropertyName = "ReceteCimento7";
            recetelerdatagridview.Columns[21].DataPropertyName = "ReceteCimento8";
            recetelerdatagridview.Columns[22].DataPropertyName = "ReceteCimento9";
            recetelerdatagridview.Columns[23].DataPropertyName = "ReceteCimento10";
            recetelerdatagridview.Columns[24].DataPropertyName = "ReceteSu1";
            recetelerdatagridview.Columns[25].DataPropertyName = "ReceteSu2";
            recetelerdatagridview.Columns[26].DataPropertyName = "ReceteSu3";
            recetelerdatagridview.Columns[27].DataPropertyName = "ReceteSu4";
            recetelerdatagridview.Columns[28].DataPropertyName = "ReceteSu5";
            recetelerdatagridview.Columns[29].DataPropertyName = "ReceteSu6";
            recetelerdatagridview.Columns[30].DataPropertyName = "ReceteSu7";
            recetelerdatagridview.Columns[31].DataPropertyName = "ReceteSu8";
            recetelerdatagridview.Columns[32].DataPropertyName = "ReceteSu9";
            recetelerdatagridview.Columns[33].DataPropertyName = "ReceteSu10";
            recetelerdatagridview.Columns[34].DataPropertyName = "ReceteKatki1";
            recetelerdatagridview.Columns[35].DataPropertyName = "ReceteKatki2";
            recetelerdatagridview.Columns[36].DataPropertyName = "ReceteKatki3";
            recetelerdatagridview.Columns[37].DataPropertyName = "ReceteKatki4";
            recetelerdatagridview.Columns[38].DataPropertyName = "ReceteKatki5";
            recetelerdatagridview.Columns[39].DataPropertyName = "ReceteKatki6";
            recetelerdatagridview.Columns[40].DataPropertyName = "ReceteKatki7";
            recetelerdatagridview.Columns[41].DataPropertyName = "ReceteKatki8";
            recetelerdatagridview.Columns[42].DataPropertyName = "ReceteKatki9";
            recetelerdatagridview.Columns[43].DataPropertyName = "ReceteKatki10";
            recetelerdatagridview.Columns[44].DataPropertyName = "ReceteCimentoGecikmeSuresi";
            recetelerdatagridview.Columns[45].DataPropertyName = "ReceteKatkıGecikmeSuresi";
            recetelerdatagridview.Columns[46].DataPropertyName = "ReceteSuGecikmeSuresi";
            recetelerdatagridview.Columns[47].DataPropertyName = "ReceteMikserBosaltmaSuresi";
            recetelerdatagridview.Columns[48].DataPropertyName = "ReceteMikserKaristirmaSuresi";
            recetelerdatagridview.Columns[49].DataPropertyName = "ReceteMikserKapakAcmaSuresi";
            recetelerdatagridview.Columns[50].DataPropertyName = "ReceteDurum";
            recetelerdatagridview.Columns[51].DataPropertyName = "ReceteDayanimSinifi";
            recetelerdatagridview.Columns[52].DataPropertyName = "ReceteKivamSinifi";
            recetelerdatagridview.Columns[53].DataPropertyName = "ReceteDonaKarsiDayaniklikSinifi";
            recetelerdatagridview.Columns[54].DataPropertyName = "ReceteSuyaKarsiDirencSinifi";
            recetelerdatagridview.Columns[55].DataPropertyName = "ReceteYogunlukSinifi";
            recetelerdatagridview.Columns[56].DataPropertyName = "ReceteBetonTipi";
            recetelerdatagridview.Columns[57].DataPropertyName = "ReceteCevreselEtki";
            recetelerdatagridview.Columns[58].DataPropertyName = "ReceteKlorurIcerigiSinifi";
            recetelerdatagridview.Columns[59].DataPropertyName = "ReceteMaxSuCimOrani";
            recetelerdatagridview.Columns[60].DataPropertyName = "ReceteMinCimIcerigi";
            recetelerdatagridview.Columns[61].DataPropertyName = "ReceteMinBetonDayanimSinifi";
            recetelerdatagridview.Columns[62].DataPropertyName = "ReceteMinBetonHavaIcerigi";

        }
        private void recetelerdatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            no = recetelerdatagridview.CurrentRow.Cells[1].Value.ToString();
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
            ES762_1.Text = Localization.Localization.ES762_1;
            ES729_1.Text = Localization.Localization.ES729_1;
            ES740_1.Text = Localization.Localization.ES740_1;
            ES3017_1.Text = Localization.Localization.ES3017_1;
            ES1561_1.Text = Localization.Localization.ES1561_1;
            ES757_1.Text = Localization.Localization.ES757_1;
            ES15_1.Text = Localization.Localization.ES15_1;

        }
        //

        private void Recete_Load(object sender, EventArgs e)
        {
            DilDegistir();
            recetegetir();
            receteKonfig();
        }
        XX_Connection._000_ReceteGonder ReceteyiPLCyeGonder = XX_Connection._000_ReceteGonder.PLC_Recete_Gonderiyor();
        private void ES740_1_Click(object sender, EventArgs e)
        {
            ReceteyiPLCyeGonder.AgregaReceteValue1 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[4].Value);
            ReceteyiPLCyeGonder.AgregaReceteValue2 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[5].Value);
            ReceteyiPLCyeGonder.AgregaReceteValue3 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[6].Value);
            ReceteyiPLCyeGonder.AgregaReceteValue4 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[7].Value);
            ReceteyiPLCyeGonder.AgregaReceteValue5 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[8].Value);
            ReceteyiPLCyeGonder.AgregaReceteValue6 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[9].Value);

            ReceteyiPLCyeGonder.SuReceteValue1 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[24].Value);
            ReceteyiPLCyeGonder.SuReceteValue2 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[25].Value);
            ReceteyiPLCyeGonder.SuReceteValue3 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[26].Value);

            ReceteyiPLCyeGonder.KatkiReceteValue1 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[34].Value);
            ReceteyiPLCyeGonder.KatkiReceteValue2 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[35].Value);
            ReceteyiPLCyeGonder.KatkiReceteValue3 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[36].Value);
            ReceteyiPLCyeGonder.KatkiReceteValue4 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[37].Value);
            ReceteyiPLCyeGonder.KatkiReceteValue5 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[38].Value);

            ReceteyiPLCyeGonder.CimentoReceteValue1 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[14].Value);
            ReceteyiPLCyeGonder.CimentoReceteValue2 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[15].Value);
            ReceteyiPLCyeGonder.CimentoReceteValue3 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[16].Value);
            ReceteyiPLCyeGonder.CimentoReceteValue4 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[17].Value);
            ReceteyiPLCyeGonder.CimentoReceteValue5 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[18].Value);
            ReceteyiPLCyeGonder.CimentoReceteValue6 = Convert.ToInt16(recetelerdatagridview.SelectedRows[0].Cells[19].Value);
            ReceteyiPLCyeGonder.PLCyeReceteGonderConnection();
        }
        public void receteKonfig()
        {

            //Konfigrasyona göre recetede görünecek dataların visible kontrol
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = false;
                    recetelerdatagridview.Columns[6].Visible = false;
                    recetelerdatagridview.Columns[7].Visible = false;
                    recetelerdatagridview.Columns[8].Visible = false;
                    recetelerdatagridview.Columns[9].Visible = false;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;

                    break;
                case 2:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = true;
                    recetelerdatagridview.Columns[6].Visible = false;
                    recetelerdatagridview.Columns[7].Visible = false;
                    recetelerdatagridview.Columns[8].Visible = false;
                    recetelerdatagridview.Columns[9].Visible = false;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;
                    break;
                case 3:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = true;
                    recetelerdatagridview.Columns[6].Visible = true;
                    recetelerdatagridview.Columns[7].Visible = false;
                    recetelerdatagridview.Columns[8].Visible = false;
                    recetelerdatagridview.Columns[9].Visible = false;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;
                    break;
                case 4:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = true;
                    recetelerdatagridview.Columns[6].Visible = true;
                    recetelerdatagridview.Columns[7].Visible = true;
                    recetelerdatagridview.Columns[8].Visible = false;
                    recetelerdatagridview.Columns[9].Visible = false;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;
                    break;
                case 5:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = true;
                    recetelerdatagridview.Columns[6].Visible = true;
                    recetelerdatagridview.Columns[7].Visible = true;
                    recetelerdatagridview.Columns[8].Visible = true;
                    recetelerdatagridview.Columns[9].Visible = false;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;
                    break;
                case 6:
                    recetelerdatagridview.Columns[4].Visible = true;
                    recetelerdatagridview.Columns[5].Visible = true;
                    recetelerdatagridview.Columns[6].Visible = true;
                    recetelerdatagridview.Columns[7].Visible = true;
                    recetelerdatagridview.Columns[8].Visible = true;
                    recetelerdatagridview.Columns[9].Visible = true;
                    recetelerdatagridview.Columns[10].Visible = false;
                    recetelerdatagridview.Columns[11].Visible = false;
                    recetelerdatagridview.Columns[12].Visible = false;
                    recetelerdatagridview.Columns[13].Visible = false;
                    break;
                default:
                    break;
            }
            //Konfigrasyona göre recetede görünecek dataların visible kontrol
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi)
            {
                case 1:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = false;
                    recetelerdatagridview.Columns[16].Visible = false;
                    recetelerdatagridview.Columns[17].Visible = false;
                    recetelerdatagridview.Columns[18].Visible = false;
                    recetelerdatagridview.Columns[19].Visible = false;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;

                    break;
                case 2:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = true;
                    recetelerdatagridview.Columns[16].Visible = false;
                    recetelerdatagridview.Columns[17].Visible = false;
                    recetelerdatagridview.Columns[18].Visible = false;
                    recetelerdatagridview.Columns[19].Visible = false;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;
                    break;
                case 3:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = true;
                    recetelerdatagridview.Columns[16].Visible = true;
                    recetelerdatagridview.Columns[17].Visible = false;
                    recetelerdatagridview.Columns[18].Visible = false;
                    recetelerdatagridview.Columns[19].Visible = false;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;
                    break;
                case 4:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = true;
                    recetelerdatagridview.Columns[16].Visible = true;
                    recetelerdatagridview.Columns[17].Visible = true;
                    recetelerdatagridview.Columns[18].Visible = false;
                    recetelerdatagridview.Columns[19].Visible = false;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;
                    break;
                case 5:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = true;
                    recetelerdatagridview.Columns[16].Visible = true;
                    recetelerdatagridview.Columns[17].Visible = true;
                    recetelerdatagridview.Columns[18].Visible = true;
                    recetelerdatagridview.Columns[19].Visible = false;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;
                    break;
                case 6:
                    recetelerdatagridview.Columns[14].Visible = true;
                    recetelerdatagridview.Columns[15].Visible = true;
                    recetelerdatagridview.Columns[16].Visible = true;
                    recetelerdatagridview.Columns[17].Visible = true;
                    recetelerdatagridview.Columns[18].Visible = true;
                    recetelerdatagridview.Columns[19].Visible = true;
                    recetelerdatagridview.Columns[20].Visible = false;
                    recetelerdatagridview.Columns[21].Visible = false;
                    recetelerdatagridview.Columns[22].Visible = false;
                    recetelerdatagridview.Columns[23].Visible = false;
                    break;
                default:
                    break;
            }
            switch (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
            {
                case 1:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = false;
                    recetelerdatagridview.Columns[36].Visible = false;
                    recetelerdatagridview.Columns[37].Visible = false;
                    recetelerdatagridview.Columns[38].Visible = false;
                    recetelerdatagridview.Columns[39].Visible = false;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;

                    break;
                case 2:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = true;
                    recetelerdatagridview.Columns[36].Visible = false;
                    recetelerdatagridview.Columns[37].Visible = false;
                    recetelerdatagridview.Columns[38].Visible = false;
                    recetelerdatagridview.Columns[39].Visible = false;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;
                    break;
                case 3:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = true;
                    recetelerdatagridview.Columns[36].Visible = true;
                    recetelerdatagridview.Columns[37].Visible = false;
                    recetelerdatagridview.Columns[38].Visible = false;
                    recetelerdatagridview.Columns[39].Visible = false;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;
                    break;
                case 4:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = true;
                    recetelerdatagridview.Columns[36].Visible = true;
                    recetelerdatagridview.Columns[37].Visible = true;
                    recetelerdatagridview.Columns[38].Visible = false;
                    recetelerdatagridview.Columns[39].Visible = false;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;
                    break;
                case 5:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = true;
                    recetelerdatagridview.Columns[36].Visible = true;
                    recetelerdatagridview.Columns[37].Visible = true;
                    recetelerdatagridview.Columns[38].Visible = true;
                    recetelerdatagridview.Columns[39].Visible = false;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;
                    break;
                case 6:
                    recetelerdatagridview.Columns[34].Visible = true;
                    recetelerdatagridview.Columns[35].Visible = true;
                    recetelerdatagridview.Columns[36].Visible = true;
                    recetelerdatagridview.Columns[37].Visible = true;
                    recetelerdatagridview.Columns[38].Visible = true;
                    recetelerdatagridview.Columns[39].Visible = true;
                    recetelerdatagridview.Columns[40].Visible = false;
                    recetelerdatagridview.Columns[41].Visible = false;
                    recetelerdatagridview.Columns[42].Visible = false;
                    recetelerdatagridview.Columns[43].Visible = false;
                    break;

                default:
                    break;
            }
            switch (Properties.S000_Konfigrator_Tag.Default.SuSayisi)
            {
                case 1:
                    recetelerdatagridview.Columns[24].Visible = true;
                    recetelerdatagridview.Columns[25].Visible = false;
                    recetelerdatagridview.Columns[26].Visible = false;
                    recetelerdatagridview.Columns[27].Visible = false;
                    recetelerdatagridview.Columns[28].Visible = false;
                    recetelerdatagridview.Columns[29].Visible = false;
                    recetelerdatagridview.Columns[30].Visible = false;
                    recetelerdatagridview.Columns[31].Visible = false;
                    recetelerdatagridview.Columns[32].Visible = false;
                    recetelerdatagridview.Columns[33].Visible = false;

                    break;
                case 2:
                    recetelerdatagridview.Columns[24].Visible = true;
                    recetelerdatagridview.Columns[25].Visible = true;
                    recetelerdatagridview.Columns[26].Visible = false;
                    recetelerdatagridview.Columns[27].Visible = false;
                    recetelerdatagridview.Columns[28].Visible = false;
                    recetelerdatagridview.Columns[29].Visible = false;
                    recetelerdatagridview.Columns[30].Visible = false;
                    recetelerdatagridview.Columns[31].Visible = false;
                    recetelerdatagridview.Columns[32].Visible = false;
                    recetelerdatagridview.Columns[33].Visible = false;
                    break;
                case 3:
                    recetelerdatagridview.Columns[24].Visible = true;
                    recetelerdatagridview.Columns[25].Visible = true;
                    recetelerdatagridview.Columns[26].Visible = true;
                    recetelerdatagridview.Columns[27].Visible = false;
                    recetelerdatagridview.Columns[28].Visible = false;
                    recetelerdatagridview.Columns[29].Visible = false;
                    recetelerdatagridview.Columns[30].Visible = false;
                    recetelerdatagridview.Columns[31].Visible = false;
                    recetelerdatagridview.Columns[32].Visible = false;
                    recetelerdatagridview.Columns[33].Visible = false;
                    break;
                case 4:
                    recetelerdatagridview.Columns[24].Visible = true;
                    recetelerdatagridview.Columns[25].Visible = true;
                    recetelerdatagridview.Columns[26].Visible = true;
                    recetelerdatagridview.Columns[27].Visible = true;
                    recetelerdatagridview.Columns[28].Visible = false;
                    recetelerdatagridview.Columns[29].Visible = false;
                    recetelerdatagridview.Columns[30].Visible = false;
                    recetelerdatagridview.Columns[31].Visible = false;
                    recetelerdatagridview.Columns[32].Visible = false;
                    recetelerdatagridview.Columns[33].Visible = false;
                    break;
                case 5:
                    recetelerdatagridview.Columns[24].Visible = true;
                     recetelerdatagridview.Columns[25].Visible= true;
                     recetelerdatagridview.Columns[26].Visible= true;
                     recetelerdatagridview.Columns[27].Visible= true;
                     recetelerdatagridview.Columns[28].Visible= true;
                     recetelerdatagridview.Columns[29].Visible= false;
                     recetelerdatagridview.Columns[30].Visible= false;
                     recetelerdatagridview.Columns[31].Visible = false;
                     recetelerdatagridview.Columns[32].Visible= false;
                     recetelerdatagridview.Columns[33].Visible= false;
                    break;
                case 6:
                    recetelerdatagridview.Columns[24].Visible = true;
                    recetelerdatagridview.Columns[25].Visible = true;
                    recetelerdatagridview.Columns[26].Visible = true;
                    recetelerdatagridview.Columns[27].Visible = true;
                    recetelerdatagridview.Columns[28].Visible = true;
                    recetelerdatagridview.Columns[29].Visible = true;
                    recetelerdatagridview.Columns[30].Visible = false;
                    recetelerdatagridview.Columns[31].Visible = false;
                    recetelerdatagridview.Columns[32].Visible = false;
                    recetelerdatagridview.Columns[33].Visible = false;
                    break;
                default:
                    break;
            }
                    recetelerdatagridview.Refresh();
            
        }

        private void recetelerdatagridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenRecete = recetelerdatagridview.SelectedRows.Count;
        }
    }
}
