using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EasyModbus;

namespace TestEasyModbus_TCP.Models
{
    public struct RegMesUMG
    {
        public float ULN1_V;
        public float ULN2_V;
        public float ULN3_V;
        public float ULL1_V;
        public float ULL2_V;
        public float ULL3_V; //фазные.линейные напряжения
        public float ILN1_A;
        public float ILN2_A;
        public float ILN3_A;
        public float ISUM3_A; //фазные токи и сумма
        public float PLN1_W;
        public float PLN2_W;
        public float PLN3_W;
        public float PSUM3_W; //актив мощность
        public float SLN1_VA;
        public float SLN2_VA;
        public float SLN3_VA;
        public float SSUM3_VA; //полная мощность
        public float QLN1_var;
        public float QLN2_var;
        public float QLN3_var;
        public float QSUM3_var; //реактивная мощность
        public float COS_PHI1;
        public float COS_PHI2;
        public float COS_PHI3;
        public float FREQ_Hz;
        public float PHASE_SEQ; //косинус, частота, направ. вращения
        public float WH1_Wh;
        public float WH2_Wh;
        public float WH3_Wh;
        public float WHSUM3_Wh;
        public float WH1_V_Wh;
        public float WH2_V_Wh;
        public float WH3_V_Wh;
        public float WHSUM3_V_Wh;
        public float WH1_Z_Wh;
        public float WH2_Z_Wh;
        public float WH3_Z_Wh;
        public float WHSUM3_Z_Wh;
        public float WH1_S_VAh;
        public float WH2_S_VAh;
        public float WH3_S_VAh;
        public float WHSUM3_S_VAh;
        public float QH1_varh;
        public float QH2_varh;
        public float QH3_varh;
        public float QHSUM3_varh;
        public float IQH1_varh;
        public float IQH2_varh;
        public float IQH3_varh;
        public float IQHSUM3_varh;
        public float CQH1_varh;
        public float CQH2_varh;
        public float CQH3_varh;
        public float CQHSUM3_varh;
        public float THD_ULN1;
        public float THD_ULN2;
        public float THD_ULN3;
        public float THD_ILN1;
        public float THD_ILN2;
        public float THD_ILN3;
    }


    public class UMG_96RM : ModbusClient  //класс : наследование от класса
    {
        //Данные регистров
        public string ErrorConect;
        public bool connectOK;

        // Данные ввиде структуры
        RegMesUMG Data = new RegMesUMG { };

        //Настройки подключения - Связь
        public string ip { get; set; }
        public int port { get; set; }
        public byte id { get; set; }

       
       
        //конструктор
        public  UMG_96RM(string inputIP, int inputPort, byte inputID)
        {
            this.ip = inputIP;
            this.port = inputPort;
            this.id = inputID;
            this.ErrorConect = "";
            this.connectOK = false;
        }
        
