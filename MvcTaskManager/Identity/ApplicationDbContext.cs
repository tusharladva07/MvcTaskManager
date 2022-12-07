using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcTaskManager.Models;
using System;

namespace MvcTaskManager.Identity
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,String>
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<IdentityRole> Roles{ get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
