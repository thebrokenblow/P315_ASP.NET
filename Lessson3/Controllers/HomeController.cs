using Lesson3.Repositories;
using Lessson3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson3.Controllers;

public class HomeController(ProductRepository productRepository) : Controller
{
    public IActionResult Index()
    {
        var products = productRepository.GetAll();
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = productRepository.GetById(id);
        return View(product);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
