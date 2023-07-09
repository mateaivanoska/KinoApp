﻿using ECinemaTicket.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ECinemaTicket.Domain.Identity
{
    public class ECinemaApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public virtual Cart UserCart { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public string Role { get; set; }


    }
}
