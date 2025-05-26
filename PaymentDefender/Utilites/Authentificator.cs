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
            bool Auth = true;
            if (Auth)
            {
                string path = "Z:\\projects\\learning\\VKR\\PaymentDefender\\Sources\\Obama.json";
                User buf = JsonFileManager.ReadObject<User>(path);


                int id = SessionManager.AddSession();   
                return id;
            }
            else return -1;
        }
    }
}
