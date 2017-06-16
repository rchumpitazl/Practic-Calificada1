using Dapper;
using Practica1.Models;
using System.Data.SqlClient;

namespace Practica1.Repositories.Sales.Dapper
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public CustomerRepository(string connectionString) : base(connectionString)
        {

        }

        public Customer SearchByFirstName(string firstname)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@firstname", firstname);
                return connection.QueryFirst<Customer>("dbo.SearchByFirstName",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }

        
    }
}
