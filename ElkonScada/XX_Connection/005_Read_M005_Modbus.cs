using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _005_Read_M005_Modbus
    {
      
        XX_Connection.ToByte Tobyte_ =  ToByte.ConvertToByte_();
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();

     
        public void ReadM005Modbus(bool[] ReadBooleanFromPLC,int[] ReadWordFromPLCPart4,int[] ReadWordFromPLCPart5,int[] ReadWordFromPLCPart20)
        {

            Properties.M005_Modbus.Default.XB1_MikserSlump = ToFloat.IntToFloat(ReadWordFromPLCPart4[96], ReadWordFromPLCPart4[97]);    //%MD0.248
            Properties.M005_Modbus.Default.XB1_VoltajOrtalama = ToFloat.IntToFloat(ReadWordFromPLCPart4[98], ReadWordFromPLCPart4[99]);    //%MD0.249
            Properties.M005_Modbus.Default.XB1_VoltajAra = ToFloat.IntToFloat(ReadWordFromPLCPart5[0], ReadWordFromPLCPart5[1]);    //%MD0.250
            Properties.M005_Modbus.Default.XB1_HelezonAkimAra = ToFloat.IntToFloat(ReadWordFromPLCPart5[2], ReadWordFromPLCPart5[3]);    //%MD0.251
            Properties.M005_Modbus.Default.XB1_Frekans = ToFloat.IntToFloat(ReadWordFromPLCPart5[4], ReadWordFromPLCPart5[5]);    //%MD0.252
            Properties.M005_Modbus.Default.XB1_ToplamAkim = ToFloat.IntToFloat(ReadWordFromPLCPart5[6], ReadWordFromPLCPart5[7]);    //%MD0.253
            Properties.M005_Modbus.Default.XB1_Voltaj1 = ToFloat.IntToFloat(ReadWordFromPLCPart5[8], ReadWordFromPLCPart5[9]);    //%MD0.254
            Properties.M005_Modbus.Default.XB1_Voltaj2 = ToFloat.IntToFloat(ReadWordFromPLCPart5[10], ReadWordFromPLCPart5[11]);    //%MD0.255
            Properties.M005_Modbus.Default.XB1_Voltaj3 = ToFloat.IntToFloat(ReadWordFromPLCPart5[12], ReadWordFromPLCPart5[13]);    //%MD0.256
            Properties.M005_Modbus.Default.XB159_Kalibrasyon_Agirligi = ToFloat.IntToFloat(ReadWordFromPLCPart5[14], ReadWordFromPLCPart5[15]);    //%MD0.257



            Properties.M005_Modbus.Default.XB159_KalibreSon = ReadBooleanFromPLC[224];//%MX0.28.0
            Properties.M005_Modbus.Default.XB159_KantarSifirla = ReadBooleanFromPLC[225];//%MX0.28.1
            Properties.M005_Modbus.Default.XB159_KantarAgirliginiYaz = ReadBooleanFromPLC[226];//%MX0.28.2
            Properties.M005_Modbus.Default.XB159_AgSec = ReadBooleanFromPLC[227];//%MX0.28.3
            Properties.M005_Modbus.Default.XB159_CimSec = ReadBooleanFromPLC[228];//%MX0.28.4
            Properties.M005_Modbus.Default.XB159_SuSec = ReadBooleanFromPLC[229];//%MX0.28.5
            Properties.M005_Modbus.Default.XB159_KatkiSec = ReadBooleanFromPLC[230];//%MX0.28.6
            Properties.M005_Modbus.Default.XB159_SlumpHesapla = ReadBooleanFromPLC[231];//%MX0.28.7
            Properties.M005_Modbus.Default.XB159_TusKilitle = ReadBooleanFromPLC[232];//%MX0.29.0
            Properties.M005_Modbus.Default.KalibrasyonYapilacak = ReadBooleanFromPLC[233];//%MX0.29.1
            Properties.M005_Modbus.Default.TusKilitlemeYapilacak = ReadBooleanFromPLC[234];//%MX0.29.2
            Properties.M005_Modbus.Default.v_SetpointSendRunning = ReadBooleanFromPLC[235];//%MX0.29.3
            Properties.M005_Modbus.Default.Spare_63 = ReadBooleanFromPLC[236];//%MX0.29.4
            Properties.M005_Modbus.Default.Spare_64 = ReadBooleanFromPLC[237];//%MX0.29.5
            Properties.M005_Modbus.Default.Spare_65 = ReadBooleanFromPLC[238];//%MX0.29.6
            Properties.M005_Modbus.Default.Spare_66 = ReadBooleanFromPLC[239];//%MX0.29.7
            Properties.M005_Modbus.Default.Spare_67 = ReadBooleanFromPLC[240];//%MX0.30.0
            Properties.M005_Modbus.Default.Spare_68 = ReadBooleanFromPLC[241];//%MX0.30.1
            Properties.M005_Modbus.Default.Spare_69 = ReadBooleanFromPLC[242];//%MX0.30.2
            Properties.M005_Modbus.Default.Spare_70 = ReadBooleanFromPLC[243];//%MX0.30.3
            Properties.M005_Modbus.Default.Spare_71 = ReadBooleanFromPLC[244];//%MX0.30.4
            Properties.M005_Modbus.Default.Spare_72 = ReadBooleanFromPLC[245];//%MX0.30.5
            Properties.M005_Modbus.Default.Spare_73 = ReadBooleanFromPLC[246];//%MX0.30.6
            Properties.M005_Modbus.Default.Spare_74 = ReadBooleanFromPLC[247];//%MX0.30.7
            Properties.M005_Modbus.Default.Spare_75 = ReadBooleanFromPLC[248];//%MX0.31.0
            Properties.M005_Modbus.Default.Spare_76 = ReadBooleanFromPLC[249];//%MX0.31.1
            Properties.M005_Modbus.Default.Spare_77 = ReadBooleanFromPLC[250];//%MX0.31.2
            Properties.M005_Modbus.Default.Spare_78 = ReadBooleanFromPLC[251];//%MX0.31.3
            Properties.M005_Modbus.Default.Spare_79 = ReadBooleanFromPLC[252];//%MX0.31.4
            Properties.M005_Modbus.Default.Spare_80 = ReadBooleanFromPLC[253];//%MX0.31.5
            Properties.M005_Modbus.Default.Spare_81 = ReadBooleanFromPLC[254];//%MX0.31.6
            Properties.M005_Modbus.Default.Spare_82 = ReadBooleanFromPLC[255];//%MX0.31.7


            Properties.M005_Modbus.Default.XB158_KantarAdresi = Tobyte_.Het_ByteConverter(ReadWordFromPLCPart20[27],3);//55 idi 27'nin önüne ToByte_1Bits(...) koyulabilir
        }
    }
}
