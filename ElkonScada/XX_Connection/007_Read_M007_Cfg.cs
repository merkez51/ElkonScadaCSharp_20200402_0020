using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _007_Read_M007_Cfg
    {
      
        public void ReadM007Cfg(bool[] ReadBooleanFromPLC)
        {
            Properties.M007_Cfg.Default.i_KovaAsagidaS = ReadBooleanFromPLC[288];//%MX0.36.0
            Properties.M007_Cfg.Default.i_KovaYukaridaS = ReadBooleanFromPLC[289];//%MX0.36.1
            Properties.M007_Cfg.Default.i_KovaOrtaLimit = ReadBooleanFromPLC[290];//%MX0.36.2
            Properties.M007_Cfg.Default.i_KovaAsagidaYavaslamaS = ReadBooleanFromPLC[291];//%MX0.36.3
            Properties.M007_Cfg.Default.i_FrenAcik = ReadBooleanFromPLC[292];//%MX0.36.4
            Properties.M007_Cfg.Default.i_GenelEmniyet = ReadBooleanFromPLC[293];//%MX0.36.5
            Properties.M007_Cfg.Default.i_KovaYukariYavasCalisiyor = ReadBooleanFromPLC[294];//%MX0.36.6
            Properties.M007_Cfg.Default.i_KovaAsagiHizli = ReadBooleanFromPLC[295];//%MX0.36.7
            Properties.M007_Cfg.Default.i_KovaAsagiYavas = ReadBooleanFromPLC[296];//%MX0.37.0
            Properties.M007_Cfg.Default.i_KovaTermikAriza = ReadBooleanFromPLC[297];//%MX0.37.1
            Properties.M007_Cfg.Default.q_KovaYukariStart = ReadBooleanFromPLC[298];//%MX0.37.2
            Properties.M007_Cfg.Default.q_KovaAsagiStart = ReadBooleanFromPLC[299];//%MX0.37.3
            Properties.M007_Cfg.Default.q_KovaAsagiYavasStart = ReadBooleanFromPLC[300];//%MX0.37.4
            Properties.M007_Cfg.Default.q_KovaYukari24VFren = ReadBooleanFromPLC[301];//%MX0.37.5
            Properties.M007_Cfg.Default.v_Yrd_SkipYukari = ReadBooleanFromPLC[302];//%MX0.37.6
            Properties.M007_Cfg.Default.v_Yrd_SkipAsagi = ReadBooleanFromPLC[303];//%MX0.37.7
            Properties.M007_Cfg.Default.i_TransferBantTermikAriza = ReadBooleanFromPLC[304];//%MX0.38.0
            Properties.M007_Cfg.Default.i_TransferBantiCalisiyor = ReadBooleanFromPLC[305];//%MX0.38.1
            Properties.M007_Cfg.Default.i_TransferBandPullCordSwitch = ReadBooleanFromPLC[306];//%MX0.38.2
            Properties.M007_Cfg.Default.i_BiriktirmeBunkerikapakAcik = ReadBooleanFromPLC[307];//%MX0.38.3
            Properties.M007_Cfg.Default.i_BiriktirmeBunkerikapakKapali = ReadBooleanFromPLC[308];//%MX0.38.4
            Properties.M007_Cfg.Default.i_BiriktirmeBunkeriVibratorTermikAriza = ReadBooleanFromPLC[309];//%MX0.38.5
            Properties.M007_Cfg.Default.i_BiriktirmeBunkeriCalisiyor = ReadBooleanFromPLC[310];//%MX0.38.6
            Properties.M007_Cfg.Default.i_BiriktirmeBunkeriVibratorCalisiyor = ReadBooleanFromPLC[311];//%MX0.38.7
            Properties.M007_Cfg.Default.q_TransferBandCalis = ReadBooleanFromPLC[312];//%MX0.39.0
            Properties.M007_Cfg.Default.q_BiriktirmeBunkeriCalis = ReadBooleanFromPLC[313];//%MX0.39.1
            Properties.M007_Cfg.Default.q_BiriktirmeBunkeriVibCalis = ReadBooleanFromPLC[314];//%MX0.39.2
            Properties.M007_Cfg.Default.v_Yrd_TransferBandStart = ReadBooleanFromPLC[315];//%MX0.39.3
            Properties.M007_Cfg.Default.v_Yrd_TransferBandStop = ReadBooleanFromPLC[316];//%MX0.39.4
            Properties.M007_Cfg.Default.Spare_98 = ReadBooleanFromPLC[317];//%MX0.39.5
            Properties.M007_Cfg.Default.Spare_99 = ReadBooleanFromPLC[318];//%MX0.39.6
            Properties.M007_Cfg.Default.Spare_100 = ReadBooleanFromPLC[319];//%MX0.39.7
            Properties.M007_Cfg.Default.Spare_101 = ReadBooleanFromPLC[320];//%MX0.40.0
            Properties.M007_Cfg.Default.Spare_102 = ReadBooleanFromPLC[321];//%MX0.40.1
            Properties.M007_Cfg.Default.Spare_103 = ReadBooleanFromPLC[322];//%MX0.40.2
            Properties.M007_Cfg.Default.Spare_104 = ReadBooleanFromPLC[323];//%MX0.40.3
            Properties.M007_Cfg.Default.Spare_105 = ReadBooleanFromPLC[324];//%MX0.40.4
            Properties.M007_Cfg.Default.Spare_106 = ReadBooleanFromPLC[325];//%MX0.40.5
            Properties.M007_Cfg.Default.Spare_107 = ReadBooleanFromPLC[326];//%MX0.40.6
            Properties.M007_Cfg.Default.Spare_108 = ReadBooleanFromPLC[327];//%MX0.40.7
            Properties.M007_Cfg.Default.Spare_109 = ReadBooleanFromPLC[328];//%MX0.41.0
            Properties.M007_Cfg.Default.Spare_110 = ReadBooleanFromPLC[329];//%MX0.41.1
            Properties.M007_Cfg.Default.Spare_111 = ReadBooleanFromPLC[330];//%MX0.41.2
            Properties.M007_Cfg.Default.Spare_112 = ReadBooleanFromPLC[331];//%MX0.41.3
            Properties.M007_Cfg.Default.Spare_113 = ReadBooleanFromPLC[332];//%MX0.41.4
            Properties.M007_Cfg.Default.Spare_114 = ReadBooleanFromPLC[333];//%MX0.41.5
            Properties.M007_Cfg.Default.Spare_115 = ReadBooleanFromPLC[334];//%MX0.41.6
            Properties.M007_Cfg.Default.Spare_116 = ReadBooleanFromPLC[335];//%MX0.41.7
            Properties.M007_Cfg.Default.Spare_117 = ReadBooleanFromPLC[336];//%MX0.42.0
            Properties.M007_Cfg.Default.Spare_118 = ReadBooleanFromPLC[337];//%MX0.42.1
            Properties.M007_Cfg.Default.Spare_119 = ReadBooleanFromPLC[338];//%MX0.42.2
            Properties.M007_Cfg.Default.Spare_120 = ReadBooleanFromPLC[339];//%MX0.42.3
            Properties.M007_Cfg.Default.Spare_121 = ReadBooleanFromPLC[340];//%MX0.42.4
            Properties.M007_Cfg.Default.Spare_122 = ReadBooleanFromPLC[341];//%MX0.42.5
            Properties.M007_Cfg.Default.Spare_123 = ReadBooleanFromPLC[342];//%MX0.42.6
            Properties.M007_Cfg.Default.Spare_124 = ReadBooleanFromPLC[343];//%MX0.42.7
            Properties.M007_Cfg.Default.Spare_125 = ReadBooleanFromPLC[344];//%MX0.43.0
            Properties.M007_Cfg.Default.Spare_126 = ReadBooleanFromPLC[345];//%MX0.43.1
            Properties.M007_Cfg.Default.Spare_127 = ReadBooleanFromPLC[346];//%MX0.43.2
            Properties.M007_Cfg.Default.Spare_128 = ReadBooleanFromPLC[347];//%MX0.43.3
            Properties.M007_Cfg.Default.Spare_129 = ReadBooleanFromPLC[348];//%MX0.43.4
            Properties.M007_Cfg.Default.Spare_130 = ReadBooleanFromPLC[349];//%MX0.43.5
            Properties.M007_Cfg.Default.Spare_131 = ReadBooleanFromPLC[350];//%MX0.43.6
            Properties.M007_Cfg.Default.Spare_132 = ReadBooleanFromPLC[351];//%MX0.43.7
        }
    }
}
