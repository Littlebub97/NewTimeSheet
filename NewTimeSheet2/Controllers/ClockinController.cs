using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewTimeSheet2.Controllers
{
    public class ClockinController : Controller
    {
        public IActionResult ClockIn()
        {
            ViewData["Message"] = "ClockIn";
            return View();
        }
    }
}