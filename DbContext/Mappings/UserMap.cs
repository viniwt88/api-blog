using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext.Mappings
{
    public class UserMap
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users")
                .HasKey(u => u.UserId);

            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .HasColumnName("user_id");

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasColumnName("password")
                .HasColumnName("password"); 

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasColumnName("role");

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .HasColumnName("user_name")
                .HasMaxLength(100);

            //relacionamentos
            modelBuilder.Entity<Album>()
                .HasOne(a => a.User)
                .WithMany(u => u.Albuns)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Comment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);
            
            modelBuilder.Entity<Photo>()
                .HasOne(p => p.User)
                .WithMany(u => u.Photos)
                .HasForeignKey(p => p.UserId);

        }
    }
}
