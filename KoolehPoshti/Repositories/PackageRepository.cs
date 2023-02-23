using System;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Context;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private readonly KoolehPoshtiContext _appDbContext;

        public PackageRepository(KoolehPoshtiContext appDbContext)
        {

            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Package>> GetPackages()
        {
            return await _appDbContext.Packages.ToListAsync();
        }

        public async Task<Package> GetPackage(int packageId)
        {
            return await _appDbContext.Packages
                .FirstOrDefaultAsync(p => p.Id == packageId);
        }

        public async Task<Package> AddPackage(Package package)
        {
            var result = await _appDbContext.Packages.AddAsync(package);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Package> UpdatePackage(Package package)
        {
            var result = await _appDbContext.Packages
                .FirstOrDefaultAsync(p => p.Id == package.Id);

            if (result != null)
            {
                result.Title = package.Title;
                result.Weight = package.Weight;
                result.Dimension = package.Dimension;
                result.Category = package.Category;
                result.Images = package.Images;
                result.IsVisible = package.IsVisible;

                await _appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeletePackage(int packageId)
        {
            var result = await _appDbContext.Packages
                .FirstOrDefaultAsync(p => p.Id == packageId);
            if (result != null)
            {
                _appDbContext.Packages.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
