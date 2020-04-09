using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ElkonScada._0001_Firmalar
{
    public class SqlTableCheckFirmalar
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
            string TabloSorgusu = "SELECT name FROM ElkonScada.sys.tables where name= 'Firmalar' ";
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
                string CreateTstr = "CREATE TABLE Firmalar" +
               "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,FirmaAdi CHAR(200), TelefonFaks CHAR(100)," +
            "Adres CHAR(250),IlgiliKisi CHAR(100),VergiDairesi CHAR(150),VergiNumarasi CHAR(100),Durumu CHAR(50))";
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
            DataAdapter = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY SiraNo) AS No,* from Firmalar", DatabaseConn);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            return dt;
        }
    }
}

