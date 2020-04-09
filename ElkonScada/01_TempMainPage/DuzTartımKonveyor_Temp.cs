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
    public partial class DuzTartımKonveyor_Temp : UserControl
    {
        public DuzTartımKonveyor_Temp()
        {
            InitializeComponent();
        }

        private void is_ButonTartiBand1Vibrator_Click(object sender, EventArgs e)
        {
            if (Properties.M011_ButonLar.Default.is_ButonTartiBand1Vibrator == false)
            {
                Properties.M011_ButonLar.Default.is_ButonTartiBand1Vibrator = true;

            }
            else if (Properties.M011_ButonLar.Default.is_ButonTartiBand1Vibrator == true)
            {
                Properties.M011_ButonLar.Default.is_ButonTartiBand1Vibrator = false;

            }
        }
        byte animationTimer = 0;
        public void Lamps_TartiKonveyor()
        {
            animationTimer++;
            if (Properties.M012_Lambalar.Default.qs_TartiBand1Lambasi&& animationTimer<5)
            {
                qs_TartiBand1Lambasi.Image = Properties.Resources.Lamp_Green;
            }
            else if(!Properties.M012_Lambalar.Default.qs_TartiBand1Lambasi)
            {
                qs_TartiBand1Lambasi.Image = Properties.Resources.Lamp_Gray;

            }
            if (animationTimer>50)
            {
                animationTimer = 0;
            }
        }

        private void DuzTartımKonveyor_Temp_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath GrVibrator = new System.Drawing.Drawing2D.GraphicsPath();
            GrVibrator.AddEllipse(2, 2, 69, 64);
            is_ButonTartiBand1Vibrator.Region = new System.Drawing.Region(GrVibrator);

            System.Drawing.Drawing2D.GraphicsPath GrTartiBandi1 = new System.Drawing.Drawing2D.GraphicsPath();
            GrTartiBandi1.AddEllipse(2, 2, 69, 64);
            is_ButonTartiBand1.Region = new System.Drawing.Region(GrTartiBandi1);


            System.Drawing.Drawing2D.GraphicsPath grTarbiBandi1Lambasi = new System.Drawing.Drawing2D.GraphicsPath();
            grTarbiBandi1Lambasi.AddEllipse(2, 2, 69, 64);
            qs_TartiBand1Lambasi.Region = new System.Drawing.Region(grTarbiBandi1Lambasi);

            System.Drawing.Drawing2D.GraphicsPath GrTransferBandi = new System.Drawing.Drawing2D.GraphicsPath();
            GrTransferBandi.AddEllipse(2, 2, 69, 64);
            is_TransferBandButon.Region = new System.Drawing.Region(GrTransferBandi);

            System.Drawing.Drawing2D.GraphicsPath GrTransferBandiLambasi = new System.Drawing.Drawing2D.GraphicsPath();
            GrTransferBandiLambasi.AddEllipse(2, 2, 69, 64);
            qs_TransferBandLamba.Region = new System.Drawing.Region(GrTransferBandiLambasi);
        }
    }
}
