using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nonameClub.Models.Configurations;

namespace nonameClub.Models.Connect
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Servers> Servers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=Servers.db");
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var roles = new List<Roles>()
            {
                new Roles{ RoleId = 1, RoleName = "Admin", RolePriority = 100}
            };
            var users = new List<Users>()
            {
                new Users{ UserId = 1, Username = "Admin", Password = "123", Email = "123@admin.ru", RoleId = 1}
            };
            builder
                .ApplyConfiguration(new ServerConfiguration());
            builder
                .ApplyConfiguration(new RolesConfiguration());
            builder
                .ApplyConfiguration(new UserConfiguration());
            builder.Entity<Roles>().HasData(roles);
            builder.Entity<Users>().HasData(users);
        }
    }
}
