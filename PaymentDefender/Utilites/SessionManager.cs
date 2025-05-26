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
        public static int AddSession()
        {
            int id = IdGenerator.GenerateUniqueId();
            Sessions.Add(id, new Session(id));
            return id;
        }
    }
}
