using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class RequestRepository:IRequestRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public RequestRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Request>> GetAllAsync()
        {
            return await _dbContext.Requests.ToListAsync();
        }

        public async Task<Request> GetByIdAsync(Guid id)
        {
            return await _dbContext.Requests.FindAsync(id);
        }

        public async Task AddAsync(Request request)
        {
            await _dbContext.Requests.AddAsync(request);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(Request request)
        {
            _dbContext.Requests.Update(request);
            _dbContext.SaveChanges();
        }

        public void Delete(Request request)
        {
            _dbContext.Requests.Remove(request);
            _dbContext.SaveChanges();
        }
    }
}
