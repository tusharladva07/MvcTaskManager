﻿using Microsoft.AspNetCore.Mvc;

namespace MvcTaskManager.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home/index")]
        public IActionResult Index()
         {
            return View();
        }
    }
}
