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
    public class JsonFileManagerTests
    {
        [TestMethod()]
        public void ReadObject_NormalLogin_NewUser()
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

            var expected = user1;

            // Act
            var newUser = JsonFileManager.ReadObject<User>(login);

            // Assert
            Assert.AreEqual(expected.ToString(), newUser.ToString());
        }
    }
}