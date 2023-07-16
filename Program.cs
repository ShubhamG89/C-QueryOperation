namespace product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
       
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }

    class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            Console.WriteLine("Product Details:");

            // Create operation
            Product newProduct = new Product { ProductId = 1, ProductName = "Phone", Price = 18000 };
            CreateProduct(newProduct);

            // Update operation
            UpdateProduct(1, "Smartphone", 1299.99M);

            // Delete operation
            DeleteProduct(1);

            Console.ReadLine();
        }

        static void CreateProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product created successfully.");
        }

        static void UpdateProduct(int productId, string newProductName, decimal newPrice)
        {
            Product productToUpdate = products.Find(p => p.ProductId == productId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = newProductName;
                productToUpdate.Price = newPrice;
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void DeleteProduct(int productId)
        {
            Product productToDelete = products.Find(p => p.ProductId == productId);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }

}