using Dapper;
using Practica1.Models;
using System.Data.SqlClient;

namespace Practica1.Repositories.Sales.Dapper
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(string connectionString) : base(connectionString)
        {

        }

        public Employee SearchByLastName(string lastName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@lastName", lastName);
                return connection.QueryFirst<Employee>("dbo.SearchByLastName",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
    }
}
