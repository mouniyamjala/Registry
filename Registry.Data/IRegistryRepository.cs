using Registry.Domain;
using System.Collections;


namespace Registry.Data
{
    public interface IRegistryRepository 
    {
        public Task<IEnumerable> GetAllAsync();
        public Task<List<UserData>> GetByIdAsync(int id);

        public Task AddAsync(UserData userData);

        //public Task UpdateAsync(Task entity);
        //public Task DeleteAsync(int id);


    }
}
