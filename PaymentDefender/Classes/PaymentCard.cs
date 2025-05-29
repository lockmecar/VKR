using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class PaymentCard : IPaymentCard
    {
        public PaymentCard(string bank, string cardID, DateTime date, string cvv, string fioHolder, PaymentSystem paymentSystem)
        {
            Bank = bank;
            CardID = cardID;
            Date = date;
            Cvv = MD5Hasher.GetHash(cvv);
            FioHolder = fioHolder;
            PaymentSystem = paymentSystem;
        }
        public string Bank { get; set; }
        public string CardID { get; set; }
        public DateTime Date { get; set; }
        public string Cvv { get; set; }
        public string FioHolder { get; set; }
        public PaymentSystem PaymentSystem { get; set; }

        public void PrintCard()
        {
            Console.WriteLine($"Платежная карта {Bank}:\n" +
                $"Номер карты: {CardID}\n" +
                $"Срок годности: {Date}\n" +
                $"Хэш CVV: {Cvv}\n" +
                $"Держатель: {FioHolder}\n" +
                $"Платежная система: {PaymentSystem}\n");
        }
    }
}
