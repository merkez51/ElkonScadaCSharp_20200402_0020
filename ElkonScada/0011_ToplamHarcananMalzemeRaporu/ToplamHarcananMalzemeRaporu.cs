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

namespace ElkonScada._0011_ToplamHarcananMalzemeRaporu
{
    public partial class ToplamHarcananMalzemeRaporu : Form
    {


        public ToplamHarcananMalzemeRaporu()
        {
            InitializeComponent();
        }

        //sayfa açma
        private void TotalMaterialUsageReportFileNameOpenEvent(object sender, EventArgs e)
        {
            ToplamHarcananMalzemeRaporuDosyaAdi TotalMaterialUsageReportFileName = new ToplamHarcananMalzemeRaporuDosyaAdi();
            TotalMaterialUsageReportFileName.Show();
        }
        //

        public static SqlTableCheckToplamHarcananMR SqlTableCheck = new SqlTableCheckToplamHarcananMR();
        public string recete;

        public void toplamharcananmalzemeraporugetir()
        {

            bool tablo = SqlTableCheck.DataBaseOlustur();
        
            toplamharcananmalzemeraporudatagridview.DataSource = null;
            toplamharcananmalzemeraporudatagridview.DataSource = SqlTableCheck.ShowData();
            


            toplamharcananmalzemeraporudatagridview.Columns[1].Visible = false;
            toplamharcananmalzemeraporudatagridview.Columns[2].HeaderText = Localization.Localization.ES104_1;
            toplamharcananmalzemeraporudatagridview.Columns[3].HeaderText = Localization.Localization.ES194_1;
            toplamharcananmalzemeraporudatagridview.Columns[4].HeaderText = Localization.Localization.ES197_1;
            toplamharcananmalzemeraporudatagridview.Columns[5].HeaderText = Localization.Localization.ES198_1;
            toplamharcananmalzemeraporudatagridview.Columns[6].HeaderText = Localization.Localization.ES199_1;
            toplamharcananmalzemeraporudatagridview.Columns[7].HeaderText = Localization.Localization.ES493_1;
            toplamharcananmalzemeraporudatagridview.Columns[8].HeaderText = Localization.Localization.ES494_1;
            toplamharcananmalzemeraporudatagridview.Columns[9].HeaderText = Localization.Localization.ES495_1;
            toplamharcananmalzemeraporudatagridview.Columns[10].HeaderText = Localization.Localization.ES495_1;
            toplamharcananmalzemeraporudatagridview.Columns[11].HeaderText = Localization.Localization.ES497_1;
            toplamharcananmalzemeraporudatagridview.Columns[12].HeaderText = Localization.Localization.ES498_1;
            toplamharcananmalzemeraporudatagridview.Columns[13].HeaderText = Localization.Localization.ES220_1;
            toplamharcananmalzemeraporudatagridview.Columns[14].HeaderText = Localization.Localization.ES499_1;
            toplamharcananmalzemeraporudatagridview.Columns[15].HeaderText = Localization.Localization.ES500_1;
            toplamharcananmalzemeraporudatagridview.Columns[16].HeaderText = Localization.Localization.ES501_1;
            toplamharcananmalzemeraporudatagridview.Columns[17].HeaderText = Localization.Localization.ES502_1;
            toplamharcananmalzemeraporudatagridview.Columns[18].HeaderText = Localization.Localization.ES503_1;
            toplamharcananmalzemeraporudatagridview.Columns[19].HeaderText = Localization.Localization.ES504_1;
            toplamharcananmalzemeraporudatagridview.Columns[20].HeaderText = Localization.Localization.ES505_1;
            toplamharcananmalzemeraporudatagridview.Columns[21].HeaderText = Localization.Localization.ES506_1;
            toplamharcananmalzemeraporudatagridview.Columns[22].HeaderText = Localization.Localization.ES507_1;
            toplamharcananmalzemeraporudatagridview.Columns[23].HeaderText = Localization.Localization.ES75_1;
            toplamharcananmalzemeraporudatagridview.Columns[24].HeaderText = Localization.Localization.ES76_1;
            toplamharcananmalzemeraporudatagridview.Columns[25].HeaderText = Localization.Localization.ES509_1;
            toplamharcananmalzemeraporudatagridview.Columns[26].HeaderText = Localization.Localization.ES510_1;
            toplamharcananmalzemeraporudatagridview.Columns[27].HeaderText = Localization.Localization.ES511_1;
            toplamharcananmalzemeraporudatagridview.Columns[28].HeaderText = Localization.Localization.ES512_1;
            toplamharcananmalzemeraporudatagridview.Columns[29].HeaderText = Localization.Localization.ES513_1;
            toplamharcananmalzemeraporudatagridview.Columns[30].HeaderText = Localization.Localization.ES514_1;
            toplamharcananmalzemeraporudatagridview.Columns[31].HeaderText = Localization.Localization.ES515_1;
            toplamharcananmalzemeraporudatagridview.Columns[32].HeaderText = Localization.Localization.ES516_1;
            toplamharcananmalzemeraporudatagridview.Columns[33].HeaderText = Localization.Localization.ES1379_1;
            toplamharcananmalzemeraporudatagridview.Columns[34].HeaderText = Localization.Localization.ES1380_1;
            toplamharcananmalzemeraporudatagridview.Columns[35].HeaderText = Localization.Localization.ES1381_1;
            toplamharcananmalzemeraporudatagridview.Columns[36].HeaderText = Localization.Localization.ES1382_1;
            toplamharcananmalzemeraporudatagridview.Columns[37].HeaderText = Localization.Localization.ES1383_1;
            toplamharcananmalzemeraporudatagridview.Columns[38].HeaderText = Localization.Localization.ES522_1;
            toplamharcananmalzemeraporudatagridview.Columns[39].HeaderText = Localization.Localization.ES523_1;
            toplamharcananmalzemeraporudatagridview.Columns[40].HeaderText = Localization.Localization.ES524_1;
            toplamharcananmalzemeraporudatagridview.Columns[41].HeaderText = Localization.Localization.ES525_1;
            toplamharcananmalzemeraporudatagridview.Columns[42].HeaderText = Localization.Localization.ES526_1;
            toplamharcananmalzemeraporudatagridview.Columns[43].HeaderText = Localization.Localization.ES909_1;
            
            toplamharcananmalzemeraporudatagridview.Columns[2].DataPropertyName = "Recete";
            toplamharcananmalzemeraporudatagridview.Columns[3].DataPropertyName = "ReceteAgrega1";
            toplamharcananmalzemeraporudatagridview.Columns[4].DataPropertyName = "ReceteAgrega2";
            toplamharcananmalzemeraporudatagridview.Columns[5].DataPropertyName = "ReceteAgrega3";
            toplamharcananmalzemeraporudatagridview.Columns[6].DataPropertyName = "ReceteAgrega4";
            toplamharcananmalzemeraporudatagridview.Columns[7].DataPropertyName = "ReceteAgrega5";
            toplamharcananmalzemeraporudatagridview.Columns[8].DataPropertyName = "ReceteAgrega6";
            toplamharcananmalzemeraporudatagridview.Columns[9].DataPropertyName = "ReceteAgrega7";
            toplamharcananmalzemeraporudatagridview.Columns[10].DataPropertyName = "ReceteAgrega8";
            toplamharcananmalzemeraporudatagridview.Columns[11].DataPropertyName = "ReceteAgrega9";
            toplamharcananmalzemeraporudatagridview.Columns[12].DataPropertyName = "ReceteAgrega10";
            toplamharcananmalzemeraporudatagridview.Columns[13].DataPropertyName = "ReceteCimento1";
            toplamharcananmalzemeraporudatagridview.Columns[14].DataPropertyName = "ReceteCimento2";
            toplamharcananmalzemeraporudatagridview.Columns[15].DataPropertyName = "ReceteCimento3";
            toplamharcananmalzemeraporudatagridview.Columns[16].DataPropertyName = "ReceteCimento4";
            toplamharcananmalzemeraporudatagridview.Columns[17].DataPropertyName = "ReceteCimento5";
            toplamharcananmalzemeraporudatagridview.Columns[18].DataPropertyName = "ReceteCimento6";
            toplamharcananmalzemeraporudatagridview.Columns[19].DataPropertyName = "ReceteCimento7";
            toplamharcananmalzemeraporudatagridview.Columns[20].DataPropertyName = "ReceteCimento8";
            toplamharcananmalzemeraporudatagridview.Columns[21].DataPropertyName = "ReceteCimento9";
            toplamharcananmalzemeraporudatagridview.Columns[22].DataPropertyName = "ReceteCimento10";
            toplamharcananmalzemeraporudatagridview.Columns[23].DataPropertyName = "ReceteSu1";
            toplamharcananmalzemeraporudatagridview.Columns[24].DataPropertyName = "ReceteSu2";
            toplamharcananmalzemeraporudatagridview.Columns[25].DataPropertyName = "ReceteSu3";
            toplamharcananmalzemeraporudatagridview.Columns[26].DataPropertyName = "ReceteSu4";
            toplamharcananmalzemeraporudatagridview.Columns[27].DataPropertyName = "ReceteSu5";
            toplamharcananmalzemeraporudatagridview.Columns[28].DataPropertyName = "ReceteSu6";
            toplamharcananmalzemeraporudatagridview.Columns[29].DataPropertyName = "ReceteSu7";
            toplamharcananmalzemeraporudatagridview.Columns[30].DataPropertyName = "ReceteSu8";
            toplamharcananmalzemeraporudatagridview.Columns[31].DataPropertyName = "ReceteSu9";
            toplamharcananmalzemeraporudatagridview.Columns[32].DataPropertyName = "ReceteSu10";
            toplamharcananmalzemeraporudatagridview.Columns[33].DataPropertyName = "ReceteKatki1";
            toplamharcananmalzemeraporudatagridview.Columns[34].DataPropertyName = "ReceteKatki2";
            toplamharcananmalzemeraporudatagridview.Columns[35].DataPropertyName = "ReceteKatki3";
            toplamharcananmalzemeraporudatagridview.Columns[36].DataPropertyName = "ReceteKatki4";
            toplamharcananmalzemeraporudatagridview.Columns[37].DataPropertyName = "ReceteKatki5";
            toplamharcananmalzemeraporudatagridview.Columns[38].DataPropertyName = "ReceteKatki6";
            toplamharcananmalzemeraporudatagridview.Columns[39].DataPropertyName = "ReceteKatki7";
            toplamharcananmalzemeraporudatagridview.Columns[40].DataPropertyName = "ReceteKatki8";
            toplamharcananmalzemeraporudatagridview.Columns[41].DataPropertyName = "ReceteKatki9";
            toplamharcananmalzemeraporudatagridview.Columns[42].DataPropertyName = "ReceteKatki10";
            toplamharcananmalzemeraporudatagridview.Columns[43].DataPropertyName = "GirisMiktari";
         
        }

        private void toplamharcananmalzemeraporudatagridview_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            recete = toplamharcananmalzemeraporudatagridview.CurrentRow.Cells[2].Value.ToString();
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
            ES1621_1.Text = Localization.Localization.ES1621_1;
            ES15_1.Text = Localization.Localization.ES15_1;
            ES30_1.Text = Localization.Localization.ES30_1;
            
            




        }
        //

        private void ToplamHarcananMalzemeRaporu_Load(object sender, EventArgs e)
        {
            
            DilDegistir();
            toplamharcananmalzemeraporugetir();
            

        }

    }
}
