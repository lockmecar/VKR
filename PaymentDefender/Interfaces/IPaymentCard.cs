using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface IPaymentCard
    {
        int Number {  get; set; }
        DateTime Date { get; set; } // Дата окончания обслуживания
        string Cvv { get; set; }
        IClient Holder { get; set; } // Держатель
        PaymentSystem paymentSystem { get; set; } // Платежная система
    }
}
