using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public enum TransactionLevel
    {
        Green,  // Стандартная аутентификация
        Yellow, // Двухфакторная
        Red     // По документам
    }
}
