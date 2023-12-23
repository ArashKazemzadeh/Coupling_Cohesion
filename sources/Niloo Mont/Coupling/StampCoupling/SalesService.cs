namespace StampCoupling;
public class SalesService
{
    public void SellProduct(Product product)
    {
        $"Decreased quantity of {product.Name} by 1".Dump();
    }
}
