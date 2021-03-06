﻿using Dada.Models.Profile;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models.Account
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string Info { get; set; }
        public string Rules { get; set; }
        public ICollection<GroupUser> GroupUsers { get; set; }
        public ICollection<PostViewModel> Posts { get; set; }
        public PostViewModel Post { get; set; }
    }
}
