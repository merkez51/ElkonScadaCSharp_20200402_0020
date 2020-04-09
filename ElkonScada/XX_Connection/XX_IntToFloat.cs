using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class XX_IntToFloat
    {
        private XX_IntToFloat()
        {

        }
        private static XX_IntToFloat ConvertToFloat;
     
        public static XX_IntToFloat ConvertToFloat_()
        {
            if (ConvertToFloat == null)
            {
                ConvertToFloat = new XX_IntToFloat();
            }
            return ConvertToFloat;
        }
        
        public double IntToFloat(int LowReg, int HighReg)
        {
            
            return ToFloat(LowReg, HighReg); 
        }
        static double ToFloat(int LowReg, int HighReg)
        {
            int VirguldenSonraBasamakAdeti = 2;

            byte[] Bytelow = { BitConverter.GetBytes(LowReg)[0], BitConverter.GetBytes(LowReg)[1] };
            byte[] ByteHigh = { BitConverter.GetBytes(HighReg)[0], BitConverter.GetBytes(HighReg)[1] };


            byte[] newArray = new[] { ByteHigh[0], ByteHigh[1], Bytelow[0], Bytelow[1] };
            float resultFloat = BitConverter.ToSingle(newArray, 0);
            double resultDouble = Convert.ToDouble(resultFloat);
            double resultRount = Math.Round(resultDouble, VirguldenSonraBasamakAdeti);
            return resultRount;
        }
    }
}
