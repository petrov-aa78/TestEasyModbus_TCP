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
        public void Report()//(string comanda)для тех кто не догадался string comanda отвечает за строку запроса к базе данных у меня все по классам и функциям раскидано так что можно его убрать показал цикл на примере дата грид кстати скоростью высокой не будет отличаться есть варианты и по быстрее но для не больших обьемов скорость приличная...
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
                // Пишем строку
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    DataGridViewRow row = dataGridView1.Rows[i]; // строки
                //    for (int j = 0; j < row.Cells.Count; j++) //цикл по ячейкам строки
                //    {
                m_workSheet.Cells[1, 1] = "№";
                m_workSheet.Cells[1, 2] = "Точка";
                m_workSheet.Cells[1, 3] = "Товар";
                m_workSheet.Cells[1, 4] = "Цена";
                m_workSheet.Cells[1, 5] = "Данные";

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
