using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class User : Person
    {
        public User(string fio, int age, Gender gender, string countryLiving, string citizenship, FamilySet familySet, float incomeLevel,
            float savings, PaymentCard[] paymentCards, long phoneNumber, string emailLogin, string passwordHesh)
            : base(fio, age, gender, countryLiving, citizenship, familySet, incomeLevel, savings, paymentCards, phoneNumber)
        {
            EmailLogin = emailLogin;
            PasswordHesh = passwordHesh;
            SessionId = -1;
        }

        public string EmailLogin { get; set; } // Логин
        public string PasswordHesh { get; set; } // Хэш пароля
        public int SessionId { get; set; } // ID сессии

        public static User Create(IPerson person, string emailLogin, string password)
        {
            return new User(person.FIO, person.Age, person.Gender, person.CountryLiving, person.Citizenship, 
                person.FamilySet, person.IncomeLevel, person.Savings, person.PaymentCards, person.PhoneNumber, emailLogin, password);
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

        public override string ToString()
        {
            return EmailLogin;
        }
    }
}
