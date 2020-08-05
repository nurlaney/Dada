using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dada.Filters;
using Dada.Models.Account;
using Dada.Models.Profile;
using Dada.Models.Userdata;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AccountRepositories;
using Repository.Repositories.SettingsRepositories;

namespace Dada.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class SettingController : Controller
    {
        private Repository.Models.User _user => RouteData.Values["User"] as Repository.Models.User;
        private readonly IMapper _mapper;
        private readonly ISettingRepository _settingRepository;
        private readonly IUserRepository _userRepository;

        public SettingController(IMapper mapper,
                                 ISettingRepository settingRepository,
                                 IUserRepository userRepository)
        {
            _mapper = mapper;
            _settingRepository = settingRepository;
            _userRepository = userRepository;
        }
        public IActionResult Profile()
        {
            var model = _mapper.Map<User, UserViewModel>(_user);
            model.Username = model.Username.Substring(2);


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Profile(UserViewModel model)
        {

            bool CheckUsername = _settingRepository.CheckUserName(_user.Id,"d/"+model.Username);

            if (CheckUsername)
            {
                ModelState.AddModelError("Username", "Bu istifadəçi adı artıq mövcuddur");
            }
            bool CheckEmail = _settingRepository.CheckEmail(_user.Id, model.Email);

            if (CheckEmail)
            {
                ModelState.AddModelError("Email", "Bu Email artıq mövcuddur");
            }

            if (ModelState.IsValid)
            {
                var user = _mapper.Map<UserViewModel, User>(model);

                var userToUpdate = _user;

                _settingRepository.UpdateUser(user, userToUpdate);

                

                return RedirectToAction("profile");
            }

            


            return View(model);
        }

        public IActionResult UserInfo()
        {
            var UserDatas = _settingRepository.GetUserDatas(_user.Id);
            var model = _mapper.Map<UserData, UserDataViewModel>(UserDatas);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserInfo(UserDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userData = _mapper.Map<UserDataViewModel, UserData>(model);
                var dataToUpdate = _settingRepository.GetUserDatas(_user.Id);
                if (dataToUpdate == null) return NotFound();

                _settingRepository.UpdateUserDatas(userData, dataToUpdate);
            }

            return View(model);
        }

        public IActionResult Social()
        {
            var socialAccount = _settingRepository.GetSocials(_user.Id);
            var model = _mapper.Map<UserSocial, UserSocialViewModel>(socialAccount);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Social(UserSocialViewModel model)
        {
            if (ModelState.IsValid)
            {
                var socialAccount = _mapper.Map<UserSocialViewModel, UserSocial>(model);
                var socialToUpdate = _settingRepository.GetSocials(_user.Id);
                if (socialToUpdate == null) return NotFound();

                _settingRepository.UpdateSocialMedia(socialAccount, socialToUpdate);

                return RedirectToAction("social");
            }

            return Ok(model);
        }

        public IActionResult ChangePassword()
        {
            return View();
        }


        public IActionResult Clubs()
        {
            var groups = _settingRepository.GetGroups(_user.Id);
            var model = _mapper.Map<IEnumerable<Group>, IEnumerable<GroupViewModel>>(groups);

            return View(model);
        }

        public IActionResult CreateClub()
        {
            return View();
        }

        public IActionResult ManageGroup()
        {
            return View();
        }
    }
}