using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentDefender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PaymentDefender.Tests
{
    [TestClass()]
    public class AntiFrodTests
    {
        [TestMethod()]
        public void CheckPay_Normal_TransactionLevelGreen()
        {
            // Arrange
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            string login = "aboba@gmail.com";
            string password = "password";

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            User user1 = User.Create(person1, login, MD5Hasher.GetHash(password), 5, "Motorola C99");

            float moneyCount = 1280;
            string countryIp = "РФ";
            float freqOfPay = 5;
            string device = "Motorola C99";
            Shop purposeOfPayment = new Shop("Пятерочка", 10);

            var expected = TransactionLevel.Green;

            // Act
            var result = AntiFrod.CheckPay(moneyCount,countryIp, freqOfPay, device, purposeOfPayment, user1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CheckPay_Medium_TransactionLevelYellow()
        {
            // Arrange
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            string login = "aboba@gmail.com";
            string password = "password";

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            User user1 = User.Create(person1, login, MD5Hasher.GetHash(password), 5, "Motorola C99");

            float moneyCount = 101280;
            string countryIp = "РФ";
            float freqOfPay = 10;
            string device = "Motorola C99";
            Shop purposeOfPayment = new Shop("ИП Гена", 3);

            var expected = TransactionLevel.Yellow;

            // Act
            var result = AntiFrod.CheckPay(moneyCount, countryIp, freqOfPay, device, purposeOfPayment, user1);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CheckPay_Hard_TransactionLevelRed()
        {
            // Arrange
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            string login = "aboba@gmail.com";
            string password = "password";

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            User user1 = User.Create(person1, login, MD5Hasher.GetHash(password), 5, "Motorola C99");

            float moneyCount = 101280;
            string countryIp = "Укр";
            float freqOfPay = 1;
            string device = "Windows 11";
            Shop purposeOfPayment = new Shop("NaN", 1);

            var expected = TransactionLevel.Red;

            // Act
            var result = AntiFrod.CheckPay(moneyCount, countryIp, freqOfPay, device, purposeOfPayment, user1);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}