using Domain.Entity;

namespace Generics.Domain.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
    }
}