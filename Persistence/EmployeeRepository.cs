using Generics.Core.Entity;
using Generics.Interface;

namespace Generics.Persistence
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
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
