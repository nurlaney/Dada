using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dada.Models;
using Repository.Repositories.ProfileRepositories;
using AutoMapper;
using Repository.Models;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Http;
using Repository.Repositories.MainRepositories;
using Dada.Models.Account;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
