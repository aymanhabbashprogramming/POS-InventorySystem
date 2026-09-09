using StoreManager.Database;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Database.Repositories
{
    internal class ListAndDeleteProductRepository
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
        public ProductsTabel SearchProduct(string search)
        {
            return StoreManagerDB.ProductsTabels
                                 .FirstOrDefault(x => x.Id.ToString() == search ||
                                                      x.Code == search);
        }
        public ProductsTabel GetProductById(int productId)
        {
            return StoreManagerDB.ProductsTabels
                                 .FirstOrDefault(x => x.Id == productId);
        }
        public void DeleteProductPurchaseDetails(int productId)
        {
            var details = StoreManagerDB.PurchaseBillDetailsTabels
                                        .Where(d => d.ProductID == productId)
                                        .ToList();

            foreach (var detail in details)
                StoreManagerDB.PurchaseBillDetailsTabels.Remove(detail);
        }
        public void DeleteProduct(ProductsTabel product)
        {
            StoreManagerDB.ProductsTabels.Remove(product);
            StoreManagerDB.SaveChanges();
        }
    }
}