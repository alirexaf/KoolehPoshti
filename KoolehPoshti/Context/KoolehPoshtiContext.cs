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
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageCategory> PackageCategories { get; set; }
        public DbSet<PackageImage> PackageImages { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Requester> Requesters { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
    }
}
