using AutoMapper;
using Dada.Models;
using Dada.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ProfileRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.ViewComonents
{
    public class EndPointsViewComponent : ViewComponent
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IMapper _mapper;
        public EndPointsViewComponent(IProfileRepository profileRepository,
                                  IMapper mapper)
        {
            _mapper = mapper;
            _profileRepository = profileRepository;
        }

        public IViewComponentResult Invoke()
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var myprofile = _profileRepository.GetUserByToken(token);

            var model = _mapper.Map<User, UserViewModel>(myprofile);

            return View(model);
        }
    }
}
