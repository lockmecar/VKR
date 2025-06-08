using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class SHA256Hascher
    {
        public static string GetHash(string input)
        {
            // Создаем объект SHA-256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Преобразуем строку в массив байтов
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Преобразуем байты в шестнадцатеричную строку
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
