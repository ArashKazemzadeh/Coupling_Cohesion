using Control_Coupling;

bool isAdmin = true;
ProductController productController = new();
productController.ShowListOfProducts(isAdmin);

isAdmin = false;
productController.ShowListOfProducts(isAdmin);
