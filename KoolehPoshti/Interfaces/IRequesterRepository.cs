using KoolehPoshti.Models;

namespace KoolehPoshti.Interfaces
{
    public interface IRequesterRepository
    {
        Task<IEnumerable<Requester>> GetRequesters();
        Task<Requester> GetRequester(int requesterId);
        Task<Requester> AddRequester(Requester requester);
        Task<Requester> UpdateRequester(Requester requester);
        void DeleteRequester(int requesterId);
    }
}
