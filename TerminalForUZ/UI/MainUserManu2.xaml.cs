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
    /// Логика взаимодействия для MainUserManu2.xaml
    /// </summary>
    public partial class MainUserManu2 : Window
    {
        public string IsAdministrator { get; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; }
        public string Password { get; set; }


        public MainUserManu2(string[] userInfo)
        {
            InitializeComponent();

            IsAdministrator = userInfo[0];
            UserName = userInfo[1];
            NameTextBox.Text = UserName;
            LastName = userInfo[2];
            LastNameTextBox.Text = LastName;
            Email = userInfo[3];
            EmailTextBox.Text = Email;
            PhoneNumber = userInfo[4];
            PhoneNumberTextBox.Text = PhoneNumber;
            Login = userInfo[5];
            Password = userInfo[6];
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            UserName = NameTextBox.Text;
            LastName = LastNameTextBox.Text;
            Email = EmailTextBox.Text;
            PhoneNumber = PhoneNumberTextBox.Text;
            Password = PasswordTextBox.Text;


            string[] accountInfo = { IsAdministrator, UserName, LastName, Email, PhoneNumber, Login, Password };
            if (Authorization.ChnageAccountInfo(accountInfo))
                MessageBox.Show(" Successful! ");
        }
    }
}

