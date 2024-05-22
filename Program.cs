using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an instance of Products class and initialize it with some Product objects
        Products productCollection = new Products();
        productCollection.AddProduct(new Product { Name = "Laptop", Price = 800 });
        productCollection.AddProduct(new Product { Name = "Smartphone", Price = 600 });
        productCollection.AddProduct(new Product { Name = "Tablet", Price = 300 });
        productCollection.AddProduct(new Product { Name = "Headphones", Price = 50 });

        // Project the list to create a new list containing names of products with prices > $50
        var expensiveProducts = from product in productCollection.ProductList
                                where product.Price > 50
                                select product.Name;

        // Display the projected names of expensive products
        Console.WriteLine("Names of Expensive Products:");
        foreach (var productName in expensiveProducts)
        {
            Console.WriteLine(productName);
        }
    }
}

// Define a Product class
class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
}

// Define a Products class to manage a collection of Product objects
class Products
{
    public List<Product> ProductList { get; private set; }

    public Products()
    {
        ProductList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        ProductList.Add(product);
    }
}
