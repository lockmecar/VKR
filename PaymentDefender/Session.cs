using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class Session : ISession
    {
        public Session(Role role)
        {
            Id = IdGenerator.GenerateUniqueId();
            this.role = role;
        }

        public int Id { get; set; }
        public Role role { get; set; }

    }
}
