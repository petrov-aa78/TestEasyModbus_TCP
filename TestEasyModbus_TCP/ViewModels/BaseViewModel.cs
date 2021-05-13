using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestEasyModbus_TCP.Models;

namespace TestEasyModbus_TCP.ViewModels
{



    public class BaseViewModel
    {
        public string ErrorRead { set; get; }



        public string DataReadQF1_PSUM3_W { get; }
        public string DataReadQS1_PSUM3_W { get; }
        public string DataReadQS3_PSUM3_W { get; }
        public string DataReadQS4_PSUM3_W { get; }
        public string DataReadQS5_PSUM3_W { get; }
        public string DataReadQS6_PSUM3_W { get; }
        public string DataReadQS7_PSUM3_W { get; }
        public string DataReadQS8_PSUM3_W { get; }
        public string DataReadQS9_PSUM3_W { get; }
        public string DataReadQS10_PSUM3_W { get; }
        public string DataReadQS11_PSUM3_W { get; }
        public string DataReadQS12_PSUM3_W { get; }
        public string DataReadQS13_PSUM3_W { get; }
        public string DataReadQS14_PSUM3_W { get; }
        public string DataReadQS15_PSUM3_W { get; }
        public string DataReadQS16_PSUM3_W { get; }
        public string DataReadQS17_PSUM3_W { get; }
        public string DataReadQS18_PSUM3_W { get; }
        public string DataReadQS19_PSUM3_W { get; }
        public string DataReadQF3_PSUM3_W { get; }
        public string DataReadQF4_PSUM3_W { get; }
        public string DataReadQF5_PSUM3_W { get; }
        public string DataReadQF6_PSUM3_W { get; }
        public string DataReadQF7_PSUM3_W { get; }
        public string DataReadQF8_PSUM3_W { get; }

        public string DataReadQF1_WHSUM3_Wh { get; }
        public string DataReadQS1_WHSUM3_Wh { get; }
        public string DataReadQS3_WHSUM3_Wh { get; }
        public string DataReadQS4_WHSUM3_Wh { get; }
        public string DataReadQS5_WHSUM3_Wh { get; }
        public string DataReadQS6_WHSUM3_Wh { get; }
        public string DataReadQS7_WHSUM3_Wh { get; }
        public string DataReadQS8_WHSUM3_Wh { get; }
        public string DataReadQS9_WHSUM3_Wh { get; }
        public string DataReadQS10_WHSUM3_Wh { get; }
        public string DataReadQS11_WHSUM3_Wh { get; }
        public string DataReadQS12_WHSUM3_Wh { get; }
        public string DataReadQS13_WHSUM3_Wh { get; }
        public string DataReadQS14_WHSUM3_Wh { get; }
        public string DataReadQS15_WHSUM3_Wh { get; }
        public string DataReadQS16_WHSUM3_Wh { get; }
        public string DataReadQS17_WHSUM3_Wh { get; }
        public string DataReadQS18_WHSUM3_Wh { get; }
        public string DataReadQS19_WHSUM3_Wh { get; }
        public string DataReadQF3_WHSUM3_Wh { get; }
        public string DataReadQF4_WHSUM3_Wh { get; }
        public string DataReadQF5_WHSUM3_Wh { get; }
        public string DataReadQF6_WHSUM3_Wh { get; }
        public string DataReadQF7_WHSUM3_Wh { get; }
        public string DataReadQF8_WHSUM3_Wh { get; }

