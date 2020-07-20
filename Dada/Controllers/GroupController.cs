﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Models.Account;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Models;
using Repository.Repositories.GroupRepositories;
using Repository.Repositories.ProfileRepositories;

namespace Dada.Controllers
{
    public class GroupController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepository;
        private readonly IProfileRepository _profileRepository;
        private readonly DadaDbContext _context;

       public GroupController(IGroupRepository groupRepository,
                              IMapper mapper,
                              IProfileRepository profileRepository,
                              DadaDbContext context)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
            _profileRepository = profileRepository;
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var user = _profileRepository.GetUserByToken(token);

            ViewBag.user = user;

            var group = _groupRepository.GetGroupById(id);

            if (group == null) return NotFound();


            if(user != null)
            {
                var joined = _context.GroupUsers.Any(g => g.GroupId == group.Id && g.UserId == user.Id);

                ViewBag.joined = joined;

                var groupUser = _context.GroupUsers.FirstOrDefault(g => g.GroupId == group.Id && g.UserId == user.Id);
                ViewBag.groupuser = groupUser;

            }

            var model = _mapper.Map<Group, GroupViewModel>(group);

            

            if (model == null) return NotFound();

            return View(model);
        }

        public IActionResult JoinGroup(GroupViewModel model)
        {
            var token = HttpContext.Request.Cookies["user-token"];

            var user = _profileRepository.GetUserByToken(token);

            if (token == user.Token)
            {
                GroupUser groupUser = new GroupUser
                {
                    GroupId = model.Id,
                    UserId = user.Id
                };

                _context.Add(groupUser);

                _context.SaveChanges();

                return RedirectToAction("index", new { id = model.Id });
            }

            return Ok(model);
        }

        public IActionResult LeaveGroup(int id)
        {
            var groupuser = _context.GroupUsers.FirstOrDefault(g => g.Id == id);

            _context.Remove(groupuser);
            _context.SaveChanges();

            return RedirectToAction("index", new { id = groupuser.GroupId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Compose(GroupViewModel model,int id)
        {

            var token = HttpContext.Request.Cookies["user-token"];

            var user = _profileRepository.GetUserByToken(token);



            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = model.Post.Title,
                    Text = model.Post.Text,
                    AddedDate = DateTime.Now,
                    GroupId = id,
                    UserId = user.Id,
                };

                _profileRepository.CreatePost(post);

                return RedirectToAction("index", new { id = id });
            }

            return View(model);
        }

    }
}