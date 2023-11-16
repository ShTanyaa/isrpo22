using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        private List<Product> products = new List<Product>();
        public int number { get; set; }
        public DateTime OrderTime { get; set; }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void Clear()
        {
            products.Clear();
        }
        public decimal TotalPrice ()
        {
            decimal total_price = 0;
            foreach(Product i in products)
            {
                total_price += i.GetPrice();
            }
            return total_price;
        }
        public string GetCheck()
        {
            string check = "Чек:\n";
            foreach(Product i in products)
            {
                check += $"{i.name} - {i.GetPrice()} руб.\n";
            }
            check += $"Итого: {TotalPrice()}руб.\nДата заказа: {OrderTime}";
            return check;
        }
    }
}
