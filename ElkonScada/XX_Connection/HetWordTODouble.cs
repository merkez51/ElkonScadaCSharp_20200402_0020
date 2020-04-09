using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class HetWordTODouble
    {

     
        int A, B = 0;
        public int Het_ByteConverter(double DoubleAdres,int digitnumber)
        {

            //// Byte0,byte1,byte2,byte3--byte4,byte5,byte6,byte7
            //byte[] bytes = new byte[4];
            //int[] DoubleAdress_to_INT =Convert.ToInt32( DoubleAdres);
            //bytes[0] = (byte)(DoubleAdres.[0] >> 24);
            //bytes[1] = (byte)(intValue >> 16);
            //bytes[2] = (byte)(intValue >> 8);
            //bytes[3] = (byte)intValue;
            int[] ReturnInteger = new int[2];
            ReturnInteger[1] = A;
            ReturnInteger[0] =B;


            return ReturnInteger[digitnumber];
        }
      
    }
}
