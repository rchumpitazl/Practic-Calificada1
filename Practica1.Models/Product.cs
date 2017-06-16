using Dapper.Contrib.Extensions;

namespace Practica1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
}
