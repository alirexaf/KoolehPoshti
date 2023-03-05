using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Context
{
    public class KoolehPoshtiContext : DbContext
    {
        public KoolehPoshtiContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>()
                   .HasOne(r => r.Requester)
                   .WithMany(r => r.Requests)
                   .HasForeignKey(r => r.RequesterId)
                   .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Request>()
                    .HasOne(r => r.Traveler)
                    .WithMany(t => t.Requests)
                    .HasForeignKey(r => r.TravelerId)
                    .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Request>()
                                .HasOne(r => r.Package)
                                .WithOne(t => t.Request)
                                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Package>()
                                 .HasOne(p => p.Category)
                                 .WithMany(c => c.Packages)
                                 .HasForeignKey(p => p.PackageCategoryId)
                                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PackageImage>()
                                 .HasOne(p => p.Package)
                                 .WithMany(c => c.Images)
                                 .HasForeignKey(p => p.PackageId)
                                 .OnDelete(DeleteBehavior.Restrict);

            var categoryId1 = Guid.NewGuid();
            modelBuilder.Entity<PackageCategory>().HasData(
                            new PackageCategory
                            {
                                Id = categoryId1,
                                Name = "One",
                                Title = "یک"
                            }
                        );

            modelBuilder.Entity<Package>().HasData(
                new Package
                {
                    Id = Guid.NewGuid(),
                    Title = "First Package",
                    IsVisible= true,
                    PackageCategoryId = categoryId1
                }
            );
        }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageCategory> PackageCategories { get; set; }
        public DbSet<PackageImage> PackageImages { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Requester> Requesters { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
    }
}
