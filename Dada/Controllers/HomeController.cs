using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dada.Models;
using Repository.Repositories.ProfileRepositories;
using AutoMapper;
using Repository.Models;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Http;
using Repository.Repositories.MainRepositories;
using Dada.Models.Account;
using System;

namespace Dada.Controllers

{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMainRepositories _mainRepositories;
        private readonly IProfileRepository _profileRepository;

        public HomeController(IMapper mapper,
                              IMainRepositories mainRepositories,
                              IProfileRepository profileRepository)
        {
            _mapper = mapper;
            _mainRepositories = mainRepositories;
            _profileRepository = profileRepository;
        }

        public IActionResult Index()
        {
            var posts = _mainRepositories.GetPosts();
            var groups = _mainRepositories.GetGroups();
            var users = _mainRepositories.GetUsers();

            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            ViewBag.user = myprofile;

            ViewBag.token = token;

            var model = new MainViewModel
            {
                Posts = _mapper.Map<ICollection<Post>, ICollection<PostViewModel>>(posts),
                Users = _mapper.Map<ICollection<User>, ICollection<UserViewModel>>(users),
                Groups = _mapper.Map<ICollection<Group>, ICollection<GroupViewModel>>(groups)
            };


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Compose(MainViewModel model)
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

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult DeletePost(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var post = _profileRepository.GetPostById(id);

            if (myprofile.Token == token)
            {
                _profileRepository.DeletePost(post);
            }

            return RedirectToAction("index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
