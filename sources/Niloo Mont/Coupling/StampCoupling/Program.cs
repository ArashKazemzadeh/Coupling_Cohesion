using StampCoupling;

Product product = new()
{
    Id = 1,
    Name = "Product 1",
    Quantity = 152,
};

InventoryService inventoryService = new();
SalesService salesService = new();

inventoryService.AddToQuantity(product);
salesService.SellProduct(product);
