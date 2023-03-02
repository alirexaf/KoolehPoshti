using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class PackageCategoryRepository:IPackageCategoryRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public PackageCategoryRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PackageCategory>> GetAllAsync()
        {
            return await _dbContext.PackageCategories.ToListAsync();
        }
    }
}
