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
    public partial class CimentoKantar_Temp : UserControl
    {
        public CimentoKantar_Temp()
        {
            InitializeComponent();
        }

        private void deneme_textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        

        private void deneme_textbox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

		private void qs_CimentoBosaltVibratorLambasi_Click(object sender, EventArgs e)
		{

		}

		private void CimentoKantar_Temp_Load(object sender, EventArgs e)
		{
			

			
		}

		private void s_CimentoKantarSeviye_Click(object sender, EventArgs e)
		{
			
		}

		private void CimentoKantar_Temp_Load_1(object sender, EventArgs e)
		{
			System.Drawing.Drawing2D.GraphicsPath grPathis = new System.Drawing.Drawing2D.GraphicsPath();
			grPathis.AddEllipse(6, 6, 56, 56);
			is_ButonCimentoBosaltVibrator.Region = new System.Drawing.Region(grPathis);
			System.Drawing.Drawing2D.GraphicsPath grPath = new System.Drawing.Drawing2D.GraphicsPath();
			grPath.AddEllipse(2, 2, 82, 82);
			qs_CimentoBosaltVibratorLambasi.Region = new System.Drawing.Region(grPath);
		}

		private void s_CimentoKantarSeviye_Click_1(object sender, EventArgs e)
		{

		}
	}

}
