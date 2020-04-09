using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _018_Read_M018_Katki
    {
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();

      
        public void ReadM018Katki(int[] ReadWordFromPLCPart4)
        {
            Properties.M018_Katki.Default.XB5_KatKantar = ToFloat.IntToFloat(ReadWordFromPLCPart4[00], ReadWordFromPLCPart4[01]); //%MDW0.200
            Properties.M018_Katki.Default.KatkiLoadCelldenGelen = ToFloat.IntToFloat(ReadWordFromPLCPart4[02], ReadWordFromPLCPart4[03]); //%MDW0.201
            Properties.M018_Katki.Default.XB5_K1ManAlim = ToFloat.IntToFloat(ReadWordFromPLCPart4[04], ReadWordFromPLCPart4[05]); //%MDW0.202
            Properties.M018_Katki.Default.XB5_K2ManAlim = ToFloat.IntToFloat(ReadWordFromPLCPart4[06], ReadWordFromPLCPart4[07]); //%MDW0.203
            Properties.M018_Katki.Default.XB5_K3ManAlim = ToFloat.IntToFloat(ReadWordFromPLCPart4[08], ReadWordFromPLCPart4[09]); //%MDW0.204
            Properties.M018_Katki.Default.XB5_K4ManAlim = ToFloat.IntToFloat(ReadWordFromPLCPart4[10], ReadWordFromPLCPart4[11]); //%MDW0.205
            Properties.M018_Katki.Default.XB5_K5ManAlim = ToFloat.IntToFloat(ReadWordFromPLCPart4[12], ReadWordFromPLCPart4[13]); //%MDW0.206


            Properties.M018_Katki.Default.XB5_AraKantarKatki = ToFloat.IntToFloat(ReadWordFromPLCPart4[16], ReadWordFromPLCPart4[17]); //%MDW0.208


        }
    }
}
