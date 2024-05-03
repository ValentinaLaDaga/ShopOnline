﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models;
using Microsoft.Extensions.Logging;

namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}