
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
    public class DataBaseManagerFlight : DataBaseManager<Flight>
    {
        public override string Path { get { return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Model\\DataBase\\Flights_DataBase.xml"; ; } }
        static readonly XmlSerializer Serializer = new XmlSerializer(typeof(Flight[]));


        public override bool ChangeInfo(Flight newFlight)
        {
            List<Flight> flights = new List<Flight>();
            XmlSerializer serializer = new XmlSerializer(flights.GetType());
            using (FileStream fs = File.OpenRead(Path))
            {
                flights = serializer.Deserialize(fs) as List<Flight>;
            }
            Flight flight;
            try
            {

                flight = flights.First(x => x.Id == newFlight.Id);
                flights[flights.IndexOf(flight)] = newFlight;

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




        public override Flight Find(int id)
        {
            List<Flight> accounts = new List<Flight>();
            XmlSerializer serializer = new XmlSerializer(accounts.GetType());
            if (!File.Exists(Path))
                CreateDB();

            using (FileStream fs = File.OpenRead(Path))
            {
                accounts = serializer.Deserialize(fs) as List<Flight>;
            }
            try
            {
                var searchAccount = accounts.First(x => x.Id == id);
                return searchAccount;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public  List<Flight> FindByPoints(string departurePoint , string destinationPoint)
        {
            List<Flight> accounts = new List<Flight>();
            XmlSerializer serializer = new XmlSerializer(accounts.GetType());
            if (!File.Exists(Path))
                CreateDB();

            using (FileStream fs = File.OpenRead(Path))
            {
                accounts = serializer.Deserialize(fs) as List<Flight>;
            }
            try
            {   
                var searchAccount = accounts.FindAll(x => x.DeparturePoint == departurePoint && x.DestinationPoint == destinationPoint);
                return searchAccount;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private IEnumerable<Flight> DeserializeFlight()
        {
            try
            {
                using (var fileStream = new FileStream(Path, FileMode.Open))
                {
                    return (IEnumerable<Flight>)Serializer.Deserialize(fileStream);
                }
            }
            catch
            {
                return Enumerable.Empty<Flight>();
            }
        }


        /// <summary>
        /// Метод добавления рейса
        /// </summary>
        /// <param name="flight"></param>
        public override void Add(Flight flight)
        {
            var flights = DeserializeFlight().ToList();
            flight.Id = flights.Count + 1;
            flights.Add(flight);
            using (var fileStream = new FileStream(Path, FileMode.Create))
            {
                Serializer.Serialize(fileStream, flights.ToArray());
            }
        }

     //   public static Flight SwitchFlightStatus(Flight flight)
     //   {
     //           ! H  E  L  P !
     //   }


    }
}
