namespace Control_Coupling;
public class Product
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public ushort Quantity { get; set; } = 0;
}
