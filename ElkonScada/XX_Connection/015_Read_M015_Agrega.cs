using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _015_Read_M015_Agrega
    {
       
        
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();

        
        public void ReadM15Agrega(int[] ReadWordFromPLCPart1,int[] ReadWordFromPLCPart5)
        {
            Properties.M015_Agrega.Default.XB19_Agrega1Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[38], ReadWordFromPLCPart5[39]);      //%MDW0.269
            Properties.M015_Agrega.Default.XB19_Agrega2Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[40], ReadWordFromPLCPart5[41]);     //%MDW0.270
            Properties.M015_Agrega.Default.XB19_Agrega3Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[42], ReadWordFromPLCPart5[43]);      //%MDW0.271
            Properties.M015_Agrega.Default.XB19_Agrega4Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[44], ReadWordFromPLCPart5[45]);     //%MDW0.272
            Properties.M015_Agrega.Default.XB19_Agrega5Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[46], ReadWordFromPLCPart5[47]);     //%MDW0.273
            Properties.M015_Agrega.Default.XB19_Agrega6Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[48], ReadWordFromPLCPart5[49]);     //%MDW0.274
            Properties.M015_Agrega.Default.XB19_Agrega7Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[50], ReadWordFromPLCPart5[51]);      //%MDW0.275
            Properties.M015_Agrega.Default.XB19_Agrega8Nem = ToFloat.IntToFloat(ReadWordFromPLCPart5[52], ReadWordFromPLCPart5[53]);     //%MDW0.276

            Properties.M015_Agrega.Default.XB2_AgregaKantar = ReadWordFromPLCPart1[60]; // %MW0.160
            Properties.M015_Agrega.Default.XB19_AraKantarAgrega = ReadWordFromPLCPart1[61]; // %MW0.161
            Properties.M015_Agrega.Default.XB2_Ag1Su = ReadWordFromPLCPart1[62]; // %MW0.162
            Properties.M015_Agrega.Default.XB2_Ag2Su = ReadWordFromPLCPart1[63]; // %MW0.163
            Properties.M015_Agrega.Default.XB2_Ag3Su = ReadWordFromPLCPart1[64]; // %MW0.164
            Properties.M015_Agrega.Default.XB2_Ag4Su = ReadWordFromPLCPart1[65]; // %MW0.165
            Properties.M015_Agrega.Default.XB2_Ag5Su = ReadWordFromPLCPart1[66]; // %MW0.166
            Properties.M015_Agrega.Default.XB2_Ag6Su = ReadWordFromPLCPart1[67]; // %MW0.167
            Properties.M015_Agrega.Default.XB2_Ag7Su = ReadWordFromPLCPart1[68]; // %MW0.168
            Properties.M015_Agrega.Default.XB2_Ag8Su = ReadWordFromPLCPart1[69]; // %MW0.169


            Properties.M015_Agrega.Default.XB2_Ag1MalAlim = ReadWordFromPLCPart1[78]; // %MW0.178
            Properties.M015_Agrega.Default.XB2_Ag2MalAlim = ReadWordFromPLCPart1[79]; // %MW0.179
            Properties.M015_Agrega.Default.XB2_Ag3MalAlim = ReadWordFromPLCPart1[80]; // %MW0.180
            Properties.M015_Agrega.Default.XB2_Ag4MalAlim = ReadWordFromPLCPart1[81]; // %MW0.181
            Properties.M015_Agrega.Default.XB2_Ag5MalAlim = ReadWordFromPLCPart1[82]; // %MW0.182
            Properties.M015_Agrega.Default.XB2_Ag6MalAlim = ReadWordFromPLCPart1[83]; // %MW0.183
            Properties.M015_Agrega.Default.XB2_Ag7MalAlim = ReadWordFromPLCPart1[84]; // %MW0.184
            Properties.M015_Agrega.Default.XB2_Ag8MalAlim = ReadWordFromPLCPart1[85]; // %MW0.185
        }
    }
}
