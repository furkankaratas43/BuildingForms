using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuildingForms.Models;

namespace BuildingForms.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Search()
    {
        return View();
    }
}
