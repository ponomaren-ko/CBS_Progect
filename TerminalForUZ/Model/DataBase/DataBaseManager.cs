using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;


namespace Controller.DataBase
{/// <summary>
/// Класс для управления базой данных
/// </summary>
    public class DataBaseManager
    {
      
        public static string Path { get { return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Model\\DataBase\\Accounts_DataBase.xml"; ; } }
       /// <summary>
       /// Создаёт новую  базу данных аккаунтов
       /// </summary>
       /// <returns></returns>
        public static bool CreateAccount() 
        {
            List<Account> accounts = new List<Account>();
            XmlSerializer xmlSerializer = new XmlSerializer(accounts.GetType());
            using (FileStream file = File.Create(Path)) 
            {
                xmlSerializer.Serialize(file,accounts);
            }
            return true;
        }

    }
}
