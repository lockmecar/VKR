using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Classes
{
    public class Client : IClient
    {
        public Client(string fio, int age, Gender gender, string countryLiving, string citizenship, FamilySet familySet, 
            float incomeLevel, float savings, IPaymentCard[] paymentCards, long phoneNumber, string email, string password)
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
            Email = email;
            PasswordHesh = MD5Hasher.GetHash(password);
            SessionId = -1;
        }

        public string FIO { get; }
        public int Age { get; set; }
        public Gender Gender { get; }
        public string CountryLiving { get; set; }
        public string Citizenship { get; set; }
        public FamilySet FamilySet { get; set; }
        public float IncomeLevel { get; set; }
        public float Savings { get; set; }
        public IPaymentCard[] PaymentCards { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHesh { get; set; }
        public int SessionId { get; set; }

        public void Authentificate()
        {
            throw new NotImplementedException();
        }

        public void PrintClient()
        {
            Console.WriteLine($"Клиент {FIO}:\n" +
                $"   Возраст: {Age}\n" +
                $"   Пол: {Gender}\n" +
                $"   Страна проживания: {CountryLiving}\n" +
                $"   Гражданство: {Citizenship}\n" +
                $"   Семейное положение: {FamilySet}\n" +
                $"   Средние месячные доходы: {IncomeLevel} руб\n" +
                $"   Сбережения: {Savings} руб\n" +
                $"   Количество платежных карт: {PaymentCards.Length}\n" +
                $"   Номер телефона: {PhoneNumber}\n" +
                $"   Электронная почта: {Email}\n" +
                $"   Хэш пароля: {PasswordHesh}\n");
        }
    }
}
