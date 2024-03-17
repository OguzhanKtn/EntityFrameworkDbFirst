using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst.Services
{
    public class SupplierService
    {
        NorthwndContext db = new NorthwndContext();
        public void DeleteSupplier(int id)
        {       
            Supplier supplier =  db.Suppliers.Find(id);

            if (supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
            }
        }

        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = db.Suppliers.ToList();
            return suppliers;
        }

        public void UpdateSupplier(Supplier updatedSupplier)
        {
            Supplier supplier = db.Suppliers.Find(updatedSupplier.SupplierId)!;
            supplier.CompanyName = updatedSupplier.CompanyName; 
            supplier.City = updatedSupplier.City;

            db.SaveChanges();
        }
    }
}
