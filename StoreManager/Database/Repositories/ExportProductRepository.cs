using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Database.Repositories
{
    internal class ExportProductRepository
    {
        private StoreManagerDBEntities StoreManagerDB = new StoreManagerDBEntities();

        public List<CategoriesTabel> GetAllCategories()
        {
            return StoreManagerDB.CategoriesTabels.ToList();
        }

        public List<ProductsTabel> GetAllProducts()
        {
            return StoreManagerDB.ProductsTabels.ToList();
        }

        public List<ProductsTabel> GetProductsByCategory(int categoryId)
        {
            return StoreManagerDB.ProductsTabels
                                 .Where(x => x.CategoryId == categoryId)
                                 .ToList();
        }

        public CategoriesTabel GetCategoryById(int categoryId)
        {
            return StoreManagerDB.CategoriesTabels.FirstOrDefault(c => c.Id == categoryId);
        }

        public CustomersTabel GetCustomerByPhoneOrEmail(string search)
        {
            return StoreManagerDB.CustomersTabels
                                 .FirstOrDefault(c => c.PhoneNumber == search || c.Email == search);
        }

        public ProductsTabel GetProductById(int id)
        {
            return StoreManagerDB.ProductsTabels.FirstOrDefault(p => p.Id == id);
        }

        public void AddSalesBill(SalesBillTabel bill)
        {
            StoreManagerDB.SalesBillTabels.Add(bill);
            StoreManagerDB.SaveChanges();
        }

        public void UpdateProductQuantity(ProductsTabel product, int newQuantity)
        {
            product.Quantity = newQuantity;
        }

        public void SaveChanges()
        {
            StoreManagerDB.SaveChanges();
        }
    }
}