﻿using activities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace activities.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}