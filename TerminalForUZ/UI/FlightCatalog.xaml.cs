using Controller;
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
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для FlightCatalog.xaml
    /// </summary>
    public partial class FlightCatalog : Window
    {
        private string[] userInfo;
        List<string> avalibleFlights;
        public FlightCatalog(string[] userInfo)
        {
            this.userInfo = userInfo;
            InitializeComponent();

            string[] flights = {"Киев","Львов","Варшава","Токио"};
            List<string> sorted = flights.ToList();
            sorted.Sort();


            foreach (var item in sorted)
            {
              
                FlightFromComboBox.Items.Add(item);
                FlightToComboBox.Items.Add(item);
            }
            // Нужно получить массив строк с названиями городов и добавить их в оба комбобокса
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {     
            new MainUserMenu(userInfo).Show();
            this.Close();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            avalibleFlights = new List<string>();
        
         string[,] result =  new FlightControlPanel().SearchFlights(FlightFromComboBox.Text,FlightToComboBox.Text);
            try
            { 
                avalibleFlights.Add(String.Format("ID: {0} ; AirCraft: {1} ; Date: {2} ; Time : {3}", result[0, 0], result[0, 1], result[0, 2], result[0, 3]));
                AvalibleFlightsComboBox.ItemsSource = avalibleFlights;
            }
            catch(Exception)
            {
                MessageBox.Show("Рейсов с указаным маршрутом не найдено ");
            }
            
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
