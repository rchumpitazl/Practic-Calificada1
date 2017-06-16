using Practica1.Models;

namespace Practica1.Repositories.Sales
{
    public interface IProductRepository : IRepository<Product>
    {
        Product SearchByName(string name);
    }
}
