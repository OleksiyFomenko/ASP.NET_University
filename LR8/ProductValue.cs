public static class ProductValue
{
    static List<Product> Products = new List<Product>();

    public static IList<Product> GetProductList() => Products;

    public static bool ProductOrder(Product? product)
    {
        if (product == null)
        {
            return false;
        }
        Products.Add(product);
        return true;
    }

    public static void init()
    {
        Products = new List<Product> {
            new Product("Bag of flour", 30m, DateTime.Today.AddDays(-5)),
            new Product("Water barrel 40 L", 10.49m, DateTime.Today.AddDays(-3)),
            new Product("Cake", 11.99m, DateTime.Today)
        };
    }
}