using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// Класс хранящий методы проверки валидности полей авторизации
    /// </summary>
    class AuthotizationValidator
    {
         public bool CheckLogin(string login)
        {
            return false;
        }
        public bool CheckPassword(string password)
        {
            return false;           
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public bool CheckPhoneNumber()
        {
            return false;
        }
    }
}
