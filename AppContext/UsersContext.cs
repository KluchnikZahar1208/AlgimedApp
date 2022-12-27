using AlgimedApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgimedApp.AppContext
{
    public class UsersContext:DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public UsersContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersdb;Trusted_Connection=True;");
        }
    }
}
