using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _008_Read_M008_CI522
    {
        
        public void ReadM008CI522(bool[] ReadBooleanFromPLC)
        {
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega1 = ReadBooleanFromPLC[352];//%MX0.44.0
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega2 = ReadBooleanFromPLC[353];//%MX0.44.1
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega3 = ReadBooleanFromPLC[354];//%MX0.44.2
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega4 = ReadBooleanFromPLC[355];//%MX0.44.3
            Properties.M008_CI522.Default.i_Yrd_MikserKapakAc = ReadBooleanFromPLC[356];//%MX0.44.4
            Properties.M008_CI522.Default.i_Yrd_KatkiKapakAc = ReadBooleanFromPLC[357];//%MX0.44.5
            Properties.M008_CI522.Default.i_Yrd_SuKapakAc = ReadBooleanFromPLC[358];//%MX0.44.6
            Properties.M008_CI522.Default.i_Yrd_CimentoKapakAc = ReadBooleanFromPLC[359];//%MX0.44.7
            Properties.M008_CI522.Default.i_Yrd_TartiBandiStart = ReadBooleanFromPLC[360];//%MX0.45.0
            Properties.M008_CI522.Default.i_Yrd_TartiBandiStop = ReadBooleanFromPLC[361];//%MX0.45.1
            Properties.M008_CI522.Default.i_Yrd_DCI1 = ReadBooleanFromPLC[362];//%MX0.45.2
            Properties.M008_CI522.Default.i_Yrd_DCI2 = ReadBooleanFromPLC[363];//%MX0.45.3
            Properties.M008_CI522.Default.i_Yrd_MikserStart = ReadBooleanFromPLC[364];//%MX0.45.4
            Properties.M008_CI522.Default.i_Yrd_MikserStop = ReadBooleanFromPLC[365];//%MX0.45.5
            Properties.M008_CI522.Default.i_Yrd_KompresorStart = ReadBooleanFromPLC[366];//%MX0.45.6
            Properties.M008_CI522.Default.i_Yrd_KompresorStop = ReadBooleanFromPLC[367];//%MX0.45.7
            Properties.M008_CI522.Default.i_Yrd_AlgeraAlStart = ReadBooleanFromPLC[368];//%MX0.46.0
            Properties.M008_CI522.Default.i_Yrd_AgregaAlStop = ReadBooleanFromPLC[369];//%MX0.46.1
            Properties.M008_CI522.Default.i_Yrd_Helezon1Start = ReadBooleanFromPLC[370];//%MX0.46.2
            Properties.M008_CI522.Default.i_Yrd_Helezon1Stop = ReadBooleanFromPLC[371];//%MX0.46.3
            Properties.M008_CI522.Default.i_Yrd_Helezon2Start = ReadBooleanFromPLC[372];//%MX0.46.4
            Properties.M008_CI522.Default.i_Yrd_Helezon2Stop = ReadBooleanFromPLC[373];//%MX0.46.5
            Properties.M008_CI522.Default.i_Yrd_SuStart = ReadBooleanFromPLC[374];//%MX0.46.6
            Properties.M008_CI522.Default.i_Yrd_SuStop = ReadBooleanFromPLC[375];//%MX0.46.7
            Properties.M008_CI522.Default.i_Yrd_Katki1Start = ReadBooleanFromPLC[376];//%MX0.47.0
            Properties.M008_CI522.Default.i_Yrd_Katki1Stop = ReadBooleanFromPLC[377];//%MX0.47.1
            Properties.M008_CI522.Default.i_Yrd_Katki2Start = ReadBooleanFromPLC[378];//%MX0.47.2
            Properties.M008_CI522.Default.i_Yrd_Katki2Stop = ReadBooleanFromPLC[379];//%MX0.47.3
            Properties.M008_CI522.Default.i_Yrd_DischargeStart = ReadBooleanFromPLC[380];//%MX0.47.4
            Properties.M008_CI522.Default.i_Yrd_DischargeStop = ReadBooleanFromPLC[381];//%MX0.47.5
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega1_2 = ReadBooleanFromPLC[382];//%MX0.47.6
            Properties.M008_CI522.Default.i_Yrd_SecimAgrega3_4 = ReadBooleanFromPLC[383];//%MX0.47.7
            Properties.M008_CI522.Default.MikserSu_KapakSec = ReadBooleanFromPLC[384];//%MX0.48.0
            Properties.M008_CI522.Default.KatkiCimento_KapakSec = ReadBooleanFromPLC[385];//%MX0.48.1
            Properties.M008_CI522.Default.TartiBandiStartStop = ReadBooleanFromPLC[386];//%MX0.48.2
            Properties.M008_CI522.Default.KovaTransferBandiYukariAsagi = ReadBooleanFromPLC[387];//%MX0.48.3
            Properties.M008_CI522.Default.MikserStartStop = ReadBooleanFromPLC[388];//%MX0.48.4
            Properties.M008_CI522.Default.KompresorStartStop = ReadBooleanFromPLC[389];//%MX0.48.5
            Properties.M008_CI522.Default.i_Yrd_AlgeraAlStartStop = ReadBooleanFromPLC[390];//%MX0.48.6
            Properties.M008_CI522.Default.i_Yrd_Helezon1StartStop = ReadBooleanFromPLC[391];//%MX0.48.7
            Properties.M008_CI522.Default.i_Yrd_Helezon2StartStop = ReadBooleanFromPLC[392];//%MX0.49.0
            Properties.M008_CI522.Default.i_Yrd_SuStartStop = ReadBooleanFromPLC[393];//%MX0.49.1
            Properties.M008_CI522.Default.i_Yrd_Katki1StartStop = ReadBooleanFromPLC[394];//%MX0.49.2
            Properties.M008_CI522.Default.i_Yrd_Katki2StartStop = ReadBooleanFromPLC[395];//%MX0.49.3
            Properties.M008_CI522.Default.i_Yrd_DischargeStartStop = ReadBooleanFromPLC[396];//%MX0.49.4
            Properties.M008_CI522.Default.q_Trig1 = ReadBooleanFromPLC[397];//%MX0.49.5
            Properties.M008_CI522.Default.q_Trig2 = ReadBooleanFromPLC[398];//%MX0.49.6
            Properties.M008_CI522.Default.q_Trig3 = ReadBooleanFromPLC[399];//%MX0.49.7
            Properties.M008_CI522.Default.Spare_133 = ReadBooleanFromPLC[400];//%MX0.50.0
            Properties.M008_CI522.Default.Spare_134 = ReadBooleanFromPLC[401];//%MX0.50.1
            Properties.M008_CI522.Default.Spare_135 = ReadBooleanFromPLC[402];//%MX0.50.2
            Properties.M008_CI522.Default.Spare_136 = ReadBooleanFromPLC[403];//%MX0.50.3
            Properties.M008_CI522.Default.Spare_137 = ReadBooleanFromPLC[404];//%MX0.50.4
            Properties.M008_CI522.Default.Spare_138 = ReadBooleanFromPLC[405];//%MX0.50.5
            Properties.M008_CI522.Default.Spare_139 = ReadBooleanFromPLC[406];//%MX0.50.6
            Properties.M008_CI522.Default.Spare_140 = ReadBooleanFromPLC[407];//%MX0.50.7
            Properties.M008_CI522.Default.Spare_141 = ReadBooleanFromPLC[408];//%MX0.51.0
            Properties.M008_CI522.Default.Spare_142 = ReadBooleanFromPLC[409];//%MX0.51.1
            Properties.M008_CI522.Default.Spare_143 = ReadBooleanFromPLC[410];//%MX0.51.2
            Properties.M008_CI522.Default.Spare_144 = ReadBooleanFromPLC[411];//%MX0.51.3
            Properties.M008_CI522.Default.Spare_145 = ReadBooleanFromPLC[412];//%MX0.51.4
            Properties.M008_CI522.Default.Spare_146 = ReadBooleanFromPLC[413];//%MX0.51.5
            Properties.M008_CI522.Default.Spare_147 = ReadBooleanFromPLC[414];//%MX0.51.6
            Properties.M008_CI522.Default.Spare_148 = ReadBooleanFromPLC[415];//%MX0.51.7
        }
    }
}
