using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _010_Read_M010_Alarm
    {
       
        public void ReadM010Alarm(bool[] ReadBooleanFromPLC)
        {
            Properties.M010_Alarm.Default.AL_O110_MikserCalismiyor = ReadBooleanFromPLC[1];//%MX0.56.0
            Properties.M010_Alarm.Default.AL_G109_XB46_MikserBosaltmaKapagiGirilenMaksimumSureIcindeAcilamadiKapanamadi = ReadBooleanFromPLC[449];//%MX0.56.1
            Properties.M010_Alarm.Default.AL_A200_1_TartiKonveyor1MotorTMSArizasi = ReadBooleanFromPLC[450];//%MX0.56.2
            Properties.M010_Alarm.Default.AL_A100_MikserMotorTMSArizasi = ReadBooleanFromPLC[451];//%MX0.56.3
            Properties.M010_Alarm.Default.AL_A900_KompresorMotorTMSArizasi = ReadBooleanFromPLC[452];//%MX0.56.4
            Properties.M010_Alarm.Default.AL_XB46_GenelHata = ReadBooleanFromPLC[453];//%MX0.56.5
            Properties.M010_Alarm.Default.AL_G507_CimentoKantariBosaltmaKapagiGriilenMaksimumSureIcindeAcilamadiKapanamadi = ReadBooleanFromPLC[454];//%MX0.56.6
            Properties.M010_Alarm.Default.AL_G604_SuKantariBosaltmaKapagiGirilenMaksimumSureIcindeAcilamadiKapanamadi = ReadBooleanFromPLC[455];//%MX0.56.7
            Properties.M010_Alarm.Default.AL_G704_KatkiKantariBosaltmaKapagiGirilenMaksimumSureIcindeAcilamadiKapanamadi = ReadBooleanFromPLC[456];//%MX0.57.0
            Properties.M010_Alarm.Default.AL_C204_TartiKonveyorAsiriYukArizasi = ReadBooleanFromPLC[457];//%MX0.57.1
            Properties.M010_Alarm.Default.AL_C503_CimentoKantariAsiriYukHatasi = ReadBooleanFromPLC[458];//%MX0.57.2
            Properties.M010_Alarm.Default.AL_C601_SuKantariAsiriYukHatasi = ReadBooleanFromPLC[459];//%MX0.57.3
            Properties.M010_Alarm.Default.AL_C701_KatkiKantariAsiriYukHatasi = ReadBooleanFromPLC[460];//%MX0.57.4
            Properties.M010_Alarm.Default.AL_A111_MikserDoluykenCalistirildi = ReadBooleanFromPLC[461];//%MX0.57.5
            Properties.M010_Alarm.Default.AL_XB46_FazHata = ReadBooleanFromPLC[462];//%MX0.57.6
            Properties.M010_Alarm.Default.AL_K404_SkipFrenBalatasiAsindiVeyaAyariBozulduVeyaFrenSwitchiAyariBozulduVeyaArizali = ReadBooleanFromPLC[463];//%MX0.57.7
            Properties.M010_Alarm.Default.AL_XB46_GenelEmniyet = ReadBooleanFromPLC[464];//%MX0.58.0
            Properties.M010_Alarm.Default.AL_A400_SkipMotorTMSArizasi = ReadBooleanFromPLC[465];//%MX0.58.1
            Properties.M010_Alarm.Default.AL_K406_SkipAltPozisyonundaDegilVeyaPozisyonSwitchininAyariBozulduVeyaArizali = ReadBooleanFromPLC[466];//%MX0.58.2
            Properties.M010_Alarm.Default.AL_K105_MikserOtomatikYaglamaArizasiVeyaSwitchiArizali = ReadBooleanFromPLC[467];//%MX0.58.3
            Properties.M010_Alarm.Default.AL_A300_TransferKonveyorMotorTMSArizasi = ReadBooleanFromPLC[468];//%MX0.58.4
            Properties.M010_Alarm.Default.AL_G801_BiriktirmeBunkerBosaltmaKapagiGirilenMaksimumSureIcindeAcilamadiKapanamadi = ReadBooleanFromPLC[469];//%MX0.58.5
            Properties.M010_Alarm.Default.AL_H510_CimentoKantarininAgirligiBosKabulEdilenMiktardanDahaFazla = ReadBooleanFromPLC[470];//%MX0.58.6
            Properties.M010_Alarm.Default.AL_H707_KatkiKantarininAgirligiBosKabulEdilenMiktardanDahaFazla = ReadBooleanFromPLC[471];//%MX0.58.7
            Properties.M010_Alarm.Default.AL_H607_SuKantarininAgirligiBosKabulEdilenMiktardanDahaFazla = ReadBooleanFromPLC[472];//%MX0.59.0
            Properties.M010_Alarm.Default.AL_H210_TartimKonveyoruKantarininAgirligiBosKabulEdilenMiktardanDahaFazla = ReadBooleanFromPLC[473];//%MX0.59.1
            Properties.M010_Alarm.Default.AL_D402_SkipMaksimunYurumeSuresiAsildi = ReadBooleanFromPLC[474];//%MX0.59.2
            Properties.M010_Alarm.Default.AL_XB46_FrenKopruAriza = ReadBooleanFromPLC[475];//%MX0.59.3
            Properties.M010_Alarm.Default.AL_A500_CimentoHelezonMotorTMSArizasi = ReadBooleanFromPLC[476];//%MX0.59.4
            Properties.M010_Alarm.Default.AL_A700_KatkiPompaMotoruTMSArizasi = ReadBooleanFromPLC[477];//%MX0.59.5
            Properties.M010_Alarm.Default.AL_A600_SuKantariBosaltPompaMotorTMSArizasi = ReadBooleanFromPLC[478];//%MX0.59.6
            Properties.M010_Alarm.Default.AL_K106_MikserMotoruAsiriIsindi70C_VeyaPTCTermistoruArizali = ReadBooleanFromPLC[479];//%MX0.59.7
            Properties.M010_Alarm.Default.AL_L302_TransferKonveyorPullCordSwitchiCekildi = ReadBooleanFromPLC[480];//%MX0.60.0
            Properties.M010_Alarm.Default.AL_L208_TartiKonveyorPullCordSwitchiCekildi = ReadBooleanFromPLC[481];//%MX0.60.1
            Properties.M010_Alarm.Default.AL_XB46_HidrolikKapakHata = ReadBooleanFromPLC[482];//%MX0.60.2
            Properties.M010_Alarm.Default.AL_K108_MikserBakimKapagiAcildiVeyaSwitchiAyariBozulduVeyaArizali = ReadBooleanFromPLC[483];//%MX0.60.3
            Properties.M010_Alarm.Default.AL_B504_1_CimentoHelezon1MotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[484];//%MX0.60.4
            Properties.M010_Alarm.Default.AL_B504_2_CimentoHelezon2MotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[485];//%MX0.60.5
            Properties.M010_Alarm.Default.AL_B504_3_CimentoHelezon3MotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[486];//%MX0.60.6
            Properties.M010_Alarm.Default.AL_B504_4_CimentoHelezon4MotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[487];//%MX0.60.7
            Properties.M010_Alarm.Default.AL_B504_5_CimentoHelezon5MotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[488];//%MX0.61.0
            Properties.M010_Alarm.Default.AL_A202_2_AgregaBunker2VibratorTMSArizasi = ReadBooleanFromPLC[490];//%MX0.61.2
            Properties.M010_Alarm.Default.AL_A202_3_AgregaBunker3VibratorTMSArizasi = ReadBooleanFromPLC[491];//%MX0.61.3
            Properties.M010_Alarm.Default.AL_A501_CimentoKantarVibratorTMSArizasi = ReadBooleanFromPLC[491];//%MX0.61.3
            Properties.M010_Alarm.Default.AL_A201_1TartiKonveyor1VibratorTMSArizasi = ReadBooleanFromPLC[492];//%MX0.61.4
            Properties.M010_Alarm.Default.AL_A800_BiriktirmeBunkeriVibratorTMSArizasi = ReadBooleanFromPLC[493];//%MX0.61.5
            Properties.M010_Alarm.Default.AL_A201_2TartiKonveyor2VibratorTMSArizasi = ReadBooleanFromPLC[494];//%MX0.61.6
            Properties.M010_Alarm.Default.AL_K107_MikserReduktorYagiAsiriIsindi70VeyaSensorArizali = ReadBooleanFromPLC[495];//%MX0.61.7
            Properties.M010_Alarm.Default.AL_A112_MikserDurdu = ReadBooleanFromPLC[496];//%MX0.62.0
            Properties.M010_Alarm.Default.AL_B103_MikserMotorAsiriAkimLimitiAsildi = ReadBooleanFromPLC[497];//%MX0.62.1
            Properties.M010_Alarm.Default.AL_E602_RecetedekiSuDegeriGirilenMaksimumSureIcindeKantaraAlinamadi = ReadBooleanFromPLC[498];//%MX0.62.2
            Properties.M010_Alarm.Default.AL_E702_RecetedekiKatkiDegeriGirilenMaksimumSureIcindeKantaraAlinamadi = ReadBooleanFromPLC[499];//%MX0.62.3
            Properties.M010_Alarm.Default.AL_E505_RecetedekiCimentoDegeriGirilenMaksimumSureIcindeKantaraAlinamadi = ReadBooleanFromPLC[500];//%MX0.62.4
            Properties.M010_Alarm.Default.AL_E205_RecetedekiAgregaDegeriGirilenMaksimumSureIcindeTartiKonveyoruneAlinamadi = ReadBooleanFromPLC[501];//%MX0.62.5
            Properties.M010_Alarm.Default.AL_F506_CimentoKantariGirilenMaksimumSureIcindeBosKabulEdilenMiktaraUlasamadi = ReadBooleanFromPLC[502];//%MX0.62.6
            Properties.M010_Alarm.Default.AL_F206_AgregaTartiKonveyoruGirilenMaksimumSureIcindeBosKabulEdilenmiktaraUlasamadi = ReadBooleanFromPLC[503];//%MX0.62.7
            Properties.M010_Alarm.Default.AL_F603_SuKantariGirilenMaksimumSureIcindeBosKabulEdilenMiktaraUlasamadi = ReadBooleanFromPLC[504];//%MX0.63.0
            Properties.M010_Alarm.Default.AL_F703_KatkiKantariGirilenMaksimumSureIcindeBosKabulEdilenMiktaraUlasamadi = ReadBooleanFromPLC[505];//%MX0.63.1
            Properties.M010_Alarm.Default.AcilStopButonuBasildi = ReadBooleanFromPLC[506];//%MX0.63.2
            Properties.M010_Alarm.Default.Spare_158 = ReadBooleanFromPLC[507];//%MX0.63.3
            Properties.M010_Alarm.Default.Spare_159 = ReadBooleanFromPLC[508];//%MX0.63.4
            Properties.M010_Alarm.Default.Spare_160 = ReadBooleanFromPLC[509];//%MX0.63.5
            Properties.M010_Alarm.Default.Spare_161 = ReadBooleanFromPLC[510];//%MX0.63.6
            Properties.M010_Alarm.Default.Spare_162 = ReadBooleanFromPLC[511];//%MX0.63.7
            Properties.M010_Alarm.Default.Spare_163 = ReadBooleanFromPLC[512];//%MX0.64.0
            Properties.M010_Alarm.Default.Spare_164 = ReadBooleanFromPLC[513];//%MX0.64.1
            Properties.M010_Alarm.Default.Spare_165 = ReadBooleanFromPLC[514];//%MX0.64.2
            Properties.M010_Alarm.Default.Spare_166 = ReadBooleanFromPLC[515];//%MX0.64.3
            Properties.M010_Alarm.Default.Spare_167 = ReadBooleanFromPLC[516];//%MX0.64.4
            Properties.M010_Alarm.Default.Spare_168 = ReadBooleanFromPLC[517];//%MX0.64.5
            Properties.M010_Alarm.Default.Spare_169 = ReadBooleanFromPLC[518];//%MX0.64.6
            Properties.M010_Alarm.Default.Spare_170 = ReadBooleanFromPLC[519];//%MX0.64.7
            Properties.M010_Alarm.Default.Spare_171 = ReadBooleanFromPLC[520];//%MX0.65.0
            Properties.M010_Alarm.Default.Spare_172 = ReadBooleanFromPLC[521];//%MX0.65.1
            Properties.M010_Alarm.Default.Spare_173 = ReadBooleanFromPLC[522];//%MX0.65.2
            Properties.M010_Alarm.Default.Spare_174 = ReadBooleanFromPLC[523];//%MX0.65.3
            Properties.M010_Alarm.Default.Spare_175 = ReadBooleanFromPLC[524];//%MX0.65.4
            Properties.M010_Alarm.Default.Spare_176 = ReadBooleanFromPLC[525];//%MX0.65.5
            Properties.M010_Alarm.Default.Spare_177 = ReadBooleanFromPLC[526];//%MX0.65.6
            Properties.M010_Alarm.Default.Spare_178 = ReadBooleanFromPLC[527];//%MX0.65.7
            Properties.M010_Alarm.Default.Spare_179 = ReadBooleanFromPLC[528];//%MX0.66.0
            Properties.M010_Alarm.Default.Spare_180 = ReadBooleanFromPLC[529];//%MX0.66.1
            Properties.M010_Alarm.Default.Spare_181 = ReadBooleanFromPLC[530];//%MX0.66.2
            Properties.M010_Alarm.Default.Spare_182 = ReadBooleanFromPLC[531];//%MX0.66.3
            Properties.M010_Alarm.Default.Spare_183 = ReadBooleanFromPLC[532];//%MX0.66.4
            Properties.M010_Alarm.Default.Spare_184 = ReadBooleanFromPLC[533];//%MX0.66.5
            Properties.M010_Alarm.Default.Spare_185 = ReadBooleanFromPLC[534];//%MX0.66.6
            Properties.M010_Alarm.Default.Spare_186 = ReadBooleanFromPLC[535];//%MX0.66.7
            Properties.M010_Alarm.Default.Spare_187 = ReadBooleanFromPLC[536];//%MX0.67.0
            Properties.M010_Alarm.Default.Spare_188 = ReadBooleanFromPLC[537];//%MX0.67.1
            Properties.M010_Alarm.Default.Spare_189 = ReadBooleanFromPLC[538];//%MX0.67.2
            Properties.M010_Alarm.Default.Spare_190 = ReadBooleanFromPLC[539];//%MX0.67.3
            Properties.M010_Alarm.Default.Spare_191 = ReadBooleanFromPLC[540];//%MX0.67.4
            Properties.M010_Alarm.Default.Spare_192 = ReadBooleanFromPLC[541];//%MX0.67.5
            Properties.M010_Alarm.Default.Spare_193 = ReadBooleanFromPLC[542];//%MX0.67.6
            Properties.M010_Alarm.Default.Spare_194 = ReadBooleanFromPLC[543];//%MX0.67.7
        }
    }
}
