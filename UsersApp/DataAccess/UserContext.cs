using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserContext:DbContext
    {
        public DbSet<User> users { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer("Server=LAPTOP-59IDB8MH; Database=Employees; User Id=sa; Password=Bogota21*; Trust Server Certificate=true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(users =>
            {
                users.ToTable("Users");
                users.HasKey(p => p.UserId);
                users.Property(p => p.UserName).HasMaxLength(100);
                users.Property(p => p.Birthdate).HasMaxLength(100);
                users.Property(p => p.Sex).HasMaxLength(1);
            });
        }
    }
}
