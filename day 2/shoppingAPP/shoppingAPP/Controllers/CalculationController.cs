using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP.Controllers
{
    public class CalculationController : Controller
    {
      
        public IActionResult Calculate()
        {
            ViewBag.add = 0;
            ViewBag.sub = 0;
            ViewBag.mul = 0;
            ViewBag.div = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int num1, int num2)
        {
            ViewBag.add = num1 + num2;
            ViewBag.sub = num1 - num2;
            ViewBag.mul = num1 * num2;
            ViewBag.div = num1 / num2;

            return View();
        }
    }
}
