using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface IPerson
    {
        public string FIO { get; }
        public int Age { get; set; }
        public Gender Gender { get; }
    }
}
