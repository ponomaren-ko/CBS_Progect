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

namespace UI.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для MainAlminMenu.xaml
    /// </summary>
    public partial class MainAdminMenu : Window
    {
        private string[] accountInfo;

        public MainAdminMenu()
        {
            InitializeComponent();
        }
        public MainAdminMenu(string[] accountInfo)
        {
            InitializeComponent();
            this.accountInfo = accountInfo;
        }

        private void AddFlight_Click(object sender, RoutedEventArgs e)
        {
            Administrator.AddFlight( "Киев", "Львов", "12:30",   "01/08/2020", 777);
            Administrator.AddFlight( "Киев", "Львов", "14:50",   "01/08/2020", 777);
            Administrator.AddFlight( "Киев", "Варшава", "12:30", "01/08/2020", 777);
            Administrator.AddFlight( "Киев", "Токио", "12:35",   "01/08/2020", 777);
            Administrator.AddFlight( "Киев", "Токио", "12:55",   "01/08/2020", 777);

            MessageBox.Show("Рейс успешно добавлен");
        }


        private void RemoveFlight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemovePlane_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
