using FP.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FP.Data
{
    public class FPDbContext : IdentityDbContext<User>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public FPDbContext(DbContextOptions<FPDbContext> options)
            : base(options)
        {
        }

    }
}
