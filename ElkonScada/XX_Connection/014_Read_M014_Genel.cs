using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _014_Read_M014_Genel
    {
        XX_Connection.ToByte ToByte = ToByte.ConvertToByte_();


    
        //3----> Byte1
        //2----> Byte0
        public void ReadM14Genel(int[] ReadWordFromPLCPart0,int[] ReadWordFromPLCPart3)
        {
            Properties.M014_Genel.Default.PLC_Hour = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[56], 2);//%MB0.112
            Properties.M014_Genel.Default.PLC_Min = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[56], 3);//%MB0.113

            Properties.M014_Genel.Default.PLC_Sec = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[57], 2);//%MB0.114
            Properties.M014_Genel.Default.PLC_Month = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[57], 3);//%MB0.115

            Properties.M014_Genel.Default.PLC_Day = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[58], 2);//%MB0.116
            Properties.M014_Genel.Default.PLC_Wday = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[58], 3);//%MB0.117

            Properties.M014_Genel.Default.PLC_Old_Day = ToByte.Het_ByteConverter(ReadWordFromPLCPart0[59], 2);//%MB0.118

            Properties.M014_Genel.Default.PLC_Year = ReadWordFromPLCPart3[70];

        }
    }
}
