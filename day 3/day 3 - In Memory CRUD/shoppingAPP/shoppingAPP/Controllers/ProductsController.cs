using Microsoft.AspNetCore.Mvc;
using shoppingAPP.Models;
namespace shoppingAPP.Controllers
{
    public class ProductsController : Controller
    {

        //this will be replaced with DI later on
        //createing a new object is like a crime now
        ProductsModel pObj = new ProductsModel();
        public IActionResult ShowAllProducts()
        {
            ViewBag.allProducts = pObj.GetAllProducts();
            return View();
        }

        public IActionResult SearchProductById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchProductById(int productId)
        {
          

                ViewBag.product = pObj.GetProductById(productId);
            
          
            return View();
        }


        public IActionResult SearchProductByCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchProductByCategory(string productCategory)
        {
            ViewBag.productByCategory = pObj.GetAllProductsByCategory(productCategory);
            return View();
        }


        public IActionResult AddProduct()
        {
            ViewBag.addResult = "";
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductsModel newProduct)
        {
             ViewBag.addResult =  pObj.AddProduct(newProduct);
           return  RedirectToAction("ShowAllProducts");
        }

        public IActionResult DeleteProduct()
        {
            ViewBag.deleteResult = "";
            return View();
        }


        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            ViewBag.deleteResult = pObj.DeleteProduct(productId);
            return View();
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateProduct(ProductsModel update)
        {
            ViewBag.udpateResult = pObj.UpdateProduct(update);
            return View();
        }





    }
}








