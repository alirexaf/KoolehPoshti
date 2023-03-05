using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IRequesterRepository
    {
        Task<IEnumerable<Requester>> GetAllAsync();
        Task<Requester> GetByIdAsync(Guid requesterId);
        Task AddAsync(Requester requester); 
        void Update(Requester requester); 
        void Delete(Requester requester);
    }
}
