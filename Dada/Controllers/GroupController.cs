using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.GroupRepositories;

namespace Dada.Controllers
{
    public class GroupController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepository;

       public GroupController(IGroupRepository groupRepository,
                              IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }
        public IActionResult Index(int id)
        {

            var group = _groupRepository.GetGroupById(id);

            var model = _mapper.Map<Group, GroupViewModel>(group);

            return View(model);
        }

    }
}