        public string DataReadQF2_PSUM3_W { get; }
        public string DataReadQS20_PSUM3_W { get; }
        public string DataReadQS21_PSUM3_W { get; }
        public string DataReadQS22_PSUM3_W { get; }
        public string DataReadQS23_PSUM3_W { get; }
        public string DataReadQS24_PSUM3_W { get; }
        public string DataReadQS25_PSUM3_W { get; }
        public string DataReadQS26_PSUM3_W { get; }
        public string DataReadQS27_PSUM3_W { get; }
        public string DataReadQS28_PSUM3_W { get; }
        public string DataReadQS29_PSUM3_W { get; }
        public string DataReadQS31_PSUM3_W { get; }
        public string DataReadQS32_PSUM3_W { get; }
        public string DataReadQS33_PSUM3_W { get; }
        public string DataReadQS34_PSUM3_W { get; }
        public string DataReadQS35_PSUM3_W { get; }
        public string DataReadQS36_PSUM3_W { get; }
        public string DataReadQS37_PSUM3_W { get; }
        public string DataReadQS38_PSUM3_W { get; }
        public string DataReadQF9_PSUM3_W { get; }
        public string DataReadQF10_PSUM3_W { get; }
        public string DataReadQF11_PSUM3_W { get; }
        public string DataReadQF12_PSUM3_W { get; }
        public string DataReadQF13_PSUM3_W { get; }

        public string DataReadQF2_WHSUM3_Wh { get; }
        public string DataReadQS20_WHSUM3_Wh { get; }
        public string DataReadQS21_WHSUM3_Wh { get; }
        public string DataReadQS22_WHSUM3_Wh { get; }
        public string DataReadQS23_WHSUM3_Wh { get; }
        public string DataReadQS24_WHSUM3_Wh { get; }
        public string DataReadQS25_WHSUM3_Wh { get; }
        public string DataReadQS26_WHSUM3_Wh { get; }
        public string DataReadQS27_WHSUM3_Wh { get; }
        public string DataReadQS28_WHSUM3_Wh { get; }
        public string DataReadQS29_WHSUM3_Wh { get; }
        public string DataReadQS31_WHSUM3_Wh { get; }
        public string DataReadQS32_WHSUM3_Wh { get; }
        public string DataReadQS33_WHSUM3_Wh { get; }
        public string DataReadQS34_WHSUM3_Wh { get; }
        public string DataReadQS35_WHSUM3_Wh { get; }
        public string DataReadQS36_WHSUM3_Wh { get; }
        public string DataReadQS37_WHSUM3_Wh { get; }
        public string DataReadQS38_WHSUM3_Wh { get; }
        public string DataReadQF9_WHSUM3_Wh { get; }
        public string DataReadQF10_WHSUM3_Wh { get; }
        public string DataReadQF11_WHSUM3_Wh { get; }
        public string DataReadQF12_WHSUM3_Wh { get; }
        public string DataReadQF13_WHSUM3_Wh { get; }





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

        #region Секция шин 2 - Инициализация
        static string IP_2 = "192.168.20.181";
        static int Port_2 = 502;

        static UMG_96RM QF2 = new UMG_96RM(IP_2, Port_2, 200);
        static UMG_96RM QS20 = new UMG_96RM(IP_2, Port_2, 20);
        static UMG_96RM QS21 = new UMG_96RM(IP_2, Port_2, 21);
        static UMG_96RM QS22 = new UMG_96RM(IP_2, Port_2, 22);
        static UMG_96RM QS23 = new UMG_96RM(IP_2, Port_2, 23);
        static UMG_96RM QS24 = new UMG_96RM(IP_2, Port_2, 24);
        static UMG_96RM QS25 = new UMG_96RM(IP_2, Port_2, 25);
        static UMG_96RM QS26 = new UMG_96RM(IP_2, Port_2, 26);
        static UMG_96RM QS27 = new UMG_96RM(IP_2, Port_2, 27);
        static UMG_96RM QS28 = new UMG_96RM(IP_2, Port_2, 28);
        static UMG_96RM QS29 = new UMG_96RM(IP_2, Port_2, 29);
        static UMG_96RM QS31 = new UMG_96RM(IP_2, Port_2, 31);
        static UMG_96RM QS32 = new UMG_96RM(IP_2, Port_2, 32);
        static UMG_96RM QS33 = new UMG_96RM(IP_2, Port_2, 33);
        static UMG_96RM QS34 = new UMG_96RM(IP_2, Port_2, 34);
        static UMG_96RM QS35 = new UMG_96RM(IP_2, Port_2, 35);
        static UMG_96RM QS36 = new UMG_96RM(IP_2, Port_2, 36);
        static UMG_96RM QS37 = new UMG_96RM(IP_2, Port_2, 37);
        static UMG_96RM QS38 = new UMG_96RM(IP_2, Port_2, 38);
        static UMG_96RM QF9 = new UMG_96RM(IP_2, Port_2, 59);
        static UMG_96RM QF10 = new UMG_96RM(IP_2, Port_2, 60);
        static UMG_96RM QF11 = new UMG_96RM(IP_2, Port_2, 61);
        static UMG_96RM QF12 = new UMG_96RM(IP_2, Port_2, 62);
        static UMG_96RM QF13 = new UMG_96RM(IP_2, Port_2, 63);



