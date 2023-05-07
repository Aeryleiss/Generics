using Generics.Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entity
{
    public class GenericDbContext : DbContext, IGenericDbContext
    {
        public GenericDbContext(DbContextOptions<GenericDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
