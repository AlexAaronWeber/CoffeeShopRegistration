using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        
        public double Price { get; set; }

        [StringLength(50)]
        public string Category { get; set; }
    }
}
