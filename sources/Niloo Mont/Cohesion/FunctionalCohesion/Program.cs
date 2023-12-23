using FunctionalCohesion;

ProductManagement productManagement = new();
List<Product> products = new()
{
    new Product { Id = 1, Name = "Bag"},
    new Product { Id = 2, Name = "T-shirt"},
    new Product { Id = 3, Name = "Mug"},
    new Product { Id = 4, Name = "Keyboard"}
};
Product newProduct = new()
{
    Id = 5,
    Name = "Pen"
};
productManagement.GetAllProducts(products);
productManagement.AddProduct(products,newProduct);
productManagement.GetAllProducts(products);
productManagement.GetProductById(products, 5);
productManagement.DeleteProductById(products, 5);
productManagement.GetAllProducts(products);
