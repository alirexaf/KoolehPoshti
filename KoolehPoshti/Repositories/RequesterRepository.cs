using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{

    public class RequesterRepository : IRequesterRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public RequesterRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Requester>> GetAllAsync()
        {
            return await _dbContext.Requesters.ToListAsync();
        }

        public async Task<Requester> GetByIdAsync(Guid id)
        {
            return await _dbContext.Requesters.FindAsync(id);
        }

        public async Task AddAsync(Requester requester)
        {
            await _dbContext.Requesters.AddAsync(requester);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(Requester requester)
        {
            _dbContext.Requesters.Update(requester);
            _dbContext.SaveChanges();
        }

        public void Delete(Requester requester)
        {
            _dbContext.Requesters.Remove(requester);
            _dbContext.SaveChanges();
        }
    }
}
