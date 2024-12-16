using Microsoft.AspNetCore.Mvc;

namespace E_Shop.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
