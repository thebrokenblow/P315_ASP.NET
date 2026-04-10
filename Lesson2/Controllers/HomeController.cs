using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }
}