using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext.Mappings
{
    public class CommentMap
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .ToTable("comments")
                .HasKey(c => c.CommentId);

            modelBuilder.Entity<Comment>()
                .Property(c => c.CommentId)
                .HasColumnName("comment_id");

            modelBuilder.Entity<Comment>()
                .Property(c => c.CommentDate)
                .HasColumnName("comment_date");

            modelBuilder.Entity<Comment>()
                .Property(c => c.Content)
                .HasColumnName("content");
        }
    }
}
