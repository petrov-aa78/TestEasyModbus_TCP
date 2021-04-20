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
      

        public string DataReader1 { set; get; }
        public string DataReader2 { set; get; }
        public string DataReader3 { set; get; }

        public string DataReader4 { set; get; }
        public string DataReader5 { set; get; }
        public string DataReader6 { set; get; }

        public string DataReader7 { set; get; }
        public string DataReader8 { set; get; }
        public string DataReader9 { set; get; }

        private string U = " В";
        private string U1 = "LN1 - ";
        private string U2 = "LN2 - ";
        private string U3 = "LN3 - ";


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

       public UMG_96RM QF2 = new UMG_96RM(IP_2, Port_2, 200);
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
            QS10Data = QS1.GetAllData(QS10Data);
            QS11Data = QS1.GetAllData(QS11Data);
            QS12Data = QS1.GetAllData(QS12Data);
            QS13Data = QS1.GetAllData(QS13Data);
            QS14Data = QS1.GetAllData(QS14Data);
            QS15Data = QS1.GetAllData(QS15Data);
            QS16Data = QS1.GetAllData(QS16Data);
            QS17Data = QS1.GetAllData(QS17Data);
            QS18Data = QS1.GetAllData(QS18Data);
            QS19Data = QS1.GetAllData(QS19Data);
            QF3Data  = QF3.GetAllData(QF3Data );
            QF4Data  = QF4.GetAllData(QF4Data );
            QF5Data  = QF5.GetAllData(QF5Data );
            QF6Data  = QF6.GetAllData(QF6Data );
            QF7Data =  QF7.GetAllData(QF7Data );
            QF8Data = QF8.GetAllData (QF8Data);

            #endregion

            #region Сукция 2  - Чтение данных

             QF2Data = QF2.GetAllData(QF2Data); 
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
             QF9Data = QF9.GetAllData(QF9Data);  
             QF10Data = QF10.GetAllData(QF10Data);
             QF11Data = QF11.GetAllData(QF11Data);
             QF12Data = QF12.GetAllData(QF12Data);
             QF13Data = QF13.GetAllData(QF13Data);

            #endregion

           

            try
            {
               
                              
                
               
                #region Секция шин 2 - Чтение

                              
                DataReader1 = $"QF2 I_LN1 = { QF2Data.ILN1_A.ToString("#.00")}A";
                DataReader2 = $"QF2 I_LN2 = { QF2Data.ILN2_A.ToString("#.00")}A";
                DataReader3 = $"QF2 I_LN3 = { QF2Data.ILN2_A.ToString("#.00")}A";

               
                DataReader4 =  $"QS25 I_LN1 = {Convert.ToString(Math.Round(QS25Data.ILN1_A, 2) )}A";
                DataReader5 =  $"QS25 I_LN2 = { QS25Data.ILN2_A.ToString("f2")}A";
                DataReader6 =  $"QS25 I_LN3 = { QS25Data.ILN3_A.ToString("f2")}A";
              

                DataReader7 = U1 + QS34Data.ULN1_V.ToString("f2") + U;
                DataReader8 = U2 + QS34Data.ULN2_V.ToString("f2") + U;
                DataReader9 = U3 + QS34Data.ULN3_V.ToString("f2") + U;
                                            
                #endregion

            }
            catch (Exception e)
            {
                DataReader1 = e.ToString();
            }
        }
    }
}