﻿

namespace PaymentDefender
{
    

    class Program
    {
        static void Main(string[] args)
        {

            //int a = Bank.FindIndexByLogin("petrov@yandex.ru");
            //Console.WriteLine(a);


            //User a = Bank.GetUserByLogin("petrov@yandex.ru");
            //a.PrintUserInfo();

            //Bank.PrintAllUsers();


            //User user = JsonFileManager.ReadObject<User>("ivan@yandex.ru");
            //user.PrintUserInfo();

            /*
            List<PaymentCard> paymentCards1 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "73849230", new DateTime(2030,12,5), "654", "Иванов Иван Петрович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "83940392", new DateTime(2027,7,23), "800", "Иванов Иван Петрович", PaymentSystem.MasterCard)
            };
            List<PaymentCard> paymentCards2 = new List<PaymentCard>
            {
                new PaymentCard("СберБанк", "89637284", new DateTime(2030,12,5), "543", "Петров Петр Иванович", PaymentSystem.Mir),
                new PaymentCard("Т-Банк", "98116241", new DateTime(2027,7,23), "876", "Петров Петр Иванович", PaymentSystem.MasterCard)
            };

            Person person1 = new Person("Иванов Иван Петрович", 24, Gender.Male, "РФ", "РФ", FamilySet.NotMarried, 60000, 100000, paymentCards1, 89633791187);
            Person person2 = new Person("Петров Петр Иванович", 32, Gender.Male, "РФ", "РФ", FamilySet.Married, 80000, 1000000, paymentCards2, 89633791187);


            User user1 = User.Create(person1, "aboba@gmail.com", MD5Hasher.GetHash("password"), 5, "Motorola C99");           
            User user2 = User.Create(person2, "petrov@yandex.ru", MD5Hasher.GetHash("0987654"), 8, "Samsung Galaxy S21");

            
            JsonFileManager.WriteObject(user1);
            JsonFileManager.WriteObject(user2);
            */

            /*
            User user1 = JsonFileManager.ReadObject<User>("aboba@gmail.com");
            User user2 = JsonFileManager.ReadObject<User>("petrov@yandex.ru");
            user1.PrintUserInfo();
            user2.PrintUserInfo();
            */
        }
    }

}
