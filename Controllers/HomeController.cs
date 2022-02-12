using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private BookstoreContext context { get; set; }
        public HomeController(BookstoreContext temp) => context = temp;

        public IActionResult Index()
        {
            return View();
        }
    }
}
