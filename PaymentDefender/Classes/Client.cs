using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender.Classes
{
    public class Client : IClient
    {
        public string[] FIO { get; }
        public int Age { get; set; }
        public Gender Gender { get; }
        public string CountryLiving { get; set; }
        public string Citizenship { get; set; }
        public FamilySet familySet { get; set; }
        public float IncomeLevel { get; set; }
        public float Savings { get; set; }
        public IPaymentCard[] PaymentCards { get; set; }
        public IPAddress ip { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHesh { get; set; }
        public int SessionId { get; set; }
        public void Authentificate()
        {
            throw new NotImplementedException();
        }
    }
}
