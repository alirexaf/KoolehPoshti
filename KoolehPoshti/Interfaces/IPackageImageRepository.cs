using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IPackageImageRepository
    {
        Task<IEnumerable<PackageImage>> GetAllAsync();
        Task<PackageImage> GetByIdAsync(Guid packageImageId);
        Task<IEnumerable<PackageImage>> GetByPackageIdAsync(Guid packageId);
        Task AddAsync(PackageImage packageImage); 
        void Update(PackageImage packageImage); 
        void Delete(PackageImage packageImage);
    }
}
