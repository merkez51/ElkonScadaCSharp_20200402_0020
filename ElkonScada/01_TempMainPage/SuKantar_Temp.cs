using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkonScada._01_TempMainPage
{
    public partial class SuKantar_Temp : UserControl
    {
        public SuKantar_Temp()
        {
            InitializeComponent();
        }

        private void XB4_SuKantar_TextChanged(object sender, EventArgs e)
        {
            switch (XB4_SuKantar.Text)
            {
                case "0":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_01;
                    break;
                case "2":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_02;
                    break;
                case "3":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_03;
                    break;
                case "4":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_04;
                    break;
                case "5":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_05;
                    break;
                case "6":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_06;
                    break;
                case "7":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_07;
                    break;
                case "8":
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_08;
                    break;

                default:
                    s_SuKantarSeviye.Image = ElkonScada.Properties.Resources.Su_Kantar_01;

                    break;
            }
        }
    }
}
