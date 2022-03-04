using Microsoft.EntityFrameworkCore;

namespace CoffeeShopRegistration.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\sqlexpress; Database=CoffeeShop;Integrated Security=SSPI;");
        }

    }
}
