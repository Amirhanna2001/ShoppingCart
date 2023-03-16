using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
