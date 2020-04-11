﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Controller.DataBase
{/// <summary>
/// Класс для управления базой данных
/// </summary>
    public class DataBaseManager
    {
      /// <summary>
      /// Возвращает путь к файлу с базой аккаунтов.
      /// </summary>
        public static string Path { get { return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Model\\DataBase\\Accounts_DataBase.xml"; ; } }
       /// <summary>
       /// Создаёт новую  базу данных аккаунтов.
       /// </summary>
       /// <returns></returns>
        public static bool CreateAccountDB() 
        {
            List<Account> accounts = new List<Account>();
            XmlSerializer xmlSerializer = new XmlSerializer(accounts.GetType());
            using (FileStream file = File.Create(Path)) 
            {
                xmlSerializer.Serialize(file,accounts);
            }
            return true;
        }

        public static Account OpenAccount(string login, string password)
        {
            List<Account> accounts = new List<Account>();
            XmlSerializer serializer = new XmlSerializer(accounts.GetType());
            if (!File.Exists(DataBaseManager.Path))
                DataBaseManager.CreateAccountDB();

            using (FileStream fs = File.OpenRead(DataBaseManager.Path))
            {
                accounts = serializer.Deserialize(fs) as List<Account>;
            }
            try
            {
                var searchAccount = accounts.First(x => x.Login == login && x.Password == password);
                return searchAccount;
            }
            catch (Exception)
            {

                return null;
            }
                

            
                
               
           
        }

    }
}
