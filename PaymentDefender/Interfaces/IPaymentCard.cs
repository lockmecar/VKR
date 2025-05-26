using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface IPaymentCard
    {
        public string Bank {  get; set; }
        public int Number {  get; set; }
        public DateTime Date { get; set; } // Дата окончания обслуживания
        public string Cvv { get; set; }    // Хэш
        public string FioHolder { get; set; } // ФИО держателя
        public PaymentSystem PaymentSystem { get; set; } // Платежная система
    }
}
