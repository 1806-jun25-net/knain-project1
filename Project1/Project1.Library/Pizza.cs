using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Pizza
    {
        public static List<string> Size { get; } = new List<string> { "Small", "Medium", "Large" };
        public static List<string> Crust { get; } = new List<string> { "Hand Tossed", "Deep Dish", "Thin Crust" };
        public static List<string> Toppings { get; } = new List<string>
            { "Pepperoni", "Sausage", "Bacon", "Mushrooms", "Olives", "Anchovies" };

        public static string WriteLine(List<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            return null;
        }

        public static void RemoveToppings()
        {
            foreach (var item in Order.OrderToppings)
            {
                Toppings.Remove(item);
            }
        }

        public static void PizzaQuantity()
        {

        }
    }
}
