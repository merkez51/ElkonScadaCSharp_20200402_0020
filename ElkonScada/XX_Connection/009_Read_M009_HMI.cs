using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _009_Read_M009_HMI
    {
        
        public void ReadM009HMI(bool[] ReadBooleanFromPLC)
        {
            Properties.M009_HMI.Default.HMI_SuKlepeKapali = ReadBooleanFromPLC[416];//%MX0.52.0
            Properties.M009_HMI.Default.HMI_CimentoKlepeKapali = ReadBooleanFromPLC[417];//%MX0.52.1
            Properties.M009_HMI.Default.HMI_MikserKapakAcik = ReadBooleanFromPLC[418];//%MX0.52.2
            Properties.M009_HMI.Default.HMI_MikserKapakKapali = ReadBooleanFromPLC[419];//%MX0.52.3
            Properties.M009_HMI.Default.HMI_SimTestAktif = ReadBooleanFromPLC[420];//%MX0.52.4
            Properties.M009_HMI.Default.HMI_ButonOtomatikte = ReadBooleanFromPLC[421];//%MX0.52.5
            Properties.M009_HMI.Default.HMI_ButonManualde = ReadBooleanFromPLC[422];//%MX0.52.6
            Properties.M009_HMI.Default.HMI_ModYariOtomatik = ReadBooleanFromPLC[423];//%MX0.52.7
            Properties.M009_HMI.Default.HMI_MikserKapakAcValf = ReadBooleanFromPLC[424];//%MX0.53.0
            Properties.M009_HMI.Default.HMI_MikserKapakKapatValf = ReadBooleanFromPLC[425];//%MX0.53.1
            Properties.M009_HMI.Default.HMI_CimentoBosalt = ReadBooleanFromPLC[426];//%MX0.53.2
            Properties.M009_HMI.Default.HMI_SuBosalt = ReadBooleanFromPLC[427];//%MX0.53.3
            Properties.M009_HMI.Default.HMI_KatkiBosalt = ReadBooleanFromPLC[428];//%MX0.53.4
            Properties.M009_HMI.Default.HMI_KovaAsagida = ReadBooleanFromPLC[429];//%MX0.53.5
            Properties.M009_HMI.Default.HMI_KovaYukarida = ReadBooleanFromPLC[430];//%MX0.53.6
            Properties.M009_HMI.Default.HMI_KovaOrtada = ReadBooleanFromPLC[431];//%MX0.53.7
            Properties.M009_HMI.Default.HMI_KovaYavaslama = ReadBooleanFromPLC[432];//%MX0.54.0
            Properties.M009_HMI.Default.HMI_AsagiHizliStart = ReadBooleanFromPLC[433];//%MX0.54.1
            Properties.M009_HMI.Default.HMI_YukariStart = ReadBooleanFromPLC[434];//%MX0.54.2
            Properties.M009_HMI.Default.HMI_AsagiYavasStart = ReadBooleanFromPLC[435];//%MX0.54.3
            Properties.M009_HMI.Default.HMI_FrenAcik = ReadBooleanFromPLC[436];//%MX0.54.4
            Properties.M009_HMI.Default.HMI_48V = ReadBooleanFromPLC[437];//%MX0.54.5
            Properties.M009_HMI.Default.HMI_24V = ReadBooleanFromPLC[438];//%MX0.54.6
            Properties.M009_HMI.Default.Spare_149 = ReadBooleanFromPLC[439];//%MX0.54.7
            Properties.M009_HMI.Default.Spare_150 = ReadBooleanFromPLC[440];//%MX0.55.0
            Properties.M009_HMI.Default.Spare_151 = ReadBooleanFromPLC[441];//%MX0.55.1
            Properties.M009_HMI.Default.Spare_152 = ReadBooleanFromPLC[442];//%MX0.55.2
            Properties.M009_HMI.Default.Spare_153 = ReadBooleanFromPLC[443];//%MX0.55.3
            Properties.M009_HMI.Default.Spare_154 = ReadBooleanFromPLC[444];//%MX0.55.4
            Properties.M009_HMI.Default.Spare_155 = ReadBooleanFromPLC[445];//%MX0.55.5
            Properties.M009_HMI.Default.Spare_156 = ReadBooleanFromPLC[446];//%MX0.55.6
            Properties.M009_HMI.Default.Spare_157 = ReadBooleanFromPLC[447];//%MX0.55.7
        }
    }
}
