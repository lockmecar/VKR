using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface IPerson
    {
        string[] FIO { get; }
        int Age { get; set; }
        Gender Gender { get; }
    }
}
