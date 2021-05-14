using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace TestEasyModbus_TCP.Models
{
    class ExcelReport
    {
        //для отображения 00, 01 и тд
        string month;
        string day;
        string hour;
        string minute;
        string second;


        public void Report(String[] ArrayPower )//(string comanda)для тех кто не догадался string comanda отвечает за строку запроса к базе данных у меня все по классам и функциям раскидано так что можно его убрать показал цикл на примере дата грид кстати скоростью высокой не будет отличаться есть варианты и по быстрее но для не больших обьемов скорость приличная...
        {
            #region 1 вариант рабочий
            // Книга Excel.
            Excel.Workbook m_workBook = null;
            // Страница Excel.
            Excel.Worksheet m_workSheet = null;
            Excel._Application m_app = null;

            //месяц
            if (DateTime.Now.Month < 10)
            {
                month = "0" + DateTime.Now.Month.ToString();
            }
            else
            {
                month = DateTime.Now.Month.ToString();
            }
            //День
            if (DateTime.Now.Day < 10)
            {
                day = "0" + DateTime.Now.Day.ToString();
            }
            else
            {
                day = DateTime.Now.Day.ToString();
            }
            //Час
            if (DateTime.Now.Hour < 10)
            {
                hour = "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                hour = DateTime.Now.Hour.ToString();
            }
            //Минута
            if (DateTime.Now.Minute < 10)
            {
                minute = "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                minute = DateTime.Now.Minute.ToString();
            }
            //Секунда
            if (DateTime.Now.Second < 10)
            {
                second = "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                second = DateTime.Now.Second.ToString();
            }
             
            string filename = "D:\\РУ - 0,4кВ\\Отчет\\Отчет РУ-0.4кВ " +
               DateTime.Now.Year + "." +
               month + "." +
               day + " " +
               hour + "_" +
               minute + "_" +
               second +
               ".xlsx";// по умолчанию сохраняет в корень диска С:

            //string filename = "D:\\Отчет за " +
            //    DateTime.Now.Year + "." +
            //    DateTime.Now.Month + "." +
            //    DateTime.Now.Day + "_" +
            //    DateTime.Now.Hour + "_" +
            //    DateTime.Now.Minute + "_" +
            //    DateTime.Now.Second +
            //    ".xlsx";// по умолчанию сохраняет в корень диска С:
            try
            {
                // Создание приложения Excel.
                m_app = new Excel.Application();     ////ApplicationClass();
                // Приложение "невидимо".
                m_app.Visible = false;
                // Приложение управляется пользователем.
                m_app.UserControl = true;
                // Добавление книги Excel.
                m_workBook = m_app.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                // Связь со страницей Excel.
                m_workSheet = m_app.ActiveSheet as Excel.Worksheet;

                //Заполняем шапку документа
                m_workSheet.Cells[1, 1] = "№ Панели";
                m_workSheet.Cells[1, 2] = "№ Фидера";
                m_workSheet.Cells[1, 3] = "Назначение линии";
                m_workSheet.Cells[1, 4] = "Трансформаторы \r\n тока,А";
                m_workSheet.Cells[1, 5] = $"{hour}час \r\n{day}.{month}.{DateTime.Now.Year}г";//$"{DateTime.Now.Hour}час \r\n{DateTime.Now.Day} \r\n{DateTime.Now.Month} \r\n{DateTime.Now.Year}г";

                m_workSheet.Cells[28, 1] = m_workSheet.Cells[1, 1];
                m_workSheet.Cells[28, 2] = m_workSheet.Cells[1, 2];
                m_workSheet.Cells[28, 3] = m_workSheet.Cells[1, 3];
                m_workSheet.Cells[28, 4] = m_workSheet.Cells[1, 4];
                m_workSheet.Cells[28, 5] = m_workSheet.Cells[1, 5];
               

                m_workSheet.Cells[2, 1] = "1";
                m_workSheet.Cells[2, 2] = "2";
                m_workSheet.Cells[2, 3] = "3";
                m_workSheet.Cells[2, 4] = "4";
                m_workSheet.Cells[2, 5] = "5";
                

                m_workSheet.Cells[29, 1] = m_workSheet.Cells[2, 1];
                m_workSheet.Cells[29, 2] = m_workSheet.Cells[2, 2];
                m_workSheet.Cells[29, 3] = m_workSheet.Cells[2, 3];
                m_workSheet.Cells[29, 4] = m_workSheet.Cells[2, 4];
                m_workSheet.Cells[29, 5] = m_workSheet.Cells[2, 5];
                m_workSheet.Cells[29, 6] = m_workSheet.Cells[2, 6];

                //Заполняем статичные поля "№ Панели"
                m_workSheet.Cells[3, 1] = "1";
                m_workSheet.Cells[4, 1] = "2";
                m_workSheet.Cells[5, 1] = "3";
                m_workSheet.Cells[6, 1] = "4";
                m_workSheet.Cells[7, 1] = "5";
                m_workSheet.Cells[8, 1] = "6";
                m_workSheet.Cells[9, 1] = "7";
                m_workSheet.Cells[10, 1] = "8";
                m_workSheet.Cells[11, 1] = "9";
                m_workSheet.Cells[12, 1] = "10";
                m_workSheet.Cells[13, 1] = "11";
                m_workSheet.Cells[14, 1] = "12";
                m_workSheet.Cells[15, 1] = "13";
                m_workSheet.Cells[16, 1] = "14";
                m_workSheet.Cells[17, 1] = "15";
                m_workSheet.Cells[18, 1] = "16";
                m_workSheet.Cells[19, 1] = "17";
                m_workSheet.Cells[20, 1] = "18";
                m_workSheet.Cells[21, 1] = "19";
                m_workSheet.Cells[22, 1] = "19";
                m_workSheet.Cells[23, 1] = "20";
                m_workSheet.Cells[24, 1] = "21";
                m_workSheet.Cells[25, 1] = "22";
                m_workSheet.Cells[26, 1] = "23";
                m_workSheet.Cells[27, 1] = "24";

                m_workSheet.Cells[30, 1] = "25";
                m_workSheet.Cells[31, 1] = "26";
                m_workSheet.Cells[32, 1] = "27";
                m_workSheet.Cells[33, 1] = "28";
                m_workSheet.Cells[34, 1] = "29";
                m_workSheet.Cells[35, 1] = "30";
                m_workSheet.Cells[36, 1] = "31";
                m_workSheet.Cells[37, 1] = "32";
                m_workSheet.Cells[38, 1] = "33";
                m_workSheet.Cells[39, 1] = "34";
                m_workSheet.Cells[40, 1] = "35";
                m_workSheet.Cells[41, 1] = "36";
                m_workSheet.Cells[42, 1] = "37";
                m_workSheet.Cells[43, 1] = "38";
                m_workSheet.Cells[44, 1] = "39";
                m_workSheet.Cells[45, 1] = "40";
                m_workSheet.Cells[46, 1] = "41";
                m_workSheet.Cells[47, 1] = "42";
                m_workSheet.Cells[48, 1] = "43";
                m_workSheet.Cells[49, 1] = "44";
                m_workSheet.Cells[50, 1] = "45";
                m_workSheet.Cells[51, 1] = "46";
                m_workSheet.Cells[52, 1] = "47";
                m_workSheet.Cells[53, 1] = "48";
                m_workSheet.Cells[54, 1] = "49";

                //Заполняем статичные поля "№ Фидера"
                m_workSheet.Cells[3, 2] = " =QF1";
                m_workSheet.Cells[4, 2] = " =QS1";
                m_workSheet.Cells[5, 2] = " =QS3";
                m_workSheet.Cells[6, 2] = " =QS4";
                m_workSheet.Cells[7, 2] = " =QS5";
                m_workSheet.Cells[8, 2] = " =QS6";
                m_workSheet.Cells[9, 2] = " =QS7";
                m_workSheet.Cells[10, 2] = " =QS8";
                m_workSheet.Cells[11, 2] = " =QS9";
                m_workSheet.Cells[12, 2] = " =QS10";
                m_workSheet.Cells[13, 2] = " =QS11";
                m_workSheet.Cells[14, 2] = " =QF4";
                m_workSheet.Cells[15, 2] = " =QF5";
                m_workSheet.Cells[16, 2] = " =QF6";
                m_workSheet.Cells[17, 2] = " =QF7";
                m_workSheet.Cells[18, 2] = " =QF8";
                m_workSheet.Cells[19, 2] = " =QS12";
                m_workSheet.Cells[20, 2] = " =QS13";
                m_workSheet.Cells[21, 2] = "Шкаф грунтовок";
                m_workSheet.Cells[22, 2] = " =QS14";
                m_workSheet.Cells[23, 2] = " =QS15";
                m_workSheet.Cells[24, 2] = " =QS16";
                m_workSheet.Cells[25, 2] = " =QS17";
                m_workSheet.Cells[26, 2] = " =QS18";
                m_workSheet.Cells[27, 2] = " =QS19";

                m_workSheet.Cells[30, 2] = " =QF2";
                m_workSheet.Cells[31, 2] = " =QS20";
                m_workSheet.Cells[32, 2] = " =QS21";
                m_workSheet.Cells[33, 2] = " =QS22";
                m_workSheet.Cells[34, 2] = " =QS23";
                m_workSheet.Cells[35, 2] = " =QS24";
                m_workSheet.Cells[36, 2] = " =QS25";
                m_workSheet.Cells[37, 2] = " =QS26";
                m_workSheet.Cells[38, 2] = " =QS27";
                m_workSheet.Cells[39, 2] = " =QF9";
                m_workSheet.Cells[40, 2] = " =QF10";
                m_workSheet.Cells[41, 2] = " =QF11";
                m_workSheet.Cells[42, 2] = " =QF12";
                m_workSheet.Cells[43, 2] = " =QF13";
                m_workSheet.Cells[44, 2] = " =QS28";
                m_workSheet.Cells[45, 2] = " =QS29";
                m_workSheet.Cells[46, 2] = " =QS31";
                m_workSheet.Cells[47, 2] = " =QS32";
                m_workSheet.Cells[48, 2] = " =QS33";
                m_workSheet.Cells[49, 2] = " =QS34";
                m_workSheet.Cells[50, 2] = " =QS35";
                m_workSheet.Cells[51, 2] = " =QS35";
                m_workSheet.Cells[52, 2] = " =QS37";
                m_workSheet.Cells[53, 2] = " =QS38";
                m_workSheet.Cells[54, 2] = " =QF3";

                //Заполняем статичные поля "Название линии"
                m_workSheet.Cells[3, 3] = "Ввод №1 защита от перенапряжения";
                m_workSheet.Cells[4, 3] = "ВРУ-СН, Гипсовое отделение, Ввод №1";
                m_workSheet.Cells[5, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[6, 3] = "ВРУ-1, АБК, Ввод №1";
                m_workSheet.Cells[7, 3] = "ВРУ-2, КПП, Ввод №1";
                m_workSheet.Cells[8, 3] = "Натяжение пленки";
                m_workSheet.Cells[9, 3] = "ШР-1, Мойка";
                m_workSheet.Cells[10, 3] = "Палетайзер";
                m_workSheet.Cells[11, 3] = "Наружное освещение, Ввод №1";
                m_workSheet.Cells[12, 3] = "АУКРМ-1";
                m_workSheet.Cells[13, 3] = "АУКРМ-2";
                m_workSheet.Cells[14, 3] = "Дробильная установка Н 2.4 +DA01";
                m_workSheet.Cells[15, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[16, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[17, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[18, 3] = "Компрессорная ШУ-К";
                m_workSheet.Cells[19, 3] = "ГРЩ 0,4 кВ КНС-1,2 сигнализация Н1.12";
                m_workSheet.Cells[20, 3] = "Склад комплектации";
                m_workSheet.Cells[21, 3] = "Cчётчик СЕ102 №007495044001680";
                m_workSheet.Cells[22, 3] = "Линия ГРУНТОВОК";
                m_workSheet.Cells[23, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[24, 3] = "Стацион. Вакуумная установка";
                m_workSheet.Cells[25, 3] = "ГРЩ 0,4кВ, ВРУ-3 насосная, Н1.7";
                m_workSheet.Cells[26, 3] = "Фасовочная машина Н1.9";
                m_workSheet.Cells[27, 3] = "СПП-250 Перлит ГРЩ 0,4кВ ШУ Н2.11";

                m_workSheet.Cells[30, 3] = "Ввод №2 защита от перенапряжения";
                m_workSheet.Cells[31, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[32, 3] = "АУКРМ-3";
                m_workSheet.Cells[33, 3] = "АУКРМ-4";
                m_workSheet.Cells[34, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[35, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[36, 3] = "ВРУ СН Гипсовое отделение Ввод №2";
                m_workSheet.Cells[37, 3] = "ВРУ-1 АБК Ввод №2";
                m_workSheet.Cells[38, 3] = "ГРЩ 0,4кВ ВРУ - Дробилки";
                m_workSheet.Cells[39, 3] = "Гипсовый завод Н2.3 +DB01";
                m_workSheet.Cells[40, 3] = "Завод смесей Н1.3 +DG01";
                m_workSheet.Cells[41, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[42, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[43, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[44, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[45, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[46, 3] = "Теплый склад, ВРУ СН";
                m_workSheet.Cells[47, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[48, 3] = "Наружное освещение, Ввод №1";
                m_workSheet.Cells[49, 3] = "ВРУ-2, КПП, Ввод №2, Н2.8";
                m_workSheet.Cells[50, 3] = "ШВР-2, Холодный склад, Н2.9";
                m_workSheet.Cells[51, 3] = "ГРЩ 0,4кВ ШУ ТЗП, Н2.10";
                m_workSheet.Cells[52, 3] = "РЕЗЕРВ";
                m_workSheet.Cells[53, 3] = "ГРЩ 0,4кВ, ВРУ-3 насосная, Н2.7";
                m_workSheet.Cells[54, 3] = "Секционный выключатель";

                //Заполняем статичные поля "Трансформаторы тока"
                m_workSheet.Cells[3, 4] = "3000/5";
                m_workSheet.Cells[4, 4] = "250/5";
                m_workSheet.Cells[5, 4] = "150/5";
                m_workSheet.Cells[6, 4] = "250/5";
                m_workSheet.Cells[7, 4] = "100/5";
                m_workSheet.Cells[8, 4] = "100/5";
                m_workSheet.Cells[9, 4] = "100/5";
                m_workSheet.Cells[10, 4] = "100/5";
                m_workSheet.Cells[11, 4] = "100/5";
                m_workSheet.Cells[12, 4] = "500/5";
                m_workSheet.Cells[13, 4] = "500/5";
                m_workSheet.Cells[14, 4] = "1200/5";
                m_workSheet.Cells[15, 4] = "800/5";
                m_workSheet.Cells[16, 4] = "600/5";
                m_workSheet.Cells[17, 4] = "600/5";
                m_workSheet.Cells[18, 4] = "600/5";
                m_workSheet.Cells[19, 4] = "250/5";
                m_workSheet.Cells[20, 4] = "400/5";
                m_workSheet.Cells[21, 4] = " - ";
                m_workSheet.Cells[22, 4] = "400/5";
                m_workSheet.Cells[23, 4] = "400/5";
                m_workSheet.Cells[24, 4] = "400/5";
                m_workSheet.Cells[25, 4] = "150/5";
                m_workSheet.Cells[26, 4] = "250/5";
                m_workSheet.Cells[27, 4] = "150/5";

                m_workSheet.Cells[30, 4] = "3000/5";
                m_workSheet.Cells[31, 4] = "150/5";
                m_workSheet.Cells[32, 4] = "500/5";
                m_workSheet.Cells[33, 4] = "500/5";
                m_workSheet.Cells[34, 4] = "400/5";
                m_workSheet.Cells[35, 4] = "250/5";
                m_workSheet.Cells[36, 4] = "250/5";
                m_workSheet.Cells[37, 4] = "400/5";
                m_workSheet.Cells[38, 4] = "250/5";
                m_workSheet.Cells[39, 4] = "1200/5";
                m_workSheet.Cells[40, 4] = "1200/5";
                m_workSheet.Cells[41, 4] = "1200/5";
                m_workSheet.Cells[42, 4] = "600/5";
                m_workSheet.Cells[43, 4] = "600/5";
                m_workSheet.Cells[44, 4] = "400/5";
                m_workSheet.Cells[45, 4] = "250/5";
                m_workSheet.Cells[46, 4] = "150/5";
                m_workSheet.Cells[47, 4] = "150/5";
                m_workSheet.Cells[48, 4] = "100/5";
                m_workSheet.Cells[49, 4] = "100/5";
                m_workSheet.Cells[50, 4] = "100/5";
                m_workSheet.Cells[51, 4] = "100/5";
                m_workSheet.Cells[52, 4] = "150/5";
                m_workSheet.Cells[53, 4] = "150/5";
                m_workSheet.Cells[54, 4] = "3000/5";

                //Заполнение данными 
                m_workSheet.Cells[21, 5] = "Показания вносятся вручную шкаф грунтовок";
                for (int i = 1; i <= 49; i++)
                {
                    if (i < 19)
                    {
                         m_workSheet.Cells[i + 2, 5] = ArrayPower[i];
                    }
                    else if (i < 25)
                    {
                        m_workSheet.Cells[i + 3, 5] = ArrayPower[i];
                    }
                    else 
                    {
                        m_workSheet.Cells[i + 5, 5] = ArrayPower[i];
                    }
                }
                    


                // Пишем строку
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    DataGridViewRow row = dataGridView1.Rows[i]; // строки
                //    for (int j = 0; j < row.Cells.Count; j++) //цикл по ячейкам строки
                //    {


                //        ObjExcel.Cells[i + 1, j + 1] = row.Cells[j].Value;
                //    }
                //}
                //m_workSheet.Cells[10, 10] = "Test";
                // Сохранение файла Excel.
                m_workBook.SaveCopyAs(filename);
                
            }
            finally
            {
                // Закрытие книги.
                m_workBook.Close(false, "", Type.Missing);
                // Закрытие приложения Excel.
                m_app.Quit();

                m_workBook = null;
                m_workSheet = null;
                m_app = null;
                GC.Collect();
            }


            #endregion
        }
    }
}
