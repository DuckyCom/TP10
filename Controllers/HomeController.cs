﻿using Microsoft.AspNetCore.Mvc;

namespace Tp10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
