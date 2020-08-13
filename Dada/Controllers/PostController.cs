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
using SendGrid;
using SendGrid.Helpers.Mail;

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

        public async Task<IActionResult> Main()
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress("dada.no-reply@yandex.com", "Dada");
            var subject = "Sending with Twilio SendGrid is Fun";
            var to = new EmailAddress("nurlanyusifli10@gmail.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);

            return Ok(response);
        }
    }
}