﻿using Microsoft.AspNetCore.Identity;
using System;

namespace AcmeProducts.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Created = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
