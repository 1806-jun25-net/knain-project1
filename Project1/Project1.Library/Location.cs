using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Location
    {
        public static Dictionary<string, List<string>> history = new Dictionary<string, List<string>>();
        public static Order order = new Order();
        public static string toppings = string.Join(", ", Order.OrderToppings.ToArray());
        public static string filePath = @":\Revature\knain-project1\Project1";

        public static List<string> values = new List<string>
            { Order.OrderSize, Order.OrderCrust, toppings};

        public static void OrderHistoryAdd()
        {
            history.Add(Customers.CustName, values);
        }

        public static void OrderHistoryRecall()
        {
            
        }

        public static void Inventory()
        {

        }
    }
}
