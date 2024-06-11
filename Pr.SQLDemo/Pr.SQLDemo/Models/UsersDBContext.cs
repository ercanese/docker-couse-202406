using Microsoft.EntityFrameworkCore;
using Pr.SQLDemo.Models;
public class UsersDBContext : DbContext
    {
        public UsersDBContext(DbContextOptions<UsersDBContext> options) : base(options)
        {

        }

        public DbSet<Users> Users{ get; set; }

    }