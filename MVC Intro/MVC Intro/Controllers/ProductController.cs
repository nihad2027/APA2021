using Microsoft.AspNetCore.Mvc;

namespace MVC_Intro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
