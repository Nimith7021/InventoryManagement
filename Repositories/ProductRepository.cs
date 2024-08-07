using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    internal class ProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public List<Product> DisplayProductDB()
        {
            return _context.Products.ToList();
        }

        public void AddProductDB(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void RemoveProductDB(int id) { 
            var productToDelete = _context.Products.
                Where(product=>product.ProductId==id).FirstOrDefault();
            if (productToDelete != null) {

                _context.Remove(productToDelete);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Employee exist");
            }
            
        }

        public void UpdateDetails(string name,int id)
        {
            var findProduct = _context.Products.Where(product => product.ProductId == id).FirstOrDefault();
            findProduct.ProductName = name;
            _context.Products.Update(findProduct);
            _context.SaveChanges();
        }

        public Product ProductDetails(int id)
        {
            var product = _context.Products.
                Where(product => product.ProductId == id).FirstOrDefault();
            return product;
        }
    }
}
