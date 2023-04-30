using Generics.Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Generics.Core.Entity
{
    public class GenericDbContext : DbContext, IGenericDbContext
    {
        public GenericDbContext(DbContextOptions<GenericDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
