using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EasyModbus;

namespace TestEasyModbus_TCP.Models
{
    public class UMG_511//.. : ModbusClient//: UMG_96RM
    {
        ////Настройки подключения - Связь
        //public string IP { get; set; }
        //public int Port { get; set; }
        //public byte id { get; set; }

        //// Данные ввиде структуры
        //RegMesUMG Data = new RegMesUMG { };


        ////конструктор
        //public UMG_511(string IP, int Port, byte id)
        //{
        //    //this.Connect(IP, Port);
        //    //this.UnitIdentifier = id;

        //    ////public struct RegMesUMG.U
        //    //Data.ULN1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19000, 2), RegisterOrder.HighLow);
        //    //Data.ULN2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19002, 2), RegisterOrder.HighLow);
        //    //Data.ULN3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19004, 2), RegisterOrder.HighLow);
        //    //Data.ULL1_V = ConvertRegistersToFloat(ReadHoldingRegisters(19006, 2), RegisterOrder.HighLow);
        //    //Data.ULL2_V = ConvertRegistersToFloat(ReadHoldingRegisters(19008, 2), RegisterOrder.HighLow);
        //    //Data.ULL3_V = ConvertRegistersToFloat(ReadHoldingRegisters(19010, 2), RegisterOrder.HighLow);
        //    //Data.ILN1_A = ConvertRegistersToFloat(ReadHoldingRegisters(19012, 2), RegisterOrder.HighLow);
        //    //Data.ILN2_A = ConvertRegistersToFloat(ReadHoldingRegisters(19014, 2), RegisterOrder.HighLow);
        //    //Data.ILN3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19016, 2), RegisterOrder.HighLow);
        //    //Data.ISUM3_A = ConvertRegistersToFloat(ReadHoldingRegisters(19018, 2), RegisterOrder.HighLow);
        //    //Data.PLN1_W = ConvertRegistersToFloat(ReadHoldingRegisters(19020, 2), RegisterOrder.HighLow);
        //    //Data.PLN2_W = ConvertRegistersToFloat(ReadHoldingRegisters(19022, 2), RegisterOrder.HighLow);
        //    //Data.PLN3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19024, 2), RegisterOrder.HighLow);
        //    //Data.PSUM3_W = ConvertRegistersToFloat(ReadHoldingRegisters(19026, 2), RegisterOrder.HighLow);
        //    //Data.SLN1_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19028, 2), RegisterOrder.HighLow);
        //    //Data.SLN2_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19030, 2), RegisterOrder.HighLow);
        //    //Data.SLN3_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19032, 2), RegisterOrder.HighLow);
        //    //Data.SSUM3_VA = ConvertRegistersToFloat(ReadHoldingRegisters(19034, 2), RegisterOrder.HighLow);
        //    //Data.QLN1_var = ConvertRegistersToFloat(ReadHoldingRegisters(19036, 2), RegisterOrder.HighLow);
        //    //Data.QLN2_var = ConvertRegistersToFloat(ReadHoldingRegisters(19038, 2), RegisterOrder.HighLow);
        //    //Data.QLN3_var = ConvertRegistersToFloat(ReadHoldingRegisters(19040, 2), RegisterOrder.HighLow);
        //    //Data.QSUM3_var = ConvertRegistersToFloat(ReadHoldingRegisters(19042, 2), RegisterOrder.HighLow);
        //    //Data.COS_PHI1 = ConvertRegistersToFloat(ReadHoldingRegisters(19044, 2), RegisterOrder.HighLow);
        //    //Data.COS_PHI2 = ConvertRegistersToFloat(ReadHoldingRegisters(19046, 2), RegisterOrder.HighLow);
        //    //Data.COS_PHI3 = ConvertRegistersToFloat(ReadHoldingRegisters(19048, 2), RegisterOrder.HighLow);
        //    //Data.FREQ_Hz = ConvertRegistersToFloat(ReadHoldingRegisters(19050, 2), RegisterOrder.HighLow);
        //    //Data.PHASE_SEQ = ConvertRegistersToFloat(ReadHoldingRegisters(19052, 2), RegisterOrder.HighLow);
        //    //Data.WH1_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19054, 2), RegisterOrder.HighLow);
        //    //Data.WH2_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19056, 2), RegisterOrder.HighLow);
        //    //Data.WH3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19058, 2), RegisterOrder.HighLow);
        //    //Data.WHSUM3_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19060, 2), RegisterOrder.HighLow);
        //    //Data.WH1_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19062, 2), RegisterOrder.HighLow);
        //    //Data.WH2_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19064, 2), RegisterOrder.HighLow);
        //    //Data.WH3_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19066, 2), RegisterOrder.HighLow);
        //    //Data.WHSUM3_V_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19068, 2), RegisterOrder.HighLow);
        //    //Data.WH1_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19070, 2), RegisterOrder.HighLow);
        //    //Data.WH2_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19072, 2), RegisterOrder.HighLow);
        //    //Data.WH3_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19074, 2), RegisterOrder.HighLow);
        //    //Data.WHSUM3_Z_Wh = ConvertRegistersToFloat(ReadHoldingRegisters(19076, 2), RegisterOrder.HighLow);
        //    //Data.WH1_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19078, 2), RegisterOrder.HighLow);
        //    //Data.WH2_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19080, 2), RegisterOrder.HighLow);
        //    //Data.WH3_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19082, 2), RegisterOrder.HighLow);
        //    //Data.WHSUM3_S_VAh = ConvertRegistersToFloat(ReadHoldingRegisters(19084, 2), RegisterOrder.HighLow);
        //    //Data.QH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19086, 2), RegisterOrder.HighLow);
        //    //Data.QH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19088, 2), RegisterOrder.HighLow);
        //    //Data.QH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19090, 2), RegisterOrder.HighLow);
        //    //Data.QHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19092, 2), RegisterOrder.HighLow);
        //    //Data.IQH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19094, 2), RegisterOrder.HighLow);
        //    //Data.IQH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19096, 2), RegisterOrder.HighLow);
        //    //Data.IQH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19098, 2), RegisterOrder.HighLow);
        //    //Data.IQHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19100, 2), RegisterOrder.HighLow);
        //    //Data.CQH1_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19102, 2), RegisterOrder.HighLow);
        //    //Data.CQH2_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19104, 2), RegisterOrder.HighLow);
        //    //Data.CQH3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19106, 2), RegisterOrder.HighLow);
        //    //Data.CQHSUM3_varh = ConvertRegistersToFloat(ReadHoldingRegisters(19108, 2), RegisterOrder.HighLow);
        //    //Data.THD_ULN1 = ConvertRegistersToFloat(ReadHoldingRegisters(19110, 2), RegisterOrder.HighLow);
        //    //Data.THD_ULN2 = ConvertRegistersToFloat(ReadHoldingRegisters(19112, 2), RegisterOrder.HighLow);
        //    //Data.THD_ULN3 = ConvertRegistersToFloat(ReadHoldingRegisters(19114, 2), RegisterOrder.HighLow);
        //    //Data.THD_ILN1 = ConvertRegistersToFloat(ReadHoldingRegisters(19116, 2), RegisterOrder.HighLow);
        //    //Data.THD_ILN2 = ConvertRegistersToFloat(ReadHoldingRegisters(19118, 2), RegisterOrder.HighLow);
        //    //Data.THD_ILN3 = ConvertRegistersToFloat(ReadHoldingRegisters(19120, 2), RegisterOrder.HighLow);

        //    //this.Disconnect();



        //}

    }
}
