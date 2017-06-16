using Dapper;
using Practica1.Models;
using System.Data.SqlClient;

namespace Practica1.Repositories.Sales.Dapper
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(string connectionString) : base(connectionString)
        {

        }

       

        public Product SearchByName(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@name", name);
                return connection.QueryFirst<Product>("dbo.SearchByName",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
    }
}
