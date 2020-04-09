using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _001_Read_M001_Secimler
    {
      
        public void Read_M001Secimler(bool [] ReadBooleanFromPLC)
        {

            Properties.M001_Secimler.Default.XB2_Agrega1Calistir = ReadBooleanFromPLC[0];//%MX0.0.0
            Properties.M001_Secimler.Default.XB2_Agrega2Calistir = ReadBooleanFromPLC[1];//%MX0.0.1
            Properties.M001_Secimler.Default.XB2_Agrega3Calistir = ReadBooleanFromPLC[2];//%MX0.0.2
            Properties.M001_Secimler.Default.XB2_Agrega4Calistir = ReadBooleanFromPLC[3];//%MX0.0.3
            Properties.M001_Secimler.Default.XB2_Agrega5Calistir = ReadBooleanFromPLC[4];//%MX0.0.4
            Properties.M001_Secimler.Default.XB2_Agrega6Calistir = ReadBooleanFromPLC[5];//%MX0.0.5
            Properties.M001_Secimler.Default.XB2_Agrega7Calistir = ReadBooleanFromPLC[6];//%MX0.0.6
            Properties.M001_Secimler.Default.XB2_Agrega8Calistir = ReadBooleanFromPLC[7];//%MX0.0.7
            Properties.M001_Secimler.Default.XB2_DurAgrega1 = ReadBooleanFromPLC[8];//%MX0.1.0
            Properties.M001_Secimler.Default.XB2_DurAgrega2 = ReadBooleanFromPLC[9];//%MX0.1.1
            Properties.M001_Secimler.Default.XB2_DurAgrega3 = ReadBooleanFromPLC[10];//%MX0.1.2
            Properties.M001_Secimler.Default.XB2_DurAgrega4 = ReadBooleanFromPLC[11];//%MX0.1.3
            Properties.M001_Secimler.Default.XB2_DurAgrega5 = ReadBooleanFromPLC[12];//%MX0.1.4
            Properties.M001_Secimler.Default.XB2_DurAgrega6 = ReadBooleanFromPLC[13];//%MX0.1.5
            Properties.M001_Secimler.Default.XB2_DurAgrega7 = ReadBooleanFromPLC[14];//%MX0.1.6
            Properties.M001_Secimler.Default.XB2_DurAgrega8 = ReadBooleanFromPLC[15];//%MX0.1.7
            Properties.M001_Secimler.Default.AgregaDegistirmeIslemiTamamlaniyor = ReadBooleanFromPLC[16];//%MX0.2.0
            Properties.M001_Secimler.Default.XB3_S1Calistir = ReadBooleanFromPLC[17];//%MX0.2.1
            Properties.M001_Secimler.Default.XB3_S2Calistir = ReadBooleanFromPLC[18];//%MX0.2.2
            Properties.M001_Secimler.Default.XB3_S3Calistir = ReadBooleanFromPLC[19];//%MX0.2.3
            Properties.M001_Secimler.Default.XB3_S4Calistir = ReadBooleanFromPLC[20];//%MX0.2.4
            Properties.M001_Secimler.Default.XB3_S5Calistir = ReadBooleanFromPLC[21];//%MX0.2.5
            Properties.M001_Secimler.Default.XB3_S6Calistir = ReadBooleanFromPLC[22];//%MX0.2.6
            Properties.M001_Secimler.Default.XB3_DurSilo1 = ReadBooleanFromPLC[23];//%MX0.2.7
            Properties.M001_Secimler.Default.XB3_DurSilo2 = ReadBooleanFromPLC[24];//%MX0.3.0
            Properties.M001_Secimler.Default.XB3_DurSilo3 = ReadBooleanFromPLC[25];//%MX0.3.1
            Properties.M001_Secimler.Default.XB3_DurSilo4 = ReadBooleanFromPLC[26];//%MX0.3.2
            Properties.M001_Secimler.Default.XB3_DurSilo5 = ReadBooleanFromPLC[27];//%MX0.3.3
            Properties.M001_Secimler.Default.XB3_DurSilo6 = ReadBooleanFromPLC[28];//%MX0.3.4
            Properties.M001_Secimler.Default.SiloDegistirmeIslemiTamamlaniyor = ReadBooleanFromPLC[29];//%MX0.3.5
            Properties.M001_Secimler.Default.XB5_Katki1Calistir = ReadBooleanFromPLC[30];//%MX0.3.6
            Properties.M001_Secimler.Default.XB5_Katki2Calistir = ReadBooleanFromPLC[31];//%MX0.3.7
            Properties.M001_Secimler.Default.XB5_Katki3Calistir = ReadBooleanFromPLC[32];//%MX0.4.0
            Properties.M001_Secimler.Default.XB5_Katki4Calistir = ReadBooleanFromPLC[33];//%MX0.4.1
            Properties.M001_Secimler.Default.XB5_Katki5Calistir = ReadBooleanFromPLC[34];//%MX0.4.2
            Properties.M001_Secimler.Default.XB5_Katki6Calistir = ReadBooleanFromPLC[35];//%MX0.4.3
            Properties.M001_Secimler.Default.XB5_DurKatki1 = ReadBooleanFromPLC[36];//%MX0.4.4
            Properties.M001_Secimler.Default.XB5_DurKatki2 = ReadBooleanFromPLC[37];//%MX0.4.5
            Properties.M001_Secimler.Default.XB5_DurKatki3 = ReadBooleanFromPLC[38];//%MX0.4.6
            Properties.M001_Secimler.Default.XB5_DurKatki4 = ReadBooleanFromPLC[39];//%MX0.4.7
            Properties.M001_Secimler.Default.XB5_DurKatki5 = ReadBooleanFromPLC[40];//%MX0.5.0
            Properties.M001_Secimler.Default.XB5_DurKatki6 = ReadBooleanFromPLC[41];//%MX0.5.1
            Properties.M001_Secimler.Default.KatkiDegistirmeIslemiTamamlaniyor = ReadBooleanFromPLC[42];//%MX0.5.2
            Properties.M001_Secimler.Default.Spare_1 = ReadBooleanFromPLC[43];//%MX0.5.3
            Properties.M001_Secimler.Default.Spare_2 = ReadBooleanFromPLC[44];//%MX0.5.4
            Properties.M001_Secimler.Default.Spare_3 = ReadBooleanFromPLC[45];//%MX0.5.5
            Properties.M001_Secimler.Default.Spare_4 = ReadBooleanFromPLC[46];//%MX0.5.6
            Properties.M001_Secimler.Default.Spare_5 = ReadBooleanFromPLC[47];//%MX0.5.7
        }
    }
}
