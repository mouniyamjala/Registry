using Microsoft.EntityFrameworkCore;
using Registry.Domain;
namespace Registry.Data
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) 
        {
            
        }

        public DbSet<UserData> UserData { get; set; }

    }
}

