﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECinemaTicket.Domain
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage = "Role name is required")]
        
        public string RoleName { get; set; }
    }
}
