using StoreManager.Database;
using System.Collections.Generic;

namespace StoreManager.Classes.BusinessLogic
{
    internal class ImportProductService
    {
        private StoreManager.Database.Repositories.ImportProductRepository _Repository;

        public ImportProductService()
        {
            _Repository = new StoreManager.Database.Repositories.ImportProductRepository();
        }

        public List<CategoriesTabel> GetAllCategories()
        {
            return _Repository.GetAllCategories();
        }

        public SuppliersTabel GetSupplierByPhoneOrEmail(string search)
        {
            return _Repository.GetSupplierByPhoneOrEmail(search);
        }

        public bool ProductCodeExists(string code)
        {
            return _Repository.ProductCodeExists(code);
        }

        public void AddProduct(ProductsTabel product)
        {
            _Repository.AddProduct(product);
        }

        public void UpdateProductImage(ProductsTabel product, string imagePath)
        {
            _Repository.UpdateProductImage(product, imagePath);
        }

        public ProductsTabel GetProductById(int id)
        {
            return _Repository.GetProductById(id);
        }

        public void DeleteProduct(int id)
        {
            _Repository.DeleteProduct(id);
        }

        public bool CategoryExists(string categoryName)
        {
            return _Repository.CategoryExists(categoryName);
        }

        public void AddCategory(CategoriesTabel category)
        {
            _Repository.AddCategory(category);
        }

        public void AddPurchaseBill(PurchaseBillTabel bill)
        {
            _Repository.AddPurchaseBill(bill);
        }

        public void AddPurchaseBillDetail(PurchaseBillDetailsTabel detail)
        {
            _Repository.AddPurchaseBillDetail(detail);
        }

        public void SaveChanges()
        {
            _Repository.SaveChanges();
        }

        public void DeleteProducts(List<int> ids)
        {
            _Repository.DeleteProducts(ids);
        }
    }
}