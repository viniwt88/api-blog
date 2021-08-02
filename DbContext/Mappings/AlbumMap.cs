using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace blogApi.DbContext.Mappings
{
    public class AlbumMap
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .ToTable("albuns")
                .HasKey(a => a.AlbumId);

            modelBuilder.Entity<Album>()
                .Property(a => a.AlbumId)
                .HasColumnName("album_id");
            
            modelBuilder.Entity<Album>()
                .Property(a => a.AlbumName)
                .HasColumnName("album_name");

            modelBuilder.Entity<Album>()
                .Property(a => a.AlbumCreatedIn)
                .HasColumnName("album_date");

            // neste caso, considerar que 1 foto pode estar somente  em 1 album, e 1 album pode ter n fotos
            modelBuilder.Entity<Photo>()
                .HasOne(a => a.Album)
                .WithMany(p => p.Photos)
                .HasForeignKey(p => p.AlbumId);
        }
    }
}
