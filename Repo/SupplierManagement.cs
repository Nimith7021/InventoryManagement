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
    internal class SupplierManagement
    {
        static SupplierRepository repository = new SupplierRepository(new SupplierContext());
        public static void AddNewSupplier(string name , string contact)
        {
            Supplier product = Supplier.CreateSupplier(name,contact);
            repository.AddSupplierDB(product);
        }



        

        public static List<Supplier> DisplayAllSuppliers()
        {
            var suppliers = repository.DisplaySupplierDB();
            return suppliers;
        }

        public static void UpdateSupplierDetails(int id, string name,string contact)
        {

            repository.UpdateDetails(id,name,contact);

        }

        public static Supplier SupplierDetails(int id)
        {
            return repository.SupplierDetails(id);
        }

        public static void DeleteSupplier(int id)
        {
            repository.RemoveSupplierDB(id);
        }
    }
}
