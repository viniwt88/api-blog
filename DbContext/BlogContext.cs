using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext
{
    public class BlogContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Album> Albuns { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento schema para PostgreSql
            modelBuilder.HasDefaultSchema("public");


        }
    }
}
