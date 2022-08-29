using Microsoft.AspNetCore.Mvc;

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
    }
}
