using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class SessionManager
    {
        static Dictionary<int,Session> Sessions = new Dictionary<int,Session>();
        public static Session CreateSession(string userLogin)
        {
            int id = IdGenerator.GenerateUniqueId();
            return new Session(id, userLogin);
        }

        public static void PrintSessions()
        {
            foreach (var session in Sessions)
            {
                Console.WriteLine(session);
            }
        }
    }
}
