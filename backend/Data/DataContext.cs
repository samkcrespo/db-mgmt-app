
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<MotionPicture> MotionPictures { get; set; }

        //public virtual DbSet<MotionPicture> MotionPictures { get; set; } = null!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MotionPicture>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasColumnName("id");

        //        entity.Property(e => e.Description)
        //            .HasMaxLength(500)
        //            .HasColumnName("description");

        //        entity.Property(e => e.Name)
        //            .HasMaxLength(50)
        //            .HasColumnName("name");

        //        entity.Property(e => e.ReleaseYear).HasColumnName("releaseYear");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}

    }
}
