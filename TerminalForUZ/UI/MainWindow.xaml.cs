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
            string[] accountInfo = Authorization.SignIn(LoginTextBox.Text, PasswordBox.Password);
            if (accountInfo != null)
            {
                MessageBox.Show("Welcome, " + accountInfo[1] );

                this.Hide();
                new MainUserManu2(accountInfo).Show();
             
            }
           
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Registration());
        }

        
    }
}
