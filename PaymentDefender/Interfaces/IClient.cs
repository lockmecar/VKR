using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public interface IClient : IPerson
    {
        public string CountryLiving { get; set; } // Страна проживания
        public string Citizenship { get; set; } // Гражданство
        public FamilySet familySet { get; set; } // Семейное положение
        public float IncomeLevel { get; set; } // Уровень доходов
        public float Savings { get; set; } // Сбережения
        public IPaymentCard[] PaymentCards { get; set; } // Массив платежных карт
        public IPAddress ip {  get; set; } // IP-адресс
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHesh { get; set; } // Хэш пароля
        public int SessionId { get; set; } // ID сессии
        public void Authentificate(); // Метод аутентификации
    }
}
