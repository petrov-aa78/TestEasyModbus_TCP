using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using TestEasyModbus_TCP.ViewModels;

using System.Configuration; //дла базы данных
using System.Data;
using System.Data.SqlClient;
  

namespace TestEasyModbus_TCP.Views
{
    public partial class MainWindow : Window
    {

        private SqlConnection SqlConnection = null; //sql соединение
        
        public MainWindow()
        {
            InitializeComponent();    
            
        }

        private void DataRefresh()
        {
            DataContext = new BaseViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRefresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) //Подключение к БД при загрузке окна
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectDB_RU_04"].ConnectionString);

            string connectSQL_error = "";
            try
            {
                SqlConnection.Open();
            }
           catch (Exception er) { connectSQL_error = er.ToString(); }

            if (SqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("База данных подключена");
            }
            else
            {
                MessageBox.Show("База данных не подключена");
            }

           


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //открыть окно таблица мощности
            WindowTable1 WindowTable1 = new WindowTable1();
            WindowTable1.Show();
        }

        private void bReport_Click(object sender, RoutedEventArgs e)
        {
            //сгенирировать отчёт в excel
           
        }
    }
}
