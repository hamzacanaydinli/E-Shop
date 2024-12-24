using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using E_Shop.BL.Menagers.Abstract;
using E_Shop.Entities.DbContexts;
using E_Shop.Entities.Entities.Concrete;
using E_ShopMVC.Models.VMs.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Mate.MVC.Controllers
{
    [Authorize]
    public class AccountController(IManager<Role> roleManager, INotyfService notyfService, IManager<MyUser> userManager, SqlDbContext sqlDbContext) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Users()
        {
            var users = userManager.GetAllInclude(null, p => p.Role).ToList();
            return View(users);
        }
        [HttpGet]
        [AllowAnonymous] // Burasi Herkese açik hale gelir
        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        [AllowAnonymous]
        //public IActionResult Login(string email,string password,bool rememberme)
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var user = userManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password).FirstOrDefault();
            //var personel = roleManager.GetAllInclude(p => p.Mail == girisVM.Mail && p.Sifre == girisVM.Sifre).FirstOrDefault();

            if (user == null)
            {

                notyfService.Error("Mail ya da şifre hatalı.");
                return View(loginVM);

            }
            if (user.RoleId == 1)
            {
                return RedirectToAction("Hizmetler", "Sayfa");
            }
            ////else if (user.RoleId == 2)
            ////{
            ////    return RedirectToAction("Index", "Home");
            ////}

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,loginVM.Email)
            };

            if (user != null)
            {
                claims.Add(new Claim("userId", user.Id.ToString()));  // userId'yi claim olarak ekliyoruz
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties()
            {
                IsPersistent = loginVM.RememberMe
            };

            var userPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincipal, authenticationProperty);

            return RedirectToAction("Index", "Home"); ;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserInsert()
        {

            UserInsertVM userInsertVM = new UserInsertVM();
            return View(userInsertVM);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult UserInsert(UserInsertVM insertVM)
        {


            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);

            }

            MyUser myUser = new MyUser();

            myUser.SurName = insertVM.SurName;
            myUser.Name = insertVM.Name;
            myUser.Email = insertVM.EMail;
            myUser.Gsm = insertVM.Gsm;
            myUser.Password = insertVM.Password;


            var user = userManager.Get(p => p.Email == myUser.Email);
            if (user != null)
            {
                notyfService.Success("Bu email kullanilmaktadir");
                return View(insertVM);
            }

            //var role = roleManager.GetAllInclude(p => p.RoleName == "User", p => p.Users).FirstOrDefault();

            userManager.Create(myUser);
            notyfService.Success("Kullanıcı Olusturuldu");


            // userManager.Create(insertVM);

            return RedirectToAction("Login", "Account");

        }

    }
}