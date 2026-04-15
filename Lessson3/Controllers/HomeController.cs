using Lesson3.Models;
using Lesson3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers;

public class HomeController(ProductRepository productRepository, IServiceProvider serviceProvider) : Controller
{
    private const string SuffixController = "Controller";

    public IActionResult Index()
    {
        var products = productRepository.GetAll();

        return View(products);
    }

    public IActionResult Create()
    {
        var product = new Product();
        product.Description = "123wefgvwergfwer";
        return View(product);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        productRepository.Create(product);

        var nameAction = nameof(HomeController.Index);
        var nameController = GetControllerName(nameof(HomeController));

        return RedirectToAction(nameAction, nameController);
    }

    public IActionResult Details(int id)
    {
        var product = productRepository.GetById(id);
        return View(product);
    }

    public IActionResult Delete(int id)
    {
        productRepository.DeleteById(id);

        var nameAction = nameof(HomeController.Index);
        var nameController = GetControllerName(nameof(HomeController));

        return RedirectToAction(nameAction, nameController);
    }

    private static string GetControllerName(string nameController)
    {
        return nameController.Replace(SuffixController, string.Empty);
    }
}
