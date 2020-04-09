using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class _101_Read_M101_Array
    {
      
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();

      
        public void Read_M101Array(int[] MSVU_Sanal,int[] MSTI_Sanal,int[] MSMUM_Sanal,int[] MSYM_Sanal,int[] SanalMemeory_ZamanTarihDizisi)
        {

            //VerilenUrunBilgileri

            Properties.M101_Array.Default.Verilen_Agrega1_ArrayCount_01 = ToFloat.IntToFloat(MSVU_Sanal[2], MSVU_Sanal[3]); //MD1101
            Properties.M101_Array.Default.Verilen_Agrega2_ArrayCount_02 = ToFloat.IntToFloat(MSVU_Sanal[4], MSVU_Sanal[5]);//MD1102
            Properties.M101_Array.Default.Verilen_Agrega3_ArrayCount_03 = ToFloat.IntToFloat(MSVU_Sanal[6], MSVU_Sanal[7]);//MD1103
            Properties.M101_Array.Default.Verilen_Agrega4_ArrayCount_04 = ToFloat.IntToFloat(MSVU_Sanal[8], MSVU_Sanal[8]);//MD1104
            Properties.M101_Array.Default.Verilen_Agrega5_ArrayCount_05 = ToFloat.IntToFloat(MSVU_Sanal[10], MSVU_Sanal[9]);//MD1105

            Properties.M101_Array.Default.Verilen_Cimento1_ArrayCount_11 = ToFloat.IntToFloat(MSVU_Sanal[22], MSVU_Sanal[23]);//MD1111
            Properties.M101_Array.Default.Verilen_Cimento2_ArrayCount_12 = ToFloat.IntToFloat(MSVU_Sanal[24], MSVU_Sanal[25]);//MD1112
            Properties.M101_Array.Default.Verilen_Cimento3_ArrayCount_13 = ToFloat.IntToFloat(MSVU_Sanal[26], MSVU_Sanal[27]);//MD1113
            Properties.M101_Array.Default.Verilen_Cimento4_ArrayCount_14 = ToFloat.IntToFloat(MSVU_Sanal[28], MSVU_Sanal[29]);//MD1114
            Properties.M101_Array.Default.Verilen_Cimento5_ArrayCount_15 = ToFloat.IntToFloat(MSVU_Sanal[30], MSVU_Sanal[31]);//MD1115

            Properties.M101_Array.Default.Verilen_Su1_ArrayCount_31 = ToFloat.IntToFloat(MSVU_Sanal[62], MSVU_Sanal[63]);//MD1131
            Properties.M101_Array.Default.Verilen_Su2_ArrayCount_32 = ToFloat.IntToFloat(MSVU_Sanal[64], MSVU_Sanal[65]);//MD1132
            Properties.M101_Array.Default.Verilen_Su3_ArrayCount_33 = ToFloat.IntToFloat(MSVU_Sanal[66], MSVU_Sanal[67]);//MD1133

            Properties.M101_Array.Default.Verilen_Katki1_ArrayCount_21 = ToFloat.IntToFloat(MSVU_Sanal[42], MSVU_Sanal[43]);//MD1121
            Properties.M101_Array.Default.Verilen_Katki2_ArrayCount_22 = ToFloat.IntToFloat(MSVU_Sanal[44], MSVU_Sanal[45]);//MD1122
            Properties.M101_Array.Default.Verilen_Katki3_ArrayCount_23 = ToFloat.IntToFloat(MSVU_Sanal[46], MSVU_Sanal[47]);//MD1123
            Properties.M101_Array.Default.Verilen_Katki4_ArrayCount_24 = ToFloat.IntToFloat(MSVU_Sanal[48], MSVU_Sanal[49]);//MD1124
            Properties.M101_Array.Default.Verilen_Katki5_ArrayCount_25 = ToFloat.IntToFloat(MSVU_Sanal[50], MSVU_Sanal[51]);//MD1125


            //Toplam istenen ürün bilgileri

            Properties.M101_Array.Default.ToplamIstenen_Agrega1_ArrayCount_1 = ToFloat.IntToFloat(MSTI_Sanal[2], MSTI_Sanal[3]); //MD1201
            Properties.M101_Array.Default.ToplamIstenen_Agrega2_ArrayCount_2 = ToFloat.IntToFloat(MSTI_Sanal[4], MSTI_Sanal[5]);//MD1202
            Properties.M101_Array.Default.ToplamIstenen_Agrega3_ArrayCount_3 = ToFloat.IntToFloat(MSTI_Sanal[6], MSTI_Sanal[7]);//MD1203
            Properties.M101_Array.Default.ToplamIstenen_Agrega4_ArrayCount_4 = ToFloat.IntToFloat(MSTI_Sanal[8], MSTI_Sanal[8]);//MD1204
            Properties.M101_Array.Default.ToplamIstenen_Agrega5_ArrayCount_5 = ToFloat.IntToFloat(MSTI_Sanal[10], MSTI_Sanal[9]);//MD1205

            Properties.M101_Array.Default.ToplamIstenen_Cimento1_ArrayCount_11 = ToFloat.IntToFloat(MSTI_Sanal[22], MSTI_Sanal[23]);//MD1211
            Properties.M101_Array.Default.ToplamIstenen_Cimento2_ArrayCount_12 = ToFloat.IntToFloat(MSTI_Sanal[24], MSTI_Sanal[25]);//MD1212
            Properties.M101_Array.Default.ToplamIstenen_Cimento3_ArrayCount_13 = ToFloat.IntToFloat(MSTI_Sanal[26], MSTI_Sanal[27]);//MD1213
            Properties.M101_Array.Default.ToplamIstenen_Cimento4_ArrayCount_14 = ToFloat.IntToFloat(MSTI_Sanal[28], MSTI_Sanal[29]);//MD1214
            Properties.M101_Array.Default.ToplamIstenen_Cimento5_ArrayCount_15 = ToFloat.IntToFloat(MSTI_Sanal[30], MSTI_Sanal[31]);//MD1215


            Properties.M101_Array.Default.ToplamIstenen_Su1_ArrayCount_31 = ToFloat.IntToFloat(MSTI_Sanal[62], MSTI_Sanal[63]);//MD1231
            Properties.M101_Array.Default.ToplamIstenen_Su2_ArrayCount_32 = ToFloat.IntToFloat(MSTI_Sanal[64], MSTI_Sanal[65]);//MD1232
            Properties.M101_Array.Default.ToplamIstenen_Su3_ArrayCount_33 = ToFloat.IntToFloat(MSTI_Sanal[66], MSTI_Sanal[67]);//MD1233

            Properties.M101_Array.Default.ToplamIstenen_Katki1_ArrayCount_21 = ToFloat.IntToFloat(MSTI_Sanal[42], MSTI_Sanal[43]);//MD1221
            Properties.M101_Array.Default.ToplamIstenen_Katki2_ArrayCount_22 = ToFloat.IntToFloat(MSTI_Sanal[44], MSTI_Sanal[45]);//MD1222
            Properties.M101_Array.Default.ToplamIstenen_Katki3_ArrayCount_23 = ToFloat.IntToFloat(MSTI_Sanal[46], MSTI_Sanal[47]);//MD1223
            Properties.M101_Array.Default.ToplamIstenen_Katki4_ArrayCount_24 = ToFloat.IntToFloat(MSTI_Sanal[48], MSTI_Sanal[49]);//MD1224
            Properties.M101_Array.Default.ToplamIstenen_Katki5_ArrayCount_25 = ToFloat.IntToFloat(MSTI_Sanal[50], MSTI_Sanal[51]);//MD1225

            //Manuel Üretim Miktari

            Properties.M101_Array.Default.ManualUretimMiktari_Agrega1_ArrayCount_1 = ToFloat.IntToFloat(MSMUM_Sanal[2], MSMUM_Sanal[3]); //MD1201
            Properties.M101_Array.Default.ManualUretimMiktari_Agrega2_ArrayCount_2 = ToFloat.IntToFloat(MSMUM_Sanal[4], MSMUM_Sanal[5]);//MD1202
            Properties.M101_Array.Default.ManualUretimMiktari_Agrega3_ArrayCount_3 = ToFloat.IntToFloat(MSMUM_Sanal[6], MSMUM_Sanal[7]);//MD1203
            Properties.M101_Array.Default.ManualUretimMiktari_Agrega4_ArrayCount_4 = ToFloat.IntToFloat(MSMUM_Sanal[8], MSMUM_Sanal[8]);//MD1204
            Properties.M101_Array.Default.ManualUretimMiktari_Agrega5_ArrayCount_5 = ToFloat.IntToFloat(MSMUM_Sanal[10], MSMUM_Sanal[9]);//MD1205

            Properties.M101_Array.Default.ManualUretimMiktari_Cimento1_ArrayCount_11 = ToFloat.IntToFloat(MSMUM_Sanal[22], MSMUM_Sanal[23]);//MD1211
            Properties.M101_Array.Default.ManualUretimMiktari_Cimento2_ArrayCount_12 = ToFloat.IntToFloat(MSMUM_Sanal[24], MSMUM_Sanal[25]);//MD1212
            Properties.M101_Array.Default.ManualUretimMiktari_Cimento3_ArrayCount_13 = ToFloat.IntToFloat(MSMUM_Sanal[26], MSMUM_Sanal[27]);//MD1213
            Properties.M101_Array.Default.ManualUretimMiktari_Cimento4_ArrayCount_14 = ToFloat.IntToFloat(MSMUM_Sanal[28], MSMUM_Sanal[29]);//MD1214
            Properties.M101_Array.Default.ManualUretimMiktari_Cimento5_ArrayCount_15 = ToFloat.IntToFloat(MSMUM_Sanal[30], MSMUM_Sanal[31]);//MD1215


            Properties.M101_Array.Default.ManualUretimMiktari_Su1_ArrayCount_31 = ToFloat.IntToFloat(MSMUM_Sanal[62], MSMUM_Sanal[63]);//MD1231
            Properties.M101_Array.Default.ManualUretimMiktari_Su2_ArrayCount_32 = ToFloat.IntToFloat(MSMUM_Sanal[64], MSMUM_Sanal[65]);//MD1232
            Properties.M101_Array.Default.ManualUretimMiktari_Su3_ArrayCount_33 = ToFloat.IntToFloat(MSMUM_Sanal[66], MSMUM_Sanal[67]);//MD1233

            Properties.M101_Array.Default.ManualUretimMiktari_Katki1_ArrayCount_21 = ToFloat.IntToFloat(MSMUM_Sanal[42], MSMUM_Sanal[43]);//MD1221
            Properties.M101_Array.Default.ManualUretimMiktari_Katki2_ArrayCount_22 = ToFloat.IntToFloat(MSMUM_Sanal[44], MSMUM_Sanal[45]);//MD1222
            Properties.M101_Array.Default.ManualUretimMiktari_Katki3_ArrayCount_23 = ToFloat.IntToFloat(MSMUM_Sanal[46], MSMUM_Sanal[47]);//MD1223
            Properties.M101_Array.Default.ManualUretimMiktari_Katki4_ArrayCount_24 = ToFloat.IntToFloat(MSMUM_Sanal[48], MSMUM_Sanal[49]);//MD1224
            Properties.M101_Array.Default.ManualUretimMiktari_Katki5_ArrayCount_25 = ToFloat.IntToFloat(MSMUM_Sanal[50], MSMUM_Sanal[51]);//MD1225

            //YariOto Üretim Miktari

            Properties.M101_Array.Default.YariOtoUretimMiktari_Agrega1_ArrayCount_1 = ToFloat.IntToFloat(MSYM_Sanal[2], MSYM_Sanal[3]); //MD1201
            Properties.M101_Array.Default.YariOtoUretimMiktari_Agrega2_ArrayCount_2 = ToFloat.IntToFloat(MSYM_Sanal[4], MSYM_Sanal[5]);//MD1202
            Properties.M101_Array.Default.YariOtoUretimMiktari_Agrega3_ArrayCount_3 = ToFloat.IntToFloat(MSYM_Sanal[6], MSYM_Sanal[7]);//MD1203
            Properties.M101_Array.Default.YariOtoUretimMiktari_Agrega4_ArrayCount_4 = ToFloat.IntToFloat(MSYM_Sanal[8], MSYM_Sanal[8]);//MD1204
            Properties.M101_Array.Default.YariOtoUretimMiktari_Agrega5_ArrayCount_5 = ToFloat.IntToFloat(MSYM_Sanal[10], MSYM_Sanal[9]);//MD1205

            Properties.M101_Array.Default.YariOtoUretimMiktari_Cimento1_ArrayCount_11 = ToFloat.IntToFloat(MSYM_Sanal[22], MSYM_Sanal[23]);//MD1211
            Properties.M101_Array.Default.YariOtoUretimMiktari_Cimento2_ArrayCount_12 = ToFloat.IntToFloat(MSYM_Sanal[24], MSYM_Sanal[25]);//MD1212
            Properties.M101_Array.Default.YariOtoUretimMiktari_Cimento3_ArrayCount_13 = ToFloat.IntToFloat(MSYM_Sanal[26], MSYM_Sanal[27]);//MD1213
            Properties.M101_Array.Default.YariOtoUretimMiktari_Cimento4_ArrayCount_14 = ToFloat.IntToFloat(MSYM_Sanal[28], MSYM_Sanal[29]);//MD1214
            Properties.M101_Array.Default.YariOtoUretimMiktari_Cimento5_ArrayCount_15 = ToFloat.IntToFloat(MSYM_Sanal[30], MSYM_Sanal[31]);//MD1215


            Properties.M101_Array.Default.YariOtoUretimMiktari_Su1_ArrayCount_31 = ToFloat.IntToFloat(MSYM_Sanal[62], MSYM_Sanal[63]);//MD1231
            Properties.M101_Array.Default.YariOtoUretimMiktari_Su2_ArrayCount_32 = ToFloat.IntToFloat(MSYM_Sanal[64], MSYM_Sanal[65]);//MD1232
            Properties.M101_Array.Default.YariOtoUretimMiktari_Su3_ArrauCount_33 = ToFloat.IntToFloat(MSYM_Sanal[66], MSYM_Sanal[67]);//MD1233

            Properties.M101_Array.Default.YariOtoUretimMiktari_Katki1_ArrayCount_21 = ToFloat.IntToFloat(MSYM_Sanal[42], MSYM_Sanal[43]);//MD1221
            Properties.M101_Array.Default.YariOtoUretimMiktari_Katki2_ArrayCount_22 = ToFloat.IntToFloat(MSYM_Sanal[44], MSYM_Sanal[45]);//MD1222
            Properties.M101_Array.Default.YariOtoUretimMiktari_Katki3_ArrayCount_23 = ToFloat.IntToFloat(MSYM_Sanal[46], MSYM_Sanal[47]);//MD1223
            Properties.M101_Array.Default.YariOtoUretimMiktari_Katki4_ArrayCount_24 = ToFloat.IntToFloat(MSYM_Sanal[48], MSYM_Sanal[49]);//MD1224
            Properties.M101_Array.Default.YariOtoUretimMiktari_Katki5_ArrayCount_25 = ToFloat.IntToFloat(MSYM_Sanal[50], MSYM_Sanal[51]);//MD1225
        }
    }
}
