using Microsoft.AspNetCore.Mvc;
using DI_Demo.Models;
namespace DI_Demo.Controllers
{
    public class ProductsController : Controller
    {

        //  Products pObj = new Products(); // this is the crime scene, if you create an object, please wite destruction code


        //step 1 to DI 

        Products _pObj;

        //Object will be created by runtime and reference will be passed to this controller, when controller is invoked
        public ProductsController(Products _pObjREF)
        {
            _pObj = _pObjREF;
        }

        public IActionResult ShowProducts()
        {
            return View(_pObj.ShowProducts());
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Products newProduct)
        {
            _pObj.AddProduct(newProduct);
            return View();
        }
    }
}
