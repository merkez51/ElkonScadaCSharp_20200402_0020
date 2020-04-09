using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace ElkonScada._01_TempMainPage
{
    public partial class OtoUretimBilgileri : UserControl
    {
        XX_Connection.ModbusConnection HetModbusClass = XX_Connection.ModbusConnection.HetConnection();
        DataTable dt_MalzemeMiktar;
        DataTable dt_UretimIzleme;
        SqlDataAdapter DataAdapter;
        SqlDataAdapter DataAdapterUretim;

        public static SqlConnection DatabaseConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElkonScada;Integrated Security=True");

        public OtoUretimBilgileri()
        {
            InitializeComponent();
        }

        private void OtoUretimBilgileri_Load(object sender, EventArgs e)
        {
            //GuncelleDatagriOtoUretim();

        }
        public String[] OtoUretimIzlemeElementArray;
        int AgregaMalzemeNameFromSQL = 0;
        int CimentoMalzemeNameFromSQL = 0;
        int KatkiMalzemeNameFromSQL = 0;
        int SuMalzemeNameFromSQL = 0;
        int DatagridSelectionRow = 0;
        public void GuncelleDatagriOtoUretim()
        {
            ElkonScada._0005_Malzemeler.SqlTableCheckMalzemeler adem = new _0005_Malzemeler.SqlTableCheckMalzemeler();
            DataAdapter = new SqlDataAdapter("Select MalzemeAdi,MalzemeType From Malzemeler", DatabaseConn);
            dt_MalzemeMiktar = new DataTable();
            DataAdapter.Fill(dt_MalzemeMiktar);
            malzemelerdatagridview.DataSource = null;
            malzemelerdatagridview.DataSource = dt_MalzemeMiktar;
            malzemelerdatagridview.Columns[0].HeaderText = Localization.Localization.ES807_1;
            malzemelerdatagridview.Columns[1].Visible = true;

            malzemelerdatagridview.Columns.Add("Istenen", "İstenen");
            malzemelerdatagridview.Columns.Add("Verilen", "Verilen");
            malzemelerdatagridview.Columns.Add("Fark", "Fark");
            AgregaMalzemeNameFromSQL = 0;
            CimentoMalzemeNameFromSQL = 0;
            KatkiMalzemeNameFromSQL = 0;
            SuMalzemeNameFromSQL = 0;
            for (int i = 0; i < malzemelerdatagridview.Rows.Count - 1; i++)
            {
                char[] TrimKey = malzemelerdatagridview.Rows[i].Cells[1].Value.ToString().ToCharArray();
                switch (TrimKey[0])
                {
                    case '1':
                        if (AgregaMalzemeNameFromSQL <= Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
                        {
                            AgregaMalzemeNameFromSQL++;
                        }
                        break;
                    case '2':
                        if (CimentoMalzemeNameFromSQL <= Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi)
                        {
                            CimentoMalzemeNameFromSQL++;
                        }
                        break;
                    case '3':
                        if (KatkiMalzemeNameFromSQL <= Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
                        {
                            KatkiMalzemeNameFromSQL++;
                        }

                        break;
                    case '4':
                        if (SuMalzemeNameFromSQL <= Properties.S000_Konfigrator_Tag.Default.SuSayisi)
                        {
                            SuMalzemeNameFromSQL++;
                        }
                        break;
                    default:
                        //  malzemelerdatagridview.Rows[i].Cells[3].Value = "-";
                        break;
                }
                malzemelerdatagridview.Columns[1].Visible = false;


            }
            //   MessageBox.Show(AgregaMalzemeNameFromSQL.ToString() + "+" + CimentoMalzemeNameFromSQL.ToString() + "+" +
            //         KatkiMalzemeNameFromSQL.ToString() + "+" + SuMalzemeNameFromSQL.ToString());
           
        }


        int UretimPageReflesTimer = 0;
        public void ReflesOtoUretimValue()
        {
            ButtonStatus();

            if (UretimPageReflesTimer>100)
            {
                DataAdapterUretim = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY SiraNo) AS No,* from UretimPlani", DatabaseConn);
                dt_UretimIzleme = new DataTable();
                DataAdapterUretim.Fill(dt_UretimIzleme);
                UretimPalanlari.DataSource = null;
                UretimPalanlari.DataSource = dt_UretimIzleme;
                UretimPageReflesTimer = 0;
            }
            else
            {
                UretimPageReflesTimer++;
            }

            int RowCount = 0;
            switch (AgregaMalzemeNameFromSQL)
            {
                case 1:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                        - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    break;
                case 2:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                        - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2
                        - Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    RowCount++;


                    break;
                case 3:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                       - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2
                       - Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3
                       - Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;

                    RowCount++;
                    break;
                case 4:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                       - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2
                       - Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3
                       - Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4
                       - Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;

                    RowCount++;
                    break;
                case 5:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                       - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2
                       - Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3
                      - Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4
                      - Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega5_ArrayCount_5;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega5_ArrayCount_05;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega5_ArrayCount_5
                      - Properties.M101_Array.Default.Verilen_Agrega5_ArrayCount_05;
                    RowCount++;


                    break;
                case 6:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1
                       - Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2
                       - Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3
                      - Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4
                      - Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega5_ArrayCount_5;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Agrega5_ArrayCount_05;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Agrega5_ArrayCount_5
                      - Properties.M101_Array.Default.Verilen_Agrega5_ArrayCount_05;
                    RowCount++;

                    break;

                default:
                    break;
            }


            switch (CimentoMalzemeNameFromSQL)
            {
                case 1:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    break;
                case 2:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12
                      - Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    RowCount++;

                    break;
                case 3:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12
                      - Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13
                      - Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    RowCount++;
                    break;
                case 4:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12
                      - Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13
                      - Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14
                      - Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    RowCount++;
                    break;
                case 5:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12
                      - Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13
                      - Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14
                      - Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento5_ArrayCount_15;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento5_ArrayCount_15;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento5_ArrayCount_15
                      - Properties.M101_Array.Default.Verilen_Cimento5_ArrayCount_15;
                    RowCount++;

                    break;
                case 6:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11
                      - Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12
                      - Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13
                      - Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14
                      - Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento5_ArrayCount_15;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Cimento5_ArrayCount_15;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Cimento5_ArrayCount_15
                      - Properties.M101_Array.Default.Verilen_Cimento5_ArrayCount_15;
                    RowCount++;

                    break;

                default:
                    break;
            }

            switch (KatkiMalzemeNameFromSQL)
            {
                case 1:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    RowCount++;
                    break;
                case 2:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22
                       - Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    RowCount++;

                    break;
                case 3:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;

                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22
                       - Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23
                       - Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    RowCount++;
                    break;
                case 4:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22
                       - Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23
                       - Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24
                       - Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    RowCount++;
                    break;
                case 5:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22
                       - Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23
                       - Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24
                       - Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki5_ArrayCount_25;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24
                       - Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    RowCount++;

                    break;
                case 6:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21
                       - Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22
                       - Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23
                       - Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24
                       - Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Katki5_ArrayCount_25;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24
                       - Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24;
                    RowCount++;

                    break;

                default:
                    break;
            }
            switch (SuMalzemeNameFromSQL)
            {
                case 1:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31
                       - Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;

                    RowCount++;
                    break;
                case 2:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31
                       - Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su2_ArrayCount_32;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su2_ArrayCount_32;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su2_ArrayCount_32
                       - Properties.M101_Array.Default.Verilen_Su2_ArrayCount_32;
                    RowCount++;

                    break;
                case 3:
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31
                       - Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su2_ArrayCount_32;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su2_ArrayCount_32;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su2_ArrayCount_32
                       - Properties.M101_Array.Default.Verilen_Su2_ArrayCount_32;
                    RowCount++;
                    malzemelerdatagridview.Rows[RowCount].Cells[2].Value = Properties.M101_Array.Default.ToplamIstenen_Su3_ArrayCount_33;
                    malzemelerdatagridview.Rows[RowCount].Cells[3].Value = Properties.M101_Array.Default.Verilen_Su3_ArrayCount_33;
                    malzemelerdatagridview.Rows[RowCount].Cells[4].Value = Properties.M101_Array.Default.ToplamIstenen_Su3_ArrayCount_33
                       - Properties.M101_Array.Default.Verilen_Su3_ArrayCount_33;
                    // RowCount++;
                    break;

                default:
                    break;
            }

        }
        public void ButtonStatus()
        {
            if (Properties.M012_Lambalar.Default.is_ButonManualde)
            {
                Makine_Modu.Text = Localization.Localization.ES268_1;
            }
            else if (Properties.M012_Lambalar.Default.is_ButonOtomatikte)
            {
                Makine_Modu.Text = Localization.Localization.ES269_1;

            }
            else if (Properties.M012_Lambalar.Default.s_ModYariOtomatik)
            {
                Makine_Modu.Text = Localization.Localization.ES1472_1;

            }
            switch (Properties.M011_ButonLar.Default.is_ButonKorna)
            {
                case false:
                    is_ButonKorna.Image = Properties.Resources.Korna_OFF;

                    break;

                case true:
                    is_ButonKorna.Image = Properties.Resources.Korna_ON;

                    break;
                default:
                    break;
            }
            switch (Properties.M012_Lambalar.Default.qs_KompresorLambasi)
            {
                case false:
                    is_ButonKompresor.Image = Properties.Resources.Kompresor_OFF;
                    break;
                case true:
                    is_ButonKompresor.Image = Properties.Resources.Kompresor_ON;

                    break;
                default:
                    break;
            }
            switch (Properties.S002UretimResetleme_Tag.Default.UretimResetleniyor)
            {
                case true:
                    XB1_Reset.Image = Properties.Resources.Lamp_Yellow;
                    Properties.S002UretimResetleme_Tag.Default.UretimResetleniyor = false;

                    break;
                case false:
                    XB1_Reset.Image = Properties.Resources.Lamp_Black;
                    break;
                default:
                    break;
            }
        }

        private void ResetUretim_Click(object sender, EventArgs e)
        {

            DialogResult UretimSonlandırmaUyarı = new DialogResult();
            if (Properties.M012_Lambalar.Default.qs_OtomatikStartLambasi)
            {
                MessageBox.Show(Localization.Localization.ES1516_1);
            }
            else if (!Properties.M012_Lambalar.Default.qs_OtomatikStartLambasi)
            {
                if (Properties.R006_Uretim.Default.XB111_Uretim)
                {
                    //   Localization.Localization.ES798_1,//evet
                    //  Localization.Localization.ES799_1,//hayır
                    UretimSonlandırmaUyarı = MessageBox.Show(Localization.Localization.ES1517_1
                        , Localization.Localization.ES1292_1,
                      MessageBoxButtons.YesNo);
                    if (UretimSonlandırmaUyarı == DialogResult.Yes)
                    {
                        XB1_Reset.ButtonValue = true;
                        Properties.R006_Uretim.Default.XB111_UretimReset = true;
                    }
                    if (UretimSonlandırmaUyarı == DialogResult.No)
                    {
                        XB1_Reset.ButtonValue = false;
                        Properties.R006_Uretim.Default.XB111_UretimReset = false;
                    }
                }
                if (!Properties.R006_Uretim.Default.XB111_Uretim)
                {
                    XB1_Reset.ButtonValue = true;
                    Properties.R006_Uretim.Default.XB111_UretimReset = true;
                    //  HetModbusClass.Write_R006();

                }
            }
        }

    

    

        private void is_ButonKorna_Click(object sender, EventArgs e)
        {
        
                HetModbusClass.WriteBool(is_ButonKorna.ModbusAdress_S);

     

        }

        private void is_ButonKompresor_Click(object sender, EventArgs e)
        {
                HetModbusClass.WriteBool(is_ButonKompresor.ModbusAdress_S);

        }

        private void is_ButonStop_Click(object sender, EventArgs e)
        {
            //Bakılacak!!!!!!!!!!!!!!!!!!!!!!!!!!
            HetModbusClass.WriteBool(is_ButonStop.ModbusAdress_S);
           
            if (Properties.R006_Uretim.Default.XB111_Uretim)
            {
                Properties.Sys002_SistemAlarm.Default.UretimDurduAlarmSet = true;
                Properties.Sys002_SistemAlarm.Default.YeniUretimBasladiAlarmSet = false;
                Properties.Sys002_SistemAlarm.Default.UretimeKaldigiYerdenDevamAlarmSet = false;

                Properties.Sys002_SistemAlarm.Default.UretimDurduAlarmSet = false;

            }
            StopWaitTime.Enabled = true;
            

        }

    

        private void StopWaitTime_Tick(object sender, EventArgs e)
        {
            HetModbusClass.WriteBool(is_ButonStop.ModbusAdress_S);
          
        }

        private void UretimStartButton_Click(object sender, EventArgs e)
        {
            if (Properties.M012_Lambalar.Default.is_ButonOtomatikte 
                && !Properties.R006_Uretim.Default.XB111_Uretim
                && UretimPalanlari.Rows.Count > 0)
            {
                Properties.M006_Uretim.Default.SiradakiPlanaGecisYapilacak = false;
                Properties.Sys003_UretimTags.Default.StartVerildi = true;
                UretimStartButton.ButtonValue = true;
                HetModbusClass.WriteBool(UretimStartButton.ModbusAdress_S);
                //Recete Gonder


            }
        }
    }
}
