using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {ID = 1, Name = "John Smith"},
                new Customer {ID = 2, Name = "Mary Williams"}
            };

            var viewCustomers = new CusomtersViewModel()
            {
                Customers = customers
            };
            
            return View(viewCustomers);
        }
        // customers/detail/{id}
        // [Route("customers/details/{id}", Name = "CustomerDetail")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer {ID = 1, Name = "John Smith"},
                new Customer {ID = 2, Name = "Mary Williams"}
            };
            var chosenCustomer = customers.FirstOrDefault(c => c.ID == id);
            
            return View(chosenCustomer);
        }
        
    }
}