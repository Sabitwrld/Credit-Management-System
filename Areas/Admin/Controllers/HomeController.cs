﻿using Microsoft.AspNetCore.Mvc;

namespace CreditManagementSystemApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
