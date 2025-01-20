using Registry.Domain;
using System.Collections;

namespace Registry.Services
{
    public interface IRegistryService
    {
        public Task<IEnumerable> GetAllUserAsync();

        public Task<List<UserData>> GetUserByIDAsync(int id);

        public Task AddUserAsync(UserData user);
    }
}
