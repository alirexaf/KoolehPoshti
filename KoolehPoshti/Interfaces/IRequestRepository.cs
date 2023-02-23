using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IRequestRepository
    {
        Task<IEnumerable<Request>> GetRequests();
        Task<Request> GetRequest(int employeeId);
        Task<Request> AddRequest(Request request);
        Task<Request> UpdateRequest(Request request);
        void DeleteRequest(int requestId);
    }
}
