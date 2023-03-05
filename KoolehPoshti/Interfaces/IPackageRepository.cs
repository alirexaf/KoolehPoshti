using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetAllAsync();
        Task<Package> GetByIdAsync(Guid packageId);
        Task AddAsync(Package package); 
        void Update(Package package); 
        void Delete(Package package);
    }
}
