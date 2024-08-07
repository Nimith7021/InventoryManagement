using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    internal class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public Supplier() { }   
        public Supplier(string name , string number,int id=0)
        {
            SupplierID = id;
            Name = name;
            ContactNumber = number;

        }

        public static Supplier CreateSupplier(string name, string number)
        {
            return new Supplier(name,number);
        }

        public override string ToString()
        {
            return $"===================================================\n" +
                $"Supplier Id : {SupplierID}\n" +
                $"Supplier Name : {Name}\n" +
                $"Supplier Contact : {ContactNumber}\n";
        }

    }
}
