using Project1.Library;
using System;

namespace Project1.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customers.NewCustomer();
            Customers.ReturningCustomer();
            Order.OrderPizza();
            Location.OrderHistoryAdd();
        }
    }
}
