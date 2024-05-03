using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace ShopOnline.Controllers
{

    public class ProdottiController : Controller
    {

        public ProdottiController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}