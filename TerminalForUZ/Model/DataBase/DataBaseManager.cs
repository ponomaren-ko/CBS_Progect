using Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.DataBase
{
    public abstract  class DataBaseManager<T>
    {
        public abstract string Path { get; }



        public bool CreateDB()
        {
            List<T> accounts = new List<T>();
            XmlSerializer xmlSerializer = new XmlSerializer(accounts.GetType());
            using (FileStream file = File.Create(Path))
            {
                xmlSerializer.Serialize(file, accounts);
            }
            return true;
        }

        public abstract void Add(T value);
        abstract public  T Find(string id);
        public abstract bool ChangeInfo(T value);


        

    }

    
}
