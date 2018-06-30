using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Customers
    {
        public static string Checker { get; set; }
        public static string CustName { get; set; }

        public static string NewCustomer()
        {
            Validation validation = new Validation();

            Console.WriteLine("Welcome to Wayne's World Pizzeria!");
            Console.WriteLine("Are you a new customer or a returning one?" +
                "\nPlease type New or Returning.");

            validation.ValidationCheck = 1;
            Checker = validation.AttemptValidation();

            if (Checker == "New")
            {
                Console.WriteLine("Since you're new here can I get your first and last name, " +
                    "or you may enter nothing and your data will not be saved.");
                CustName = validation.ReadNext();

                if (CustName == null)
                {
                    CustName = "Guest";
                }
                return CustName;
            }
            else
            {
                return null;
            }
        }

        public static void ReturningCustomer()
        {
            Validation validation = new Validation();

            if (Checker == "Returning")
            {
                Console.WriteLine("Can you please enter your first and last name.");
                CustName = validation.ReadNext();
            }

            Console.WriteLine($"Hello {CustName}, welcome back.");
        }

        public static void PreferredLocation()
        {

        }

        public static void PreferredOrder()
        {

        }
    }
}
