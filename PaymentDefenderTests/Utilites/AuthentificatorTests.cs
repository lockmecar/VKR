using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentDefender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Tests
{
    [TestClass()]
    public class AuthentificatorTests
    {
        [TestMethod()]
        public void Authentificate_Normal_NewSession()
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
            JsonFileManager.WriteObject(user1);

            int expectedId = 0;

            // Act
            var resultId = Authentificator.Authentificate(login, password).Id;

            // Assert
            Assert.AreEqual(expectedId, resultId);
        }

        [TestMethod()]
        public void Authentificate_WrongPassword_null()
        {
            // Arrange
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            string login = "aboba@gmail.com";
            string password = "password";
            string wrongPassword = "WrongPassword";

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            User user1 = User.Create(person1, login, MD5Hasher.GetHash(password), 5, "Motorola C99");
            JsonFileManager.WriteObject(user1);

            Session expected = null;

            // Act
            var result = Authentificator.Authentificate(login, wrongPassword);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Authentificate_WrongLogin_null()
        {
            // Arrange
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            string login = "aboba@gmail.com";
            string password = "password";
            string wrongLogin = "WrongLogin";

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            User user1 = User.Create(person1, login, MD5Hasher.GetHash(password), 5, "Motorola C99");
            JsonFileManager.WriteObject(user1);

            Session expected = null;

            // Act
            var result = Authentificator.Authentificate(wrongLogin, password);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}