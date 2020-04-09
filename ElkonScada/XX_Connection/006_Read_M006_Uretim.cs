using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _006_Read_M006_Uretim
    {
      
        XX_IntToFloat IntoFloat = XX_IntToFloat.ConvertToFloat_();
      
        public void ReadM006Uretim(bool[] ReadBooleanFromPLC,int[] ReadWordFromPLCPart3,int[] ReadWordFromPLCPart5)
        {
            Properties.M006_Uretim.Default.XB111_UretimBittiKayitReset = ReadBooleanFromPLC[256];//%MX0.32.0
            Properties.M006_Uretim.Default.AraKayitAl = ReadBooleanFromPLC[257];//%MX0.32.1
            Properties.M006_Uretim.Default.XB101_GonderAnimasyon = ReadBooleanFromPLC[258];//%MX0.32.2
            Properties.M006_Uretim.Default.VerilerPLCdenGonderildi = ReadBooleanFromPLC[259];//%MX0.32.3
            Properties.M006_Uretim.Default.VerilerResetDelay = ReadBooleanFromPLC[260];//%MX0.32.4
            Properties.M006_Uretim.Default.VerilerResetDelay = ReadBooleanFromPLC[261];//%MX0.32.5
            Properties.M006_Uretim.Default.IrsaliyeYazdir = ReadBooleanFromPLC[262];//%MX0.32.6
            Properties.M006_Uretim.Default.XB1_Reset = ReadBooleanFromPLC[263];//%MX0.32.7
            Properties.M006_Uretim.Default.XB1_StartOK = ReadBooleanFromPLC[264];//%MX0.33.0
            Properties.M006_Uretim.Default.XB1_Gonder = ReadBooleanFromPLC[265];//%MX0.33.1
            Properties.M006_Uretim.Default.XB1_KornaBaslangic = ReadBooleanFromPLC[266];//%MX0.33.2
            Properties.M006_Uretim.Default.XB1_KornaBitis = ReadBooleanFromPLC[267];//%MX0.33.3
            Properties.M006_Uretim.Default.XB1_BosaltmaBitti = ReadBooleanFromPLC[268];//%MX0.33.4
            Properties.M006_Uretim.Default.XB1_KontrolWordlerSifir = ReadBooleanFromPLC[269];//%MX0.33.5
            Properties.M006_Uretim.Default.XB1_CimSuKatAlindi = ReadBooleanFromPLC[270];//%MX0.33.6
            Properties.M006_Uretim.Default.XB1_MikserStart = ReadBooleanFromPLC[271];//%MX0.33.7
            Properties.M006_Uretim.Default.XB1_24VFren_Gecis = ReadBooleanFromPLC[272];//%MX0.34.0
            Properties.M006_Uretim.Default.Spare_83 = ReadBooleanFromPLC[273];//%MX0.34.1
            Properties.M006_Uretim.Default.Spare_84 = ReadBooleanFromPLC[274];//%MX0.34.2
            Properties.M006_Uretim.Default.Spare_85 = ReadBooleanFromPLC[275];//%MX0.34.3
            Properties.M006_Uretim.Default.Spare_86 = ReadBooleanFromPLC[276];//%MX0.34.4
            Properties.M006_Uretim.Default.Spare_87 = ReadBooleanFromPLC[277];//%MX0.34.5
            Properties.M006_Uretim.Default.Spare_88 = ReadBooleanFromPLC[278];//%MX0.34.6
            Properties.M006_Uretim.Default.Spare_89 = ReadBooleanFromPLC[279];//%MX0.34.7
            Properties.M006_Uretim.Default.Spare_90 = ReadBooleanFromPLC[280];//%MX0.35.0
            Properties.M006_Uretim.Default.Spare_91 = ReadBooleanFromPLC[281];//%MX0.35.1
            Properties.M006_Uretim.Default.Spare_92 = ReadBooleanFromPLC[282];//%MX0.35.2
            Properties.M006_Uretim.Default.Spare_93 = ReadBooleanFromPLC[283];//%MX0.35.3
            Properties.M006_Uretim.Default.Spare_94 = ReadBooleanFromPLC[284];//%MX0.35.4
            Properties.M006_Uretim.Default.Spare_95 = ReadBooleanFromPLC[285];//%MX0.35.5
            Properties.M006_Uretim.Default.Spare_96 = ReadBooleanFromPLC[286];//%MX0.35.6
            Properties.M006_Uretim.Default.Spare_97 = ReadBooleanFromPLC[287];//%MX0.35.7

            Properties.M006_Uretim.Default.XB1_KovaYukBekKalanSure = ReadWordFromPLCPart3[59]; //MW0.359
            Properties.M006_Uretim.Default.XB1_MikserKalanSure = ReadWordFromPLCPart3[60]; //MW0.359
            Properties.M006_Uretim.Default.XB1_MikserKapakAcikKalmaSure = ReadWordFromPLCPart3[61]; //MW0.359
            Properties.M006_Uretim.Default.XB112_SoklamaKW = ReadWordFromPLCPart3[62]; //MW0.359
            Properties.M006_Uretim.Default.XB19_MikserAnalogDeger = IntoFloat.IntToFloat(ReadWordFromPLCPart5[54], ReadWordFromPLCPart5[55]);     //%MD0.277
        }
    }
}
