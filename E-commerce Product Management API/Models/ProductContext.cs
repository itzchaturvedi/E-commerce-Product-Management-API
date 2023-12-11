using Microsoft.EntityFrameworkCore;

namespace E_commerce_Product_Management_API.Models
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; } = null!;
    }
}
