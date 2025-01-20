using Registry.Domain;
using Registry.Data;
using System.Collections;

namespace Registry.Services
{
    public class RegistryService : IRegistryService
    {
        private readonly IRegistryRepository _registryrepository;

        public RegistryService(IRegistryRepository registryrepository)
        {
            _registryrepository = registryrepository;
        }

        public async Task AddUserAsync(UserData user)
        {
            await _registryrepository.AddAsync(user);
        }

        public async Task<IEnumerable> GetAllUserAsync()
        {
          var a = await _registryrepository.GetAllAsync();
          return a;
        }

        public async Task<List<UserData>> GetUserByIDAsync(int id)
        {
            return await _registryrepository.GetByIdAsync(id);
        }
    }
}
