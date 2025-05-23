using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface ISession
    {
        int Id { get; set; }
        Role role { get; set; }
    }
}
