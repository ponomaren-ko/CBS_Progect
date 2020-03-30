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

namespace TerminalForUZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account account =  Authorization.Login(Login_Textbox.Text, Password_Textbox.Text);
            if ( account != null) 
            {
                if (account.IsAdministartor)
                {
                    //Открываем окно АМИНИСТРАТОРА, тут мне нужно разбораться с WPF а то я не шарю как это сделать
                }
                else
                {
                    // Открываем новое окно для ПОЛЬЗОВАТЕЛЯ передаем экземпляр класса с нашим аккаунтом , тут мне нужно разбораться с WPF а то я не шарю как это сделать
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }
    }
}
