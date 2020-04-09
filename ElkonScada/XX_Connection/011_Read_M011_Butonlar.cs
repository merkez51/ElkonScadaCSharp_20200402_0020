using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _011_Read_M011_Butonlar
    {
     
        public void ReadM011Butonlar(bool[] ReadBooleanFromPLC)
        {
            Properties.M011_ButonLar.Default.is_ButonAgrega1 = ReadBooleanFromPLC[544];//%MX0.68.0
            Properties.M011_ButonLar.Default.is_ButonAgrega2 = ReadBooleanFromPLC[545];//%MX0.68.1
            Properties.M011_ButonLar.Default.is_ButonAgrega3 = ReadBooleanFromPLC[546];//%MX0.68.2
            Properties.M011_ButonLar.Default.is_ButonAgrega4 = ReadBooleanFromPLC[547];//%MX0.68.3
            Properties.M011_ButonLar.Default.is_ButonAgrega5 = ReadBooleanFromPLC[548];//%MX0.68.4
            Properties.M011_ButonLar.Default.is_ButonAgrega6 = ReadBooleanFromPLC[549];//%MX0.68.5
            Properties.M011_ButonLar.Default.is_ButonAgrega7 = ReadBooleanFromPLC[550];//%MX0.68.6
            Properties.M011_ButonLar.Default.is_ButonAgrega8 = ReadBooleanFromPLC[551];//%MX0.68.7
            Properties.M011_ButonLar.Default.is_ButonCimento1 = ReadBooleanFromPLC[552];//%MX0.69.0
            Properties.M011_ButonLar.Default.is_ButonCimento2 = ReadBooleanFromPLC[553];//%MX0.69.1
            Properties.M011_ButonLar.Default.is_ButonCimento3 = ReadBooleanFromPLC[554];//%MX0.69.2
            Properties.M011_ButonLar.Default.is_ButonCimento4 = ReadBooleanFromPLC[555];//%MX0.69.3
            Properties.M011_ButonLar.Default.is_ButonCimento5 = ReadBooleanFromPLC[556];//%MX0.69.4
            Properties.M011_ButonLar.Default.is_ButonCimento6 = ReadBooleanFromPLC[557];//%MX0.69.5
            Properties.M011_ButonLar.Default.is_ButonKatki1 = ReadBooleanFromPLC[558];//%MX0.69.6
            Properties.M011_ButonLar.Default.is_ButonKatki2 = ReadBooleanFromPLC[559];//%MX0.69.7
            Properties.M011_ButonLar.Default.is_ButonKatki3 = ReadBooleanFromPLC[560];//%MX0.70.0
            Properties.M011_ButonLar.Default.is_ButonKatki4 = ReadBooleanFromPLC[561];//%MX0.70.1
            Properties.M011_ButonLar.Default.is_ButonKatki5 = ReadBooleanFromPLC[562];//%MX0.70.2
            Properties.M011_ButonLar.Default.is_ButonKatki6 = ReadBooleanFromPLC[563];//%MX0.70.3
            Properties.M011_ButonLar.Default.is_ButonSu1 = ReadBooleanFromPLC[564];//%MX0.70.4
            Properties.M011_ButonLar.Default.is_ButonSu2 = ReadBooleanFromPLC[565];//%MX0.70.5
            Properties.M011_ButonLar.Default.is_ButonSu3 = ReadBooleanFromPLC[566];//%MX0.70.6
            Properties.M011_ButonLar.Default.is_ButonSu4 = ReadBooleanFromPLC[567];//%MX0.70.7
            Properties.M011_ButonLar.Default.is_ButonHassasAgrega = ReadBooleanFromPLC[568];//%MX0.71.0
            Properties.M011_ButonLar.Default.is_ButonVibBesAg1 = ReadBooleanFromPLC[569];//%MX0.71.1
            Properties.M011_ButonLar.Default.is_ButonCimentoBosalt = ReadBooleanFromPLC[570];//%MX0.71.2
            Properties.M011_ButonLar.Default.is_ButonCimentoBosaltVibrator = ReadBooleanFromPLC[571];//%MX0.71.3
            Properties.M011_ButonLar.Default.is_ButonKatkiBosalt = ReadBooleanFromPLC[572];//%MX0.71.4
            Properties.M011_ButonLar.Default.is_ButonSuBosalt = ReadBooleanFromPLC[573];//%MX0.71.5
            Properties.M011_ButonLar.Default.is_ButonKatkiYikama = ReadBooleanFromPLC[574];//%MX0.71.6
            Properties.M011_ButonLar.Default.is_ButonMikserStop = ReadBooleanFromPLC[575];//%MX0.71.7
            Properties.M011_ButonLar.Default.is_ButonMikserStart = ReadBooleanFromPLC[576];//%MX0.72.0
            Properties.M011_ButonLar.Default.is_ButonMikserKapakAc = ReadBooleanFromPLC[577];//%MX0.72.1
            Properties.M011_ButonLar.Default.is_ButonMikserKapakKapak = ReadBooleanFromPLC[578];//%MX0.72.2
            Properties.M011_ButonLar.Default.is_ButonFiltre1 = ReadBooleanFromPLC[579];//%MX0.72.3
            Properties.M011_ButonLar.Default.is_ButonFiltre2 = ReadBooleanFromPLC[580];//%MX0.72.4
            Properties.M011_ButonLar.Default.is_ButonFiltre3 = ReadBooleanFromPLC[581];//%MX0.72.5
            Properties.M011_ButonLar.Default.is_ButonFiltre4 = ReadBooleanFromPLC[582];//%MX0.72.6
            Properties.M011_ButonLar.Default.is_ButonFiltre5 = ReadBooleanFromPLC[583];//%MX0.72.7
            Properties.M011_ButonLar.Default.is_ButonFiltre6 = ReadBooleanFromPLC[584];//%MX0.73.0
            Properties.M011_ButonLar.Default.is_ButonKovaYukari = ReadBooleanFromPLC[585];//%MX0.73.1
            Properties.M011_ButonLar.Default.is_ButonKovaAsagi = ReadBooleanFromPLC[586];//%MX0.73.2
            Properties.M011_ButonLar.Default.is_TransferBandButon = ReadBooleanFromPLC[587];//%MX0.73.3
            Properties.M011_ButonLar.Default.is_ButonTartiBand1 = ReadBooleanFromPLC[588];//%MX0.73.4
            Properties.M011_ButonLar.Default.is_ButonTartiBand1Vibrator = ReadBooleanFromPLC[589];//%MX0.73.5
            Properties.M011_ButonLar.Default.is_ButonAgrega1Vibrator = ReadBooleanFromPLC[590];//%MX0.73.6
            Properties.M011_ButonLar.Default.is_ButonAgrega2Vibrator = ReadBooleanFromPLC[591];//%MX0.73.7
            Properties.M011_ButonLar.Default.is_ButonAgrega3Vibrator = ReadBooleanFromPLC[592];//%MX0.74.0
            Properties.M011_ButonLar.Default.is_ButonAgrega4Vibrator = ReadBooleanFromPLC[593];//%MX0.74.1
            Properties.M011_ButonLar.Default.is_ButonAgrega5Vibrator = ReadBooleanFromPLC[594];//%MX0.74.2
            Properties.M011_ButonLar.Default.is_ButonAgrega6Vibrator = ReadBooleanFromPLC[595];//%MX0.74.3
            Properties.M011_ButonLar.Default.is_ButonAgrega7Vibrator = ReadBooleanFromPLC[596];//%MX0.74.4
            Properties.M011_ButonLar.Default.is_ButonAgrega8Vibrator = ReadBooleanFromPLC[597];//%MX0.74.5
            Properties.M011_ButonLar.Default.is_ButonSoklama = ReadBooleanFromPLC[598];//%MX0.74.6
            Properties.M011_ButonLar.Default.is_ButonKompresor = ReadBooleanFromPLC[599];//%MX0.74.7
            Properties.M011_ButonLar.Default.is_ButonKorna = ReadBooleanFromPLC[600];//%MX0.75.0
            Properties.M011_ButonLar.Default.is_ButonMikserBlokFiltre = ReadBooleanFromPLC[601];//%MX0.75.1
            Properties.M011_ButonLar.Default.Spare_195 = ReadBooleanFromPLC[602];//%MX0.75.2
            Properties.M011_ButonLar.Default.Spare_196 = ReadBooleanFromPLC[603];//%MX0.75.3
            Properties.M011_ButonLar.Default.Spare_197 = ReadBooleanFromPLC[604];//%MX0.75.4
            Properties.M011_ButonLar.Default.Spare_198 = ReadBooleanFromPLC[605];//%MX0.75.5
            Properties.M011_ButonLar.Default.Spare_199 = ReadBooleanFromPLC[606];//%MX0.75.6
            Properties.M011_ButonLar.Default.Spare_200 = ReadBooleanFromPLC[607];//%MX0.75.7
            Properties.M011_ButonLar.Default.Spare_201 = ReadBooleanFromPLC[608];//%MX0.76.0
            Properties.M011_ButonLar.Default.Spare_202 = ReadBooleanFromPLC[609];//%MX0.76.1
            Properties.M011_ButonLar.Default.Spare_203 = ReadBooleanFromPLC[610];//%MX0.76.2
            Properties.M011_ButonLar.Default.Spare_204 = ReadBooleanFromPLC[611];//%MX0.76.3
            Properties.M011_ButonLar.Default.Spare_205 = ReadBooleanFromPLC[612];//%MX0.76.4
            Properties.M011_ButonLar.Default.Spare_206 = ReadBooleanFromPLC[613];//%MX0.76.5
            Properties.M011_ButonLar.Default.Spare_207 = ReadBooleanFromPLC[614];//%MX0.76.6
            Properties.M011_ButonLar.Default.Spare_208 = ReadBooleanFromPLC[615];//%MX0.76.7
            Properties.M011_ButonLar.Default.Spare_209 = ReadBooleanFromPLC[616];//%MX0.77.0
            Properties.M011_ButonLar.Default.Spare_210 = ReadBooleanFromPLC[617];//%MX0.77.1
            Properties.M011_ButonLar.Default.Spare_211 = ReadBooleanFromPLC[618];//%MX0.77.2
            Properties.M011_ButonLar.Default.Spare_212 = ReadBooleanFromPLC[619];//%MX0.77.3
            Properties.M011_ButonLar.Default.Spare_213 = ReadBooleanFromPLC[620];//%MX0.77.4
            Properties.M011_ButonLar.Default.Spare_214 = ReadBooleanFromPLC[621];//%MX0.77.5
            Properties.M011_ButonLar.Default.Spare_215 = ReadBooleanFromPLC[622];//%MX0.77.6
            Properties.M011_ButonLar.Default.Spare_216 = ReadBooleanFromPLC[623];//%MX0.77.7
            Properties.M011_ButonLar.Default.Spare_217 = ReadBooleanFromPLC[624];//%MX0.78.0
            Properties.M011_ButonLar.Default.Spare_218 = ReadBooleanFromPLC[625];//%MX0.78.1
            Properties.M011_ButonLar.Default.Spare_219 = ReadBooleanFromPLC[626];//%MX0.78.2
            Properties.M011_ButonLar.Default.Spare_220 = ReadBooleanFromPLC[627];//%MX0.78.3
            Properties.M011_ButonLar.Default.Spare_221 = ReadBooleanFromPLC[628];//%MX0.78.4
            Properties.M011_ButonLar.Default.Spare_222 = ReadBooleanFromPLC[629];//%MX0.78.5
            Properties.M011_ButonLar.Default.Spare_223 = ReadBooleanFromPLC[630];//%MX0.78.6
            Properties.M011_ButonLar.Default.Spare_224 = ReadBooleanFromPLC[631];//%MX0.78.7
            Properties.M011_ButonLar.Default.Spare_225 = ReadBooleanFromPLC[632];//%MX0.79.0
            Properties.M011_ButonLar.Default.Spare_226 = ReadBooleanFromPLC[633];//%MX0.79.1
            Properties.M011_ButonLar.Default.Spare_227 = ReadBooleanFromPLC[634];//%MX0.79.2
            Properties.M011_ButonLar.Default.Spare_228 = ReadBooleanFromPLC[635];//%MX0.79.3
            Properties.M011_ButonLar.Default.Spare_229 = ReadBooleanFromPLC[636];//%MX0.79.4
            Properties.M011_ButonLar.Default.Spare_230 = ReadBooleanFromPLC[637];//%MX0.79.5
            Properties.M011_ButonLar.Default.Spare_231 = ReadBooleanFromPLC[638];//%MX0.79.6
            Properties.M011_ButonLar.Default.Spare_232 = ReadBooleanFromPLC[639];//%MX0.79.7
        }
    }
    
}
