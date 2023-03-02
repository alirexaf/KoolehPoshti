using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IRequestRepository
    {
        Task<IEnumerable<Request>> GetAllAsync();
        Task<Request> GetByIdAsync(int employeeId);
        Task AddAsync(Request request);
        void Update(Request request);
        void Delete(Request request);
    }
}
