﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Controller.DataBase;

namespace Controller
{
    public class Authorization
    {
        
       
        public static string SignIn(string login, string password) // Ищет аккаунт по логину и паролю если есть то возращает login аккаунта если нет - null.
        {
            
            List<Account> accounts = new List<Account>();
            XmlSerializer serializer = new XmlSerializer(accounts.GetType());
            if (!File.Exists(DataBaseManager.Path))
                DataBaseManager.CreateAccount();
            using (FileStream fs = File.OpenRead(DataBaseManager.Path))
            {
                accounts = serializer.Deserialize(fs) as List<Account>;
            }
            var searchAccount = from a in accounts
                                where a.Login == login && a.Password == password
                                select a;

            if(searchAccount.Count() > 0)
            {
                return searchAccount.First().Login;
            }
           
            return null;
        }
        public void Register()// В разработке
        {

        }
    }
}
