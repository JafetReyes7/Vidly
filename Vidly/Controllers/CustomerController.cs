using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {


        [Route("Customers/")]
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe", Id = 1},
                new Customer { Name = "Jane Doe", Id = 2}
            };
            var viewModel = new CustomerListController
            {
                customerList = customers
            };

            return View(viewModel);

        }

        [Route("Customer/{id}")]
        public ActionResult Customer(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe", Id = 1},
                new Customer { Name = "Jane Doe", Id = 2}
            };
            var viewModel = new CustomerListController
            {
                customerList = customers
            };
            
            return View(viewModel.customerList.Where(cust => cust.Id == id).First());

        }
    }
}