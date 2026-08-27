public static class ProductService
{
    private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
        new Product { Id = 2, Name = "Phone", Price = 499.99m, Category = "Electronics" }
    };

    public static List<Product> GetAll() => Products;

    public static Product Insert(Product product)
    {
        product.Id = Products.Count + 1;
        Products.Add(product);
        return product;
    }
}