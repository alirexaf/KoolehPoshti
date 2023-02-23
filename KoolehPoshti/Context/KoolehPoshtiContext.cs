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
        DbSet<Package> Packages { get; set; }
        DbSet<PackageCategory> PackageCategories { get; set; }
        DbSet<PackageImage> PackageImages { get; set; }
        DbSet<Request> Requests { get; set; }
        DbSet<Requester> Requesters { get; set; }
        DbSet<Traveler> Travelers { get; set; }
    }
}
