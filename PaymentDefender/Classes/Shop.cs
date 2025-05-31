using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDefender
{
    public class Shop
    {
        public Shop(string name, int popularity)
        {
            Name = name;
            Popularity = popularity;
        }
        public string Name {  get; set; }
        public int Popularity { get; set; } // число от 1 до 10 - известность магазина
    }
}
