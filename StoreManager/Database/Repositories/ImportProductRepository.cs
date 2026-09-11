using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Database.Repositories
{
    internal class ImportProductRepository
    {
        private StoreManagerDBEntities storeManagerDB = new StoreManagerDBEntities();

        public List<CategoriesTabel> GetAllCategories()
        {
            return storeManagerDB.CategoriesTabels.ToList();
        }

        public SuppliersTabel GetSupplierByPhoneOrEmail(string search)
        {
            return storeManagerDB.SuppliersTabels
                                 .FirstOrDefault(s => s.PhoneNumber == search || s.Email == search);
        }

        public bool ProductCodeExists(string code)
        {
            return storeManagerDB.ProductsTabels.Any(p => p.Code == code);
        }

        public void AddProduct(ProductsTabel product)
        {
            storeManagerDB.ProductsTabels.Add(product);
            storeManagerDB.SaveChanges();
        }

        public void UpdateProductImage(ProductsTabel product, string imagePath)
        {
            product.Image = imagePath;
            storeManagerDB.SaveChanges();
        }

        public ProductsTabel GetProductById(int id)
        {
            return storeManagerDB.ProductsTabels.FirstOrDefault(p => p.Id == id);
        }

        public void DeleteProduct(int id)
        {
            var product = storeManagerDB.ProductsTabels.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                storeManagerDB.ProductsTabels.Remove(product);
                storeManagerDB.SaveChanges();
            }
        }

        public bool CategoryExists(string categoryName)
        {
            return storeManagerDB.CategoriesTabels.Any(c => c.CategoryName == categoryName);
        }

        public void AddCategory(CategoriesTabel category)
        {
            storeManagerDB.CategoriesTabels.Add(category);
            storeManagerDB.SaveChanges();
        }

        public void AddPurchaseBill(PurchaseBillTabel bill)
        {
            storeManagerDB.PurchaseBillTabels.Add(bill);
            storeManagerDB.SaveChanges();
        }

        public void AddPurchaseBillDetail(PurchaseBillDetailsTabel detail)
        {
            storeManagerDB.PurchaseBillDetailsTabels.Add(detail);
        }

        public void SaveChanges()
        {
            storeManagerDB.SaveChanges();
        }

        public void DeleteProducts(List<int> ids)
        {
            var products = storeManagerDB.ProductsTabels.Where(p => ids.Contains(p.Id)).ToList();
            foreach (var p in products)
                storeManagerDB.ProductsTabels.Remove(p);
            storeManagerDB.SaveChanges();
        }
    }
}