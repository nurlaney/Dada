using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ProfileRepositories;

namespace Dada.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IMapper _mapper;
        public ProfileController(IProfileRepository profileRepository,
                                  IMapper mapper)
        {
            _mapper = mapper;
            _profileRepository = profileRepository;
        }


        public IActionResult Index(string username)
        {
            var token = HttpContext.Request.Cookies["user-token"];
            var myprofile = _profileRepository.GetUserByToken(token);

            ViewBag.token = token;
            ViewBag.user = myprofile;

            var profile = _profileRepository.GetUserByUserName(username);

            if (profile == null) return NotFound();

            var model = new ProfileViewModel
            {
                User = _mapper.Map<User, UserViewModel>(profile),
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Compose(ProfileViewModel model)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = model.Post.Title,
                    Text = model.Post.Text,
                    AddedDate = DateTime.Now,
                    UserId = myprofile.Id,
                };

                _profileRepository.CreatePost(post);

                return RedirectToAction("index", new { username = myprofile.Username });
            }

            return View(model);
        }

        public IActionResult DeletePost(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var post = _profileRepository.GetPostById(id);

            if(myprofile.Token == token)
            {
                _profileRepository.DeletePost(post);
            }

            return RedirectToAction("index", new { username = myprofile.Username });
        }

    }
}