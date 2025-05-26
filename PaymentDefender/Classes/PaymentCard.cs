using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Classes
{
    public class PaymentCard : IPaymentCard
    {
        public PaymentCard(string bank, int number, DateTime date, string cvv, IClient holder, PaymentSystem paymentSystem)
        {
            Bank = bank;
            Number = number;
            Date = date;
            Cvv = MD5Hasher.GetHash(cvv);
            Holder = holder;
            PaymentSystem = paymentSystem;
        }
        public string Bank { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Cvv { get; set; }
        public IClient Holder { get; set; }
        public PaymentSystem PaymentSystem { get; set; }

        public void PrintCard()
        {
            Console.WriteLine($"Платежная карта {Bank}:\nНомер карты: {Number}\nСрок годности: {Date}\nХэш CVV: {Cvv}\nДержатель: {Holder.FIO}\nПлатежная система: {PaymentSystem}\n");
        }
    }
}
