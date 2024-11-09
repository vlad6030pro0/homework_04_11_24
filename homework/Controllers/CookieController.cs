using System;
using Microsoft.AspNetCore.Mvc;

namespace homework.Controllers;

public class CookieController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AddCookie()
    {

        return RedirectToAction();
    }
}
