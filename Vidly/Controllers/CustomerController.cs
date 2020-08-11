﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        //static List<Customer> customers = new List<Customer>()
        //{
        //    new Customer
        //    {
        //       Name ="Fatih Ceylan",
        //       Id= 1,
        //    },
        //    new Customer
        //    {
        //        Name="Mahmut Tuncer",
        //        Id=2,
        //    },
        //    new Customer
        //    {
        //        Name="İsmail Türüt",
        //        Id=3,
        //    }
        //};


        //[Route("~/Customers")]
        //public IActionResult Customers()
        //{
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Customers = customers
        //    };
        //    return View(viewModel);
        //}

        //public IActionResult Details(int? id)
        //{

        //    var customer = customers.FirstOrDefault(a => a.Id == id);
        //    if (customer == null)
        //    {
        //        return NotFound("Error");
        //    }
        //    return View(customer);

        //}

        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return View(customer);
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name="John Smith"},
                new Customer{Id=2,Name="Mary Jane"}
            };
        }
    }
}
