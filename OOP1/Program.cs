using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product {
                Id = 1, CategoryId = 2, ProductName = "Olta Takımı",
                UnitPrice = 450, UnitsInStock = 3
            };

            Product product2 = new Product {
                Id = 2, CategoryId = 3, 
                ProductName = "Misina", UnitPrice = 100, UnitsInStock = 4 
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
