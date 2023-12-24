using ExternalCoupling;

Product product = new()
{
    Id = 1,
    Name = "Bag",
    Weight = 1.3,
};
string zipCode = "45795350";
ProductController productController = new();
productController.CalculteShippingCost(product, zipCode);
