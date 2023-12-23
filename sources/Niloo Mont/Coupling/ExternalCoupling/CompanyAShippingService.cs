namespace ExternalCoupling;
public class CompanyAShippingService : IShippingService
{
    public void CalculateShippingCost(double weight, string zipCode)
    {
        $"Shipping cost for this product to {zipCode} is x dollars".Dump();
    }
}
