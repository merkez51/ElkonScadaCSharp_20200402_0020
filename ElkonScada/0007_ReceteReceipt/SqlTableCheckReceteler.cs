using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada
{
	class SqlTableCheckReceteler
	{
		SqlConnection ServerConn = new SqlConnection(@"server=.\SQLEXPRESS;Trusted_Connection=yes");
		public static SqlConnection DatabaseConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElkonScada;Integrated Security=True");
		SqlDataAdapter DataAdapter;

        DataTable dt;
		private Boolean DataBaseCheckS, TabloCheckS = false;
		public bool DataBaseOlustur()
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
			string TabloSorgusu = "SELECT name FROM ElkonScada.sys.tables where name= 'Receteler' ";
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
				string CreateTstr = "CREATE TABLE Receteler" +
			   "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,ReceteAdi CHAR(250), ReceteAciklama CHAR(250)," +
            "ReceteAgrega1 FLOAT,ReceteAgrega2 FLOAT,ReceteAgrega3 FLOAT,ReceteAgrega4 FLOAT,ReceteAgrega5 FLOAT,ReceteAgrega6 FLOAT," +
            "ReceteAgrega7 FLOAT,ReceteAgrega8 FLOAT,ReceteAgrega9 FLOAT,ReceteAgrega10 FLOAT,ReceteCimento1 FLOAT,ReceteCimento2 FLOAT," +
            "ReceteCimento3 FLOAT,ReceteCimento4 FLOAT,ReceteCimento5 FLOAT,ReceteCimento6 FLOAT,ReceteCimento7 FLOAT,ReceteCimento8 FLOAT," +
            "ReceteCimento9 FLOAT,ReceteCimento10 FLOAT,ReceteSu1 FLOAT,ReceteSu2 FLOAT,ReceteSu3 FLOAT,ReceteSu4 FLOAT,ReceteSu5 FLOAT," +
            "ReceteSu6 FLOAT,ReceteSu7 FLOAT,ReceteSu8 FLOAT,ReceteSu9 FLOAT,ReceteSu10 FLOAT,ReceteKatki1 FLOAT,ReceteKatki2 FLOAT," +
            "ReceteKatki3 FLOAT,ReceteKatki4 FLOAT,ReceteKatki5 FLOAT,ReceteKatki6 FLOAT,ReceteKatki7 FLOAT,ReceteKatki8 FLOAT," +
            "ReceteKatki9 FLOAT,ReceteKatki10 FLOAT,ReceteCimentoGecikmeSuresi INTEGER,ReceteKatkıGecikmeSuresi INTEGER," +
            "ReceteSuGecikmeSuresi INTEGER,ReceteMikserBosaltmaSuresi INTEGER,ReceteMikserKaristirmaSuresi INTEGER," +
            "ReceteMikserKapakAcmaSuresi INTEGER,ReceteDurum CHAR(250), ReceteDayanimSinifi CHAR(250),ReceteKivamSinifi CHAR(100)," +
			"ReceteDonaKarsiDayaniklikSinifi CHAR(100),ReceteSuyaKarsiDirencSinifi CHAR(100),ReceteYogunlukSinifi CHAR(100)," +
            "ReceteBetonTipi CHAR(100),ReceteCevreselEtki CHAR(100),ReceteKlorurIcerigiSinifi CHAR(100),ReceteMaxSuCimOrani FLOAT," +
            "ReceteMinCimIcerigi CHAR(100),ReceteMinBetonDayanimSinifi CHAR(100),ReceteMinBetonHavaIcerigi CHAR(100))";
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
			DataAdapter = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY SiraNo) AS sira,* from Receteler", DatabaseConn);
			dt = new DataTable();
			DataAdapter.Fill(dt);
			return dt;
		}
	}
}

