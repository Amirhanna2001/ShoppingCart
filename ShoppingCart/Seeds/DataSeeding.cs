using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category fruits = new () { Name = "Fruits", };
                Category shirts = new () { Name = "Shirts", };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Apples",
                            Description = "Juicy apples",
                            Price = 1.50M,
                            Category = fruits,
                            ImagePath = "apples.jpg"
                        },
                        new Product
                        {
                            Name = "Bananas",
                            Description = "Fresh bananas",
                            Price = 3M,
                            Category = fruits,
                            ImagePath = "bananas.jpg"
                        },
                        new Product
                        {
                            Name = "Watermelon",
                            Description = "Juicy watermelon",
                            Price = 0.50M,
                            Category = fruits,
                            ImagePath = "watermelon.jpg"
                        },
                        new Product
                        {
                            Name = "Grapefruit",
                            Description = "Juicy grapefruit",
                            Price = 2M,
                            Category = fruits,
                            ImagePath = "grapefruit.jpg"
                        },
                        new Product
                        {
                            Name = "White shirt",
                            Description = "White shirt",
                            Price = 5.99M,
                            Category = shirts,
                            ImagePath = "white shirt.jpg"
                        },
                        new Product
                        {
                            Name = "Black shirt",
                            Description = "Black shirt",
                            Price = 7.99M,
                            Category = shirts,
                            ImagePath = "black shirt.jpg"
                        },
                        new Product
                        {
                            Name = "Yellow shirt",
                            Description = "Yellow shirt",
                            Price = 11.99M,
                            Category = shirts,
                            ImagePath = "yellow shirt.jpg"
                        },
                        new Product
                        {
                            Name = "Grey shirt",
                            Description = "Grey shirt",
                            Price = 12.99M,
                            Category = shirts,
                            ImagePath = "grey shirt.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}