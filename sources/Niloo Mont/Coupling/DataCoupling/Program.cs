using DataCoupling;

string iranIp = "Iran";
string nonIranIp = "non-Iran";

ProductController productController = new();
Framework framework = new();
framework.Authentication(iranIp,
    (context) => framework.ExceptionHandling(iranIp,
    productController.GetAllProducts));

framework.Authentication(nonIranIp,
    (context) => framework.ExceptionHandling(nonIranIp,
    productController.GetAllProducts));