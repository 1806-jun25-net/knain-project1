using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NLog;
using Project1.ContextLibrary;
using Project1.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Project1.UI
{
    public class Program
    {
        //set up logging
        private static readonly Logger logger =
            LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            //start logging
            logger.Info("Application start");

            try
            {
                throw new ArgumentException("Error!");
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "Error thrown right after startup");
            }

            //deserialize Inventory and Order History files
            Location.InventoryRecall();
            Location.OrderHistoryRecall();

            Location.InventoryRecall2();
            Location.OrderHistoryRecall2();
            

            //start program
            Customers.NewCustomer();
            if (Customers.ReturningCustomer2() == "No") //change ReturningCustomer to switch from XML to DB
            {
                Order.OrderPizza();
            }

            //checks if you are allowed to place an order
            if (Order.CheckTime2(Order.OrderTime) == false) //change CheckTime to switch from XML to DB
            {
                Console.WriteLine("Sorry, you need to wait to place another order or choose a different location" +
                    "\npress any key to exit the program.");
                Console.ReadKey();
                Environment.Exit(0);
            }
                
            //checks current inventory levels
            //change Check to switch from XML to DB
            if (Location.Check2(Order.OrderLocation, Order.OrderToppings, Order.OrderSize, Order.OrderQuantity) == false)
            {
                Console.WriteLine("Sorry, that location does not have the ingredients to complete your order" +
                    "\npress any key to exit the program.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //final decision
            Order.FinalAnswer();

            //add information to DB

            Context.Program.Main();

            //serialize Inventory and Order History files
            //Serializer.SerializeInventoryToFile(@"C:\Revature\knain-project1\Project1\locationInventory.xml", Location.LocationInventory);

            //Location.OrderHistoryAdd(Location.OrderHistory);
            //Serializer.SerializeOrderToFile(@"C:\Revature\knain-project1\Project1\orderHistory.xml", Location.OrderHistory);

            //end logging
            logger.Info("Application shutting down");
        }
    }
}
