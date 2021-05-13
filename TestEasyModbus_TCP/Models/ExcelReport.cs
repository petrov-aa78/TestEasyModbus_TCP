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
        public void Report(String[] ArrayPower )//(string comanda)для тех кто не догадался string comanda отвечает за строку запроса к базе данных у меня все по классам и функциям раскидано так что можно его убрать показал цикл на примере дата грид кстати скоростью высокой не будет отличаться есть варианты и по быстрее но для не больших обьемов скорость приличная...
        {
            #region 1 вариант рабочий
            // Книга Excel.
            Excel.Workbook m_workBook = null;
            // Страница Excel.
            Excel.Worksheet m_workSheet = null;
            Excel._Application m_app = null;
            string filename = "D:\\Отчет за " +
                DateTime.Now.Day + "." +
                DateTime.Now.Month + "." +
                DateTime.Now.Year + ".xlsx";// по умолчанию сохраняет в корень диска С:
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
                m_workSheet.Cells[1, 5] = "Данные";
                m_workSheet.Cells[1, 6] = $"{DateTime.Now.Day} \r\n {DateTime.Now.Month} \r\n {DateTime.Now.Year}";

                m_workSheet.Cells[27, 1] = m_workSheet.Cells[1, 1];
                m_workSheet.Cells[27, 2] = m_workSheet.Cells[1, 2];
                m_workSheet.Cells[27, 3] = m_workSheet.Cells[1, 3];
                m_workSheet.Cells[27, 4] = m_workSheet.Cells[1, 4];
                m_workSheet.Cells[27, 5] = m_workSheet.Cells[1, 5];
                m_workSheet.Cells[27, 6] = m_workSheet.Cells[1, 6];

                m_workSheet.Cells[2, 1] = "1";
                m_workSheet.Cells[2, 2] = "2";
                m_workSheet.Cells[2, 3] = "3";
                m_workSheet.Cells[2, 4] = "4";
                m_workSheet.Cells[2, 5] = "5";
                m_workSheet.Cells[2, 6] = "6";

                m_workSheet.Cells[28, 1] = m_workSheet.Cells[2, 1];
                m_workSheet.Cells[28, 2] = m_workSheet.Cells[2, 2];
                m_workSheet.Cells[28, 3] = m_workSheet.Cells[2, 3];
                m_workSheet.Cells[28, 4] = m_workSheet.Cells[2, 4];
                m_workSheet.Cells[28, 5] = m_workSheet.Cells[2, 5];
                m_workSheet.Cells[28, 6] = m_workSheet.Cells[2, 6];

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
                m_workSheet.Cells[22, 1] = "20";
                m_workSheet.Cells[23, 1] = "21";
                m_workSheet.Cells[24, 1] = "22";
                m_workSheet.Cells[25, 1] = "23";
                m_workSheet.Cells[26, 1] = "24";

                m_workSheet.Cells[29, 1] = "25";
                m_workSheet.Cells[30, 1] = "26";
                m_workSheet.Cells[31, 1] = "27";
                m_workSheet.Cells[32, 1] = "28";
                m_workSheet.Cells[33, 1] = "29";
                m_workSheet.Cells[34, 1] = "30";
                m_workSheet.Cells[35, 1] = "31";
                m_workSheet.Cells[36, 1] = "32";
                m_workSheet.Cells[37, 1] = "33";
                m_workSheet.Cells[38, 1] = "34";
                m_workSheet.Cells[39, 1] = "35";
                m_workSheet.Cells[40, 1] = "36";
                m_workSheet.Cells[41, 1] = "37";
                m_workSheet.Cells[42, 1] = "38";
                m_workSheet.Cells[43, 1] = "39";
                m_workSheet.Cells[44, 1] = "40";
                m_workSheet.Cells[45, 1] = "41";
                m_workSheet.Cells[46, 1] = "42";
                m_workSheet.Cells[47, 1] = "43";
                m_workSheet.Cells[48, 1] = "44";
                m_workSheet.Cells[49, 1] = "45";
                m_workSheet.Cells[50, 1] = "46";
                m_workSheet.Cells[51, 1] = "47";
                m_workSheet.Cells[52, 1] = "48";
                m_workSheet.Cells[53, 1] = "49";

                //Заполняем статичные поля "№ Фидера"
                m_workSheet.Cells[3, 2] = "=QF1";
                m_workSheet.Cells[4, 2] = "=QS1";
                m_workSheet.Cells[5, 2] = "=QS3";
                m_workSheet.Cells[6, 2] = "=QS4";
                m_workSheet.Cells[7, 2] = "=QS5";
                m_workSheet.Cells[8, 2] = "=QS6";
                m_workSheet.Cells[9, 2] = "=QS7";
                m_workSheet.Cells[10, 2] = "=QS8";
                m_workSheet.Cells[11, 2] = "=QS9";
                m_workSheet.Cells[12, 2] = "=QS10";
                m_workSheet.Cells[13, 2] = "=QS11";
                m_workSheet.Cells[14, 2] = "=QF4";
                m_workSheet.Cells[15, 2] = "=QF5";
                m_workSheet.Cells[16, 2] = "=QF6";
                m_workSheet.Cells[17, 2] = "=QF7";
                m_workSheet.Cells[18, 2] = "=QF8";
                m_workSheet.Cells[19, 2] = "=QS12";
                m_workSheet.Cells[20, 2] = "=QS13";
                m_workSheet.Cells[21, 2] = "=QS14";
                m_workSheet.Cells[22, 2] = "=QS15";
                m_workSheet.Cells[23, 2] = "=QS16";
                m_workSheet.Cells[24, 2] = "=QS17";
                m_workSheet.Cells[25, 2] = "=QS18";
                m_workSheet.Cells[26, 2] = "=QS19";

                m_workSheet.Cells[29, 2] = "=QF2";
                m_workSheet.Cells[30, 2] = "=QS20";
                m_workSheet.Cells[31, 2] = "=QS21";
                m_workSheet.Cells[32, 2] = "=QS22";
                m_workSheet.Cells[33, 2] = "=QS23";
                m_workSheet.Cells[34, 2] = "=QS24";
                m_workSheet.Cells[35, 2] = "=QS25";
                m_workSheet.Cells[36, 2] = "=QS26";
                m_workSheet.Cells[37, 2] = "=QS27";
                m_workSheet.Cells[38, 2] = "=QF9";
                m_workSheet.Cells[39, 2] = "=QF10";
                m_workSheet.Cells[40, 2] = "=QF11";
                m_workSheet.Cells[41, 2] = "=QF12";
                m_workSheet.Cells[42, 2] = "=QF13";
                m_workSheet.Cells[43, 2] = "=QS28";
                m_workSheet.Cells[44, 2] = "=QS29";
                m_workSheet.Cells[45, 2] = "=QS31";
                m_workSheet.Cells[46, 2] = "=QS32";
                m_workSheet.Cells[47, 2] = "=QS33";
                m_workSheet.Cells[48, 2] = "=QS34";
                m_workSheet.Cells[49, 2] = "=QS35";
                m_workSheet.Cells[50, 2] = "=QS35";
                m_workSheet.Cells[51, 2] = "=QS37";
                m_workSheet.Cells[52, 2] = "=QS38";
                m_workSheet.Cells[53, 2] = "=QF3";

                //Заполняем статичные поля "Название линии"
                m_workSheet.Cells[3, 1] = "Ввод №1 защита от перенапряжения";
                m_workSheet.Cells[4, 1] = "ВРУ-СН, Гипсовое отделение, Ввод №1";
                m_workSheet.Cells[5, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[6, 1] = "ВРУ-1, АБК, Ввод №1";
                m_workSheet.Cells[7, 1] = "ВРУ-2, КПП, Ввод №1";
                m_workSheet.Cells[8, 1] = "Натяжение пленки";
                m_workSheet.Cells[9, 1] = "ШР-1, Мойка";
                m_workSheet.Cells[10, 1] = "Палетайзер";
                m_workSheet.Cells[11, 1] = "Наружное освещение, Ввод №1";
                m_workSheet.Cells[12, 1] = "АУКРМ-1";
                m_workSheet.Cells[13, 1] = "АУКРМ-2";
                m_workSheet.Cells[14, 1] = "Дробильная установка Н 2.4 +DA01";
                m_workSheet.Cells[15, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[16, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[17, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[18, 1] = "Компрессорная ШУ-К";
                m_workSheet.Cells[19, 1] = "ГРЩ 0,4 кВ КНС-1,2 сигнализация Н1.12";
                m_workSheet.Cells[20, 1] = "Склад комплектации";
                m_workSheet.Cells[21, 1] = "Линия ГРУНТОВОК";
                m_workSheet.Cells[22, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[23, 1] = "Стацион. Вакуумная установка";
                m_workSheet.Cells[24, 1] = "ГРЩ 0,4кВ, ВРУ-3 насосная, Н1.7";
                m_workSheet.Cells[25, 1] = "Фасовочная машина Н1.9";
                m_workSheet.Cells[26, 1] = "СПП-250 Перлит ГРЩ 0,4кВ ШУ Н2.11";

                m_workSheet.Cells[29, 1] = "Ввод №2 защита от перенапряжения";
                m_workSheet.Cells[30, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[31, 1] = "АУКРМ-3";
                m_workSheet.Cells[32, 1] = "АУКРМ-4";
                m_workSheet.Cells[33, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[34, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[35, 1] = "ВРУ СН Гипсовое отделение Ввод №2";
                m_workSheet.Cells[36, 1] = "ВРУ-1 АБК Ввод №2";
                m_workSheet.Cells[37, 1] = "ГРЩ 0,4кВ ВРУ - Дробилки";
                m_workSheet.Cells[38, 1] = "Гипсовый завод Н2.3 +DB01";
                m_workSheet.Cells[39, 1] = "Завод смесей Н1.3 +DG01";
                m_workSheet.Cells[40, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[41, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[42, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[43, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[44, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[45, 1] = "Теплый склад, ВРУ СН";
                m_workSheet.Cells[46, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[47, 1] = "Наружное освещение, Ввод №1";
                m_workSheet.Cells[48, 1] = "ВРУ-2, КПП, Ввод №2, Н2.8";
                m_workSheet.Cells[49, 1] = "ШВР-2, Холодный склад, Н2.9";
                m_workSheet.Cells[50, 1] = "ГРЩ 0,4кВ ШУ ТЗП, Н2.10";
                m_workSheet.Cells[51, 1] = "РЕЗЕРВ";
                m_workSheet.Cells[52, 1] = "ГРЩ 0,4кВ, ВРУ-3 насосная, Н2.7";
                m_workSheet.Cells[53, 1] = "Секционный выключатель";

                //Заполняем статичные поля "Трансформаторы тока"
                m_workSheet.Cells[3, 1] = "3000/5";
                m_workSheet.Cells[4, 1] = "250/5";
                m_workSheet.Cells[5, 1] = "150/5";
                m_workSheet.Cells[6, 1] = "250/5";
                m_workSheet.Cells[7, 1] = "100/5";
                m_workSheet.Cells[8, 1] = "100/5";
                m_workSheet.Cells[9, 1] = "100/5";
                m_workSheet.Cells[10, 1] = "100/5";
                m_workSheet.Cells[11, 1] = "100/5";
                m_workSheet.Cells[12, 1] = "500/5";
                m_workSheet.Cells[13, 1] = "500/5";
                m_workSheet.Cells[14, 1] = "1200/5";
                m_workSheet.Cells[15, 1] = "800/5";
                m_workSheet.Cells[16, 1] = "600/5";
                m_workSheet.Cells[17, 1] = "600/5";
                m_workSheet.Cells[18, 1] = "600/5";
                m_workSheet.Cells[19, 1] = "250/5";
                m_workSheet.Cells[20, 1] = "400/5";
                m_workSheet.Cells[21, 1] = "400/5";
                m_workSheet.Cells[22, 1] = "400/5";
                m_workSheet.Cells[23, 1] = "400/5";
                m_workSheet.Cells[24, 1] = "150/5";
                m_workSheet.Cells[25, 1] = "250/5";
                m_workSheet.Cells[26, 1] = "150/5";

                m_workSheet.Cells[29, 1] = "3000/5";
                m_workSheet.Cells[30, 1] = "150/5";
                m_workSheet.Cells[31, 1] = "500/5";
                m_workSheet.Cells[32, 1] = "500/5";
                m_workSheet.Cells[33, 1] = "400/5";
                m_workSheet.Cells[34, 1] = "250/5";
                m_workSheet.Cells[35, 1] = "250/5";
                m_workSheet.Cells[36, 1] = "400/5";
                m_workSheet.Cells[37, 1] = "250/5";
                m_workSheet.Cells[38, 1] = "1200/5";
                m_workSheet.Cells[39, 1] = "1200/5";
                m_workSheet.Cells[40, 1] = "1200/5";
                m_workSheet.Cells[41, 1] = "600/5";
                m_workSheet.Cells[42, 1] = "600/5";
                m_workSheet.Cells[43, 1] = "400/5";
                m_workSheet.Cells[44, 1] = "250/5";
                m_workSheet.Cells[45, 1] = "150/5";
                m_workSheet.Cells[46, 1] = "150/5";
                m_workSheet.Cells[47, 1] = "100/5";
                m_workSheet.Cells[48, 1] = "100/5";
                m_workSheet.Cells[49, 1] = "100/5";
                m_workSheet.Cells[50, 1] = "100/5";
                m_workSheet.Cells[51, 1] = "150/5";
                m_workSheet.Cells[52, 1] = "150/5";
                m_workSheet.Cells[53, 1] = "3000/5";




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
