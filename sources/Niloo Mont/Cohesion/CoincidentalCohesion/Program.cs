using CoincidentalCohesion;
using Dumpify;

Product product1 = new Product(1, "Laptop", 1200.00);
Product product2 = new Product(2, "Phone", 800.00);

"Product Details:".Dump();
product1.Dump();
product2.Dump();

Order order = new Order(1001);
order.AddProduct(product1);
order.AddProduct(product2);

Console.WriteLine("Order Details:");
order.DisplayOrderDetails();
