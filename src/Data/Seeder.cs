using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiEnsayoNuevo.src.Models;

namespace apiEnsayoNuevo.src.Data
{
    public static class Seeder
    {
        public static async Task Seed(ApplicationDBContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            var Category = new string[] { "POLERAS", "PANTALONES", "SOMBREROS" };
            var random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                var product = new Product
                {
                    Code = $"CODE{i}",
                    Name = $"Product {i}",
                    Category = Category[random.Next(0, Category.Length)],
                    Stock = random.Next(1, 99)
                };

                await context.Products.AddAsync(product);
            }

            await context.SaveChangesAsync();

        }
    }
}