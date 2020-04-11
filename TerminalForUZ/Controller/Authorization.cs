using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using Controller.DataBase;

namespace Controller
{
    public class Authorization
    {
        
       //TODO: Доделать проверку по паролю
        public static string[] SignIn(string login, string password) 
        {
            Account account = DataBaseManager.OpenAccount(login, password);
            if (account != null)
            {
                string[] accountInfo = new string[7];
                accountInfo[0] = account.IsAdministrator.ToString();
                accountInfo[1] = account.Name;
                accountInfo[2] = account.LastName;
                accountInfo[3] = account.Email;
                accountInfo[4] = account.PhoneNumber;
                accountInfo[5] = account.Login;
                accountInfo[6] = account.Password;
                return accountInfo;
            }
            else
                return null;
            
            
        }
       
    }
}
