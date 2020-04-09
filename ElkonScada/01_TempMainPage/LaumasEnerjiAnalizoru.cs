using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AJBauer;
using System.Data.SqlClient;

namespace ElkonScada._01_TempMainPage
{
    public partial class LaumasEnerjiAnalizoru : UserControl
    {
        public LaumasEnerjiAnalizoru()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void AgregaLaumasPic_Click(object sender, EventArgs e)
        {
            
        }

        private void XB2_AgregaKantar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LaumasAgrega()

        {
        }
        public void LaumasCimento()

        {
        }
        public void LaumasSu()

        {
        }
        public void LaumasKatki()

        {
        }
        private float fCapacityUtilizationPct = 0.75F;

        private Random r = new Random();
        float i = 0;
        DateTime PC_Clock;
        int Sayac = 0;
        int UretimNo = 0;
        public void RefleshValue()
        {
            PC_Clock = DateTime.Now;
            XB2_AgregaKantar.Text = Convert.ToString(Properties.M015_Agrega.Default.XB2_AgregaKantar);
            XB3_CMKantar.Text = Convert.ToString(Properties.M016_Cimento.Default.XB3_CMKantar);
            XB4_SuKantar.Text = Convert.ToString(Properties.M017_Su.Default.XB4_SuKantar);
            XB5_KatKantar.Text = Convert.ToString(Properties.M018_Katki.Default.XB5_KatKantar);
            XB1_Voltaj1.Text = Convert.ToString(Properties.M005_Modbus.Default.XB1_Voltaj1);
            XB1_Voltaj2.Text = Convert.ToString(Properties.M005_Modbus.Default.XB1_Voltaj2);
            XB1_Voltaj3.Text = Convert.ToString(Properties.M005_Modbus.Default.XB1_Voltaj3);

            //updateGaugeWidget(true, MixerAkımSlumMeter,
            //    label1, i);
            MixerAkımSlumMeter.Value =(float) Properties.M005_Modbus.Default.XB1_MikserSlump ;
            MikserAkim.Text = MixerAkımSlumMeter.Value.ToString();

            
            MixerGraph.Series[0]["LineTension"] = "0.2";
            MixerGraph.Series["Amp"].Points.AddXY(Sayac, Properties.M005_Modbus.Default.XB1_MikserSlump);
            MixerGraph.Series["Amp"].Color = Color.Red;
            MixerGraph.Series["Amp"].BorderWidth = 1;
            Sayac++;

            string sql = "insert into MikserAkimKayit(UretimNo,MikserTime,Akim)" +
                         "values('" + "UH" + UretimNo.ToString() + "','" + PC_Clock.ToString() + "','" + Properties.M005_Modbus.Default.XB1_MikserSlump + "')";
            SqlCommand cmd = new SqlCommand(sql, SqlTableCheckMikserAkim.DatabaseConn);

            if (SqlTableCheckMikserAkim.DatabaseConn.State != ConnectionState.Open) SqlTableCheckMikserAkim.DatabaseConn.Open();
            cmd.ExecuteNonQuery();

        }
        SqlConnection ServerConn = new SqlConnection(@"server=.\SQLEXPRESS;Trusted_Connection=yes");
        public static SqlConnection DatabaseConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElkonScada;Integrated Security=True");
        private Boolean DataBaseCheckS, TabloCheckS = false;
        SqlDataAdapter DataAdapter;
        DataTable dt;
        private void LaumasEnerjiAnalizoru_Load(object sender, EventArgs e)
        {

            DataBaseOlustur();
            string TabloSorgusu = "SELECT name FROM ElkonScada.sys.tables where name= 'MikserAkimKayit' ";
            SqlCommand tablosorgucommand = new SqlCommand(TabloSorgusu, SqlTableCheckMikserAkim.DatabaseConn);
            try
            {
                SqlTableCheckMikserAkim.DatabaseConn.Open();
                tablosorgucommand.ExecuteNonQuery();
                SqlDataReader tablodurumunuoku = tablosorgucommand.ExecuteReader();
                while (tablodurumunuoku.Read())
                {
                    TabloCheckS = true;

                }
                SqlTableCheckMikserAkim.DatabaseConn.Close();
                if (TabloCheckS == false)
                {
                    string CreateTstr = "CREATE TABLE MikserAkimKayit" +
                   "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,UretimNo CHAR(1000),MikserTime CHAR(100), Akim float)";
                    SqlCommand CreateTSqlCommand = new SqlCommand(CreateTstr, SqlTableCheckMikserAkim.DatabaseConn);
                    SqlTableCheckMikserAkim.DatabaseConn.Open();
                    CreateTSqlCommand.ExecuteNonQuery();
                    SqlTableCheckMikserAkim.DatabaseConn.Close();

                }
            }
            catch (Exception)
            {

                
            }
           


        }
        public void DataBaseOlustur()
        {
            String DbaseSorguStr = "SELECT name FROM master.dbo.sysdatabases   WHERE name='ElkonScada' ";
            SqlCommand cmd = new SqlCommand(DbaseSorguStr, ServerConn);
            try
            {
                ServerConn.Open();
                SqlDataReader sqlData = cmd.ExecuteReader();
                while (sqlData.Read())
                {
                    DataBaseCheckS = true;
                }
                ServerConn.Close();
                if (DataBaseCheckS == false)
                {
                    string CreateDbaseStr = string.Format("create database {0};", "ElkonScada");
                    SqlCommand myCommand = new SqlCommand(CreateDbaseStr, ServerConn);
                    try
                    {
                        ServerConn.Open();

                        myCommand.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                    }
                    finally
                    {
                        if (ServerConn.State == System.Data.ConnectionState.Open)
                        {
                            ServerConn.Close();
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Sql Connection Error!!");
            }
            
          

      
        }
        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
