using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Classes
{
    public class PaymentCard : IPaymentCard
    {
        public PaymentCard(string bank, int number, DateTime date, string cvv, string fioHolder, PaymentSystem paymentSystem)
        {
            Bank = bank;
            Number = number;
            Date = date;
            Cvv = MD5Hasher.GetHash(cvv);
            FioHolder = fioHolder;
            PaymentSystem = paymentSystem;
        }
        public string Bank { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Cvv { get; set; }
        public string FioHolder { get; set; }
        public PaymentSystem PaymentSystem { get; set; }

        public void PrintCard()
        {
            Console.WriteLine($"Платежная карта {Bank}:\n" +
                $"Номер карты: {Number}\n" +
                $"Срок годности: {Date}\n" +
                $"Хэш CVV: {Cvv}\n" +
                $"Держатель: {FioHolder}\n" +
                $"Платежная система: {PaymentSystem}\n");
        }
    }
}
