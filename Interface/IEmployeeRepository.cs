using Generics.Core.Entity;

namespace Generics.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
    }
}