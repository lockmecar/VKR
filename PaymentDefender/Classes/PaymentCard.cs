using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Classes
{
    public class PaymentCard : IPaymentCard
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Cvv { get; set; }
        public IClient Holder { get; set; }
        public PaymentSystem paymentSystem { get; set; }
    }
}
