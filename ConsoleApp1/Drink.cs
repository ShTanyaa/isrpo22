using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Drink:Product
    {
        public int Volueme { get; set; }
        public bool isBottled { get; set; }
        private decimal basePrice=150;
        public Drink (decimal basePrice) : base(basePrice)
        {
        }

        public override decimal GetPrice ()
        {
            decimal price = basePrice;
            if(isBottled)
            {
                price = basePrice + 25;
            }
            return price;
        }
    }
}
