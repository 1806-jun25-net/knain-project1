using Project1.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Project1.XUnit
{
    public class Tester
    {
        public List<string> Checker = new List<string> { "New" };
        public List<string> PizzaSize = new List<string> { "Small" };
        public List<string> PizzaCrust = new List<string> { "Deep Dish" };
        public List<string> PizzaToppings = new List<string> { "Bacon", "Peppers" };
        [Fact]
        public void TestChecker()
        {
            bool expected = true;

            Assert.Equal(expected, Customers.TestChecker(Checker));
        }

        [Fact]
        public void TestSize()
        {
            bool expected = true;

            Assert.Equal(expected, Pizza.TestSize(PizzaSize));
        }

        [Fact]
        public void TestCrust()
        {
            bool expected = true;

            Assert.Equal(expected, Pizza.TestCrust(PizzaCrust));
        }

        [Fact]
        public void TestToppings()
        {
            bool expected = true;

            Assert.Equal(expected, Pizza.TestToppings(PizzaToppings));
        }


        [Fact]
        public void TestInventoryTrue()
        {
            Location.InventoryRecall2();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 3;

            bool expected = true;

            Assert.Equal(expected, Location.Check2(location, toppings, size, quantity));
        }

        [Fact]
        public void TestInventoryFalse()
        {
            Location.InventoryRecall2();

            string location = "Herndon";
            List<string> toppings = new List<string> { "Bacon", "Sausage" };
            string size = "Large";
            int quantity = 12;

            bool expected = false;

            Assert.Equal(expected, Location.Check2(location, toppings, size, quantity));
        }
    }
}