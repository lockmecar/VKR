using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class Person : IPerson
    {
        public Person(string fio, int age, Gender gender, string countryLiving, string citizenship, FamilySet familySet,
            float incomeLevel, float savings, PaymentCard[] paymentCards, long phoneNumber)
        {
            FIO = fio;
            Age = age;
            Gender = gender;
            CountryLiving = countryLiving;
            Citizenship = citizenship;
            FamilySet = familySet;
            IncomeLevel = incomeLevel;
            Savings = savings;
            PaymentCards = paymentCards;
            PhoneNumber = phoneNumber;
        }
        public string FIO { get; }
        public int Age { get; set; }
        public Gender Gender { get; }
        public string CountryLiving { get; set; } // Страна проживания
        public string Citizenship { get; set; } // Гражданство
        public FamilySet FamilySet { get; set; } // Семейное положение
        public float IncomeLevel { get; set; } // Уровень доходов
        public float Savings { get; set; } // Сбережения
        public PaymentCard[] PaymentCards { get; set; } // Массив платежных карт
        public long PhoneNumber { get; set; }
    }
}
