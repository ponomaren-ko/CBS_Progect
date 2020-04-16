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
    /// Логика взаимодействия для BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        static string[] accountInfo;
        static string flightId;
        public BuyWindow(string[] userInfo, string flightId)
        {
            InitializeComponent();
            IdLabel.Content = flightId;
            accountInfo = userInfo;
        }

        
        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

            new FlightCatalog(accountInfo).Show();
            this.Close();
        }
    }
}
