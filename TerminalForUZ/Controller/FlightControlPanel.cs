using Model.DataBase;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FlightControlPanel
    {
        public string[,] SearchFlights(string departurePoint, string destinationPoint)
        {
            
            Flight[] flights = new DataBaseManagerFlight().FindByPoints(departurePoint, destinationPoint).ToArray();
            string[,] result = new string[flights.Length, 4];

            for (int i = 0; i < flights.Length; i++)
            {
                result[i, 0] = flights[i].Id;
                result[i, 1] = flights[i].Plane;
                result[i, 2] = flights[i].DepartureDate;
                result[i, 3] = flights[i].DepartureTime;
            }

            return result;
        }
    }
}
