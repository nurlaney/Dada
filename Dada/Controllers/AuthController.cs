using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AccountRepositories;

namespace Dada.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AuthController(IUserRepository userRepository,
                              IMapper mapper)
        {
            _mapper = mapper;
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
                var user = _userRepository.Login(model.Username, model.Password);

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

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            bool CheckEmail = _userRepository.CheckEmail(model.Email);

            if (CheckEmail)
            {
                ModelState.AddModelError("Email", "Bu E-mail artiq movcuddur");
            }
            bool CheckUsername = _userRepository.CheckUserName(model.Username);
            if (CheckUsername)
            {
                ModelState.AddModelError("Username", "Bu istifadəçi adı artıq mövcuddur");
            }

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterViewModel, User>(model);

                user.Token = Guid.NewGuid().ToString();
                user.Username = "d/" + model.Username;
                user.JoinDate = DateTime.Now;


                _userRepository.Register(user);

                UserData userData = new UserData
                {
                    UserId = user.Id,
                };
                UserSocial userSocial = new UserSocial
                {
                    UserId = user.Id
                };

                _userRepository.AddUserSocial(userSocial);
                _userRepository.AddUserData(userData);

                Response.Cookies.Append("user-token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                return RedirectToAction("index", "home");
            }


            return View(model);
        }

        public IActionResult Logout()
        {
            Request.Cookies.TryGetValue("user-token", out string token);
            var user = _userRepository.CheckByToken(token);
            _userRepository.UpdateToken(user.Id, "NULL");
            return RedirectToAction("index");
        }
    }

}
