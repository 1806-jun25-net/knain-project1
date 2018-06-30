using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Order
    {
        public int OrderCheck { get; } = 0;
        public static string OrderSize { get; set; }
        public static string OrderCrust { get; set; }
        public static List<string> OrderToppings { get; set; } = new List<string> { };

        static void OrderCustomer()
        {

        }

        public static void OrderPizza()
        {
            Validation validation = new Validation();

            Console.WriteLine("What size Pizza would you like to order?");
            Console.WriteLine(Pizza.WriteLine(Pizza.Size));

            validation.ValidationCheck = 2;
            OrderSize = validation.AttemptValidation();

            Console.WriteLine("Please select what type of crust you would like?");
            Console.WriteLine(Pizza.WriteLine(Pizza.Crust));

            validation.ValidationCheck = 3;
            OrderCrust = validation.AttemptValidation();

            Console.WriteLine("What toppings would you like?");
            Console.WriteLine("You may select up to 5 toppings.");
            Console.WriteLine("When you are done selecting toppings just leave it blank.");
            validation.ValidationCheck = 4;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(Pizza.WriteLine(Pizza.Toppings));
                OrderToppings.Add(item: validation.AttemptValidation());
                if (OrderToppings[i] == "")
                {
                    OrderToppings.Remove("");
                    break;
                }
                Pizza.RemoveToppings();
                Console.WriteLine("\n");
            }
        }

        public static void OrderLocation()
        {

        }

        public static void OrderTime()
        {

        }

        public static void OrderCost()
        {

        }
    }
}
