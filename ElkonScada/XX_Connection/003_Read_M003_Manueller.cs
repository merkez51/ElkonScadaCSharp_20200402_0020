using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _003_Read_M003_Manueller
    {
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();
        public void Read_M003Manueller(bool[] ReadBooleanFromPLC,int[] ReadWordFromPLCPart3, int[] ReadWordFromPLCPart4)
        {

            Properties.M003_Manueller.Default.XB115_ManDaraAg1 = ReadWordFromPLCPart3[32];
            Properties.M003_Manueller.Default.XB115_ManDaraAg2 = ReadWordFromPLCPart3[33];
            Properties.M003_Manueller.Default.XB115_ManDaraAg3 = ReadWordFromPLCPart3[34];
            Properties.M003_Manueller.Default.XB115_ManDaraAg4 = ReadWordFromPLCPart3[35];
            Properties.M003_Manueller.Default.XB115_ManDaraAg5 = ReadWordFromPLCPart3[36];
            Properties.M003_Manueller.Default.XB115_ManDaraAg6 = ReadWordFromPLCPart3[37];
            Properties.M003_Manueller.Default.XB115_ManDaraAg7 = ReadWordFromPLCPart3[38];
            Properties.M003_Manueller.Default.XB115_ManDaraAg8 = ReadWordFromPLCPart3[39];

            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[40];
            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[41];
            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[42];
            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[43];
            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[44];
            Properties.M003_Manueller.Default.XB115_ManDaraCM1 = ReadWordFromPLCPart3[45];

            Properties.M003_Manueller.Default.XB115_ManDaraSu1 = ReadWordFromPLCPart3[46];
            Properties.M003_Manueller.Default.XB115_ManDaraSu2 = ReadWordFromPLCPart3[47];
            Properties.M003_Manueller.Default.XB115_ManDaraSu3 = ReadWordFromPLCPart3[48];
            Properties.M003_Manueller.Default.XB115_ManDaraSu4 = ReadWordFromPLCPart3[49];


            Properties.M003_Manueller.Default.XB115_ManDaraKatki1 = ToFloat.IntToFloat(ReadWordFromPLCPart3[56], ReadWordFromPLCPart3[57]);     //%MD0.228
            Properties.M003_Manueller.Default.XB115_ManDaraKatki2 = ToFloat.IntToFloat(ReadWordFromPLCPart3[58], ReadWordFromPLCPart3[59]);    //%MD0.229
            Properties.M003_Manueller.Default.XB115_ManDaraKatki3 = ToFloat.IntToFloat(ReadWordFromPLCPart3[60], ReadWordFromPLCPart3[61]);     //%MD0.230
            Properties.M003_Manueller.Default.XB115_ManDaraKatki4 = ToFloat.IntToFloat(ReadWordFromPLCPart3[62], ReadWordFromPLCPart3[63]);    //%MD0.231
            Properties.M003_Manueller.Default.XB115_ManDaraKatki5 = ToFloat.IntToFloat(ReadWordFromPLCPart3[64], ReadWordFromPLCPart3[65]);    //%MD0.232
            Properties.M003_Manueller.Default.XB115_ManDaraKatki6 = ToFloat.IntToFloat(ReadWordFromPLCPart3[66], ReadWordFromPLCPart3[67]);    //%MD0.233

            Properties.M003_Manueller.Default.XB19_Agrega1ManualAraUretim = ReadWordFromPLCPart3[8]; //MW0.308
            Properties.M003_Manueller.Default.XB19_Agrega2ManualAraUretim = ReadWordFromPLCPart3[9]; //MW0.309
            Properties.M003_Manueller.Default.XB19_Agrega3ManualAraUretim = ReadWordFromPLCPart3[10]; //MW0.310
            Properties.M003_Manueller.Default.XB19_Agrega4ManualAraUretim = ReadWordFromPLCPart3[11]; //MW0.311
            Properties.M003_Manueller.Default.XB19_Agrega5ManualAraUretim = ReadWordFromPLCPart3[12]; //MW0.312
            Properties.M003_Manueller.Default.XB19_Agrega6ManualAraUretim = ReadWordFromPLCPart3[13]; //MW0.313
            Properties.M003_Manueller.Default.XB19_Agrega7ManualAraUretim = ReadWordFromPLCPart3[14]; //MW0.314
            Properties.M003_Manueller.Default.XB19_Agrega8ManualAraUretim = ReadWordFromPLCPart3[15]; //MW0.315

            Properties.M003_Manueller.Default.XB19_Cimento1ManualAraUretim = ReadWordFromPLCPart3[16]; //MW0.316
            Properties.M003_Manueller.Default.XB19_Cimento2ManualAraUretim = ReadWordFromPLCPart3[17]; //MW0.317
            Properties.M003_Manueller.Default.XB19_Cimento3ManualAraUretim = ReadWordFromPLCPart3[18]; //MW0.318
            Properties.M003_Manueller.Default.XB19_Cimento4ManualAraUretim = ReadWordFromPLCPart3[19]; //MW0.319
            Properties.M003_Manueller.Default.XB19_Cimento5ManualAraUretim = ReadWordFromPLCPart3[20]; //MW0.320
            Properties.M003_Manueller.Default.XB19_Cimento6ManualAraUretim = ReadWordFromPLCPart3[21]; //MW0.321

            Properties.M003_Manueller.Default.XB19_Su1ManualAraUretim = ReadWordFromPLCPart3[22]; //MW0.322
            Properties.M003_Manueller.Default.XB19_Su2ManualAraUretim = ReadWordFromPLCPart3[23]; //MW0.323
            Properties.M003_Manueller.Default.XB19_Su3ManualAraUretim = ReadWordFromPLCPart3[24]; //MW0.324
            Properties.M003_Manueller.Default.XB19_Su4ManualAraUretim = ReadWordFromPLCPart3[25]; //MW0.325


            Properties.M003_Manueller.Default.XB115_Ag1ManAl = ReadBooleanFromPLC[64];//%MX0.8.0
            Properties.M003_Manueller.Default.XB115_Ag2ManAl = ReadBooleanFromPLC[65];//%MX0.8.1
            Properties.M003_Manueller.Default.XB115_Ag3ManAl = ReadBooleanFromPLC[66];//%MX0.8.2
            Properties.M003_Manueller.Default.XB115_Ag4ManAl = ReadBooleanFromPLC[67];//%MX0.8.3
            Properties.M003_Manueller.Default.XB115_Ag5ManAl = ReadBooleanFromPLC[68];//%MX0.8.4
            Properties.M003_Manueller.Default.XB115_Ag6ManAl = ReadBooleanFromPLC[69];//%MX0.8.5
            Properties.M003_Manueller.Default.XB115_Ag7ManAl = ReadBooleanFromPLC[70];//%MX0.8.6
            Properties.M003_Manueller.Default.XB115_Ag8ManAl = ReadBooleanFromPLC[71];//%MX0.8.7
            Properties.M003_Manueller.Default.XB115_CM1ManAl = ReadBooleanFromPLC[72];//%MX0.9.0
            Properties.M003_Manueller.Default.XB115_CM2ManAl = ReadBooleanFromPLC[73];//%MX0.9.1
            Properties.M003_Manueller.Default.XB115_CM3ManAl = ReadBooleanFromPLC[74];//%MX0.9.2
            Properties.M003_Manueller.Default.XB115_CM4ManAl = ReadBooleanFromPLC[75];//%MX0.9.3
            Properties.M003_Manueller.Default.XB115_CM5ManAl = ReadBooleanFromPLC[76];//%MX0.9.4
            Properties.M003_Manueller.Default.XB115_CM6ManAl = ReadBooleanFromPLC[77];//%MX0.9.5
            Properties.M003_Manueller.Default.XB115_K1ManAl = ReadBooleanFromPLC[78];//%MX0.9.6
            Properties.M003_Manueller.Default.XB115_K2ManAl = ReadBooleanFromPLC[79];//%MX0.9.7
            Properties.M003_Manueller.Default.XB115_K3ManAl = ReadBooleanFromPLC[80];//%MX0.10.0
            Properties.M003_Manueller.Default.XB115_K4ManAl = ReadBooleanFromPLC[81];//%MX0.10.1
            Properties.M003_Manueller.Default.XB115_K5ManAl = ReadBooleanFromPLC[82];//%MX0.10.2
            Properties.M003_Manueller.Default.XB115_K6ManAl = ReadBooleanFromPLC[83];//%MX0.10.3
            Properties.M003_Manueller.Default.XB115_Su1ManAl = ReadBooleanFromPLC[84];//%MX0.10.4
            Properties.M003_Manueller.Default.XB115_Su2ManAl = ReadBooleanFromPLC[85];//%MX0.10.5
            Properties.M003_Manueller.Default.XB115_Su3ManAl = ReadBooleanFromPLC[86];//%MX0.10.6
            Properties.M003_Manueller.Default.XB115_Su4ManAl = ReadBooleanFromPLC[87];//%MX0.10.7
            Properties.M003_Manueller.Default.Spare_14 = ReadBooleanFromPLC[88];//%MX0.11.0
            Properties.M003_Manueller.Default.Spare_15 = ReadBooleanFromPLC[89];//%MX0.11.1
            Properties.M003_Manueller.Default.Spare_16 = ReadBooleanFromPLC[90];//%MX0.11.2
            Properties.M003_Manueller.Default.Spare_17 = ReadBooleanFromPLC[91];//%MX0.11.3
            Properties.M003_Manueller.Default.Spare_18 = ReadBooleanFromPLC[92];//%MX0.11.4
            Properties.M003_Manueller.Default.Spare_19 = ReadBooleanFromPLC[93];//%MX0.11.5
            Properties.M003_Manueller.Default.Spare_20 = ReadBooleanFromPLC[94];//%MX0.11.6
            Properties.M003_Manueller.Default.Spare_21 = ReadBooleanFromPLC[95];//%MX0.11.7
            Properties.M003_Manueller.Default.XB19_Agrega1OtoUretimKayit = ReadBooleanFromPLC[96];//%MX0.12.0
            Properties.M003_Manueller.Default.XB19_Agrega2OtoUretimKayit = ReadBooleanFromPLC[97];//%MX0.12.1
            Properties.M003_Manueller.Default.XB19_Agrega3OtoUretimKayit = ReadBooleanFromPLC[98];//%MX0.12.2
            Properties.M003_Manueller.Default.XB19_Agrega4OtoUretimKayit = ReadBooleanFromPLC[99];//%MX0.12.3
            Properties.M003_Manueller.Default.XB19_Agrega5OtoUretimKayit = ReadBooleanFromPLC[100];//%MX0.12.4
            Properties.M003_Manueller.Default.XB19_Agrega6OtoUretimKayit = ReadBooleanFromPLC[101];//%MX0.12.5
            Properties.M003_Manueller.Default.XB19_Agrega7OtoUretimKayit = ReadBooleanFromPLC[102];//%MX0.12.6
            Properties.M003_Manueller.Default.XB19_Agrega8OtoUretimKayit = ReadBooleanFromPLC[103];//%MX0.12.7
            Properties.M003_Manueller.Default.XB19_Cimento1OtoUretimKayit = ReadBooleanFromPLC[104];//%MX0.13.0
            Properties.M003_Manueller.Default.XB19_Cimento2OtoUretimKayit = ReadBooleanFromPLC[105];//%MX0.13.1
            Properties.M003_Manueller.Default.XB19_Cimento3OtoUretimKayit = ReadBooleanFromPLC[106];//%MX0.13.2
            Properties.M003_Manueller.Default.XB19_Cimento4OtoUretimKayit = ReadBooleanFromPLC[107];//%MX0.13.3
            Properties.M003_Manueller.Default.XB19_Cimento5OtoUretimKayit = ReadBooleanFromPLC[108];//%MX0.13.4
            Properties.M003_Manueller.Default.XB19_Cimento6OtoUretimKayit = ReadBooleanFromPLC[109];//%MX0.13.5
            Properties.M003_Manueller.Default.XB19_Su1OtoUretimKayit = ReadBooleanFromPLC[110];//%MX0.13.6
            Properties.M003_Manueller.Default.XB19_Su2OtoUretimKayit = ReadBooleanFromPLC[111];//%MX0.13.7
            Properties.M003_Manueller.Default.XB19_Su3OtoUretimKayit = ReadBooleanFromPLC[112];//%MX0.14.0
            Properties.M003_Manueller.Default.XB19_Su4OtoUretimKayit = ReadBooleanFromPLC[113];//%MX0.14.1
            Properties.M003_Manueller.Default.XB19_Katki1OtoUretimKayit = ReadBooleanFromPLC[114];//%MX0.14.2
            Properties.M003_Manueller.Default.XB19_Katki2OtoUretimKayit = ReadBooleanFromPLC[115];//%MX0.14.3
            Properties.M003_Manueller.Default.XB19_Katki3OtoUretimKayit = ReadBooleanFromPLC[116];//%MX0.14.4
            Properties.M003_Manueller.Default.XB19_Katki4OtoUretimKayit = ReadBooleanFromPLC[117];//%MX0.14.5
            Properties.M003_Manueller.Default.XB19_Katki5OtoUretimKayit = ReadBooleanFromPLC[118];//%MX0.14.6
            Properties.M003_Manueller.Default.XB19_Katki6OtoUretimKayit = ReadBooleanFromPLC[119];//%MX0.14.7
            Properties.M003_Manueller.Default.Spare_22 = ReadBooleanFromPLC[120];//%MX0.15.0
            Properties.M003_Manueller.Default.Spare_23 = ReadBooleanFromPLC[121];//%MX0.15.1
            Properties.M003_Manueller.Default.Spare_24 = ReadBooleanFromPLC[122];//%MX0.15.2
            Properties.M003_Manueller.Default.Spare_25 = ReadBooleanFromPLC[123];//%MX0.15.3
            Properties.M003_Manueller.Default.Spare_26 = ReadBooleanFromPLC[124];//%MX0.15.4
            Properties.M003_Manueller.Default.Spare_27 = ReadBooleanFromPLC[125];//%MX0.15.5
            Properties.M003_Manueller.Default.Spare_28 = ReadBooleanFromPLC[126];//%MX0.15.6
            Properties.M003_Manueller.Default.Spare_29 = ReadBooleanFromPLC[127];//%MX0.15.7
            Properties.M003_Manueller.Default.XB115_Ag1DaraAl = ReadBooleanFromPLC[128];//%MX0.16.0
            Properties.M003_Manueller.Default.XB115_Ag2DaraAl = ReadBooleanFromPLC[129];//%MX0.16.1
            Properties.M003_Manueller.Default.XB115_Ag3DaraAl = ReadBooleanFromPLC[130];//%MX0.16.2
            Properties.M003_Manueller.Default.XB115_Ag4DaraAl = ReadBooleanFromPLC[131];//%MX0.16.3
            Properties.M003_Manueller.Default.XB115_Ag5DaraAl = ReadBooleanFromPLC[132];//%MX0.16.4
            Properties.M003_Manueller.Default.XB115_Ag6DaraAl = ReadBooleanFromPLC[133];//%MX0.16.5
            Properties.M003_Manueller.Default.XB115_Ag7DaraAl = ReadBooleanFromPLC[134];//%MX0.16.6
            Properties.M003_Manueller.Default.XB115_Ag8DaraAl = ReadBooleanFromPLC[135];//%MX0.16.7
            Properties.M003_Manueller.Default.XB115_CM1DaraAl = ReadBooleanFromPLC[136];//%MX0.17.0
            Properties.M003_Manueller.Default.XB115_CM2DaraAl = ReadBooleanFromPLC[137];//%MX0.17.1
            Properties.M003_Manueller.Default.XB115_CM3DaraAl = ReadBooleanFromPLC[138];//%MX0.17.2
            Properties.M003_Manueller.Default.XB115_CM4DaraAl = ReadBooleanFromPLC[139];//%MX0.17.3
            Properties.M003_Manueller.Default.XB115_CM5DaraAl = ReadBooleanFromPLC[140];//%MX0.17.4
            Properties.M003_Manueller.Default.XB115_CM6DaraAl = ReadBooleanFromPLC[141];//%MX0.17.5
            Properties.M003_Manueller.Default.XB115_Su1DaraAl = ReadBooleanFromPLC[142];//%MX0.17.6
            Properties.M003_Manueller.Default.XB115_Su2DaraAl = ReadBooleanFromPLC[143];//%MX0.17.7
            Properties.M003_Manueller.Default.XB115_Su3DaraAl = ReadBooleanFromPLC[144];//%MX0.18.0
            Properties.M003_Manueller.Default.XB115_Su4DaraAl = ReadBooleanFromPLC[145];//%MX0.18.1
            Properties.M003_Manueller.Default.XB115_K1DaraAl = ReadBooleanFromPLC[146];//%MX0.18.2
            Properties.M003_Manueller.Default.XB115_K2DaraAl = ReadBooleanFromPLC[147];//%MX0.18.3
            Properties.M003_Manueller.Default.XB115_K3DaraAl = ReadBooleanFromPLC[148];//%MX0.18.4
            Properties.M003_Manueller.Default.XB115_K4DaraAl = ReadBooleanFromPLC[149];//%MX0.18.5
            Properties.M003_Manueller.Default.XB115_K5DaraAl = ReadBooleanFromPLC[150];//%MX0.18.6
            Properties.M003_Manueller.Default.XB115_K6DaraAl = ReadBooleanFromPLC[151];//%MX0.18.7
            Properties.M003_Manueller.Default.Spare_30 = ReadBooleanFromPLC[152];//%MX0.19.0
            Properties.M003_Manueller.Default.Spare_31 = ReadBooleanFromPLC[153];//%MX0.19.1
            Properties.M003_Manueller.Default.Spare_32 = ReadBooleanFromPLC[154];//%MX0.19.2
            Properties.M003_Manueller.Default.Spare_33 = ReadBooleanFromPLC[155];//%MX0.19.3
            Properties.M003_Manueller.Default.Spare_34 = ReadBooleanFromPLC[156];//%MX0.19.4
            Properties.M003_Manueller.Default.Spare_35 = ReadBooleanFromPLC[157];//%MX0.19.5
            Properties.M003_Manueller.Default.Spare_36 = ReadBooleanFromPLC[158];//%MX0.19.6
            Properties.M003_Manueller.Default.Spare_37 = ReadBooleanFromPLC[159];//%MX0.19.7
            Properties.M003_Manueller.Default.XB115_Ag1KayitAl = ReadBooleanFromPLC[160];//%MX0.20.0
            Properties.M003_Manueller.Default.XB115_Ag2KayitAl = ReadBooleanFromPLC[161];//%MX0.20.1
            Properties.M003_Manueller.Default.XB115_Ag3KayitAl = ReadBooleanFromPLC[162];//%MX0.20.2
            Properties.M003_Manueller.Default.XB115_Ag4KayitAl = ReadBooleanFromPLC[163];//%MX0.20.3
            Properties.M003_Manueller.Default.XB115_Ag5KayitAl = ReadBooleanFromPLC[164];//%MX0.20.4
            Properties.M003_Manueller.Default.XB115_Ag6KayitAl = ReadBooleanFromPLC[165];//%MX0.20.5
            Properties.M003_Manueller.Default.XB115_Ag7KayitAl = ReadBooleanFromPLC[166];//%MX0.20.6
            Properties.M003_Manueller.Default.XB115_Ag8KayitAl = ReadBooleanFromPLC[167];//%MX0.20.7
            Properties.M003_Manueller.Default.XB115_CM1KayitAl = ReadBooleanFromPLC[168];//%MX0.21.0
            Properties.M003_Manueller.Default.XB115_CM2KayitAl = ReadBooleanFromPLC[169];//%MX0.21.1
            Properties.M003_Manueller.Default.XB115_CM3KayitAl = ReadBooleanFromPLC[170];//%MX0.21.2
            Properties.M003_Manueller.Default.XB115_CM4KayitAl = ReadBooleanFromPLC[171];//%MX0.21.3
            Properties.M003_Manueller.Default.XB115_CM5KayitAl = ReadBooleanFromPLC[172];//%MX0.21.4
            Properties.M003_Manueller.Default.XB115_CM6KayitAl = ReadBooleanFromPLC[173];//%MX0.21.5
            Properties.M003_Manueller.Default.XB115_Su1KayitAl = ReadBooleanFromPLC[174];//%MX0.21.6
            Properties.M003_Manueller.Default.XB115_Su2KayitAl = ReadBooleanFromPLC[175];//%MX0.21.7
            Properties.M003_Manueller.Default.XB115_Su3KayitAl = ReadBooleanFromPLC[176];//%MX0.22.0
            Properties.M003_Manueller.Default.XB115_Su4KayitAl = ReadBooleanFromPLC[177];//%MX0.22.1
            Properties.M003_Manueller.Default.XB115_K1KayitAl = ReadBooleanFromPLC[178];//%MX0.22.2
            Properties.M003_Manueller.Default.XB115_K2KayitAl = ReadBooleanFromPLC[179];//%MX0.22.3
            Properties.M003_Manueller.Default.XB115_K3KayitAl = ReadBooleanFromPLC[180];//%MX0.22.4
            Properties.M003_Manueller.Default.XB115_K4KayitAl = ReadBooleanFromPLC[181];//%MX0.22.5
            Properties.M003_Manueller.Default.XB115_K5KayitAl = ReadBooleanFromPLC[182];//%MX0.22.6
            Properties.M003_Manueller.Default.XB115_K6KayitAl = ReadBooleanFromPLC[183];//%MX0.22.7
            Properties.M003_Manueller.Default.Spare_38 = ReadBooleanFromPLC[184];//%MX0.23.0
            Properties.M003_Manueller.Default.Spare_39 = ReadBooleanFromPLC[185];//%MX0.23.1
            Properties.M003_Manueller.Default.Spare_40 = ReadBooleanFromPLC[186];//%MX0.23.2
            Properties.M003_Manueller.Default.Spare_41 = ReadBooleanFromPLC[187];//%MX0.23.3
            Properties.M003_Manueller.Default.Spare_42 = ReadBooleanFromPLC[188];//%MX0.23.4
            Properties.M003_Manueller.Default.Spare_43 = ReadBooleanFromPLC[189];//%MX0.23.5
            Properties.M003_Manueller.Default.Spare_44 = ReadBooleanFromPLC[190];//%MX0.23.6
            Properties.M003_Manueller.Default.Spare_45 = ReadBooleanFromPLC[191];//%MX0.23.7
            Properties.M003_Manueller.Default.v_Ag1VibratorluBeslemeBolgesinde = ReadBooleanFromPLC[192];//%MX0.24.0
            Properties.M003_Manueller.Default.v_Ag2VibratorluBeslemeBolgesinde = ReadBooleanFromPLC[193];//%MX0.24.1
            Properties.M003_Manueller.Default.v_Ag3VibratorluBeslemeBolgesinde = ReadBooleanFromPLC[194];//%MX0.24.2
            Properties.M003_Manueller.Default.v_Ag4VibratorluBeslemeBolgesinde = ReadBooleanFromPLC[195];//%MX0.24.3
            Properties.M003_Manueller.Default.v_ArizaLambaPulse = ReadBooleanFromPLC[196];//%MX0.24.4
            Properties.M003_Manueller.Default.Saniye = ReadBooleanFromPLC[197];//%MX0.24.5
            Properties.M003_Manueller.Default.DataChange = ReadBooleanFromPLC[198];//%MX0.24.6
            Properties.M003_Manueller.Default.DB250_OzelIptal = ReadBooleanFromPLC[199];//%MX0.24.7
            Properties.M003_Manueller.Default.s_ZamanSenkronizasyonuSaglandi = ReadBooleanFromPLC[200];//%MX0.25.0
            Properties.M003_Manueller.Default.Spare_46 = ReadBooleanFromPLC[201];//%MX0.25.1
            Properties.M003_Manueller.Default.Spare_47 = ReadBooleanFromPLC[202];//%MX0.25.2
            Properties.M003_Manueller.Default.Spare_48 = ReadBooleanFromPLC[203];//%MX0.25.3
            Properties.M003_Manueller.Default.Spare_49 = ReadBooleanFromPLC[204];//%MX0.25.4
            Properties.M003_Manueller.Default.Spare_50 = ReadBooleanFromPLC[205];//%MX0.25.5
            Properties.M003_Manueller.Default.Spare_51 = ReadBooleanFromPLC[206];//%MX0.25.6
            Properties.M003_Manueller.Default.Spare_52 = ReadBooleanFromPLC[207];//%MX0.25.7

            Properties.M003_Manueller.Default.XB19_Katki1ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[30], ReadWordFromPLCPart4[31]);     //%MD0.215
            Properties.M003_Manueller.Default.XB19_Katki2ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[32], ReadWordFromPLCPart4[33]);    //%MD0.216
            Properties.M003_Manueller.Default.XB19_Katki3ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[34], ReadWordFromPLCPart4[35]);     //%MD0.217
            Properties.M003_Manueller.Default.XB19_Katki4ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[36], ReadWordFromPLCPart4[37]);    //%MD0.218
            Properties.M003_Manueller.Default.XB19_Katki5ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[38], ReadWordFromPLCPart4[39]);    //%MD0.219
            Properties.M003_Manueller.Default.XB19_Katki6ManualAraUretim = ToFloat.IntToFloat(ReadWordFromPLCPart4[40], ReadWordFromPLCPart4[41]);    //%MD0.220
        }
    }
}
