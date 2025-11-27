using System.Reflection;
using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        if (!context.Products.Any())
        {
            var productData = await File
                .ReadAllTextAsync(path + @"/Data/SeedData/products.json");

            var products = JsonSerializer.Deserialize<List<Product>>(productData);

            if (products == null) return;

            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }

        if (!context.ShippingMethods.Any())
        {
            var shippingData = await File
                .ReadAllTextAsync(path + "/Data/SeedData/delivery.json");

            var methods = JsonSerializer.Deserialize<List<ShippingMethod>>(shippingData);

            if (methods == null) return;

            context.ShippingMethods.AddRange(methods);

            await context.SaveChangesAsync();
        }

    }
}
