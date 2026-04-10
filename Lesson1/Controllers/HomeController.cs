using Lesson1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var person = new Person
        {
            Name = "Артём",
            Surname = "Красов",
            Age = 23
        };

        return View(person);
    }
}