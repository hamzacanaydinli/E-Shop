using Microsoft.AspNetCore.Mvc;

namespace E_ShopMVC.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
