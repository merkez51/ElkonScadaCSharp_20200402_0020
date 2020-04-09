using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _017_Read_M017_Su
    {
       
        public void ReadM017Su(int[] ReadWordFromPLCPart2)
        {
            Properties.M017_Su.Default.XB4_SuKantar = ReadWordFromPLCPart2[69]; //%MW0.269
            Properties.M017_Su.Default.SuLoadCelldenGelen = ReadWordFromPLCPart2[70]; //%MW0.270
            Properties.M017_Su.Default.XB4_Su1AManAlin = ReadWordFromPLCPart2[71]; //%MW0.271
            Properties.M017_Su.Default.XB4_Su2AManAlin = ReadWordFromPLCPart2[72]; //%MW0.272
            Properties.M017_Su.Default.XB4_Su3AManAlin = ReadWordFromPLCPart2[73]; //%MW0.273

            Properties.M017_Su.Default.XB4_AraKantarSu = ReadWordFromPLCPart2[75]; //%MW0.275


        }
    }
}
