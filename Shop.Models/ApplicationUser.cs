﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name {  get; set; }
        public string Address {  get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        [ValidateNever]
        public Store Store { get; set; }
    }
}
