using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3----> Byte1
//2----> Byte0
namespace ElkonScada.XX_Connection
{
    class ToByte
    {
        private ToByte()
        {

        }
        private static ToByte ConvertToByte;

        public static ToByte ConvertToByte_()
        {
            if (ConvertToByte == null)
            {
                ConvertToByte = new ToByte();
            }
            return ConvertToByte;
        }
        public  byte Het_ByteConverter(int VerilenAdress,int WhichDigit)
        {
            return  ToByte_0Bits(VerilenAdress, WhichDigit);
        }
        static byte ToByte_0Bits(int Write_A_Word,int WhichDigit)
        {

            int intValue = Write_A_Word;

            byte[] bytes = new byte[4];

            bytes[0] = (byte)(intValue >> 24);
            bytes[1] = (byte)(intValue >> 16);
            bytes[2] = (byte)(intValue >> 8);
            bytes[3] = (byte)intValue;
            return bytes[WhichDigit];
        }

    }
}