        #endregion

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


        static RegMesUMG QF2Data = new RegMesUMG { };
        static RegMesUMG QS20Data = new RegMesUMG { };
        static RegMesUMG QS21Data = new RegMesUMG { };
        static RegMesUMG QS22Data = new RegMesUMG { };
        static RegMesUMG QS23Data = new RegMesUMG { };
        static RegMesUMG QS24Data = new RegMesUMG { };
        static RegMesUMG QS25Data = new RegMesUMG { };
        static RegMesUMG QS26Data = new RegMesUMG { };
        static RegMesUMG QS27Data = new RegMesUMG { };
        static RegMesUMG QS28Data = new RegMesUMG { };
        static RegMesUMG QS29Data = new RegMesUMG { };
        static RegMesUMG QS31Data = new RegMesUMG { };
        static RegMesUMG QS32Data = new RegMesUMG { };
        static RegMesUMG QS33Data = new RegMesUMG { };
        static RegMesUMG QS34Data = new RegMesUMG { };
        static RegMesUMG QS35Data = new RegMesUMG { };
        static RegMesUMG QS36Data = new RegMesUMG { };
        static RegMesUMG QS37Data = new RegMesUMG { };
        static RegMesUMG QS38Data = new RegMesUMG { };
        static RegMesUMG QF9Data = new RegMesUMG { };
        static RegMesUMG QF10Data = new RegMesUMG { };
        static RegMesUMG QF11Data = new RegMesUMG { };
        static RegMesUMG QF12Data = new RegMesUMG { };
        static RegMesUMG QF13Data = new RegMesUMG { };

        static ExcelReport PowerReport = new ExcelReport();
        static string[] ArrayPower = new string[25];

