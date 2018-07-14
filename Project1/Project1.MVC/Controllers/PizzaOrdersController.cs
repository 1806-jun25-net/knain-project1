using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.ContextLibrary;
using Project1.Library;

namespace Project1.MVC.Controllers
{
    public class PizzaOrdersController : Controller
    {
        public PizzaRepos Repo { get; }

        public PizzaOrdersController(PizzaRepos repos)
        {
            Repo = repos;
        }

        // GET: Order
        //[FromQuery]string search = ""
        public ActionResult Index()
        {
            var libraryOrders = Repo.GetPizzaOrders();
            
            var webOrders = libraryOrders.Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        public ActionResult IndexEarliest()
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.OrderByDescending(x => x.OrderTime).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        public ActionResult IndexLatest()
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.OrderBy(x => x.OrderTime).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        public ActionResult IndexHighest()
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.OrderByDescending(x => x.OrderCost).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        public ActionResult IndexLowest()
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.OrderBy(x => x.OrderCost).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexLocation(IFormCollection collection)
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.Where(x => x.Location.LocationName == collection["Location.LocationName"]).
                Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return View("Index", webOrders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexUser(IFormCollection collection)
        {
            var libraryOrders = Repo.GetPizzaOrders();
            int cId = Repo.CheckCustomerId(collection["CustomerName"]);

            var webOrders = libraryOrders.Where(x => x.CustomerId == cId).
                Select(x => new PizzaOrder
                {
                    PizzaOrderId = x.PizzaOrderId,
                    CustomerId = x.CustomerId,
                    LocationId = x.LocationId,
                    PizzaId = x.PizzaId,
                    PizzaQuantity = x.PizzaQuantity,
                    OrderCost = x.OrderCost,
                    OrderTime = x.OrderTime,
                    Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                    {
                        CustomerName = y.Customer.CustomerName,
                    }).First(),
                    Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                    {
                        LocationName = y.Location.LocationName
                    }).First(),
                    Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                    {
                        PizzaId = y.Pizza.PizzaId
                    }).First()
                });

            return View("Index", webOrders);
        }

        // GET: PizzaOrder/Details/5
        public ActionResult Details(int id)
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.Where(x => x.PizzaOrderId == id).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaSize = y.Pizza.PizzaSize,
                    PizzaCrust = y.Pizza.PizzaCrust
                }).First(),
                PizzaOrderToppings = libraryOrders.Where(y => y.PizzaOrderId == x.PizzaOrderId).
                    Select(y => new PizzaOrderToppings
                    {
                        ToppingName = string.Join(", ", y.PizzaOrderToppings.Select(y2 => y2.ToppingName).ToList())
                    })
            }).First();

            return View(webOrders);
        }

        // GET: PizzaOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaOrder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                int cId = Repo.CheckCustomerId(collection["Customer.CustomerName"]);
                int lId = Repo.LookupLocationId(collection["Location.LocationName"]);
                int pId = Repo.LookupPizzaId(collection["Pizza.PizzaSize"], collection["Pizza.PizzaCrust"]);

                Repo.UpdateLocationInventory(collection["Location.LocationName"], collection["Pizza.PizzaSize"],
                    collection["PizzaOrderToppings"].ToList(), Int32.Parse(collection["PizzaQuantity"]));

                Repo.AddPizzaOrder(cId, lId, pId, Int32.Parse(collection["PizzaQuantity"]),
                    Order.CalculateCost(collection["Pizza.PizzaSize"],
                    collection["PizzaOrderToppings"].ToList(), Int32.Parse(collection["PizzaQuantity"])), DateTime.Now);

                Repo.AddPizzaOrderToppings(collection["PizzaOrderToppings"].ToList());

                

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: PizzaOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}