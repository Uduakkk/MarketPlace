﻿using MarketPlace.Core.Enums;
using MarketPlace.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Core.Dtos
{
    public class AppUserDto : BaseModel<string>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public UserType UserType { get; set; }
        public string? Address { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
