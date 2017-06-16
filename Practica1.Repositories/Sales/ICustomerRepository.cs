using Practica1.Models;

namespace Practica1.Repositories.Sales
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer SearchByFirstName(string firstname);
    }
}
