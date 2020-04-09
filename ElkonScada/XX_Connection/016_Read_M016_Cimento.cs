using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _016_Read_M016_Cimento
    {
     
        public void ReadM016Cimento(int[] ReadWordFromPLCPart2)
        {
            Properties.M016_Cimento.Default.XB3_CMKantar =ReadWordFromPLCPart2[33];//%MW0.233
            Properties.M016_Cimento.Default.XB19_AraKantarCimento =ReadWordFromPLCPart2[33];//%MW0.234
            Properties.M016_Cimento.Default.XB3_CM1ManAlim =ReadWordFromPLCPart2[33];//%MW0.235
            Properties.M016_Cimento.Default.XB3_CM2ManAlim =ReadWordFromPLCPart2[33];//%MW0.236
            Properties.M016_Cimento.Default.XB3_CM3ManAlim =ReadWordFromPLCPart2[33];//%MW0.237
            Properties.M016_Cimento.Default.XB3_CM4ManAlim =ReadWordFromPLCPart2[33];//%MW0.238
            Properties.M016_Cimento.Default.XB3_CM5ManAlim =ReadWordFromPLCPart2[33];//%MW0.239

        }
    }
}
