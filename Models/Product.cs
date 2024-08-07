using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int ProductQuantity { get; set; }

        public double ProductPrice { get; set; }

        public Product(string productName, 
            string productDescription, int productQuantity, double productPrice, int productId=0)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductQuantity = productQuantity;
            ProductPrice = productPrice;
        }

        public override string ToString()
        {
            return $"===========================================================\n" +
                $"Product Id : {ProductId}\n" +
                $"Product Name : {ProductName}\n" +
                $"Product Description : {ProductDescription}\n" +
                $"Product Quantity : {ProductQuantity}\n" +
                $"Product Price : {ProductPrice}\n";
        }

        public static Product CreateProduct(string name, string description , int quantity , double price)
        {
            return new Product(name, description,quantity,price);
        }


    }
}
