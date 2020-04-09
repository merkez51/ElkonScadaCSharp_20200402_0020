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
    public partial class SuBosaltButon : UserControl
    {
        public SuBosaltButon()
        {
            InitializeComponent();
        }

        private void is_ButonSuBosalt_Click(object sender, EventArgs e)
        {
            
        }

        private void is_ButonSuBosalt_MouseClick(object sender, MouseEventArgs e)
        {
            is_ButonSuBosalt.Image = ElkonScada.Properties.Resources.Button_Green;
        }

        private void denemetextBox1_TextChanged(object sender, EventArgs e)
        {
            switch (denemetextBox1.Text)
            {
                case "1":
                    is_ButonSuBosalt.Image = ElkonScada.Properties.Resources.Button_Green;
                    break;

                default:
                    is_ButonSuBosalt.Image = ElkonScada.Properties.Resources.Button_White;
                    break;
            }
        }
    }
}
