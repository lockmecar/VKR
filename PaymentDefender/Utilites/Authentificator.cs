using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class Authentificator
    {
        public static int Authentificate(User user) 
        {

            string filePath = "Z:\\projects\\learning\\VKR\\PaymentDefender\\Sources\\" + user.EmailLogin + ".json";
            if (File.Exists(filePath))
            {
                User buf = JsonFileManager.ReadObject<User>(filePath);

                if (user.PasswordHesh == buf.PasswordHesh)
                {
                    int id = SessionManager.AddSession();
                    Console.WriteLine($"Аутентификация успешна, id сессии: {id}");
                    return id;
                }
                else
                {
                    Console.WriteLine("Аутентификация провалена");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Аутентификация провалена");
                return -1;
            }

        }
    }
}
