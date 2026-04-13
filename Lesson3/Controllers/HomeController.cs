using Lesson3.Model;
using Lesson3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers;

public class HomeController(ProductRepository productRepository) : Controller
{
    public IActionResult Index()
    {
        var products = productRepository.Get();
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = productRepository.GetById(id);
        return View(product);
    }

    public IActionResult Create()
    {
        return View(new Product());
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        productRepository.Add(product);

        return RedirectToAction("Index");
    }
}