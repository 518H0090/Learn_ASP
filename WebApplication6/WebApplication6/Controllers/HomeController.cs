﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexStatement()
        {
            return View();
        }
    }
}
