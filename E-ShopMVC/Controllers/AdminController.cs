﻿using Microsoft.AspNetCore.Mvc;

namespace E_ShopMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
