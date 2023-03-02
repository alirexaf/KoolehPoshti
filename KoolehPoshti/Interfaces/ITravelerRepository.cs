using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface ITravelerRepository
    {
        Task<IEnumerable<Traveler>> GetAllAsync();
        Task<Traveler> GetByIdAsync(int travelerId);
        Task AddAsync(Traveler traveler);
        void Update(Traveler traveler);
        void Delete(Traveler traveler);
    }
}