        //Метод считывания постоянных данных 
        public void  GetSmallData(ref RegMesUMG Data)
        {
            Connect(ip, port);
            UnitIdentifier = id;

            try
            {
                this.Data.ULN1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19000, 2), RegisterOrder.HighLow);
                this.Data.ULN2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19002, 2), RegisterOrder.HighLow);
                this.Data.ULN3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19004, 2), RegisterOrder.HighLow);
                this.Data.ULL1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19006, 2), RegisterOrder.HighLow);
                this.Data.ULL2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19008, 2), RegisterOrder.HighLow);
                this.Data.ULL3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19010, 2), RegisterOrder.HighLow);
                this.Data.ILN1_A = ConvertRegistersToFloat(ReadHoldingRegisters(19012, 2), RegisterOrder.HighLow);
                this.Data.ILN2_A = ConvertRegistersToFloat(ReadHoldingRegisters(19014, 2), RegisterOrder.HighLow);
                this.Data.ILN3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19016, 2), RegisterOrder.HighLow);
                this.Data.ISUM3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19018, 2), RegisterOrder.HighLow);
                this.Data.PLN1_W = ConvertRegistersToFloat(ReadHoldingRegisters(19020, 2), RegisterOrder.HighLow);
                this.Data.PLN2_W = ConvertRegistersToFloat(ReadHoldingRegisters(19022, 2), RegisterOrder.HighLow);
                this.Data.PLN3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19024, 2), RegisterOrder.HighLow);
                this.Data.PSUM3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19026, 2), RegisterOrder.HighLow);

                this.Data.WHSUM3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19060, 2), RegisterOrder.HighLow);

                connectOK = true;

            }
            catch (Exception e) { ErrorConect = e.ToString(); connectOK = false; }


            Disconnect();

            if(connectOK) 
               CopyData(ref Data);

        }

        //Метод считывания счетчика Активной мощности
        public void GetPowerWh(ref float WHSUM3_WhX)
        {
            try
            {
                Connect(ip, port);
                UnitIdentifier = id;
                            
                Data.WHSUM3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19060, 2), RegisterOrder.HighLow);
                connectOK = true;
            
                 Disconnect();
            }
            catch (Exception e) { ErrorConect = e.ToString(); connectOK = false; }

            if (connectOK) WHSUM3_WhX = Data.WHSUM3_Wh;
        }

        //метод возврата структуры       
        public RegMesUMG GetAllData(RegMesUMG Data) //ref RegMesUMG DataX
        {

            try
            {
                Connect(ip, port);
                UnitIdentifier = id;
            
                
                //this.Data.ULN1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19000, 2), RegisterOrder.HighLow);
                //this.Data.ULN2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19002, 2), RegisterOrder.HighLow);
                //this.Data.ULN3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19004, 2), RegisterOrder.HighLow);
                //this.Data.ULL1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19006, 2), RegisterOrder.HighLow);
                //this.Data.ULL2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19008, 2), RegisterOrder.HighLow);
                //this.Data.ULL3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19010, 2), RegisterOrder.HighLow);
                //this.Data.ILN1_A = ConvertRegistersToFloat(ReadHoldingRegisters(19012, 2), RegisterOrder.HighLow);
                //this.Data.ILN2_A = ConvertRegistersToFloat(ReadHoldingRegisters(19014, 2), RegisterOrder.HighLow);
                //this.Data.ILN3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19016, 2), RegisterOrder.HighLow);
                //this.Data.ISUM3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19018, 2), RegisterOrder.HighLow);
                //this.Data.PLN1_W = ConvertRegistersToFloat(ReadHoldingRegisters(19020, 2), RegisterOrder.HighLow);
                //this.Data.PLN2_W = ConvertRegistersToFloat(ReadHoldingRegisters(19022, 2), RegisterOrder.HighLow);
                //this.Data.PLN3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19024, 2), RegisterOrder.HighLow);
                this.Data.PSUM3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19026, 2), RegisterOrder.HighLow);
                //this.Data.SLN1_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19028, 2), RegisterOrder.HighLow);
                //this.Data.SLN2_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19030, 2), RegisterOrder.HighLow);
                //this.Data.SLN3_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19032, 2), RegisterOrder.HighLow);
                //this.Data.SSUM3_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19034, 2), RegisterOrder.HighLow);
                //this.Data.QLN1_var = ConvertRegistersToFloat(ReadHoldingRegisters(19036, 2), RegisterOrder.HighLow);
                //this.Data.QLN2_var = ConvertRegistersToFloat(ReadHoldingRegisters(19038, 2), RegisterOrder.HighLow);
                //this.Data.QLN3_var = ConvertRegistersToFloat(ReadHoldingRegisters(19040, 2), RegisterOrder.HighLow);
                //this.Data.QSUM3_var = ConvertRegistersToFloat(ReadHoldingRegisters(19042, 2), RegisterOrder.HighLow);
                //this.Data.COS_PHI1 = ConvertRegistersToFloat(ReadHoldingRegisters(19044, 2), RegisterOrder.HighLow);
                //this.Data.COS_PHI2 = ConvertRegistersToFloat(ReadHoldingRegisters(19046, 2), RegisterOrder.HighLow);
                //this.Data.COS_PHI3 = ConvertRegistersToFloat(ReadHoldingRegisters(19048, 2), RegisterOrder.HighLow);
                //this.Data.FREQ_Hz = ConvertRegistersToFloat(ReadHoldingRegisters(19050, 2), RegisterOrder.HighLow);
                //this.Data.PHASE_SEQ = ConvertRegistersToFloat(ReadHoldingRegisters(19052, 2), RegisterOrder.HighLow);
                //this.Data.WH1_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19054, 2), RegisterOrder.HighLow);
                //this.Data.WH2_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19056, 2), RegisterOrder.HighLow);
                //this.Data.WH3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19058, 2), RegisterOrder.HighLow);
                this.Data.WHSUM3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19060, 2), RegisterOrder.HighLow);
                //this.Data.WH1_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19062, 2), RegisterOrder.HighLow);
                //this.Data.WH2_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19064, 2), RegisterOrder.HighLow);
                //this.Data.WH3_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19066, 2), RegisterOrder.HighLow);
                //this.Data.WHSUM3_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19068, 2), RegisterOrder.HighLow);
                //this.Data.WH1_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19070, 2), RegisterOrder.HighLow);
                //this.Data.WH2_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19072, 2), RegisterOrder.HighLow);
                //this.Data.WH3_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19074, 2), RegisterOrder.HighLow);
                //this.Data.WHSUM3_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19076, 2), RegisterOrder.HighLow);
                //this.Data.WH1_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19078, 2), RegisterOrder.HighLow);
                //this.Data.WH2_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19080, 2), RegisterOrder.HighLow);
                //this.Data.WH3_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19082, 2), RegisterOrder.HighLow);
                //this.Data.WHSUM3_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19084, 2), RegisterOrder.HighLow);
                //this.Data.QH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19086, 2), RegisterOrder.HighLow);
                //this.Data.QH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19088, 2), RegisterOrder.HighLow);
                //this.Data.QH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19090, 2), RegisterOrder.HighLow);
                //this.Data.QHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19092, 2), RegisterOrder.HighLow);
                //this.Data.IQH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19094, 2), RegisterOrder.HighLow);
                //this.Data.IQH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19096, 2), RegisterOrder.HighLow);
                //this.Data.IQH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19098, 2), RegisterOrder.HighLow);
                //this.Data.IQHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19100, 2), RegisterOrder.HighLow);
                //this.Data.CQH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19102, 2), RegisterOrder.HighLow);
                //this.Data.CQH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19104, 2), RegisterOrder.HighLow);
                //this.Data.CQH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19106, 2), RegisterOrder.HighLow);
                //this.Data.CQHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19108, 2), RegisterOrder.HighLow);
                //this.Data.THD_ULN1 = ConvertRegistersToFloat(ReadHoldingRegisters(19110, 2), RegisterOrder.HighLow);
                //this.Data.THD_ULN2 = ConvertRegistersToFloat(ReadHoldingRegisters(19112, 2), RegisterOrder.HighLow);
                //this.Data.THD_ULN3 = ConvertRegistersToFloat(ReadHoldingRegisters(19114, 2), RegisterOrder.HighLow);
                //this.Data.THD_ILN1 = ConvertRegistersToFloat(ReadHoldingRegisters(19116, 2), RegisterOrder.HighLow);
                //this.Data.THD_ILN2 = ConvertRegistersToFloat(ReadHoldingRegisters(19118, 2), RegisterOrder.HighLow);
                //this.Data.THD_ILN3 = ConvertRegistersToFloat(ReadHoldingRegisters(19120, 2), RegisterOrder.HighLow);
                this.connectOK = true;
               
            }
            catch (Exception e) { ErrorConect = e.ToString(); this.connectOK = false; }
            Disconnect();

            if (this.connectOK && true)  
             CopyData(ref Data);
           

            return Data;
        }

        //метод копирования данных структуры       
        private   void CopyData(ref RegMesUMG Data) //ref RegMesUMG DataX
        {
            Data.ULN1_V = this.Data.ULN1_V;
            Data.ULN2_V = this.Data.ULN2_V;
            Data.ULN3_V = this.Data.ULN3_V;
            Data.ULL1_V = this.Data.ULL1_V;
            Data.ULL2_V = this.Data.ULL2_V;
            Data.ULL3_V = this.Data.ULL3_V;
            Data.ILN1_A = this.Data.ILN1_A;
            Data.ILN2_A = this.Data.ILN2_A;
            Data.ILN3_A = this.Data.ILN3_A;
            Data.ISUM3_A = this.Data.ISUM3_A;
            Data.PLN1_W = this.Data.PLN1_W;
            Data.PLN2_W = this.Data.PLN2_W;
            Data.PLN3_W = this.Data.PLN3_W;
            Data.PSUM3_W = this.Data.PSUM3_W;
            Data.SLN1_VA = this.Data.SLN1_VA;
            Data.SLN2_VA = this.Data.SLN2_VA;
            Data.SLN3_VA = this.Data.SLN3_VA;
            Data.SSUM3_VA = this.Data.SSUM3_VA;
            Data.QLN1_var = this.Data.QLN1_var;
            Data.QLN2_var = this.Data.QLN2_var;
            Data.QLN3_var = this.Data.QLN3_var;
            Data.QSUM3_var = this.Data.QSUM3_var;
            Data.COS_PHI1 = this.Data.COS_PHI1;
            Data.COS_PHI2 = this.Data.COS_PHI2;
            Data.COS_PHI3 = this.Data.COS_PHI3;
            Data.FREQ_Hz = this.Data.FREQ_Hz;
            Data.PHASE_SEQ = this.Data.PHASE_SEQ;
            Data.WH1_Wh = this.Data.WH1_Wh;
            Data.WH2_Wh = this.Data.WH2_Wh;
            Data.WH3_Wh = this.Data.WH3_Wh;
            Data.WHSUM3_Wh = this.Data.WHSUM3_Wh;
            Data.WH1_V_Wh = this.Data.WH1_V_Wh;
            Data.WH2_V_Wh = this.Data.WH2_V_Wh;
            Data.WH3_V_Wh = this.Data.WH3_V_Wh;
            Data.WHSUM3_V_Wh = this.Data.WHSUM3_V_Wh;
            Data.WH1_Z_Wh = this.Data.WH1_Z_Wh;
            Data.WH2_Z_Wh = this.Data.WH2_Z_Wh;
            Data.WH3_Z_Wh = this.Data.WH3_Z_Wh;
            Data.WHSUM3_Z_Wh = this.Data.WHSUM3_Z_Wh;
            Data.WH1_S_VAh = this.Data.WH1_S_VAh;
            Data.WH2_S_VAh = this.Data.WH2_S_VAh;
            Data.WH3_S_VAh = this.Data.WH3_S_VAh;
            Data.WHSUM3_S_VAh = this.Data.WHSUM3_S_VAh;
            Data.QH1_varh = this.Data.QH1_varh;
            Data.QH2_varh = this.Data.QH2_varh;
            Data.QH3_varh = this.Data.QH3_varh;
            Data.QHSUM3_varh = this.Data.QHSUM3_varh;
            Data.IQH1_varh = this.Data.IQH1_varh;
            Data.IQH2_varh = this.Data.IQH2_varh;
            Data.IQH3_varh = this.Data.IQH3_varh;
            Data.IQHSUM3_varh = this.Data.IQHSUM3_varh;
            Data.CQH1_varh = this.Data.CQH1_varh;
            Data.CQH2_varh = this.Data.CQH2_varh;
            Data.CQH3_varh = this.Data.CQH3_varh;
            Data.CQHSUM3_varh = this.Data.CQHSUM3_varh;
            Data.THD_ULN1 = this.Data.THD_ULN1;
            Data.THD_ULN2 = this.Data.THD_ULN2;
            Data.THD_ULN3 = this.Data.THD_ULN3;
            Data.THD_ILN1 = this.Data.THD_ILN1;
            Data.THD_ILN2 = this.Data.THD_ILN2;
            Data.THD_ILN3 = this.Data.THD_ILN3;

           
        }
    }
}