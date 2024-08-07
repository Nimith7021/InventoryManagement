using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Repo
{
    internal class ProductManagement
    {
        static ProductRepository repository = new ProductRepository(new ProductContext());
        static List<Product> products { get; set; } = new List<Product>();
        public static void AddNewProduct(string name, string description,
           int quantity, double price)
        {
            Product product = Product.CreateProduct(name, description,
                quantity, price);
            products.Add(product);
            repository.AddProductDB(product);
        }



        public static Product FindProduct(int id)
        {
            Product findProduct = null;
            foreach (Product product in products)
            {
                if (product.ProductId == id)
                    findProduct = product;
            }
            return findProduct;

        }

        public static List<Product> DisplayAllProducts()
        {
            var products = repository.DisplayProductDB();
            return products;
        }

        public static void UpdateProductDetails(int id, string name)
        {
            
            repository.UpdateDetails(name,id);
            
        }

        public static Product ProductDetails(int id)
        {
           return repository.ProductDetails(id);
        }

        public static void DeleteProduct(int id)
        {
            repository.RemoveProductDB(id);
        }
    }
}
