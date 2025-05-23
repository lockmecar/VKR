using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class Authentificator
    {
        public static int Authentificate(string email, string passwordHesh) // Сделать проверку параметров из файла
        {
            int id = SessionManager.AddSession(Role.User);  // Сделать получение роли из json-файла 
            return id;
        }
    }
}
