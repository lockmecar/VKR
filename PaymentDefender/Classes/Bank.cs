using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class Bank
    {
        public Bank(List<string> logins)
        {
            Users = new List<User>();
            foreach (string log in logins)
            {
                Users.Add(JsonFileManager.ReadObject<User>(log));
            }
        }

        private List<User> Users { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
        public void PrintAllUsers()
        {
            foreach (var user in Users)
            {
                user.PrintUserInfo();
            }
        }
        public List<User> GetUsersByCard(string cardId)
        {
            return Users.Where(u => u.PaymentCards.Any(pc => pc.CardID == cardId)).ToList();
        }
    }
}
