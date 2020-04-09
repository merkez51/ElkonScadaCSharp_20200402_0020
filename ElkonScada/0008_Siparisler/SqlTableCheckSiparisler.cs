using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ElkonScada._0008_Siparisler
{
    public class SqlTableCheckSiparisler
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
            string TabloSorgusu = "SELECT name FROM ElkonScada.sys.tables where name= 'Siparisler' ";
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
                string CreateTstr = "CREATE TABLE Siparisler" +
               "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,SiparisNo CHAR(150) , FirmaAdi CHAR(150)," +
            "SantiyeAdi CHAR(150),SiparisMiktari CHAR(100),ReceteAdi CHAR(150),YapilanMiktar CHAR(100),KalanMiktar CHAR(100))";
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
            DataAdapter = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY SiraNo) AS No,* from Siparisler", DatabaseConn);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            return dt;
        }
    }
}

