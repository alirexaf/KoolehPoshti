using System;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Context;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public PackageRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Package>> GetAllAsync()
        {
            return await _dbContext.Packages.ToListAsync();
        }

        public async Task<Package> GetByIdAsync(Guid id)
        {
            return await _dbContext.Packages.FindAsync(id);
        }

        public async Task AddAsync(Package package)
        {
            await _dbContext.Packages.AddAsync(package);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(Package package)
        {
            _dbContext.Packages.Update(package);
            _dbContext.SaveChanges();
        }

        public void Delete(Package package)
        {
            _dbContext.Packages.Remove(package);
            _dbContext.SaveChanges();
        }
    }
}
