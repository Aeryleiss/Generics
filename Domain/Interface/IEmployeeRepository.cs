using Domain.Entity;

namespace Infrastructure.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
    }
}