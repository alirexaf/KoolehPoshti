using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IPackageImageRepository
    {
        Task<IEnumerable<PackageImage>> GetPackageImages();
        Task<PackageImage> GetPackageImage(int packageImageId);
        Task<PackageImage> AddPackageImage(PackageImage packageImage);
        Task<PackageImage> UpdatePackageImage(PackageImage packageImage);
        void DeletePackage(int packageImageId);
    }
}
