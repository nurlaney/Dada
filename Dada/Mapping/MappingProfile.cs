﻿using AutoMapper;
using Dada.Models;
using Dada.Models.Account;
using Dada.Models.Notification;
using Dada.Models.Profile;
using Dada.Models.Userdata;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();

            CreateMap<Group, GroupViewModel>();
            CreateMap<GroupViewModel, Group>();


            CreateMap<Post, PostViewModel>();

            CreateMap<Comment, CommentViewModel>();

            CreateMap<RegisterViewModel, User>();

            CreateMap<UserData, UserDataViewModel>();
            CreateMap<UserSocial, UserSocialViewModel>();
            CreateMap<UserSocialViewModel, UserSocial>();
            CreateMap<UserDataViewModel, UserData>();

            CreateMap<Notification, NotificationViewModel>();
        }
    }
}
