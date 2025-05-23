using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class Authentificator
    {
        public static void Authentificate(string email, string passwordHesh) // Сделать проверку параметров из файла
        {
            SessionManager.AddSession(new Session(Role.User)); // Сделать получение роли из json-файла 
        }
    }
}
