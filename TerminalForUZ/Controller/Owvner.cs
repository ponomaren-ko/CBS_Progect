using Model.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;

namespace Controller
{
    /// <summary>
    /// Класс содержащий методы предназначеные для управления аккаунтами
    /// (Добавление и удаление Администраторов и Пользователей)
    /// </summary>
    public class Owvner
    {  // Тест создания баз данных 
        public static bool Test()
        {
            new DataBaseManagerFlight().CreateDB();
           // new DataBaseManagerPlane().CreateDB();
            
            return true;
        }

        public static bool Test1()
        {
            new DataBaseManagerFlight().Add(new Flight() { Id = "0001",PlaneID = "Airobus 350", Staus = FlightStatus.Сheck_In, DeparturePoint = "Киев", DestinationPoint = "Львов", DepartureDate = "01/01/21", DepartureTime = "10:15"});
            return true;
        }

    }
}
