using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class Authentificator
    {
        public static Session Authentificate(string login, string password) 
        {

            string filePath = "Z:\\projects\\learning\\VKR\\PaymentDefender\\Sources\\" + login + ".json";
            if (File.Exists(filePath))
            {
                User buf = JsonFileManager.ReadObject<User>(login);

                if (MD5Hasher.GetHash(password) == buf.PasswordHesh)
                {
                    Console.WriteLine($"Аутентификация успешна");
                    return SessionManager.CreateSession();
                }
                else
                {
                    Console.WriteLine("Аутентификация провалена");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Аутентификация провалена");
                return null;
            }

        }
    }
}
