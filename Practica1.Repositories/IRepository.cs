using System.Collections.Generic;

namespace Practica1.Repositories
{
    public interface IRepository<T> where T:class
    {
        bool Delete(T entity);
        int Insert(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetEntityById(int id);
    }
}
