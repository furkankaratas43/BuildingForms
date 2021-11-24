using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuildingForms.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(ProductRepository.Products);
    }
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(new List<string>() { "Telefon", "Bilgisayar", "Tablet" });

        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        ProductRepository.AddProduct(product);
        return RedirectToAction("Index");
    }

    public IActionResult Search(string q)
    {
        if (!String.IsNullOrWhiteSpace(q))
        {
            return View("Index", ProductRepository.Products.Where(i => i.Name.Contains(q)));
        }
        else
        {
            return View();
        }
    }
}
