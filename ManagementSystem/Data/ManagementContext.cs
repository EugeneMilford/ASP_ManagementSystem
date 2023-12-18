using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Models;

namespace ManagementSystem.Data
{
    public class ManagementContext : DbContext
    {
        public ManagementContext (DbContextOptions<ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Personnel { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<BugTracking> Bugs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>().ToTable("staff");
            modelBuilder.Entity<Event>().ToTable("event");
            modelBuilder.Entity<Role>().ToTable("role");
            modelBuilder.Entity<Assignment>().ToTable("assignment");
            modelBuilder.Entity<Project>().ToTable("project");
            modelBuilder.Entity<Message>().ToTable("message");
            modelBuilder.Entity<Mail>().ToTable("mail");
            modelBuilder.Entity<Profile>().ToTable("profile");
            modelBuilder.Entity<BugTracking>().HasNoKey().ToTable("bug");
        }

    }
}
