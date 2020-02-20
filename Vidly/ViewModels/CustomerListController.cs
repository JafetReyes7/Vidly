using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerListController
    {
        public List<Customer> customerList { get; set; }
    }
}