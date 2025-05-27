

namespace PaymentDefender
{
    

    class Program
    {
        static void Main(string[] args)
        {
            PaymentCard[] paymentCards = new PaymentCard[]
            {
                new PaymentCard("СберБанк", 73849230, new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", 83940392, new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 
                60000, 100000, paymentCards, 89633791187);

            User user1 = User.Create(person1, "login@gmail.com", MD5Hasher.GetHash("password"));
            User user2 = User.Create(person1, "ivan@yandex.ru", MD5Hasher.GetHash("123456"));

            JsonFileManager.WriteObject(user2);

            Authentificator.Authentificate(user1);
        }
    }

}
