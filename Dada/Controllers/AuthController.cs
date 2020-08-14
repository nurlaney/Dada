using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models;
using Dada.Services.EmailServices;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AccountRepositories;

namespace Dada.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        public AuthController(IUserRepository userRepository,
                              IMapper mapper,
                              IEmailSender emailSender)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _emailSender = emailSender;
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
                user.ConfirmToken = Guid.NewGuid().ToString();
                user.Username = "d/" + model.Username;
                user.JoinDate = DateTime.Now;
                user.EmailConfirmed = false;


                _userRepository.Register(user);

                     _emailSender.Send(user.Email, user.FullName, "d-e0fa4ccef93c430d98a0ca0bf6c4e7d1", new
                {
                    Subject = "Email təsdiqi",
                    Title = "Dadaya xoş gəlmisən !",
                    Subtitle = "Dadanın tam imkanlarından yararlanmaq üçün emailini aşağıdakı düyməyə klik edərək təsdiqləsən yaxşı olar,dostum",
                    btn = new
                    {
                        active = true,
                        text = "Emaili təsdiqlə",
                        url = $"{ this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/auth/confirm?token={user.ConfirmToken}"
                    }
                }) ;


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
                Response.Cookies.Append("confirm-token", user.ConfirmToken, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                return RedirectToAction("index", "home");

                
            }


            return View(model);
        }

        public IActionResult Confirm(string token)
        {
            if (string.IsNullOrEmpty(token)) return NotFound();

            User user = _userRepository.GetUserByConfirmToken(token);

            if (user == null && user.ConfirmToken == null) return NotFound();

            user.ConfirmToken = null;

            _userRepository.ConfirmUser(user);


            return RedirectToAction("index", "home");
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
