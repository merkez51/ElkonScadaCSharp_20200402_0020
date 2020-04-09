using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _013_Read_M013_KantarAnimasyon
    {

        XX_Connection.ToByte ToByte = ToByte.ConvertToByte_();

        public void ReadM013KantarAnimasyon(int[] ReadWordFromPLCPart0, int[] ReadWordFromPLCPart3)
        {
            //3----> Byte1
            //2----> Byte0
            Properties.M013_KantarAnimasyon.Default.s_Katki1PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[46], 2);//%MB0.92 
            Properties.M013_KantarAnimasyon.Default.s_Katki2PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[46], 3);//%MB0.93
            Properties.M013_KantarAnimasyon.Default.s_Katki3PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[47], 2);//%MB0.94
            Properties.M013_KantarAnimasyon.Default.s_Katki4PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[47], 3);//%MB0.95
            Properties.M013_KantarAnimasyon.Default.s_Katki5PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[48], 2);//%MB0.96
            Properties.M013_KantarAnimasyon.Default.s_Katki6PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[48], 3);////%MB0.97

            Properties.M013_KantarAnimasyon.Default.s_KatkiKantari1_2Seviye = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[49], 2);//%MB0.98
            Properties.M013_KantarAnimasyon.Default.s_SuKantarSeviye = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[49], 3);//%MB0.99
            Properties.M013_KantarAnimasyon.Default.s_CimentoKantarSeviye = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[50], 2);//%MB0.100
            Properties.M013_KantarAnimasyon.Default.s_Su1PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[50], 3);//%MB0.101
            Properties.M013_KantarAnimasyon.Default.s_Su2PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[51], 2);//%MB0.102
            Properties.M013_KantarAnimasyon.Default.s_Su3PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[51], 3);//%MB0.103
            Properties.M013_KantarAnimasyon.Default.s_Su4PompaRenk = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[52], 2);//%MB0.102
            Properties.M005_Modbus.Default.XB159_KalibrasyonAgirligi = ReadWordFromPLCPart3[77]; //MW0.325

        }
    }
}
