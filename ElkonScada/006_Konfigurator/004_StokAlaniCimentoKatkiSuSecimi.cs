using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._006_Konfigurator
{
    public partial class _004_StokAlaniCimentoKatkiSuSecimi : Form
    {
        SqlConnection ServerConn = new SqlConnection(@"server=.\SQLEXPRESS;Trusted_Connection=yes");
        public static SqlConnection DatabaseConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElkonScada;Integrated Security=True");
        public _004_StokAlaniCimentoKatkiSuSecimi()
        {
            InitializeComponent();
        }

        private void Pic_CimentoSilo1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 1;
            CimentoSiloFunction();
        }

        private void Pic_CimentoSilo2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 2;
            CimentoSiloFunction();
         }

        private void Pic_CimentoSilo3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 3;
            CimentoSiloFunction();
        }

        private void Pic_CimentoSilo4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 4;
            CimentoSiloFunction();
        }

        private void Pic_CimentoSilo5_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 5;
            CimentoSiloFunction();
        }

        private void Pic_CimentoSilo6_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi = 6;
            CimentoSiloFunction();
        }
        private void CimentoSiloFunction()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi)
            {
                case 1:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo_Blur;

                    break;
                case 2:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo_Blur;
                    break;
                case 3:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo_Blur;
                    break;
                case 4:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo_Blur;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo_Blur;
                    break;
                case 5:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo_Blur;

                    break;
                case 6:
                    Pic_CimentoSilo1.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo2.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo3.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo4.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo5.Image = Properties.Resources.Cimento_Silo;
                    Pic_CimentoSilo6.Image = Properties.Resources.Cimento_Silo;
                    break;
                default:
                    break;
            }

         
        }
        
        private void Pic_TorbaliHelezon_Click(object sender, EventArgs e)
        {
       
      
             
                if (Properties.S000_Konfigrator_Tag.Default.TorbaliHelezonSecimi)
                {
                    Pic_TorbaliHelezon.Image = Properties.Resources.Torba_Silo_Blur;
                    Properties.S000_Konfigrator_Tag.Default.TorbaliHelezonSecimi = true;
                }
                else if (!Properties.S000_Konfigrator_Tag.Default.TorbaliHelezonSecimi)
                {
                    Pic_TorbaliHelezon.Image = Properties.Resources.Torba_Silo;
                    Properties.S000_Konfigrator_Tag.Default.TorbaliHelezonSecimi = false;
                }
         
        }

        private void _004_StokAlaniCimentoKatkiSuSecimi_Load(object sender, EventArgs e)
        {
            CimentoSiloFunction();
            if (Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi == 22 || Properties.S000_Konfigrator_Tag.Default.SecilenSantralTipi == 23)
            {
                Pic_TorbaliHelezon.Visible = true;
         
            }
            else
            {
                Pic_TorbaliHelezon.Visible = false;
            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.Reload();

        }

        private void NextWindow_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._005_KantarKapasiteleri_OzelAyarlar OzelAyar = new _005_KantarKapasiteleri_OzelAyarlar();

            OzelAyar.Show();
            this.Close();
        }

        public void KonfigrasyonTamamla_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.konfigrasyonYapiliyor = true;
            try
            {
                Properties.S000_Konfigrator_Tag.Default.Save();

            }
            catch (Exception)
            {
                MessageBox.Show("konfigrasyonYapilamadi");
            }
            MalzemelerOlustur();
           
            //  this.Close();
            // ((Firmalar)Application.OpenForms["Firmalar"]).firmagetir();

            
            // ((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.AgregaSiloYerlesimi();
          
            // ((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.cimento_Temp1.BelirlenenSiloSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.Su_Button_Yerlesimi.BelirlenenSuSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.katki_Temp1.BelirlenenKatkiSayisi();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.Santral_belirleme();
            //((_002.Sayfalar.Anasayfa)Application.OpenForms["Anasayfa"]).MainPageUserControl.mixer_Temp_TW1.Miksersecimi();






        }
        public void MalzemelerOlustur()
        {
            //<Malzemele adeti belirleme>>
            // DELETE FROM Mazlemeler
            string TabloSorgusu = "DELETE FROM Malzemeler ";
            SqlCommand tablosorgucommand = new SqlCommand(TabloSorgusu, DatabaseConn);
            DatabaseConn.Open();
            try
            {
                tablosorgucommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            string TabloSorgusu2 = "CREATE TABLE Malzemeler" +
               "(SiraNo INTEGER IDENTITY(1,1) PRIMARY KEY,MalzemeAdi CHAR(100),MalzemeType CHAR(100), Aciklama1 CHAR(150)," +
            "Aciklama2 CHAR(150),Durumu CHAR(50))"; 
            SqlCommand tablosorgucommand2 = new SqlCommand(TabloSorgusu2, DatabaseConn);
            try
            {
                tablosorgucommand2.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }



            switch (Properties.S000_Konfigrator_Tag.Default.SecilenBunkerSayisi)
            {
                case 1:
                    string sql1 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
           
                   "values('" + Localization.Localization.ES351_1+"1" + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                    SqlCommand cmd = new SqlCommand(sql1, DatabaseConn);
                    cmd.ExecuteNonQuery();
                    break;
                case 2:
                    for (int i = 1; i < 3; i++)
                    {
                        string sql2 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES351_1+i.ToString() + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd1 = new SqlCommand(sql2, DatabaseConn);
                        cmd1.ExecuteNonQuery();
                    }
                    

                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        string sql3 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES351_1 + i.ToString() + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd3 = new SqlCommand(sql3, DatabaseConn);
                        cmd3.ExecuteNonQuery();
                    }

                    break;
                case 4:
                    for (int i = 1; i < 5; i++)
                    {
                        string sql4 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES351_1 + i.ToString() + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd4 = new SqlCommand(sql4, DatabaseConn);
                        cmd4.ExecuteNonQuery();
                    }

                    break;
                case 5:
                    for (int i = 1; i < 6; i++)
                    {
                        string sql5 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES351_1 + i.ToString() + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd5 = new SqlCommand(sql5, DatabaseConn);
                        cmd5.ExecuteNonQuery();
                    }
                 


                    break;
                case 6:
                    for (int i = 1; i < 7; i++)
                    {
                        string sql6 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES351_1 + i.ToString() + "','" + "1" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd6 = new SqlCommand(sql6, DatabaseConn);
                        cmd6.ExecuteNonQuery();
                    }
                    break;
                default:
                    break;
            }
            //-------------------------------------------
            switch (Properties.S000_Konfigrator_Tag.Default.SecilenCimentoSayisi)
            {
                case 1:
                    string sql1 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1+"1" + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                    SqlCommand cmd = new SqlCommand(sql1, DatabaseConn);
                    cmd.ExecuteNonQuery();
                    break;
                case 2:
                    for (int i = 1; i < 3; i++)
                    {
                        string sql2 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1 + i.ToString() + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd1 = new SqlCommand(sql2, DatabaseConn);
                        cmd1.ExecuteNonQuery();
                    }


                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        string sql3 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1 + i.ToString() + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd3 = new SqlCommand(sql3, DatabaseConn);
                        cmd3.ExecuteNonQuery();
                    }

                    break;
                case 4:
                    for (int i = 1; i < 5; i++)
                    {
                        string sql4 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1 + i.ToString() + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd4 = new SqlCommand(sql4, DatabaseConn);
                        cmd4.ExecuteNonQuery();
                    }

                    break;
                case 5:
                    for (int i = 1; i < 6; i++)
                    {
                        string sql5 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1 + i.ToString() + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd5 = new SqlCommand(sql5, DatabaseConn);
                        cmd5.ExecuteNonQuery();
                    }



                    break;
                case 6:
                    for (int i = 1; i < 7; i++)
                    {
                        string sql6 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES208_1 + i.ToString() + "','" + "2" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd6 = new SqlCommand(sql6, DatabaseConn);
                        cmd6.ExecuteNonQuery();
                    }
                    break;
                default:
                    break;
            }
            //-------------------------------
            switch (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
            {
                case 1:
                    string sql1 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" +Localization.Localization.ES209_1+"1" + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                    SqlCommand cmd = new SqlCommand(sql1, DatabaseConn);
                    cmd.ExecuteNonQuery();
                    break;
                case 2:
                    for (int i = 1; i < 3; i++)
                    {
                        string sql2 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES209_1 + i.ToString() + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd1 = new SqlCommand(sql2, DatabaseConn);
                        cmd1.ExecuteNonQuery();
                    }


                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        string sql3 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES209_1 + i.ToString() + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd3 = new SqlCommand(sql3, DatabaseConn);
                        cmd3.ExecuteNonQuery();
                    }

                    break;
                case 4:
                    for (int i = 1; i < 5; i++)
                    {
                        string sql4 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES209_1 + i.ToString() + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd4 = new SqlCommand(sql4, DatabaseConn);
                        cmd4.ExecuteNonQuery();
                    }

                    break;
                case 5:
                    for (int i = 1; i < 6; i++)
                    {
                        string sql5 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES209_1 + i.ToString() + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd5 = new SqlCommand(sql5, DatabaseConn);
                        cmd5.ExecuteNonQuery();
                    }



                    break;
                case 6:
                    for (int i = 1; i < 7; i++)
                    {
                        string sql6 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES209_1 + i.ToString() + "','" + "3" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd6 = new SqlCommand(sql6, DatabaseConn);
                        cmd6.ExecuteNonQuery();
                    }
                    break;
                default:
                    break;
            }
            //-------------------------------
            switch (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
            {
                case 1:
                    string sql1 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES98_1+"1" + "','" + "4" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                    SqlCommand cmd = new SqlCommand(sql1, DatabaseConn);
                    cmd.ExecuteNonQuery();
                    break;
                case 2:
                    for (int i = 1; i < 3; i++)
                    {
                        string sql2 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES98_1 + i.ToString() + "','" + "4" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd1 = new SqlCommand(sql2, DatabaseConn);
                        cmd1.ExecuteNonQuery();
                    }


                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        string sql3 = "insert into Malzemeler(MalzemeAdi,MalzemeType,Aciklama1,Aciklama2,Durumu)" +
                   "values('" + Localization.Localization.ES98_1 + i.ToString() + "','" + "4" + "','" + "none" + "','" + "none" + "','" +  Localization.Localization.ES1363_1 + "')";
                        SqlCommand cmd3 = new SqlCommand(sql3, DatabaseConn);
                        cmd3.ExecuteNonQuery();
                    }

                    break;
             
                default:
                    break;
            }


            KonfigrasyonTamamla.BackgroundImage = Properties.Resources.Konfigrator_OK;

            DatabaseConn.Close();
            //<Malzeme adeti belirleme>
        }
        private void BackWindow_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._004_StokAlaniCimentoKatkiSuSecimi KatkiPage = new _004_StokAlaniCimentoKatkiSuSecimi();
            KatkiPage.Show();
            Properties.S000_Konfigrator_Tag.Default.Reload();

            this.Close();
        }
    }
}
