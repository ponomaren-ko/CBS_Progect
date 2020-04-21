using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Ticket  //Не знаю стоит ли такое реализовывать , думал сделать так, что бы на аккаунте был массив этих билетов
    {
        public string TicketID { get; set; }   
        public string Place { get; set; }
        public bool Active { get; set; } //Активный неактивный билет(до вылета актив после неактив)
    }   
}
