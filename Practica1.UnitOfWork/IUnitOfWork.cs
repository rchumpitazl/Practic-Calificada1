using Practica1.Models;
using Practica1.Repositories;
using Practica1.Repositories.Sales;

namespace Practica1.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IEmployeeRepository Employees { get; }
        IRepository<Sale> Sales { get; }
        IProductRepository Products { get; }
    }
}
