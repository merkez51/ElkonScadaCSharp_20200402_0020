using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ElkonScada._0011_ToplamHarcananMalzemeRaporu
{
    public class SqlTableCheckToplamHarcananMR
    {
        SqlConnection ServerConn = new SqlConnection(@"server=.\SQLEXPRESS;Trusted_Connection=yes");
        public static SqlConnection DatabaseConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElkonScada;Integrated Security=True");
        private Boolean DataBaseCheckS, TabloCheckS = false;
        SqlDataAdapter DataAdapter;
        DataTable dt;
        public bool DataBaseOlustur()
        {
            String DbaseSorguStr = "SELECT name FROM master.dbo.sysdatabases   WHERE name='ElkonScada' ";
            SqlCommand cmd = new SqlCommand(DbaseSorguStr, ServerConn);
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

            if (TabloOlustur() && DataBaseCheckS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool TabloOlustur()
        {
            string TabloSorgusu = "SELECT name FROM ElkonScada.sys.tables where name= 'ToplamHarcananMalzemeRaporu' ";
            SqlCommand tablosorgucommand = new SqlCommand(TabloSorgusu, DatabaseConn);
            DatabaseConn.Open();
            tablosorgucommand.ExecuteNonQuery();
            SqlDataReader tablodurumunuoku = tablosorgucommand.ExecuteReader();
            while (tablodurumunuoku.Read())
            {
                TabloCheckS = true;

            }
            DatabaseConn.Close();
            if (TabloCheckS == false)
            {
                string CreateTstr = "CREATE TABLE ToplamHarcananMalzemeRaporu" +
               "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,Recete CHAR(250), ReceteAciklama CHAR(250),ReceteAgrega1 CHAR(50)," +
               "ReceteAgrega2 CHAR(50),ReceteAgrega3 CHAR(50),ReceteAgrega4 CHAR(50),ReceteAgrega5 CHAR(50),ReceteAgrega6 CHAR(50)," +
            "ReceteAgrega7 CHAR(50),ReceteAgrega8 CHAR(50),ReceteAgrega9 CHAR(50),ReceteAgrega10 CHAR(50),ReceteCimento1 CHAR(50)," +
            "ReceteCimento2 CHAR(50),ReceteCimento3 CHAR(50),ReceteCimento4 CHAR(50),ReceteCimento5 CHAR(50),ReceteCimento6 CHAR(50)," +
            "ReceteCimento7 CHAR(50),ReceteCimento8 CHAR(50),ReceteCimento9 CHAR(50),ReceteCimento10 CHAR(50),ReceteSu1 CHAR(50)," +
            "ReceteSu2 CHAR(50),ReceteSu3 CHAR(50),ReceteSu4 CHAR(50),ReceteSu5 CHAR(50),ReceteSu6 CHAR(50),ReceteSu7 CHAR(50)," +
            "ReceteSu8 CHAR(50),ReceteSu9 CHAR(50),ReceteSu10 CHAR(50),ReceteKatki1 CHAR(50),ReceteKatki2 CHAR(50),ReceteKatki3 CHAR(50)," +
            "ReceteKatki4 CHAR(50),ReceteKatki5 CHAR(50),ReceteKatki6 CHAR(50),ReceteKatki7 CHAR(50),ReceteKatki8 CHAR(50)," +
            "ReceteKatki9 CHAR(50),ReceteKatki10 CHAR(50),GirisMiktari CHAR(50))";
                SqlCommand CreateTSqlCommand = new SqlCommand(CreateTstr, DatabaseConn);
                DatabaseConn.Open();
                CreateTSqlCommand.ExecuteNonQuery();
                DatabaseConn.Close();

            }
            if (TabloCheckS) return true;
            else return false;
        }
        public DataTable ShowData()
        {
            DataAdapter = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY SiraNo) AS No,* from ToplamHarcananMalzemeRaporu", DatabaseConn);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            return dt;
        }
    }
}
