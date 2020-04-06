using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Controller
{

    public class Account
    {
        private int userId;
        private string name;
        private string lastName;
        private string login;
        private string password;
        private Ticket[] tickets;//  Не уверен!
        public bool IsAdministartor { get; set; }
        public string Email { get; set; }   
        public string UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Login { get; set; }
        [XmlIgnore]
        public string Password { get; set; }


    }
}
