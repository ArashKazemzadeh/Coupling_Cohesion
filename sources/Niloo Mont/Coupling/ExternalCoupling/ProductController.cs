namespace ExternalCoupling;

public class ProductController
{
    IShippingService shippingService = new CompanyAShippingService();
    public void CalculteShippingCost(Product product, string zipCode)
    {
        shippingService.CalculateShippingCost(product.Weight, zipCode);
    }
}
