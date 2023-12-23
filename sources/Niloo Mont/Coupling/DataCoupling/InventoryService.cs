namespace DataCoupling;
public class InventoryService
{
    public void AddToQuantity(Product product)
    {
        $"Increased quantity of {product.Name} by 1".Dump();
    }
}
