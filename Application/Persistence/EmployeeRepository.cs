using Domain.Entity;
using Infrastructure.Interface;

namespace Generics.Application.Persistence
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(GenericDbContext context) : base(context)
        {
            
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
