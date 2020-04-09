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
    public partial class QuickTartimKovasi : UserControl
    {
        public QuickTartimKovasi()
        {
            InitializeComponent();
        }

        private void QuickTartimKovasi_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath grQuickTartiBandiVibrator = new System.Drawing.Drawing2D.GraphicsPath();
            grQuickTartiBandiVibrator.AddEllipse(2, 2, 69, 64);
            is_ButonTartiBand1Vibrator.Region = new System.Drawing.Region(grQuickTartiBandiVibrator);
        }
    }
}
