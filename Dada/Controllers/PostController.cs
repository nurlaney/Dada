using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.MainRepositories;
using Repository.Repositories.PostRepositories;
using Repository.Repositories.ProfileRepositories;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Dada.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly IProfileRepository _profileRepository;
        private readonly IMainRepositories _mainRepositories;
        public PostController(IPostRepository postRepository,
                              IMapper mapper,
                              IProfileRepository profileRepository,
                              IMainRepositories mainRepositories)
        {
            _postRepository = postRepository;
            _mapper = mapper;
            _profileRepository = profileRepository;
            _mainRepositories = mainRepositories;
        }

        public IActionResult Index(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var groups = _mainRepositories.GetGroups();
            var titles = _mainRepositories.GetPosts();

            ViewBag.groups = groups;

            ViewBag.titles = titles;

            ViewBag.token = token;

            ViewBag.user = myprofile;

            var post = _postRepository.GetPostById(id);

            var model = _mapper.Map<Post, PostViewModel>(post);

            return View(model);
        }

        public IActionResult ComposeComment(PostViewModel model, int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);


            if (ModelState.IsValid)
            {
                Comment comment = new Comment
                {
                    Text = model.Comment.Text,
                    AddedDate = DateTime.Now,
                    UserId = myprofile.Id,
                    PostId = id
                };

                _postRepository.AddComment(comment);

                return RedirectToAction("index", new { id = id });
            }
            return Ok(model);
        }

        public IActionResult DeleteComment(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var comment = _postRepository.GetCommentById(id);

            if (myprofile.Token == token)
            {
                _postRepository.DeleteComment(comment);
            }

            return RedirectToAction("index", new { id = comment.PostId });
        }

    }
}