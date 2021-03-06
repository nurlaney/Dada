﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Models
{
    public class LoginViewModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