    public BaseViewModel()
        {
            #region   Сукция 1  - Чтение данных

            QF1Data =  QF1.GetAllData(QF1Data );
            QS1Data  = QS1.GetAllData(QS1Data );
            QS3Data  = QS3.GetAllData(QS3Data );
            QS4Data  = QS4.GetAllData(QS4Data );
            QS5Data  = QS5.GetAllData(QS5Data );
            QS6Data  = QS6.GetAllData(QS6Data );
            QS7Data  = QS7.GetAllData(QS7Data );
            QS8Data  = QS8.GetAllData(QS8Data );
            QS9Data  = QS9.GetAllData(QS9Data );
            QS10Data = QS10.GetAllData(QS10Data);
            QS11Data = QS11.GetAllData(QS11Data);
            QS12Data = QS12.GetAllData(QS12Data);
            QS13Data = QS13.GetAllData(QS13Data);
            QS14Data = QS14.GetAllData(QS14Data);
            QS15Data = QS15.GetAllData(QS15Data);
            QS16Data = QS16.GetAllData(QS16Data);
            QS17Data = QS17.GetAllData(QS17Data);
            QS18Data = QS18.GetAllData(QS18Data);
            QS19Data = QS19.GetAllData(QS19Data);
            QF3Data  = QF3.GetAllData(QF3Data );
            QF4Data  = QF4.GetAllData(QF4Data );
            QF5Data  = QF5.GetAllData(QF5Data );
            QF6Data  = QF6.GetAllData(QF6Data );
            QF7Data =  QF7.GetAllData(QF7Data );
            QF8Data =  QF8.GetAllData (QF8Data);

            #endregion

            #region Сукция 2  - Чтение данных

             QF2Data =  QF2.GetAllData(QF2Data); 
             QS20Data = QS20.GetAllData(QS20Data);
             QS21Data = QS21.GetAllData(QS21Data);
             QS22Data = QS22.GetAllData(QS22Data);
             QS23Data = QS23.GetAllData(QS23Data);
             QS24Data = QS24.GetAllData(QS24Data);
             QS25Data = QS25.GetAllData(QS25Data);
             QS26Data = QS26.GetAllData(QS26Data);
             QS27Data = QS27.GetAllData(QS27Data);
             QS28Data = QS28.GetAllData(QS28Data);
             QS29Data = QS29.GetAllData(QS29Data);
             QS31Data = QS31.GetAllData(QS31Data);
             QS32Data = QS32.GetAllData(QS32Data);
             QS33Data = QS33.GetAllData(QS33Data);
             QS34Data = QS34.GetAllData(QS34Data);
             QS35Data = QS35.GetAllData(QS35Data);
             QS36Data = QS36.GetAllData(QS36Data);
             QS37Data = QS37.GetAllData(QS37Data);
             QS38Data = QS38.GetAllData(QS38Data);
             QF9Data =  QF9.GetAllData(QF9Data);  
             QF10Data = QF10.GetAllData(QF10Data);
             QF11Data = QF11.GetAllData(QF11Data);
             QF12Data = QF12.GetAllData(QF12Data);
             QF13Data = QF13.GetAllData(QF13Data);

            #endregion

           

            try
            {
                #region Секция шин 1 - Чтение

                DataReadQF1_PSUM3_W  = $"{( QF1Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS1_PSUM3_W  = $"{( QS1Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS3_PSUM3_W  = $"{( QS3Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS4_PSUM3_W  = $"{( QS4Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS5_PSUM3_W  = $"{( QS5Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS6_PSUM3_W  = $"{( QS6Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS7_PSUM3_W  = $"{( QS7Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS8_PSUM3_W  = $"{( QS8Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS9_PSUM3_W  = $"{( QS9Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS10_PSUM3_W = $"{( QS10Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS11_PSUM3_W = $"{( QS11Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS12_PSUM3_W = $"{( QS12Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS13_PSUM3_W = $"{( QS13Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS14_PSUM3_W = $"{( QS14Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS15_PSUM3_W = $"{( QS15Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS16_PSUM3_W = $"{( QS16Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS17_PSUM3_W = $"{( QS17Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS18_PSUM3_W = $"{( QS18Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS19_PSUM3_W = $"{( QS19Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF3_PSUM3_W  = $"{( QF3Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF4_PSUM3_W  = $"{( QF4Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF5_PSUM3_W  = $"{( QF5Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF6_PSUM3_W  = $"{( QF6Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF7_PSUM3_W  = $"{( QF7Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF8_PSUM3_W  = $"{(QF8Data.PSUM3_W / 1000).ToString("f2")}";

                DataReadQF1_WHSUM3_Wh = $"{( QF1Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS1_WHSUM3_Wh = $"{( QS1Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS3_WHSUM3_Wh = $"{( QS3Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS4_WHSUM3_Wh = $"{( QS4Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS5_WHSUM3_Wh = $"{( QS5Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS6_WHSUM3_Wh = $"{( QS6Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS7_WHSUM3_Wh = $"{( QS7Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS8_WHSUM3_Wh = $"{( QS8Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS9_WHSUM3_Wh = $"{( QS9Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS10_WHSUM3_Wh= $"{( QS10Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS11_WHSUM3_Wh= $"{( QS11Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS12_WHSUM3_Wh= $"{( QS12Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS13_WHSUM3_Wh= $"{( QS13Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS14_WHSUM3_Wh= $"{( QS14Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS15_WHSUM3_Wh= $"{( QS15Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS16_WHSUM3_Wh= $"{( QS16Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS17_WHSUM3_Wh= $"{( QS17Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS18_WHSUM3_Wh= $"{( QS18Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS19_WHSUM3_Wh= $"{( QS19Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF3_WHSUM3_Wh = $"{( QF3Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF4_WHSUM3_Wh = $"{( QF4Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF5_WHSUM3_Wh = $"{( QF5Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF6_WHSUM3_Wh = $"{( QF6Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF7_WHSUM3_Wh = $"{( QF7Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF8_WHSUM3_Wh = $"{( QF8Data.WHSUM3_Wh / 1000).ToString("f0")}";


                #endregion



                #region Секция шин 2 - Чтение
                DataReadQF2_PSUM3_W  = $"{(QF2Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS20_PSUM3_W = $"{(QS20Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS21_PSUM3_W = $"{(QS21Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS22_PSUM3_W = $"{(QS22Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS23_PSUM3_W = $"{(QS23Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS24_PSUM3_W = $"{(QS24Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS25_PSUM3_W = $"{(QS25Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS26_PSUM3_W = $"{(QS26Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS27_PSUM3_W = $"{(QS27Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS28_PSUM3_W = $"{(QS28Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS29_PSUM3_W = $"{(QS29Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS31_PSUM3_W = $"{(QS31Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS32_PSUM3_W = $"{(QS32Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS33_PSUM3_W = $"{(QS33Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS34_PSUM3_W = $"{(QS34Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS35_PSUM3_W = $"{(QS35Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS36_PSUM3_W = $"{(QS36Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS37_PSUM3_W = $"{(QS37Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQS38_PSUM3_W = $"{(QS38Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF9_PSUM3_W  = $"{(QF9Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF10_PSUM3_W = $"{(QF10Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF11_PSUM3_W = $"{(QF11Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF12_PSUM3_W = $"{(QF12Data.PSUM3_W / 1000).ToString("f2")}";
                DataReadQF13_PSUM3_W = $"{(QF13Data.PSUM3_W / 1000).ToString("f2")}";

                DataReadQF2_WHSUM3_Wh  = $"{(QF2Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS20_WHSUM3_Wh = $"{(QS20Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS21_WHSUM3_Wh = $"{(QS21Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS22_WHSUM3_Wh = $"{(QS22Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS23_WHSUM3_Wh = $"{(QS23Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS24_WHSUM3_Wh = $"{(QS24Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS25_WHSUM3_Wh = $"{(QS25Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS26_WHSUM3_Wh = $"{(QS26Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS27_WHSUM3_Wh = $"{(QS27Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS28_WHSUM3_Wh = $"{(QS28Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS29_WHSUM3_Wh = $"{(QS29Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS31_WHSUM3_Wh = $"{(QS31Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS32_WHSUM3_Wh = $"{(QS32Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS33_WHSUM3_Wh = $"{(QS33Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS34_WHSUM3_Wh = $"{(QS34Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS35_WHSUM3_Wh = $"{(QS35Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS36_WHSUM3_Wh = $"{(QS36Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS37_WHSUM3_Wh = $"{(QS37Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQS38_WHSUM3_Wh = $"{(QS38Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF9_WHSUM3_Wh  = $"{(QF9Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF10_WHSUM3_Wh = $"{(QF10Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF11_WHSUM3_Wh = $"{(QF11Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF12_WHSUM3_Wh = $"{(QF12Data.WHSUM3_Wh / 1000).ToString("f0")}";
                DataReadQF13_WHSUM3_Wh = $"{(QF13Data.WHSUM3_Wh / 1000).ToString("f0")}";

                #region Report
                // -------                Создаём массив данных для отчёта
                // секция 1
                ArrayPower[0] = "";
                ArrayPower[1] = DataReadQF1_PSUM3_W;
                ArrayPower[2] = DataReadQS1_PSUM3_W;
                ArrayPower[3] = DataReadQS3_PSUM3_W;
                ArrayPower[4] = DataReadQS4_PSUM3_W;
                ArrayPower[5] = DataReadQS5_PSUM3_W;
                ArrayPower[6] = DataReadQS6_PSUM3_W;
                ArrayPower[7] = DataReadQS7_PSUM3_W;
                ArrayPower[8] = DataReadQS8_PSUM3_W;
                ArrayPower[9] = DataReadQS9_PSUM3_W;
                ArrayPower[10] = DataReadQS10_PSUM3_W;
                ArrayPower[11] = DataReadQS11_PSUM3_W;
                ArrayPower[12] = DataReadQF4_PSUM3_W;
                ArrayPower[13] = DataReadQF5_PSUM3_W;
                ArrayPower[14] = DataReadQF6_PSUM3_W;
                ArrayPower[15] = DataReadQF7_PSUM3_W;
                ArrayPower[16] = DataReadQF8_PSUM3_W;
                ArrayPower[17] = DataReadQS12_PSUM3_W;
                ArrayPower[18] = DataReadQS13_PSUM3_W;
                ArrayPower[19] = DataReadQS14_PSUM3_W;
                ArrayPower[20] = DataReadQS15_PSUM3_W;
                ArrayPower[21] = DataReadQS16_PSUM3_W;
                ArrayPower[22] = DataReadQS17_PSUM3_W;
                ArrayPower[23] = DataReadQS18_PSUM3_W;
                ArrayPower[24] = DataReadQS19_PSUM3_W;

                // секция 2
                ArrayPower[25] = DataReadQF2_PSUM3_W;
                ArrayPower[26] = DataReadQS20_PSUM3_W;
                ArrayPower[27] = DataReadQS21_PSUM3_W;
                ArrayPower[28] = DataReadQS22_PSUM3_W;
                ArrayPower[29] = DataReadQS23_PSUM3_W;
                ArrayPower[30] = DataReadQS24_PSUM3_W;
                ArrayPower[31] = DataReadQS25_PSUM3_W;
                ArrayPower[32] = DataReadQS26_PSUM3_W;
                ArrayPower[33] = DataReadQS27_PSUM3_W;
                ArrayPower[34] = DataReadQF9_PSUM3_W;
                ArrayPower[35] = DataReadQF10_PSUM3_W;
                ArrayPower[36] = DataReadQF11_PSUM3_W;
                ArrayPower[37] = DataReadQF12_PSUM3_W;
                ArrayPower[38] = DataReadQF13_PSUM3_W;
                ArrayPower[39] = DataReadQS28_PSUM3_W;
                ArrayPower[40] = DataReadQS29_PSUM3_W;
                ArrayPower[41] = DataReadQS31_PSUM3_W;
                ArrayPower[42] = DataReadQS32_PSUM3_W;
                ArrayPower[43] = DataReadQS33_PSUM3_W;
                ArrayPower[44] = DataReadQS34_PSUM3_W;
                ArrayPower[45] = DataReadQS35_PSUM3_W;
                ArrayPower[46] = DataReadQS36_PSUM3_W;
                ArrayPower[47] = DataReadQS37_PSUM3_W;
                ArrayPower[48] = DataReadQS38_PSUM3_W;
                ArrayPower[49] = DataReadQF3_PSUM3_W;

                PowerReport.Report(ArrayPower);
                #endregion


                #endregion

            }
            catch (Exception e)
            {
                ErrorRead = e.ToString();
            }
        }
    }
}