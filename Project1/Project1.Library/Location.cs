using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Location
    {
        public static Dictionary<string, List<string>> history = new Dictionary<string, List<string>>();
        public static List<string> values = new List<string>
            { Order.OrderSize, Order.OrderCrust, Order.OrderToppings.ToString()};

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
