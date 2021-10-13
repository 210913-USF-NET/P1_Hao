﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using BL;
using Microsoft.AspNetCore.Http;
using Models;



namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBL _bl;
        private CustomerVM currentCustomer = new CustomerVM();
        /*private string _newcustomer = "false";*/

        public HomeController(IBL bl)
        {
            _bl = bl;
        }

 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
