using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Controller
{
    public class Authorization
    {
        public static string dataBasePath = @"DB\Accounts_DataBase.xml"; // Путь к БД 
        

        public static Account SignIn(string login, string password) // Ищет аккаунт по логину и паролю если есть то возращает аккаунт если нет - null.
        {
            XmlDocument dataBase = new XmlDocument();
            dataBase.Load(dataBasePath);
            XmlElement elements = dataBase.DocumentElement;

            // Поиск по нашими user ам в XML файле
            foreach (XmlNode user in elements)
            {
                // получаем атрибут Login
                if (user.Attributes.Count > 0)
                {
                    XmlNode userLogin = user.Attributes.GetNamedItem("Login");
                    XmlNode userPassword = user.Attributes.GetNamedItem("Password");

                    if(userLogin.Value == login && userPassword.Value == password)
                    {
                        Account account = new Account();
                        account.UserID = user.Attributes.GetNamedItem("ID").Value;
                        account.Name = user.Attributes.GetNamedItem("Name").Value;
                        account.LastName = user.Attributes.GetNamedItem("LastName").Value;
                        account.IsAdministartor = Convert.ToBoolean(user.Attributes.GetNamedItem("IsAdministrator").Value);
                        account.Login = user.Attributes.GetNamedItem("Login").Value;
                        account.Password = user.Attributes.GetNamedItem("Password").Value;
                        return account;
                    }
                       
                }
            }

                return null;
        }
        public void Register()// В разработке
        {

        }
    }
}
