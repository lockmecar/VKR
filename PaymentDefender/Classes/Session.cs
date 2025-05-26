using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class Session : ISession
    {
        public Session(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
