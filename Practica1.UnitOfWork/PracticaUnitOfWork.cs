using Practica1.Models;
using Practica1.Repositories;
using Practica1.Repositories.Sales;
using Practica1.Repositories.Sales.Dapper;

namespace Practica1.UnitOfWork
{
    public class PracticaUnitOfWork: IUnitOfWork
    {
        public PracticaUnitOfWork(string connectionString)
        {
            Customers = new CustomerRepository(connectionString);
            Sales = new Repository<Sale>(connectionString);
            Employees = new EmployeeRepository(connectionString);
            Products = new ProductRepository(connectionString);
        }
        public ICustomerRepository Customers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IRepository<Sale> Sales { get; private set; }
        public IProductRepository Products { get; private set; }
        
    }
}
