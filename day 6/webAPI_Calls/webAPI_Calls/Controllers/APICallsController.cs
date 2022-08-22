using Microsoft.AspNetCore.Mvc;
using webAPI_Calls.Models;
namespace webAPI_Calls.Controllers
{
    public class APICallsController : Controller
    {
        public IActionResult PostData()
        {
            return View();
        }

        public IActionResult GetAlbums()
        {
            return View();
        }

        public IActionResult GetPostNew()
        {
            PostDataModel obj = new PostDataModel();
            ViewBag.data = obj.GetPostDatas();
            return View();
        }

        public IActionResult GetComments()
        {
            CommentsData data = new CommentsData();
            return View(data.GetComments());
        }


       
    }
}
