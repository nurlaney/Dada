using AutoMapper;
using Dada.Models;
using Dada.Models.Account;
using Dada.Models.Profile;
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


            CreateMap<Group, GroupViewModel>();


            CreateMap<Post, PostViewModel>();

            CreateMap<Comment, CommentViewModel>();

            CreateMap<RegisterViewModel, User>();
        }
    }
}
