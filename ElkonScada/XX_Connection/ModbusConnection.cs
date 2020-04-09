using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRModbusTCP;
namespace ElkonScada.XX_Connection
{
    class ModbusConnection
    {
        
        ModbusTCP HetModbusTool = new ModbusTCP();
        //EasyModbus.ModbusClient HetModbusTool = new EasyModbus.ModbusClient();
        public static ModbusConnection HetConnect;

        public string ConnectionErrorString;

        public bool ConnectionErrorState = false;

        public static ModbusConnection HetConnection()
        {
            if (HetConnect == null)
            {
                HetConnect = new ModbusConnection();
            }
            return HetConnect;
        }


        
        String PLCIP = "192.168.0.10";
        int PLCPort = 502;
        public void ConnectPLC()
        {
            try
            {
                HetModbusTool.Connect(PLCIP, PLCPort);
                ConnectionErrorString = "Connected";
                ConnectionErrorState = false;
            }
            catch (Exception e)
            {
                ConnectionErrorString = "Control PLC Cable" + e.ToString();
                ConnectionErrorState = true;

            }
            if (HetModbusTool.Connected)
            {
                ConnectionErrorState = false;
            }
            else if (!HetModbusTool.Connected)
            {
                ConnectionErrorState = true;
                
            }
        }
        public int FunctionCode = 0;
        public bool WriteAktif = false;
        _001_Read_M001_Secimler Read_M001_Secimler =new _001_Read_M001_Secimler();
        _002_Read_M002_YariOto Read_M002_YariOto =new  _002_Read_M002_YariOto();
        _003_Read_M003_Manueller Read_M003_Manueller = new _003_Read_M003_Manueller();
        _004_Read_M004_Parametreler Read_M004_Parametreler = new _004_Read_M004_Parametreler();
        _005_Read_M005_Modbus Read_M005_Modbus = new _005_Read_M005_Modbus();
        _006_Read_M006_Uretim Read_M006_Uretim = new _006_Read_M006_Uretim();
        _007_Read_M007_Cfg Read_M007_Cfg = new _007_Read_M007_Cfg();
        _008_Read_M008_CI522 Read_M008_CI522 = new _008_Read_M008_CI522();
        _009_Read_M009_HMI Read_M009_HMI = new _009_Read_M009_HMI();
        _010_Read_M010_Alarm Read_M010_Alarm = new _010_Read_M010_Alarm();
        _011_Read_M011_Butonlar Read_M011_Butonlar = new _011_Read_M011_Butonlar();
        _012_Read_M012_Lambalar Read_M012_Lambalar = new _012_Read_M012_Lambalar();
        _013_Read_M013_KantarAnimasyon Read_M013_KantarAnimasyon = new _013_Read_M013_KantarAnimasyon();
        _014_Read_M014_Genel Read_M014_Genel = new _014_Read_M014_Genel();
        _015_Read_M015_Agrega Read_M015_Agrega = new _015_Read_M015_Agrega();
        _016_Read_M016_Cimento Read_M016_Cimento = new _016_Read_M016_Cimento();
        _017_Read_M017_Su Read_M017_Su = new _017_Read_M017_Su();
        _018_Read_M018_Katki Read_M018_Katki = new _018_Read_M018_Katki();
        _101_Read_M101_Array Read_M101_Array =new _101_Read_M101_Array();



        int[] VeriGonder = new int[514];
        bool[] ButtonArray = new bool[602];
        
       
        public bool[] ReadBooleanFromPLC;
        public int[] ReadWordFromPLCPart0;
        public int[] ReadWordFromPLCPart1;
        public int[] ReadWordFromPLCPart2;
        public int[] ReadWordFromPLCPart3;
        public int[] ReadWordFromPLCPart4;
        public int[] ReadWordFromPLCPart5;
        public int[] ReadWordFromPLCPart6;
        public int[] ReadWordFromPLCPart7;
        public int[] ReadWordFromPLCPart8;
        public int[] ReadWordFromPLCPart9;
        public int[] ReadWordFromPLCPart10;
        public int[] ReadWordFromPLCPart20;

