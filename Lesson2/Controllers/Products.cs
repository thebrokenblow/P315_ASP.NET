using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers;

public class Products : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
