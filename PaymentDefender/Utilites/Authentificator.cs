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
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string exeDirectory = Path.GetDirectoryName(exePath);

            // Поднимаемся вверх по директориям, пока не найдем папку Sources
            DirectoryInfo directory = new DirectoryInfo(exeDirectory);
            while (directory != null && !directory.GetDirectories("Sources").Any())
            {
                directory = directory.Parent;
            }

            if (directory == null)
            {
                Console.WriteLine("Не удалось найти папку Sources");
                return null;
            }

            string sourcesPath = Path.Combine(directory.FullName, "Sources");
            string filePath = Path.Combine(sourcesPath, login + ".json");

            if (File.Exists(filePath))
            {
                User buf = JsonFileManager.ReadObject<User>(login);

                if (SHA256Hascher.GetHash(password) == buf.PasswordHesh)
                {
                    Console.WriteLine($"Аутентификация успешна");
                    return SessionManager.CreateSession(login);
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