        public bool[] AlarmFromPLC;



        public int[] R006_UretimValue = new int[45];
        public bool[] R006_UretimValueBool = new bool[14];

        public int R006Start_Adress = 4104;// PLCDEN CEKİLECEK DEĞERLERin Adres Başlangıcı
        public int R006_Quantity = 46;// PLCDEN CEKİLECEK DEĞERLERin Adres Başlangıcı

        public int[] MSVU_Sanal = new int[80];
        public int[] MSTI_Sanal = new int[80];
        public int[] MSMUM_Sanal = new int[80];
        public int[] MSYM_Sanal = new int[80];
        public int[] SanalMemeory_ZamanTarihDizisi = new int[80];





        public void ReadPLCData()
        {
            if (!WriteAktif)
            {
                if (HetModbusTool.Connected)
                {
                    try
                    {
                        ReadBooleanFromPLC = HetModbusTool.ReadCoils(0, 1999);

                        AlarmFromPLC = HetModbusTool.ReadCoils(0, 1000);

                        ReadWordFromPLCPart0 = HetModbusTool.ReadHoldingRegisters(0, 100);
                        ReadWordFromPLCPart1 = HetModbusTool.ReadHoldingRegisters(100, 100);
                        ReadWordFromPLCPart2 = (HetModbusTool.ReadHoldingRegisters(200, 100));
                        ReadWordFromPLCPart3 = HetModbusTool.ReadHoldingRegisters(300, 100);
                        ReadWordFromPLCPart4 = HetModbusTool.ReadHoldingRegisters(400, 100);
                        ReadWordFromPLCPart5 = HetModbusTool.ReadHoldingRegisters(500, 100);
                        ReadWordFromPLCPart6 = HetModbusTool.ReadHoldingRegisters(600, 100);
                        ReadWordFromPLCPart7 = HetModbusTool.ReadHoldingRegisters(700, 100);
                        ReadWordFromPLCPart8 = HetModbusTool.ReadHoldingRegisters(800, 100);
                        ReadWordFromPLCPart9 = HetModbusTool.ReadHoldingRegisters(900, 100);
                        ReadWordFromPLCPart10 = HetModbusTool.ReadHoldingRegisters(1000, 100);
                        ReadWordFromPLCPart20 = HetModbusTool.ReadHoldingRegisters(2000, 100);

                        R006_UretimValue = HetModbusTool.ReadHoldingRegisters(R006Start_Adress, R006_Quantity);
                        R006_UretimValueBool = HetModbusTool.ReadCoils(4202, 14);


                        MSVU_Sanal = HetModbusTool.ReadHoldingRegisters(M101_StartAdress_VerilenUrunMiktarlari_SCADA_Gonderilen, 80);
                        MSTI_Sanal = HetModbusTool.ReadHoldingRegisters(M101_StartAdress_ToplamIstenen_SCADA_Gonderilen, 80);
                        MSMUM_Sanal = HetModbusTool.ReadHoldingRegisters(M101_StartAdress_ManuelUretimMiktarlari, 80);
                        MSYM_Sanal = HetModbusTool.ReadHoldingRegisters(M101_StartAdress_YariOtoUretimMiktarlari, 80);
                        SanalMemeory_ZamanTarihDizisi = HetModbusTool.ReadHoldingRegisters(M101_StartAdress_s_ZamanTarihDizisi, 4);


                    }
                    catch (Exception)
                    {

                    }
                }
                if ( HetModbusTool.Connected)
                {
                    Read_M001_Secimler.Read_M001Secimler(ReadBooleanFromPLC);
                    Read_M002_YariOto.Read_M002YariOto(ReadBooleanFromPLC);
                    Read_M003_Manueller.Read_M003Manueller(ReadBooleanFromPLC, ReadWordFromPLCPart3, ReadWordFromPLCPart4);
                    Read_M004_Parametreler.ReadM004Parametreler(ReadBooleanFromPLC, ReadWordFromPLCPart3);
                    Read_M005_Modbus.ReadM005Modbus(ReadBooleanFromPLC, ReadWordFromPLCPart4, ReadWordFromPLCPart5,ReadWordFromPLCPart20);
                    Read_M006_Uretim.ReadM006Uretim(ReadBooleanFromPLC, ReadWordFromPLCPart3, ReadWordFromPLCPart5);
                    Read_M007_Cfg.ReadM007Cfg(ReadBooleanFromPLC);
                    Read_M008_CI522.ReadM008CI522(ReadBooleanFromPLC);
                    Read_M009_HMI.ReadM009HMI(ReadBooleanFromPLC);
                    Read_M010_Alarm.ReadM010Alarm(AlarmFromPLC);
                    Read_M011_Butonlar.ReadM011Butonlar(ReadBooleanFromPLC);
                    Read_M012_Lambalar.ReadM012Lambalar(ReadBooleanFromPLC);
                    Read_M013_KantarAnimasyon.ReadM013KantarAnimasyon(ReadWordFromPLCPart0, ReadWordFromPLCPart3);
                    Read_M014_Genel.ReadM14Genel(ReadWordFromPLCPart0,ReadWordFromPLCPart3);
                    Read_M015_Agrega.ReadM15Agrega(ReadWordFromPLCPart1,ReadWordFromPLCPart5);
                    Read_M016_Cimento.ReadM016Cimento(ReadWordFromPLCPart2);
                    Read_M017_Su.ReadM017Su(ReadWordFromPLCPart2);
                    Read_M018_Katki.ReadM018Katki(ReadWordFromPLCPart4);
                    Read_M101_Array.Read_M101Array(MSVU_Sanal, MSTI_Sanal, MSMUM_Sanal, MSYM_Sanal, SanalMemeory_ZamanTarihDizisi);
                }

            }
        }
        int adem = 0;
        public void KantarKalibrasyonSendData()
        {
            WriteAktif = true;
            // HetModbusTool.WriteSingleRegister(517,adem);//
            adem++;
            WriteAktif = false;
        }
        public void KonfigrasyonGonder()
        {
            //Properties.R004_Parametreler.Default.XB111_AgCiftKapakSecim = true;

        }
        public void Alarmlar()
        {
        }
      public void HetmodbusTool_WritePLC(int StartAdres,int[] WriteArrayValue)
        {
            WriteAktif = true;
            ConnectPLC();
            HetModbusTool.WriteMultipleRegisters(StartAdres, WriteArrayValue);

            WriteAktif = false;
        }
    

   
     
