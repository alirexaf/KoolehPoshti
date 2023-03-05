using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class PackageImageRepository:IPackageImageRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public PackageImageRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PackageImage>> GetAllAsync()
        {
            return await _dbContext.PackageImages.ToListAsync();
        }

        public async Task<PackageImage> GetByIdAsync(Guid id)
        {
            return await _dbContext.PackageImages.FindAsync(id);
        }
        public async Task<IEnumerable<PackageImage>> GetByPackageIdAsync(Guid packageId)
        {
            return await _dbContext.PackageImages.Where(p => p.PackageId == packageId).ToListAsync();
        }

        public async Task AddAsync(PackageImage packageImage)
        {
            await _dbContext.PackageImages.AddAsync(packageImage);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(PackageImage packageImage)
        {
            _dbContext.PackageImages.Update(packageImage);
            _dbContext.SaveChanges();
        }

        public void Delete(PackageImage packageImage)
        {
            _dbContext.PackageImages.Remove(packageImage);
            _dbContext.SaveChanges();
        }
    }
}
