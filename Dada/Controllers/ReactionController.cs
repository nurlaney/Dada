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

        public void RemoveUpvote(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var reaction = _reactionRepository.FindReaction(myprofile.Id, id);

            _reactionRepository.RemoveReaction(reaction);
        }
    }
}