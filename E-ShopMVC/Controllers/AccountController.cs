using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using E_Shop.BL.Menagers.Abstract;
using E_Shop.Entities.Entities.Concrete;
using E_ShopMVC.Models.VMs.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_ShopMVC.Controllers
{
    [Authorize]
    public class AccountController(IManager<Role> roleManager
                                   , IManager<User> userManager
                                   , INotyfService notyfService
                                    , IMapper mapper) : Controller
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
        //public async Task<IActionResult> Login(LoginVM loginVM)
        //{
        //    var user = userManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password
        //    , p => p.Roller).FirstOrDefault();
        //    if (user == null)
        //    {
        //        notyfService.Error("Email yada Password Hatali.");
        //        return View(loginVM);
        //    }

        //    // Cookie uzerinde tutulacak bilgileri tanimliyoruz. Yani Kimlik karti uzerindeki bilgiler gibi dusunebilirsiniz.
        //    string roller = "";
        //    foreach (var item in user.Roller)
        //    {
        //        roller += item.RoleAdi + " ";
        //    }
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimTypes.NameIdentifier, loginVM.Email),
        //        //new Claim(ClaimTypes.Email, loginVM.Email),
        //        new Claim(ClaimTypes.Name,user.Ad + " " + user.Soyad),
        //        new Claim(ClaimTypes.MobilePhone,user.Gsm),
        //        new Claim(ClaimTypes.Role,roller),
        //        //new Claim(ClaimTypes.Gender,user.Cinsiyet.ToString()),
        //        new Claim (ClaimTypes.Email,user.Email + " " + user.Email),
        //        //new Claim(ClaimTypes.NameIdentifier,"12312312311"),
        //        //new Claim(ClaimTypes.UserData,user.PhotoPath)

        //    };
        //    var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //    var authenticationProperty = new AuthenticationProperties()
        //    {
        //        IsPersistent = loginVM.RememberMe
        //    };
        //    var userClaimPrinciple = new ClaimsPrincipal(claimIdentity);


        //    //var signIn = HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity),
        //    //    _userService.AuthenticationOptions(model.RememberMe));

        //    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
        //        userClaimPrinciple, authenticationProperty);

        //    if (roller.Contains("Admin"))   // büyük A olacak Githubda kucuk a kayitli
        //    {
        //        return RedirectToAction("Index", "Home", new { Area = "Admin" });
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }



        //}
        [HttpGet]
        //[AllowAnonymous]


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
        //[HttpPost]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserInsert(UserInsertVM insertVM)
        {

            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);
            }
            // Burada insertvm MyUser sinifina çevrilmesi lazim

            #region Amele Yontemi

            //MyUser myUser = new MyUser();
            //myUser.Cinsiyet=insertVM.Cinsiyet;
            //myUser.Ad=insertVM.Ad;
            //myUser.Soyad=insertVM.Soyad;
            //myUser.Email=insertVM.Email;
            //myUser.TcNo=insertVM.TcNo;
            //myUser.Gsm=insertVM.Gsm;
            //myUser.CreateDate=DateTime.Now;
            //myUser.Password=insertVM.Password;
            #endregion

            var myUser = mapper.Map<User>(insertVM);
            userManager.Create(myUser);

            #region Kullaniciya Default olarak user rolü eklenir
            var role = roleManager.Get(p => p.RoleName == "user"); // user role db'den cekilir
            myUser.Role = new List<Role>();
            myUser.Roles.Add(role);
            userManager.Update(myUser);
            #endregion
            notyfService.Success("Islem Basarili");



            // userManager.Create(insertVM);

            //return RedirectToAction("Index", "Account", new { Area = "Admin" });

            return RedirectToAction("UserRegisterSuccess", "Account");

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserRegisterSuccess()
        {
            return View();
        }
    }
}
