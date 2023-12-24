namespace StampCoupling;
public class OutOfStockException : ApplicationException
{
    public OutOfStockException(string name) :
        base($"Product {name} is out of stock!")
    {        
    }
}
