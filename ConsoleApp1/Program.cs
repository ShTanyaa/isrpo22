using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("хотите сделать заказ?(Да/Нет)");
            string otv = Console.ReadLine();
            if (otv == "Да")
            {
                var order = new Order()
                {
                    number = 1,
                    OrderTime = DateTime.Now
                };
                Console.WriteLine("введите напиток");
                var drink = new Drink(300)
                {

                    name = Console.ReadLine(),
                    Volueme = 250,
                    isBottled = true,
                };
                Console.WriteLine("введите название бургера");
                var burger = new Burger(350)
                {
                    name = Console.ReadLine(),
                };
                Console.WriteLine("хотите добавить что нибудь в бургер?(Да/Нет)");
                string otv1 = Console.ReadLine();
                if (otv1 == "Да")
                {
                    Console.WriteLine("Выберите опцию:\n1.Доп.порция лука\n2.Доп.порция сыра\n3.Халапеньо\n4.Доп.котлета\n5.Соус");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            burger.AddOption(new Option { name = "onion", price = 15 });
                            break;
                        case 2:
                            burger.AddOption(new Option { name = "cheese", price = 25 });
                            break;
                        case 3:
                            burger.AddOption(new Option { name = "jalapeno", price = 30 });
                            break;
                        case 4:
                            burger.AddOption(new Option { name = "cutlet", price = 40 });
                            break;
                        case 5:
                            burger.AddOption(new Option { name = "sauce", price = 35 });
                            break;
                        default:
                            Console.WriteLine("неверный ввод.введите число");
                            break;
                    }
                } else if (otv1 == "Нет")
                {
                    Console.WriteLine("доп.опций нет");
                }
                order.AddProduct(drink);
                order.AddProduct(burger);
                Console.WriteLine(order.GetCheck());
                Console.ReadLine();
            } else if (otv == "Нет")
                Console.WriteLine("до встречи");
        }
    }
}
