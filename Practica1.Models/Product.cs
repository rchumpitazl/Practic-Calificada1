using Dapper.Contrib.Extensions;

namespace Practica1.Models
{
    public class Product
    {
        [ExplicitKey]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
}
