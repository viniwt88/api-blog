using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext.Mappings
{
    public class PostMap
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .ToTable("posts")
                .HasKey("post_id");

            modelBuilder.Entity<Post>()
                .Property(p => p.PostId)
                .HasColumnName("post_id");

            modelBuilder.Entity<Post>()
                .Property(p => p.Content)
                .HasColumnName("content");

            modelBuilder.Entity<Post>()
                .Property(p => p.PostDate)
                .HasColumnName("post_date");

            modelBuilder.Entity<Post>()
                .Property(p => p.Title)
                .HasColumnName("title");

            modelBuilder.Entity<Post>()
                .Property(p => p.PostId)
                .HasColumnName("post_id");
        }
    }
}
