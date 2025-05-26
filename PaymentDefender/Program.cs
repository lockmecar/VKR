

namespace PaymentDefender
{
    

    class Program
    {
        static void Main(string[] args)
        {
            PaymentCard[] paymentCards = new PaymentCard[]
            {
                new PaymentCard("СберБанк", 73849230, new DateTime(2030,12,5), "654", "Обамов Обама Обамович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", 83940392, new DateTime(2027,7,23), "800", "Обамов Обама Обамович", PaymentSystem.MasterCard)
            };

            User Obama = new User("Обамов Обама Обамович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 
                60000, 100000, paymentCards, 89633791187, "lockmecar@gmail.com", "123qwert");

            //Obama.PrintClient();

            JsonFileManager.WriteObject(Obama, "Z:\\projects\\learning\\VKR\\Obama.json");
            User Obama_copy = JsonFileManager.ReadObject<User>("Z:\\projects\\learning\\VKR\\Obama.json");
            Obama_copy.PrintUserInfo();
            Obama_copy.PrintUserCards();
        }
    }

}
