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
        string CountryLiving { get; set; } // Страна проживания
        string Citizenship { get; set; } // Гражданство
        FamilySet familySet { get; set; } // Семейное положение
        float IncomeLevel { get; set; } // Уровень доходов
        float Savings { get; set; } // Сбережения
        IPaymentCard[] PaymentCards { get; set; } // Массив платежных карт
        IPAddress ip {  get; set; } // IP-адресс
        int PhoneNumber { get; set; }
        string Email { get; set; }
        string PasswordHesh { get; set; } // Хэш пароля
        int SessionId { get; set; } // ID сессии
        public void Authentificate(); // Метод аутентификации
    }
}
