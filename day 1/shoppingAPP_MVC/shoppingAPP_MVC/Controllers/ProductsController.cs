using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP_MVC.Controllers
{
    public class ProductsController : Controller
    {
       public IActionResult Productlist()
        {            
            return View();
        }

        public IActionResult OrdersList()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
