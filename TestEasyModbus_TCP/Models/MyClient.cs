using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EasyModbus;

namespace TestEasyModbus_TCP.Models
{
    public class MyClient : ModbusClient
    {
        public float U_LN1 { get; set; }
        public float U_LN2 { get; set; }
        public float U_LN3 { get; set; }

        private static int Port = 502;
        private static string Ip = "192.168.20.181";

        public MyClient(byte id)
        {
            this.Connect(Ip, Port);
            this.UnitIdentifier = id;
           
            U_LN1 = ConvertRegistersToFloat(ReadHoldingRegisters(19000, 2), RegisterOrder.HighLow);
            U_LN2 = ConvertRegistersToFloat(ReadHoldingRegisters(19002, 2), RegisterOrder.HighLow);
            U_LN3 = ConvertRegistersToFloat(ReadHoldingRegisters(19004, 2), RegisterOrder.HighLow);

            this.Disconnect();
        }
    }
}