        int GonderilenModbusAdres = 0;
        public void WriteBool(String ModbusAdress)
        {
            string[] AdresInfo = ModbusAdress.Split('.');
            GonderilenModbusAdres = Convert.ToInt32(AdresInfo[2]) * 8 + Convert.ToInt16(AdresInfo[3]);
          HetModbusTool.Connect();
            if (HetModbusTool.Connected)
            {
               
                if (HetModbusTool.ReadCoils(GonderilenModbusAdres, 1)[0])
                {
                    HetModbusTool.WriteSingleCoil(GonderilenModbusAdres, false);

                }
                else if (!HetModbusTool.ReadCoils(GonderilenModbusAdres, 1)[0])
                {
                    HetModbusTool.WriteSingleCoil(GonderilenModbusAdres, true);

                }


            }
       
        }
       
        int M101_StartAdress_VerilenUrunMiktarlari_SCADA_Gonderilen = 2200;//Modbus okuma başlangıç adresi
        int M101_StartAdress_ToplamIstenen_SCADA_Gonderilen = 2400;//Modbus okuma başlangıç adresi
        int M101_StartAdress_ManuelUretimMiktarlari = 2600;//Modbus okuma başlangıç adresi
        int M101_StartAdress_YariOtoUretimMiktarlari = 2800;//Modbus okuma başlangıç adresi
        int M101_StartAdress_s_ZamanTarihDizisi = 3000;//Modbus okuma başlangıç adresi

        int M101_Quantity =40; //Modbus ile kaç adet adres okunacağı belirlenir.


  
     
        }
    }

