using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _002_Read_M002_YariOto
    {
     
        public void Read_M002YariOto(bool[] ReadBooleanFromPLC)
        {

            Properties.M002_YariOto.Default.v_YariOtoAgregaAlim = ReadBooleanFromPLC[48];//%MX0.6.0
            Properties.M002_YariOto.Default.v_YariOtoCimentoAlim = ReadBooleanFromPLC[49];//%MX0.6.1
            Properties.M002_YariOto.Default.v_YariOtoKatkiAlim = ReadBooleanFromPLC[50];//%MX0.6.2
            Properties.M002_YariOto.Default.v_YariOtoSuAlim = ReadBooleanFromPLC[51];//%MX0.6.3
            Properties.M002_YariOto.Default.v_YariOtoAgregaAlimStop = ReadBooleanFromPLC[52];//%MX0.6.4
            Properties.M002_YariOto.Default.v_YariOtoCimentoAlimStop = ReadBooleanFromPLC[53];//%MX0.6.5
            Properties.M002_YariOto.Default.v_YariOtoSuAlimStop = ReadBooleanFromPLC[54];//%MX0.6.6
            Properties.M002_YariOto.Default.v_YariOtoKatkiAlimStop = ReadBooleanFromPLC[55];//%MX0.6.7
            Properties.M002_YariOto.Default.Spare_6 = ReadBooleanFromPLC[56];//%MX0.7.0
            Properties.M002_YariOto.Default.Spare_7 = ReadBooleanFromPLC[57];//%MX0.7.1
            Properties.M002_YariOto.Default.Spare_8 = ReadBooleanFromPLC[58];//%MX0.7.2
            Properties.M002_YariOto.Default.Spare_9 = ReadBooleanFromPLC[59];//%MX0.7.3
            Properties.M002_YariOto.Default.Spare_10 = ReadBooleanFromPLC[60];//%MX0.7.4
            Properties.M002_YariOto.Default.Spare_11 = ReadBooleanFromPLC[61];//%MX0.7.5
            Properties.M002_YariOto.Default.Spare_12 = ReadBooleanFromPLC[62];//%MX0.7.6
            Properties.M002_YariOto.Default.Spare_13 = ReadBooleanFromPLC[63];//%MX0.7.7
        }
    }
}
