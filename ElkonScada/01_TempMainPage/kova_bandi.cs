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
    public partial class kova_bandi : UserControl
    {
        public kova_bandi()
        {
            InitializeComponent();
        }

        private void kova_bandi_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath grKovaAsagidaLambasi = new System.Drawing.Drawing2D.GraphicsPath();
            grKovaAsagidaLambasi.AddEllipse(0, 0, 20, 20);
            qs_KovaAsagidaLambasi.Region = new System.Drawing.Region(grKovaAsagidaLambasi);

            System.Drawing.Drawing2D.GraphicsPath grKovaOrtadaLambasi = new System.Drawing.Drawing2D.GraphicsPath();
            grKovaOrtadaLambasi.AddEllipse(0, 0, 20, 20);
            qs_KovaOrtadaLambasi.Region = new System.Drawing.Region(grKovaOrtadaLambasi);

            System.Drawing.Drawing2D.GraphicsPath grKovaYukaridaLambasi = new System.Drawing.Drawing2D.GraphicsPath();
            grKovaYukaridaLambasi.AddEllipse(0, 0, 20, 20);
            qs_KovaYukaridaLambasi.Region = new System.Drawing.Region(grKovaYukaridaLambasi);

            System.Drawing.Drawing2D.GraphicsPath grFrenAcik = new System.Drawing.Drawing2D.GraphicsPath();
            grFrenAcik.AddEllipse(0, 0, 45, 45);
            qs_FrenAcik.Region = new System.Drawing.Region(grFrenAcik);

            System.Drawing.Drawing2D.GraphicsPath grKovaAsagiStart = new System.Drawing.Drawing2D.GraphicsPath();
            grKovaAsagiStart.AddEllipse(0, 0, 20, 20);
            q_KovaAsagiStart.Region = new System.Drawing.Region(grKovaAsagiStart);

            System.Drawing.Drawing2D.GraphicsPath grKovaAsagiLambasi = new System.Drawing.Drawing2D.GraphicsPath();
            grKovaAsagiLambasi.AddEllipse(0, 0, 64, 64);
            qs_KovaAsagiLambasi.Region = new System.Drawing.Region(grKovaAsagiLambasi);

            System.Drawing.Drawing2D.GraphicsPath grTRransferBandiButonu = new System.Drawing.Drawing2D.GraphicsPath();
            grTRransferBandiButonu.AddEllipse(0, 0, 64, 64);
            is_TransferBandButon.Region = new System.Drawing.Region(grTRransferBandiButonu);
        }
    }
}
