using Microsoft.EntityFrameworkCore;
using Registry.Domain;
using System.Collections;

namespace Registry.Data
{
    public class RegistryRepository : IRegistryRepository
    {
        private readonly RegistryDbContext _db;
        private readonly DbSet<UserData> _dbSet;
        public RegistryRepository(RegistryDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<UserData>();
        }

        public async Task AddAsync(UserData userData)
        {
           await _dbSet.AddAsync(userData);
           await _db.SaveChangesAsync();
        }

   

        public async Task<IEnumerable> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<List<UserData>> GetByIdAsync(int id)
        {
            return await _dbSet.ToListAsync();
        }

       
    }
}
