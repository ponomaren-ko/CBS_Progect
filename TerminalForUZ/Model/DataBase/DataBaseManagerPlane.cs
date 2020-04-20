using Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.DataBase
{
    public class DataBaseManagerPlane : DataBaseManager<Plane>
    {
        public override string Path { get { return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Model\\DataBase\\Planes_DataBase.xml"; ; } }

        

        public override  bool ChangeInfo(Plane newPlane)
        {
            
            List<Plane> flights = new List<Plane>();
            XmlSerializer serializer = new XmlSerializer(flights.GetType());
            using (FileStream fs = File.OpenRead(Path))
            {
                flights = serializer.Deserialize(fs) as List<Plane>;
            }
            Plane plane;
            try
            {

                plane = flights.First(x => x.Id == newPlane.Id);
                flights[flights.IndexOf(plane)] = newPlane;

            }
            catch (Exception)
            {
                return false;
            }


            using (FileStream file = File.Create(Path))
            {
                serializer.Serialize(file, flights);
            }


            return true;
        }

        public override  Plane Find( string Id)
        {
            throw new NotImplementedException();
        }

        public override void Add(Plane value)
        {
            throw new NotImplementedException();
        }
    }
}
