using StoreManager.Database;
using StoreManager.Database.Repositories;
using System.Collections.Generic;

namespace StoreManager.Classes.BusinessLogic
{
    internal class ListAndDeleteProductService
    {
        private ListAndDeleteProductRepository _Repository;

        public ListAndDeleteProductService()
        {
            _Repository = new ListAndDeleteProductRepository();
        }

        public List<CategoriesTabel> GetAllCategories()
        {
            return _Repository.GetAllCategories();
        }
        public List<ProductsTabel> GetAllProducts()
        {
            return _Repository.GetAllProducts();
        }
        public List<ProductsTabel> GetProductsByCategory(int categoryId)
        {
            return _Repository.GetProductsByCategory(categoryId);
        }

        public ProductsTabel SearchProduct(string search)
        {
            return _Repository.SearchProduct(search);
        }

        public ProductsTabel GetProductById(int productId)
        {
            return _Repository.GetProductById(productId);
        }

        public void DeleteProductPurchaseDetails(int productId)
        {
            _Repository.DeleteProductPurchaseDetails(productId);
        }

        public void DeleteProduct(ProductsTabel product)
        {
            _Repository.DeleteProduct(product);
        }
    }
}