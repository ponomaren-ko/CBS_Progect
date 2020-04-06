using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;


namespace Controller.DataBase
{
    public class DataBaseManager
    {
      
        public static string Path { get { return @"DataBase\Accounts_DataBase.xml"; } }
        public static bool Create() 
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
