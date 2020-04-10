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
        public static bool SignIn(string login, string password) 
        {
            
            List<Account> accounts = new List<Account>();
            XmlSerializer serializer = new XmlSerializer(accounts.GetType());
            if (!File.Exists(DataBaseManager.Path))
                DataBaseManager.CreateAccount();

            using (FileStream fs = File.OpenRead(DataBaseManager.Path))
            {
                accounts = serializer.Deserialize(fs) as List<Account>;
            }

            try
            {
                var searchAccount  = accounts.First(x => x.Login == login);
                var searchPassword = accounts.First(p => p.Password == password); //не уверен что тут должен быть First
                MessageBox.Show("Login successfull");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
       
    }
}
