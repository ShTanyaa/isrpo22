using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Burger:Product
    {
        private List<Option> options = new List<Option>();
        private decimal basePrice=300;
        public Burger (decimal basePrice) : base(basePrice)
        {
        }



        public override decimal GetPrice ()
        {
            decimal price=basePrice;
            foreach(Option i in options)
            {
                price += i.price;
            }
            return price;
        }
        public void AddOption(Option option)
        {
            options.Add(option);
        }
        public void ClearOption ()
        {
            options.Clear();
        }
    }
}
