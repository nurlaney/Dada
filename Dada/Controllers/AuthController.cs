using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dada.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.AccountRepositories;

namespace Dada.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = _userRepository.Login(model.Email, model.Password);

                if (user != null)
                {
                    user.Token = Guid.NewGuid().ToString();
                    _userRepository.UpdateToken(user.Id, user.Token);

                    Response.Cookies.Append("user-token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1)
                    });

                    return RedirectToAction("index", "home");
                }
                ModelState.AddModelError("Password", "Şifrə vəya istifadəçi adı səhvdir !");
            }
            return View("Views/Auth/Index.cshtml",model);
        }
    }
}