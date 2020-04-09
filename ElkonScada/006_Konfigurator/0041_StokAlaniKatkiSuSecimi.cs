using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._006_Konfigurator
{
    public partial class _0041_StokAlaniKatkiSuSecimi : Form
    {
        public _0041_StokAlaniKatkiSuSecimi()
        {
            InitializeComponent();
        }

        private void Pic_KatkiKantar1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 1;
            KatkiPictureBlur();

        }

        private void Pic_KatkiKantar2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 2;
            KatkiPictureBlur();

        }

        private void Pic_KatkiKantar3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 3;
            KatkiPictureBlur();

        }

        private void Pic_KatkiKantar4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 4;
            KatkiPictureBlur();

        }

        private void Pic_KatkiKantar5_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 5;
            KatkiPictureBlur();

        }

        private void Pic_KatkiSayac1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 1;
            KatkiPictureBlur();

        }

        private void Pic_KatkiSayac2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 2;
            KatkiPictureBlur();

        }

        private void Pic_KatkiSayac3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 3;
            KatkiPictureBlur();

        }

        private void Pic_KatkiSayac4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 4;
            KatkiPictureBlur();

        }

        private void Pic_KatkiSayac5_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiSayisi = 5;
            KatkiPictureBlur();
        }
        private void KatkiPictureBlur()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.KatkiSayisi)
            {
                case 1:
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim1.BackColor = Color.Green;
                        Button_KatkiSayacSecim1.BackColor = Color.Red;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim1.BackColor = Color.Red;
                        Button_KatkiSayacSecim1.BackColor = Color.Green;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var



                    }
                    Button_KatkiKantarSecim1.Visible = true;
                    Button_KatkiKantarSecim2.Visible = false;
                    Button_KatkiKantarSecim3.Visible = false;
                    Button_KatkiKantarSecim4.Visible = false;
                    Button_KatkiKantarSecim5.Visible = false;

                    Button_KatkiSayacSecim1.Visible = true;
                    Button_KatkiSayacSecim2.Visible = false;
                    Button_KatkiSayacSecim3.Visible = false;
                    Button_KatkiSayacSecim4.Visible = false;
                    Button_KatkiSayacSecim5.Visible = false;

                    Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config_Blur;

                    Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config_Blur;


                    break;
                case 2:
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim1.BackColor = Color.Green;
                        Button_KatkiSayacSecim1.BackColor = Color.Red;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok


                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim1.BackColor = Color.Red;
                        Button_KatkiSayacSecim1.BackColor = Color.Green;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim2.BackColor = Color.Green;
                        Button_KatkiSayacSecim2.BackColor = Color.Red;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config_Blur;

                        Button_KatkiKantarSecim2.BackColor = Color.Red;
                        Button_KatkiSayacSecim2.BackColor = Color.Green;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    Button_KatkiKantarSecim1.Visible = true;
                    Button_KatkiKantarSecim2.Visible = true;
                    Button_KatkiKantarSecim3.Visible = false;
                    Button_KatkiKantarSecim4.Visible = false;
                    Button_KatkiKantarSecim5.Visible = false;

                    Button_KatkiSayacSecim1.Visible = true;
                    Button_KatkiSayacSecim2.Visible = true;
                    Button_KatkiSayacSecim3.Visible = false;
                    Button_KatkiSayacSecim4.Visible = false;
                    Button_KatkiSayacSecim5.Visible = false;

                   
                    Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config_Blur;

                    Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config_Blur;
                    break;
                case 3:

                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim1.BackColor = Color.Green;
                        Button_KatkiSayacSecim1.BackColor = Color.Red;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim1.BackColor = Color.Red;
                        Button_KatkiSayacSecim1.BackColor = Color.Green;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim2.BackColor = Color.Green;
                        Button_KatkiSayacSecim2.BackColor = Color.Red;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok
                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim2.BackColor = Color.Red;
                        Button_KatkiSayacSecim2.BackColor = Color.Green;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim3.BackColor = Color.Green;
                        Button_KatkiSayacSecim3.BackColor = Color.Red;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1664_1;//Sayaç yok
                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim3.BackColor = Color.Red;
                        Button_KatkiSayacSecim3.BackColor = Color.Green;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    Button_KatkiKantarSecim1.Visible = true;
                    Button_KatkiKantarSecim2.Visible = true;
                    Button_KatkiKantarSecim3.Visible = true;
                    Button_KatkiKantarSecim4.Visible = false;
                    Button_KatkiKantarSecim5.Visible = false;

                    Button_KatkiSayacSecim1.Visible = true;
                    Button_KatkiSayacSecim2.Visible = true;
                    Button_KatkiSayacSecim3.Visible = true;
                    Button_KatkiSayacSecim4.Visible = false;
                    Button_KatkiSayacSecim5.Visible = false;


                    Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config_Blur;

                    Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config_Blur;
                    Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config_Blur;

                    break;
                case 4:

                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim1.BackColor = Color.Green;
                        Button_KatkiSayacSecim1.BackColor = Color.Red;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim1.BackColor = Color.Red;
                        Button_KatkiSayacSecim1.BackColor = Color.Green;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim2.BackColor = Color.Green;
                        Button_KatkiSayacSecim2.BackColor = Color.Red;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim2.BackColor = Color.Red;
                        Button_KatkiSayacSecim2.BackColor = Color.Green;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim3.BackColor = Color.Green;
                        Button_KatkiSayacSecim3.BackColor = Color.Red;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim3.BackColor = Color.Red;
                        Button_KatkiSayacSecim3.BackColor = Color.Green;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true)
                    {
                        Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim4.BackColor = Color.Green;
                        Button_KatkiSayacSecim4.BackColor = Color.Red;
                        Button_KatkiKantarSecim4.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim4.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                    {
                        Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim4.BackColor = Color.Red;
                        Button_KatkiSayacSecim4.BackColor = Color.Green;
                        Button_KatkiKantarSecim4.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim4.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    Button_KatkiKantarSecim1.Visible = true;
                    Button_KatkiKantarSecim2.Visible = true;
                    Button_KatkiKantarSecim3.Visible = true;
                    Button_KatkiKantarSecim4.Visible = true;
                    Button_KatkiKantarSecim5.Visible = false;

                    Button_KatkiSayacSecim1.Visible = true;
                    Button_KatkiSayacSecim2.Visible = true;
                    Button_KatkiSayacSecim3.Visible = true;
                    Button_KatkiSayacSecim4.Visible = true;
                    Button_KatkiSayacSecim5.Visible = false;


                    Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config_Blur;

                    Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config_Blur;
                    break;
                case 5:
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == true)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim1.BackColor = Color.Green;
                        Button_KatkiSayacSecim1.BackColor = Color.Red;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 == false)
                    {
                        Pic_KatkiSayac1.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar1.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim1.BackColor = Color.Red;
                        Button_KatkiSayacSecim1.BackColor = Color.Green;
                        Button_KatkiKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == true)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim2.BackColor = Color.Green;
                        Button_KatkiSayacSecim2.BackColor = Color.Red;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 == false)
                    {
                        Pic_KatkiSayac2.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar2.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim2.BackColor = Color.Red;
                        Button_KatkiSayacSecim2.BackColor = Color.Green;
                        Button_KatkiKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == true)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim3.BackColor = Color.Green;
                        Button_KatkiSayacSecim3.BackColor = Color.Red;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 == false)
                    {
                        Pic_KatkiSayac3.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar3.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim3.BackColor = Color.Red;
                        Button_KatkiSayacSecim3.BackColor = Color.Green;
                        Button_KatkiKantarSecim3.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim3.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == true)
                    {
                        Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim4.BackColor = Color.Green;
                        Button_KatkiSayacSecim4.BackColor = Color.Red;
                        Button_KatkiKantarSecim4.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim4.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 == false)
                    {
                        Pic_KatkiSayac4.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar4.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim4.BackColor = Color.Red;
                        Button_KatkiSayacSecim4.BackColor = Color.Green;
                        Button_KatkiKantarSecim4.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim4.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == true)
                    {
                        Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config;
                        Button_KatkiKantarSecim5.BackColor = Color.Green;
                        Button_KatkiSayacSecim5.BackColor = Color.Red;
                        Button_KatkiKantarSecim5.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_KatkiSayacSecim5.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 == false)
                    {
                        Pic_KatkiSayac5.Image = Properties.Resources.KatkiPump_Config;
                        Pic_KatkiKantar5.Image = Properties.Resources.KatkiPump_Config_Blur;
                        Button_KatkiKantarSecim5.BackColor = Color.Red;
                        Button_KatkiSayacSecim5.BackColor = Color.Green;
                        Button_KatkiKantarSecim5.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_KatkiSayacSecim5.Text = Localization.Localization.ES1663_1;//Sayaç Var

                    }
                    Button_KatkiKantarSecim1.Visible = true;
                    Button_KatkiKantarSecim2.Visible = true;
                    Button_KatkiKantarSecim3.Visible = true;
                    Button_KatkiKantarSecim4.Visible = true;
                    Button_KatkiKantarSecim5.Visible = true;

                    Button_KatkiSayacSecim1.Visible = true;
                    Button_KatkiSayacSecim2.Visible = true;
                    Button_KatkiSayacSecim3.Visible = true;
                    Button_KatkiSayacSecim4.Visible = true;
                    Button_KatkiSayacSecim5.Visible = true;


            
                    break;

                default:
                    break;
            }
        }

        private void Button_KatkiKantarSecim1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 = true;
            KatkiPictureBlur();

        }

        private void Button_KatkiKantarSecim2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 = true;
            KatkiPictureBlur();


        }

        private void Button_KatkiKantarSecim3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 = true;
            KatkiPictureBlur();

        }

        private void Button_KatkiKantarSecim4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 = true;
            KatkiPictureBlur();

        }

        private void Button_KatkiKantarSecim5_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 = true;
            KatkiPictureBlur();

        }

        private void Button_KatkiSayacSecim1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok1 = false;
            KatkiPictureBlur();

        }

        private void Button_KatkiSayacSecim2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok2 = false;
            KatkiPictureBlur();

        }

        private void Button_KatkiSayacSecim3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok3 = false;
            KatkiPictureBlur();

        }

        private void Button_KatkiSayacSecim4_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok4 = false;
            KatkiPictureBlur();

        }

        private void Button_KatkiSayacSecim6_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.KatkiKantarVarYok5 = false;
            KatkiPictureBlur();

        }

        private void _0041_StokAlaniKatkiSuSecimi_Load(object sender, EventArgs e)
        {
            KatkiPictureBlur();
            SuKantarSecimFunction();


        }

        private void Pic_SuKantar1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 1;
            SuKantarSecimFunction();
        }

        private void Pic_SuKantar2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 2;
            SuKantarSecimFunction();

        }

        private void Pic_SuKantar3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 3;
            SuKantarSecimFunction();

        }

        private void Pic_SuSayac1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 1;
            SuKantarSecimFunction();

        }

        private void Pic_SuSayac2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 2;
            SuKantarSecimFunction();

        }

        private void Pic_SuSayac3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuSayisi = 3;
            SuKantarSecimFunction();

        }

        private void SuKantarSecimFunction()
        {
            switch (Properties.S000_Konfigrator_Tag.Default.SuSayisi)
            {
                case 1:
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue;
                        Button_SuKantarSecim1.BackColor = Color.Green;
                        Button_SuSayacSecim1.BackColor = Color.Red;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim1.BackColor = Color.Red;
                        Button_SuSayacSecim1.BackColor = Color.Green;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var



                    }
                    Button_SuKantarSecim1.Visible = true;
                    Button_SuKantarSecim2.Visible = false;
                    Button_SuKantarSecim3.Visible = false;

                    Button_SuSayacSecim1.Visible = true;
                    Button_SuSayacSecim2.Visible = false;
                    Button_SuSayacSecim3.Visible = false;

                    Pic_SuSayac2.Image = Properties.Resources.Water_Pump_Blue_Blur;
                    Pic_SuSayac3.Image = Properties.Resources.Water_Pump_Blue_Blur;

                    Pic_SuKantar2.Image = Properties.Resources.Water_Pump_Blue_Blur;
                    Pic_SuKantar3.Image = Properties.Resources.Water_Pump_Blue_Blur;


                    break;
                case 2:
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim1.BackColor = Color.Green;
                        Button_SuSayacSecim1.BackColor = Color.Red;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok


                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim1.BackColor = Color.Red;
                        Button_SuSayacSecim1.BackColor = Color.Green;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)
                    {
                        Pic_SuSayac2.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Pic_SuKantar2.Image = Properties.Resources.Water_Pump_Blue;
                        Button_SuKantarSecim2.BackColor = Color.Green;
                        Button_SuSayacSecim2.BackColor = Color.Red;
                        Button_SuKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false)
                    {
                        Pic_SuSayac2.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar2.Image = Properties.Resources.Water_Pump_Blue_Blur;

                        Button_SuKantarSecim2.BackColor = Color.Red;
                        Button_SuSayacSecim2.BackColor = Color.Green;
                        Button_SuKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    Button_SuKantarSecim1.Visible = true;
                    Button_SuKantarSecim2.Visible = true;
                    Button_SuKantarSecim3.Visible = false;

                    Button_SuSayacSecim1.Visible = true;
                    Button_SuSayacSecim2.Visible = true;
                    Button_SuSayacSecim3.Visible = false;


                    Pic_SuSayac3.Image = Properties.Resources.Water_Pump_Blue_Blur;
                    

                    Pic_SuKantar3.Image = Properties.Resources.Water_Pump_Blue_Blur;
          
                    break;
                case 3:

                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == true)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue;
                        Button_SuKantarSecim1.BackColor = Color.Green;
                        Button_SuSayacSecim1.BackColor = Color.Red;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1664_1;//Sayaç yok

                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 == false)
                    {
                        Pic_SuSayac1.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar1.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim1.BackColor = Color.Red;
                        Button_SuSayacSecim1.BackColor = Color.Green;
                        Button_SuKantarSecim1.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim1.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == true)
                    {
                        Pic_SuSayac2.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Pic_SuKantar2.Image = Properties.Resources.Water_Pump_Blue;
                        Button_SuKantarSecim2.BackColor = Color.Green;
                        Button_SuSayacSecim2.BackColor = Color.Red;
                        Button_SuKantarSecim2.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim2.Text = Localization.Localization.ES1664_1;//Sayaç yok
                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 == false)
                    {
                        Pic_SuSayac2.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar2.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim2.BackColor = Color.Red;
                        Button_SuSayacSecim2.BackColor = Color.Green;
                        Button_SuKantarSecim2.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim2.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == true)
                    {
                        Pic_SuSayac3.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Pic_SuKantar3.Image = Properties.Resources.Water_Pump_Blue;
                        Button_SuKantarSecim3.BackColor = Color.Green;
                        Button_SuSayacSecim3.BackColor = Color.Red;
                        Button_SuKantarSecim3.Text = Localization.Localization.ES1666_1;//Kantar Var
                        Button_SuSayacSecim3.Text = Localization.Localization.ES1664_1;//Sayaç yok
                    }
                    else if (Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 == false)
                    {
                        Pic_SuSayac3.Image = Properties.Resources.Water_Pump_Blue;
                        Pic_SuKantar3.Image = Properties.Resources.Water_Pump_Blue_Blur;
                        Button_SuKantarSecim3.BackColor = Color.Red;
                        Button_SuSayacSecim3.BackColor = Color.Green;
                        Button_SuKantarSecim3.Text = Localization.Localization.ES1665_1;//Kantar Yok
                        Button_SuSayacSecim3.Text = Localization.Localization.ES1663_1;//Sayaç Var
                    }
                    Button_SuKantarSecim1.Visible = true;
                    Button_SuKantarSecim2.Visible = true;
                    Button_SuKantarSecim3.Visible = true;

                    Button_SuSayacSecim1.Visible = true;
                    Button_SuSayacSecim2.Visible = true;
                    Button_SuSayacSecim3.Visible = true;
                    break;
                default:
                    break;
            }
        }

     

        private void Button_SuKantarSecim1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 = true;
            SuKantarSecimFunction();

        }

        private void Button_SuKantarSecim2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 = true; 
            SuKantarSecimFunction();

        }

        private void Button_SuKantarSecim3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 = true;
            SuKantarSecimFunction();

        }
        private void Button_SuSayacSecim1_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok1 = false;
            SuKantarSecimFunction();
        }
        private void Button_SuSayacSecim2_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok2 = false;
            SuKantarSecimFunction();
        }

        private void Button_SuSayacSecim3_Click(object sender, EventArgs e)
        {
            Properties.S000_Konfigrator_Tag.Default.SuKantarVarYok3 = false;
            SuKantarSecimFunction();
        }

        private void BackWindow_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._003_StokAlaniAgregaSecimi StokAlanlarıAgregaSecim = new _003_StokAlaniAgregaSecimi();
            StokAlanlarıAgregaSecim.Show();
            this.Close();
        }

        private void NextWindow_Click(object sender, EventArgs e)
        {
            ElkonScada._006_Konfigurator._004_StokAlaniCimentoKatkiSuSecimi KonfigOnaySayfasi = new _004_StokAlaniCimentoKatkiSuSecimi();
            KonfigOnaySayfasi.Show();
            this.Close();
        }

        private void _0041_StokAlaniKatkiSuSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }
}
