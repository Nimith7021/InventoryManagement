using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    internal class SupplierRepository
    {
        private readonly SupplierContext _context;
        public SupplierRepository(SupplierContext context)
        {
            _context = context;
        }

        public List<Supplier> DisplaySupplierDB()
        {
            return _context.Suppliers.ToList();
        }

        public void AddSupplierDB(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void RemoveSupplierDB(int id)
        {
            var productToDelete = _context.Suppliers.
                Where(product => product.SupplierID == id).FirstOrDefault();
            if (productToDelete != null)
            {

                _context.Remove(productToDelete);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Employee exist");
            }

        }

        public  void UpdateDetails(int id , string name , string contact)
        {
            var findSupplier = _context.Suppliers.Where(product => product.SupplierID == id).FirstOrDefault();
            findSupplier.Name = name;
            findSupplier.ContactNumber = contact;
            _context.Suppliers.Update(findSupplier);
            _context.SaveChanges();
        }

        public Supplier SupplierDetails(int id)
        {
            var supplier = _context.Suppliers.
                Where(supplier => supplier.SupplierID == id).FirstOrDefault();
            return supplier;
        }
    }
}
