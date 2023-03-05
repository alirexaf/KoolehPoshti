using KoolehPoshti.Context;
using KoolehPoshti.Interfaces;
using KoolehPoshti.Models;
using Microsoft.EntityFrameworkCore;

namespace KoolehPoshti.Repositories
{
    public class TravelerRepository:ITravelerRepository
    {
        private readonly KoolehPoshtiContext _dbContext;

        public TravelerRepository(KoolehPoshtiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Traveler>> GetAllAsync()
        {
            return await _dbContext.Travelers.ToListAsync();
        }

        public async Task<Traveler> GetByIdAsync(Guid id)
        {
            return await _dbContext.Travelers.FindAsync(id);
        }

        public async Task AddAsync(Traveler traveler)
        {
            await _dbContext.Travelers.AddAsync(traveler);
            await _dbContext.SaveChangesAsync();
        }

        public void Update(Traveler traveler)
        {
            _dbContext.Travelers.Update(traveler);
            _dbContext.SaveChanges();
        }

        public void Delete(Traveler traveler)
        {
            _dbContext.Travelers.Remove(traveler);
            _dbContext.SaveChanges();
        }
    }
}
