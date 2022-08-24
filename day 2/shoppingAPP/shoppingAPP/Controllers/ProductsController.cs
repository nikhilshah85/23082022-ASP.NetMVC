using Microsoft.AspNetCore.Mvc;
using shoppingAPP.Models;
namespace shoppingAPP.Controllers
{
    public class ProductsController : Controller
    {
      static  List<string> pList = new List<string>()
            { "T-Shirt", "Shoes", "Jeans","Belt","Deo","Gel"};


        ProductModel pObj = new ProductModel();
        public IActionResult ShowProducts()
        {
            ViewBag.products = pObj.GetProductsList();
            return View();
        }



        public IActionResult Productlist()
        {
            //this is data and this will come from model file           

            ViewBag.products = pList;
            ViewBag.count = pList.Count;
            //ViewBag.listupdate = new DateTime();
            return View();
        }
        [HttpPost]
    public IActionResult Productlist(string newProduct)
    {
            pList.Add(newProduct);
            ViewBag.products = pList;
            ViewBag.count = pList.Count;
            return View();
    }

       public IActionResult ProductsHome()
        {
            return View();
        }

       
    }
}
