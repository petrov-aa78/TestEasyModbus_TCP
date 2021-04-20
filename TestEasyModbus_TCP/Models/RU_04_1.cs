using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEasyModbus_TCP.Models
{
    class RU_04_1
    {
        // Инициализация (создание экземпляраов) устройста секции шин 1
        #region Секция шин 1 - Инициализация
        static string IP_1 = "192.168.20.180";
        static int Port_1 = 502;

        static UMG_96RM QF1 = new UMG_96RM(IP_1, Port_1, 100);
        static UMG_96RM QS1 = new UMG_96RM(IP_1, Port_1, 1);
        static UMG_96RM QS3 = new UMG_96RM(IP_1, Port_1, 3);
        static UMG_96RM QS4 = new UMG_96RM(IP_1, Port_1, 4);
        static UMG_96RM QS5 = new UMG_96RM(IP_1, Port_1, 5);
        static UMG_96RM QS6 = new UMG_96RM(IP_1, Port_1, 6);
        static UMG_96RM QS7 = new UMG_96RM(IP_1, Port_1, 7);
        static UMG_96RM QS8 = new UMG_96RM(IP_1, Port_1, 8);
        static UMG_96RM QS9 = new UMG_96RM(IP_1, Port_1, 9);
        static UMG_96RM QS10 = new UMG_96RM(IP_1, Port_1, 10);
        static UMG_96RM QS11 = new UMG_96RM(IP_1, Port_1, 11);
        static UMG_96RM QS12 = new UMG_96RM(IP_1, Port_1, 12);
        static UMG_96RM QS13 = new UMG_96RM(IP_1, Port_1, 13);
        static UMG_96RM QS14 = new UMG_96RM(IP_1, Port_1, 14);
        static UMG_96RM QS15 = new UMG_96RM(IP_1, Port_1, 15);
        static UMG_96RM QS16 = new UMG_96RM(IP_1, Port_1, 16);
        static UMG_96RM QS17 = new UMG_96RM(IP_1, Port_1, 17);
        static UMG_96RM QS18 = new UMG_96RM(IP_1, Port_1, 18);
        static UMG_96RM QS19 = new UMG_96RM(IP_1, Port_1, 19);
        static UMG_96RM QF3 = new UMG_96RM(IP_1, Port_1, 20);
        static UMG_96RM QF4 = new UMG_96RM(IP_1, Port_1, 54);
        static UMG_96RM QF5 = new UMG_96RM(IP_1, Port_1, 55);
        static UMG_96RM QF6 = new UMG_96RM(IP_1, Port_1, 56);
        static UMG_96RM QF7 = new UMG_96RM(IP_1, Port_1, 57);
        static UMG_96RM QF8 = new UMG_96RM(IP_1, Port_1, 58);

        #endregion

        #region Данные по устройствам
        static RegMesUMG QF1Data = new RegMesUMG { };
        static RegMesUMG QS1Data = new RegMesUMG { };
        static RegMesUMG QS3Data = new RegMesUMG { };
        static RegMesUMG QS4Data = new RegMesUMG { };
        static RegMesUMG QS5Data = new RegMesUMG { };
        static RegMesUMG QS6Data = new RegMesUMG { };
        static RegMesUMG QS7Data = new RegMesUMG { };
        static RegMesUMG QS8Data = new RegMesUMG { };
        static RegMesUMG QS9Data = new RegMesUMG { };
        static RegMesUMG QS10Data = new RegMesUMG { };
        static RegMesUMG QS11Data = new RegMesUMG { };
        static RegMesUMG QS12Data = new RegMesUMG { };
        static RegMesUMG QS13Data = new RegMesUMG { };
        static RegMesUMG QS14Data = new RegMesUMG { };
        static RegMesUMG QS15Data = new RegMesUMG { };
        static RegMesUMG QS16Data = new RegMesUMG { };
        static RegMesUMG QS17Data = new RegMesUMG { };
        static RegMesUMG QS18Data = new RegMesUMG { };
        static RegMesUMG QS19Data = new RegMesUMG { };
        static RegMesUMG QF3Data = new RegMesUMG { };
        static RegMesUMG QF4Data = new RegMesUMG { };
        static RegMesUMG QF5Data = new RegMesUMG { };
        static RegMesUMG QF6Data = new RegMesUMG { };
        static RegMesUMG QF7Data = new RegMesUMG { };
        static RegMesUMG QF8Data = new RegMesUMG { };
        #endregion



        // Создаем соединение со шлюзом UMG-511 секция шин 1
        
            //try
            //{
            //    Connect(IP, Port);
            //}
            //catch ()

    }
}
