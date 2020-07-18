using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.PostRepositories;

namespace Dada.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostController(IPostRepository postRepository,
                              IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public IActionResult Index(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            ViewBag.token = token;


            var post = _postRepository.GetPostById(id);

            var model = _mapper.Map<Post, PostViewModel>(post);


            return View(model);
        }
    }
}