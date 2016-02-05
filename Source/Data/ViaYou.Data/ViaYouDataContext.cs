﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using ViaYou.Domain.Users;
using System.Data.Entity;
using ViaYou.Domain.Travels;
using ViaYou.Domain.Chat;

namespace ViaYou.Data
{
    public class ViaYouDataContext : IdentityDbContext<ApplicationUser>
    {
        public ViaYouDataContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ViaYouDataContext Create()
        {
            return new ViaYouDataContext();
        }

        public DbSet<Travel> Travels { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
