using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{ 
    public static class AntiFrod
    {
        public static TransactionLevel CheckPay(float moneyCount, string login, string password, string cardNumber, DateTime date, string cvv,
            string countryIp, float freqOfPay, string device, Shop purposeOfPayment, User user)
        {
            int warnings = 0;
            if (moneyCount > 30000) warnings += 2; // Проверка на большую сумму перевода
            if (countryIp != user.CountryLiving) warnings += 2; // Проверка айпи с которого запрашивают оплату
            if ((freqOfPay > user.FreqOfPay * 1.5)) warnings += 2; // Проверка переодичности платежей
            if (device != user.LastDevice) warnings++; // Проверка устройства
            if (purposeOfPayment.Popularity < 7) warnings++;
            if (purposeOfPayment.Popularity < 4) warnings++; // Проверка условной известности куда назначен платеж
            if (purposeOfPayment.Popularity < 2) warnings++;

            if (warnings < 4) return TransactionLevel.Green;
            else if (warnings < 7) return TransactionLevel.Yellow;
            else return TransactionLevel.Red;
        }
    }
}
