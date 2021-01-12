using System.Data.Entity;

namespace Vidly.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Categories { get; set; } 
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
