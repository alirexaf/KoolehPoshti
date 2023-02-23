using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetPackages();
        Task<Package> GetPackage(int packageId);
        Task<Package> AddPackage(Package package);
        Task<Package> UpdatePackage(Package package);
        void DeletePackage(int packageId);
    }
}
