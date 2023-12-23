namespace ExternalCoupling;
public interface IShippingService
{
    public void CalculateShippingCost(double weight, string zipCode);
}
