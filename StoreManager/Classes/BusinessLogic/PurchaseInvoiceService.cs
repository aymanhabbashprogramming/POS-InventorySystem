using StoreManager.Database;

namespace StoreManager.Classes.BusinessLogic
{
    internal class PurchaseInvoiceService
    {
        private StoreManager.Database.Repositories.PurchaseInvoiceRepository _Repository;

        public PurchaseInvoiceService()
        {
            _Repository = new StoreManager.Database.Repositories.PurchaseInvoiceRepository();
        }

        public System.Collections.Generic.List<PurchaseBillTabel> GetAllBills()
        {
            return _Repository.GetAllBills();
        }

        public PurchaseBillTabel GetBillById(int id)
        {
            return _Repository.GetBillById(id);
        }

        public void DeleteBill(int billId)
        {
            var bill = _Repository.GetBillById(billId);
            if (bill != null)
            {
                _Repository.DeleteBillDetails(billId);
                _Repository.DeleteBill(bill);
            }
        }
    }
}