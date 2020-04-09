using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _012_Read_M012_Lambalar
    {
       
        public void ReadM012Lambalar(bool[] ReadBooleanFromPLC)
        {

            Properties.M012_Lambalar.Default.qs_Agrega1Lambasi = ReadBooleanFromPLC[640];//%MX0.80.0
            Properties.M012_Lambalar.Default.qs_Agrega2Lambasi = ReadBooleanFromPLC[641];//%MX0.80.1
            Properties.M012_Lambalar.Default.qs_Agrega3Lambasi = ReadBooleanFromPLC[642];//%MX0.80.2
            Properties.M012_Lambalar.Default.qs_Agrega4Lambasi = ReadBooleanFromPLC[643];//%MX0.80.3
            Properties.M012_Lambalar.Default.qs_Agrega5Lambasi = ReadBooleanFromPLC[644];//%MX0.80.4
            Properties.M012_Lambalar.Default.qs_Agrega6Lambasi = ReadBooleanFromPLC[645];//%MX0.80.5
            Properties.M012_Lambalar.Default.qs_Cimento1Lambasi = ReadBooleanFromPLC[646];//%MX0.80.6
            Properties.M012_Lambalar.Default.qs_Cimento2Lambasi = ReadBooleanFromPLC[647];//%MX0.80.7
            Properties.M012_Lambalar.Default.qs_Cimento3Lambasi = ReadBooleanFromPLC[648];//%MX0.81.0
            Properties.M012_Lambalar.Default.qs_Cimento4Lambasi = ReadBooleanFromPLC[649];//%MX0.81.1
            Properties.M012_Lambalar.Default.qs_Cimento5Lambasi = ReadBooleanFromPLC[650];//%MX0.81.2
            Properties.M012_Lambalar.Default.qs_Cimento6Lambasi = ReadBooleanFromPLC[651];//%MX0.81.3
            Properties.M012_Lambalar.Default.qs_Katki1Lambasi = ReadBooleanFromPLC[652];//%MX0.81.4
            Properties.M012_Lambalar.Default.qs_Katki2Lambasi = ReadBooleanFromPLC[653];//%MX0.81.5
            Properties.M012_Lambalar.Default.qs_Katki3Lambasi = ReadBooleanFromPLC[654];//%MX0.81.6
            Properties.M012_Lambalar.Default.qs_Katki4Lambasi = ReadBooleanFromPLC[655];//%MX0.81.7
            Properties.M012_Lambalar.Default.qs_Katki5Lambasi = ReadBooleanFromPLC[656];//%MX0.82.0
            Properties.M012_Lambalar.Default.qs_Katki6Lambasi = ReadBooleanFromPLC[657];//%MX0.82.1
            Properties.M012_Lambalar.Default.qs_Su1Lambasi = ReadBooleanFromPLC[658];//%MX0.82.2
            Properties.M012_Lambalar.Default.qs_Su2Lambasi = ReadBooleanFromPLC[659];//%MX0.82.3
            Properties.M012_Lambalar.Default.qs_Su3Lambasi = ReadBooleanFromPLC[660];//%MX0.82.4
            Properties.M012_Lambalar.Default.qs_Su4Lambasi = ReadBooleanFromPLC[661];//%MX0.82.5
            Properties.M012_Lambalar.Default.qs_LambaHassasAgrega = ReadBooleanFromPLC[662];//%MX0.82.6
            Properties.M012_Lambalar.Default.qs_Agrega1VibBesLambasi = ReadBooleanFromPLC[663];//%MX0.82.7
            Properties.M012_Lambalar.Default.qs_CimentoBosaltLambasi = ReadBooleanFromPLC[664];//%MX0.83.0
            Properties.M012_Lambalar.Default.qs_CimentoBosaltVibratorLambasi = ReadBooleanFromPLC[665];//%MX0.83.1
            Properties.M012_Lambalar.Default.qs_KatkiBosaltLambasi = ReadBooleanFromPLC[666];//%MX0.83.2
            Properties.M012_Lambalar.Default.qs_SuBosaltLambasi = ReadBooleanFromPLC[667];//%MX0.83.3
            Properties.M012_Lambalar.Default.qs_MikserStartLambasi = ReadBooleanFromPLC[668];//%MX0.83.4
            Properties.M012_Lambalar.Default.qs_MikserKapakAcikLambasi = ReadBooleanFromPLC[669];//%MX0.83.5
            Properties.M012_Lambalar.Default.qs_MikserKapakKapaliLambasi = ReadBooleanFromPLC[670];//%MX0.83.6
            Properties.M012_Lambalar.Default.qs_MikserArizaLambasi = ReadBooleanFromPLC[671];//%MX0.83.7
            Properties.M012_Lambalar.Default.qs_Filtre1Lambasi = ReadBooleanFromPLC[672];//%MX0.84.0
            Properties.M012_Lambalar.Default.qs_Filtre2Lambasi = ReadBooleanFromPLC[673];//%MX0.84.1
            Properties.M012_Lambalar.Default.qs_Filtre3Lambasi = ReadBooleanFromPLC[674];//%MX0.84.2
            Properties.M012_Lambalar.Default.qs_Filtre4Lambasi = ReadBooleanFromPLC[675];//%MX0.84.3
            Properties.M012_Lambalar.Default.qs_Filtre5Lambasi = ReadBooleanFromPLC[676];//%MX0.84.4
            Properties.M012_Lambalar.Default.qs_Filtre6Lambasi = ReadBooleanFromPLC[677];//%MX0.84.5
            Properties.M012_Lambalar.Default.qs_KovaAsagidaLambasi = ReadBooleanFromPLC[678];//%MX0.84.6
            Properties.M012_Lambalar.Default.qs_KovaYukaridaLambasi = ReadBooleanFromPLC[679];//%MX0.84.7
            Properties.M012_Lambalar.Default.qs_KovaOrtadaLambasi = ReadBooleanFromPLC[680];//%MX0.85.0
            Properties.M012_Lambalar.Default.qs_KovaYukariLambasi = ReadBooleanFromPLC[681];//%MX0.85.1
            Properties.M012_Lambalar.Default.qs_KovaAsagiLambasi = ReadBooleanFromPLC[682];//%MX0.85.2
            Properties.M012_Lambalar.Default.qs_FrenAcik = ReadBooleanFromPLC[683];//%MX0.85.3
            Properties.M012_Lambalar.Default.qs_TransferBandLamba = ReadBooleanFromPLC[684];//%MX0.85.4
            Properties.M012_Lambalar.Default.qs_TartiBand1Lambasi = ReadBooleanFromPLC[685];//%MX0.85.5
            Properties.M012_Lambalar.Default.qs_TartiBand1VibratorLambasi = ReadBooleanFromPLC[686];//%MX0.85.6
            Properties.M012_Lambalar.Default.qs_Agrega1VibratorLambasi = ReadBooleanFromPLC[687];//%MX0.85.7
            Properties.M012_Lambalar.Default.qs_Agrega2VibratorLambasi = ReadBooleanFromPLC[688];//%MX0.86.0
            Properties.M012_Lambalar.Default.qs_Agrega3VibratorLambasi = ReadBooleanFromPLC[689];//%MX0.86.1
            Properties.M012_Lambalar.Default.qs_Agrega4VibratorLambasi = ReadBooleanFromPLC[690];//%MX0.86.2
            Properties.M012_Lambalar.Default.qs_Agrega5VibratorLambasi = ReadBooleanFromPLC[691];//%MX0.86.3
            Properties.M012_Lambalar.Default.qs_Agrega6VibratorLambasi = ReadBooleanFromPLC[692];//%MX0.86.4
            Properties.M012_Lambalar.Default.qs_SoklamaLambasi = ReadBooleanFromPLC[693];//%MX0.86.5
            Properties.M012_Lambalar.Default.qs_KompresorLambasi = ReadBooleanFromPLC[694];//%MX0.86.6
            Properties.M012_Lambalar.Default.qs_MikserBlokFiltreLambasi = ReadBooleanFromPLC[695];//%MX0.86.7
            Properties.M012_Lambalar.Default.qs_OtomatikStartLambasi = ReadBooleanFromPLC[696];//%MX0.87.0
            Properties.M012_Lambalar.Default.qs_YrdButonMikserAcLambasi = ReadBooleanFromPLC[697];//%MX0.87.1
            Properties.M012_Lambalar.Default.qs_YrdButonCimentoBosaltLambasi = ReadBooleanFromPLC[698];//%MX0.87.2
            Properties.M012_Lambalar.Default.qs_YrdButonKatkiBosaltLambasi = ReadBooleanFromPLC[699];//%MX0.87.3
            Properties.M012_Lambalar.Default.qs_YrdButonSuBosaltLambasi = ReadBooleanFromPLC[700];//%MX0.87.4
            Properties.M012_Lambalar.Default.is_AcilStop = ReadBooleanFromPLC[701];//%MX0.87.5
            Properties.M012_Lambalar.Default.is_ButonManualde = ReadBooleanFromPLC[702];//%MX0.87.6
            Properties.M012_Lambalar.Default.is_ButonOtomatikte = ReadBooleanFromPLC[703];//%MX0.87.7
            Properties.M012_Lambalar.Default.s_ModYariOtomatik = ReadBooleanFromPLC[704];//%MX0.88.0
            Properties.M012_Lambalar.Default.is_ButonStart = ReadBooleanFromPLC[705];//%MX0.88.1
            Properties.M012_Lambalar.Default.is_ButonStop = ReadBooleanFromPLC[706];//%MX0.88.2
            Properties.M012_Lambalar.Default.Spare_233 = ReadBooleanFromPLC[707];//%MX0.88.3
            Properties.M012_Lambalar.Default.Spare_234 = ReadBooleanFromPLC[708];//%MX0.88.4
            Properties.M012_Lambalar.Default.Spare_235 = ReadBooleanFromPLC[709];//%MX0.88.5
            Properties.M012_Lambalar.Default.Spare_236 = ReadBooleanFromPLC[710];//%MX0.88.6
            Properties.M012_Lambalar.Default.Spare_237 = ReadBooleanFromPLC[711];//%MX0.88.7
            Properties.M012_Lambalar.Default.Spare_238 = ReadBooleanFromPLC[712];//%MX0.89.0
            Properties.M012_Lambalar.Default.Spare_239 = ReadBooleanFromPLC[713];//%MX0.89.1
            Properties.M012_Lambalar.Default.Spare_240 = ReadBooleanFromPLC[714];//%MX0.89.2
            Properties.M012_Lambalar.Default.Spare_241 = ReadBooleanFromPLC[715];//%MX0.89.3
            Properties.M012_Lambalar.Default.Spare_242 = ReadBooleanFromPLC[716];//%MX0.89.4
            Properties.M012_Lambalar.Default.Spare_243 = ReadBooleanFromPLC[717];//%MX0.89.5
            Properties.M012_Lambalar.Default.Spare_244 = ReadBooleanFromPLC[718];//%MX0.89.6
            Properties.M012_Lambalar.Default.Spare_245 = ReadBooleanFromPLC[719];//%MX0.89.7
            Properties.M012_Lambalar.Default.Spare_246 = ReadBooleanFromPLC[720];//%MX0.90.0
            Properties.M012_Lambalar.Default.Spare_247 = ReadBooleanFromPLC[721];//%MX0.90.1
            Properties.M012_Lambalar.Default.Spare_248 = ReadBooleanFromPLC[722];//%MX0.90.2
            Properties.M012_Lambalar.Default.Spare_249 = ReadBooleanFromPLC[723];//%MX0.90.3
            Properties.M012_Lambalar.Default.Spare_250 = ReadBooleanFromPLC[724];//%MX0.90.4
            Properties.M012_Lambalar.Default.Spare_251 = ReadBooleanFromPLC[725];//%MX0.90.5
            Properties.M012_Lambalar.Default.Spare_252 = ReadBooleanFromPLC[726];//%MX0.90.6
            Properties.M012_Lambalar.Default.Spare_253 = ReadBooleanFromPLC[727];//%MX0.90.7
            Properties.M012_Lambalar.Default.Spare_254 = ReadBooleanFromPLC[728];//%MX0.91.0
            Properties.M012_Lambalar.Default.Spare_255 = ReadBooleanFromPLC[729];//%MX0.91.1
            Properties.M012_Lambalar.Default.Spare_256 = ReadBooleanFromPLC[730];//%MX0.91.2
            Properties.M012_Lambalar.Default.Spare_257 = ReadBooleanFromPLC[731];//%MX0.91.3
            Properties.M012_Lambalar.Default.Spare_258 = ReadBooleanFromPLC[732];//%MX0.91.4
            Properties.M012_Lambalar.Default.Spare_259 = ReadBooleanFromPLC[733];//%MX0.91.5
            Properties.M012_Lambalar.Default.Spare_260 = ReadBooleanFromPLC[734];//%MX0.91.6
            Properties.M012_Lambalar.Default.Spare_261 = ReadBooleanFromPLC[735];//%MX0.91.7
        }
    }
}
