using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a value")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
