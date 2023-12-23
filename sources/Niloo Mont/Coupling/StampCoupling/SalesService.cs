namespace StampCoupling;
public class SalesService
{
    public void CheckQuantity(Product product)
    {
        if (product.Quantity <= 0) throw new OutOfStockException(product.Name);
        $"We have enough {product.Name}s".Dump();
    }
    public void SellProduct(Product product)
    {
        try
        {
            CheckQuantity(product);
            $"Decreased quantity of {product.Name} by 1".Dump();
        }
        catch (OutOfStockException ex)
        {
            ex.Message.Dump();
        }
    }
}
