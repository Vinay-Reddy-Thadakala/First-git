﻿using Microsoft.AspNetCore.Mvc;

namespace SuperMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
