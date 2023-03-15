using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
    }
}
