using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IPackageCategoryRepository
    {
        Task<IEnumerable<PackageCategory>> GetAllAsync();

    }
}
