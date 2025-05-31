using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public static class PaymentGateway
    {
        public static void Pay(float moneyCount, string login, string password, string cardNumber, DateTime date, string cvv, string countryIp,float freqOfPay, string device, Shop purposeOfPayment)
        {
            User user = Bank.GetUserByLogin(login);
            TransactionLevel transactionLevel = AntiFrod.CheckPay(moneyCount, login, password, cardNumber, date, cvv, countryIp, freqOfPay, device, purposeOfPayment, user); // Тут вызывается антифрод, который возвращает вердикт
            if (transactionLevel == TransactionLevel.Green)
            {
                Bank.AddSession(Authentificator.Authentificate(login, password), login);
            }
            else if (transactionLevel == TransactionLevel.Yellow)
            {
                Console.WriteLine("Нужна дополнительная аутентификация. Введите код из смс..");
            }
            else
            {
                Console.WriteLine("Для проведения плтежа потребуется удостоверить документы");
            }
        }
    }
}
