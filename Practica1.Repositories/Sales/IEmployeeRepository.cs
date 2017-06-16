using Practica1.Models;

namespace Practica1.Repositories.Sales
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee SearchByLastName(string lastname);
    }
}
