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
        public string CountryLiving { get; set; } // Страна проживания
        public string Citizenship { get; set; } // Гражданство
        public FamilySet FamilySet { get; set; } // Семейное положение
        public float IncomeLevel { get; set; } // Уровень доходов
        public float Savings { get; set; } // Сбережения
        public List<PaymentCard> PaymentCards { get; set; } // Массив платежных карт
        public long PhoneNumber { get; set; }
    }
}
