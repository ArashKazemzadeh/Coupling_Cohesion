using StampCoupling;

Product product1 = new()
{
    Id = 1,
    Name = "Bag",
    Quantity = 0,
};
Product product = new()
{
    Id = 1,
    Name = "T-shirt",
    Quantity = 55,
};

SalesService salesService = new();
salesService.SellProduct(product);
