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
using Controller;



namespace UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            Authorization.SignIn(LoginTextBox.Text, PasswordBox.Password);

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = "Иван";
            string lastname = "Иванов";
            string login = "ivanivanov";
            string password = "Test123@";
            string email = "qwerty@gmail.com";
            string phone = "0965423431";

            Registrator.Register(name, lastname, login, password, phone, email);
        }
    }
}
