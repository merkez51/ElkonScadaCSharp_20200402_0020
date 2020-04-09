using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _004_Read_M004_Parametreler
    {
        public void ReadM004Parametreler(bool[] ReadBooleanFromPLC, int[] ReadWordFromPLCPart3)
        {
            Properties.M004_Parametreler.Default.XB1_Mikser_PnomatikKapak = ReadBooleanFromPLC[208];//%MX0.26.0
            Properties.M004_Parametreler.Default.XB1_Mikser_HidrolikKapak = ReadBooleanFromPLC[209];//%MX0.26.1
            Properties.M004_Parametreler.Default.v_SuTipiSayacVar = ReadBooleanFromPLC[210];//%MX0.26.2
            Properties.M004_Parametreler.Default.v_SuTipiKantarVar = ReadBooleanFromPLC[211];//%MX0.26.3
            Properties.M004_Parametreler.Default.v_KatkiTipiSayacVar = ReadBooleanFromPLC[212];//%MX0.26.4
            Properties.M004_Parametreler.Default.v_KatkiTipiKantarVar = ReadBooleanFromPLC[213];//%MX0.26.5
            Properties.M004_Parametreler.Default.Spare_53 = ReadBooleanFromPLC[214];//%MX0.26.6
            Properties.M004_Parametreler.Default.Spare_54 = ReadBooleanFromPLC[215];//%MX0.26.7
            Properties.M004_Parametreler.Default.Spare_55 = ReadBooleanFromPLC[216];//%MX0.27.0
            Properties.M004_Parametreler.Default.Spare_56 = ReadBooleanFromPLC[217];//%MX0.27.1
            Properties.M004_Parametreler.Default.Spare_57 = ReadBooleanFromPLC[218];//%MX0.27.2
            Properties.M004_Parametreler.Default.Spare_58 = ReadBooleanFromPLC[219];//%MX0.27.3
            Properties.M004_Parametreler.Default.Spare_59 = ReadBooleanFromPLC[220];//%MX0.27.4
            Properties.M004_Parametreler.Default.Spare_60 = ReadBooleanFromPLC[221];//%MX0.27.5
            Properties.M004_Parametreler.Default.Spare_61 = ReadBooleanFromPLC[222];//%MX0.27.6
            Properties.M004_Parametreler.Default.Spare_62 = ReadBooleanFromPLC[223];//%MX0.27.7

            Properties.M004_Parametreler.Default.XB19_YaglamaRunEsigi = ReadWordFromPLCPart3[63]; //MW0.325

        }
    }
   
    
}
