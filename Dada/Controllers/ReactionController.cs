using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ProfileRepositories;
using Repository.Repositories.ReactionRepositories;

namespace Dada.Controllers
{
    public class ReactionController : Controller
    {
        private Repository.Models.User _user => RouteData.Values["User"] as Repository.Models.User;

        private readonly IReactionRepository _reactionRepository;
        private readonly IProfileRepository _profileRepository;

        public ReactionController(IReactionRepository reactionRepository,
                                  IProfileRepository profileRepository)
        {
            _reactionRepository = reactionRepository;
            _profileRepository = profileRepository;
        }
        public void UpvotePost(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);
            Reaction reaction = new Reaction
            {
                UserId = myprofile.Id,
                PostId = id,
                Upvote = true,
                AddedDate = DateTime.Now
            };
            _reactionRepository.AddReaction(reaction);
        }

        public IActionResult RemoveUpvote(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var reaction = _reactionRepository.FindReaction(myprofile.Id, id);


            _reactionRepository.RemoveReaction(reaction);


            var notifyToDelete = _reactionRepository.GetNotificationByReaction($"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/post/index/"+id,myprofile.FullName);

            if (notifyToDelete == null) return Ok();

            _reactionRepository.RemoveNotify(notifyToDelete);


            return Ok(notifyToDelete);
        }

        public void DownvotePost(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);
            Reaction reaction = new Reaction
            {
                UserId = myprofile.Id,
                PostId = id,
                Upvote = false,
                AddedDate = DateTime.Now
            };
            _reactionRepository.AddReaction(reaction);
        }

        public void DownvoteComment(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);
            CommentReaction commentReaction = new CommentReaction
            {
                UserId = myprofile.Id,
                CommentId = id,
                Upvote = false,
                AddedDate = DateTime.Now
            };
            _reactionRepository.AddCommentReaction(commentReaction);
        }

        public IActionResult RemoveDownvote(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var reaction = _reactionRepository.FindReactionDown(myprofile.Id, id);


            _reactionRepository.RemoveReaction(reaction);


            var notifyToDelete = _reactionRepository.GetNotificationByReaction($"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/post/index/" + id, myprofile.FullName);

            if (notifyToDelete == null) return Ok();

            _reactionRepository.RemoveNotify(notifyToDelete);


            return Ok(notifyToDelete);
        }

        public IActionResult RemoveDownvoteComment(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var reaction = _reactionRepository.FindCommentReactionDown(myprofile.Id, id);


            _reactionRepository.RemoveCommentReaction(reaction);


            var notifyToDelete = _reactionRepository.GetNotificationByReaction($"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/post/index/" + id, myprofile.FullName);

            if (notifyToDelete == null) return Ok();

            _reactionRepository.RemoveNotify(notifyToDelete);


            return Ok(notifyToDelete);
        }

        public void UpvoteComment(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);
            CommentReaction commentReaction = new CommentReaction
            {
                UserId = myprofile.Id,
                CommentId = id,
                Upvote = true,
                AddedDate = DateTime.Now
            };
            _reactionRepository.AddCommentReaction(commentReaction);
        }

        public IActionResult RemoveUpvoteComment(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var reaction = _reactionRepository.FindCommentReaction(myprofile.Id, id);


            _reactionRepository.RemoveCommentReaction(reaction);


            var notifyToDelete = _reactionRepository.GetNotificationByReaction($"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/post/index/" + id, myprofile.FullName);

            if (notifyToDelete == null) return Ok();

            _reactionRepository.RemoveNotify(notifyToDelete);


            return Ok(notifyToDelete);
        }
    }
}