using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _000_ReceteGonder
    {
        private _000_ReceteGonder()
        {

        }
        private static _000_ReceteGonder PLC_Recete_Gonder;

        public static _000_ReceteGonder PLC_Recete_Gonderiyor()
        {
            if (PLC_Recete_Gonder == null)
            {
                PLC_Recete_Gonder = new _000_ReceteGonder();
            }
            return PLC_Recete_Gonder;
        }

        public int[] ReceteElemanlari = new int[23];
        public XX_Connection.ModbusConnection HetModbusTool = XX_Connection.ModbusConnection.HetConnection();
        XX_Connection.HetWordTODouble Het_DoubleToINT = new XX_Connection.HetWordTODouble();

        public int AgregaReceteValue1;
        public int AgregaReceteValue2;
        public int AgregaReceteValue3;
        public int AgregaReceteValue4;
        public int AgregaReceteValue5;
        public int AgregaReceteValue6;

        public int CimentoReceteValue1;
        public int CimentoReceteValue2;
        public int CimentoReceteValue3;
        public int CimentoReceteValue4;
        public int CimentoReceteValue5;
        public int CimentoReceteValue6;

        public int SuReceteValue1;
        public int SuReceteValue2;
        public int SuReceteValue3;

        public double KatkiReceteValue1;
        public double KatkiReceteValue2;
        public double KatkiReceteValue3;
        public double KatkiReceteValue4;
        public double KatkiReceteValue5;


        public void PLCyeReceteGonderConnection()
        {

            ReceteElemanlari[0] =( AgregaReceteValue1); //MW0.4000
            ReceteElemanlari[1] = (AgregaReceteValue2); //MW0.4001
            ReceteElemanlari[2] = (AgregaReceteValue3); //MW0.4002
            ReceteElemanlari[3] = (AgregaReceteValue4); //MW0.4003
            ReceteElemanlari[4] = (AgregaReceteValue5); //MW0.4004

            ReceteElemanlari[5] = (CimentoReceteValue1); //MW0.4005
            ReceteElemanlari[6] = (CimentoReceteValue2); //MW0.4006
            ReceteElemanlari[7] = (CimentoReceteValue3); //MW0.4007
            ReceteElemanlari[8] = (CimentoReceteValue4); //MW0.4008
            ReceteElemanlari[9] = (CimentoReceteValue5); //MW0.4009

            ReceteElemanlari[10] = (SuReceteValue1); //MW0.4010
            ReceteElemanlari[11] = (SuReceteValue2); //MW0.4011
            ReceteElemanlari[12] = (SuReceteValue3); //MW0.4012

            ReceteElemanlari[13] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue1,0); //MD0.2007 
            ReceteElemanlari[14] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue1, 1); //MD0.2007

            ReceteElemanlari[15] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue2,0); //MD0.2008
            ReceteElemanlari[16] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue2, 1); //MD0.2008

            ReceteElemanlari[17] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue3,0); //MD0.2009
            ReceteElemanlari[18] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue3,1); //MD0.2009

            ReceteElemanlari[19] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue4,0); //MD0.2010
            ReceteElemanlari[20] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue4,1); //MD0.2010

            ReceteElemanlari[21] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue5,0); //MD0.2011
            ReceteElemanlari[22] = Het_DoubleToINT.Het_ByteConverter(KatkiReceteValue5,1); //MD0.2011


            HetModbusTool.HetmodbusTool_WritePLC(4000, ReceteElemanlari);

        }
    }
}
