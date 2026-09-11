using StoreManager.Database;

namespace StoreManager.Classes.BusinessLogic
{
    internal class ExportProductService
    {
        private StoreManager.Database.Repositories.ExportProductRepository _Repository;

        public ExportProductService()
        {
            _Repository = new StoreManager.Database.Repositories.ExportProductRepository();
        }

        public System.Collections.Generic.List<CategoriesTabel> GetAllCategories()
        {
            return _Repository.GetAllCategories();
        }

        public System.Collections.Generic.List<ProductsTabel> GetAllProducts()
        {
            return _Repository.GetAllProducts();
        }

        public System.Collections.Generic.List<ProductsTabel> GetProductsByCategory(int categoryId)
        {
            return _Repository.GetProductsByCategory(categoryId);
        }

        public CategoriesTabel GetCategoryById(int categoryId)
        {
            return _Repository.GetCategoryById(categoryId);
        }

        public CustomersTabel GetCustomerByPhoneOrEmail(string search)
        {
            return _Repository.GetCustomerByPhoneOrEmail(search);
        }

        public ProductsTabel GetProductById(int id)
        {
            return _Repository.GetProductById(id);
        }

        public void AddSalesBill(SalesBillTabel bill)
        {
            _Repository.AddSalesBill(bill);
        }

        public void DecreaseProductQuantity(int productId, int quantityToSubtract)
        {
            var product = _Repository.GetProductById(productId);
            if (product != null)
            {
                _Repository.UpdateProductQuantity(product, product.Quantity - quantityToSubtract);
            }
        }

        public void SaveChanges()
        {
            _Repository.SaveChanges();
        }
    }
}