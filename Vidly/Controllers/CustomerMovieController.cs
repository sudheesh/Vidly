using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerMovieController : Controller
    {
        // GET: CustomerMovie
        public ActionResult Index()
        {
            return View();

        }
        //Action Result for Customer and List name is Customers 
        public ActionResult Customer()
            
        {
            var customer = new Customer();
            List<Customer>customers = new List<Customer>()
            {
                new Customer() {Id=1,Name="jonny Walker" },
                new Customer() {Id = 2, Name = "David " }
            };
            customer.Id = 1;

            return View();
        }
    }
}