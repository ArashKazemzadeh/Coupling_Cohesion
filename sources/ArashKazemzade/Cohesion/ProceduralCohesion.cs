// Example of Procedural Cohesion
// OrderProcessingModule.cs

public class OrderProcessingModule
{
    // Operations grouped based on sequence of execution
    public void ProcessOrder(Order order)
    {
        ValidateOrder(order);
        CalculateTotal(order);
        GenerateInvoice(order);
    }

    private void ValidateOrder(Order order) { /* implementation */ }
    private void CalculateTotal(Order order) { /* implementation */ }
    private void GenerateInvoice(Order order) { /* implementation */ }
}
