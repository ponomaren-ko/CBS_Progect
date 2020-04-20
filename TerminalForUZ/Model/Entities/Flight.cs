using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public enum FlightStatus
    {
        Сheck_In, 
        Сheck_In_Open, 
        Open    

    }

    public class Flight
    {
        public string Id { get; set; }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string PlaneID { get; set; }
        public FlightStatus Staus;

    }
}
