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
    public partial class Transferkonveyorbiriktirmesiz_Temp : UserControl
    {
        public Transferkonveyorbiriktirmesiz_Temp()
        {
            InitializeComponent();
        }

        private void is_ButonKatki3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {

                case "1":
                    {
                        qs_TransferBandLamba.Image = ElkonScada.Properties.Resources.Lamp_Green;
                        break;
                    }
                
                default:
                    qs_TransferBandLamba.Image = ElkonScada.Properties.Resources.Lamp_Gray;
                    
                    break;

            }
        }
    }
}
