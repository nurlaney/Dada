using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.PostRepositories;
using Repository.Repositories.ProfileRepositories;

namespace Dada.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly IProfileRepository _profileRepository;
        public PostController(IPostRepository postRepository,
                              IMapper mapper,
                              IProfileRepository profileRepository)
        {
            _postRepository = postRepository;
            _mapper = mapper;
            _profileRepository = profileRepository;
        }

        public IActionResult Index(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            ViewBag.token = token;
            ViewBag.user = myprofile;

            var post = _postRepository.GetPostById(id);

            var model = _mapper.Map<Post, PostViewModel>(post);


            return View(model);
        }
    }
}