using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DataBase;
using Model.Entities;

namespace Controller
{
    public class Administrator // Хранит методы по управлению контентом!(Добавление рейсов...?)
    {
        public static void AddFlight(string id, string departurepoint, string destinationpoint, string departuretime, string deparuredate, string plane)
        {
            Flight testflight = new Flight();
            testflight.PlaneID = id;
            testflight.DeparturePoint = departurepoint;
            testflight.DestinationPoint = destinationpoint;
            testflight.DepartureTime = departuretime;
            testflight.DepartureDate = deparuredate;
            testflight.Staus = FlightStatus.Сheck_In_Open;

            new DataBaseManagerFlight().Add(testflight);
            //Актальная версия)
        }

        public static void AddPlane()
        {

        }

        public static void RemoveFlight()
        {

        }

        public static void RemovePlane()
        {

        }

        public static void ChangeFlightInfo()
        {

        }
    }
}

