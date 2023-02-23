using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface ITravelerRepository
    {
        Task<IEnumerable<Traveler>> GetTravelerss();
        Task<Traveler> GetTraveler(int travelerId);
        Task<Traveler> AddTraveler(Traveler traveler);
        Task<Traveler> UpdateTraveler(Traveler traveler);
        void DeleteTraveler(int travelerId);
    }
}
