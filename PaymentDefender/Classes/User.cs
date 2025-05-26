using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class User : IPerson
    {
        public User(string fio, int age, Gender gender, string countryLiving, string citizenship, FamilySet familySet,
            float incomeLevel, float savings, PaymentCard[] paymentCards, long phoneNumber, string emailLogin, string passwordHesh)
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
            EmailLogin = emailLogin;
            PasswordHesh = MD5Hasher.GetHash(passwordHesh);
            SessionId = -1;
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
        public string EmailLogin { get; set; }
        public string PasswordHesh { get; set; } // Хэш пароля
        public int SessionId { get; set; } // ID сессии

        public void Authentificate()
        {
            throw new NotImplementedException();
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"Пользователь {EmailLogin}:\n\n" +
                $"   ФИО: {FIO}\n" +
                $"   Возраст: {Age}\n" +
                $"   Пол: {Gender}\n" +
                $"   Страна проживания: {CountryLiving}\n" +
                $"   Гражданство: {Citizenship}\n" +
                $"   Семейное положение: {FamilySet}\n" +
                $"   Средние месячные доходы: {IncomeLevel} руб\n" +
                $"   Сбережения: {Savings} руб\n" +
                $"   Количество платежных карт: {PaymentCards.Length}\n" +
                $"   Номер телефона: {PhoneNumber}\n" +
                $"   Электронная почта: {EmailLogin}\n" +
                $"   Хэш пароля: {PasswordHesh}\n\n");
        }

        public void PrintUserCards()
        {
            Console.WriteLine($"Платежные карты пользователя {EmailLogin}:\n");
            foreach (var card in PaymentCards)
            {
                card.PrintCard();
            }
        }
    }
}
