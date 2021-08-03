using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext.Mappings
{
    public class PhotoMap
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .ToTable("photos")
                .HasKey(p  => p.PhotoId);

            modelBuilder.Entity<Photo>()
                .Property(p => p.PhotoId)
                .HasColumnName("photo_id");

            modelBuilder.Entity<Photo>()
                .Property(p => p.Content)
                .HasColumnName("content");

            modelBuilder.Entity<Photo>()
                .Property(p => p.PhotoDate)
                .HasColumnName("photo_date");
        }
    }
}
