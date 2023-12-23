using StampCoupling;

Product product1 = new()
{
    Id = 1,
    Name = "Bag",
    Quantity = 0,
};
Product product2 = new()
{
    Id = 2,
    Name = "T-shirt",
    Quantity = 55,
};

SalesService salesService = new();
salesService.SellProduct(product1);
salesService.SellProduct(product2);
