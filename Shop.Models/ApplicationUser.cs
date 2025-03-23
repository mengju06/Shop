﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name {  get; set; }
        public string Address {  get; set; }
    }
}
