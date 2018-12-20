using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_Csharp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate (Calculator calculator)
        {
            calculator.CalculateResult();
            return RedirectToAction("Index", calculator);
        }

    }
}
