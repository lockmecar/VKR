using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class Bank
    {
        static Bank()
        {
            List<string> logins = new List<string>()
            {
                "ivan@yandex.ru",
                "login@gmail.com",
                "petrov@yandex.ru"
            };
            Users = new List<User>();
            foreach (string log in logins)
            {
                Users.Add(JsonFileManager.ReadObject<User>(log));
            }
        }

        public static List<User> Users { get; set; }
        public static Dictionary<int, Session> Sessions = new Dictionary<int, Session>();

        public static void AddUser(User user)
        {
            Users.Add(user);
        }
        public static void PrintAllUsers()
        {
            foreach (var user in Users)
            {
                user.PrintUserInfo();
            }
        }
        public static List<User> GetUsersByCard(string cardId)
        {
            return Users.Where(u => u.PaymentCards.Any(pc => pc.CardID == cardId)).ToList();
        }
    }
}
