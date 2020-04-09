using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.XX_Connection
{
    class ZZ_006_Read_R006_Uretim
    {
        private ZZ_006_Read_R006_Uretim()
        {

        }
        private static ZZ_006_Read_R006_Uretim Read_R006_Uretim;
        XX_Connection.ModbusConnection ModbusClass = ModbusConnection.HetConnection();
        XX_IntToFloat ToFloat = XX_IntToFloat.ConvertToFloat_();

        public static ZZ_006_Read_R006_Uretim ZZ_006_Read_R006_Uretim_Okunuyor()
        {
            if (Read_R006_Uretim == null)
            {
                Read_R006_Uretim = new ZZ_006_Read_R006_Uretim();
            }
            return Read_R006_Uretim;
        }
        public void Read_R006Uretim()
        {
            //R4104 Adresinden başlıyarak değerleri alıyoruz.
            Properties.R006_Uretim.Default.XB112_AgregaKW = ModbusClass.R006_UretimValue[0]; //R4104 Adresi
            Properties.R006_Uretim.Default.XB112_CimentoKW = ModbusClass.R006_UretimValue[1];
            Properties.R006_Uretim.Default.XB112_SuKW = ModbusClass.R006_UretimValue[2];
            Properties.R006_Uretim.Default.XB112_KatkiKW = ModbusClass.R006_UretimValue[3];
            Properties.R006_Uretim.Default.XB112_MikserKW = ModbusClass.R006_UretimValue[4];
            Properties.R006_Uretim.Default.XB112_TransferBandKW = ModbusClass.R006_UretimValue[5];

            Properties.R006_Uretim.Default.XB112_KovaKW = ModbusClass.R006_UretimValue[6];
            Properties.R006_Uretim.Default.XB112_ToplamTur = ModbusClass.R006_UretimValue[7];
            Properties.R006_Uretim.Default.XB112_YapilanTur = ModbusClass.R006_UretimValue[8];
            Properties.R006_Uretim.Default.XB112_AgregaTur = ModbusClass.R006_UretimValue[9];
            Properties.R006_Uretim.Default.XB112_MalzemeTur = ModbusClass.R006_UretimValue[10];
            Properties.R006_Uretim.Default.XB112_BosaltilmaRecete = ModbusClass.R006_UretimValue[11];
            Properties.R006_Uretim.Default.XB112_CimentoGecikmeRecete = ModbusClass.R006_UretimValue[12];
            Properties.R006_Uretim.Default.XB112_SuGecikmeRecete = ModbusClass.R006_UretimValue[13];
            Properties.R006_Uretim.Default.XB112_KatkiGecikmeRecete = ModbusClass.R006_UretimValue[14];
            Properties.R006_Uretim.Default.XB112_KovaAraYurumeSuresi = ModbusClass.R006_UretimValue[15];
            Properties.R006_Uretim.Default.XB112_KovaMaxYurumeSuresi = ModbusClass.R006_UretimValue[16];
            Properties.R006_Uretim.Default.XB112_BosaltilanSure = ModbusClass.R006_UretimValue[17];
            Properties.R006_Uretim.Default.XB112_KaristirilanSure = ModbusClass.R006_UretimValue[18];
            Properties.R006_Uretim.Default.UretimPlaniDataGrid = ModbusClass.R006_UretimValue[19];
            Properties.R006_Uretim.Default.XB112_AraBantKW = ModbusClass.R006_UretimValue[20];
            //spare  R006_Uretim[20];R006_Uretim[35];
            Properties.R006_Uretim.Default.XB19_MiktarYapilan = ToFloat.IntToFloat(ModbusClass.R006_UretimValue[36], ModbusClass.R006_UretimValue[37]);  //R2070
            Properties.R006_Uretim.Default.XB19_Miktar = ToFloat.IntToFloat(ModbusClass.R006_UretimValue[38], ModbusClass.R006_UretimValue[39]);  //R2071
            Properties.R006_Uretim.Default.XB19_ToplamYapilanMiktar = ToFloat.IntToFloat(ModbusClass.R006_UretimValue[40], ModbusClass.R006_UretimValue[41]);  //R2072
            Properties.R006_Uretim.Default.XB19_GunlukToplamYapilanMiktar = ToFloat.IntToFloat(ModbusClass.R006_UretimValue[42], ModbusClass.R006_UretimValue[43]);  //R2073
            Properties.R006_Uretim.Default.XB1_ReceteKatsayi = ToFloat.IntToFloat(ModbusClass.R006_UretimValue[44], ModbusClass.R006_UretimValue[45]);  //R2074


            Properties.R006_Uretim.Default.XB111_AgregaAlindi = ModbusClass.R006_UretimValueBool[2];
            Properties.R006_Uretim.Default.XB111_CimentoAlindi = ModbusClass.R006_UretimValueBool[3];
            Properties.R006_Uretim.Default.XB111_SuAlindi = ModbusClass.R006_UretimValueBool[4];
            Properties.R006_Uretim.Default.XB111_KatkiAlindi = ModbusClass.R006_UretimValueBool[5];
            Properties.R006_Uretim.Default.XB111_AgregaBasla = ModbusClass.R006_UretimValueBool[6];
            Properties.R006_Uretim.Default.XB111_MalzemeAlimBasla = ModbusClass.R006_UretimValueBool[7];
            Properties.R006_Uretim.Default.SeriUretim = ModbusClass.R006_UretimValueBool[8];
            Properties.R006_Uretim.Default.XB111_UretimReset = ModbusClass.R006_UretimValueBool[9];
            Properties.R006_Uretim.Default.XB111_Uretim = ModbusClass.R006_UretimValueBool[10];
            Properties.R006_Uretim.Default.YapilanTurSifirlandi = ModbusClass.R006_UretimValueBool[11];
            Properties.R006_Uretim.Default.v_Yrd_YariModUretimDevam = ModbusClass.R006_UretimValueBool[12];
            Properties.R006_Uretim.Default.s_ManualKayitArsivAl = ModbusClass.R006_UretimValueBool[13];
            Properties.R006_Uretim.Default.s_ManuelUretimDisplayTrigger = ModbusClass.R006_UretimValueBool[14];
        }
    }
}
