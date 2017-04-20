using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stanly.Models;

namespace Stanly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            var customers = getCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        private IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Name = "Bill", Id = 1},
                new Customer() {Name = "Joe", Id = 2},
                new Customer() {Name = "Phil", Id = 3}
            };
        }
    }
}