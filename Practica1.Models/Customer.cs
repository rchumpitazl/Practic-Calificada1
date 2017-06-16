using Dapper.Contrib.Extensions;

namespace Practica1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleInitial { get; set; }
        

    }
}
