using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class SessionManager
    {
        static List<ISession> Sessions = new List<ISession>();
        public static void AddSession(ISession session)
        {
            Sessions.Add(session);
        }
    }
}
