using AspNetCoreHero.ToastNotification.Abstractions;
using E_Shop.BL.Menagers.Abstract;
using E_Shop.Entities.Entities.Concrete;
using E_ShopMVC.Models.VMs.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_ShopMVC.Controllers
{
    public class ContactController(IManager<CommUser> commUserManager, INotyfService notyfService) : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous] // Burasi Herkese açik hale gelir
        public IActionResult İletişim()
        {
            ContactVM contactVM = new ContactVM();
            return View(contactVM);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult İletişim(ContactVM contactVM)
        {
            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(contactVM);

            }


            else
            {
                CommUser commUser = new CommUser();
                commUser.Name = contactVM.Name;
                commUser.Email = contactVM.Email;
                commUser.Message = contactVM.Message;


                commUserManager.Create(commUser);




                return RedirectToAction("CommUserSuccess", "Contact");
            }
        }
        public IActionResult CommUserSuccess()
        {
            return View();
        }
    }
}

