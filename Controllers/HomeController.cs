using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AccountApp.Models;

namespace AccountApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}
